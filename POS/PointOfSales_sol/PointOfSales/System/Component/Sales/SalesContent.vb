Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SalesContent

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")

    ' Load sales into Guna2DataGridView1
    Public Sub LoadSalesData()
        Try
            conn.Open()
            Dim query As String = "SELECT SalesID, SaleDate, TotalAmount FROM sales ORDER BY SaleDate ASC"
            Dim cmd As New MySqlCommand(query, conn)
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

            ' Clear previous datasets
            GunaChart1.Datasets.Clear()

            ' Create new bar dataset
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


    ' Refresh both grid and chart
    Public Sub RefreshSales()
        LoadSalesData()
        LoadMonthlySalesChart()
    End Sub

    Private Sub SalesContent_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSalesData()
        LoadMonthlySalesChart()
    End Sub
End Class
