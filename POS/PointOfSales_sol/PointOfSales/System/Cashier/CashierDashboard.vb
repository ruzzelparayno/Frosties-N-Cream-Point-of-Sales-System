Public Class CashierDashboard

    Private Sub CashierDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Register views using shared instances from Dashboard
        ContentPanel.AddContentToView("Dashboard", Dashboard.DashboardContent)
        ContentPanel.AddContentToView("Point Of Sales", Dashboard.posInstance)
        ContentPanel.AddContentToView("Transaction", Dashboard.TransactionContent)
        ContentPanel.AddContentToView("Shift", Dashboard.shiftInstance)
        ContentPanel.AddContentToView("Logout", Dashboard.LogoutContent)
    End Sub

    ' ✅ Display a UserControl inside the dashboard card
    Private Sub ShowControl(uc As UserControl)
        If uc IsNot Nothing Then
            uc.Dock = DockStyle.Fill
            SiticoneDashboardCard.Controls.Clear()
            SiticoneDashboardCard.Controls.Add(uc)
        End If
    End Sub

    ' ✅ Corrected resize logic
    Private Sub CashierDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Panel1.Size = New Size(Panel1.Width, 400)
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Panel1.Size = New Size(Panel1.Width, 300)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub
End Class
