Public Class Edit

    ' 🔹 Custom property for passing product name (renamed to avoid conflict)
    Public Property SelectedProductName As String
    Public lbl_quantity As New Label()

    ' Index of the selected product in ListBox1
    Public Property SelectedIndex As Integer

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize SiticoneUpDown1 with the current quantity
        Dim qty As Integer
        If Integer.TryParse(lbl_quantity.Text, qty) AndAlso qty > 0 Then
            SiticoneUpDown1.Value = qty
        Else
            SiticoneUpDown1.Value = 1
        End If
    End Sub

    ' 🔹 When quantity is changed using the SiticoneUpDown
    Private Sub SiticoneUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles SiticoneUpDown1.ValueChanged
        lbl_quantity.Text = SiticoneUpDown1.Value.ToString()
    End Sub

    ' 🔹 Save button click
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Try
            ' ✅ Validate values before continuing
            If String.IsNullOrEmpty(SelectedProductName) Then
                MessageBox.Show("Product name cannot be empty. Please reopen this edit window from the POS screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If SiticoneUpDown1.Value <= 0 Then
                MessageBox.Show("Quantity must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim updatedQty As Integer = CInt(SiticoneUpDown1.Value)
            Dim productName As String = SelectedProductName

            ' ✅ Step 1: Get the active PosControl from Dashboard
            Dim posForm As PosControl = Dashboard.posInstance
            If posForm Is Nothing Then
                MessageBox.Show("⚠️ POS screen not loaded in Dashboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ✅ Step 2: Find the product in ListBox1
            Dim index As Integer = -1
            For i As Integer = 0 To posForm.ListBox1.Items.Count - 1
                If posForm.ListBox1.Items(i).ToString().Contains(productName) Then
                    index = i
                    Exit For
                End If
            Next

            If index = -1 Then
                MessageBox.Show("Product not found in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ✅ Step 3: Get the old quantity
            Dim oldItem As String = posForm.ListBox1.Items(index).ToString()
            Dim regex As New System.Text.RegularExpressions.Regex("(\d+)x")
            Dim match = regex.Match(oldItem)
            Dim oldQty As Integer = 1
            If match.Success Then oldQty = Convert.ToInt32(match.Groups(1).Value)

            Dim delta As Integer = updatedQty - oldQty

            ' ✅ Step 4: Check and adjust stock
            If delta > 0 Then
                Dim available As Integer = posForm.GetStockQuantity(productName)
                If available < delta Then
                    MessageBox.Show("Not enough stock to increase quantity. Available: " & available, "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                posForm.ChangeStock(productName, -delta)
            ElseIf delta < 0 Then
                posForm.ChangeStock(productName, -delta)
            End If

            ' ✅ Step 5: Update ListBox1 & ListBox2
            posForm.ListBox1.Items(index) = $"{updatedQty}x {productName}"

            Dim oldTotal As Decimal = 0D
            Dim cleanText As String = posForm.ListBox2.Items(index).ToString().Replace("₱", "").Replace(",", "").Trim()
            If Decimal.TryParse(cleanText, oldTotal) Then
                Dim unitPrice As Decimal = If(oldQty > 0, oldTotal / oldQty, oldTotal)
                posForm.ListBox2.Items(index) = "₱" & (unitPrice * updatedQty).ToString("N2")
            End If

            ' ✅ Step 6: Recalculate totals
            posForm.CalculateTotals()

            MessageBox.Show("Quantity updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred while saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SiticoneImageButton1_Click(sender As Object, e As EventArgs) Handles SiticoneImageButton1.Click
        Me.Close()
        ' Return to POS screen via Dashboard
        Dashboard.posInstance.BringToFront()

    End Sub
End Class
