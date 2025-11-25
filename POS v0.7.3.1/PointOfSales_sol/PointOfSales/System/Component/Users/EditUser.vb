Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class EditUser
    Public CurrentUserID As Integer = -1

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdminPass.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
        txtPassword.UseSystemPasswordChar = True
        txtAdminPass.PasswordChar = "•"c
        txtConfirmPass.PasswordChar = "•"c
        txtPassword.PasswordChar = "•"c
        satextbox.UseSystemPasswordChar = True
        satextbox.PasswordChar = "•"c
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cb_sq.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Function HashText(input As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(input)
            Dim hash = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If CurrentUserID = -1 Then
            MessageBox.Show("No user selected.")
            Exit Sub
        End If

        ' VALIDATION
        If txtPassword.Text = "" Or txtConfirmPass.Text = "" Or txtAdminPass.Text = "" Then
            MessageBox.Show("Please fill all password fields.")
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPass.Text Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If

        If cb_sq.Text = "" Or satextbox.Text = "" Then
            MessageBox.Show("Please fill the security question and answer.")
            Exit Sub
        End If

        ' VERIFY ADMIN PASSWORD
        Dim adminCorrect As Boolean = False

        Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
            conn.Open()

            Dim checkAdmin = "SELECT COUNT(*) FROM users WHERE username='admin' AND password=@pass"
            Using cmd As New MySqlCommand(checkAdmin, conn)
                cmd.Parameters.AddWithValue("@pass", HashText(txtAdminPass.Text))
                adminCorrect = (Convert.ToInt32(cmd.ExecuteScalar()) = 1)
            End Using
        End Using

        If Not adminCorrect Then
            MessageBox.Show("Admin password is incorrect.")
            Exit Sub
        End If

        ' UPDATE USER DATA
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                ' 🔥 Updated to use Secret_Question and Secret_Answer
                Dim query As String =
                    "UPDATE users SET username=@u, email=@e, role=@r, password=@p, " &
                    "Secret_Question=@sq, Secret_Answer=@sa WHERE userid=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@r", cbRole.Text)
                    cmd.Parameters.AddWithValue("@p", HashText(txtPassword.Text))
                    cmd.Parameters.AddWithValue("@sq", cb_sq.Text)
                    cmd.Parameters.AddWithValue("@sa", HashText(satextbox.Text))  ' 🔥 hashed answer
                    cmd.Parameters.AddWithValue("@id", CurrentUserID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' REFRESH USER LIST + OVERLAY
            UserContent.Instance.LoadUsers()

            Me.Close()

            MessageBox.Show(
                "User updated successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            UserContent.Instance.SiticoneOverlay1.Show = True
            Await Task.Delay(1500)
            UserContent.Instance.SiticoneOverlay1.Show = False

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try

    End Sub

End Class
