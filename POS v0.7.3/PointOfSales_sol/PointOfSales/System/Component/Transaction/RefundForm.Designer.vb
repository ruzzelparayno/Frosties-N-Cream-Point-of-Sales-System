<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefundForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.SiticoneButton3 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.SiticonePanel1 = New SiticoneNetFrameworkUI.SiticonePanel()
        Me.lbl_getsubtotal = New System.Windows.Forms.Label()
        Me.lbl_gettotal = New System.Windows.Forms.Label()
        Me.lbl_getvat = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_getprice = New System.Windows.Forms.Label()
        Me.lbl_getproducts = New System.Windows.Forms.Label()
        Me.lbl_MOP = New System.Windows.Forms.Label()
        Me.lbl_getticket = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiticonePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 57)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PointOfSales.My.Resources.Resources.Back_To
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Refund"
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.BtnSave.AccessibleName = "Refund"
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.AutoSizeBasedOnText = False
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BadgeBackColor = System.Drawing.Color.Black
        Me.BtnSave.BadgeFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.BadgeValue = 0
        Me.BtnSave.BadgeValueForeColor = System.Drawing.Color.White
        Me.BtnSave.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnSave.BorderWidth = 2
        Me.BtnSave.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnSave.ButtonImage = Nothing
        Me.BtnSave.ButtonTextLeftPadding = 0
        Me.BtnSave.CanBeep = True
        Me.BtnSave.CanGlow = False
        Me.BtnSave.CanShake = True
        Me.BtnSave.ContextMenuStripEx = Nothing
        Me.BtnSave.CornerRadiusBottomLeft = 5
        Me.BtnSave.CornerRadiusBottomRight = 5
        Me.BtnSave.CornerRadiusTopLeft = 5
        Me.BtnSave.CornerRadiusTopRight = 5
        Me.BtnSave.CustomCursor = System.Windows.Forms.Cursors.Default
        Me.BtnSave.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnSave.EnableLongPress = False
        Me.BtnSave.EnablePressAnimation = True
        Me.BtnSave.EnableRippleEffect = True
        Me.BtnSave.EnableShadow = False
        Me.BtnSave.EnableTextWrapping = False
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.GlowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.GlowIntensity = 100
        Me.BtnSave.GlowRadius = 20.0!
        Me.BtnSave.GradientBackground = False
        Me.BtnSave.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSave.HintText = Nothing
        Me.BtnSave.HoverBackColor = System.Drawing.Color.White
        Me.BtnSave.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.BtnSave.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnSave.HoverTransitionDuration = 250
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.ImagePadding = 5
        Me.BtnSave.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnSave.IsRadial = False
        Me.BtnSave.IsReadOnly = False
        Me.BtnSave.IsToggleButton = False
        Me.BtnSave.IsToggled = False
        Me.BtnSave.Location = New System.Drawing.Point(255, 489)
        Me.BtnSave.LongPressDurationMS = 1000
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.BtnSave.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnSave.ParticleCount = 15
        Me.BtnSave.PressAnimationScale = 0.97!
        Me.BtnSave.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnSave.PressedFontStyle = System.Drawing.FontStyle.Regular
        Me.BtnSave.PressTransitionDuration = 150
        Me.BtnSave.ReadOnlyTextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnSave.RippleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.RippleOpacity = 0.3!
        Me.BtnSave.RippleRadiusMultiplier = 0.6!
        Me.BtnSave.ShadowBlur = 5
        Me.BtnSave.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.ShadowOffset = New System.Drawing.Point(2, 2)
        Me.BtnSave.ShakeDuration = 500
        Me.BtnSave.ShakeIntensity = 5
        Me.BtnSave.Size = New System.Drawing.Size(175, 44)
        Me.BtnSave.TabIndex = 17
        Me.BtnSave.Text = "Refund"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.TextColor = System.Drawing.Color.White
        Me.BtnSave.TooltipText = Nothing
        Me.BtnSave.UseAdvancedRendering = True
        Me.BtnSave.UseParticles = False
        '
        'SiticoneButton3
        '
        Me.SiticoneButton3.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton3.AccessibleName = "Print"
        Me.SiticoneButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneButton3.AutoSizeBasedOnText = False
        Me.SiticoneButton3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton3.BadgeBackColor = System.Drawing.Color.Black
        Me.SiticoneButton3.BadgeFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButton3.BadgeValue = 0
        Me.SiticoneButton3.BadgeValueForeColor = System.Drawing.Color.White
        Me.SiticoneButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton3.BorderWidth = 2
        Me.SiticoneButton3.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton3.ButtonImage = Nothing
        Me.SiticoneButton3.ButtonTextLeftPadding = 0
        Me.SiticoneButton3.CanBeep = True
        Me.SiticoneButton3.CanGlow = False
        Me.SiticoneButton3.CanShake = True
        Me.SiticoneButton3.ContextMenuStripEx = Nothing
        Me.SiticoneButton3.CornerRadiusBottomLeft = 5
        Me.SiticoneButton3.CornerRadiusBottomRight = 5
        Me.SiticoneButton3.CornerRadiusTopLeft = 5
        Me.SiticoneButton3.CornerRadiusTopRight = 5
        Me.SiticoneButton3.CustomCursor = System.Windows.Forms.Cursors.Default
        Me.SiticoneButton3.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SiticoneButton3.EnableLongPress = False
        Me.SiticoneButton3.EnablePressAnimation = True
        Me.SiticoneButton3.EnableRippleEffect = True
        Me.SiticoneButton3.EnableShadow = False
        Me.SiticoneButton3.EnableTextWrapping = False
        Me.SiticoneButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton3.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton3.GlowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButton3.GlowIntensity = 100
        Me.SiticoneButton3.GlowRadius = 20.0!
        Me.SiticoneButton3.GradientBackground = False
        Me.SiticoneButton3.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SiticoneButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SiticoneButton3.HintText = Nothing
        Me.SiticoneButton3.HoverBackColor = System.Drawing.Color.White
        Me.SiticoneButton3.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton3.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton3.HoverTransitionDuration = 250
        Me.SiticoneButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SiticoneButton3.ImagePadding = 5
        Me.SiticoneButton3.ImageSize = New System.Drawing.Size(16, 16)
        Me.SiticoneButton3.IsRadial = False
        Me.SiticoneButton3.IsReadOnly = False
        Me.SiticoneButton3.IsToggleButton = False
        Me.SiticoneButton3.IsToggled = False
        Me.SiticoneButton3.Location = New System.Drawing.Point(52, 489)
        Me.SiticoneButton3.LongPressDurationMS = 1000
        Me.SiticoneButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.SiticoneButton3.Name = "SiticoneButton3"
        Me.SiticoneButton3.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton3.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButton3.ParticleCount = 15
        Me.SiticoneButton3.PressAnimationScale = 0.97!
        Me.SiticoneButton3.PressedBackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton3.PressedFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton3.PressTransitionDuration = 150
        Me.SiticoneButton3.ReadOnlyTextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SiticoneButton3.RippleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButton3.RippleOpacity = 0.3!
        Me.SiticoneButton3.RippleRadiusMultiplier = 0.6!
        Me.SiticoneButton3.ShadowBlur = 5
        Me.SiticoneButton3.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneButton3.ShadowOffset = New System.Drawing.Point(2, 2)
        Me.SiticoneButton3.ShakeDuration = 500
        Me.SiticoneButton3.ShakeIntensity = 5
        Me.SiticoneButton3.Size = New System.Drawing.Size(175, 44)
        Me.SiticoneButton3.TabIndex = 18
        Me.SiticoneButton3.Text = "Print"
        Me.SiticoneButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton3.TextColor = System.Drawing.Color.White
        Me.SiticoneButton3.TooltipText = Nothing
        Me.SiticoneButton3.UseAdvancedRendering = True
        Me.SiticoneButton3.UseParticles = False
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.AcrylicTintColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticonePanel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center
        Me.SiticonePanel1.BorderDashPattern = Nothing
        Me.SiticonePanel1.BorderGradientEndColor = System.Drawing.Color.Purple
        Me.SiticonePanel1.BorderGradientStartColor = System.Drawing.Color.Blue
        Me.SiticonePanel1.BorderThickness = 2.0!
        Me.SiticonePanel1.Controls.Add(Me.lbl_getsubtotal)
        Me.SiticonePanel1.Controls.Add(Me.lbl_gettotal)
        Me.SiticonePanel1.Controls.Add(Me.lbl_getvat)
        Me.SiticonePanel1.Controls.Add(Me.Label4)
        Me.SiticonePanel1.Controls.Add(Me.Label3)
        Me.SiticonePanel1.Controls.Add(Me.Label2)
        Me.SiticonePanel1.Controls.Add(Me.lbl_getprice)
        Me.SiticonePanel1.Controls.Add(Me.lbl_getproducts)
        Me.SiticonePanel1.Controls.Add(Me.lbl_MOP)
        Me.SiticonePanel1.Controls.Add(Me.lbl_getticket)
        Me.SiticonePanel1.CornerRadiusBottomLeft = 10.0!
        Me.SiticonePanel1.CornerRadiusBottomRight = 10.0!
        Me.SiticonePanel1.CornerRadiusTopLeft = 10.0!
        Me.SiticonePanel1.CornerRadiusTopRight = 10.0!
        Me.SiticonePanel1.EnableAcrylicEffect = False
        Me.SiticonePanel1.EnableMicaEffect = False
        Me.SiticonePanel1.EnableRippleEffect = False
        Me.SiticonePanel1.FillColor = System.Drawing.Color.White
        Me.SiticonePanel1.GradientColors = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.LightGray, System.Drawing.Color.Gray}
        Me.SiticonePanel1.GradientPositions = New Single() {0!, 0.5!, 1.0!}
        Me.SiticonePanel1.Location = New System.Drawing.Point(45, 91)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid
        Me.SiticonePanel1.RippleAlpha = 50
        Me.SiticonePanel1.RippleAlphaDecrement = 3
        Me.SiticonePanel1.RippleColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticonePanel1.RippleMaxSize = 600.0!
        Me.SiticonePanel1.RippleSpeed = 15.0!
        Me.SiticonePanel1.ShowBorder = True
        Me.SiticonePanel1.Size = New System.Drawing.Size(393, 363)
        Me.SiticonePanel1.TabIndex = 19
        Me.SiticonePanel1.TabStop = True
        Me.SiticonePanel1.TrackSystemTheme = False
        Me.SiticonePanel1.UseBorderGradient = False
        Me.SiticonePanel1.UseMultiGradient = False
        Me.SiticonePanel1.UsePatternTexture = False
        Me.SiticonePanel1.UseRadialGradient = False
        '
        'lbl_getsubtotal
        '
        Me.lbl_getsubtotal.AutoSize = True
        Me.lbl_getsubtotal.BackColor = System.Drawing.Color.White
        Me.lbl_getsubtotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_getsubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_getsubtotal.Location = New System.Drawing.Point(298, 283)
        Me.lbl_getsubtotal.Name = "lbl_getsubtotal"
        Me.lbl_getsubtotal.Size = New System.Drawing.Size(13, 21)
        Me.lbl_getsubtotal.TabIndex = 19
        Me.lbl_getsubtotal.Text = "."
        '
        'lbl_gettotal
        '
        Me.lbl_gettotal.AutoSize = True
        Me.lbl_gettotal.BackColor = System.Drawing.Color.White
        Me.lbl_gettotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gettotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_gettotal.Location = New System.Drawing.Point(298, 321)
        Me.lbl_gettotal.Name = "lbl_gettotal"
        Me.lbl_gettotal.Size = New System.Drawing.Size(13, 21)
        Me.lbl_gettotal.TabIndex = 18
        Me.lbl_gettotal.Text = "."
        '
        'lbl_getvat
        '
        Me.lbl_getvat.AutoSize = True
        Me.lbl_getvat.BackColor = System.Drawing.Color.White
        Me.lbl_getvat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_getvat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_getvat.Location = New System.Drawing.Point(298, 243)
        Me.lbl_getvat.Name = "lbl_getvat"
        Me.lbl_getvat.Size = New System.Drawing.Size(13, 21)
        Me.lbl_getvat.TabIndex = 17
        Me.lbl_getvat.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "VAT"
        '
        'lbl_getprice
        '
        Me.lbl_getprice.AutoSize = True
        Me.lbl_getprice.BackColor = System.Drawing.Color.White
        Me.lbl_getprice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_getprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_getprice.Location = New System.Drawing.Point(298, 109)
        Me.lbl_getprice.Name = "lbl_getprice"
        Me.lbl_getprice.Size = New System.Drawing.Size(13, 21)
        Me.lbl_getprice.TabIndex = 13
        Me.lbl_getprice.Text = "."
        '
        'lbl_getproducts
        '
        Me.lbl_getproducts.AutoSize = True
        Me.lbl_getproducts.BackColor = System.Drawing.Color.White
        Me.lbl_getproducts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_getproducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_getproducts.Location = New System.Drawing.Point(49, 109)
        Me.lbl_getproducts.Name = "lbl_getproducts"
        Me.lbl_getproducts.Size = New System.Drawing.Size(13, 21)
        Me.lbl_getproducts.TabIndex = 12
        Me.lbl_getproducts.Text = "."
        '
        'lbl_MOP
        '
        Me.lbl_MOP.AutoSize = True
        Me.lbl_MOP.BackColor = System.Drawing.Color.White
        Me.lbl_MOP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MOP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_MOP.Location = New System.Drawing.Point(187, 29)
        Me.lbl_MOP.Name = "lbl_MOP"
        Me.lbl_MOP.Size = New System.Drawing.Size(13, 21)
        Me.lbl_MOP.TabIndex = 11
        Me.lbl_MOP.Text = "."
        '
        'lbl_getticket
        '
        Me.lbl_getticket.AutoSize = True
        Me.lbl_getticket.BackColor = System.Drawing.Color.White
        Me.lbl_getticket.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_getticket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lbl_getticket.Location = New System.Drawing.Point(49, 42)
        Me.lbl_getticket.Name = "lbl_getticket"
        Me.lbl_getticket.Size = New System.Drawing.Size(13, 21)
        Me.lbl_getticket.TabIndex = 10
        Me.lbl_getticket.Text = "."
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'RefundForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 562)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.Controls.Add(Me.SiticoneButton3)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RefundForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RefundForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiticonePanel1.ResumeLayout(False)
        Me.SiticonePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents SiticoneButton3 As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents SiticonePanel1 As SiticonePanel
    Friend WithEvents lbl_getsubtotal As Label
    Friend WithEvents lbl_gettotal As Label
    Friend WithEvents lbl_getvat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_getprice As Label
    Friend WithEvents lbl_getproducts As Label
    Friend WithEvents lbl_MOP As Label
    Friend WithEvents lbl_getticket As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
