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
            Dim itemText = ListBox1.Items(index).ToString()
            ' parse qty and productName
            Dim regex As New System.Text.RegularExpressions.Regex("^(\d+)x\s+(.+)$")
            Dim m = regex.Match(itemText)
            If m.Success Then
                Dim qty As Integer = Convert.ToInt32(m.Groups(1).Value)
                Dim pname As String = m.Groups(2).Value.Trim()
                ' restore stock
                ChangeStock(pname, qty)
            End If

            ListBox1.Items.RemoveAt(index)
            ListBox2.Items.RemoveAt(index)
            CalculateTotals()
        Else
            MessageBox.Show("Please select a product to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    ' ✅ This existing method clears the items and totals.
    Public Sub ResetOrder()
        ' Restore stock back for current cart
        RestoreStockFromCart()

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
        Try
            ' Check stock first
            Dim stockNow As Integer = GetStockQuantity(productName)
            If stockNow <= 0 Then
                MessageBox.Show("No stock available for this product.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim found As Boolean = False

            For i As Integer = 0 To ListBox1.Items.Count - 1
                Dim item As String = ListBox1.Items(i).ToString()
                If item.Contains(productName) Then
                    ' parse existing quantity
                    Dim qty As Integer = 1
                    Dim regex As New System.Text.RegularExpressions.Regex("(\d+)x")
                    Dim match = regex.Match(item)
                    If match.Success Then
                        qty = Convert.ToInt32(match.Groups(1).Value)
                    End If

                    ' Before incrementing ensure stock still available for +1
                    If GetStockQuantity(productName) <= 0 Then
                        MessageBox.Show("No stock available to increase quantity for this product.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    ' Update listboxes
                    qty += 1
                    ListBox1.Items(i) = $"{qty}x {productName}"
                    ListBox2.Items(i) = "₱" & (productPrice * qty).ToString("N2")

                    ' Decrease stock by 1 in products
                    ChangeStock(productName, -1)

                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                ' Add new item and decrease stock by 1
                ListBox1.Items.Add($"1x {productName}")
                ListBox2.Items.Add("₱" & productPrice.ToString("N2"))
                ChangeStock(productName, -1)
            End If

            CalculateTotals()

        Catch ex As Exception
            MessageBox.Show("Error adding product to ticket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            Dim selectedItem As String = ListBox1.SelectedItem.ToString()
            ' Example: "2x Coke" → extract quantity and name
            Dim regex As New System.Text.RegularExpressions.Regex("^(\d+)x\s+(.+)$")
            Dim match = regex.Match(selectedItem)

            If match.Success Then
                Dim qty As Integer = Convert.ToInt32(match.Groups(1).Value)
                Dim pname As String = match.Groups(2).Value.Trim()

                ' ✅ Create and configure the Edit form
                Dim editForm As New Edit()
                editForm.SelectedProductName = pname
                editForm.lbl_quantity.Text = qty.ToString()
                editForm.SelectedIndex = ListBox1.SelectedIndex

                ' ✅ Show edit form
                editForm.ShowDialog()
            Else
                MessageBox.Show("Could not parse product information. Please select a valid item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
    ' ------------------------
    ' Stock helper functions
    ' ------------------------
    Public Function GetStockQuantity(productName As String) As Integer
        Dim stock As Integer = 0
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                Dim q As String = "SELECT StockQuantity FROM products WHERE ProductName = @ProductName LIMIT 1"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    Dim res = cmd.ExecuteScalar()
                    If res IsNot Nothing AndAlso Not IsDBNull(res) Then
                        stock = Convert.ToInt32(res)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking stock: " & ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return stock
    End Function

    Public Function ChangeStock(productName As String, delta As Integer) As Boolean
        ' delta can be negative (decrease) or positive (increase)
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                Dim q As String = "UPDATE products SET StockQuantity = StockQuantity + @Delta WHERE ProductName = @ProductName"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@Delta", delta)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    Return affected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Restore stock for everything currently in the listboxes (used on Reset/Clear)
    Public Sub RestoreStockFromCart()
        Try
            For i As Integer = 0 To ListBox1.Items.Count - 1
                Dim itemText = ListBox1.Items(i).ToString()
                ' Expect format "Nx ProductName"
                Dim regex As New System.Text.RegularExpressions.Regex("^(\d+)x\s+(.+)$")
                Dim m = regex.Match(itemText)
                If m.Success Then
                    Dim qty As Integer = Convert.ToInt32(m.Groups(1).Value)
                    Dim pname As String = m.Groups(2).Value.Trim()
                    ChangeStock(pname, qty) ' increase stock by qty
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("RestoreStockFromCart error: " & ex.Message)
        End Try
    End Sub
    Private Sub InsertSales(productName As String, quantity As Integer, unitPrice As Decimal)
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                Dim q As String = "
                INSERT INTO sales (TicketNumber, ProductName, Quantity, UnitPrice, SubTotal)
                VALUES (@TicketNumber, @ProductName, @Quantity, @UnitPrice, @SubTotal)"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@TicketNumber", PosControl.CurrentTicket)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice)
                    cmd.Parameters.AddWithValue("@SubTotal", quantity * unitPrice)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting sales record: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateSales(productName As String, quantity As Integer, unitPrice As Decimal)
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                Dim q As String = "
                UPDATE sales 
                SET Quantity = @Quantity, SubTotal = @SubTotal
                WHERE TicketNumber = @TicketNumber AND ProductName = @ProductName"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@TicketNumber", PosControl.CurrentTicket)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@SubTotal", quantity * unitPrice)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating sales record: " & ex.Message)
        End Try
    End Sub

End Class
