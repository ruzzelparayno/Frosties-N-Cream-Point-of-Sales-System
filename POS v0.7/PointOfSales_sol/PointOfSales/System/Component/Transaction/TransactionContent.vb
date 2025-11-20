Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Threading.Tasks

Public Class TransactionContent
    Public Property AllowCloseOverlay As Boolean = True
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Private dt As DataTable

    ' ----------------- FORM LOAD -----------------
    Private Sub TransactionContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSortOptions()
        LoadTransactions()
    End Sub

    ' ----------------- SORT OPTIONS -----------------
    Private Sub LoadSortOptions()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Date Ascending")
        ComboBox1.Items.Add("Date Descending")
        ComboBox1.Items.Add("TotalAmount Ascending")
        ComboBox1.Items.Add("TotalAmount Descending")
        ComboBox1.SelectedIndex = 1 ' default: Date Descending
    End Sub

    Private Function GetSortQuery() As String
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Date Ascending"
                Return "SaleDate ASC"
            Case "Date Descending"
                Return "SaleDate DESC"
            Case "TotalAmount Ascending"
                Return "TotalAmount ASC"
            Case "TotalAmount Descending"
                Return "TotalAmount DESC"
            Case Else
                Return "SaleDate DESC"
        End Select
    End Function

    ' ----------------- LOAD TRANSACTIONS ASYNC -----------------
    Public Async Sub LoadTransactionsAsync()
        SiticoneOverlay1.Show = True
        Await Task.Delay(2000)
        If AllowCloseOverlay Then
            SiticoneOverlay1.Show = False
        End If
    End Sub

    ' Main function to load transactions with filters
    Private Sub LoadTransactions(Optional ByVal filter As String = "")
        Try
            conn.Open()

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

            ' ----------------- DATE FILTER -----------------
            If SiticoneDateTimePicker1.Value.HasValue AndAlso SiticoneDateTimePicker2.Value.HasValue Then
                query &= " AND SaleDate BETWEEN @dateFrom AND @dateTo"
            ElseIf SiticoneDateTimePicker1.Value.HasValue Then
                query &= " AND DATE(SaleDate) = @dateFrom"
            ElseIf SiticoneDateTimePicker2.Value.HasValue Then
                query &= " AND SaleDate <= @dateTo"
            End If

            ' ----------------- SEARCH FILTER -----------------
            If filter <> "" Then
                query &= " AND (ProductName LIKE @filter OR TicketNumber LIKE @filter OR SaleDate LIKE @filter)"
            End If

            ' ----------------- SORT -----------------
            query &= " ORDER BY " & GetSortQuery()

            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters
            If SiticoneDateTimePicker1.Value.HasValue Then cmd.Parameters.AddWithValue("@dateFrom", SiticoneDateTimePicker1.SelectedDate)
            If SiticoneDateTimePicker2.Value.HasValue Then cmd.Parameters.AddWithValue("@dateTo", SiticoneDateTimePicker2.SelectedDate)
            If filter <> "" Then cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            dt = New DataTable()
            adapter.Fill(dt)

            If Guna2DataGridView1.InvokeRequired Then
                Guna2DataGridView1.Invoke(Sub() Guna2DataGridView1.DataSource = dt)
            Else
                Guna2DataGridView1.DataSource = dt
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' ----------------- EVENT HANDLERS -----------------
    Private Sub SiticoneButtonTextbox1_TextChanged(sender As Object, e As EventArgs) Handles SiticoneButtonTextbox1.TextChanged
        LoadTransactions()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadTransactions()
    End Sub

    Private Sub SiticoneDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles SiticoneDateTimePicker1.ValueChanged
        LoadTransactions()
    End Sub

    Private Sub SiticoneDateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles SiticoneDateTimePicker2.ValueChanged
        LoadTransactions()
    End Sub

    Private Async Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        SiticoneOverlay1.Show = True
        Await Task.Delay(2000)
        If AllowCloseOverlay Then
            SiticoneOverlay1.Show = False
        End If
    End Sub

    Private Async Sub SiticoneDateTimePicker1_Click(sender As Object, e As EventArgs) Handles SiticoneDateTimePicker1.Click
        SiticoneOverlay1.Show = True
        Await Task.Delay(2000)
        If AllowCloseOverlay Then
            SiticoneOverlay1.Show = False
        End If
    End Sub

    Private Async Sub SiticoneDateTimePicker2_Click(sender As Object, e As EventArgs) Handles SiticoneDateTimePicker2.Click
        SiticoneOverlay1.Show = True
        Await Task.Delay(2000)
        If AllowCloseOverlay Then
            SiticoneOverlay1.Show = False
        End If
    End Sub

    ' ----------------- ORIGINAL FUNCTIONS -----------------
    Private Function GetTotalRefunded() As Decimal
        Dim totalRefund As Decimal = 0D
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
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
            Using c As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                c.Open()
                Dim q As String = "SELECT ProductName, Quantity FROM sales WHERE TicketNumber=@TicketNumber AND Status='Completed'"
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
                        For Each pair In toRestore
                            Using upd As New MySqlCommand("UPDATE products SET StockQuantity = StockQuantity + @qty WHERE ProductName=@pname", c)
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

    Private Function GetProductPrice(productName As String) As String
        Dim price As String = "₱0.00"
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()
                Dim query As String = "SELECT Price FROM products WHERE ProductName=@ProductName LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", productName.Trim())
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then price = Convert.ToDecimal(result).ToString("₱0.00")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting product price: " & ex.Message)
        End Try
        Return price
    End Function

    Private Sub Guna2DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentDoubleClick

    End Sub

    Private Async Sub Guna2DataGridView1_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        SiticoneOverlay1.Show = True
        Await Task.Delay(1500)
        Dim selectedRow = Guna2DataGridView1.Rows(e.RowIndex)
        Dim ticketNum = selectedRow.Cells("TicketNumber").Value.ToString()
        Dim productName = selectedRow.Cells("ProductName").Value.ToString().Trim()
        Dim subtotal = selectedRow.Cells("Subtotal").Value.ToString()
        Dim vat = selectedRow.Cells("Vat").Value.ToString()
        Dim totalAmount = selectedRow.Cells("TotalAmount").Value.ToString()

        Dim allPrices As New List(Of String)
        Dim mop = ""

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
                conn.Open()
                Dim query = "SELECT Price, ModeOfPayment FROM sales WHERE TRIM(ProductName)=@ProductName AND TicketNumber=@TicketNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@TicketNumber", ticketNum)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            allPrices.Add(reader("Price").ToString().Trim())
                            If mop = "" AndAlso Not IsDBNull(reader("ModeOfPayment")) Then mop = reader("ModeOfPayment").ToString().Trim()
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting prices: " & ex.Message)
            If AllowCloseOverlay Then
                SiticoneOverlay1.Show = False
            End If
            Exit Sub
        End Try

        Dim displayPrices = If(allPrices.Count > 0, String.Join(Environment.NewLine, allPrices), "₱0.00")

        ' Open refund form
        Dim refundForm As New RefundForm
        refundForm.lbl_getticket.Text = ticketNum
        refundForm.lbl_getproducts.Text = productName
        refundForm.lbl_getprice.Text = displayPrices
        refundForm.lbl_getsubtotal.Text = subtotal
        refundForm.lbl_getvat.Text = vat
        refundForm.lbl_gettotal.Text = totalAmount
        refundForm.lbl_MOP.Text = If(mop <> "", mop, "")
        refundForm.ShowDialog()

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
            If AllowCloseOverlay Then
                SiticoneOverlay1.Show = False
            End If
        End If
    End Sub
End Class
