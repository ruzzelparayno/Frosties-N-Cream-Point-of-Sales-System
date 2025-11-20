Public Class ShiftContent
    Dim cashmanagementcontroll As New CashManagementControll
    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        ShowControl(New CashManagementControll())
    End Sub
    Private Sub ShowControl(uc As UserControl)
        uc.Dock = DockStyle.Fill
        Panel2.Controls.Clear()
        Panel2.Controls.Add(uc)
    End Sub

    Private Sub ShiftContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowControl(New CashManagementControll())
        Panel4.Show()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        ShowControl(New ClosingShiftContent())
    End Sub

    ' 🔹 Whenever cash updates, recompute immediately
    Public Sub UpdateCash(newCash As Decimal)
        Dim currentCash As Decimal = 0D
        Decimal.TryParse(cashmanagementcontroll.lbl_cashp1.Text.Replace("₱", "").Replace(",", "").Trim(), currentCash)

        currentCash += newCash
        cashmanagementcontroll.lbl_cashp1.Text = "₱" & currentCash.ToString("N0")

        ' ✅ Ensure UI updates right away
        cashmanagementcontroll.lbl_cashp1.Refresh()
        ComputeTotal()
    End Sub


    ' 🔹 Function to always add lbl_sc1 + lbl_cashp1 and show result in lbl_eca
    Public Sub ComputeTotal()
        Dim shiftAmount As Decimal = 0D
        Dim cashP1 As Decimal = 0D
        Dim total As Decimal = 0D

        ' 🔸 Clean the text before converting
        Dim shiftText As String = cashmanagementcontroll.lbl_sc1.Text.Replace("₱", "").Replace(",", "").Trim()
        Dim cashText As String = cashmanagementcontroll.lbl_cashp1.Text.Replace("₱", "").Replace(",", "").Trim()

        ' 🔸 Convert safely (default to 0 if empty)
        If Not Decimal.TryParse(shiftText, shiftAmount) Then shiftAmount = 0D
        If Not Decimal.TryParse(cashText, cashP1) Then cashP1 = 0D

        ' 🔸 Add them together
        total = shiftAmount + cashP1

        ' 🔸 Subtract refund if it exists
        Dim refundAmount As Decimal = 0D
        If Decimal.TryParse(cashmanagementcontroll.lbl_refund1.Text.Replace("₱", "").Replace(",", "").Trim(), refundAmount) Then
            total -= refundAmount
        End If

        ' 🔸 Show formatted total
        cashmanagementcontroll.lbl_eca.Text = "₱" & total.ToString("N0")
        cashmanagementcontroll.lbl_eca.Refresh()
    End Sub

    ' 🔹 Function to apply refund subtraction directly
    Public Sub SubtractRefund(refundValue As Decimal)
        Dim currentEca As Decimal = 0D
        Decimal.TryParse(cashmanagementcontroll.lbl_eca.Text.Replace("₱", "").Replace(",", "").Trim(), currentEca)

        Dim newTotal As Decimal = currentEca - refundValue
        If newTotal < 0 Then newTotal = 0 ' prevent negative total

        cashmanagementcontroll.lbl_eca.Text = "₱" & newTotal.ToString("N0")
        cashmanagementcontroll.lbl_eca.Refresh()
    End Sub

    Public Sub ComputeNetSales()
        Try
            ' 🔹 Get Gross Sales
            Dim grossSales As Decimal = 0D
            Decimal.TryParse(cashmanagementcontroll.lbl_gs.Text.Replace("₱", "").Replace(",", "").Trim(), grossSales)

            ' 🔹 Get Refunds
            Dim refunds As Decimal = 0D
            Decimal.TryParse(cashmanagementcontroll.lbl_srefunds.Text.Replace("₱", "").Replace(",", "").Trim(), refunds)

            ' 🔹 Get Discounts
            Dim discounts As Decimal = 0D
            Decimal.TryParse(cashmanagementcontroll.lbl_sdiscounts.Text.Replace("₱", "").Replace(",", "").Trim(), discounts)

            ' 🔹 Get GCash total
            Dim gcashTotal As Decimal = 0D
            Decimal.TryParse(cashmanagementcontroll.lbl_ngcash.Text.Replace("₱", "").Replace(",", "").Trim(), gcashTotal)

            ' 🔹 Compute Net Sales (Gross - Refunds - Discounts)
            Dim netSales As Decimal = grossSales - refunds - discounts
            If netSales < 0 Then netSales = 0 ' prevent negative total

            ' 🔹 Compute Net Cash (Add GCash)
            Dim netCash As Decimal = netSales + gcashTotal

            ' 🔹 Display results
            cashmanagementcontroll.lbl_ns.Text = "₱" & netSales.ToString("N0")

            ' ✅ Automatically get value from lbl_cashp1 and display in lbl_ncash
            Dim cashP1Value As Decimal = 0D
            Decimal.TryParse(cashmanagementcontroll.lbl_cashp1.Text.Replace("₱", "").Replace(",", "").Trim(), cashP1Value)
            cashmanagementcontroll.lbl_ncash.Text = "₱" & cashP1Value.ToString("N0")
            cashmanagementcontroll.lbl_ncash.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error computing net sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🔹 Auto recompute whenever label texts change
    Private Sub lbl_cashp1_TextChanged(sender As Object, e As EventArgs)
        ComputeTotal()
    End Sub

    Private Sub lbl_sc1_TextChanged(sender As Object, e As EventArgs)
        ComputeTotal()
    End Sub

    Private Sub lbl_refund1_TextChanged(sender As Object, e As EventArgs)
        ' ✅ Auto subtract refund when lbl_refund1 updates
        ComputeTotal()
    End Sub

    Private Sub Labels_TextChanged(sender As Object, e As EventArgs)
        ComputeNetSales()
    End Sub
End Class
