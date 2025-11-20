
Imports MySql.Data.MySqlClient


Public Class CategoryContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Dim connectionString As String = "server=localhost;userid=root;password=;database=pos"
    Private selectedCategoryID As Integer = -1 ' Track selected row for editing

    ' ✅ Function to load all categories into GunaDataGridView1
    Public Sub LoadCategoriesToGrid()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT CategoryID, CategoryName, Description FROM categories"
                Dim da As New MySqlDataAdapter(query, connection)
                Dim dt As New DataTable()
                da.Fill(dt)
                Guna2DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error loading categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Load categories when form loads
    Private Sub CategoryContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategoriesToGrid()
    End Sub

    ' ✅ Resize font logic
    Private Sub CategoryContent_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If Me.Parent IsNot Nothing AndAlso Me.Parent.FindForm().WindowState = FormWindowState.Maximized Then
                SiticoneTextBox1.Font = New Font(SiticoneTextBox1.Font.FontFamily, 16, SiticoneTextBox1.Font.Style)
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, 16, TextBox1.Font.Style)
            Else
                SiticoneTextBox1.Font = New Font(SiticoneTextBox1.Font.FontFamily, 12, SiticoneTextBox1.Font.Style)
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, 12, TextBox1.Font.Style)
            End If
        Catch ex As Exception
            Debug.WriteLine("Resize error in CategoryContent: " & ex.Message)
        End Try
    End Sub

    ' ✅ Add a new category
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If SiticoneTextBox1.Text.Trim() = "" Or TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO categories (CategoryName, Description) VALUES (@categoryName, @description)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@categoryName", SiticoneTextBox1.Text.Trim())
            cmd.Parameters.AddWithValue("@description", TextBox1.Text.Trim())
            cmd.ExecuteNonQuery()

            MessageBox.Show("✅ Category saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh product combo in ProductContent if open
            Dim productContentInstance As ProductContent = Nothing
            For Each f As Form In Application.OpenForms
                For Each ctrl As Control In f.Controls
                    If TypeOf ctrl Is ProductContent Then
                        productContentInstance = DirectCast(ctrl, ProductContent)
                        Exit For
                    End If
                Next
            Next
            If productContentInstance IsNot Nothing Then
                productContentInstance.LoadCategories()
            End If

            ' Refresh grid and clear inputs
            LoadCategoriesToGrid()
            SiticoneTextBox1.Clear()
            TextBox1.Clear()
            selectedCategoryID = -1

        Catch ex As Exception
            MessageBox.Show("❌ Error saving category: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' ✅ Handle row click to edit
    Private Sub Guna2DataGridView1_Click(sender As Object, e As EventArgs) Handles Guna2DataGridView1.Click
        Try
            If Guna2DataGridView1.CurrentRow IsNot Nothing Then
                Dim row = Guna2DataGridView1.CurrentRow
                selectedCategoryID = Convert.ToInt32(row.Cells("CategoryID").Value)
                SiticoneTextBox1.Text = row.Cells("CategoryName").Value.ToString()
                TextBox1.Text = row.Cells("Description").Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting row: " & ex.Message)
        End Try
    End Sub

    ' ✅ Update existing category
    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        If selectedCategoryID = -1 Then
            MessageBox.Show("Please select a category to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SiticoneTextBox1.Text.Trim() = "" Or TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE categories SET CategoryName=@name, Description=@desc WHERE CategoryID=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", SiticoneTextBox1.Text.Trim())
            cmd.Parameters.AddWithValue("@desc", TextBox1.Text.Trim())
            cmd.Parameters.AddWithValue("@id", selectedCategoryID)
            cmd.ExecuteNonQuery()

            MessageBox.Show("✅ Category updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh grid and clear fields
            LoadCategoriesToGrid()
            SiticoneTextBox1.Clear()
            TextBox1.Clear()
            selectedCategoryID = -1

        Catch ex As Exception
            MessageBox.Show("❌ Error updating category: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
