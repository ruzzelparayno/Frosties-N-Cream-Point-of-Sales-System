Imports System.Data.SQLite

Public Class LoginPass
    Public Shared currentUsername As String = ""

    ' 🔹 SQLite connection string (use your .db file)
    Private dbName As String = "pos.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private consString As String = "Data Source=" & dbPath & ";Version=3;"

    Private conn As New SQLiteConnection(consString)

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
            Return
        End If

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM users WHERE Username=@username AND Password=@password"
            Dim cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password) ' plain text check

            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim role As String = reader("role").ToString().ToLower()

                MessageBox.Show("Login successful!" & vbCrLf & "Role: " & role,
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoginPass.currentUsername = username

                If role = "admin" Then
                    Dashboard.Show()
                    Login.Hide()
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
            SiticoneTextBox2.UseSystemPasswordChar = False
        Else
            SiticoneTextBox2.UseSystemPasswordChar = True
            SiticoneTextBox2.PasswordChar = "•"c
        End If
    End Sub

End Class
