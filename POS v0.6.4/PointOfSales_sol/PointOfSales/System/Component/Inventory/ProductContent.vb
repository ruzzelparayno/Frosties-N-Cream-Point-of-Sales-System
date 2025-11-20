Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ProductContent
    Public Shared Instance As ProductContent
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"
    Private conn As New MySqlConnection(connectionString)
    Private selectedProductID As Integer = -1
    Private selectedImagePath As String = ""

    ' Load categories into combobox
    Public Sub LoadCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT CategoryName FROM categories"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cb_cate.Items.Clear()
            While reader.Read()
                cb_cate.Items.Add(reader("CategoryName").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Load inventory into DataGridView
    Public Sub LoadInventory()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ProductID, ProductName, Price, StockQuantity, CategoryName FROM products"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                Guna2DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' Form Load
    Private Sub ProductContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadInventory()
        cb_cate.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    ' When a row is clicked in the DataGridView
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            selectedProductID = Convert.ToInt32(row.Cells("ProductID").Value)
            SiticoneTextBox1.Text = row.Cells("ProductName").Value.ToString()
            SiticoneTextBox2.Text = row.Cells("StockQuantity").Value.ToString()
            SiticoneTextBox3.Text = row.Cells("Price").Value.ToString()
            cb_cate.SelectedItem = row.Cells("CategoryName").Value.ToString()

            ' Load image from DB
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT ProductImage FROM products WHERE ProductID=@id", conn)
                cmd.Parameters.AddWithValue("@id", selectedProductID)
                Dim imgData As Byte() = CType(cmd.ExecuteScalar(), Byte())
                If imgData IsNot Nothing AndAlso imgData.Length > 0 Then
                    Using ms As New MemoryStream(imgData)
                        pb_ci.Image = Image.FromStream(ms)
                    End Using
                Else
                    pb_ci.Image = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub


    ' Choose Image button
    Private Sub siticonebutton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        If selectedProductID <> -1 Then
            MessageBox.Show("Cannot change image while editing. Select a new product to add image.")
            Exit Sub
        End If
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            selectedImagePath = ofd.FileName
            pb_ci.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub

    ' Save button (add new product)
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If SiticoneTextBox1.Text = "" Or SiticoneTextBox2.Text = "" Or SiticoneTextBox3.Text = "" Or cb_cate.SelectedIndex = -1 Or selectedImagePath = "" Then
            MessageBox.Show("Please fill all fields and choose an image.")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO products (ProductName, StockQuantity, Price, CategoryName, ProductImage) VALUES (@name,@stock,@price,@category,@image)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", SiticoneTextBox1.Text)
            cmd.Parameters.AddWithValue("@stock", SiticoneTextBox2.Text)
            cmd.Parameters.AddWithValue("@price", SiticoneTextBox3.Text)
            cmd.Parameters.AddWithValue("@category", cb_cate.SelectedItem.ToString())

            Dim imgData() As Byte = File.ReadAllBytes(selectedImagePath)
            cmd.Parameters.AddWithValue("@image", imgData)

            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Product added successfully!")
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        Finally
            conn.Close()
            LoadInventory()
            SiticoneTextBox1.Text = ""
            SiticoneTextBox2.Text = ""
            SiticoneTextBox3.Text = ""
            cb_cate.SelectedIndex = -1
            pb_ci.Image = Nothing
            selectedImagePath = ""
            selectedProductID = -1
        End Try
    End Sub

    ' Update button 
    Private Sub SiticoneButton3_Click_1(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        If selectedProductID = -1 Then
            MessageBox.Show("Please select a product to update.")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE products SET ProductName=@name, StockQuantity=@stock, Price=@price, CategoryName=@category WHERE ProductID=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", SiticoneTextBox1.Text)
            cmd.Parameters.AddWithValue("@stock", SiticoneTextBox2.Text)
            cmd.Parameters.AddWithValue("@price", SiticoneTextBox3.Text)
            cmd.Parameters.AddWithValue("@category", cb_cate.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@id", selectedProductID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("✅ Product updated successfully!")
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
        Finally
            conn.Close()
            LoadInventory()
        End Try
    End Sub
End Class
