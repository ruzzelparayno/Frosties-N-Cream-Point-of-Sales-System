Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Runtime.InteropServices

Public Class RefundForm

    ' Optional labels/controls you already have on the form:
    ' lbl_getticket, lbl_getproducts, lbl_getprice, lbl_getsubtotal, lbl_getvat, lbl_gettotal, lbl_MOP

    Private Sub RefundForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: format the labels if necessary
        ' e.g., lbl_gettotal.Text = "₱0.00" if empty
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' --- Confirm refund action ---
        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure you want to refund this transaction?",
        "Confirm Refund",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )
        If confirm <> DialogResult.Yes Then Return

        ' --- Parse refund amount safely ---
        Dim refundAmount As Decimal = 0D
        If Not Decimal.TryParse(lbl_gettotal.Text.Replace("₱", "").Replace(",", "").Trim(), refundAmount) Then
            MessageBox.Show("Invalid total amount. Refund cannot be processed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim subtotal As Decimal = 0D
        Decimal.TryParse(lbl_getsubtotal.Text.Replace("₱", "").Replace(",", "").Trim(), subtotal)

        Dim grossSaleAmount As Decimal = 0D
        Decimal.TryParse(lbl_getprice.Text.Replace("₱", "").Replace(",", "").Trim(), grossSaleAmount)
        If grossSaleAmount = 0D Then grossSaleAmount = subtotal

        Dim discountAmount As Decimal = Math.Max(0D, grossSaleAmount - subtotal)

        ' --- Update database ---
        Dim connStr As String = "server=localhost;userid=root;password=;database=pos"
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim updateQuery As String = "UPDATE sales SET Status='Refunded' WHERE TicketNumber=@TicketNumber AND TRIM(ProductName)=@ProductName"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@TicketNumber", lbl_getticket.Text.Trim())
                    cmd.Parameters.AddWithValue("@ProductName", lbl_getproducts.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating refund status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' --- Update CashManagementControll ---
        Dim shiftForm As ShiftContent = Dashboard.shiftInstance
        If shiftForm Is Nothing Then
            MessageBox.Show("Shift form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cashForm As CashManagementControll = shiftForm.Panel2.Controls.OfType(Of CashManagementControll)().FirstOrDefault()
        If cashForm Is Nothing Then
            MessageBox.Show("Cash management control not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --- Update shift totals (discounts and gross sales) ---
        cashForm.UpdateShiftSales(refundValue:=refundAmount,
                              discountValue:=-discountAmount,
                              grossSaleValue:=-grossSaleAmount)

        ' --- Update refund labels ---
        ' Current refund for this item
        cashForm.lbl_refund1.Text = "₱" & refundAmount.ToString("N0")

        ' Accumulate total refunds for shift
        Dim totalRefunds As Decimal = 0D
        Decimal.TryParse(cashForm.lbl_srefunds.Text.Replace("₱", "").Replace(",", "").Trim(), totalRefunds)
        totalRefunds += refundAmount
        cashForm.lbl_srefunds.Text = "₱" & totalRefunds.ToString("N0")

        ' --- Recompute totals to update Extra Cash and Net Cash correctly ---
        cashForm.ComputeTotal()

        ' --- Finish ---
        MessageBox.Show("Refund processed successfully!", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    ' ----------------- REPRINT REFUND RECEIPT -----------------
    Private Sub SiticoneButton3_Click(sender As Object, e As EventArgs) Handles SiticoneButton3.Click
        Dim receipt As New StringBuilder()
        Dim maxChars As Integer = 32
        Dim line As String = New String("=", maxChars)

        ' --- Header ---
        receipt.AppendLine("Frosties N' Cream".PadLeft((maxChars + "Frosties N' Cream".Length) \ 2))
        receipt.AppendLine("10 Rosal St. Doña Manuela Subd.".PadLeft((maxChars + "10 Rosal St. Doña Manuela Subd.".Length) \ 2))
        receipt.AppendLine("Pamplona 3,  1740 Las Piñas.".PadLeft((maxChars + "Pamplona 3,  1740 Las Piñas.".Length) \ 2))
        receipt.AppendLine("Contact: 0917 557 5485".PadLeft((maxChars + "Contact: 0917 557 5485".Length) \ 2))
        receipt.AppendLine(line)

        ' --- Refund receipt title ---
        receipt.AppendLine("REFUND RECEIPT".PadLeft((maxChars + "REFUND RECEIPT".Length) \ 2))
        receipt.AppendLine(line)
        receipt.AppendLine("Ticket #: " & lbl_getticket.Text)
        receipt.AppendLine("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        receipt.AppendLine(line)

        ' --- Column headers ---
        Dim qtyWidth As Integer = 6
        Dim productWidth As Integer = 16
        Dim priceWidth As Integer = maxChars - qtyWidth - productWidth
        Dim headerText As String = "QTY".PadRight(qtyWidth) & "PRODUCT".PadRight(productWidth) & "PRICE".PadRight(priceWidth)
        Dim headerPadding As Integer = (maxChars - headerText.Length) \ 2
        receipt.AppendLine(New String(" "c, headerPadding) & headerText)
        receipt.AppendLine(line)

        ' --- Product line(s) ---
        Dim qtyValue As String = "1" ' change if multiple qty
        Dim productValue As String = lbl_getproducts.Text
        Dim priceValue As Decimal = 0D
        Decimal.TryParse(lbl_getprice.Text.Replace("₱", "").Replace(",", "").Trim(), priceValue)

        Dim qtyText As String = qtyValue.PadRight(qtyWidth)
        Dim productText As String = productValue.PadRight(productWidth)
        Dim priceText As String = priceValue.ToString("N2").PadLeft(priceWidth)

        receipt.AppendLine(New String(" "c, headerPadding) & qtyText & productText & priceText)
        receipt.AppendLine(line)

        ' Subtotal, VAT, Total
        Dim subtotal As Decimal = 0D
        Decimal.TryParse(lbl_getsubtotal.Text.Replace("₱", "").Replace(",", "").Trim(), subtotal)

        Dim vatAmount As Decimal = 0D
        Decimal.TryParse(lbl_getvat.Text.Replace("₱", "").Replace(",", "").Trim(), vatAmount)

        Dim totalAmount As Decimal = 0D
        Decimal.TryParse(lbl_gettotal.Text.Replace("₱", "").Replace(",", "").Trim(), totalAmount)

        receipt.AppendLine("Subtotal:".PadRight(20) & subtotal.ToString("N2").PadLeft(12))
        receipt.AppendLine("VAT (12%):".PadRight(20) & vatAmount.ToString("N2").PadLeft(12))
        receipt.AppendLine("Total:".PadRight(20) & totalAmount.ToString("N2").PadLeft(12))

        ' --- Mode of Payment ---
        receipt.AppendLine("Mode of Payment: " & lbl_MOP.Text)
        receipt.AppendLine(line)

        ' --- Footer ---
        receipt.AppendLine("VAT REG. TIN: 123-456-789-000")
        receipt.AppendLine("BIR Permit No.: 1234-5678-9012-3456")
        receipt.AppendLine("Date Issued: 2024-01-01")
        receipt.AppendLine("Valid Until: 2025-12-31")
        receipt.AppendLine(line)
        receipt.AppendLine("Thank you for your purchase!".PadLeft((maxChars + "Thank you for your purchase!".Length) \ 2))
        receipt.AppendLine()
        receipt.AppendLine()
        receipt.AppendLine()
        receipt.Append(Chr(&H1D) & "V" & Chr(0)) ' ESC/POS cut

        ' --- Send to printer ---
        SendStringToPrinter("POS-58-Series", receipt.ToString())
    End Sub



    ' ----------------- ESC/POS raw printing function -----------------
    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function OpenPrinter(ByVal szPrinter As String, ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Integer, ByRef di As DOCINFOA) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Integer, ByRef dwWritten As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Private Structure DOCINFOA
        <MarshalAs(UnmanagedType.LPStr)>
        Public pDocName As String
        <MarshalAs(UnmanagedType.LPStr)>
        Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPStr)>
        Public pDataType As String
    End Structure

    Private Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String) As Boolean
        Dim pBytes As IntPtr
        Dim bytes() As Byte = Encoding.GetEncoding(437).GetBytes(szString)
        pBytes = Marshal.AllocCoTaskMem(bytes.Length)
        Marshal.Copy(bytes, 0, pBytes, bytes.Length)

        Dim hPrinter As IntPtr
        Dim di As DOCINFOA = New DOCINFOA()
        di.pDocName = "Receipt"
        di.pDataType = "RAW"

        If OpenPrinter(szPrinterName, hPrinter, IntPtr.Zero) Then
            If StartDocPrinter(hPrinter, 1, di) Then
                If StartPagePrinter(hPrinter) Then
                    Dim dwWritten As Integer = 0
                    WritePrinter(hPrinter, pBytes, bytes.Length, dwWritten)
                    EndPagePrinter(hPrinter)
                End If
                EndDocPrinter(hPrinter)
            End If
            ClosePrinter(hPrinter)
        End If
        Marshal.FreeCoTaskMem(pBytes)
        Return True
    End Function
End Class
