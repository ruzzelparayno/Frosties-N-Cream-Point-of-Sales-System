Public Class edit

    Public Class Edit
        Public lbl_getproductname As New Label()
        Public lbl_quantity As New Label()
    End Class

    ' Index of the selected product in ListBox1
    Public Property SelectedIndex As Integer

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default quantity validation
        If Not IsNumeric(lbl_quantity.Text) OrElse Val(lbl_quantity.Text) <= 0 Then
            lbl_quantity.Text = "1"
        End If
    End Sub

    ' 🔹 Add Quantity
    Private Sub lbl_add_Click(sender As Object, e As EventArgs) Handles lbl_add.Click
        Dim qty As Integer = Val(lbl_quantity.Text)
        qty += 1
        lbl_quantity.Text = qty.ToString()
    End Sub

    ' 🔹 Minus Quantity
    Private Sub lbl_minus_Click(sender As Object, e As EventArgs) Handles lbl_minus.Click
        Dim qty As Integer = Val(lbl_quantity.Text)
        If qty > 1 Then qty -= 1
        lbl_quantity.Text = qty.ToString()
    End Sub

    ' 🔹 Save Edited Quantity
    Private Sub btn_editsave_Click(sender As Object, e As EventArgs) Handles btn_editsave.Click
        Try
            Dim updatedQty As Integer = Convert.ToInt32(lbl_quantity.Text.Trim()) ' Quantity after editing
            Dim productName As String = lbl_getproductname.Text.Trim()            ' Product name being edited

            ' ✅ Step 1: Get the active PosControl from Dashboard
            Dim posForm As PosControl = Dashboard.posInstance

            If posForm Is Nothing Then
                MessageBox.Show("⚠️ PosControl instance is not loaded in Dashboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ✅ Step 2: Find and update the matching product in PosControl
            For i As Integer = 0 To posForm.ListBox1.Items.Count - 1
                Dim item As String = posForm.ListBox1.Items(i).ToString()

                If item.Contains(productName) Then
                    ' Update ListBox1 with new quantity
                    posForm.ListBox1.Items(i) = $"{updatedQty}x {productName}"

                    ' Update total price in ListBox2
                    Dim oldTotal As Decimal = 0D
                    Dim cleanText As String = posForm.ListBox2.Items(i).ToString().Replace("₱", "").Replace(",", "").Trim()

                    If Decimal.TryParse(cleanText, oldTotal) Then
                        ' Extract old quantity using regex
                        Dim oldQty As Integer = 1
                        Dim regex As New System.Text.RegularExpressions.Regex("(\d+)x")
                        Dim match = regex.Match(item)
                        If match.Success Then oldQty = Convert.ToInt32(match.Groups(1).Value)

                        ' Compute new total price
                        Dim unitPrice As Decimal = If(oldQty > 0, oldTotal / oldQty, oldTotal)
                        posForm.ListBox2.Items(i) = "₱" & (unitPrice * updatedQty).ToString("N2")
                    End If

                    Exit For
                End If
            Next

            ' ✅ Step 3: Refresh totals
            posForm.CalculateTotals()

            ' ✅ Step 4: Close edit form
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred while saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
