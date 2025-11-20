Imports System.Data.SQLite
Imports System.Security.Cryptography ' 🔹 REQUIRED for Hashing
Imports System.Text ' 🔹 REQUIRED for Encoding

Public Class UserContent
    ' 🔹 SQLite connection string (use your .db file)
    Private dbName As String = "pos.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private consString As String = "Data Source=" & dbPath & ";Version=3;"

    Private conn As New SQLiteConnection(consString)

    ' 🔹 NEW HELPER FUNCTION: Generates SHA256 Hash
    Private Function ComputeHash(ByVal rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            ' ComputeHash - returns byte array
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))

            ' Convert byte array to a hexadecimal string
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub UserContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        cb_sq.DropDownStyle = ComboBoxStyle.DropDownList
        cb_ur.DropDownStyle = ComboBoxStyle.DropDownList
        SiticoneTextBox6.UseSystemPasswordChar = True
        SiticoneTextBox3.UseSystemPasswordChar = True
        SiticoneTextBox6.PasswordChar = "•"c
        SiticoneTextBox3.PasswordChar = "•"c
    End Sub

    Private Sub LoadUsers()
        Try
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT UserID, Username, Role, Secret_Question, Email FROM users", conn)
            Dim da As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Guna2DataGridView1.DataSource = dt

            ' Adjust column widths
            If Guna2DataGridView1.Columns.Contains("UserID") Then Guna2DataGridView1.Columns("UserID").Width = 50
            If Guna2DataGridView1.Columns.Contains("Username") Then Guna2DataGridView1.Columns("Username").Width = 100
            If Guna2DataGridView1.Columns.Contains("Role") Then Guna2DataGridView1.Columns("Role").Width = 100
            If Guna2DataGridView1.Columns.Contains("Secret_Question") Then Guna2DataGridView1.Columns("Secret_Question").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            If Guna2DataGridView1.Columns.Contains("Email") Then Guna2DataGridView1.Columns("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' 🔹 UPDATE USER
    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        If Guna2DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user first.")
            Exit Sub
        End If

        Dim userid As Integer = Guna2DataGridView1.CurrentRow.Cells("UserID").Value

        If SiticoneTextBox5.Text = "" Or cb_ur.Text = "" Or cb_sq.Text = "" Or SiticoneTextBox1.Text = "" Or SiticoneTextBox7.Text = "" Then
            MessageBox.Show("Please fill all required fields.")
            Exit Sub
        End If

        Try
            conn.Open()
            ' Note: The password column is NOT updated in this query, but the Secret Answer is.
            Dim query = "UPDATE users SET Username=@username, Role=@role, Secret_Question=@secretQ, Secret_Answer=@secretA, Email=@Email WHERE UserID=@userid"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", SiticoneTextBox5.Text.Trim)
                cmd.Parameters.AddWithValue("@role", cb_ur.Text.Trim)
                cmd.Parameters.AddWithValue("@secretQ", cb_sq.Text.Trim)
                cmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text.Trim)
                cmd.Parameters.AddWithValue("@userid", userid)

                ' 🔹 HASH THE SECRET ANSWER BEFORE UPDATING
                cmd.Parameters.AddWithValue("@secretA", ComputeHash(SiticoneTextBox7.Text.Trim))

                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected = 0 Then
                    Throw New Exception("No rows were updated. Check if userid exists.")
                End If
            End Using
            MessageBox.Show("The user information has been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Unable to update the user. Please try again." & vbCrLf & "Error details: " & ex.Message,
                            "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' 🔹 SAVE / INSERT USER
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If SiticoneTextBox5.Text = "" Or SiticoneTextBox6.Text = "" Or SiticoneTextBox3.Text = "" Or cb_ur.Text = "" Or cb_sq.Text = "" Or SiticoneTextBox1.Text = "" Or SiticoneTextBox7.Text = "" Then
            MessageBox.Show("Please fill all required fields.")
            Exit Sub
        End If

        If SiticoneTextBox6.Text <> SiticoneTextBox3.Text Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If

        Try
            conn.Open()

            ' Check duplicate username
            Dim checkUserQuery = "SELECT COUNT(*) FROM users WHERE Username=@username"
            Using checkCmd As New SQLiteCommand(checkUserQuery, conn)
                checkCmd.Parameters.AddWithValue("@username", SiticoneTextBox5.Text)
                Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Username is already used. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Check duplicate email
            Dim checkEmailQuery = "SELECT COUNT(*) FROM users WHERE Email=@Email"
            Using checkCmd As New SQLiteCommand(checkEmailQuery, conn)
                checkCmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text)
                Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Email is already used. Please use another email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Insert user
            Dim query = "INSERT INTO users(Username, Password, Role, Secret_Question, Secret_Answer, Email) VALUES(@username, @password, @role, @secretQ, @secretA, @Email)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", SiticoneTextBox5.Text)

                ' 🔹 HASH THE PASSWORD
                cmd.Parameters.AddWithValue("@password", ComputeHash(SiticoneTextBox6.Text.Trim))

                cmd.Parameters.AddWithValue("@role", cb_ur.Text)
                cmd.Parameters.AddWithValue("@secretQ", cb_sq.Text)

                ' 🔹 HASH THE SECRET ANSWER
                cmd.Parameters.AddWithValue("@secretA", ComputeHash(SiticoneTextBox7.Text.Trim))

                cmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error inserting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        SiticoneTextBox5.Clear()
        SiticoneTextBox6.Clear()
        SiticoneTextBox6.Enabled = True
        SiticoneTextBox3.Enabled = True
        SiticoneTextBox1.Enabled = True
        SiticoneTextBox3.Clear()
        SiticoneTextBox7.Clear()
        SiticoneTextBox1.Clear()
        cb_ur.SelectedIndex = -1
        cb_sq.SelectedIndex = -1
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row = Guna2DataGridView1.Rows(e.RowIndex)
            SiticoneTextBox5.Text = row.Cells("username").Value.ToString()
            cb_ur.Text = row.Cells("role").Value.ToString()
            cb_sq.Text = row.Cells("Secret_Question").Value.ToString()
            SiticoneTextBox1.Text = row.Cells("email").Value.ToString()

            ' 🔹 IMPORTANT: The logic to fetch and display the plain-text password is removed.
            ' Since we store a SHA-256 hash, we cannot reverse it to show the original password.
            SiticoneTextBox6.Clear() ' Clear password field
            SiticoneTextBox3.Clear() ' Clear confirm password field

            SiticoneTextBox1.Enabled = False
            SiticoneTextBox5.Enabled = False
            SiticoneTextBox6.Enabled = False
            SiticoneTextBox3.Enabled = False
        End If
    End Sub
End Class