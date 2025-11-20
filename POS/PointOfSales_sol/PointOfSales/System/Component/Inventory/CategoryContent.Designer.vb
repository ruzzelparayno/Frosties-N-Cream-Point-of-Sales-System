<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryContent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnSave = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SiticoneTextBox1 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SiticonePanel2 = New SiticoneNetFrameworkUI.SiticonePanel()
        Me.SiticoneButton3 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel22.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SiticonePanel2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.MintCream
        Me.Panel22.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(758, 208)
        Me.Panel22.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 208)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MintCream
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.BtnSave)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(382, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 202)
        Me.Panel6.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TextBox1.Location = New System.Drawing.Point(25, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(298, 99)
        Me.TextBox1.TabIndex = 3
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
        Me.BtnSave.Location = New System.Drawing.Point(234, 157)
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
        Me.BtnSave.ShadowColor = System.Drawing.Color.Transparent
        Me.BtnSave.ShadowOffset = New System.Drawing.Point(2, 2)
        Me.BtnSave.ShakeDuration = 500
        Me.BtnSave.ShakeIntensity = 5
        Me.BtnSave.Size = New System.Drawing.Size(100, 35)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.TextColor = System.Drawing.Color.White
        Me.BtnSave.TooltipText = Nothing
        Me.BtnSave.UseAdvancedRendering = True
        Me.BtnSave.UseParticles = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Description"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.SiticoneTextBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(373, 202)
        Me.Panel5.TabIndex = 1
        '
        'SiticoneTextBox1
        '
        Me.SiticoneTextBox1.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox1.AccessibleName = "Text Box"
        Me.SiticoneTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SiticoneTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneTextBox1.BlinkCount = 3
        Me.SiticoneTextBox1.BlinkShadow = False
        Me.SiticoneTextBox1.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox1.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox1.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.CanShake = True
        Me.SiticoneTextBox1.ContinuousBlink = False
        Me.SiticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox1.CursorBlinkRate = 500
        Me.SiticoneTextBox1.CursorColor = System.Drawing.Color.Black
        Me.SiticoneTextBox1.CursorHeight = 26
        Me.SiticoneTextBox1.CursorOffset = 0
        Me.SiticoneTextBox1.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.SiticoneTextBox1.CursorWidth = 1
        Me.SiticoneTextBox1.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox1.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.SiticoneTextBox1.DisabledTextColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.EnableDropShadow = False
        Me.SiticoneTextBox1.FillColor1 = System.Drawing.Color.White
        Me.SiticoneTextBox1.FillColor2 = System.Drawing.Color.White
        Me.SiticoneTextBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox1.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.IsEnabled = True
        Me.SiticoneTextBox1.Location = New System.Drawing.Point(26, 44)
        Me.SiticoneTextBox1.Name = "SiticoneTextBox1"
        Me.SiticoneTextBox1.PlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.PlaceholderText = "Enter text here..."
        Me.SiticoneTextBox1.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox1.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox1.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox1.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox1.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.SiticoneTextBox1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.ShadowAnimationDuration = 1
        Me.SiticoneTextBox1.ShadowBlur = 10
        Me.SiticoneTextBox1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneTextBox1.Size = New System.Drawing.Size(232, 29)
        Me.SiticoneTextBox1.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox1.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox1.TabIndex = 11
        Me.SiticoneTextBox1.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox1.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox1.ValidationFunction = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Category Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Guna2DataGridView1)
        Me.Panel3.Controls.Add(Me.SiticonePanel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.Panel3.Size = New System.Drawing.Size(758, 328)
        Me.Panel3.TabIndex = 5
        '
        'SiticonePanel2
        '
        Me.SiticonePanel2.AcrylicTintColor = System.Drawing.Color.Transparent
        Me.SiticonePanel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticonePanel2.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center
        Me.SiticonePanel2.BorderDashPattern = Nothing
        Me.SiticonePanel2.BorderGradientEndColor = System.Drawing.Color.Transparent
        Me.SiticonePanel2.BorderGradientStartColor = System.Drawing.Color.Transparent
        Me.SiticonePanel2.BorderThickness = 2.0!
        Me.SiticonePanel2.Controls.Add(Me.SiticoneButton3)
        Me.SiticonePanel2.CornerRadiusBottomLeft = 16.0!
        Me.SiticonePanel2.CornerRadiusBottomRight = 16.0!
        Me.SiticonePanel2.CornerRadiusTopLeft = 16.0!
        Me.SiticonePanel2.CornerRadiusTopRight = 16.0!
        Me.SiticonePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel2.EnableAcrylicEffect = False
        Me.SiticonePanel2.EnableMicaEffect = False
        Me.SiticonePanel2.EnableRippleEffect = False
        Me.SiticonePanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticonePanel2.GradientColors = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.LightGray, System.Drawing.Color.Gray}
        Me.SiticonePanel2.GradientPositions = New Single() {0!, 0.5!, 1.0!}
        Me.SiticonePanel2.Location = New System.Drawing.Point(10, 0)
        Me.SiticonePanel2.Name = "SiticonePanel2"
        Me.SiticonePanel2.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid
        Me.SiticonePanel2.RippleAlpha = 50
        Me.SiticonePanel2.RippleAlphaDecrement = 3
        Me.SiticonePanel2.RippleColor = System.Drawing.Color.Transparent
        Me.SiticonePanel2.RippleMaxSize = 600.0!
        Me.SiticonePanel2.RippleSpeed = 15.0!
        Me.SiticonePanel2.ShowBorder = False
        Me.SiticonePanel2.Size = New System.Drawing.Size(738, 54)
        Me.SiticonePanel2.TabIndex = 11
        Me.SiticonePanel2.TabStop = True
        Me.SiticonePanel2.TrackSystemTheme = False
        Me.SiticonePanel2.UseBorderGradient = False
        Me.SiticonePanel2.UseMultiGradient = False
        Me.SiticonePanel2.UsePatternTexture = False
        Me.SiticonePanel2.UseRadialGradient = False
        '
        'SiticoneButton3
        '
        Me.SiticoneButton3.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton3.AccessibleName = "Update"
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
        Me.SiticoneButton3.Location = New System.Drawing.Point(606, 9)
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
        Me.SiticoneButton3.Size = New System.Drawing.Size(100, 35)
        Me.SiticoneButton3.TabIndex = 17
        Me.SiticoneButton3.Text = "Update"
        Me.SiticoneButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton3.TextColor = System.Drawing.Color.White
        Me.SiticoneButton3.TooltipText = Nothing
        Me.SiticoneButton3.UseAdvancedRendering = True
        Me.SiticoneButton3.UseParticles = False
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(16, 60)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(731, 257)
        Me.Guna2DataGridView1.TabIndex = 12
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'CategoryContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel22)
        Me.Name = "CategoryContent"
        Me.Size = New System.Drawing.Size(758, 536)
        Me.Panel22.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.SiticonePanel2.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel22 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnSave As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SiticoneTextBox1 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SiticoneDashboardCard1 As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SiticonePanel2 As SiticonePanel
    Friend WithEvents SiticoneButton3 As SiticoneButton
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
