Public Class LogoutContent
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click

        ' Clear any user-related data
        ClearUserData()

        ' Show the login form
        Login.Show()

        ' Close the current form
        Dashboard.Close()
    End Sub

    ' Function to clear all user session data
    Private Sub ClearUserData()
        ' Example: clear global username variable
        LoginPass.currentUsername = String.Empty

        ' Clear any form controls that might hold sensitive data
        ' For example, if you have TextBoxes or labels showing user info:
        Try
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()
                ElseIf TypeOf ctrl Is Label Then
                    DirectCast(ctrl, Label).Text = ""
                End If
            Next
        Catch ex As Exception
            ' Ignore errors during cleanup
        End Try

        ' You can also reset other global or shared variables related to the session
    End Sub

    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        ' Just cancel the logout, optionally clear selection or close panel
        MessageBox.Show("Logout cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
