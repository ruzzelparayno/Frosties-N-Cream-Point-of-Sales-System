Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Charge
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private originalTotal As Decimal = 0D

    Private Sub Charge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Get PosControl instance from Dashboard
        Dim posForm As PosControl = Dashboard.posInstance

        If posForm Is Nothing Then
            MessageBox.Show("POS screen not found. Please open the POS module first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' ✅ Find lbl_total even if it’s inside nested controls
        Dim lblTotalInPanel As Label = FindLabelRecursive(posForm, "lbl_total")

        If lblTotalInPanel IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(lblTotalInPanel.Text) Then
            Dim cleanValue As String = lblTotalInPanel.Text.Replace("₱", "").Replace(",", "").Trim()
            Decimal.TryParse(cleanValue, originalTotal)
        Else
            originalTotal = 0D
        End If

        lbl_totalpaid.Text = "₱" & originalTotal.ToString("N2")
        txt_cashs.Clear()
        lbl_change.Text = "₱0.00"
        lbl_ref.Hide()
        txt_reference.Hide()
    End Sub

    ' 🔹 Recursive label finder
    Private Function FindLabelRecursive(parent As Control, labelName As String) As Label
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Name = labelName Then
                Return DirectCast(ctrl, Label)
            ElseIf ctrl.HasChildren Then
                Dim found As Label = FindLabelRecursive(ctrl, labelName)
                If found IsNot Nothing Then Return found
            End If
        Next
        Return Nothing
    End Function

    ' ✅ Refresh the total each time the form appears
    Public Sub RefreshTotalPaid()
        cb_employee.Checked = False
        cb_pwd.Checked = False
        cb_senior.Checked = False
        txt_cashs.Clear()
        txt_reference.Clear()
        lbl_change.Text = ""

        Dim subtotal As Decimal = 0D
        Dim posForm As PosControl = Dashboard.posInstance

        If posForm IsNot Nothing Then
            Dim lblTotalInPanel As Label = FindLabelRecursive(posForm, "lbl_total")
            If lblTotalInPanel IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(lblTotalInPanel.Text) Then
                Dim cleanValue As String = lblTotalInPanel.Text.Replace("₱", "").Replace(",", "").Trim()
                Decimal.TryParse(cleanValue, subtotal)
            End If
        End If

        originalTotal = subtotal

        Me.Tag = subtotal
        lbl_totalpaid.Text = "₱" & Math.Round(subtotal, 2).ToString("N2")
    End Sub

    Private Sub rb_gcash_CheckedChanged(sender As Object, e As EventArgs) Handles rb_gcash.CheckedChanged
        lbl_cr.Hide()
        lbl_ref.Show()
        txt_reference.Show()
        txt_cashs.Hide()
        txt_cashs.Clear()
        lbl_change.Text = "₱0.00"
    End Sub

    Private Sub rb_cash_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cash.CheckedChanged
        lbl_ref.Hide()
        lbl_cr.Show()
        txt_reference.Hide()
        txt_cashs.Show()
        txt_reference.Clear()
        lbl_change.Text = "₱0.00"
    End Sub

    Private Sub DiscountChanged(sender As Object, e As EventArgs) Handles cb_employee.CheckedChanged, cb_pwd.CheckedChanged, cb_senior.CheckedChanged
        ApplyDiscount()
    End Sub

    Private Sub ApplyDiscount()
        Dim total As Decimal = originalTotal
        If cb_employee.Checked OrElse cb_pwd.Checked OrElse cb_senior.Checked Then
            total = Math.Round(total * 0.8D, 2)
        End If
        lbl_totalpaid.Text = "₱" & total.ToString("N2")
        CalculateChange()
    End Sub

    Private Sub txt_cashs_TextChanged(sender As Object, e As EventArgs) Handles txt_cashs.TextChanged
        CalculateChange()
    End Sub

    Private Sub CalculateChange()
        Dim cash As Decimal = 0D
        Dim totalPaid As Decimal = 0D

        Decimal.TryParse(txt_cashs.Text.Replace("₱", "").Replace(",", "").Trim(), cash)
        Decimal.TryParse(lbl_totalpaid.Text.Replace("₱", "").Replace(",", "").Trim(), totalPaid)

        Dim change As Decimal = cash - totalPaid

        If change >= 0D Then
            lbl_change.Text = "₱" & change.ToString("N2")
        Else
            lbl_change.Text = "₱0.00"
        End If
    End Sub

    Private Sub btn_charge_Click(sender As Object, e As EventArgs) Handles btn_charge.Click
        Dim cash As Decimal = 0D
        Dim totalPaid As Decimal = 0D
        Dim cashText As String = txt_cashs.Text.Replace("₱", "").Replace(",", "").Trim()

        Decimal.TryParse(lbl_totalpaid.Text.Replace("₱", "").Replace(",", "").Trim(), totalPaid)

        If totalPaid <= 0 Then
            MessageBox.Show("Invalid or missing total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim modeOfPayment As String = ""
        Dim reference As String = txt_reference.Text.Trim()
        Dim posForm As PosControl = Dashboard.posInstance

        If posForm Is Nothing Then
            MessageBox.Show("POS form not found inside Dashboard!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' ✅ PAYMENT MODES VALIDATION
        If rb_cash.Checked Then
            modeOfPayment = "Cash"

            If Not Decimal.TryParse(cashText, cash) Then
                MessageBox.Show("Please enter a valid cash amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cash < totalPaid Then
                MessageBox.Show("Cash is not enough!" & vbCrLf &
                                 "Total: ₱" & totalPaid.ToString("N2") & vbCrLf &
                                 "Cash Entered: ₱" & cash.ToString("N2"),
                                 "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim change As Decimal = cash - totalPaid
            lbl_change.Text = "₱" & change.ToString("N2")

        ElseIf rb_gcash.Checked Then
            modeOfPayment = "GCash"

            If String.IsNullOrWhiteSpace(reference) Then
                MessageBox.Show("Please enter GCash Reference Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' ✅ Check duplicate reference 
            Try
                Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                    conn.Open()
                    Dim checkQuery As String = "SELECT COUNT(*) FROM sales WHERE Reference = @Reference"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@Reference", reference)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("This GCash Reference Number is already used!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking reference number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        Else
            MessageBox.Show("Please select a mode of payment!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ----------------- SUCCESS ACTIONS -----------------

        ' 1. ✅ Update Cash Management Totals (CRITICAL FIX: Find the active instance)
        Dim cashForm As CashManagementControll = Nothing
        Dim shiftForm As ShiftContent = Dashboard.shiftInstance

        ' Check if ShiftContent exists and contains the CashManagementControll
        If shiftForm IsNot Nothing AndAlso shiftForm.Panel2.Controls.Count > 0 Then
            ' Assuming Panel2 is the container for CashManagementControll
            If TypeOf shiftForm.Panel2.Controls(0) Is CashManagementControll Then
                cashForm = DirectCast(shiftForm.Panel2.Controls(0), CashManagementControll)
            End If
        End If

        If cashForm IsNot Nothing Then
            ' This calls the updated function in CashManagementControll with .Refresh()
            cashForm.UpdateCashManager(totalPaid, modeOfPayment)
            ' Also update gross sales/discounts via UpdateShiftSales (discount handled as 0 here)
            cashForm.UpdateShiftSales(refundValue:=0D, discountValue:=0D, grossSaleValue:=originalTotal)
        Else
            ' Log an error if the cash manager isn't found, but proceed with the sale
            MessageBox.Show("Warning: Could not find active Cash Management Control to update totals.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' 2. ✅ Save to Database (Saves to the 'sales' table) with Status 'Completed'
        SaveToDatabase(posForm, modeOfPayment, reference, totalPaid)

        ' 3. ✅ Refresh POS for new transaction (Clears DataGridView and total label)
        MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PPD.Document = PD
        PPD.ShowDialog()

        posForm.ClearTransaction() ' <-- move this after printing
        Me.Hide()

    End Sub

    Private Sub SaveToDatabase(posForm As PosControl, modeOfPayment As String, reference As String, totalPaid As Decimal)
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                ' Use transaction in case something fails
                Using tr As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Insert one row per cart item into sales table
                        For i As Integer = 0 To posForm.ListBox1.Items.Count - 1
                            Dim itemText As String = posForm.ListBox1.Items(i).ToString()
                            Dim priceText As String = posForm.ListBox2.Items(i).ToString().Replace("₱", "").Replace(",", "").Trim()
                            Dim qty As Integer = 1
                            Dim regex As New System.Text.RegularExpressions.Regex("^(\d+)x\s+(.+)$")
                            Dim m = regex.Match(itemText)
                            Dim pname As String = itemText
                            If m.Success Then
                                qty = Convert.ToInt32(m.Groups(1).Value)
                                pname = m.Groups(2).Value.Trim()
                            End If

                            Dim pricePerUnit As Decimal = 0D
                            If qty > 0 AndAlso Decimal.TryParse(priceText, pricePerUnit) Then
                                ' priceText might be total for the line; compute unit price:
                                Dim unitPrice As Decimal = pricePerUnit / qty

                                Dim cmd As New MySqlCommand("
                                INSERT INTO sales (TicketNumber, SaleDate, ProductName, Price, Quantity, SubTotal, TotalAmount, ModeOfPayment, Reference, Status)
                                VALUES (@TicketNumber, @SaleDate, @ProductName, @Price, @Quantity, @SubTotal, @TotalAmount, @ModeOfPayment, @Reference, @Status)
                            ", conn, tr)

                                cmd.Parameters.AddWithValue("@TicketNumber", posForm.lbl_tickets.Text)
                                cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now)
                                cmd.Parameters.AddWithValue("@ProductName", pname)
                                cmd.Parameters.AddWithValue("@Price", unitPrice)
                                cmd.Parameters.AddWithValue("@Quantity", qty)
                                cmd.Parameters.AddWithValue("@SubTotal", unitPrice * qty)
                                cmd.Parameters.AddWithValue("@TotalAmount", totalPaid) ' same total repeated per row; OK for now
                                cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment)
                                cmd.Parameters.AddWithValue("@Reference", reference)
                                cmd.Parameters.AddWithValue("@Status", "Completed")
                                cmd.ExecuteNonQuery()
                            End If
                        Next

                        tr.Commit()
                    Catch exInner As Exception
                        tr.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            ' ✅ Reload ProductContent safely (to update inventory/stock) - you already had this
            If Dashboard.productInstance IsNot Nothing Then
                Dashboard.productInstance.LoadInventory()
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Charge_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then RefreshTotalPaid()
    End Sub

    Private Sub PD_BeginPrint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD_BeginPrint.PrintPage
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    ' ✅ Fetch sale header data
    Private Function GetLatestSaleData(ticketNumber As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()
                Dim query As String = "SELECT SaleDate, TicketNumber, TotalAmount, ModeOfPayment, Reference FROM sales WHERE TicketNumber = @TicketNumber ORDER BY SaleDate DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TicketNumber", ticketNumber)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sale data for receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ✅ Fetch product details for that ticket
    Private Function GetSaleItems(ticketNumber As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=pos")
                conn.Open()
                Dim query As String = "SELECT ProductName, Price, Quantity, (Price * Quantity) AS SubTotal FROM sales WHERE TicketNumber = @TicketNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TicketNumber", ticketNumber)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sale items: " & ex.Message)
        End Try
        Return dt
    End Function


    Private Sub PD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Arial", 8, FontStyle.Regular)
        Dim f10 As New Font("Arial", 8, FontStyle.Bold)
        Dim f14 As New Font("Arial", 10, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left + 10
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width \ 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width - 20

        Dim right As New StringFormat() With {.Alignment = StringAlignment.Far}
        Dim center As New StringFormat() With {.Alignment = StringAlignment.Center}

        ' ---------- Get POS instance ----------
        Dim posForm As PosControl = Dashboard.posInstance
        If posForm Is Nothing Then
            MessageBox.Show("POS screen not found. Please open the POS module first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim ticketNumber As String = posForm.lbl_tickets.Text.Trim()
        Dim modePayment As String = If(rb_cash.Checked, "Cash", If(rb_gcash.Checked, "GCash", "N/A"))
        Dim reference As String = If(modePayment = "GCash", txt_reference.Text.Trim(), "")

        Dim line As String = "======================================="

        ' ---------- Header ----------
        Dim currentY As Integer = 20
        e.Graphics.DrawString("Frosties N' Cream", f14, Brushes.Black, 95, currentY, center)
        currentY += 15
        e.Graphics.DrawString("10 Rosal, Las Piñas City", f8, Brushes.Black, 95, currentY, center)
        currentY += 12
        e.Graphics.DrawString("Contact: 0917 557 5485", f8, Brushes.Black, 95, currentY, center)
        currentY += 15
        e.Graphics.DrawString("Service Invoice", f10, Brushes.Black, 95, currentY, center)
        currentY += 20
        e.Graphics.DrawString("Ticket No: " & ticketNumber, f8, Brushes.Black, 10, currentY)
        currentY += 12
        e.Graphics.DrawString(line, f8, Brushes.Black, 100, currentY, center)
        currentY += 12
        e.Graphics.DrawString("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), f8, Brushes.Black, 10, currentY)
        currentY += 12
        e.Graphics.DrawString(line, f8, Brushes.Black, 100, currentY, center)
        currentY += 14

        ' ---------- Product Header ----------
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 15, currentY, center)
        e.Graphics.DrawString("Product", f8, Brushes.Black, 90, currentY, center)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 178, currentY, right)
        currentY += 10
        e.Graphics.DrawString("----------------------------------------------------------------", f8, Brushes.Black, 100, currentY, center)
        currentY += 12

        ' ---------- Product Lines ----------
        Dim totalAmount As Decimal = 0D

        For i As Integer = 0 To posForm.ListBox1.Items.Count - 1
            Dim itemText As String = posForm.ListBox1.Items(i).ToString()
            Dim priceText As String = If(i < posForm.ListBox2.Items.Count, posForm.ListBox2.Items(i).ToString(), "₱0.00")

            Dim qty As Integer = 1
            Dim prodName As String = itemText
            Dim rx As New System.Text.RegularExpressions.Regex("^(\d+)x\s+(.+)$")
            Dim m = rx.Match(itemText)
            If m.Success Then
                qty = Convert.ToInt32(m.Groups(1).Value)
                prodName = m.Groups(2).Value.Trim()
            End If

            Dim lineTotal As Decimal = 0D
            Decimal.TryParse(priceText.Replace("₱", "").Replace(",", "").Trim(), lineTotal)
            Dim unitPrice As Decimal = If(qty > 0, Math.Round(lineTotal / qty, 2), 0D)

            ' ✅ Print product line properly spaced
            e.Graphics.DrawString(qty.ToString(), f8, Brushes.Black, 15, currentY, center)
            e.Graphics.DrawString(prodName, f8, Brushes.Black, 90, currentY, center)
            e.Graphics.DrawString(lineTotal.ToString("N2"), f8, Brushes.Black, 178, currentY, right)

            currentY += 12 ' ✅ move down after each product
            totalAmount += lineTotal
        Next

        ' ---------- Divider ----------
        currentY += 6
        e.Graphics.DrawString("----------------------------------------------------------------", f8, Brushes.Black, 100, currentY, center)
        currentY += 14

        ' ---------- Payment Info ----------
        e.Graphics.DrawString("Payment: " & modePayment, f8, Brushes.Black, 10, currentY)
        currentY += 12
        If modePayment = "GCash" AndAlso reference <> "" Then
            e.Graphics.DrawString("Reference: " & reference, f8, Brushes.Black, 10, currentY)
            currentY += 12
        End If

        ' ---------- Total ----------
        e.Graphics.DrawString(line, f8, Brushes.Black, 100, currentY, center)
        currentY += 14
        e.Graphics.DrawString("TOTAL: ₱" & totalAmount.ToString("N2"), f10, Brushes.Black, 95, currentY, center)
        currentY += 20
        e.Graphics.DrawString("Thank you for your purchase!", f8, Brushes.Black, 95, currentY, center)

        ' ✅ Adjust paper size automatically
        longpaper = currentY + 80
        PD.DefaultPageSettings.PaperSize = New PaperSize("Custom", 300, longpaper)
    End Sub

End Class
