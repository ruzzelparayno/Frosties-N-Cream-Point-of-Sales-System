<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_getproductname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_minus = New System.Windows.Forms.Label()
        Me.btn_editsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-10, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 49)
        Me.Label1.TabIndex = 0
        '
        'lbl_getproductname
        '
        Me.lbl_getproductname.AutoSize = True
        Me.lbl_getproductname.Location = New System.Drawing.Point(47, 60)
        Me.lbl_getproductname.Name = "lbl_getproductname"
        Me.lbl_getproductname.Size = New System.Drawing.Size(10, 13)
        Me.lbl_getproductname.TabIndex = 1
        Me.lbl_getproductname.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'lbl_add
        '
        Me.lbl_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_add.Location = New System.Drawing.Point(85, 208)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(44, 35)
        Me.lbl_add.TabIndex = 3
        Me.lbl_add.Text = "+"
        Me.lbl_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_quantity
        '
        Me.lbl_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_quantity.Location = New System.Drawing.Point(126, 208)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(148, 35)
        Me.lbl_quantity.TabIndex = 4
        Me.lbl_quantity.Text = "."
        Me.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_minus
        '
        Me.lbl_minus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_minus.Location = New System.Drawing.Point(267, 208)
        Me.lbl_minus.Name = "lbl_minus"
        Me.lbl_minus.Size = New System.Drawing.Size(44, 35)
        Me.lbl_minus.TabIndex = 5
        Me.lbl_minus.Text = "-"
        Me.lbl_minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_editsave
        '
        Me.btn_editsave.Location = New System.Drawing.Point(126, 323)
        Me.btn_editsave.Name = "btn_editsave"
        Me.btn_editsave.Size = New System.Drawing.Size(148, 48)
        Me.btn_editsave.TabIndex = 6
        Me.btn_editsave.Text = "Save"
        Me.btn_editsave.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 436)
        Me.Controls.Add(Me.btn_editsave)
        Me.Controls.Add(Me.lbl_minus)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_getproductname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "edit"
        Me.Text = "edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_getproductname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_add As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_minus As Label
    Friend WithEvents btn_editsave As Button
End Class
