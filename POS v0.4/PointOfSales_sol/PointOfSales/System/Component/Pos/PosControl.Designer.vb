<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PosControl
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
        Me.SiticoneDashboardCard = New SiticoneNetFrameworkUI.SiticoneDashboardCard()
        Me.cb_cate1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_dandt = New System.Windows.Forms.Label()
        Me.lbl_tickets = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_vat = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SiticoneActivityButton6 = New SiticoneNetFrameworkUI.SiticoneActivityButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SiticoneActivityButton3 = New SiticoneNetFrameworkUI.SiticoneActivityButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.SiticoneActivityButton2 = New SiticoneNetFrameworkUI.SiticoneActivityButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SiticoneActivityButton1 = New SiticoneNetFrameworkUI.SiticoneActivityButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SiticoneLabel2 = New SiticoneNetFrameworkUI.SiticoneLabel()
        Me.SiticoneLabel1 = New SiticoneNetFrameworkUI.SiticoneLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SiticoneButtonTextbox1 = New SiticoneNetFrameworkUI.SiticoneButtonTextbox()
        Me.SiticoneDashboardCard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiticoneDashboardCard
        '
        Me.SiticoneDashboardCard.BackColor = System.Drawing.Color.Black
        Me.SiticoneDashboardCard.BackgroundEndColor = System.Drawing.Color.White
        Me.SiticoneDashboardCard.BackgroundStartColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneDashboardCard.BorderColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard.BorderEndColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard.BorderStartColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard.Controls.Add(Me.SiticoneButtonTextbox1)
        Me.SiticoneDashboardCard.Controls.Add(Me.cb_cate1)
        Me.SiticoneDashboardCard.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticoneDashboardCard.Location = New System.Drawing.Point(0, 0)
        Me.SiticoneDashboardCard.Name = "SiticoneDashboardCard"
        Me.SiticoneDashboardCard.Size = New System.Drawing.Size(758, 54)
        Me.SiticoneDashboardCard.TabIndex = 7
        '
        'cb_cate1
        '
        Me.cb_cate1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cate1.FormattingEnabled = True
        Me.cb_cate1.Location = New System.Drawing.Point(12, 11)
        Me.cb_cate1.Name = "cb_cate1"
        Me.cb_cate1.Size = New System.Drawing.Size(149, 28)
        Me.cb_cate1.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_dandt)
        Me.Panel1.Controls.Add(Me.lbl_tickets)
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.lbl_subtotal)
        Me.Panel1.Controls.Add(Me.lbl_vat)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(533, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 527)
        Me.Panel1.TabIndex = 0
        '
        'lbl_dandt
        '
        Me.lbl_dandt.AutoSize = True
        Me.lbl_dandt.Location = New System.Drawing.Point(26, 121)
        Me.lbl_dandt.Name = "lbl_dandt"
        Me.lbl_dandt.Size = New System.Drawing.Size(14, 13)
        Me.lbl_dandt.TabIndex = 12
        Me.lbl_dandt.Text = "#"
        '
        'lbl_tickets
        '
        Me.lbl_tickets.AutoSize = True
        Me.lbl_tickets.Location = New System.Drawing.Point(156, 121)
        Me.lbl_tickets.Name = "lbl_tickets"
        Me.lbl_tickets.Size = New System.Drawing.Size(14, 13)
        Me.lbl_tickets.TabIndex = 11
        Me.lbl_tickets.Text = "#"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(166, 421)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(10, 13)
        Me.lbl_total.TabIndex = 10
        Me.lbl_total.Text = "."
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Location = New System.Drawing.Point(166, 390)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(10, 13)
        Me.lbl_subtotal.TabIndex = 9
        Me.lbl_subtotal.Text = "."
        '
        'lbl_vat
        '
        Me.lbl_vat.AutoSize = True
        Me.lbl_vat.Location = New System.Drawing.Point(166, 359)
        Me.lbl_vat.Name = "lbl_vat"
        Me.lbl_vat.Size = New System.Drawing.Size(10, 13)
        Me.lbl_vat.TabIndex = 8
        Me.lbl_vat.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Subtotal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "VAT"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(160, 145)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(54, 186)
        Me.ListBox2.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 145)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 186)
        Me.ListBox1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 437)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(222, 90)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel5.Controls.Add(Me.SiticoneActivityButton6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(222, 45)
        Me.Panel5.TabIndex = 4
        '
        'SiticoneActivityButton6
        '
        Me.SiticoneActivityButton6.ActivityDuration = 2000
        Me.SiticoneActivityButton6.ActivityIndicatorColor = System.Drawing.Color.White
        Me.SiticoneActivityButton6.ActivityIndicatorSize = 4
        Me.SiticoneActivityButton6.ActivityIndicatorSpeed = 100
        Me.SiticoneActivityButton6.ActivityText = "Processing..."
        Me.SiticoneActivityButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneActivityButton6.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad
        Me.SiticoneActivityButton6.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneActivityButton6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SiticoneActivityButton6.BorderWidth = 2
        Me.SiticoneActivityButton6.CornerRadiusBottomLeft = 5
        Me.SiticoneActivityButton6.CornerRadiusBottomRight = 5
        Me.SiticoneActivityButton6.CornerRadiusTopLeft = 5
        Me.SiticoneActivityButton6.CornerRadiusTopRight = 5
        Me.SiticoneActivityButton6.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.SiticoneActivityButton6.Elevation = 2.0!
        Me.SiticoneActivityButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneActivityButton6.HoverAnimationDuration = 200
        Me.SiticoneActivityButton6.HoverColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SiticoneActivityButton6.Location = New System.Drawing.Point(4, 3)
        Me.SiticoneActivityButton6.Name = "SiticoneActivityButton6"
        Me.SiticoneActivityButton6.PressAnimationDuration = 150
        Me.SiticoneActivityButton6.PressedColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SiticoneActivityButton6.PressedElevation = 1.0!
        Me.SiticoneActivityButton6.RippleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneActivityButton6.RippleDuration = 1800
        Me.SiticoneActivityButton6.RippleSize = 5
        Me.SiticoneActivityButton6.ShowActivityText = True
        Me.SiticoneActivityButton6.Size = New System.Drawing.Size(215, 39)
        Me.SiticoneActivityButton6.TabIndex = 14
        Me.SiticoneActivityButton6.Text = "Split Ticket"
        Me.SiticoneActivityButton6.TextColor = System.Drawing.Color.White
        Me.SiticoneActivityButton6.UseAnimation = True
        Me.SiticoneActivityButton6.UseElevation = False
        Me.SiticoneActivityButton6.UseRippleEffect = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(222, 45)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.SiticoneActivityButton3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(151, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(68, 39)
        Me.Panel8.TabIndex = 2
        '
        'SiticoneActivityButton3
        '
        Me.SiticoneActivityButton3.ActivityDuration = 2000
        Me.SiticoneActivityButton3.ActivityIndicatorColor = System.Drawing.Color.White
        Me.SiticoneActivityButton3.ActivityIndicatorSize = 4
        Me.SiticoneActivityButton3.ActivityIndicatorSpeed = 100
        Me.SiticoneActivityButton3.ActivityText = "Processing..."
        Me.SiticoneActivityButton3.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad
        Me.SiticoneActivityButton3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneActivityButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SiticoneActivityButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SiticoneActivityButton3.BorderWidth = 2
        Me.SiticoneActivityButton3.CornerRadiusBottomLeft = 5
        Me.SiticoneActivityButton3.CornerRadiusBottomRight = 5
        Me.SiticoneActivityButton3.CornerRadiusTopLeft = 5
        Me.SiticoneActivityButton3.CornerRadiusTopRight = 5
        Me.SiticoneActivityButton3.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.SiticoneActivityButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneActivityButton3.Elevation = 2.0!
        Me.SiticoneActivityButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneActivityButton3.HoverAnimationDuration = 200
        Me.SiticoneActivityButton3.HoverColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SiticoneActivityButton3.Location = New System.Drawing.Point(0, 0)
        Me.SiticoneActivityButton3.Name = "SiticoneActivityButton3"
        Me.SiticoneActivityButton3.PressAnimationDuration = 150
        Me.SiticoneActivityButton3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SiticoneActivityButton3.PressedElevation = 1.0!
        Me.SiticoneActivityButton3.RippleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneActivityButton3.RippleDuration = 1800
        Me.SiticoneActivityButton3.RippleSize = 5
        Me.SiticoneActivityButton3.ShowActivityText = True
        Me.SiticoneActivityButton3.Size = New System.Drawing.Size(68, 39)
        Me.SiticoneActivityButton3.TabIndex = 9
        Me.SiticoneActivityButton3.Text = "Clear"
        Me.SiticoneActivityButton3.TextColor = System.Drawing.Color.White
        Me.SiticoneActivityButton3.Theme = SiticoneNetFrameworkUI.SiticoneActivityButton.ActivityButtonTheme.MaterialRed
        Me.SiticoneActivityButton3.UseAnimation = True
        Me.SiticoneActivityButton3.UseElevation = False
        Me.SiticoneActivityButton3.UseRippleEffect = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.SiticoneActivityButton2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(77, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(68, 39)
        Me.Panel7.TabIndex = 1
        '
        'SiticoneActivityButton2
        '
        Me.SiticoneActivityButton2.ActivityDuration = 2000
        Me.SiticoneActivityButton2.ActivityIndicatorColor = System.Drawing.Color.White
        Me.SiticoneActivityButton2.ActivityIndicatorSize = 4
        Me.SiticoneActivityButton2.ActivityIndicatorSpeed = 100
        Me.SiticoneActivityButton2.ActivityText = "Processing..."
        Me.SiticoneActivityButton2.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad
        Me.SiticoneActivityButton2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneActivityButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SiticoneActivityButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SiticoneActivityButton2.BorderWidth = 2
        Me.SiticoneActivityButton2.CornerRadiusBottomLeft = 5
        Me.SiticoneActivityButton2.CornerRadiusBottomRight = 5
        Me.SiticoneActivityButton2.CornerRadiusTopLeft = 5
        Me.SiticoneActivityButton2.CornerRadiusTopRight = 5
        Me.SiticoneActivityButton2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.SiticoneActivityButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneActivityButton2.Elevation = 2.0!
        Me.SiticoneActivityButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneActivityButton2.HoverAnimationDuration = 200
        Me.SiticoneActivityButton2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SiticoneActivityButton2.Location = New System.Drawing.Point(0, 0)
        Me.SiticoneActivityButton2.Name = "SiticoneActivityButton2"
        Me.SiticoneActivityButton2.PressAnimationDuration = 150
        Me.SiticoneActivityButton2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.SiticoneActivityButton2.PressedElevation = 1.0!
        Me.SiticoneActivityButton2.RippleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneActivityButton2.RippleDuration = 1800
        Me.SiticoneActivityButton2.RippleSize = 5
        Me.SiticoneActivityButton2.ShowActivityText = True
        Me.SiticoneActivityButton2.Size = New System.Drawing.Size(68, 39)
        Me.SiticoneActivityButton2.TabIndex = 9
        Me.SiticoneActivityButton2.Text = "Remove "
        Me.SiticoneActivityButton2.TextColor = System.Drawing.Color.White
        Me.SiticoneActivityButton2.Theme = SiticoneNetFrameworkUI.SiticoneActivityButton.ActivityButtonTheme.MaterialRed
        Me.SiticoneActivityButton2.UseAnimation = True
        Me.SiticoneActivityButton2.UseElevation = False
        Me.SiticoneActivityButton2.UseRippleEffect = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.SiticoneActivityButton1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(68, 39)
        Me.Panel6.TabIndex = 0
        '
        'SiticoneActivityButton1
        '
        Me.SiticoneActivityButton1.ActivityDuration = 2000
        Me.SiticoneActivityButton1.ActivityIndicatorColor = System.Drawing.Color.White
        Me.SiticoneActivityButton1.ActivityIndicatorSize = 4
        Me.SiticoneActivityButton1.ActivityIndicatorSpeed = 100
        Me.SiticoneActivityButton1.ActivityText = "Processing..."
        Me.SiticoneActivityButton1.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad
        Me.SiticoneActivityButton1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneActivityButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SiticoneActivityButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SiticoneActivityButton1.BorderWidth = 2
        Me.SiticoneActivityButton1.CornerRadiusBottomLeft = 5
        Me.SiticoneActivityButton1.CornerRadiusBottomRight = 5
        Me.SiticoneActivityButton1.CornerRadiusTopLeft = 5
        Me.SiticoneActivityButton1.CornerRadiusTopRight = 5
        Me.SiticoneActivityButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.SiticoneActivityButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneActivityButton1.Elevation = 2.0!
        Me.SiticoneActivityButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneActivityButton1.HoverAnimationDuration = 200
        Me.SiticoneActivityButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.SiticoneActivityButton1.Location = New System.Drawing.Point(0, 0)
        Me.SiticoneActivityButton1.Name = "SiticoneActivityButton1"
        Me.SiticoneActivityButton1.PressAnimationDuration = 150
        Me.SiticoneActivityButton1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SiticoneActivityButton1.PressedElevation = 1.0!
        Me.SiticoneActivityButton1.RippleColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneActivityButton1.RippleDuration = 1800
        Me.SiticoneActivityButton1.RippleSize = 5
        Me.SiticoneActivityButton1.ShowActivityText = True
        Me.SiticoneActivityButton1.Size = New System.Drawing.Size(68, 39)
        Me.SiticoneActivityButton1.TabIndex = 9
        Me.SiticoneActivityButton1.Text = "Charge"
        Me.SiticoneActivityButton1.TextColor = System.Drawing.Color.White
        Me.SiticoneActivityButton1.Theme = SiticoneNetFrameworkUI.SiticoneActivityButton.ActivityButtonTheme.MaterialGreen
        Me.SiticoneActivityButton1.UseAnimation = True
        Me.SiticoneActivityButton1.UseElevation = False
        Me.SiticoneActivityButton1.UseRippleEffect = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.SiticoneLabel2)
        Me.Panel2.Controls.Add(Me.SiticoneLabel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 118)
        Me.Panel2.TabIndex = 0
        '
        'SiticoneLabel2
        '
        Me.SiticoneLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneLabel2.ForeColor = System.Drawing.Color.Black
        Me.SiticoneLabel2.Location = New System.Drawing.Point(12, 89)
        Me.SiticoneLabel2.Name = "SiticoneLabel2"
        Me.SiticoneLabel2.Size = New System.Drawing.Size(202, 32)
        Me.SiticoneLabel2.TabIndex = 2
        Me.SiticoneLabel2.Text = "Doña Manuela Subdivision, 10 Rosal, " & Global.Microsoft.VisualBasic.ChrW(10) & "Las Piñas, 1740 Metro Manila" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SiticoneLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneLabel1.ForeColor = System.Drawing.Color.Black
        Me.SiticoneLabel1.Location = New System.Drawing.Point(9, 65)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(202, 23)
        Me.SiticoneLabel1.TabIndex = 1
        Me.SiticoneLabel1.Text = "Frosties 'N Cream"
        Me.SiticoneLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 62)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PointOfSales.My.Resources.Resources.POS_terminal
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 54)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 533.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 533.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 533)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(524, 524)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'SiticoneButtonTextbox1
        '
        Me.SiticoneButtonTextbox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneButtonTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButtonTextbox1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SiticoneButtonTextbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButtonTextbox1.BottomLeftCornerRadius = 20
        Me.SiticoneButtonTextbox1.BottomRightCornerRadius = 20
        Me.SiticoneButtonTextbox1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.SiticoneButtonTextbox1.ButtonCornerRadius = 15
        Me.SiticoneButtonTextbox1.ButtonHoverColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.SiticoneButtonTextbox1.ButtonImageHover = Nothing
        Me.SiticoneButtonTextbox1.ButtonImageIdle = Nothing
        Me.SiticoneButtonTextbox1.ButtonImagePress = Nothing
        Me.SiticoneButtonTextbox1.ButtonPlaceholderColor = System.Drawing.Color.Black
        Me.SiticoneButtonTextbox1.ButtonPlaceholderFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButtonTextbox1.ButtonPressColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SiticoneButtonTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneButtonTextbox1.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButtonTextbox1.FocusImage = Nothing
        Me.SiticoneButtonTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SiticoneButtonTextbox1.HoverBorderColor = System.Drawing.Color.Gray
        Me.SiticoneButtonTextbox1.HoverImage = Nothing
        Me.SiticoneButtonTextbox1.IdleImage = Nothing
        Me.SiticoneButtonTextbox1.Location = New System.Drawing.Point(533, 10)
        Me.SiticoneButtonTextbox1.Name = "SiticoneButtonTextbox1"
        Me.SiticoneButtonTextbox1.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.SiticoneButtonTextbox1.PlaceholderFocusColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.SiticoneButtonTextbox1.PlaceholderFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButtonTextbox1.PlaceholderText = "Search..."
        Me.SiticoneButtonTextbox1.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.ButtonPlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneButtonTextbox1.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SiticoneButtonTextbox1.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SiticoneButtonTextbox1.RippleColor = System.Drawing.Color.White
        Me.SiticoneButtonTextbox1.Size = New System.Drawing.Size(214, 38)
        Me.SiticoneButtonTextbox1.TabIndex = 19
        Me.SiticoneButtonTextbox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SiticoneButtonTextbox1.TextContent = ""
        Me.SiticoneButtonTextbox1.TextLeftMargin = 0
        Me.SiticoneButtonTextbox1.TopLeftCornerRadius = 20
        Me.SiticoneButtonTextbox1.TopRightCornerRadius = 20
        Me.SiticoneButtonTextbox1.ValidationEnabled = False
        '
        'PosControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.SiticoneDashboardCard)
        Me.Name = "PosControl"
        Me.Size = New System.Drawing.Size(758, 587)
        Me.SiticoneDashboardCard.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneDashboardCard1 As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SiticoneLabel1 As SiticoneNetFrameworkUI.SiticoneLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SiticoneActivityButton6 As SiticoneNetFrameworkUI.SiticoneActivityButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents SiticoneActivityButton3 As SiticoneNetFrameworkUI.SiticoneActivityButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents SiticoneActivityButton2 As SiticoneNetFrameworkUI.SiticoneActivityButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SiticoneActivityButton1 As SiticoneNetFrameworkUI.SiticoneActivityButton
    Friend WithEvents SiticoneLabel2 As SiticoneNetFrameworkUI.SiticoneLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_vat As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_tickets As Label
    Friend WithEvents cb_cate1 As ComboBox
    Friend WithEvents lbl_dandt As Label
    Friend WithEvents SiticoneDashboardCard As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents SiticoneButtonTextbox1 As SiticoneNetFrameworkUI.SiticoneButtonTextbox
End Class
