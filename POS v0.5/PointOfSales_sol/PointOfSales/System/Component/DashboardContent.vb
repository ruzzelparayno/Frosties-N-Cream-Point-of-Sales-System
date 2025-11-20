Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class DashboardContent
    Private connectionString As String = "server=localhost;userid=root;password=;database=pos;"

    Private Sub DashboardContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdjustLayout()
        LoadWeeklySales()
        LoadLowStockProducts()
        LoadTodayOrders()
        LoadTodayGrossSales()
        LoadTop5BestSellers()
        SiticoneBarChart1.BackColor = Color.Transparent
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
        Else
            Panel2.Size = New Size(758, 125)

            Label2.Font = New Font(Label2.Font.FontFamily, 12, Label2.Font.Style)
            Label3.Font = New Font(Label3.Font.FontFamily, 40, Label3.Font.Style)
            Label5.Font = New Font(Label5.Font.FontFamily, 12, Label5.Font.Style)
            Label4.Font = New Font(Label4.Font.FontFamily, 40, Label4.Font.Style)
            Label7.Font = New Font(Label7.Font.FontFamily, 12, Label7.Font.Style)
        End If
    End Sub

    ' =======================
    '  📊 WEEKLY SALES
    ' =======================
    Private Sub LoadWeeklySales()
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
                LEFT JOIN sales s ON DAYOFWEEK(s.SaleDate) = day_names.DayOfWeek
                    AND YEARWEEK(s.SaleDate, 1) = YEARWEEK(CURDATE(), 1)
                GROUP BY day_names.DayName, day_names.DayOfWeek
                ORDER BY day_names.DayOfWeek;
            "

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    table.Columns("DayName").ColumnName = "Month"
                    table.Columns("Revenue").ColumnName = "Revenue"

                    SiticoneBarChart1.DataSource = table
                    SiticoneBarChart1.LabelMember = "Month"
                    SiticoneBarChart1.ValueMember = "Revenue"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading weekly sales: " & ex.Message)
        End Try
    End Sub

    ' =======================
    '  ⚠️ LOW STOCK PRODUCTS
    ' =======================
    Public Sub LoadLowStockProducts()
        Try
            FlowLayoutPanel1.Controls.Clear()

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
                                .Width = 70,
                                .Height = 75,
                                .BackColor = Color.Transparent,
                                .Margin = New Padding(3),
                                .BorderStyle = BorderStyle.FixedSingle
                            }

                            Dim pic As New PictureBox With {
                                .Width = 60,
                                .Height = 35,
                                .SizeMode = PictureBoxSizeMode.Zoom,
                                .Image = productImage,
                                .Top = 4,
                                .Left = 5
                            }

                            Dim lblName As New Label With {
                                .AutoSize = False,
                                .TextAlign = ContentAlignment.MiddleCenter,
                                .Font = New Font("Segoe UI", 6, FontStyle.Bold),
                                .Text = pname,
                                .Width = 60,
                                .Top = 42,
                                .Left = 5,
                                .ForeColor = Color.White
                            }

                            Dim lblStock As New Label With {
                                .AutoSize = False,
                                .TextAlign = ContentAlignment.MiddleCenter,
                                .Font = New Font("Segoe UI", 6, FontStyle.Regular),
                                .Text = "Stock: " & stockQty,
                                .Width = 60,
                                .Top = 55,
                                .Left = 5,
                                .ForeColor = Color.White
                            }

                            If stockQty <= 5 Then
                                productPanel.BackColor = Color.Red
                            End If

                            productPanel.Controls.Add(pic)
                            productPanel.Controls.Add(lblName)
                            productPanel.Controls.Add(lblStock)
                            FlowLayoutPanel1.Controls.Add(productPanel)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading low-stock products: " & ex.Message)
        End Try
    End Sub

    ' =======================
    '  📦 TOP 5 BEST SELLERS
    ' =======================
    ' 🔹 Load Top 5 Best Sellers into FlowLayoutPanel2
    Private Sub LoadTop5BestSellers()
        Try
            FlowLayoutPanel2.Controls.Clear()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                SELECT 
                    s.ProductName, 
                    SUM(s.Quantity) AS TotalSold,
                    p.ProductImage
                FROM sales s
                INNER JOIN products p ON s.ProductName = p.ProductName
                GROUP BY s.ProductName
                ORDER BY TotalSold DESC
                LIMIT 5;
            "

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim pname As String = reader("ProductName").ToString()
                            Dim totalSold As Integer = Convert.ToInt32(reader("TotalSold"))
                            Dim productImage As Image = Nothing

                            If Not IsDBNull(reader("ProductImage")) Then
                                Dim imgBytes() As Byte = DirectCast(reader("ProductImage"), Byte())
                                If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                                    Using ms As New MemoryStream(imgBytes)
                                        productImage = Image.FromStream(ms)
                                    End Using
                                End If
                            End If

                            ' 🔹 Create product display panel
                            Dim productPanel As New Panel With {
                            .Width = 100,
                            .Height = 100,
                            .BackColor = Color.FromArgb(45, 45, 48),
                            .Margin = New Padding(5),
                            .BorderStyle = BorderStyle.FixedSingle
                        }

                            ' 🔹 Picture
                            Dim pic As New PictureBox With {
                            .Width = 90,
                            .Height = 55,
                            .SizeMode = PictureBoxSizeMode.Zoom,
                            .Image = productImage,
                            .Top = 5,
                            .Left = 5
                        }

                            ' 🔹 Product name label
                            Dim lblName As New Label With {
                            .AutoSize = False,
                            .TextAlign = ContentAlignment.MiddleCenter,
                            .Font = New Font("Segoe UI", 7, FontStyle.Bold),
                            .Text = pname,
                            .Width = 90,
                            .Top = 63,
                            .Left = 5,
                            .ForeColor = Color.White
                        }

                            ' 🔹 Total sold label
                            Dim lblSold As New Label With {
                            .AutoSize = False,
                            .TextAlign = ContentAlignment.MiddleCenter,
                            .Font = New Font("Segoe UI", 7, FontStyle.Regular),
                            .Text = "Sold: " & totalSold,
                            .Width = 90,
                            .Top = 80,
                            .Left = 5,
                            .ForeColor = Color.LightGray
                        }

                            productPanel.Controls.Add(pic)
                            productPanel.Controls.Add(lblName)
                            productPanel.Controls.Add(lblSold)
                            FlowLayoutPanel2.Controls.Add(productPanel)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading top 5 best sellers: " & ex.Message)
        End Try
    End Sub


    ' =======================
    '  🧾 ORDERS + SALES
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
        Catch ex As Exception
            MessageBox.Show("Error loading today's gross sales: " & ex.Message)
        End Try
    End Sub

    ' =======================
    '  🔁 REFRESH DASHBOARD
    ' =======================
    Public Sub RefreshDashboard()
        Try
            LoadWeeklySales()
            LoadLowStockProducts()
            LoadTodayOrders()
            LoadTodayGrossSales()
            LoadTop5BestSellers()
        Catch ex As Exception
            MessageBox.Show("Error refreshing dashboard: " & ex.Message)
        End Try
    End Sub
End Class
