Imports SiticoneNetFrameworkUI ' Adjust this if needed based on your actual Siticone version

Public Class Dashboard
    Public Shared IsLoggingOut As Boolean = False

    ' ✅ Shared instances
    Public Shared DashboardContent As New DashboardContent()
    Public Shared posInstance As New PosControl()
    Public Shared shiftInstance As New ShiftContent()
    Public Shared productInstance As New ProductContent()
    Public Shared cashInstance As New CashManagementControll()
    Public Shared TransactionContent As New TransactionContent()
    Public Shared LogoutContent As New LogoutContent()

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Register views (assuming ContentPanel is a custom view manager)
        ContentPanel.AddContentToView("Dashboard", New DashboardContent())
        ContentPanel.AddContentToView("Point Of Sales", posInstance)
        ContentPanel.AddContentToView("Inventory", New inventory)
        ContentPanel.AddContentToView("Users", New UserContent())
        ContentPanel.AddContentToView("Sales", New SalesContent())
        ContentPanel.AddContentToView("Transaction", New TransactionContent())
        ContentPanel.AddContentToView("Shift", shiftInstance)
        ContentPanel.AddContentToView("Cash Management", cashInstance)
        ContentPanel.AddContentToView("Account", New AccountContent())
        ContentPanel.AddContentToView("Logout", New LogoutContent())



    End Sub

    ' ✅ Display a UserControl inside the main content area
    Private Sub ShowControl(uc As UserControl)
        If uc IsNot Nothing Then
            uc.Dock = DockStyle.Fill
            SiticoneDashboardCard1.Controls.Clear()
            SiticoneDashboardCard1.Controls.Add(uc)
        End If
    End Sub

    ' ✅ Resize logic fix: swapped width/height parameters
    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Panel1.Size = New Size(Panel1.Width, 400)
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Panel1.Size = New Size(Panel1.Width, 300)
        End If
    End Sub

    ' ✅ Optional: remove or use this event properly
    Private Sub ContentPanel_Paint(sender As Object, e As PaintEventArgs)
        ' Avoid placing logic here unless you're doing custom drawing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub SiticoneNavbar1_SelectedItemChanged(sender As Object, e As SiticoneNavbar.NavBarSelectionEventArgs)


    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ' 🔥 If logout is triggering this close → allow it (NO MESSAGE)
        If IsLoggingOut = True Then
            IsLoggingOut = False ' reset the flag
            Return
        End If

        ' 🔥 This part runs only if user clicks the X button manually
        If e.CloseReason = CloseReason.UserClosing Then

            Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                e.Cancel = True
            End If

        End If

    End Sub


    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If IsLoggingOut = False Then
            ' User manually closed the dashboard → exit the whole app
            Application.Exit()
        End If
        ' If logging out → DO NOT EXIT APP (Login will show)
    End Sub


End Class
