Imports MySql.Data.MySqlClient

Public Class UserContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")

    Private Sub UserContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 🔹 Load categories and products when the form/control opens
        LoadUsers()
        cb_sq.DropDownStyle = ComboBoxStyle.DropDownList
        cb_ur.DropDownStyle = ComboBoxStyle.DropDownList
        SiticoneTextBox6.UseSystemPasswordChar = True
        SiticoneTextBox3.UseSystemPasswordChar = True
        SiticoneTextBox6.PasswordChar = "•"c
        SiticoneTextBox3.PasswordChar = "•"c
    End Sub
    ' 🔹 Function to hash a string with SHA256
    Private Function HashText(input As String) As String
        Using sha As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub LoadUsers()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                Dim cmd As New MySqlCommand("SELECT userid, username, role, Secret_Question, email FROM users", conn)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Guna2DataGridView1.DataSource = dt


                If Guna2DataGridView1.Columns.Contains("userid") Then
                    Guna2DataGridView1.Columns("userid").Width = 50
                End If
                If Guna2DataGridView1.Columns.Contains("username") Then
                    Guna2DataGridView1.Columns("username").Width = 100
                End If
                If Guna2DataGridView1.Columns.Contains("role") Then
                    Guna2DataGridView1.Columns("role").Width = 100
                End If
                If Guna2DataGridView1.Columns.Contains("Secret_Question") Then
                    Guna2DataGridView1.Columns("Secret_Question").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                If Guna2DataGridView1.Columns.Contains("email") Then
                    Guna2DataGridView1.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        If Guna2DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user first.")
            Exit Sub
        End If

        Dim userid As Integer = Guna2DataGridView1.CurrentRow.Cells("userid").Value

        ' Validation
        If SiticoneTextBox5.Text = "" Or cb_ur.Text = "" Or cb_sq.Text = "" Or SiticoneTextBox1.Text = "" Or SiticoneTextBox7.Text = "" Then
            MessageBox.Show("Please fill all required fields.")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                ' 🔹 Update user info (no password here)
                Dim query = "UPDATE users SET username=@username, role=@role, Secret_Question=@secretQ, Secret_Answer=@secretA, email=@Email WHERE userid=@userid"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", SiticoneTextBox5.Text.Trim)
                    cmd.Parameters.AddWithValue("@role", cb_ur.Text.Trim)
                    cmd.Parameters.AddWithValue("@secretQ", cb_sq.Text.Trim)
                    cmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text.Trim)
                    cmd.Parameters.AddWithValue("@userid", userid)

                    ' 🔒 Always hash secret answer
                    cmd.Parameters.AddWithValue("@secretA", HashText(SiticoneTextBox7.Text.Trim))

                    Dim rowsAffected = cmd.ExecuteNonQuery
                    If rowsAffected = 0 Then
                        Throw New Exception("No rows were updated. Check if userid exists.")
                    End If
                End Using
            End Using

            MessageBox.Show("The user information has been updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Unable to update the user. Please try again." & vbCrLf & "Error details: " & ex.Message,
        "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        SiticoneTextBox5.Clear() 'USERNAME
        SiticoneTextBox6.Clear() 'PASSWORD
        SiticoneTextBox6.Enabled = False
        SiticoneTextBox3.Enabled = False 'CONFIRM PASSWORD
        SiticoneTextBox1.Enabled = False 'EMAIL
        SiticoneTextBox3.Clear()
        SiticoneTextBox7.Clear() 'SECRET ANSWER
        SiticoneTextBox1.Clear()
        cb_ur.SelectedIndex = -1
        cb_sq.SelectedIndex = -1
    End Sub



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
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()


                Dim checkUserQuery = "SELECT COUNT(*) FROM users WHERE username=@username"
                Using checkCmd As New MySqlCommand(checkUserQuery, conn)
                    checkCmd.Parameters.AddWithValue("@username", SiticoneTextBox5.Text)
                    Dim count = Convert.ToInt32(checkCmd.ExecuteScalar)
                    If count > 0 Then
                        MessageBox.Show("Username is already used. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                Dim checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email=@Email"
                Using checkCmd As New MySqlCommand(checkEmailQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text)
                    Dim count = Convert.ToInt32(checkCmd.ExecuteScalar)
                    If count > 0 Then
                        MessageBox.Show("Email is already used. Please use another email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using


                Dim query = "INSERT INTO users(username, password, role, Secret_Question, Secret_Answer, email) VALUES(@username, @password, @role, @secretQ, @secretA, @Email)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", SiticoneTextBox5.Text)
                    cmd.Parameters.AddWithValue("@password", HashText(SiticoneTextBox6.Text))
                    cmd.Parameters.AddWithValue("@role", cb_ur.Text)
                    cmd.Parameters.AddWithValue("@secretQ", cb_sq.Text)
                    cmd.Parameters.AddWithValue("@secretA", HashText(SiticoneTextBox7.Text))
                    cmd.Parameters.AddWithValue("@Email", SiticoneTextBox1.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

            LoadUsers()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error inserting user: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs)
        SiticoneTextBox5.Clear()
        SiticoneTextBox6.Clear()
        SiticoneTextBox6.Enabled = True
        SiticoneTextBox3.Enabled = True
        SiticoneTextBox3.Clear()
        SiticoneTextBox7.Clear()
        SiticoneTextBox1.Clear()
        cb_ur.SelectedIndex = -1
        cb_sq.SelectedIndex = -1
        SiticoneTextBox5.Focus()
        SiticoneTextBox1.Enabled = True
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row = Guna2DataGridView1.Rows(e.RowIndex)
            SiticoneTextBox5.Text = row.Cells("username").Value.ToString
            cb_ur.Text = row.Cells("role").Value.ToString
            cb_sq.Text = row.Cells("Secret_Question").Value.ToString
            SiticoneTextBox1.Text = row.Cells("email").Value.ToString


            Dim userid = row.Cells("userid").Value.ToString



            Try
                Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                    conn.Open()
                    Dim cmd As New MySqlCommand("SELECT password FROM users WHERE userid=@userid", conn)
                    cmd.Parameters.AddWithValue("@userid", userid)
                    Dim dbPassword = cmd.ExecuteScalar

                    If dbPassword IsNot Nothing Then
                        SiticoneTextBox6.Text = dbPassword.ToString
                        SiticoneTextBox3.Text = dbPassword.ToString
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



            SiticoneTextBox1.Enabled = False
            SiticoneTextBox5.Enabled = False
            SiticoneTextBox3.Enabled = False

        End If
    End Sub
End Class
