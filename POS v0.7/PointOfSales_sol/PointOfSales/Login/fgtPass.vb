Imports System.Security.Cryptography
Imports System.Text
Imports System.Timers
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto
Imports SiticoneNetFrameworkUI

Public Class fgtPass

    Public Property UserEmail As String

    Private currentStep As Integer = 1

    ' 🔹 Same SHA256 Hash Function (must match login 100%)
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Trim()))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2")) ' lowercase hex
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



    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click

        Select Case currentStep

            ' -------------------------------
            ' STEP 1 — CHECK EMAIL
            ' -------------------------------
            Case 1
                If SiticoneTextBox1.Text.Trim() = "" Then
                    MessageBox.Show("Please enter your email.")
                    Exit Sub
                End If

                Try
                    Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                        conn.Open()

                        Dim query As String = "SELECT Secret_Question FROM users WHERE email=@Email LIMIT 1"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text.Trim())

                            Dim result As Object = cmd.ExecuteScalar()

                            If result IsNot Nothing Then
                                SiticoneLabel1.Text = result.ToString()
                                SiticoneLabel1.Visible = True
                                SiticoneTextBox2.Visible = True
                                SiticoneTextBox2.Text = ""

                                UserEmail = SiticoneTextBox1.Text.Trim()

                                currentStep = 2
                                SiticoneButton1.Text = "Next"
                            Else
                                MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error checking email: " & ex.Message)
                End Try

            ' -------------------------------
            ' STEP 2 — CHECK SECRET ANSWER
            ' -------------------------------
            Case 2

                If SiticoneTextBox2.Text.Trim() = "" Then
                    MessageBox.Show("Please enter your secret answer.")
                    Exit Sub
                End If

                Try
                    Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                        conn.Open()

                        Dim query As String = "SELECT Secret_Answer FROM users WHERE email=@Email LIMIT 1"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Email", UserEmail)

                            Dim storedHash As Object = cmd.ExecuteScalar()

                            If storedHash IsNot Nothing Then

                                Dim enteredHash As String = HashPassword(SiticoneTextBox2.Text.Trim())

                                If enteredHash = storedHash.ToString() Then

                                    MessageBox.Show("Your answer is correct!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    currentStep = 3
                                    SiticoneLabel1.Visible = False
                                    SiticoneTextBox2.Visible = False

                                    SiticoneLabel5.Visible = True
                                    SiticoneTextBox4.Visible = True
                                    SiticoneLabel3.Visible = True
                                    SiticoneTextBox3.Visible = True
                                    SiticoneButton1.Text = "Reset Password"

                                Else
                                    MessageBox.Show("Incorrect secret answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            Else
                                MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error checking answer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            ' -------------------------------
            ' STEP 3 — RESET PASSWORD
            ' -------------------------------
            Case 3

                If SiticoneTextBox4.Text.Trim() = "" Or SiticoneTextBox3.Text.Trim() = "" Then
                    MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If SiticoneTextBox4.Text.Trim() <> SiticoneTextBox3.Text.Trim() Then
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Try
                    Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                        conn.Open()

                        Dim newPass As String = SiticoneTextBox4.Text.Trim()
                        Dim hashedPassword As String = HashPassword(newPass)

                        Dim query As String = "UPDATE users SET password=@Password WHERE email=@Email"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Password", hashedPassword)
                            cmd.Parameters.AddWithValue("@Email", UserEmail)

                            Dim rowsAffected = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ShowControl(New LoginPass())
                            Else
                                MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
