Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Charge
    Dim WithEvents PD As New PrintDocument()
    Dim PPD As New PrintPreviewDialog()
    Dim longpaper As Integer

    ' Sub-forms (your other forms)
    Public Shared cashForm As New Charge_Cash()
    Public Shared gcashForm As New Charge_Gcash()
    Public Shared successForm As New Charge_Success()


    Private originalTotal As Decimal = 0D

    Private Sub Charge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure Dashboard POS exists
        Dim posForm As PosControl = Dashboard.posInstance
        If posForm Is Nothing Then
            MessageBox.Show("POS screen not found. Please open the POS module first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Embed child forms into your siticoneflatpanel1
        Try
            ' Prepare cash form
            cashForm.Dock = DockStyle.Fill

            ' Prepare gcash form
            gcashForm.Dock = DockStyle.Fill

            ' Clear panel and add both forms (we'll show/hide)
            SiticoneFlatPanel1.Controls.Clear()
            SiticoneFlatPanel1.Controls.Add(cashForm)
            SiticoneFlatPanel1.Controls.Add(gcashForm)

            cashForm.Show()
            gcashForm.Hide()
        Catch ex As Exception
            ' If embed fails, continue (forms might already be added)
        End Try

        ' Wire text changed events from child forms to local handlers
        Try
            AddHandler cashForm.txt_cashs.TextChanged, AddressOf txt_cashs_TextChanged
            AddHandler gcashForm.txt_ref.TextChanged, AddressOf txt_reference_TextChanged
        Catch ex As Exception
            ' ignore if child controls not present
        End Try

        ' Find lbl_total inside pos (recursive)
        Dim lblTotalInPanel As Label = FindLabelRecursive(posForm, "lbl_total")

        If lblTotalInPanel IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(lblTotalInPanel.Text) Then
            Dim cleanValue As String = lblTotalInPanel.Text.Replace("₱", "").Replace(",", "").Trim()
            Decimal.TryParse(cleanValue, originalTotal)
        Else
            originalTotal = 0D
        End If

        lbl_totalpaid.Text = "₱" & originalTotal.ToString("N2")

        ' Initialize child controls
        Try
            cashForm.txt_cashs.Clear()
            cashForm.lbl_change.Text = "₱0.00"
            cashForm.lbl_totalP.Text = "₱0.00"
        Catch ex As Exception
        End Try

        Try
            gcashForm.txt_ref.Hide() ' keep reference hidden until GCash selected
        Catch ex As Exception
        End Try
    End Sub

    ' Recursive label finder (unchanged)
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

    ' Refresh totals each time form becomes visible
    Public Sub RefreshTotalPaid()
        cb_employee.Checked = False
        cb_pwd.Checked = False
        cb_senior.Checked = False

        ' Clear child inputs
        Try
            cashForm.txt_cashs.Clear()
            gcashForm.txt_ref.Clear()
        Catch ex As Exception
        End Try


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

        ' reflect into child form if needed
        Try
            cashForm.lbl_totalP.Text = "₱" & Math.Round(subtotal, 2).ToString("N2")
        Catch ex As Exception
        End Try
    End Sub

    ' When SiticoneRadioButton1 (Cash) is selected
    Private Sub SiticoneRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles SiticoneRadioButton1.CheckedChanged
        If SiticoneRadioButton1.Checked Then
            ' Show cash panel form, hide gcash form
            Try
                cashForm.Show()
                gcashForm.Hide()
            Catch ex As Exception
            End Try

            ' Show/hide appropriate fields
            Try
                gcashForm.txt_ref.Hide()
            Catch ex As Exception
            End Try
            Try
                cashForm.txt_cashs.Show()
            Catch ex As Exception
            End Try

        End If
    End Sub

    ' When SiticoneRadioButton2 (GCash) is selected
    Private Sub SiticoneRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles SiticoneRadioButton2.CheckedChanged
        If SiticoneRadioButton2.Checked Then
            Try
                gcashForm.Show()
                cashForm.Hide()
            Catch ex As Exception
            End Try

            Try
                gcashForm.txt_ref.Show()
            Catch ex As Exception
            End Try
            Try
                cashForm.txt_cashs.Hide()
                cashForm.txt_cashs.Clear()
            Catch ex As Exception
            End Try

        End If
    End Sub

    ' Discount checkbox handler
    Private Sub DiscountChanged(sender As Object, e As EventArgs) Handles cb_employee.CheckedChanged, cb_pwd.CheckedChanged, cb_senior.CheckedChanged
        ApplyDiscount()
    End Sub

    Private Sub ApplyDiscount()
        Dim total As Decimal = originalTotal
        If cb_employee.Checked OrElse cb_pwd.Checked OrElse cb_senior.Checked Then
            total = Math.Round(total * 0.8D, 2)
        End If
        lbl_totalpaid.Text = "₱" & total.ToString("N2")
        ' update child total display
        Try
            cashForm.lbl_totalP.Text = "₱" & total.ToString("N2")
        Catch ex As Exception
        End Try
        CalculateChange()
    End Sub

    ' proxy for cash text changed (wired via AddHandler)
    Private Sub txt_cashs_TextChanged(sender As Object, e As EventArgs)
        CalculateChange()
    End Sub

    Private Sub CalculateChange()
        Dim cash As Decimal = 0D
        Dim totalPaid As Decimal = 0D

        Dim cashText As String = ""
        Try
            cashText = cashForm.txt_cashs.Text
        Catch ex As Exception
            cashText = ""
        End Try

        Decimal.TryParse(cashText.Replace("₱", "").Replace(",", "").Trim(), cash)
        Decimal.TryParse(lbl_totalpaid.Text.Replace("₱", "").Replace(",", "").Trim(), totalPaid)

        Dim change As Decimal = cash - totalPaid

        If change >= 0D Then

            Try
                cashForm.lbl_change.Text = "₱" & change.ToString("N2")
            Catch ex As Exception
            End Try
        Else

            Try
                cashForm.lbl_change.Text = "₱0.00"
            Catch ex As Exception
            End Try
        End If
    End Sub

    ' Main charge button (handles SiticoneButton1)
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        ' forward to the main charge logic
        ProcessCharge()
    End Sub

    ' Extracted charge logic to keep things tidy
    Private Sub ProcessCharge()
        Dim cash As Decimal = 0D
        Dim totalPaid As Decimal = 0D
        Dim cashText As String = ""
        Try
            cashText = cashForm.txt_cashs.Text.Replace("₱", "").Replace(",", "").Trim()
        Catch ex As Exception
            cashText = ""
        End Try

        Decimal.TryParse(lbl_totalpaid.Text.Replace("₱", "").Replace(",", "").Trim(), totalPaid)

        If totalPaid <= 0 Then
            MessageBox.Show("Invalid or missing total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim modeOfPayment As String = ""
        Dim reference As String = ""
        Try
            reference = gcashForm.txt_ref.Text.Trim()
        Catch ex As Exception
            reference = ""
        End Try

        Dim posForm As PosControl = Dashboard.posInstance
        If posForm Is Nothing Then
            MessageBox.Show("POS form not found inside Dashboard!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Payment mode validation
        If SiticoneRadioButton1.Checked Then
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

            Try
                cashForm.lbl_change.Text = "₱" & change.ToString("N2")
            Catch ex As Exception
            End Try

        ElseIf SiticoneRadioButton2.Checked Then
            modeOfPayment = "GCash"
            If String.IsNullOrWhiteSpace(reference) Then
                MessageBox.Show("Please enter GCash Reference Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' duplicate reference check
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
        ' 1. Update Cash Management Totals
        Dim cashMgr As CashManagementControll = Nothing
        Dim shiftForm As ShiftContent = Dashboard.shiftInstance

        If shiftForm IsNot Nothing Then
            Try
                If shiftForm.Panel2.Controls.Count > 0 AndAlso TypeOf shiftForm.Panel2.Controls(0) Is CashManagementControll Then
                    cashMgr = DirectCast(shiftForm.Panel2.Controls(0), CashManagementControll)
                End If
            Catch ex As Exception
            End Try
        End If

        If cashMgr IsNot Nothing Then
            Try
                cashMgr.UpdateCashManager(totalPaid, modeOfPayment)
                cashMgr.UpdateShiftSales(refundValue:=0D, discountValue:=0D, grossSaleValue:=originalTotal)
            Catch ex As Exception
                ' continue even if cash manager update fails
            End Try
        Else
            MessageBox.Show("Warning: Could not find active Cash Management Control to update totals.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' 2. Save to DB
        SaveToDatabase(posForm, modeOfPayment, reference, totalPaid)
        ' ✅ Refresh Dashboard content after successful transaction
        ' ✅ Refresh dashboard after successful sale
        Try
            If Dashboard.DashboardContent IsNot Nothing Then
                Dashboard.DashboardContent.RefreshDashboard()
            End If
        Catch ex As Exception
            MessageBox.Show("Dashboard refresh failed: " & ex.Message)
        End Try

        ' 3. Print and clear
        MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PPD.Document = PD
        PPD.ShowDialog()

        Try
            posForm.ClearTransaction()
        Catch ex As Exception
        End Try

        Me.Hide()
    End Sub

    Private Sub SaveToDatabase(posForm As PosControl, modeOfPayment As String, reference As String, totalPaid As Decimal)
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()
                Using tr As MySqlTransaction = conn.BeginTransaction()
                    Try
                        For i As Integer = 0 To posForm.ListBox1.Items.Count - 1
                            Dim itemText As String = posForm.ListBox1.Items(i).ToString()
                            Dim priceText As String = If(i < posForm.ListBox2.Items.Count, posForm.ListBox2.Items(i).ToString().Replace("₱", "").Replace(",", "").Trim(), "0")
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
                                cmd.Parameters.AddWithValue("@TotalAmount", totalPaid)
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

            ' Reload inventory
            If Dashboard.productInstance IsNot Nothing Then
                Dashboard.productInstance.LoadInventory()
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When form visibility changes, refresh totals
    Private Sub Charge_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then RefreshTotalPaid()
    End Sub

    ' Set paper size before printing (BeginPrint)
    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        ' Estimate paper height based on item count
        Dim posForm As PosControl = Dashboard.posInstance
        Dim itemCount As Integer = If(posForm IsNot Nothing, posForm.ListBox1.Items.Count, 1)

        ' Each product line adds about 20 units height
        longpaper = 250 + (itemCount * 20)

        Dim pagesetup As New PageSettings()
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub


    ' Actual print page drawing
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Arial", 8, FontStyle.Regular)
        Dim f10 As New Font("Arial", 8, FontStyle.Bold)
        Dim f14 As New Font("Arial", 10, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left + 10
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width \ 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width - 20

        Dim right As New StringFormat() With {.Alignment = StringAlignment.Far}
        Dim center As New StringFormat() With {.Alignment = StringAlignment.Center}

        Dim posForm As PosControl = Dashboard.posInstance
        If posForm Is Nothing Then
            MessageBox.Show("POS screen not found. Please open the POS module first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim ticketNumber As String = posForm.lbl_tickets.Text.Trim()
        Dim modePayment As String = If(SiticoneRadioButton1.Checked, "Cash", If(SiticoneRadioButton2.Checked, "GCash", "N/A"))
        Dim reference As String = If(modePayment = "GCash", (If(gcashForm IsNot Nothing, gcashForm.txt_ref.Text.Trim(), "")), "")

        Dim line As String = "======================================="

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

        ' Product header
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 15, currentY, center)
        e.Graphics.DrawString("Product", f8, Brushes.Black, 90, currentY, center)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 178, currentY, right)
        currentY += 10
        e.Graphics.DrawString("----------------------------------------------------------------", f8, Brushes.Black, 100, currentY, center)
        currentY += 12

        ' Product lines
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

            e.Graphics.DrawString(qty.ToString(), f8, Brushes.Black, 15, currentY, center)
            e.Graphics.DrawString(prodName, f8, Brushes.Black, 90, currentY, center)
            e.Graphics.DrawString(lineTotal.ToString("N2"), f8, Brushes.Black, 178, currentY, right)

            currentY += 12
            totalAmount += lineTotal
        Next

        currentY += 6
        e.Graphics.DrawString("----------------------------------------------------------------", f8, Brushes.Black, 100, currentY, center)
        currentY += 14

        e.Graphics.DrawString("Payment: " & modePayment, f8, Brushes.Black, 10, currentY)
        currentY += 12
        If modePayment = "GCash" AndAlso reference <> "" Then
            e.Graphics.DrawString("Reference: " & reference, f8, Brushes.Black, 10, currentY)
            currentY += 12
        End If

        e.Graphics.DrawString(line, f8, Brushes.Black, 100, currentY, center)
        currentY += 14
        e.Graphics.DrawString("TOTAL: ₱" & totalAmount.ToString("N2"), f10, Brushes.Black, 95, currentY, center)
        currentY += 20
        e.Graphics.DrawString("Thank you for your purchase!", f8, Brushes.Black, 95, currentY, center)

        longpaper = currentY + 80
        PD.DefaultPageSettings.PaperSize = New PaperSize("Custom", 300, longpaper)
    End Sub

    ' Empty handler used by AddHandler wiring
    Private Sub txt_reference_TextChanged(sender As Object, e As EventArgs)
        ' you may implement validation of reference here if desired
    End Sub

    Private Sub SiticoneImageButton1_Click(sender As Object, e As EventArgs) Handles SiticoneImageButton1.Click
        Me.Close()
        ' Return to POS screen via Dashboard
        Dashboard.posInstance.BringToFront()
    End Sub
End Class
