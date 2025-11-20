Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports SiticoneNetFrameworkUI

Public Class LoginPass

    Public Shared currentUsername As String = ""

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")

    ' 🔹 Unified SHA-256 Hash Function (used in both Login + Forgot)
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Trim()))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2")) ' ALWAYS lowercase hex
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub ShowControl(uc As UserControl)
        uc.Dock = DockStyle.Fill
        Login.Panel8.Controls.Clear()
        Login.Panel8.Controls.Add(uc)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiticoneTextBox2.UseSystemPasswordChar = True
        SiticoneTextBox2.PasswordChar = "•"c
    End Sub

    Private Sub SiticoneLabel4_Click_1(sender As Object, e As EventArgs) Handles SiticoneLabel4.Click
        ShowControl(New fgtPass())
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click

        Dim username As String = SiticoneTextBox1.Text.Trim()
        Dim password As String = SiticoneTextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        Dim hashedPassword As String = HashPassword(password)

        Try
            conn.Open()

            Dim query As String = "SELECT username, password, role FROM users WHERE username=@username LIMIT 1"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)

            ' 🔹 FIX #1: use SingleRow
            Dim reader As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleRow)

            If reader.Read() Then

                Dim dbPassword As String = reader("password").ToString()
                Dim dbRole As String = reader("role").ToString().ToLower()

                If dbPassword = hashedPassword Then

                    currentUsername = username

                    MessageBox.Show("Login successful!" & vbCrLf & "Role: " & dbRole)

                    If dbRole = "admin" Then
                        Dashboard.Show()
                        Login.Hide()
                    Else
                        CashierDashboard.Show()
                        Login.Hide()
                    End If

                Else
                    MessageBox.Show("Incorrect password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Username not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            reader.Close() ' 🔹 FIX #2: MUST close reader

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Show password
            SiticoneTextBox2.UseSystemPasswordChar = False
        Else
            ' Hide password
            SiticoneTextBox2.UseSystemPasswordChar = True
            SiticoneTextBox2.PasswordChar = "•"c
        End If
    End Sub

End Class
