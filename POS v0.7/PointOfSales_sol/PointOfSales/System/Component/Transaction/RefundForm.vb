Imports MySql.Data.MySqlClient

Public Class RefundForm

    ' Optional labels/controls you already have on the form:
    ' lbl_getticket, lbl_getproducts, lbl_getprice, lbl_getsubtotal, lbl_getvat, lbl_gettotal, lbl_MOP

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Confirm refund action
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to refund this transaction?",
            "Confirm Refund",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm <> DialogResult.Yes Then Return

        ' Parse refund amount from the displayed total label (lbl_gettotal)
        Dim refundAmount As Decimal = 0D
        Decimal.TryParse(lbl_gettotal.Text.Replace("₱", "").Replace(",", "").Trim(), refundAmount)

        ' Determine discount and gross sale if you maintain them per transaction.
        ' For now, attempt to parse subtotal and compute discount as gross - subtotal if a gross exists.
        Dim subtotal As Decimal = 0D
        Decimal.TryParse(lbl_getsubtotal.Text.Replace("₱", "").Replace(",", "").Trim(), subtotal)

        Dim grossSaleAmount As Decimal = 0D
        ' If you have gross sale displayed, parse it; otherwise treat originalTotal = subtotal + vat
        Decimal.TryParse(lbl_getprice.Text.Replace("₱", "").Replace(",", "").Trim(), grossSaleAmount)
        If grossSaleAmount = 0D Then
            grossSaleAmount = subtotal ' fallback
        End If

        Dim discountAmount As Decimal = Math.Max(0D, grossSaleAmount - subtotal)

        ' 1) Update database: mark matching sale(s) as Refunded
        Dim connStr As String = "server=localhost;userid=root;password=;database=pos"
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Update status for the transaction(s) matching TicketNumber & ProductName.
                Dim updateQuery As String = "UPDATE sales SET Status='Refunded' WHERE TicketNumber=@TicketNumber AND TRIM(ProductName)=@ProductName"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@TicketNumber", lbl_getticket.Text.Trim())
                    cmd.Parameters.AddWithValue("@ProductName", lbl_getproducts.Text.Trim())
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    ' rows indicates number of rows updated; proceed either way.
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating refund status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' 2) Update Cash Management (shift totals)
        Dim cashForm As CashManagementControll = Nothing
        Dim shiftForm As ShiftContent = Dashboard.shiftInstance

        If shiftForm IsNot Nothing AndAlso shiftForm.Panel2.Controls.Count > 0 Then
            If TypeOf shiftForm.Panel2.Controls(0) Is CashManagementControll Then
                cashForm = DirectCast(shiftForm.Panel2.Controls(0), CashManagementControll)
            End If
        End If

        If cashForm IsNot Nothing Then
            ' A) Add to the accumulated shift refund total (lbl_srefunds)
            cashForm.UpdateShiftSales(refundValue:=refundAmount, discountValue:=-discountAmount, grossSaleValue:=-grossSaleAmount)

            ' B) Update immediate refund out label (cash paid out for refunds)
            Dim currentRefundOut As Decimal = 0D
            Decimal.TryParse(cashForm.lbl_refund1.Text.Replace("₱", "").Replace(",", "").Trim(), currentRefundOut)
            currentRefundOut += refundAmount
            cashForm.lbl_refund1.Text = "₱" & currentRefundOut.ToString("N2")
            cashForm.lbl_refund1.Refresh()

            ' C) Subtract from cash payments (cash drawer) - if refund was in cash
            Dim isCashRefund As Boolean = True
            If lbl_MOP IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(lbl_MOP.Text) Then
                If lbl_MOP.Text.Trim().ToLower() = "gcash" Then
                    isCashRefund = False
                End If
            End If
            cashForm.UpdateCashTotals(-refundAmount, isCash:=isCashRefund)

            ' D) Recompute totals
            cashForm.ComputeTotal()
        End If

        MessageBox.Show("Refund processed successfully!", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub RefundForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: format the labels if necessary
        ' e.g., lbl_gettotal.Text = "₱0.00" if empty
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub
End Class
