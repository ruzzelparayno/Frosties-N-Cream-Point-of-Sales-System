Imports SiticoneNetFrameworkUI

Public Class DashboardContent


    Private Sub DashboardContent_Resize(sender As Object, e As EventArgs)

        If Me.Parent IsNot Nothing AndAlso Me.Parent.FindForm().WindowState = FormWindowState.Maximized Then
            ' When maximized, set Top padding = 50 
            Panel2.Size = New Size(Panel2.Height, 175)
            '758, 125
            Label2.Font = New Font(Label2.Font.FontFamily, 20, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 60, Label3.Font.Style)


            Label5.Font = New Font(Label5.Font.FontFamily, 20, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 60, Label4.Font.Style)

            Label7.Font = New Font(Label7.Font.FontFamily, 20, Label7.Font.Style)
            Label6.Font = New Font(Label6.Font.FontFamily, 60, Label6.Font.Style)


        Else
            ' When restored, set Top padding = 10 
            Panel2.Size = New Size(Panel2.Height, 125)

            Label2.Font = New Font(Label2.Font.FontFamily, 12, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 40, Label3.Font.Style)

            Label5.Font = New Font(Label5.Font.FontFamily, 12, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 40, Label4.Font.Style)

            Label7.Font = New Font(Label7.Font.FontFamily, 12, Label7.Font.Style)
            Label6.Font = New Font(Label6.Font.FontFamily, 40, Label6.Font.Style)


        End If

    End Sub


End Class
