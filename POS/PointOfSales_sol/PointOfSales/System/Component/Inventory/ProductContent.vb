Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class ProductContent
    Public Shared Instance As ProductContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"

    ' Load users into DataGridView
    Private Sub LoadUsers()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                Dim cmd As New MySqlCommand("SELECT userid, username, role, Secret_Question, email FROM users", conn)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgv_inventory.DataSource = dt


                If dgv_inventory.Columns.Contains("userid") Then
                    dgv_inventory.Columns("userid").Width = 50
                End If
                If dgv_inventory.Columns.Contains("username") Then
                    dgv_inventory.Columns("username").Width = 100
                End If
                If dgv_inventory.Columns.Contains("role") Then
                    dgv_inventory.Columns("role").Width = 100
                End If
                If dgv_inventory.Columns.Contains("Secret_Question") Then
                    dgv_inventory.Columns("Secret_Question").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                If dgv_inventory.Columns.Contains("email") Then
                    dgv_inventory.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    ' 🔹 Function to hash a string with SHA256
    Private Function HashText(input As String) As String
        Using sha As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub ProductContent_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            ' ✅ Make sure controls are initialized before accessing them
            If SiticoneTextBox1 Is Nothing OrElse SiticoneTextBox2 Is Nothing OrElse SiticoneTextBox3 Is Nothing Then
                Exit Sub
            End If

            ' ✅ Safely check parent form state
            Dim parentForm As Form = Me.FindForm()
            If parentForm IsNot Nothing AndAlso parentForm.WindowState = FormWindowState.Maximized Then
                ' When maximized
                SiticoneTextBox1.Font = New Font(SiticoneTextBox1.Font.FontFamily, 16, SiticoneTextBox1.Font.Style)
                SiticoneTextBox3.Font = New Font(SiticoneTextBox3.Font.FontFamily, 16, SiticoneTextBox3.Font.Style)
                SiticoneTextBox2.Font = New Font(SiticoneTextBox2.Font.FontFamily, 16, SiticoneTextBox2.Font.Style)
            Else
                ' When restored or normal
                SiticoneTextBox1.Font = New Font(SiticoneTextBox1.Font.FontFamily, 12, SiticoneTextBox1.Font.Style)
                SiticoneTextBox3.Font = New Font(SiticoneTextBox3.Font.FontFamily, 12, SiticoneTextBox3.Font.Style)
                SiticoneTextBox2.Font = New Font(SiticoneTextBox2.Font.FontFamily, 12, SiticoneTextBox2.Font.Style)
            End If

        Catch ex As Exception
            Debug.WriteLine("Resize error in ProductContent: " & ex.Message)
        End Try
    End Sub


    Public Sub LoadCategories1()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT CategoryName FROM categories"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                cb_cate.Items.Clear() ' clear old items

                While reader.Read()
                    cb_cate.Items.Add(reader("CategoryName").ToString())
                End While

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub LoadInventory()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                ' ✅ Select ProductImage also, but we will hide it later
                Dim query As String = "SELECT ProductID, ProductName, Price, StockQuantity, CategoryName, Status, ProductImage FROM products"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgv_inventory.DataSource = dt
            End Using

            ' ✅ Apply column formatting after loading data
            If dgv_inventory.Columns.Count > 0 Then
                dgv_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                dgv_inventory.Columns("ProductID").Width = 80
                dgv_inventory.Columns("ProductName").Width = 200
                dgv_inventory.Columns("Price").Width = 100
                dgv_inventory.Columns("StockQuantity").Width = 120
                dgv_inventory.Columns("CategoryName").Width = 150
                dgv_inventory.Columns("Status").Width = 100

                ' ✅ Hide the ProductImage column (still usable in CellClick)
                dgv_inventory.Columns("ProductImage").Visible = False

                ' Optional: make ProductID read-only
                dgv_inventory.Columns("ProductID").ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show("❌ Error loading products: " & ex.Message,
                    "Load Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try
    End Sub


    ' ✅ CellClick event - loads selected row data into controls
    Private Sub dgv_inventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_inventory.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_inventory.Rows(e.RowIndex)

            ' Fill textboxes and comboboxes
            SiticoneTextBox1.Text = row.Cells("ProductName").Value.ToString()
            SiticoneTextBox3.Text = row.Cells("Price").Value.ToString()
            SiticoneTextBox2.Text = row.Cells("StockQuantity").Value.ToString()
            cb_cate.Text = row.Cells("CategoryName").Value.ToString()

            ' Save ProductID in Tag (for updating later)
            SiticoneButton3.Tag = row.Cells("ProductID").Value.ToString()

            ' Load product image (if exists)
            If Not IsDBNull(row.Cells("ProductImage").Value) Then
                Dim imgBytes As Byte() = DirectCast(row.Cells("ProductImage").Value, Byte())
                Using ms As New MemoryStream(imgBytes)
                    pb_ci.Image = Image.FromStream(ms)
                    pb_ci.SizeMode = PictureBoxSizeMode.StretchImage
                End Using
            Else
                pb_ci.Image = Nothing
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' ✅ Check image
        If pb_ci.Image Is Nothing Then
            MessageBox.Show("Please select a product image first.")
            Exit Sub
        End If

        ' ✅ Check product name
        If String.IsNullOrWhiteSpace(SiticoneTextBox1.Text) Then
            MessageBox.Show("Please enter a product name first.")
            Exit Sub
        End If

        ' ✅ Check price
        If String.IsNullOrWhiteSpace(SiticoneTextBox3.Text) OrElse Not IsNumeric(SiticoneTextBox3.Text) Then
            MessageBox.Show("Please enter a valid price.")
            Exit Sub
        End If

        ' ✅ Check stock
        If String.IsNullOrWhiteSpace(SiticoneTextBox2.Text) OrElse Not IsNumeric(SiticoneTextBox2.Text) Then
            MessageBox.Show("Please enter a valid stock quantity.")
            Exit Sub
        End If

        ' ✅ Check category
        If cb_cate.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a category.")
            Exit Sub
        End If

        Try
            ' Convert PictureBox image to byte array
            Dim ms As New MemoryStream
            pb_ci.Image.Save(ms, pb_ci.Image.RawFormat)
            Dim imgBytes = ms.ToArray

            ' Get values
            Dim pname As String = SiticoneTextBox1.Text.Trim()
            Dim price As Decimal = Convert.ToDecimal(SiticoneTextBox3.Text)
            Dim stock As Integer = Convert.ToInt32(SiticoneTextBox2.Text)
            Dim category As String = cb_cate.SelectedItem.ToString().Trim()

            ' Database connection
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                ' ✅ Insert query with all fields
                Dim query = "INSERT INTO products (ProductName, Price, StockQuantity, CategoryName, ProductImage) 
                         VALUES (@pname, @price, @stock, @category, @pimage)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pname", pname)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@stock", stock)
                    cmd.Parameters.AddWithValue("@category", category)
                    cmd.Parameters.Add("@pimage", MySqlDbType.Blob).Value = imgBytes

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("✅ Product added successfully!")

            ' Reset fields
            SiticoneTextBox1.Clear()
            SiticoneTextBox3.Clear()
            SiticoneTextBox2.Clear()
            cb_cate.SelectedIndex = -1
            pb_ci.Image = Nothing

            ' ✅ Refresh inventory
            LoadInventory()

            ' ✅ Refresh POS products (if PosControl is open)

            Dim posForm As PosControl = Application.OpenForms().OfType(Of PosControl)().FirstOrDefault()
            If posForm IsNot Nothing Then
                posForm.Invoke(Sub()
                                   posForm.LoadProducts()
                               End Sub)
            End If
        Catch ex As Exception
            MessageBox.Show("Error refreshing POS: " & ex.Message)
        End Try
    End Sub


    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        ' Set filters for the OpenFileDialog
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog1.Title = "Select an Image"

        ' Show dialog and check if user selected a file
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                ' Load the selected image into the PictureBox
                pb_ci.Image = Image.FromFile(OpenFileDialog1.FileName)
                pb_ci.SizeMode = PictureBoxSizeMode.StretchImage  ' Adjust image to fit PictureBox
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub


    ' Load categories into combo boxes
    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT CategoryName FROM categories"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cb_cate.Items.Clear()



            While reader.Read()
                Dim catName As String = reader("CategoryName").ToString()
                cb_cate.Items.Add(catName)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ProductContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 🔹 Load categories and products when the form/control opens
        LoadCategories()
        LoadInventory()
        cb_cate.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        ' Ensure a product is selected
        If SiticoneButton3.Tag Is Nothing Then
            MessageBox.Show("Please select a product to update from the inventory.")
            Exit Sub
        End If

        Try
            Dim productId As Integer = Convert.ToInt32(SiticoneButton3.Tag)

            ' Validate inputs
            Dim price As Decimal
            Dim stock As Integer
            If Not Decimal.TryParse(SiticoneTextBox3.Text, price) Then
                MessageBox.Show("Enter a valid price.")
                Exit Sub
            End If
            If Not Integer.TryParse(SiticoneTextBox2.Text, stock) Then
                MessageBox.Show("Enter a valid stock quantity.")
                Exit Sub
            End If

            ' Prepare image if set
            Dim imgBytes As Byte() = Nothing
            If pb_ci.Image IsNot Nothing Then
                Using bmp As New Bitmap(pb_ci.Image)
                    Using ms As New MemoryStream()
                        bmp.Save(ms, Imaging.ImageFormat.Png)
                        imgBytes = ms.ToArray()
                    End Using
                End Using
            End If

            ' Update database
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                Dim query As String
                If imgBytes IsNot Nothing Then
                    query = "UPDATE products 
                        SET ProductName=@pname, Price=@price, StockQuantity=@stock, 
                            CategoryName=@category, Status=@status, ProductImage=@pimage 
                        WHERE ProductID=@id"
                Else
                    query = "UPDATE products 
                        SET ProductName=@pname, Price=@price, StockQuantity=@stock, 
                            CategoryName=@category, Status=@status 
                        WHERE ProductID=@id"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pname", SiticoneTextBox1.Text.Trim())
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@stock", stock)
                    cmd.Parameters.AddWithValue("@category", cb_cate.Text.Trim())
                    cmd.Parameters.AddWithValue("@status", "Available") ' optional
                    cmd.Parameters.AddWithValue("@id", productId)
                    If imgBytes IsNot Nothing Then
                        cmd.Parameters.Add("@pimage", MySqlDbType.Blob).Value = imgBytes
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' --- Real-time update of FlowLayoutPanel1 cards ---
            Dim posControl As New PosControl()
            For Each ctrl As Control In posControl.FlowLayoutPanel1.Controls
                If TypeOf ctrl Is Panel AndAlso ctrl.Tag IsNot Nothing AndAlso ctrl.Tag = productId Then
                    For Each c As Control In ctrl.Controls
                        Select Case c.Tag
                            Case "name"
                                c.Text = SiticoneTextBox1.Text.Trim()
                            Case "price"
                                Dim newPrice As Decimal
                                If Decimal.TryParse(SiticoneTextBox3.Text, newPrice) Then
                                    c.Text = newPrice.ToString("C2")
                                End If
                            Case "img"
                                If pb_ci.Image IsNot Nothing Then
                                    CType(c, PictureBox).Image = pb_ci.Image
                                End If
                        End Select
                    Next
                    Exit For
                End If
            Next

            MessageBox.Show("✅ Product updated successfully!")

            ' Refresh DataGridView
            LoadInventory()
            LoadCategories()

            ' Clear fields
            SiticoneTextBox1.Clear()
            SiticoneTextBox3.Clear()
            SiticoneTextBox2.Clear()
            cb_cate.SelectedIndex = -1
            pb_ci.Image = Nothing
            SiticoneButton3.Tag = Nothing

        Catch ex As Exception
            MessageBox.Show("❌ Error updating product: " & ex.Message,
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try
    End Sub

End Class
