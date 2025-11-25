<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SiticoneCloseButton1 = New SiticoneNetFrameworkUI.SiticoneCloseButton()
        Me.BtnSave = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdminPass = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.cb_sq = New System.Windows.Forms.ComboBox()
        Me.satextbox = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.TargetControl = Me.Panel6
        Me.Guna2DragControl2.UseTransparentDrag = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel6.Controls.Add(Me.SiticoneCloseButton1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(600, 45)
        Me.Panel6.TabIndex = 19
        '
        'SiticoneCloseButton1
        '
        Me.SiticoneCloseButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SiticoneCloseButton1.CountdownFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SiticoneCloseButton1.IconColor = System.Drawing.Color.White
        Me.SiticoneCloseButton1.Location = New System.Drawing.Point(556, -2)
        Me.SiticoneCloseButton1.Name = "SiticoneCloseButton1"
        Me.SiticoneCloseButton1.Size = New System.Drawing.Size(44, 44)
        Me.SiticoneCloseButton1.TabIndex = 1
        Me.SiticoneCloseButton1.Text = "SiticoneCloseButton1"
        Me.SiticoneCloseButton1.TooltipText = "Close button"
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.BtnSave.AccessibleName = "Save"
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
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.CustomCursor = System.Windows.Forms.Cursors.Hand
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
        Me.BtnSave.Location = New System.Drawing.Point(420, 340)
        Me.BtnSave.LongPressDurationMS = 1000
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.BtnSave.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnSave.ParticleCount = 15
        Me.BtnSave.PressAnimationScale = 0.97!
        Me.BtnSave.PressedBackColor = System.Drawing.Color.Transparent
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
        Me.BtnSave.Size = New System.Drawing.Size(100, 35)
        Me.BtnSave.TabIndex = 31
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.TextColor = System.Drawing.Color.White
        Me.BtnSave.TooltipText = Nothing
        Me.BtnSave.UseAdvancedRendering = True
        Me.BtnSave.UseParticles = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "New Password"
        '
        'txtPassword
        '
        Me.txtPassword.AccessibleDescription = "A customizable text input field."
        Me.txtPassword.AccessibleName = "Text Box"
        Me.txtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BlinkCount = 3
        Me.txtPassword.BlinkShadow = False
        Me.txtPassword.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.txtPassword.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.txtPassword.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.CanShake = True
        Me.txtPassword.ContinuousBlink = False
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.CursorBlinkRate = 500
        Me.txtPassword.CursorColor = System.Drawing.Color.Black
        Me.txtPassword.CursorHeight = 26
        Me.txtPassword.CursorOffset = 0
        Me.txtPassword.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.txtPassword.CursorWidth = 1
        Me.txtPassword.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.txtPassword.DisabledTextColor = System.Drawing.Color.Gray
        Me.txtPassword.EnableDropShadow = False
        Me.txtPassword.FillColor1 = System.Drawing.Color.White
        Me.txtPassword.FillColor2 = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.txtPassword.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.txtPassword.IsEnabled = True
        Me.txtPassword.Location = New System.Drawing.Point(40, 200)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtPassword.PlaceholderText = "Enter text here..."
        Me.txtPassword.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.txtPassword.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.txtPassword.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtPassword.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.ShadowAnimationDuration = 1
        Me.txtPassword.ShadowBlur = 10
        Me.txtPassword.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword.Size = New System.Drawing.Size(176, 29)
        Me.txtPassword.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.txtPassword.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.txtPassword.SolidFillColor = System.Drawing.Color.White
        Me.txtPassword.TabIndex = 29
        Me.txtPassword.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.txtPassword.ValidationErrorMessage = "Invalid input."
        Me.txtPassword.ValidationFunction = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleDescription = "A customizable text input field."
        Me.txtEmail.AccessibleName = "Text Box"
        Me.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BlinkCount = 3
        Me.txtEmail.BlinkShadow = False
        Me.txtEmail.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.txtEmail.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.txtEmail.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.CanShake = True
        Me.txtEmail.ContinuousBlink = False
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.CursorBlinkRate = 500
        Me.txtEmail.CursorColor = System.Drawing.Color.Black
        Me.txtEmail.CursorHeight = 26
        Me.txtEmail.CursorOffset = 0
        Me.txtEmail.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.txtEmail.CursorWidth = 1
        Me.txtEmail.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.txtEmail.DisabledTextColor = System.Drawing.Color.Gray
        Me.txtEmail.EnableDropShadow = False
        Me.txtEmail.FillColor1 = System.Drawing.Color.White
        Me.txtEmail.FillColor2 = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.DimGray
        Me.txtEmail.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.txtEmail.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.txtEmail.IsEnabled = True
        Me.txtEmail.Location = New System.Drawing.Point(40, 121)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtEmail.PlaceholderText = "Enter text here..."
        Me.txtEmail.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.txtEmail.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.txtEmail.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtEmail.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.ShadowAnimationDuration = 1
        Me.txtEmail.ShadowBlur = 10
        Me.txtEmail.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEmail.Size = New System.Drawing.Size(176, 29)
        Me.txtEmail.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.txtEmail.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.txtEmail.SolidFillColor = System.Drawing.Color.White
        Me.txtEmail.TabIndex = 27
        Me.txtEmail.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.txtEmail.ValidationErrorMessage = "Invalid input."
        Me.txtEmail.ValidationFunction = Nothing
        '
        'cbRole
        '
        Me.cbRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cbRole.Location = New System.Drawing.Point(344, 46)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(248, 29)
        Me.cbRole.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Role"
        '
        'txtUsername
        '
        Me.txtUsername.AccessibleDescription = "A customizable text input field."
        Me.txtUsername.AccessibleName = "Text Box"
        Me.txtUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BlinkCount = 3
        Me.txtUsername.BlinkShadow = False
        Me.txtUsername.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.txtUsername.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.txtUsername.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.CanShake = True
        Me.txtUsername.ContinuousBlink = False
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.CursorBlinkRate = 500
        Me.txtUsername.CursorColor = System.Drawing.Color.Black
        Me.txtUsername.CursorHeight = 26
        Me.txtUsername.CursorOffset = 0
        Me.txtUsername.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.txtUsername.CursorWidth = 1
        Me.txtUsername.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.txtUsername.DisabledTextColor = System.Drawing.Color.Gray
        Me.txtUsername.EnableDropShadow = False
        Me.txtUsername.FillColor1 = System.Drawing.Color.White
        Me.txtUsername.FillColor2 = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.txtUsername.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.txtUsername.IsEnabled = True
        Me.txtUsername.Location = New System.Drawing.Point(40, 46)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtUsername.PlaceholderText = "Enter text here..."
        Me.txtUsername.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.txtUsername.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.txtUsername.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtUsername.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.ShadowAnimationDuration = 1
        Me.txtUsername.ShadowBlur = 10
        Me.txtUsername.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtUsername.Size = New System.Drawing.Size(176, 29)
        Me.txtUsername.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.txtUsername.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.txtUsername.SolidFillColor = System.Drawing.Color.White
        Me.txtUsername.TabIndex = 23
        Me.txtUsername.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.txtUsername.ValidationErrorMessage = "Invalid input."
        Me.txtUsername.ValidationFunction = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Username"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cb_sq)
        Me.Panel4.Controls.Add(Me.satextbox)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtAdminPass)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtConfirmPass)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtPassword)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtEmail)
        Me.Panel4.Controls.Add(Me.cbRole)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtUsername)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(600, 405)
        Me.Panel4.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Admin Password"
        '
        'txtAdminPass
        '
        Me.txtAdminPass.AccessibleDescription = "A customizable text input field."
        Me.txtAdminPass.AccessibleName = "Text Box"
        Me.txtAdminPass.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtAdminPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdminPass.BackColor = System.Drawing.Color.Transparent
        Me.txtAdminPass.BlinkCount = 3
        Me.txtAdminPass.BlinkShadow = False
        Me.txtAdminPass.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.txtAdminPass.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.txtAdminPass.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPass.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPass.CanShake = True
        Me.txtAdminPass.ContinuousBlink = False
        Me.txtAdminPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminPass.CursorBlinkRate = 500
        Me.txtAdminPass.CursorColor = System.Drawing.Color.Black
        Me.txtAdminPass.CursorHeight = 26
        Me.txtAdminPass.CursorOffset = 0
        Me.txtAdminPass.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.txtAdminPass.CursorWidth = 1
        Me.txtAdminPass.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAdminPass.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.txtAdminPass.DisabledTextColor = System.Drawing.Color.Gray
        Me.txtAdminPass.EnableDropShadow = False
        Me.txtAdminPass.FillColor1 = System.Drawing.Color.White
        Me.txtAdminPass.FillColor2 = System.Drawing.Color.White
        Me.txtAdminPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtAdminPass.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.txtAdminPass.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.txtAdminPass.IsEnabled = True
        Me.txtAdminPass.Location = New System.Drawing.Point(40, 293)
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtAdminPass.PlaceholderText = "Enter text here..."
        Me.txtAdminPass.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.txtAdminPass.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.txtAdminPass.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.txtAdminPass.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.txtAdminPass.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtAdminPass.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPass.ShadowAnimationDuration = 1
        Me.txtAdminPass.ShadowBlur = 10
        Me.txtAdminPass.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAdminPass.Size = New System.Drawing.Size(176, 29)
        Me.txtAdminPass.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.txtAdminPass.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminPass.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.txtAdminPass.SolidFillColor = System.Drawing.Color.White
        Me.txtAdminPass.TabIndex = 34
        Me.txtAdminPass.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.txtAdminPass.ValidationErrorMessage = "Invalid input."
        Me.txtAdminPass.ValidationFunction = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Confirm Password"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.AccessibleDescription = "A customizable text input field."
        Me.txtConfirmPass.AccessibleName = "Text Box"
        Me.txtConfirmPass.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtConfirmPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPass.BlinkCount = 3
        Me.txtConfirmPass.BlinkShadow = False
        Me.txtConfirmPass.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.txtConfirmPass.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.txtConfirmPass.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.CanShake = True
        Me.txtConfirmPass.ContinuousBlink = False
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.CursorBlinkRate = 500
        Me.txtConfirmPass.CursorColor = System.Drawing.Color.Black
        Me.txtConfirmPass.CursorHeight = 26
        Me.txtConfirmPass.CursorOffset = 0
        Me.txtConfirmPass.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.txtConfirmPass.CursorWidth = 1
        Me.txtConfirmPass.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtConfirmPass.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.txtConfirmPass.DisabledTextColor = System.Drawing.Color.Gray
        Me.txtConfirmPass.EnableDropShadow = False
        Me.txtConfirmPass.FillColor1 = System.Drawing.Color.White
        Me.txtConfirmPass.FillColor2 = System.Drawing.Color.White
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.DimGray
        Me.txtConfirmPass.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.txtConfirmPass.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.txtConfirmPass.IsEnabled = True
        Me.txtConfirmPass.Location = New System.Drawing.Point(344, 121)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PlaceholderColor = System.Drawing.Color.Gray
        Me.txtConfirmPass.PlaceholderText = "Enter text here..."
        Me.txtConfirmPass.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.txtConfirmPass.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.txtConfirmPass.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.txtConfirmPass.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.txtConfirmPass.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtConfirmPass.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.ShadowAnimationDuration = 1
        Me.txtConfirmPass.ShadowBlur = 10
        Me.txtConfirmPass.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtConfirmPass.Size = New System.Drawing.Size(176, 29)
        Me.txtConfirmPass.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.txtConfirmPass.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.txtConfirmPass.SolidFillColor = System.Drawing.Color.White
        Me.txtConfirmPass.TabIndex = 32
        Me.txtConfirmPass.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.txtConfirmPass.ValidationErrorMessage = "Invalid input."
        Me.txtConfirmPass.ValidationFunction = Nothing
        '
        'cb_sq
        '
        Me.cb_sq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_sq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cb_sq.FormattingEnabled = True
        Me.cb_sq.Items.AddRange(New Object() {"What is your mother’s maiden name?", "What was the name of your first pet?", "What city were you born in?", "What was the name of your elementary school?", "What is your favorite food?", "What was the model of your first phone?", "Who is your childhood best friend?", "What is your father’s middle name?", "What was the name of your first teacher?", "What is the title of your favorite movie?"})
        Me.cb_sq.Location = New System.Drawing.Point(340, 200)
        Me.cb_sq.Name = "cb_sq"
        Me.cb_sq.Size = New System.Drawing.Size(180, 29)
        Me.cb_sq.TabIndex = 39
        '
        'satextbox
        '
        Me.satextbox.AccessibleDescription = "A customizable text input field."
        Me.satextbox.AccessibleName = "Text Box"
        Me.satextbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.satextbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.satextbox.BackColor = System.Drawing.Color.Transparent
        Me.satextbox.BlinkCount = 3
        Me.satextbox.BlinkShadow = False
        Me.satextbox.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.satextbox.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.satextbox.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.satextbox.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.satextbox.CanShake = True
        Me.satextbox.ContinuousBlink = False
        Me.satextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.satextbox.CursorBlinkRate = 500
        Me.satextbox.CursorColor = System.Drawing.Color.Black
        Me.satextbox.CursorHeight = 26
        Me.satextbox.CursorOffset = 0
        Me.satextbox.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.satextbox.CursorWidth = 1
        Me.satextbox.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.satextbox.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.satextbox.DisabledTextColor = System.Drawing.Color.Gray
        Me.satextbox.EnableDropShadow = False
        Me.satextbox.FillColor1 = System.Drawing.Color.White
        Me.satextbox.FillColor2 = System.Drawing.Color.White
        Me.satextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.satextbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.satextbox.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.satextbox.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.satextbox.IsEnabled = True
        Me.satextbox.Location = New System.Drawing.Point(338, 293)
        Me.satextbox.Name = "satextbox"
        Me.satextbox.PlaceholderColor = System.Drawing.Color.Gray
        Me.satextbox.PlaceholderText = "Enter text here..."
        Me.satextbox.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.satextbox.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.satextbox.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.satextbox.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.satextbox.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.satextbox.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.satextbox.ShadowAnimationDuration = 1
        Me.satextbox.ShadowBlur = 10
        Me.satextbox.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.satextbox.Size = New System.Drawing.Size(182, 33)
        Me.satextbox.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.satextbox.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.satextbox.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.satextbox.SolidFillColor = System.Drawing.Color.White
        Me.satextbox.TabIndex = 37
        Me.satextbox.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.satextbox.ValidationErrorMessage = "Invalid input."
        Me.satextbox.ValidationFunction = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(343, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Security Question"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(340, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 21)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Security Answer"
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditUser"
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnSave As SiticoneButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As SiticoneTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As SiticoneTextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As SiticoneTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SiticoneCloseButton1 As SiticoneCloseButton
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdminPass As SiticoneTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfirmPass As SiticoneTextBox
    Friend WithEvents cb_sq As ComboBox
    Friend WithEvents satextbox As SiticoneTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
