<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charge
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
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_gcash = New System.Windows.Forms.RadioButton()
        Me.lbl_cr = New System.Windows.Forms.Label()
        Me.lbl_ref = New System.Windows.Forms.Label()
        Me.txt_cashs = New System.Windows.Forms.TextBox()
        Me.txt_reference = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_totalpaid = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_employee = New System.Windows.Forms.CheckBox()
        Me.cb_pwd = New System.Windows.Forms.CheckBox()
        Me.cb_senior = New System.Windows.Forms.CheckBox()
        Me.btn_charge = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-17, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 49)
        Me.Label1.TabIndex = 1
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Location = New System.Drawing.Point(75, 59)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(49, 17)
        Me.rb_cash.TabIndex = 2
        Me.rb_cash.TabStop = True
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_gcash
        '
        Me.rb_gcash.AutoSize = True
        Me.rb_gcash.Location = New System.Drawing.Point(75, 82)
        Me.rb_gcash.Name = "rb_gcash"
        Me.rb_gcash.Size = New System.Drawing.Size(56, 17)
        Me.rb_gcash.TabIndex = 3
        Me.rb_gcash.TabStop = True
        Me.rb_gcash.Text = "Gcash"
        Me.rb_gcash.UseVisualStyleBackColor = True
        '
        'lbl_cr
        '
        Me.lbl_cr.AutoSize = True
        Me.lbl_cr.Location = New System.Drawing.Point(72, 159)
        Me.lbl_cr.Name = "lbl_cr"
        Me.lbl_cr.Size = New System.Drawing.Size(80, 13)
        Me.lbl_cr.TabIndex = 4
        Me.lbl_cr.Text = "Cash Received"
        '
        'lbl_ref
        '
        Me.lbl_ref.AutoSize = True
        Me.lbl_ref.Location = New System.Drawing.Point(72, 159)
        Me.lbl_ref.Name = "lbl_ref"
        Me.lbl_ref.Size = New System.Drawing.Size(57, 13)
        Me.lbl_ref.TabIndex = 5
        Me.lbl_ref.Text = "Reference"
        '
        'txt_cashs
        '
        Me.txt_cashs.Location = New System.Drawing.Point(75, 175)
        Me.txt_cashs.Name = "txt_cashs"
        Me.txt_cashs.Size = New System.Drawing.Size(166, 20)
        Me.txt_cashs.TabIndex = 6
        '
        'txt_reference
        '
        Me.txt_reference.Location = New System.Drawing.Point(75, 175)
        Me.txt_reference.Name = "txt_reference"
        Me.txt_reference.Size = New System.Drawing.Size(166, 20)
        Me.txt_reference.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Paid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Change"
        '
        'lbl_totalpaid
        '
        Me.lbl_totalpaid.AutoSize = True
        Me.lbl_totalpaid.Location = New System.Drawing.Point(91, 239)
        Me.lbl_totalpaid.Name = "lbl_totalpaid"
        Me.lbl_totalpaid.Size = New System.Drawing.Size(10, 13)
        Me.lbl_totalpaid.TabIndex = 10
        Me.lbl_totalpaid.Text = "."
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Location = New System.Drawing.Point(231, 239)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(10, 13)
        Me.lbl_change.TabIndex = 11
        Me.lbl_change.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Discount"
        '
        'cb_employee
        '
        Me.cb_employee.AutoSize = True
        Me.cb_employee.Location = New System.Drawing.Point(75, 314)
        Me.cb_employee.Name = "cb_employee"
        Me.cb_employee.Size = New System.Drawing.Size(72, 17)
        Me.cb_employee.TabIndex = 13
        Me.cb_employee.Text = "Employee"
        Me.cb_employee.UseVisualStyleBackColor = True
        '
        'cb_pwd
        '
        Me.cb_pwd.AutoSize = True
        Me.cb_pwd.Location = New System.Drawing.Point(75, 337)
        Me.cb_pwd.Name = "cb_pwd"
        Me.cb_pwd.Size = New System.Drawing.Size(163, 17)
        Me.cb_pwd.TabIndex = 14
        Me.cb_pwd.Text = "Person With Disability (PWD)"
        Me.cb_pwd.UseVisualStyleBackColor = True
        '
        'cb_senior
        '
        Me.cb_senior.AutoSize = True
        Me.cb_senior.Location = New System.Drawing.Point(75, 360)
        Me.cb_senior.Name = "cb_senior"
        Me.cb_senior.Size = New System.Drawing.Size(90, 17)
        Me.cb_senior.TabIndex = 15
        Me.cb_senior.Text = "Senior Citizen"
        Me.cb_senior.UseVisualStyleBackColor = True
        '
        'btn_charge
        '
        Me.btn_charge.Location = New System.Drawing.Point(106, 403)
        Me.btn_charge.Name = "btn_charge"
        Me.btn_charge.Size = New System.Drawing.Size(150, 42)
        Me.btn_charge.TabIndex = 16
        Me.btn_charge.Text = "Charge"
        Me.btn_charge.UseVisualStyleBackColor = True
        '
        'charge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 484)
        Me.Controls.Add(Me.btn_charge)
        Me.Controls.Add(Me.cb_senior)
        Me.Controls.Add(Me.cb_pwd)
        Me.Controls.Add(Me.cb_employee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_change)
        Me.Controls.Add(Me.lbl_totalpaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_reference)
        Me.Controls.Add(Me.txt_cashs)
        Me.Controls.Add(Me.lbl_ref)
        Me.Controls.Add(Me.lbl_cr)
        Me.Controls.Add(Me.rb_gcash)
        Me.Controls.Add(Me.rb_cash)
        Me.Controls.Add(Me.Label1)
        Me.Name = "charge"
        Me.Text = "charge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_gcash As RadioButton
    Friend WithEvents lbl_cr As Label
    Friend WithEvents lbl_ref As Label
    Friend WithEvents txt_cashs As TextBox
    Friend WithEvents txt_reference As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_totalpaid As Label
    Friend WithEvents lbl_change As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_employee As CheckBox
    Friend WithEvents cb_pwd As CheckBox
    Friend WithEvents cb_senior As CheckBox
    Friend WithEvents btn_charge As Button
End Class
