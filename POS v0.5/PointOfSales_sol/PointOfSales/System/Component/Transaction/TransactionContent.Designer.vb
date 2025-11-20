<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionContent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SiticoneDashboardCard1 = New SiticoneNetFrameworkUI.SiticoneDashboardCard()
        Me.SiticoneButtonTextbox1 = New SiticoneNetFrameworkUI.SiticoneButtonTextbox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_transactions = New System.Windows.Forms.DataGridView()
        Me.SiticoneDashboardCard1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneDashboardCard1
        '
        Me.SiticoneDashboardCard1.BackColor = System.Drawing.Color.Black
        Me.SiticoneDashboardCard1.BackgroundEndColor = System.Drawing.Color.White
        Me.SiticoneDashboardCard1.BackgroundStartColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneDashboardCard1.BorderColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard1.BorderEndColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard1.BorderStartColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard1.Controls.Add(Me.SiticoneButtonTextbox1)
        Me.SiticoneDashboardCard1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticoneDashboardCard1.Location = New System.Drawing.Point(0, 0)
        Me.SiticoneDashboardCard1.Name = "SiticoneDashboardCard1"
        Me.SiticoneDashboardCard1.Size = New System.Drawing.Size(758, 54)
        Me.SiticoneDashboardCard1.TabIndex = 7
        '
        'SiticoneButtonTextbox1
        '
        Me.SiticoneButtonTextbox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneButtonTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButtonTextbox1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButtonTextbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SiticoneButtonTextbox1.BottomLeftCornerRadius = 8
        Me.SiticoneButtonTextbox1.BottomRightCornerRadius = 8
        Me.SiticoneButtonTextbox1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SiticoneButtonTextbox1.ButtonHoverColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.SiticoneButtonTextbox1.ButtonImageHover = Nothing
        Me.SiticoneButtonTextbox1.ButtonImageIdle = Nothing
        Me.SiticoneButtonTextbox1.ButtonImagePress = Nothing
        Me.SiticoneButtonTextbox1.ButtonPlaceholderColor = System.Drawing.Color.White
        Me.SiticoneButtonTextbox1.ButtonPlaceholderFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButtonTextbox1.ButtonPressColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SiticoneButtonTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneButtonTextbox1.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.SiticoneButtonTextbox1.FocusImage = Nothing
        Me.SiticoneButtonTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.SiticoneButtonTextbox1.HoverBorderColor = System.Drawing.Color.Gray
        Me.SiticoneButtonTextbox1.HoverImage = Nothing
        Me.SiticoneButtonTextbox1.IdleImage = Nothing
        Me.SiticoneButtonTextbox1.Location = New System.Drawing.Point(573, 5)
        Me.SiticoneButtonTextbox1.Name = "SiticoneButtonTextbox1"
        Me.SiticoneButtonTextbox1.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SiticoneButtonTextbox1.PlaceholderFocusColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.SiticoneButtonTextbox1.PlaceholderFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButtonTextbox1.PlaceholderText = "Search?"
        Me.SiticoneButtonTextbox1.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.ButtonPlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneButtonTextbox1.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SiticoneButtonTextbox1.RippleColor = System.Drawing.Color.White
        Me.SiticoneButtonTextbox1.Size = New System.Drawing.Size(161, 43)
        Me.SiticoneButtonTextbox1.TabIndex = 17
        Me.SiticoneButtonTextbox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.SiticoneButtonTextbox1.TextContent = ""
        Me.SiticoneButtonTextbox1.TextLeftMargin = 0
        Me.SiticoneButtonTextbox1.TopLeftCornerRadius = 8
        Me.SiticoneButtonTextbox1.TopRightCornerRadius = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dgv_transactions)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(758, 482)
        Me.Panel3.TabIndex = 8
        '
        'dgv_transactions
        '
        Me.dgv_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_transactions.Location = New System.Drawing.Point(3, 6)
        Me.dgv_transactions.Name = "dgv_transactions"
        Me.dgv_transactions.Size = New System.Drawing.Size(752, 473)
        Me.dgv_transactions.TabIndex = 0
        '
        'TransactionContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SiticoneDashboardCard1)
        Me.Name = "TransactionContent"
        Me.Size = New System.Drawing.Size(758, 536)
        Me.SiticoneDashboardCard1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_transactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneDashboardCard1 As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents SiticoneButtonTextbox1 As SiticoneNetFrameworkUI.SiticoneButtonTextbox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_transactions As DataGridView
End Class
