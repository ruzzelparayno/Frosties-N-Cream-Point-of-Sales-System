Public Class Login


    Public Shared IsLoggingOut As Boolean = False
    Private Sub ShowControl(uc As UserControl)
        uc.Dock = DockStyle.Fill
        Panel8.Controls.Clear()
        Panel8.Controls.Add(uc)
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowControl(New LoginPass)
    End Sub


    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            ' When maximized, set Top padding = 50
            Panel8.Padding = New Padding(Panel8.Padding.Left, 150, Panel8.Padding.Right, Panel8.Padding.Bottom)

            Label1.Font = New Font("Segoe UI", 40, FontStyle.Bold)
            Label1.Size = New Size(550, Panel5.Size.Width)
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ' When restored, set Top padding = 10
            Panel8.Padding = New Padding(Panel8.Padding.Left, 50, Panel8.Padding.Right, Panel8.Padding.Bottom)

            Label1.Font = New Font("Segoe UI", 25, FontStyle.Bold)
            Label1.Size = New Size(418, Label1.Size.Width)
        End If

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If IsLoggingOut = False Then
            ' User manually closed the dashboard → exit the whole app
            Application.Exit()
        End If
        ' If logging out → DO NOT EXIT APP (Login will show)
    End Sub
End Class
