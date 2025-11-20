Public Class Login



    Private Sub ShowControl(uc As UserControl)
        uc.Dock = DockStyle.Fill
        SiticoneDragPanel1.Controls.Clear()
        SiticoneDragPanel1.Controls.Add(uc)
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowControl(New LoginPass)
    End Sub


    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            ' When maximized, set Top padding = 50
            SiticoneDragPanel1.Padding = New Padding(SiticoneDragPanel1.Padding.Left, 150, SiticoneDragPanel1.Padding.Right, SiticoneDragPanel1.Padding.Bottom)

            Label1.Font = New Font("Segoe UI", 40, FontStyle.Bold)
            Label1.Size = New Size(550, Panel5.Size.Width)
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ' When restored, set Top padding = 10
            SiticoneDragPanel1.Padding = New Padding(SiticoneDragPanel1.Padding.Left, 50, SiticoneDragPanel1.Padding.Right, SiticoneDragPanel1.Padding.Bottom)

            Label1.Font = New Font("Segoe UI", 25, FontStyle.Bold)
            Label1.Size = New Size(418, Label1.Size.Width)
        End If

    End Sub






End Class
