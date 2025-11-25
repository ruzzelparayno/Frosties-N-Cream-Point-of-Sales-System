Public Class LogoutContent

    ' ================================
    ' YES BUTTON (SiticoneButton1)
    ' ================================
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click

        ' Clear user session data
        ClearUserData()

        ' Clear Login textboxes
        Login.SiticoneTextBox1.Text = ""
        Login.SiticoneTextBox2.Text = ""

        ' Set focus back to username field
        Login.SiticoneTextBox1.Focus()



        ' Close Dashboard
        Dashboard.Close()

        ' Show message
        MessageBox.Show("You have been logged out successfully!",
                        "Logout",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        ' Show login form again
        Login.Show()

    End Sub


    ' ================================
    ' CLEAR USER SESSION DATA
    ' ================================
    Private Sub ClearUserData()
        LoginPass.currentUsername = String.Empty

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

    End Sub


    ' ================================
    ' NO BUTTON (SiticoneButton2)
    ' ================================
    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        MessageBox.Show("Logout cancelled.",
                        "Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

End Class
