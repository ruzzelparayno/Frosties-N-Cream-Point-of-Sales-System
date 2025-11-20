<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Charge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lbl_totalpaid = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_employee = New System.Windows.Forms.CheckBox()
        Me.cb_pwd = New System.Windows.Forms.CheckBox()
        Me.cb_senior = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SiticoneImageButton1 = New SiticoneNetFrameworkUI.SiticoneImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneRadioButton1 = New SiticoneNetFrameworkUI.SiticoneRadioButton()
        Me.SiticoneRadioButton2 = New SiticoneNetFrameworkUI.SiticoneRadioButton()
        Me.SiticoneFlatPanel1 = New SiticoneNetFrameworkUI.SiticoneFlatPanel()
        Me.SiticoneButton1 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Panel1.SuspendLayout()
        Me.SiticoneFlatPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_totalpaid
        '
        Me.lbl_totalpaid.AutoSize = True
        Me.lbl_totalpaid.Location = New System.Drawing.Point(51, 75)
        Me.lbl_totalpaid.Name = "lbl_totalpaid"
        Me.lbl_totalpaid.Size = New System.Drawing.Size(10, 13)
        Me.lbl_totalpaid.TabIndex = 10
        Me.lbl_totalpaid.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Discount"
        '
        'cb_employee
        '
        Me.cb_employee.AutoSize = True
        Me.cb_employee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_employee.Location = New System.Drawing.Point(50, 354)
        Me.cb_employee.Name = "cb_employee"
        Me.cb_employee.Size = New System.Drawing.Size(101, 25)
        Me.cb_employee.TabIndex = 13
        Me.cb_employee.Text = "Employee"
        Me.cb_employee.UseVisualStyleBackColor = True
        '
        'cb_pwd
        '
        Me.cb_pwd.AutoSize = True
        Me.cb_pwd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pwd.Location = New System.Drawing.Point(50, 377)
        Me.cb_pwd.Name = "cb_pwd"
        Me.cb_pwd.Size = New System.Drawing.Size(235, 25)
        Me.cb_pwd.TabIndex = 14
        Me.cb_pwd.Text = "Person With Disability (PWD)"
        Me.cb_pwd.UseVisualStyleBackColor = True
        '
        'cb_senior
        '
        Me.cb_senior.AutoSize = True
        Me.cb_senior.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_senior.Location = New System.Drawing.Point(50, 400)
        Me.cb_senior.Name = "cb_senior"
        Me.cb_senior.Size = New System.Drawing.Size(129, 25)
        Me.cb_senior.TabIndex = 15
        Me.cb_senior.Text = "Senior Citizen"
        Me.cb_senior.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SiticoneImageButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 57)
        Me.Panel1.TabIndex = 17
        '
        'SiticoneImageButton1
        '
        Me.SiticoneImageButton1.AnimationSpeed = 0.15!
        Me.SiticoneImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneImageButton1.BackgroundFillColor = System.Drawing.Color.Transparent
        Me.SiticoneImageButton1.BadgeAnimationEnabled = True
        Me.SiticoneImageButton1.BadgeAnimationSpeed = 0.15!
        Me.SiticoneImageButton1.BadgeColor = System.Drawing.Color.Red
        Me.SiticoneImageButton1.BadgeFont = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneImageButton1.BadgePosition = SiticoneNetFrameworkUI.BadgePositionExt.TopRight
        Me.SiticoneImageButton1.BadgeTextColor = System.Drawing.Color.White
        Me.SiticoneImageButton1.BadgeValue = 0
        Me.SiticoneImageButton1.BorderColor = System.Drawing.Color.Transparent
        Me.SiticoneImageButton1.BorderThickness = 2
        Me.SiticoneImageButton1.CanBeep = True
        Me.SiticoneImageButton1.CanShake = True
        Me.SiticoneImageButton1.CornerRadiusBottomLeft = 16.0!
        Me.SiticoneImageButton1.CornerRadiusBottomRight = 16.0!
        Me.SiticoneImageButton1.CornerRadiusTopLeft = 16.0!
        Me.SiticoneImageButton1.CornerRadiusTopRight = 16.0!
        Me.SiticoneImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SiticoneImageButton1.ForeColor = System.Drawing.Color.Transparent
        Me.SiticoneImageButton1.ImageDown = Nothing
        Me.SiticoneImageButton1.ImageHover = Nothing
        Me.SiticoneImageButton1.ImageNormal = Global.PointOfSales.My.Resources.Resources.Back_To
        Me.SiticoneImageButton1.ImageSizing = SiticoneNetFrameworkUI.ImageSizingMode.Zoom
        Me.SiticoneImageButton1.IsReadOnly = False
        Me.SiticoneImageButton1.Location = New System.Drawing.Point(35, 11)
        Me.SiticoneImageButton1.MakeRadial = True
        Me.SiticoneImageButton1.Name = "SiticoneImageButton1"
        Me.SiticoneImageButton1.PlaceholderImage = Nothing
        Me.SiticoneImageButton1.RippleColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneImageButton1.RippleEnabled = True
        Me.SiticoneImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.SiticoneImageButton1.SpringEffectEnabled = True
        Me.SiticoneImageButton1.TabIndex = 12
        Me.SiticoneImageButton1.Text = "SiticoneImageButton1"
        Me.SiticoneImageButton1.TrackSystemTheme = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Charge"
        '
        'SiticoneRadioButton1
        '
        Me.SiticoneRadioButton1.AccessibleName = "Cash"
        Me.SiticoneRadioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.SiticoneRadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneRadioButton1.CanBeep = True
        Me.SiticoneRadioButton1.CanShake = True
        Me.SiticoneRadioButton1.Checked = False
        Me.SiticoneRadioButton1.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerBorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerBorderWidth = 1
        Me.SiticoneRadioButton1.ContainerBottomLeftRadius = 8
        Me.SiticoneRadioButton1.ContainerBottomRightRadius = 8
        Me.SiticoneRadioButton1.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerCheckedColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerHoverColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerPadding = 8
        Me.SiticoneRadioButton1.ContainerPressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton1.ContainerTopLeftRadius = 8
        Me.SiticoneRadioButton1.ContainerTopRightRadius = 8
        Me.SiticoneRadioButton1.EnableRipple = False
        Me.SiticoneRadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRadioButton1.HoverCursor = System.Windows.Forms.Cursors.Hand
        Me.SiticoneRadioButton1.IsContained = False
        Me.SiticoneRadioButton1.IsReadOnly = False
        Me.SiticoneRadioButton1.Location = New System.Drawing.Point(35, 71)
        Me.SiticoneRadioButton1.MinimumSize = New System.Drawing.Size(178, 26)
        Me.SiticoneRadioButton1.Name = "SiticoneRadioButton1"
        Me.SiticoneRadioButton1.RippleColor = System.Drawing.Color.Transparent
        Me.SiticoneRadioButton1.RippleDuration = 0.5!
        Me.SiticoneRadioButton1.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard
        Me.SiticoneRadioButton1.ShakeDuration = 0.5!
        Me.SiticoneRadioButton1.Size = New System.Drawing.Size(178, 26)
        Me.SiticoneRadioButton1.TabIndex = 18
        Me.SiticoneRadioButton1.Text = "Cash"
        Me.SiticoneRadioButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SiticoneRadioButton1.ToolTipText = ""
        Me.SiticoneRadioButton1.UncheckedColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        '
        'SiticoneRadioButton2
        '
        Me.SiticoneRadioButton2.AccessibleName = "Cash"
        Me.SiticoneRadioButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton
        Me.SiticoneRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneRadioButton2.CanBeep = True
        Me.SiticoneRadioButton2.CanShake = True
        Me.SiticoneRadioButton2.Checked = False
        Me.SiticoneRadioButton2.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerBorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerBorderWidth = 1
        Me.SiticoneRadioButton2.ContainerBottomLeftRadius = 8
        Me.SiticoneRadioButton2.ContainerBottomRightRadius = 8
        Me.SiticoneRadioButton2.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerCheckedColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerHoverColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerPadding = 8
        Me.SiticoneRadioButton2.ContainerPressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneRadioButton2.ContainerTopLeftRadius = 8
        Me.SiticoneRadioButton2.ContainerTopRightRadius = 8
        Me.SiticoneRadioButton2.EnableRipple = False
        Me.SiticoneRadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneRadioButton2.HoverCursor = System.Windows.Forms.Cursors.Hand
        Me.SiticoneRadioButton2.IsContained = False
        Me.SiticoneRadioButton2.IsReadOnly = False
        Me.SiticoneRadioButton2.Location = New System.Drawing.Point(35, 103)
        Me.SiticoneRadioButton2.MinimumSize = New System.Drawing.Size(178, 26)
        Me.SiticoneRadioButton2.Name = "SiticoneRadioButton2"
        Me.SiticoneRadioButton2.RippleColor = System.Drawing.Color.Transparent
        Me.SiticoneRadioButton2.RippleDuration = 0.5!
        Me.SiticoneRadioButton2.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard
        Me.SiticoneRadioButton2.ShakeDuration = 0.5!
        Me.SiticoneRadioButton2.Size = New System.Drawing.Size(178, 26)
        Me.SiticoneRadioButton2.TabIndex = 19
        Me.SiticoneRadioButton2.Text = "GCash"
        Me.SiticoneRadioButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SiticoneRadioButton2.ToolTipText = ""
        Me.SiticoneRadioButton2.UncheckedColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        '
        'SiticoneFlatPanel1
        '
        Me.SiticoneFlatPanel1.BackColor = System.Drawing.Color.DarkGray
        Me.SiticoneFlatPanel1.Controls.Add(Me.lbl_totalpaid)
        Me.SiticoneFlatPanel1.Location = New System.Drawing.Point(40, 135)
        Me.SiticoneFlatPanel1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.SiticoneFlatPanel1.Name = "SiticoneFlatPanel1"
        Me.SiticoneFlatPanel1.Size = New System.Drawing.Size(295, 190)
        Me.SiticoneFlatPanel1.TabIndex = 20
        '
        'SiticoneButton1
        '
        Me.SiticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton1.AccessibleName = "Charge"
        Me.SiticoneButton1.AutoSizeBasedOnText = False
        Me.SiticoneButton1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.BadgeBackColor = System.Drawing.Color.Black
        Me.SiticoneButton1.BadgeFont = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton1.BadgeValue = 0
        Me.SiticoneButton1.BadgeValueForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SiticoneButton1.BorderWidth = 2
        Me.SiticoneButton1.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SiticoneButton1.ButtonImage = Nothing
        Me.SiticoneButton1.ButtonTextLeftPadding = 0
        Me.SiticoneButton1.CanBeep = True
        Me.SiticoneButton1.CanGlow = False
        Me.SiticoneButton1.CanShake = True
        Me.SiticoneButton1.ContextMenuStripEx = Nothing
        Me.SiticoneButton1.CornerRadiusBottomLeft = 6
        Me.SiticoneButton1.CornerRadiusBottomRight = 6
        Me.SiticoneButton1.CornerRadiusTopLeft = 6
        Me.SiticoneButton1.CornerRadiusTopRight = 6
        Me.SiticoneButton1.CustomCursor = System.Windows.Forms.Cursors.Default
        Me.SiticoneButton1.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SiticoneButton1.EnableLongPress = False
        Me.SiticoneButton1.EnableRippleEffect = True
        Me.SiticoneButton1.EnableShadow = False
        Me.SiticoneButton1.EnableTextWrapping = False
        Me.SiticoneButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SiticoneButton1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneButton1.GlowIntensity = 100
        Me.SiticoneButton1.GlowRadius = 20.0!
        Me.SiticoneButton1.GradientBackground = False
        Me.SiticoneButton1.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SiticoneButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SiticoneButton1.HintText = Nothing
        Me.SiticoneButton1.HoverBackColor = System.Drawing.Color.White
        Me.SiticoneButton1.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton1.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SiticoneButton1.HoverTransitionDuration = 250
        Me.SiticoneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SiticoneButton1.ImagePadding = 5
        Me.SiticoneButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.SiticoneButton1.IsRadial = False
        Me.SiticoneButton1.IsReadOnly = False
        Me.SiticoneButton1.IsToggleButton = False
        Me.SiticoneButton1.IsToggled = False
        Me.SiticoneButton1.Location = New System.Drawing.Point(35, 429)
        Me.SiticoneButton1.LongPressDurationMS = 1000
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton1.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButton1.ParticleCount = 15
        Me.SiticoneButton1.PressAnimationScale = 0.97!
        Me.SiticoneButton1.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.SiticoneButton1.PressedFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton1.PressTransitionDuration = 150
        Me.SiticoneButton1.ReadOnlyTextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SiticoneButton1.RippleColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.RippleRadiusMultiplier = 0.6!
        Me.SiticoneButton1.ShadowBlur = 5
        Me.SiticoneButton1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneButton1.ShadowOffset = New System.Drawing.Point(0, 2)
        Me.SiticoneButton1.ShakeDuration = 500
        Me.SiticoneButton1.ShakeIntensity = 5
        Me.SiticoneButton1.Size = New System.Drawing.Size(315, 43)
        Me.SiticoneButton1.TabIndex = 21
        Me.SiticoneButton1.Text = "Charge"
        Me.SiticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton1.TextColor = System.Drawing.Color.White
        Me.SiticoneButton1.TooltipText = Nothing
        Me.SiticoneButton1.UseAdvancedRendering = True
        Me.SiticoneButton1.UseParticles = False
        '
        'Charge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 484)
        Me.Controls.Add(Me.SiticoneButton1)
        Me.Controls.Add(Me.SiticoneFlatPanel1)
        Me.Controls.Add(Me.SiticoneRadioButton2)
        Me.Controls.Add(Me.SiticoneRadioButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cb_senior)
        Me.Controls.Add(Me.cb_pwd)
        Me.Controls.Add(Me.cb_employee)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Charge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "charge"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SiticoneFlatPanel1.ResumeLayout(False)
        Me.SiticoneFlatPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_totalpaid As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_employee As CheckBox
    Friend WithEvents cb_pwd As CheckBox
    Friend WithEvents cb_senior As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SiticoneImageButton1 As SiticoneNetFrameworkUI.SiticoneImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneRadioButton1 As SiticoneNetFrameworkUI.SiticoneRadioButton
    Friend WithEvents SiticoneRadioButton2 As SiticoneNetFrameworkUI.SiticoneRadioButton
    Friend WithEvents SiticoneFlatPanel1 As SiticoneNetFrameworkUI.SiticoneFlatPanel
    Friend WithEvents SiticoneButton1 As SiticoneNetFrameworkUI.SiticoneButton
End Class
