Public Class DashboardContent

    Private Sub DashboardContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdjustLayout()
    End Sub

    Private Sub DashboardContent_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AdjustLayout()
    End Sub

    Private Sub AdjustLayout()
        Dim parentForm As Form = Nothing
        Dim isMaximized As Boolean = False

        ' 🔹 Safely check if the parent form exists
        Try
            If Me.Parent IsNot Nothing Then
                parentForm = Me.Parent.FindForm()
            End If
        Catch
            ' Ignore, just means parent form not yet available
        End Try

        ' 🔹 If we found a parent form, check its window state
        If parentForm IsNot Nothing Then
            isMaximized = (parentForm.WindowState = FormWindowState.Maximized)
        End If

        ' 🔹 Apply layout based on the form’s state
        If isMaximized Then
            Panel2.Size = New Size(758, 175)

            Label2.Font = New Font(Label2.Font.FontFamily, 20, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 60, Label3.Font.Style)

            Label5.Font = New Font(Label5.Font.FontFamily, 20, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 60, Label4.Font.Style)

            Label7.Font = New Font(Label7.Font.FontFamily, 20, Label7.Font.Style)
            Label6.Font = New Font(Label6.Font.FontFamily, 60, Label6.Font.Style)

        Else
            Panel2.Size = New Size(758, 125)

            Label2.Font = New Font(Label2.Font.FontFamily, 12, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 40, Label3.Font.Style)

            Label5.Font = New Font(Label5.Font.FontFamily, 12, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 40, Label4.Font.Style)

            Label7.Font = New Font(Label7.Font.FontFamily, 12, Label7.Font.Style)
            Label6.Font = New Font(Label6.Font.FontFamily, 40, Label6.Font.Style)
        End If
    End Sub

End Class
