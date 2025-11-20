Public Class ClosingShiftContent

    ' Use a unique property name to reference the parent form
    Public Property MainForm As ShiftContent

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs) Handles SiticoneButton1.Click
        Dim actualCash As String = SiticoneTextBox1.Text.Trim()

        If String.IsNullOrEmpty(actualCash) Then
            MessageBox.Show("Please insert the actual cash amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SiticoneTextBox1.Focus()
            Return
        End If

        MessageBox.Show("Thank you! Cash amount recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Hide() ' Hide the ClosingShiftContent form

        ' ✅ Show the existing CashManagementControll inside the parent form
        If MainForm IsNot Nothing Then
            MainForm.cashmanagementcontroll.ResetShift() ' reset controls for new shift
            MainForm.ShowControl(MainForm.cashmanagementcontroll)
            MainForm.Panel4.Show()
        End If

    End Sub

End Class
