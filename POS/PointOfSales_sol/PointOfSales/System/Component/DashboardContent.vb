Imports System.Globalization
Imports System.IO
Imports Guna.Charts.Interfaces
Imports Guna.Charts.WinForms
Imports MySql.Data.MySqlClient
Imports SiticoneNetFrameworkUI


Public Class DashboardContent
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos;"

    ' ✅ Shared instance for cross-dashboard access
    Public Shared Instance As DashboardContent

    Private Sub DashboardContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        AdjustLayout()
        RefreshDashboard()
        LoadWeeklySales_GunaChart()
        LoadCategoryDoughnutChart()
        LoadRevenueByCategory_LineChart()
        LoadMonthlyTransactions_GunaChart()
        LoadTotalRevenue()
    End Sub

    ' ✅ Auto-refresh when control becomes visible (e.g., switching panels)
    Private Sub DashboardContent_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            RefreshDashboard()
        End If
    End Sub

    Private Sub DashboardContent_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AdjustLayout()
    End Sub

    Private Sub AdjustLayout()
        Dim parentForm As Form = Nothing
        Dim isMaximized As Boolean = False

        Try
            If Me.Parent IsNot Nothing Then
                parentForm = Me.Parent.FindForm()
            End If
        Catch
        End Try

        If parentForm IsNot Nothing Then
            isMaximized = (parentForm.WindowState = FormWindowState.Maximized)
        End If

        If isMaximized Then
            Panel2.Size = New Size(758, 175)
            Label2.Font = New Font(Label2.Font.FontFamily, 20, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 60, Label3.Font.Style)
            Label5.Font = New Font(Label5.Font.FontFamily, 20, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 60, Label4.Font.Style)
            Label7.Font = New Font(Label7.Font.FontFamily, 20, Label7.Font.Style)

            Label1.Font = New Font(Label1.Font.FontFamily, 20, Label1.Font.Style)
            Label6.Font = New Font(Label6.Font.FontFamily, 20, Label6.Font.Style)
            Label8.Font = New Font(Label8.Font.FontFamily, 20, Label8.Font.Style)
            Label9.Font = New Font(Label9.Font.FontFamily, 20, Label9.Font.Style)
            Label10.Font = New Font(Label10.Font.FontFamily, 20, Label10.Font.Style)

            FlowLayoutPanel2.Padding = New Padding(85, FlowLayoutPanel2.Padding.Top, FlowLayoutPanel2.Padding.Right, FlowLayoutPanel2.Padding.Bottom)
        Else
            Panel2.Size = New Size(758, 125)
            Label2.Font = New Font(Label2.Font.FontFamily, 12, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 40, Label3.Font.Style)
            Label5.Font = New Font(Label5.Font.FontFamily, 12, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 40, Label4.Font.Style)
            Label7.Font = New Font(Label7.Font.FontFamily, 12, Label7.Font.Style)

            Label1.Font = New Font(Label1.Font.FontFamily, 12, Label1.Font.Style)
            Label6.Font = New Font(Label6.Font.FontFamily, 12, Label6.Font.Style)
            Label8.Font = New Font(Label8.Font.FontFamily, 12, Label8.Font.Style)
            Label9.Font = New Font(Label9.Font.FontFamily, 12, Label9.Font.Style)
            Label10.Font = New Font(Label10.Font.FontFamily, 12, Label10.Font.Style)

            FlowLayoutPanel2.Padding = New Padding(0, FlowLayoutPanel2.Padding.Top, FlowLayoutPanel2.Padding.Right, FlowLayoutPanel2.Padding.Bottom)
        End If
    End Sub


    ' =======================
    ' ⚠️ LOW STOCK PRODUCTS
    ' =======================
    Public Sub LoadLowStockProducts()
        Try
            FlowLayoutPanel2.Controls.Clear()

            ' 1️⃣ Create a tracker variable
            Dim hasLowStock As Boolean = False

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                    SELECT ProductID, ProductName, ProductImage, Price, StockQuantity
                    FROM products
                    WHERE StockQuantity <= 13
                    ORDER BY StockQuantity ASC
                "

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()

                            ' 2️⃣ We found a row, so set the tracker to True
                            hasLowStock = True

                            Dim pname As String = reader("ProductName").ToString()
                            Dim stockQty As Integer = Convert.ToInt32(reader("StockQuantity"))

                            Dim productImage As Image = Nothing
                            If Not IsDBNull(reader("ProductImage")) Then
                                Dim imgBytes() As Byte = DirectCast(reader("ProductImage"), Byte())
                                If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                                    Using ms As New MemoryStream(imgBytes)
                                        productImage = Image.FromStream(ms)
                                    End Using
                                End If
                            End If

                            Dim productPanel As New Panel With {
                                .Width = 143,
                                .Height = 160,
                                .BackColor = Color.FromArgb(217, 220, 235),
                                .Margin = New Padding(3)
                            }

                            Dim pic As New PictureBox With {
                                .Width = 64,
                                .Height = 54,
                                .SizeMode = PictureBoxSizeMode.Zoom,
                                .Image = productImage,
                                .Dock = DockStyle.Fill
                            }

                            Dim lblName As New Label With {
                                .AutoSize = False,
                                .TextAlign = ContentAlignment.TopCenter,
                                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                                .Text = pname,
                                .Dock = DockStyle.Top,
                                .ForeColor = Color.FromArgb(75, 75, 75)
                            }

                            Dim lblStock As New Label With {
                                .AutoSize = False,
                                .TextAlign = ContentAlignment.MiddleCenter,
                                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                                .Text = stockQty & " QTY",
                                .Dock = DockStyle.Bottom,
                                .ForeColor = Color.FromArgb(75, 75, 75)
                            }

                            If stockQty <= 5 Then
                                productPanel.BackColor = Color.Red
                            End If

                            productPanel.Controls.Add(pic)
                            productPanel.Controls.Add(lblName)
                            productPanel.Controls.Add(lblStock)

                            FlowLayoutPanel2.Controls.Add(productPanel)
                        End While

                    End Using
                End Using
            End Using

            ' 3️⃣ VISIBILITY LOGIC
            If hasLowStock = True Then
                ' Items exist -> Hide the "Empty/All Good" Panel
                FlowLayoutPanel2.Visible = True
                Guna2Panel1.Visible = False
            Else
                ' No items found -> Show the "Empty/All Good" Panel
                Guna2Panel1.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading low-stock products: " & ex.Message)
        End Try
    End Sub


    ' =======================
    ' 📦 TOP 5 BEST SELLERS (3 PER ROW)
    ' =======================
    Private Sub LoadTop5BestSellers()
        'Try
        '    FlowLayoutPanel2.Controls.Clear()

        '    ' ✅ Force 3 per row
        '    FlowLayoutPanel2.WrapContents = True
        '    FlowLayoutPanel2.FlowDirection = FlowDirection.LeftToRight
        '    FlowLayoutPanel2.AutoScroll = False
        '    FlowLayoutPanel2.Padding = New Padding(10)
        '    FlowLayoutPanel2.Width = 3 * 110 + 50 ' each 110px + padding spacing

        '    Using conn As New MySqlConnection(connectionString)
        '        conn.Open()

        '        Dim query As String = "
        '            SELECT 
        '                s.ProductName, 
        '                SUM(s.Quantity) AS TotalSold,
        '                p.ProductImage
        '            FROM sales s
        '            INNER JOIN products p ON s.ProductName = p.ProductName
        '            GROUP BY s.ProductName
        '            ORDER BY TotalSold DESC
        '            LIMIT 5;
        '        "

        '        Using cmd As New MySqlCommand(query, conn)
        '            Using reader As MySqlDataReader = cmd.ExecuteReader()
        '                Dim count As Integer = 0
        '                Dim currentRowPanel As FlowLayoutPanel = Nothing

        '                While reader.Read()
        '                    Dim pname As String = reader("ProductName").ToString()
        '                    Dim totalSold As Integer = Convert.ToInt32(reader("TotalSold"))
        '                    Dim productImage As Image = Nothing

        '                    If Not IsDBNull(reader("ProductImage")) Then
        '                        Dim imgBytes() As Byte = DirectCast(reader("ProductImage"), Byte())
        '                        If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
        '                            Using ms As New MemoryStream(imgBytes)
        '                                productImage = Image.FromStream(ms)
        '                            End Using
        '                        End If
        '                    End If

        '                    Dim productPanel As New Panel With {
        '                        .Width = 100,
        '                        .Height = 100,
        '                        .BackColor = Color.FromArgb(217, 220, 235),
        '                        .Margin = New Padding(5),
        '                        .BorderStyle = BorderStyle.FixedSingle
        '                    }

        '                    Dim pic As New PictureBox With {
        '                        .Width = 90,
        '                        .Height = 55,
        '                        .SizeMode = PictureBoxSizeMode.Zoom,
        '                        .Image = productImage,
        '                        .Top = 5,
        '                        .Left = 5
        '                    }

        '                    Dim lblName As New Label With {
        '                        .AutoSize = False,
        '                        .TextAlign = ContentAlignment.MiddleCenter,
        '                        .Font = New Font("Segoe UI", 7, FontStyle.Bold),
        '                        .Text = pname,
        '                        .Width = 90,
        '                        .Top = 63,
        '                        .Left = 5,
        '                        .ForeColor = Color.FromArgb(75, 75, 75)
        '                    }

        '                    Dim lblSold As New Label With {
        '                        .AutoSize = False,
        '                        .TextAlign = ContentAlignment.MiddleCenter,
        '                        .Font = New Font("Segoe UI", 7, FontStyle.Regular),
        '                        .Text = "Sold: " & totalSold,
        '                        .Width = 90,
        '                        .Top = 80,
        '                        .Left = 5,
        '                        .ForeColor = Color.FromArgb(75, 75, 75)
        '                    }

        '                    productPanel.Controls.Add(pic)
        '                    productPanel.Controls.Add(lblName)
        '                    productPanel.Controls.Add(lblSold)
        '                    FlowLayoutPanel2.Controls.Add(productPanel)

        '                    count += 1
        '                End While
        '            End Using
        '        End Using
        '    End Using
        'Catch ex As Exception
        '    MessageBox.Show("Error loading top 5 best sellers: " & ex.Message)
        'End Try
    End Sub

    ' =======================
    ' 🧾 ORDERS + SALES
    ' =======================
    Private Sub LoadTodayOrders()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    SELECT COUNT(DISTINCT SalesID)
                    FROM sales
                    WHERE DATE(SaleDate) = CURDATE();
                "
                Using cmd As New MySqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Label3.Text = count.ToString("N0")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading today's orders: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTodayGrossSales()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                    SELECT IFNULL(SUM(TotalAmount), 0)
                    FROM sales
                    WHERE DATE(SaleDate) = CURDATE();
                "
                Using cmd As New MySqlCommand(query, conn)
                    Dim totalSales As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    Label4.Text = totalSales.ToString("N2", CultureInfo.InvariantCulture)
                End Using
            End Using

            ' 🔹 Adjust font size based on text length
            AdjustGrossSalesFont()

        Catch ex As Exception
            MessageBox.Show("Error loading today's gross sales: " & ex.Message)
        End Try
    End Sub

    ' =======================
    ' 🔁 REFRESH DASHBOARD
    ' =======================
    Public Sub RefreshDashboard()
        Try
            LoadLowStockProducts()
            LoadTodayOrders()
            LoadTodayGrossSales()
            LoadTop5BestSellers()
            LoadWeeklySales_GunaChart()
            LoadCategoryDoughnutChart()
            LoadRevenueByCategory_LineChart()
            LoadMonthlyTransactions_GunaChart()
            LoadTotalRevenue()
        Catch ex As Exception
            MessageBox.Show("Error refreshing dashboard: " & ex.Message)
        End Try
    End Sub


    ' =======================
    ' 📊 WEEKLY SALES
    ' =======================

    Private Sub LoadWeeklySales_GunaChart()
        Try
            Dim query As String = "
            SELECT 
                day_names.DayName,
                IFNULL(SUM(s.TotalAmount), 0) AS Revenue
            FROM (
                SELECT 'Mon' AS DayName, 2 AS DayOfWeek UNION
                SELECT 'Tue', 3 UNION
                SELECT 'Wed', 4 UNION
                SELECT 'Thu', 5 UNION
                SELECT 'Fri', 6 UNION
                SELECT 'Sat', 7 UNION
                SELECT 'Sun', 1
            ) AS day_names
            LEFT JOIN sales s 
                ON DAYOFWEEK(s.SaleDate) = day_names.DayOfWeek
                AND YEARWEEK(s.SaleDate, 1) = YEARWEEK(CURDATE(), 1)
            GROUP BY day_names.DayName, day_names.DayOfWeek
            ORDER BY day_names.DayOfWeek;
        "

            ' 🔹 Prepare chart
            GunaChart1.Datasets.Clear()

            Dim dataset As New Guna.Charts.WinForms.GunaBarDataset()
            dataset.Label = "Weekly Sales"
            dataset.FillColors.Add(Color.FromArgb(255, 0, 148, 255)) ' Cornflower Blue

            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim dayName As String = reader("DayName").ToString()
                            Dim revenue As Decimal = Convert.ToDecimal(reader("Revenue"))

                            ' Add label and value
                            dataset.DataPoints.Add(dayName, revenue)
                        End While
                    End Using
                End Using
            End Using

            ' 🔹 Add dataset to chart
            GunaChart1.Datasets.Add(dataset)

            ' 🔹 Chart appearance customization
            GunaChart1.YAxes.GridLines.Display = True
            GunaChart1.YAxes.Ticks.ForeColor = Color.FromArgb(75, 75, 75)
            GunaChart1.XAxes.Ticks.ForeColor = Color.FromArgb(75, 75, 75)
            GunaChart1.Legend.LabelForeColor = Color.FromArgb(75, 75, 75)
            GunaChart1.Title.ForeColor = Color.FromArgb(75, 75, 75)
            GunaChart1.Update()

        Catch ex As Exception
            MessageBox.Show("Error loading weekly sales: " & ex.Message)
        End Try
    End Sub
    ' =======================
    ' 🔧 ADJUST FONT SIZE BASED ON LENGTH
    ' =======================
    Private Sub AdjustGrossSalesFont()
        ' Remove formatting characters to count only digits
        Dim numericText As String = Label4.Text.Replace(",", "").Replace(".", "")
        If numericText.Length >= 9 Then
            Label4.Font = New Font(Label4.Font.FontFamily, 8, Label4.Font.Style)
        Else
            ' Reset to default size depending on form state
            If Me.Parent IsNot Nothing AndAlso Me.Parent.FindForm() IsNot Nothing AndAlso Me.Parent.FindForm().WindowState = FormWindowState.Maximized Then
                Label4.Font = New Font(Label4.Font.FontFamily, 60, Label4.Font.Style)
            Else
                Label4.Font = New Font(Label4.Font.FontFamily, 40, Label4.Font.Style)
            End If
        End If
    End Sub

    Private Sub LoadCategoryDoughnutChart()
        Try
            Dim dt As New DataTable()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' This query now works because we added the 'Category' column in Step 1
                Dim query As String = "
                SELECT Category, SUM(TotalAmount) AS Amount
                FROM sales
                GROUP BY Category;
            "

                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

            ' 🔹 Bind DataSource
            SiticoneDoughnutChart1.DataSource = dt
            SiticoneDoughnutChart1.LabelMember = "Category"
            SiticoneDoughnutChart1.ValueMember = "Amount"
            SiticoneDoughnutChart1.BackColor = Color.FromArgb(217, 220, 235)

            ' 🔹 Compute total for center text
            Dim total As Decimal = 0
            For Each row As DataRow In dt.Rows
                ' Added check for DBNull to prevent crashes on empty data
                If Not IsDBNull(row("Amount")) Then
                    total += Convert.ToDecimal(row("Amount"))
                End If
            Next

            SiticoneDoughnutChart1.CenterText = "Total"
            SiticoneDoughnutChart1.CenterSubText = "₱" & total.ToString("N2")

            ' 🔹 Refresh chart
            SiticoneDoughnutChart1.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error loading chart by category: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadRevenueByCategory_LineChart()
        Try
            ' 1. Clear existing data to prevent duplicates
            GunaChart2.Datasets.Clear()

            ' 2. Create the Line Dataset
            Dim lineDataset As New Guna.Charts.WinForms.GunaLineDataset()
            lineDataset.Label = "Revenue"
            lineDataset.BorderColor = Color.FromArgb(255, 0, 148, 255) ' Choose your line color
            lineDataset.PointRadius = 5  ' Make the dots visible
            lineDataset.PointFillColors.Add(Color.FromArgb(255, 0, 148, 255))
            lineDataset.PointBorderColors.Add(Color.FromArgb(255, 0, 148, 255))
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' ✅ ROBUST QUERY: Uses TRIM to fix spaces and COALESCE for safety
                Dim query As String = "
                    SELECT 
                        COALESCE(p.CategoryName, 'Uncategorized') AS Category, 
                        IFNULL(SUM(s.TotalAmount), 0) AS Revenue
                    FROM sales s
                    LEFT JOIN products p ON TRIM(s.ProductName) = TRIM(p.ProductName)
                    GROUP BY COALESCE(p.CategoryName, 'Uncategorized')
                    ORDER BY p.CategoryName ASC; 
                "

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim category As String = reader("Category").ToString()
                            Dim revenue As Double = Convert.ToDouble(reader("Revenue"))

                            ' 3. Add Data Point to Guna Dataset
                            ' Guna uses .DataPoints.Add(Label, Value)
                            lineDataset.DataPoints.Add(category, revenue)
                        End While
                    End Using
                End Using
            End Using

            ' 4. Add the dataset to the chart and update
            GunaChart2.Datasets.Add(lineDataset)
            GunaChart2.Update()

        Catch ex As Exception
            MessageBox.Show("Error loading Guna Line Chart: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadMonthlyTransactions_GunaChart()
        Try
            ' Clear previous datasets
            GunaChart3.Datasets.Clear()

            ' Create a new bar dataset
            Dim barDataset As New Guna.Charts.WinForms.GunaBarDataset()
            barDataset.Label = "Monthly Transactions"
            barDataset.FillColors.Add(Color.FromArgb(255, 0, 148, 255)) ' Purple theme

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                SELECT 
                    DATE_FORMAT(SaleDate, '%b') AS MonthName,
                    COUNT(SalesID) AS TotalTransactions
                FROM sales
                GROUP BY MONTH(SaleDate)
                ORDER BY MONTH(SaleDate);
            "

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim monthName As String = reader("MonthName").ToString()
                            Dim total As Integer = Convert.ToInt32(reader("TotalTransactions"))

                            ' Add datapoint
                            barDataset.DataPoints.Add(monthName, total)
                        End While
                    End Using
                End Using
            End Using

            ' Add dataset to chart
            GunaChart3.Datasets.Add(barDataset)

            ' Beautify Chart
            GunaChart3.YAxes.GridLines.Display = True
            GunaChart3.YAxes.Ticks.ForeColor = Color.FromArgb(75, 75, 75)
            GunaChart3.XAxes.Ticks.ForeColor = Color.FromArgb(75, 75, 75)
            GunaChart3.Legend.LabelForeColor = Color.FromArgb(75, 75, 75)

            GunaChart3.Update()

        Catch ex As Exception
            MessageBox.Show("Error loading monthly transactions: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadTotalRevenue()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                SELECT IFNULL(SUM(TotalAmount), 0)
                FROM sales;
            "

                Using cmd As New MySqlCommand(query, conn)
                    Dim totalRev As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    Label11.Text = "₱" & totalRev.ToString("N2")

                    ' 🔹 Adjust font size based on number of digits
                    Dim txt As String = Label11.Text.Replace("₱", "").Replace(",", "").Split("."c)(0)
                    Dim digitCount As Integer = txt.Length

                    If digitCount >= 9 Then
                        Label11.Font = New Font(Label11.Font.FontFamily, 20, FontStyle.Bold)
                    ElseIf digitCount >= 8 Then
                        Label11.Font = New Font(Label11.Font.FontFamily, 24, FontStyle.Bold)
                    Else
                        Label11.Font = New Font(Label11.Font.FontFamily, 28, FontStyle.Bold)
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading total revenue: " & ex.Message)
        End Try
    End Sub


End Class
