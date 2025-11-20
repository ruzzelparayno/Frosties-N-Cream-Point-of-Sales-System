Imports System.IO
Imports MySql.Data.MySqlClient

Public Class PosControl
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"

    Private Sub PosControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_vat.Text = "₱0.00"
        lbl_subtotal.Text = "₱0.00"
        lbl_total.Text = "₱0.00"
        LoadProducts()
        cb_cate1.DropDownStyle = ComboBoxStyle.DropDownList
        LoadCategories()
        UpdateTicket() ' Ensure the initial ticket number is shown on load
    End Sub

    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim query As String = "SELECT CategoryName FROM categories"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cb_cate1.Items.Clear()

            While reader.Read()
                Dim catName As String = reader("CategoryName").ToString()
                cb_cate1.Items.Add(catName)
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

    Public Sub LoadProducts()
        Try
            FlowLayoutPanel1.Controls.Clear()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ProductID, ProductName, ProductImage, Price FROM products"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim productCount As Integer = 0

                        While reader.Read()
                            productCount += 1
                            Dim productId As Integer = Convert.ToInt32(reader("ProductID"))
                            Dim pname As String = reader("ProductName").ToString()

                            ' Read image safely
                            Dim productImage As Image = Nothing
                            If Not IsDBNull(reader("ProductImage")) Then
                                Dim imgBytes() As Byte = DirectCast(reader("ProductImage"), Byte())
                                If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                                    Using ms As New MemoryStream(imgBytes)
                                        productImage = Image.FromStream(ms)
                                    End Using
                                End If
                            End If

                            ' Read price
                            Dim price As Decimal = 0D
                            If Not IsDBNull(reader("Price")) Then
                                price = Convert.ToDecimal(reader("Price"))
                            End If

                            AddProductCard(productId, pname, productImage, price)
                        End While

                        If productCount = 0 Then
                            MessageBox.Show("No products found in database.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    Private Sub SiticoneActivityButton1_Click(sender As Object, e As EventArgs) Handles SiticoneActivityButton1.Click
        Dim chargeForm As New Charge()
        ' Use ShowDialog() to pause execution until the charge form closes
        chargeForm.ShowDialog()
    End Sub

    Private Sub SiticoneActivityButton2_Click(sender As Object, e As EventArgs) Handles SiticoneActivityButton2.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim index = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(index)
            ListBox2.Items.RemoveAt(index)
            CalculateTotals()
        Else
            MessageBox.Show("Please select a product to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ✅ This existing method clears the items and totals.
    Public Sub ResetOrder()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        lbl_vat.Text = "₱0.00"
        lbl_subtotal.Text = "₱0.00"
        lbl_total.Text = "₱0.00"
    End Sub

    Private Sub AddProductCard(productId As Integer, productName As String, productImage As Image, Optional productPrice As Decimal = 0D)
        Dim card As New Panel()
        card.Size = New Size(160, 80)
        card.BackColor = Color.MediumPurple
        card.BorderStyle = BorderStyle.FixedSingle
        card.Margin = New Padding(10)
        card.Tag = productId

        Dim pb As New PictureBox()
        pb.Size = New Size(60, 55)
        pb.Location = New Point(10, 15)
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = If(productImage, SystemIcons.Question.ToBitmap())
        pb.Tag = "img"

        Dim lbl As New Label()
        lbl.Text = productName
        lbl.ForeColor = Color.White
        lbl.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Location = New Point(70, 15)
        lbl.Tag = "name"

        Dim lblPrice As New Label()
        lblPrice.Text = "₱" & productPrice.ToString("N2")
        lblPrice.ForeColor = Color.White
        lblPrice.Font = New Font("Segoe UI", 8, FontStyle.Regular)
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(70, 40)
        lblPrice.Tag = "price"

        card.Controls.Add(pb)
        card.Controls.Add(lbl)
        card.Controls.Add(lblPrice)

        Dim clickHandler = Sub(sender As Object, e As EventArgs)
                               AddOrUpdateTicket(productName, productPrice)
                           End Sub

        AddHandler card.Click, clickHandler
        AddHandler pb.Click, clickHandler
        AddHandler lbl.Click, clickHandler
        AddHandler lblPrice.Click, clickHandler

        FlowLayoutPanel1.Controls.Add(card)
    End Sub

    Private Sub AddOrUpdateTicket(productName As String, productPrice As Decimal)
        Dim found As Boolean = False

        For i As Integer = 0 To ListBox1.Items.Count - 1
            Dim item As String = ListBox1.Items(i).ToString()
            If item.Contains(productName) Then
                Dim qty As Integer = 1
                Dim regex As New System.Text.RegularExpressions.Regex("(\d+)x")
                Dim match = regex.Match(item)
                If match.Success Then
                    qty = Convert.ToInt32(match.Groups(1).Value)
                End If
                qty += 1

                ListBox1.Items(i) = $"{qty}x {productName}"
                ListBox2.Items(i) = "₱" & (productPrice * qty).ToString("N2")

                found = True
                Exit For
            End If
        Next

        If Not found Then
            ListBox1.Items.Add($"1x {productName}")
            ListBox2.Items.Add("₱" & productPrice.ToString("N2"))
        End If

        CalculateTotals()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ListBox1.SelectedIndex <> -1 AndAlso ListBox1.SelectedIndex < ListBox2.Items.Count Then
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ListBox2.SelectedIndex <> -1 AndAlso ListBox2.SelectedIndex < ListBox1.Items.Count Then
            ListBox1.SelectedIndex = ListBox2.SelectedIndex
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedIndex >= 0 Then
            Dim editForm As New edit
            Dim selectedItem As String = ListBox1.SelectedItem.ToString()
            Dim parts As String() = selectedItem.Split(New Char() {" "c}, 2, StringSplitOptions.None)

            If parts.Length > 1 Then
                editForm.lbl_quantity.Text = parts(0).Replace("x", "").Trim()
                editForm.lbl_getproductname.Text = parts(1)
            End If

            editForm.SelectedIndex = ListBox1.SelectedIndex
            editForm.ShowDialog()
        End If
    End Sub

    Private Sub SearchProducts(keyword As String)
        FlowLayoutPanel1.Controls.Clear()

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ProductID, ProductName, Price, ProductImage FROM products WHERE ProductName LIKE @keyword"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim productId As Integer = Convert.ToInt32(reader("ProductID"))
                        Dim productName As String = reader("ProductName").ToString()
                        Dim productPrice As Decimal = Convert.ToDecimal(reader("Price"))

                        Dim productImage As Image = Nothing
                        If Not IsDBNull(reader("ProductImage")) Then
                            Try
                                Dim imgBytes As Byte() = DirectCast(reader("ProductImage"), Byte())
                                Using ms As New MemoryStream(imgBytes)
                                    productImage = Image.FromStream(ms)
                                End Using
                            Catch ex As Exception
                                productImage = SystemIcons.Question.ToBitmap()
                            End Try
                        End If

                        AddProductCard(productId, productName, productImage, productPrice)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub CalculateTotals()
        Dim total As Decimal = 0D

        For Each item As String In ListBox2.Items
            Dim cleanText As String = item.Replace("₱", "").Replace(",", "").Trim()
            Dim price As Decimal
            If Decimal.TryParse(cleanText, price) Then
                total += price
            End If
        Next

        ' Assuming 12% VAT
        Dim vatRate As Decimal = 0.12D
        Dim vat As Decimal = Math.Round(total * vatRate, 2)
        Dim subtotal As Decimal = Math.Round(total - vat, 2)

        lbl_subtotal.Text = "₱" & subtotal.ToString("N2")
        lbl_vat.Text = "₱" & vat.ToString("N2")
        lbl_total.Text = "₱" & total.ToString("N2")
    End Sub

    Private Sub SiticoneActivityButton3_Click(sender As Object, e As EventArgs) Handles SiticoneActivityButton3.Click
        ResetOrder()
    End Sub

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

    Private Sub SiticoneDropdown1_selectedindexchange(sender As Object, e As EventArgs)
        ' This method seems unused, leaving it as is.
    End Sub

    Private Sub cb_cate1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cate1.SelectedIndexChanged
        If cb_cate1.SelectedItem Is Nothing Then Exit Sub

        Dim selectedCategory = cb_cate1.SelectedItem.ToString.Trim
        FlowLayoutPanel1.Controls.Clear() ' Clear previous products

        Try
            Dim query = "
            SELECT p.ProductID, p.ProductName, p.ProductImage, p.Price
            FROM products p
            INNER JOIN categories c ON p.CategoryName = c.CategoryName
            WHERE c.CategoryName = @CategoryName
        "

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CategoryName", selectedCategory)

                If conn.State <> ConnectionState.Open Then conn.Open()

                Using reader = cmd.ExecuteReader
                    Dim hasProducts = False

                    While reader.Read
                        hasProducts = True

                        Dim productId = Convert.ToInt32(reader("ProductID"))
                        Dim productName = reader("ProductName").ToString

                        Dim productPrice = 0D
                        If Not IsDBNull(reader("Price")) Then
                            productPrice = Convert.ToDecimal(reader("Price"))
                        End If

                        Dim productImage As Image = Nothing
                        If Not IsDBNull(reader("ProductImage")) Then
                            Dim imgBytes = CType(reader("ProductImage"), Byte())
                            Using ms As New MemoryStream(imgBytes)
                                productImage = Image.FromStream(ms)
                            End Using
                        End If

                        AddProductCard(productId, productName, productImage, productPrice)
                    End While

                    If Not hasProducts Then
                        MessageBox.Show("No products found for this category.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' 🌟 NEW: Public method called by the Charge form to clear the transaction 🌟
    Public Sub ClearTransaction()
        ' 1. Clear ListBoxes and reset Total/VAT/Subtotal labels
        ResetOrder()

        ' 2. Advance the ticket number for the next transaction
        NextTicket()
        UpdateTicket()
    End Sub

End Class
