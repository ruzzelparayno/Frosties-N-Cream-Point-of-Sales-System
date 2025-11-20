Public Class CashManagementControll
    ' Removed Private shiftAmount As Decimal = 0D - shift amount is read directly from lbl_sc1.Text

    Private Sub cashmanagementcontroll_load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearalllabels()
        lbl_sc1.Text = "₱0.00"
        lbl_cashp1.Text = "₱0.00"
        lbl_refund1.Text = "₱0.00"
        lbl_eca.Text = "₱0.00"
        lbl_gs.Text = "₱0.00"
        lbl_srefunds.Text = "₱0.00"
        lbl_sdiscounts.Text = "₱0.00"
        lbl_ns.Text = "₱0.00"
        lbl_ncash.Text = "₱0.00"
        lbl_ngcash.Text = "₱0.00"
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        ' ✅ Validate input
        If SiticoneTextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please enter a shift amount first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Show welcome message
        MessageBox.Show("Welcome to Shift!", "Shift Started", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' ✅ Get the ShiftContent instance from Dashboard
        Dim shiftForm As ShiftContent = Dashboard.shiftInstance

        ' ✅ Get the running Dashboard instance
        Dim mainDashboard As Dashboard = Application.OpenForms().OfType(Of Dashboard)().FirstOrDefault()

        ' ✅ If ShiftContent is not initialized, create it and add to ContentPanel
        If shiftForm Is Nothing Then
            shiftForm = New ShiftContent()
            Dashboard.shiftInstance = shiftForm

            If mainDashboard IsNot Nothing Then
                ' Assuming ContentPanel has an AddContentToView method
                ' Note: If Dashboard is the parent form, you might need to adjust this view logic.
                ' For this code, we rely on Dashboard.shiftInstance being correctly set.
                ' mainDashboard.ContentPanel.AddContentToView("Shift", shiftForm)
            Else
                MessageBox.Show("Dashboard is not running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        ' The code below assumes you are calling this method after the ShiftContent is loaded
        ' and its panels are accessible.

        ' ✅ Ensure Panel4 is visible (This assumes Panel4 is a control within ShiftContent)
        If shiftForm IsNot Nothing Then
            shiftForm.Panel4.Show()
            shiftForm.SiticoneButton3.Hide()
        End If

        ' ✅ Format the shift amount with Peso sign and 2 decimals
        Dim shiftValue As Decimal
        If Decimal.TryParse(SiticoneTextBox1.Text, shiftValue) Then
            lbl_sc1.Text = "₱" & shiftValue.ToString("N2")
        Else
            lbl_sc1.Text = "₱0.00"
        End If

        ' ✅ Display date and time inside a label
        lbl_datet.Text = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
        clearopenshift()
        displayalllabels()

        ' ✅ Update totals
        ComputeTotal()
    End Sub

    ' ------------------ CORE CASH/PAYMENT UPDATE LOGIC ------------------

    ' This function is called by Charge.vb to initiate cash/gcash updates.
    Public Sub UpdateCashManager(amount As Decimal, modeOfPayment As String)
        Select Case modeOfPayment
            Case "Cash"
                UpdateCashTotals(amount, isCash:=True)
            Case "GCash"
                UpdateCashTotals(amount, isCash:=False)
        End Select
        ' UpdateShiftSales is called separately in Charge.vb to handle GS/Discount accumulation.
    End Sub

    ' This function updates the cash/gcash running totals (lbl_cashp1 and lbl_ngcash).
    Public Sub UpdateCashTotals(amount As Decimal, isCash As Boolean)
        Try
            Dim currentCash, currentGCash As Decimal

            Decimal.TryParse(lbl_cashp1.Text.Replace("₱", "").Replace(",", "").Trim(), currentCash)
            Decimal.TryParse(lbl_ngcash.Text.Replace("₱", "").Replace(",", "").Trim(), currentGCash)

            If isCash Then
                currentCash += amount
            Else
                currentGCash += amount
            End If

            lbl_cashp1.Text = "₱" & currentCash.ToString("N2")
            lbl_ngcash.Text = "₱" & currentGCash.ToString("N2")

            ComputeTotal()
        Catch ex As Exception
            MessageBox.Show("Error updating totals: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------ MISSING SALES/REFUND ACCUMULATION LOGIC (CRITICAL FIX) ------------------

    ' ✅ NEW FUNCTION: This function is called by Charge.vb (for sales) and RefundForm.vb (for sales reversal).
    Public Sub UpdateShiftSales(ByVal refundValue As Decimal, ByVal discountValue As Decimal, ByVal grossSaleValue As Decimal)
        Try
            ' Helper function to safely parse and accumulate
            Dim AccumulateLabel As Func(Of Label, Decimal, String) =
                Function(lbl As Label, amount As Decimal) As String
                    Dim currentValue As Decimal
                    Decimal.TryParse(lbl.Text.Replace("₱", "").Replace(",", "").Trim(), currentValue)
                    currentValue += amount
                    lbl.Refresh()
                    Return "₱" & currentValue.ToString("N2")
                End Function

            ' 1. Update Total Refunds (lbl_srefunds)
            lbl_srefunds.Text = AccumulateLabel(lbl_srefunds, refundValue)

            ' 2. Update Total Discounts (lbl_sdiscounts)
            lbl_sdiscounts.Text = AccumulateLabel(lbl_sdiscounts, discountValue)

            ' 3. Update Total Gross Sales (lbl_gs)
            lbl_gs.Text = AccumulateLabel(lbl_gs, grossSaleValue)

            ' 4. Recalculate derived totals (Net Sales, Extra Cash, etc.)
            ComputeTotal()

        Catch ex As Exception
            MessageBox.Show("Error updating shift sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------ TOTAL CALCULATION LOGIC (CRITICAL FIX) ------------------

    ' ✅ CORRECTED FUNCTION: Uses the accumulated totals (GS, Discounts, Refunds) for accurate calculations.
    Public Sub ComputeTotal()
        Try
            Dim shiftStartCash, cashPayments, refunds, discounts, grossSales As Decimal

            ' Get all relevant data from labels
            Decimal.TryParse(lbl_sc1.Text.Replace("₱", "").Replace(",", "").Trim(), shiftStartCash)
            Decimal.TryParse(lbl_cashp1.Text.Replace("₱", "").Replace(",", "").Trim(), cashPayments)
            Decimal.TryParse(lbl_refund1.Text.Replace("₱", "").Replace(",", "").Trim(), refunds) ' Cash Refund Out
            Decimal.TryParse(lbl_sdiscounts.Text.Replace("₱", "").Replace(",", "").Trim(), discounts) ' Total Discounts
            Decimal.TryParse(lbl_gs.Text.Replace("₱", "").Replace(",", "").Trim(), grossSales) ' Total Gross Sales

            ' Calculate Extra Cash (ECA): Total Cash Available = Shift Start Cash + Cash Payments - Cash Refunds Out
            Dim extraCash As Decimal = shiftStartCash + cashPayments - refunds

            ' Calculate Net Sales (NS): Net Sales = Gross Sales - Discounts
            Dim netSales As Decimal = grossSales - discounts
            If netSales < 0 Then netSales = 0D ' Net sales cannot be negative

            ' Update Labels
            lbl_eca.Text = "₱" & extraCash.ToString("N2")
            lbl_ns.Text = "₱" & netSales.ToString("N2")

            ' The existing code was doing unnecessary calculation/label updates here, simplified below:
            ' lbl_ncash is often Net Cash (Cash Payments - Refunds)
            ' lbl_ngcash is already updated in UpdateCashTotals
            lbl_ncash.Text = "₱" & (cashPayments - refunds).ToString("N2")

            lbl_eca.Refresh()
            lbl_ns.Refresh()
            lbl_ncash.Refresh()

        Catch ex As Exception
            lbl_ns.Text = "₱0.00"
            ' Consider displaying an error message here for debugging
        End Try
    End Sub

    ' ------------------ VISIBILITY UTILITY FUNCTIONS ------------------

    Public Sub clearopenshift()
        SiticoneButton1.Hide()
        SiticoneTextBox1.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Public Sub clearalllabels()
        lbl_datet.Hide()
        lbl_sc1.Hide()
        lbl_cashp1.Hide()
        lbl_refund1.Hide()
        lbl_eca.Hide()
        Label17.Hide()
        Label14.Hide()
        Label12.Hide()
        Label11.Hide()
        Label10.Hide()
        Label6.Hide()
        Label5.Hide()
        Label4.Hide()
        Label3.Hide()
        lbl_gs.Hide()
        lbl_srefunds.Hide()
        lbl_sdiscounts.Hide()
        lbl_nsn.Hide()
        lbl_cashn.Hide()
        lbl_gcashn.Hide()
        lbl_ns.Hide()
        lbl_ncash.Hide()
        lbl_ngcash.Hide()

    End Sub

    Public Sub displayalllabels()
        lbl_datet.Show()
        lbl_sc1.Show()
        lbl_cashp1.Show()
        lbl_refund1.Show()
        lbl_eca.Show()
        Label17.Show()
        Label14.Show()
        Label12.Show()
        Label11.Show()
        Label10.Show()
        Label6.Show()
        Label5.Show()
        Label4.Show()
        Label3.Show()
        lbl_gs.Show()
        lbl_srefunds.Show()
        lbl_sdiscounts.Show()
        lbl_nsn.Show()
        lbl_cashn.Show()
        lbl_gcashn.Show()
        lbl_ns.Show()
        lbl_ncash.Show()
        lbl_ngcash.Show()
    End Sub

    ' Optional: helper to refresh total refunded from DB if you ever need it
    Public Sub RefreshTotalRefundedFromDB()
        Try
            Using conn As New MySql.Data.MySqlClient.MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT IFNULL(SUM(TotalAmount),0) FROM sales WHERE Status='Refunded'", conn)
                Dim res = cmd.ExecuteScalar()
                Dim totalRefund As Decimal = 0D
                If res IsNot Nothing AndAlso res IsNot DBNull.Value Then Decimal.TryParse(res.ToString(), totalRefund)
                lbl_srefunds.Text = "₱" & totalRefund.ToString("N2")
                ComputeTotal()
            End Using
        Catch ex As Exception
            ' ignore DB read error here, not critical
        End Try
    End Sub

End Class
