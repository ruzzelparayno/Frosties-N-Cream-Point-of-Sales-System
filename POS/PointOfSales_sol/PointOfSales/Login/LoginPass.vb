Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text 'eto yung bago
Imports MySql.Data.MySqlClient
Imports SiticoneNetFrameworkUI
Public Class LoginPass
    Public Shared currentUsername As String = ""
    ' MySQL connection string to XAMPP
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")

    ' 🔹 Function to hash the password using SHA256
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set PasswordChar to mask the password
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
            Return
        End If

        ' 🔹 Hash the entered password before checking
        Dim hashedPassword As String = HashPassword(password)

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", hashedPassword) ' ✅ compare with hashed password

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim role As String = reader("role").ToString().ToLower()

                MessageBox.Show("Login successful!" & vbCrLf & "Role: " & role, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoginPass.currentUsername = username
                If role = "admin" Then
                    Dashboard.Show()
                    Login.Hide()
                    'MessageBox.Show("Access denied. Only admin is allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    CashierDashboard.Show()
                    Login.Hide()
                End If
            Else
                MessageBox.Show("Invalid username or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
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
