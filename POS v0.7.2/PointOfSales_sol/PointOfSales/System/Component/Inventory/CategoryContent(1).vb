Imports MySql.Data.MySqlClient
Imports SiticoneNetFrameworkUI

Public Class CategoryContent
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=pos")
    Dim connectionString As String = "server=localhost;userid=root;password=;database=pos"
    Private Sub CategoryContent_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If Me.Parent IsNot Nothing AndAlso Me.Parent.FindForm().WindowState = FormWindowState.Maximized Then
                ' When maximized  
                SiticoneTextBox1.Font = New Font(SiticoneTextBox1.Font.FontFamily, 16, SiticoneTextBox1.Font.Style)
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, 16, TextBox1.Font.Style)
            Else
                ' When restored  
                SiticoneTextBox1.Font = New Font(SiticoneTextBox1.Font.FontFamily, 12, SiticoneTextBox1.Font.Style)
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, 12, TextBox1.Font.Style)

            End If

        Catch ex As Exception
            Debug.WriteLine("Resize error in ProductContent: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If SiticoneTextBox1.Text.Trim() = "" Or TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.",
                        "Missing Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO categories (CategoryName, Description) VALUES (@categoryName, @description)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@categoryName", SiticoneTextBox1.Text.Trim())
            cmd.Parameters.AddWithValue("@description", TextBox1.Text.Trim())
            cmd.ExecuteNonQuery()

            MessageBox.Show("✅ Category saved successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            ' ✅ Find ProductContent among open forms/controls
            Dim productContentInstance As ProductContent = Nothing
            For Each f As Form In Application.OpenForms
                For Each ctrl As Control In f.Controls
                    If TypeOf ctrl Is ProductContent Then
                        productContentInstance = DirectCast(ctrl, ProductContent)
                        Exit For
                    End If
                Next
            Next

            ' ✅ Refresh ComboBox in ProductContent if found
            If productContentInstance IsNot Nothing Then
                productContentInstance.LoadCategories1()
            End If

            ' ✅ Clear input fields
            SiticoneTextBox1.Clear()
            TextBox1.Clear()

        Catch ex As Exception
            MessageBox.Show("❌ Error saving category: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
