Imports System.IO
Imports MySql.Data.MySqlClient

Public Class PosControl
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"

    Private Sub PosControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_vat.Text = "₱0.00"
        lbl_subtotal.Text = "₱0.00"
        lbl_total.Text = "₱0.00"

        ' ✅ Setup DataGridView Columns
        SetupDataGrid()

        LoadProducts()
        cb_cate1.DropDownStyle = ComboBoxStyle.DropDownList
        LoadCategories()
        UpdateTicket()
    End Sub

    Private Sub SetupDataGrid()
        Guna2DataGridView1.Rows.Clear()
        Guna2DataGridView1.Columns.Clear()

        With Guna2DataGridView1
            .Columns.Add("Quantity", "Qty")
            .Columns.Add("ProductName", "Product Name")
            .Columns.Add("Price", "Price (₱)")
        End With
        If Guna2DataGridView1.Columns.Contains("ProductName") Then
            Guna2DataGridView1.Columns("ProductName").Width = 80
        End If
        If Guna2DataGridView1.Columns.Contains("Quantity") Then
            Guna2DataGridView1.Columns("Quantity").Width = 10
        End If
        If Guna2DataGridView1.Columns.Contains("Price") Then
            Guna2DataGridView1.Columns("Price").Width = 10
        End If
    End Sub

    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT CategoryName FROM categories"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cb_cate1.Items.Clear()
            While reader.Read()
                cb_cate1.Items.Add(reader("CategoryName").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub LoadProducts()
        Try
            FlowLayoutPanel1.Controls.Clear()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ProductID, ProductName, ProductImage, Price FROM products"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim productId As Integer = Convert.ToInt32(reader("ProductID"))
                            Dim pname As String = reader("ProductName").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                            Dim productImage As Image = Nothing

                            If Not IsDBNull(reader("ProductImage")) Then
                                Dim imgBytes As Byte() = DirectCast(reader("ProductImage"), Byte())
                                Using ms As New MemoryStream(imgBytes)
                                    productImage = Image.FromStream(ms)
                                End Using
                            End If

                            AddProductCard(productId, pname, productImage, price)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    Private Sub AddProductCard(productId As Integer, productName As String, productImage As Image, Optional productPrice As Decimal = 0D)
        Dim card As New Panel()
        card.Size = New Size(235, 80)
        card.BackColor = Color.FromArgb(89, 70, 141)
        card.BorderStyle = BorderStyle.FixedSingle
        card.Margin = New Padding(10)
        card.Tag = productId
        card.Cursor = Cursors.Hand

        Dim pb As New PictureBox()
        pb.Size = New Size(60, 55)
        pb.Location = New Point(10, 15)
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = If(productImage, SystemIcons.Question.ToBitmap())
        pb.Cursor = Cursors.Hand

        Dim lbl As New Label()
        lbl.Text = productName
        lbl.ForeColor = Color.White
        lbl.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Location = New Point(90, 15)
        lbl.Cursor = Cursors.Hand

        Dim lblPrice As New Label()
        lblPrice.Text = "₱" & productPrice.ToString("N2")
        lblPrice.ForeColor = Color.White
        lblPrice.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(90, 45)
        lblPrice.Cursor = Cursors.Hand

        card.Controls.Add(pb)
        card.Controls.Add(lbl)
        card.Controls.Add(lblPrice)

        Dim clickHandler = Sub(sender As Object, e As EventArgs)
                               ' Determine which PictureBox was clicked
                               Dim pic As PictureBox = Nothing

                               If TypeOf sender Is PictureBox Then
                                   pic = CType(sender, PictureBox)
                               ElseIf TypeOf sender Is Panel Then
                                   ' get PictureBox inside panel
                                   pic = CType(CType(sender, Panel).Controls(0), PictureBox)
                               ElseIf TypeOf sender Is Label Then
                                   ' get PictureBox from parent panel
                                   pic = CType(CType(sender, Label).Parent.Controls(0), PictureBox)
                               End If

                               Dim img As Image = Nothing
                               If pic IsNot Nothing Then img = pic.Image

                               ' Pass image to AddOrUpdateTicket
                               AddOrUpdateTicket(productName, productPrice, img)
                           End Sub


        AddHandler card.Click, clickHandler
        AddHandler pb.Click, clickHandler
        AddHandler lbl.Click, clickHandler
        AddHandler lblPrice.Click, clickHandler

        FlowLayoutPanel1.Controls.Add(card)
    End Sub

    ' ✅ ADD OR UPDATE PRODUCT TO DATAGRIDVIEW
    ' Add or update ticket with Edit form
    Private Sub AddOrUpdateTicket(productName As String, productPrice As Decimal, Optional productImage As Image = Nothing)
        Try
            Dim stockNow As Integer = GetStockQuantity(productName)
            If stockNow <= 0 Then
                MessageBox.Show("No stock available for this product.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            ' Determine current quantity if product already in cart
            Dim currentQty As Integer = 1
            Dim foundRow As DataGridViewRow = Nothing
            For Each row As DataGridViewRow In Guna2DataGridView1.Rows
                If row.Cells("ProductName").Value IsNot Nothing AndAlso
               String.Equals(row.Cells("ProductName").Value.ToString(), productName, StringComparison.OrdinalIgnoreCase) Then
                    foundRow = row
                    currentQty = Convert.ToInt32(row.Cells("Quantity").Value)
                    Exit For
                End If
            Next

            Dim editForm As New Edit()
            editForm.SelectedProductName = productName
            editForm.SelectedProductPrice = productPrice
            editForm.SelectedProductImage = productImage

            SiticoneOverlay1.Show = True
            editForm.ParentPOS = Me
            editForm.ShowDialog()
            CalculateTotals()
            If editForm.AllowCloseOverlay Then
                SiticoneOverlay1.Show = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub







    ' ✅ RESET ORDER
    Public Sub ResetOrder()
        RestoreStockFromCart()
        Guna2DataGridView1.Rows.Clear()
        lbl_vat.Text = "₱0.00"
        lbl_subtotal.Text = "₱0.00"
        lbl_total.Text = "₱0.00"
    End Sub

    ' ✅ CALCULATE TOTALS
    Public Sub CalculateTotals()
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In Guna2DataGridView1.Rows
            If row.Cells("Price").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("Price").Value)
            End If
        Next

        Dim vatRate As Decimal = 0.12D
        Dim vat As Decimal = Math.Round(total * vatRate, 2)
        Dim subtotal As Decimal = Math.Round(total - vat, 2)

        lbl_subtotal.Text = "₱" & subtotal.ToString("N2")
        lbl_vat.Text = "₱" & vat.ToString("N2")
        lbl_total.Text = "₱" & total.ToString("N2")
    End Sub

    ' ✅ RESTORE STOCK WHEN CLEARING
    Public Sub RestoreStockFromCart()
        Try
            For Each row As DataGridViewRow In Guna2DataGridView1.Rows
                If row.Cells("ProductName").Value IsNot Nothing Then
                    Dim pname As String = row.Cells("ProductName").Value.ToString()
                    Dim qty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                    ChangeStock(pname, qty)
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("RestoreStockFromCart error: " & ex.Message)
        End Try
    End Sub

    ' ✅ STOCK FUNCTIONS
    Public Function GetStockQuantity(productName As String) As Integer
        Dim stock As Integer = 0
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                Dim q As String = "SELECT StockQuantity FROM products WHERE ProductName = @ProductName LIMIT 1"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    Dim res = cmd.ExecuteScalar()
                    If res IsNot Nothing Then stock = Convert.ToInt32(res)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking stock: " & ex.Message)
        End Try
        Return stock
    End Function

    Public Function ChangeStock(productName As String, delta As Integer) As Boolean
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                Dim q As String = "UPDATE products SET StockQuantity = StockQuantity + @Delta WHERE ProductName = @ProductName"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@Delta", delta)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message)
            Return False
        End Try
    End Function

    ' ✅ CLEAR TRANSACTION WHEN PAID
    Public Sub ClearTransaction()
        ResetOrder()
        NextTicket()
        UpdateTicket()
    End Sub

    ' ✅ TICKET NUMBER FUNCTIONS
    Public Shared CurrentTicket As Integer = 1
    Public Shared Function GetFormattedTicket() As String
        Return "#" & CurrentTicket.ToString("D3")
    End Function
    Public Shared Sub NextTicket()
        CurrentTicket += 1
    End Sub
    Public Sub UpdateTicket()
        lbl_tickets.Text = GetFormattedTicket()
    End Sub




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim chargeForm As New Charge()
        ' Use ShowDialog() to pause execution until the charge form closes
        chargeForm.ShowDialog()

        Dim searchText As String = SiticoneButtonTextbox1.Text.Trim().ToLower()

        ' Loop through all product cards in FlowLayoutPanel
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Panel Then
                Dim card As Panel = CType(ctrl, Panel)
                ' The product name label is the second control in the panel (index 1)
                Dim lblName As Label = CType(card.Controls(1), Label)

                If lblName.Text.ToLower().StartsWith(searchText) Then
                    card.Visible = True
                Else
                    card.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Guna2DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
            Dim pname As String = row.Cells("ProductName").Value.ToString()
            Dim qty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

            ChangeStock(pname, qty)
            Guna2DataGridView1.Rows.Remove(row)
            CalculateTotals()
        Else
            MessageBox.Show("Please select a product to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all items?", "Clear All", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' ✅ Restore all stock before clearing
            RestoreStockFromCart()

            ' ✅ Clear the DataGridView
            Guna2DataGridView1.Rows.Clear()

            ' ✅ Reset totals
            lbl_subtotal.Text = "₱0.00"
            lbl_vat.Text = "₱0.00"
            lbl_total.Text = "₱0.00"

            MessageBox.Show("All items have been cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cb_cate1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cate1.SelectedIndexChanged
        FilterProductsByCategory()
    End Sub
    Private Sub FilterProductsByCategory()
        If cb_cate1.SelectedIndex = -1 Then Exit Sub

        Dim selectedCategory As String = cb_cate1.SelectedItem.ToString()

        Try
            FlowLayoutPanel1.Controls.Clear()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                SELECT ProductID, ProductName, ProductImage, Price 
                FROM products 
                WHERE CategoryName = @cat
            "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cat", selectedCategory)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim productId As Integer = reader("ProductID")
                            Dim pname As String = reader("ProductName").ToString()
                            Dim price As Decimal = reader("Price")

                            Dim productImage As Image = Nothing
                            If Not IsDBNull(reader("ProductImage")) Then
                                Dim imgBytes As Byte() = DirectCast(reader("ProductImage"), Byte())
                                Using ms As New MemoryStream(imgBytes)
                                    productImage = Image.FromStream(ms)
                                End Using
                            End If

                            AddProductCard(productId, pname, productImage, price)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering products: " & ex.Message)
        End Try
    End Sub

End Class
