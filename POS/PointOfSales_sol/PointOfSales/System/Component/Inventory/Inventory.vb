Imports SiticoneNetFrameworkUI

Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowControl(New ProductContent())

    End Sub
    Private Sub ShowControl(uc As UserControl)
        uc.Dock = DockStyle.Fill
        Panel2.Controls.Clear()
        Panel2.Controls.Add(uc)
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click


        btnCategory.ButtonBackColor = Color.FromArgb(74, 144, 226)
        btnCategory.TextColor = Color.White
        btnCategory.BorderColor = Color.FromArgb(74, 144, 226)

        SiticoneButton1.ButtonBackColor = Color.White
        SiticoneButton1.TextColor = Color.FromArgb(74, 144, 226)

        ShowControl(New CategoryContent())
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click


        SiticoneButton1.ButtonBackColor = Color.FromArgb(74, 144, 226)
        SiticoneButton1.TextColor = Color.White
        SiticoneButton1.BorderColor = Color.FromArgb(74, 144, 226)

        btnCategory.ButtonBackColor = Color.White
        btnCategory.TextColor = Color.FromArgb(74, 144, 226)

        ShowControl(New ProductContent())
    End Sub

End Class
