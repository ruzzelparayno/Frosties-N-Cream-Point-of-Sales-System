Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneHProgressBar1.Value = 0
        Timer1.Interval = 90   ' speed of loading (lower = faster)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SiticoneHProgressBar1.Value += 1

        ' Optional: update percentage label

        If SiticoneHProgressBar1.Value >= 100 Then
            Timer1.Stop()

            ' Show login form and hide splash
            Dim loginForm As New Login
            Login.Show()

            Me.Hide()
        End If
    End Sub
End Class