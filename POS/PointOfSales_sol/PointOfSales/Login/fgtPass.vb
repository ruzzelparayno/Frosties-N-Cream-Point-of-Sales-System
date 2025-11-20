Imports System.Security.Cryptography
Imports System.Text
Imports System.Timers
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto
Imports SiticoneNetFrameworkUI

Public Class fgtPass

    Public Property UserEmail As String

    ' Track attempts and lockout
    Private attemptCount As Integer = 0
    Private isLocked As Boolean = False
    Private lockoutEnd As DateTime

    ' 🔹 Function to hash input with SHA256
    Private Function HashInput(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub ShowControl(uc As UserControl)
        uc.Dock = DockStyle.Fill
        Login.Panel8.Controls.Clear()
        Login.Panel8.Controls.Add(uc)


    End Sub

    Private Sub SiticoneLabel4_Click_1(sender As Object, e As EventArgs) Handles SiticoneLabel4.Click
        ShowControl(New LoginPass())
    End Sub

    Private currentStep As Integer = 1

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        ''email textbox and label
        'SiticoneLabel2.Visible = Email label
        'SiticoneTextBox1.Visible = Email txtbox


        ''security question label and textbox
        'SiticoneLabel1.Visible = SecQ Label
        'SiticoneTextBox2.Visible = SecQ Txtbox

        ''new password, Confirm password Textbox and label
        'SiticoneLabel5.Visible = Npass Label
        'SiticoneTextBox4.Visible =  Npass Txtbox

        'SiticoneLabel3.Visible = Cpass Label
        'SiticoneTextBox3.Visible = Cpass Txtbox
        Select Case currentStep
            Case 1
                ' Step 1: Check Email
                If SiticoneTextBox1.Text.Trim() = "" Then
                    MessageBox.Show("Please enter your email.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Try
                    Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                        conn.Open()

                        ' Get the secret question for the entered email
                        Dim query As String = "SELECT Secret_Question FROM users WHERE email=@Email"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text.Trim())
                            Dim result As Object = cmd.ExecuteScalar()

                            If result IsNot Nothing Then
                                ' ✅ Email exists, show secret question automatically
                                SiticoneLabel1.Text = result.ToString()
                                SiticoneLabel1.Visible = True
                                SiticoneTextBox2.Visible = True
                                SiticoneTextBox2.Text = "" ' Clear previous input
                                UserEmail = SiticoneTextBox1.Text.Trim()

                                currentStep = 2 ' Move to next step automatically
                                SiticoneButton1.Text = "Next"
                            Else
                                MessageBox.Show("Email not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error checking email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Case 2
                ' Step 2: Check Security Answer
                If SiticoneTextBox2.Text.Trim() = "" Then
                    MessageBox.Show("Please enter your secret answer.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Try
                    Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                        conn.Open()

                        Dim query As String = "SELECT Secret_Answer FROM users WHERE email=@Email"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Email", UserEmail)
                            Dim storedHash As Object = cmd.ExecuteScalar()

                            If storedHash IsNot Nothing AndAlso Not DBNull.Value.Equals(storedHash) Then
                                Dim enteredHash As String = HashInput(SiticoneTextBox2.Text.Trim())

                                If enteredHash.Equals(storedHash.ToString(), StringComparison.OrdinalIgnoreCase) Then
                                    MessageBox.Show("Your answer is correct!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    ' Move to password reset step
                                    currentStep = 3
                                    SiticoneLabel1.Visible = False
                                    SiticoneTextBox2.Visible = False
                                    SiticoneLabel5.Visible = True
                                    SiticoneTextBox4.Visible = True
                                    SiticoneLabel3.Visible = True
                                    SiticoneTextBox3.Visible = True
                                    SiticoneButton1.Text = "Reset Password"
                                Else
                                    MessageBox.Show("Your answer is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("No account found for this email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error checking secret answer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Case 3
                ' Step 3: Reset Password
                If SiticoneTextBox4.Text.Trim() = "" Or SiticoneTextBox3.Text.Trim() = "" Then
                    MessageBox.Show("Please fill out both fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Select
                End If

                If SiticoneTextBox4.Text.Trim() <> SiticoneTextBox3.Text.Trim() Then
                    MessageBox.Show("Passwords do not match. Please try again.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If

                Try
                    Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                        conn.Open()

                        ' 🔹 Hash the new password before saving
                        Dim hashedPassword As String = HashPassword(SiticoneTextBox4.Text.Trim())

                        Dim query As String = "UPDATE users SET password=@Password WHERE email=@Email"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Password", hashedPassword)
                            cmd.Parameters.AddWithValue("@Email", UserEmail)

                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' Hide password fields
                                SiticoneLabel5.Visible = False
                                SiticoneTextBox4.Visible = False
                                SiticoneLabel3.Visible = False
                                SiticoneTextBox3.Visible = False

                                ' Reset step
                                currentStep = 1
                                SiticoneButton1.Text = "Continue"

                                ' Show Login form and close current form
                                ShowControl(New LoginPass())
                            Else
                                MessageBox.Show("Failed to update password. Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error updating password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

        End Select
    End Sub

    Private Sub fgtPass_Load(sender As Object, e As EventArgs) Handles Me.Load
        SiticoneLabel2.Visible = True
        SiticoneTextBox1.Visible = True

        SiticoneLabel1.Visible = False
        SiticoneTextBox2.Visible = False

        SiticoneLabel5.Visible = False
        SiticoneTextBox4.Visible = False
        SiticoneLabel3.Visible = False
        SiticoneTextBox3.Visible = False

        SiticoneButton1.Text = "Next"
    End Sub

    Private Sub fp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneTextBox2.PasswordChar = "●"c
        SiticoneTextBox2.UseSystemPasswordChar = True
        SiticoneTextBox3.PasswordChar = "●"c
        SiticoneTextBox3.UseSystemPasswordChar = True
        SiticoneTextBox4.PasswordChar = "●"c
        SiticoneTextBox4.UseSystemPasswordChar = True
    End Sub

End Class
