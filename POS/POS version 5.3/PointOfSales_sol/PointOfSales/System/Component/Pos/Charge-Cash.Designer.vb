<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charge_Cash
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txt_cashs = New System.Windows.Forms.TextBox()
        Me.lbl_cr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_totalP = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_cashs
        '
        Me.txt_cashs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cashs.Location = New System.Drawing.Point(7, 24)
        Me.txt_cashs.Name = "txt_cashs"
        Me.txt_cashs.Size = New System.Drawing.Size(285, 29)
        Me.txt_cashs.TabIndex = 11
        '
        'lbl_cr
        '
        Me.lbl_cr.AutoSize = True
        Me.lbl_cr.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lbl_cr.Location = New System.Drawing.Point(3, 0)
        Me.lbl_cr.Name = "lbl_cr"
        Me.lbl_cr.Size = New System.Drawing.Size(115, 21)
        Me.lbl_cr.TabIndex = 10
        Me.lbl_cr.Text = "Cash Received"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Total Paid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(147, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Change"
        '
        'lbl_totalP
        '
        Me.lbl_totalP.BackColor = System.Drawing.Color.White
        Me.lbl_totalP.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lbl_totalP.Location = New System.Drawing.Point(7, 80)
        Me.lbl_totalP.Name = "lbl_totalP"
        Me.lbl_totalP.Size = New System.Drawing.Size(138, 29)
        Me.lbl_totalP.TabIndex = 18
        Me.lbl_totalP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_change
        '
        Me.lbl_change.BackColor = System.Drawing.Color.White
        Me.lbl_change.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lbl_change.Location = New System.Drawing.Point(154, 80)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(138, 29)
        Me.lbl_change.TabIndex = 19
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Charge_Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_change)
        Me.Controls.Add(Me.lbl_totalP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cashs)
        Me.Controls.Add(Me.lbl_cr)
        Me.Name = "Charge_Cash"
        Me.Size = New System.Drawing.Size(295, 161)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cashs As TextBox
    Friend WithEvents lbl_cr As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_totalP As Label
    Friend WithEvents lbl_change As Label
End Class
