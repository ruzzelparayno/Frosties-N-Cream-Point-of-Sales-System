Public Class Charge_Success
    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        ' ✅ Hide the current success form
        Me.Hide()

        ' ✅ Safely return to POS screen
        If Dashboard.posInstance IsNot Nothing Then
            Dashboard.posInstance.BringToFront()
        Else
            MessageBox.Show("POS screen not found. Please reopen the POS module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
