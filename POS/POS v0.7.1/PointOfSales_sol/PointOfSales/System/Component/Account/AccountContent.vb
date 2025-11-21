Imports System.Data
Imports iText.IO.Font.Constants
Imports iText.Kernel.Colors
Imports iText.Kernel.Font
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Borders
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports MySql.Data.MySqlClient


Public Class AccountContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Dim boldFont As PdfFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD)
    ' 🔹 Function to hash a string with SHA256
    Private Function HashText(input As String) As String
        Using sha As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub AccountContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cpass.PasswordChar = "•"c
        txt_pass.PasswordChar = "•"c
        txt_pass2.PasswordChar = "•"c
        txt_op.PasswordChar = "•"c
        txt_np.PasswordChar = "•"c
    End Sub

    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        Try
            conn.Open()

            Dim query = "SELECT username, password, email FROM users WHERE username=@uname"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uname", txt_uname.Text.Trim())

            Dim reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim dbUsername = reader("username").ToString()
                Dim dbPassword = reader("password").ToString()
                Dim dbEmail = reader("email").ToString()

                ' ✅ Display the email from the database in txt_mail1
                txt_mail1.Text = dbEmail

                Dim hashedInputPass = HashText(txt_pass2.Text.Trim())

                If txt_uname.Text = dbUsername AndAlso hashedInputPass = dbPassword AndAlso txt_mail.Text = dbEmail Then
                    txt_uname.Enabled = False
                    txt_pass2.Enabled = False
                    txt_mail.Enabled = False
                    txt_mail1.Enabled = False
                    txt_pass.Text = txt_pass2.Text
                    txt_pass.Enabled = False

                    MessageBox.Show("Account confirmed! Current password is verified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' ✅ Show all the password change controls
                    Panel9.Show()
                    Panel16.Show()
                    Panel18.Show()
                    lbl_op.Show()
                    txt_op.Show()
                    lbl_np.Show()
                    lbl_cp.Show()
                    txt_cpass.Show()
                    SiticoneButton1.Show()
                    txt_np.Show()
                Else
                    MessageBox.Show("Username, Password, or Email does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("User not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub



    Private Sub ResetAccountFields()
        txt_uname.Enabled = True
        txt_pass2.Enabled = True
        txt_mail.Enabled = True
        txt_mail1.Enabled = True
        txt_pass.Enabled = True

        txt_uname.Clear()
        txt_pass2.Clear()
        txt_mail.Clear()
        txt_mail1.Clear()
        txt_pass.Clear()
        txt_op.Clear()
        txt_np.Clear()
        txt_cpass.Clear()

        ' 🔹 FIXED — Hide everything again properly
        lbl_op.Hide()
        txt_op.Hide()
        lbl_np.Hide()
        lbl_cp.Hide()
        txt_np.Hide()
        txt_cpass.Hide()
        SiticoneButton1.Hide()
    End Sub

    Private Sub SiticoneButton1_Click(sender As Object, e As EventArgs)
        Try
            conn.Open()

            Dim checkQuery = "SELECT password FROM users WHERE username=@uname"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@uname", txt_uname.Text.Trim)

            Dim dbPassword = Convert.ToString(checkCmd.ExecuteScalar)
            Dim hashedOldPass = HashText(txt_op.Text.Trim)

            If hashedOldPass <> dbPassword Then
                MessageBox.Show("Old password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Exit Sub
            End If

            If txt_np.Text.Trim = "" OrElse txt_cpass.Text.Trim = "" Then
                MessageBox.Show("Please enter a new password and confirm it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            If txt_np.Text.Trim <> txt_cpass.Text.Trim Then
                MessageBox.Show("New password and confirm password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Exit Sub
            End If

            Dim updateQuery = "UPDATE users SET password=@newPass WHERE username=@uname"
            Dim updateCmd As New MySqlCommand(updateQuery, conn)
            updateCmd.Parameters.AddWithValue("@newPass", HashText(txt_np.Text.Trim)) ' 🔹 Hash new password
            updateCmd.Parameters.AddWithValue("@uname", txt_uname.Text.Trim)

            Dim rowsAffected = updateCmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetAccountFields()
            Else
                MessageBox.Show("Failed to update password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub
    Private Sub ExportToPDF(shiftID As Integer)
        Dim dt As DataTable = GetSalesData(shiftID)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No sales data for this shift.")
            Return
        End If

        ' Compute Sales
        Dim gross As Decimal, refunds As Decimal, net As Decimal
        ComputeSales(dt, gross, refunds, net)

        ' Save file
        Dim saveFile As New SaveFileDialog()
        saveFile.Filter = "PDF Files|*.pdf"
        saveFile.FileName = "SalesReport_Shift_" & shiftID & ".pdf"
        If saveFile.ShowDialog() <> DialogResult.OK Then Return

        Try
            ' Create PDF
            Dim writer As New PdfWriter(saveFile.FileName)
            Dim pdf As New PdfDocument(writer)
            Dim document As New Document(pdf)

            ' Title
            document.Add(New Paragraph("Sales Report - Shift " & shiftID).SetFont(boldFont).SetFontSize(18).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER))
            document.Add(New Paragraph(" "))

            ' Add Table
            Dim table As New Table(dt.Columns.Count)
            ' Add headers
            For Each col As DataColumn In dt.Columns
                table.AddHeaderCell(New Cell().Add(New Paragraph(col.ColumnName).SetFont(boldFont)).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
            Next
            ' Add rows
            For Each row As DataRow In dt.Rows
                For Each col As DataColumn In dt.Columns
                    table.AddCell(row(col.ColumnName).ToString())
                Next
            Next
            document.Add(table)

            ' Add computations
            document.Add(New Paragraph(" "))
            document.Add(New Paragraph("Gross Sales: ₱" & gross.ToString("N2")))
            document.Add(New Paragraph("Total Refunds: ₱" & refunds.ToString("N2")))
            document.Add(New Paragraph("Net Sales: ₱" & net.ToString("N2")))

            document.Close()
            MessageBox.Show("PDF Exported Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error exporting PDF: " & ex.Message)
        End Try
    End Sub


    Private Sub SiticoneButton2_Click(sender As Object, e As EventArgs) Handles SiticoneButton2.Click
        ' Get the running CashManagementControll instance
        Dim cashForm As CashManagementControll = Application.OpenForms().OfType(Of CashManagementControll)().FirstOrDefault()

        If cashForm IsNot Nothing Then
            Dim shiftID As Integer = cashForm.CurrentShiftID
            If shiftID = 0 Then
                MessageBox.Show("No shift is currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            ExportToPDF(shiftID)
        Else
            MessageBox.Show("Cash Management form is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function GetSalesData(shiftID As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim connStr As String = "server=localhost;userid=root;password=;database=pos;"
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "SELECT * FROM sales WHERE ShiftID = @ShiftID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ShiftID", shiftID)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching sales data: " & ex.Message)
        End Try
        Return dt
    End Function
    Private Sub ComputeSales(dt As DataTable, ByRef grossSales As Decimal, ByRef totalRefunds As Decimal, ByRef netSales As Decimal)
        grossSales = 0
        totalRefunds = 0
        netSales = 0

        For Each row As DataRow In dt.Rows
            grossSales += Convert.ToDecimal(row("TotalAmount"))
            totalRefunds += Convert.ToDecimal(row("RefundAmount"))
        Next

        netSales = grossSales - totalRefunds
    End Sub

End Class
