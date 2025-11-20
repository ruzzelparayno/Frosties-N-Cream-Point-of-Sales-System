Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SalesContent

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")

    ' Load sales into Guna2DataGridView1
    Public Sub LoadSalesData(Optional ByVal filter As String = "", Optional ByVal sortBy As String = "SaleDate ASC")
        Try
            conn.Open()
            Dim query As String = "SELECT SalesID, SaleDate, ProductName, TicketNumber, TotalAmount FROM sales WHERE 1=1"

            ' Filter by search box if not empty
            If filter <> "" Then
                query &= " AND (ProductName LIKE @filter OR SaleDate LIKE @filter OR TicketNumber LIKE @filter)"
            End If

            ' Add sort
            query &= " ORDER BY " & sortBy

            Dim cmd As New MySqlCommand(query, conn)
            If filter <> "" Then
                cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Guna2DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Load monthly sales into Guna2Chart
    Public Sub LoadMonthlySalesChart()
        Try
            conn.Open()
            Dim currentYear As Integer = DateTime.Now.Year

            Dim query As String = "
            SELECT MONTH(SaleDate) AS SaleMonth, SUM(TotalAmount) AS TotalAmount
            FROM sales
            WHERE YEAR(SaleDate) = @year
            GROUP BY MONTH(SaleDate)
            ORDER BY SaleMonth"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@year", currentYear)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim monthlySales As New Dictionary(Of Integer, Decimal)
            While reader.Read()
                monthlySales(Convert.ToInt32(reader("SaleMonth"))) = Convert.ToDecimal(reader("TotalAmount"))
            End While
            reader.Close()

            GunaChart1.Datasets.Clear()
            Dim series As New Guna.Charts.WinForms.GunaBarDataset()
            series.Label = "Sales"

            For i As Integer = 1 To 12
                Dim monthName As String = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i)
                Dim value As Decimal = If(monthlySales.ContainsKey(i), monthlySales(i), 0)
                series.DataPoints.Add(monthName, value)
            Next

            GunaChart1.Datasets.Add(series)
            GunaChart1.Update()

        Catch ex As Exception
            MessageBox.Show("Error loading monthly sales chart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Populate ComboBox1 with sort options
    Private Sub LoadSortOptions()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Date Ascending")
        ComboBox1.Items.Add("Date Descending")
        ComboBox1.Items.Add("TotalAmount Ascending")
        ComboBox1.Items.Add("TotalAmount Descending")
        ComboBox1.SelectedIndex = 0
    End Sub

    ' Apply sorting based on ComboBox1 selection
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
                Return "SaleDate ASC"
        End Select
    End Function

    ' Refresh both grid and chart
    Public Sub RefreshSales(Optional ByVal filter As String = "")
        LoadSalesData(filter, GetSortQuery())
        LoadMonthlySalesChart()
    End Sub

    ' Form Load
    Private Sub SalesContent_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSortOptions()
        RefreshSales()
    End Sub

    ' ComboBox1 SelectedIndexChanged - update sorting
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RefreshSales(SiticoneButtonTextbox2.Text)
    End Sub

    ' SiticoneButtonTextbox2 TextChanged - search filter
    Private Sub SiticoneButtonTextbox2_TextChanged(sender As Object, e As EventArgs) Handles SiticoneButtonTextbox2.TextChanged
        RefreshSales(SiticoneButtonTextbox2.Text)
    End Sub

End Class
