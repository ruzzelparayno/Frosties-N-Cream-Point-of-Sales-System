Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Edit_ProductForm

    Private connectionString As String = "server=localhost;userid=root;password=;database=pos;"
    Public CurrentProductID As Integer = -1
    Public CurrentImage As Image = Nothing

    Public Sub LoadProductData(id As Integer, pname As String, category As String, qty As String, price As String, img As Image)
        CurrentProductID = id

        SiticoneTextBox1.Text = pname
        SiticoneTextBox2.Text = qty
        SiticoneTextBox3.Text = price
        cb_cate.Text = category

        If img IsNot Nothing Then
            PictureBox1.Image = img
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            CurrentImage = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image = CurrentImage
        End If
    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CurrentProductID = -1 Then
            MessageBox.Show("Error: No product selected.")
            Exit Sub
        End If

        Try
            ' SHOW OVERLAY FROM PRODUCTCONTENT


            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                UPDATE products 
                SET ProductName=@name,
                    StockQuantity=@stock,
                    Price=@price,
                    CategoryName=@category,
                    ProductImage=@image
                WHERE ProductID=@id
            "

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", SiticoneTextBox1.Text)
                cmd.Parameters.AddWithValue("@stock", SiticoneTextBox2.Text)
                cmd.Parameters.AddWithValue("@price", SiticoneTextBox3.Text)
                cmd.Parameters.AddWithValue("@category", cb_cate.Text)
                cmd.Parameters.AddWithValue("@id", CurrentProductID)

                ' Convert Image to Byte()
                Dim imgData() As Byte = Nothing
                If PictureBox1.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        imgData = ms.ToArray()
                    End Using
                End If
                cmd.Parameters.AddWithValue("@image", imgData)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Product updated successfully!")

            ProductContent.Instance.LoadInventory()

            ' HIDE OVERLAY

            Me.Close()
            If ProductContent.Instance IsNot Nothing Then
                ProductContent.Instance.SiticoneOverlay1.Show = True
            End If

            Await Task.Delay(1500)

            If ProductContent.Instance IsNot Nothing Then
                ProductContent.Instance.SiticoneOverlay1.Show = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)

            If ProductContent.Instance IsNot Nothing Then
                ProductContent.Instance.SiticoneOverlay1.Show = False
            End If
        End Try
    End Sub

End Class
