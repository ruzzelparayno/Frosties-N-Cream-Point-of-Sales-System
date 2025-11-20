Imports MySql.Data.MySqlClient

Public Class TransactionContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"
    Private dt As DataTable

    Private Sub TransactionContent_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
        Guna2DataGridView1.ScrollBars = ScrollBars.Vertical
        Guna2DataGridView1.Dock = DockStyle.Fill
    End Sub
    ' Add this inside your TransactionContent class

    ' Update LoadTransactions to accept an optional filter parameter
    Public Sub LoadTransactions(Optional ByVal filter As String = "")
        Try
            conn.Open()

            ' Base query
            Dim query As String = "
            SELECT 
                TicketNumber, 
                ProductName, 
                SaleDate, 
                Subtotal, 
                DiscountType, 
                Vat, 
                TotalAmount, 
                Status 
            FROM sales 
            WHERE 1=1
        "

            ' Add filtering if search text is provided
            If filter <> "" Then
                query &= " AND (ProductName LIKE @filter OR TicketNumber LIKE @filter OR SaleDate LIKE @filter)"
            End If

            query &= " ORDER BY SaleDate DESC"

            Dim cmd As New MySqlCommand(query, conn)
            If filter <> "" Then
                cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            dt = New DataTable()
            adapter.Fill(dt)

            Guna2DataGridView1.DataSource = dt
            Guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Guna2DataGridView1.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Add this event handler for SiticoneButtonTextbox1 text change
    Private Sub SiticoneButtonTextbox1_TextChanged(sender As Object, e As EventArgs) Handles SiticoneButtonTextbox1.TextChanged
        ' Pass the search text to LoadTransactions
        LoadTransactions(SiticoneButtonTextbox1.Text.Trim())
    End Sub


    'Show ProductName in tooltip when hovering
    Private Sub Guna2DataGridView1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "ProductName" Then
                Dim cellValue = Guna2DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If cellValue IsNot Nothing Then
                    Guna2DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = cellValue.ToString
                End If
            End If
        End If
    End Sub

    'Function to get product price by name
    Private Function GetProductPrice(productName As String) As String
        Dim price As String = "₱0.00"

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()

                Dim query As String = "SELECT Price FROM products WHERE ProductName = @ProductName LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", productName.Trim())
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then

                        price = Convert.ToDecimal(result).ToString("₱0.00")
                    Else
                        Debug.WriteLine("Product not found in products table: " & productName)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting product price: " & ex.Message)
        End Try

        Return price
    End Function


    Private Sub dgv_transactions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    ' NEW FUNCTION: Get total refunded amount
    Private Function GetTotalRefunded() As Decimal
        Dim totalRefund As Decimal = 0D
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT IFNULL(SUM(TotalAmount),0) FROM sales WHERE Status='Refunded'"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        totalRefund = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error calculating total refunded amount: " & ex.Message)
        End Try
        Return totalRefund
    End Function
    Private Sub RestoreStockForTicket(ticketNumber As String)
        Try
            Using c As New MySqlConnection(connectionString)
                c.Open()
                ' Find all items for that ticket (only those that were completed)
                Dim q As String = "SELECT ProductName, Quantity FROM sales WHERE TicketNumber = @TicketNumber AND Status = 'Completed'"
                Using cmd As New MySqlCommand(q, c)
                    cmd.Parameters.AddWithValue("@TicketNumber", ticketNumber)
                    Using reader = cmd.ExecuteReader()
                        Dim toRestore As New List(Of (String, Integer))
                        While reader.Read()
                            Dim pname = reader("ProductName").ToString()
                            Dim qty = If(IsDBNull(reader("Quantity")), 0, Convert.ToInt32(reader("Quantity")))
                            If qty > 0 Then toRestore.Add((pname, qty))
                        End While
                        reader.Close()

                        ' Update product stock for each item
                        For Each pair In toRestore
                            Using upd As New MySqlCommand("UPDATE products SET StockQuantity = StockQuantity + @qty WHERE ProductName = @pname", c)
                                upd.Parameters.AddWithValue("@qty", pair.Item2)
                                upd.Parameters.AddWithValue("@pname", pair.Item1)
                                upd.ExecuteNonQuery()
                            End Using
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error restoring stock for ticket: " & ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        ' Get selected row
        Dim selectedRow = Guna2DataGridView1.Rows(e.RowIndex)
        Dim ticketNum = selectedRow.Cells("TicketNumber").Value.ToString()
        Dim productName = selectedRow.Cells("ProductName").Value.ToString().Trim()
        Dim priceText = selectedRow.Cells("TotalAmount").Value.ToString()
        Dim totalPrice As Decimal = 0D
        Decimal.TryParse(priceText.Replace("₱", "").Replace(",", "").Trim(), totalPrice)

        Dim mop As String = ""

        Dim connStr = "server=localhost;userid=root;password=;database=pos"

        ' Optional: get Mode of Payment from database
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query = "SELECT ModeOfPayment FROM sales WHERE TRIM(ProductName) = @ProductName AND TicketNumber = @TicketNumber LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@TicketNumber", ticketNum)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not IsDBNull(reader("ModeOfPayment")) Then
                                mop = reader("ModeOfPayment").ToString().Trim()
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting mode of payment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' ✅ VAT calculation: 12% of total price
        Dim vatRate As Decimal = 0.12D
        Dim vatAmount As Decimal = Math.Round(totalPrice * vatRate, 2)
        Dim subtotalAmount As Decimal = Math.Round(totalPrice - vatAmount, 2)

        ' Send data to refund form
        Dim refundForm As New RefundForm
        refundForm.lbl_getticket.Text = ticketNum
        refundForm.lbl_getproducts.Text = productName
        refundForm.lbl_getprice.Text = "₱" & totalPrice.ToString("N2") ' Total price
        refundForm.lbl_getsubtotal.Text = "₱" & subtotalAmount.ToString("N2") ' Price without VAT
        refundForm.lbl_getvat.Text = "₱" & vatAmount.ToString("N2")
        refundForm.lbl_gettotal.Text = "₱" & totalPrice.ToString("N2") ' Total including VAT
        refundForm.lbl_MOP.Text = If(mop <> "", mop, "")

        refundForm.ShowDialog()

        ' Refund confirmed
        If refundForm.DialogResult = DialogResult.OK Then
            RestoreStockForTicket(ticketNum)
            LoadTransactions()

            Dim shiftForm As ShiftContent = Dashboard.shiftInstance
            If shiftForm IsNot Nothing AndAlso shiftForm.Panel2.Controls.Count > 0 Then
                Dim cashCtrl As CashManagementControll = TryCast(shiftForm.Panel2.Controls(0), CashManagementControll)
                If cashCtrl IsNot Nothing Then
                    Dim totalRefunds As Decimal = GetTotalRefunded()
                    cashCtrl.lbl_srefunds.Text = "₱" & totalRefunds.ToString("N2")
                    cashCtrl.ComputeTotal()
                End If
            End If

            MessageBox.Show("Refund applied and stock restored successfully.", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
