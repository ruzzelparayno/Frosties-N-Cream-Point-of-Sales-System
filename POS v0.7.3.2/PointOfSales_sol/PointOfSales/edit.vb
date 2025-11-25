Imports MySql.Data.MySqlClient

Public Class Edit
    Public ParentPOS As PosControl
    Public AllowCloseOverlay As Boolean = False

    ' 🔹 Properties to receive product details from PosControl
    Public Property SelectedProductName As String
    Public Property SelectedProductPrice As Decimal
    Public Property SelectedProductImage As Image

    Public lbl_quantity As New Label()

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Show product details in Edit form
        If Not String.IsNullOrEmpty(SelectedProductName) Then
            Label1.Text = SelectedProductName
        End If

        Label4.Text = "₱" & SelectedProductPrice.ToString("N2")

        If SelectedProductImage IsNot Nothing Then
            PictureBox1.Image = SelectedProductImage
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image = My.Resources.POS_imge ' optional placeholder
        End If


        ' Default quantity setup
        Dim qty As Integer = 1
        If Integer.TryParse(lbl_quantity.Text, qty) = False OrElse qty <= 0 Then
            qty = 1
        End If
        SiticoneUpDown1.Value = qty
        lbl_quantity.Text = qty.ToString()
    End Sub

    Private Sub SiticoneUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles SiticoneUpDown1.ValueChanged
        lbl_quantity.Text = SiticoneUpDown1.Value.ToString()
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Try
            If String.IsNullOrWhiteSpace(SelectedProductName) Then
                MessageBox.Show("Product name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If SiticoneUpDown1.Value <= 0 Then
                MessageBox.Show("Quantity must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim updatedQty As Integer = CInt(SiticoneUpDown1.Value)
            Dim productName As String = SelectedProductName
            Dim productPrice As Decimal = SelectedProductPrice

            Dim posForm As PosControl = Dashboard.posInstance
            If posForm Is Nothing Then
                MessageBox.Show("POS screen not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Find product row in DataGridView
            Dim foundRow As DataGridViewRow = Nothing
            For Each row As DataGridViewRow In posForm.Guna2DataGridView1.Rows
                If row.IsNewRow Then Continue For
                If row.Cells("ProductName").Value IsNot Nothing AndAlso
                   String.Equals(row.Cells("ProductName").Value.ToString(), productName, StringComparison.OrdinalIgnoreCase) Then
                    foundRow = row
                    Exit For
                End If
            Next

            If foundRow Is Nothing Then
                ' Product not yet in cart → add it
                posForm.Guna2DataGridView1.Rows.Add(updatedQty, productName, (productPrice * updatedQty).ToString("N2"))
                posForm.ChangeStock(productName, -updatedQty)
            Else
                ' Update existing product
                Dim oldQty As Integer = Convert.ToInt32(foundRow.Cells("Quantity").Value)
                Dim delta As Integer = updatedQty - oldQty

                ' Check stock if increasing quantity
                If delta > 0 Then
                    Dim available As Integer = posForm.GetStockQuantity(productName)
                    If available < delta Then
                        MessageBox.Show("Not enough stock. Available: " & available, "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    posForm.ChangeStock(productName, -delta)
                ElseIf delta < 0 Then
                    posForm.ChangeStock(productName, -delta) ' return stock
                End If

                foundRow.Cells("Quantity").Value = updatedQty
                foundRow.Cells("Price").Value = (productPrice * updatedQty).ToString("N2")
            End If

            posForm.CalculateTotals()
            AllowCloseOverlay = True
            If ParentPOS IsNot Nothing Then
                ParentPOS.SiticoneOverlay1.Show = False
            End If
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SiticoneImageButton1_Click(sender As Object, e As EventArgs) Handles SiticoneImageButton1.Click
        AllowCloseOverlay = True
        If ParentPOS IsNot Nothing Then
            ParentPOS.SiticoneOverlay1.Show = False
        End If
        Me.Close()
    End Sub

End Class
