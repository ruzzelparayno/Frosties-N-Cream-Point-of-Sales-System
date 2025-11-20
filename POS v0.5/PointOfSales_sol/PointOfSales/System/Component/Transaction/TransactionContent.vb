Imports MySql.Data.MySqlClient

Public Class TransactionContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos"
    Private dt As DataTable

    Private Sub TransactionContent_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
    End Sub
    Public Sub LoadTransactions()
        Try
            ' Open the database connection
            conn.Open()

            ' Query to fetch transaction details including Status, ordered by most recent SaleDate
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
        ORDER BY SaleDate DESC;
    "

            ' Execute the query and fill the DataTable
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            dt = New DataTable()
            adapter.Fill(dt)

            ' Bind the data to the DataGridView
            dgv_transactions.DataSource = dt
            dgv_transactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_transactions.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)

        Finally
            ' Ensure the connection is closed even if an error occurs
            conn.Close()
        End Try

    End Sub

    'Show ProductName in tooltip when hovering
    Private Sub dgv_transactions_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_transactions.CellMouseEnter
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgv_transactions.Columns(e.ColumnIndex).Name = "ProductName" Then
                Dim cellValue = dgv_transactions.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If cellValue IsNot Nothing Then
                    dgv_transactions.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = cellValue.ToString
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


    Private Sub dgv_transactions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_transactions.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        ' ✅ Get selected row data
        Dim selectedRow = dgv_transactions.Rows(e.RowIndex)
        Dim ticketNum = selectedRow.Cells("TicketNumber").Value.ToString()
        Dim productName = selectedRow.Cells("ProductName").Value.ToString().Trim()
        Dim subtotal = selectedRow.Cells("Subtotal").Value.ToString()
        Dim vat = selectedRow.Cells("Vat").Value.ToString()
        Dim totalAmount = selectedRow.Cells("TotalAmount").Value.ToString()

        Dim allPrices As New List(Of String)
        Dim mop = ""

        Dim connStr = "server=localhost;userid=root;password=;database=pos"

        ' ✅ Get price and mode of payment
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim query = "SELECT Price, ModeOfPayment FROM sales WHERE TRIM(ProductName) = @ProductName AND TicketNumber = @TicketNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@TicketNumber", ticketNum)

                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim priceText = reader("Price").ToString().Trim()
                            allPrices.Add(priceText)

                            If mop = "" AndAlso Not IsDBNull(reader("ModeOfPayment")) Then
                                mop = reader("ModeOfPayment").ToString().Trim()
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting prices from sales table: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim displayPrices = If(allPrices.Count > 0, String.Join(Environment.NewLine, allPrices), "₱0.00")

        ' ✅ Open refund form and send data
        Dim refundForm As New RefundForm
        refundForm.lbl_getticket.Text = ticketNum
        refundForm.lbl_getproducts.Text = productName
        refundForm.lbl_getprice.Text = displayPrices
        refundForm.lbl_getsubtotal.Text = subtotal
        refundForm.lbl_getvat.Text = vat
        refundForm.lbl_gettotal.Text = totalAmount
        refundForm.lbl_MOP.Text = If(mop <> "", mop, "")

        refundForm.ShowDialog()

        ' ✅ If user confirmed refund
        If refundForm.DialogResult = DialogResult.OK Then
            ' ✅ 1. Restore stock for refunded items
            RestoreStockForTicket(ticketNum)

            ' ✅ 2. Refresh transactions
            LoadTransactions()

            ' ✅ 3. Update total refunded label in CashManagementControll
            Dim shiftForm As ShiftContent = Dashboard.shiftInstance
            If shiftForm IsNot Nothing AndAlso shiftForm.Panel2.Controls.Count > 0 Then
                Dim cashCtrl As CashManagementControll = TryCast(shiftForm.Panel2.Controls(0), CashManagementControll)
                If cashCtrl IsNot Nothing Then
                    ' Get total refunded from DB and update label
                    Dim totalRefunds As Decimal = GetTotalRefunded()
                    cashCtrl.lbl_srefunds.Text = "₱" & totalRefunds.ToString("N2")
                    cashCtrl.ComputeTotal()
                End If
            End If

            MessageBox.Show("Refund applied and stock restored successfully.", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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

End Class
