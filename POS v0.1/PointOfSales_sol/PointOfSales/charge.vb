Imports MySql.Data.MySqlClient

Public Class Charge

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
        posForm.ClearTransaction()

        MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
    End Sub

    Private Sub SaveToDatabase(posForm As PosControl, modeOfPayment As String, reference As String, totalPaid As Decimal)
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                ' 🟢 Save sales record
                Dim cmd As New MySqlCommand("
                    INSERT INTO sales (TicketNumber, SaleDate, TotalAmount, ModeOfPayment, Reference, Status)
                    VALUES (@TicketNumber, @SaleDate, @TotalAmount, @ModeOfPayment, @Reference, @Status)", conn)
                cmd.Parameters.AddWithValue("@TicketNumber", posForm.lbl_tickets.Text)
                cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now)
                cmd.Parameters.AddWithValue("@TotalAmount", totalPaid)
                cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment)
                cmd.Parameters.AddWithValue("@Reference", reference)
                cmd.Parameters.AddWithValue("@Status", "Completed")
                cmd.ExecuteNonQuery()
            End Using

            ' ✅ Reload ProductContent safely (to update inventory/stock)
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

End Class
