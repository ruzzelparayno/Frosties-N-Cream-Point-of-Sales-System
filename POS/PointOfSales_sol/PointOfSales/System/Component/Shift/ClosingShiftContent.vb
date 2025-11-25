Public Class ClosingShiftContent

    ' Reference to the existing ShiftContent form
    Public Property MainForm As ShiftContent

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Dim actualCash As String = SiticoneTextBox1.Text.Trim()

        If String.IsNullOrEmpty(actualCash) Then
            MessageBox.Show("Please insert the actual cash amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SiticoneTextBox1.Focus()
            Return
        End If

        ' Success message
        MessageBox.Show("Thank you! Cash amount recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' ❗ Correct: Hide the existing PictureBox1 in ShiftContent
        If MainForm IsNot Nothing Then
            MainForm.PictureBox1.Visible = False  ' <--- THIS IS THE CORRECT LINE
        End If

        ' Hide this form after closing shift
        Me.Hide()

        ' Show CashManagementControll again
        If MainForm IsNot Nothing Then
            MainForm.cashmanagementcontroll.ResetShift()
            MainForm.ShowControl(MainForm.cashmanagementcontroll)
            MainForm.Panel4.Show()
        End If

    End Sub

End Class
