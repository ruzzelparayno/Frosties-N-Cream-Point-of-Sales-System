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
        ShowControl(New CategoryContent())
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        ShowControl(New ProductContent())
    End Sub

End Class
