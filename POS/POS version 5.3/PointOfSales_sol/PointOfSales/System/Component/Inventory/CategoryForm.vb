Imports MySql.Data.MySqlClient

Public Class CategoryForm
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim categoryName As String = SiticoneTextBox1.Text.Trim()
        Dim description As String = TextBox1.Text.Trim()

        ' Check if fields are empty
        If categoryName = "" Or description = "" Then
            MessageBox.Show("Please fill in both Category and Description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check description word count
        Dim wordCount As Integer = description.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries).Length
        If wordCount < 10 Then
            MessageBox.Show("Description must have at least 10 words.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check for duplicate category name
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM categories WHERE category_name=@catName"
                Using cmd As New MySqlCommand(checkQuery, conn)
                    cmd.Parameters.AddWithValue("@catName", categoryName)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Category name already exists. Please enter a different name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Insert new category
                Dim insertQuery As String = "INSERT INTO categories (category_name, description) VALUES (@catName, @desc)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@catName", categoryName)
                    cmd.Parameters.AddWithValue("@desc", description)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Category saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear fields after saving
                SiticoneTextBox1.Clear()
                TextBox1.Clear()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Dashboard.posInstance.BringToFront()
    End Sub
End Class
