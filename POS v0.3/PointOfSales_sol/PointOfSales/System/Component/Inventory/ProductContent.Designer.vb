<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductContent
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cb_cate = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneTextBox2 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SiticoneButton2 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.pb_ci = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SiticoneTextBox1 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SiticoneTextBox3 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.SiticoneDashboardCard1 = New SiticoneNetFrameworkUI.SiticoneDashboardCard()
        Me.SiticoneButton3 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_inventory = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pb_ci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.SiticoneDashboardCard1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
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
        Me.Panel6.Controls.Add(Me.cb_cate)
        Me.Panel6.Controls.Add(Me.BtnSave)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.SiticoneTextBox2)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(457, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(298, 202)
        Me.Panel6.TabIndex = 2
        '
        'cb_cate
        '
        Me.cb_cate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cate.FormattingEnabled = True
        Me.cb_cate.Location = New System.Drawing.Point(26, 44)
        Me.cb_cate.Name = "cb_cate"
        Me.cb_cate.Size = New System.Drawing.Size(218, 29)
        Me.cb_cate.TabIndex = 16
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
        Me.BtnSave.BorderColor = System.Drawing.Color.Transparent
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
        Me.BtnSave.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.BtnSave.HoverTextColor = System.Drawing.Color.Black
        Me.BtnSave.HoverTransitionDuration = 250
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.ImagePadding = 5
        Me.BtnSave.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnSave.IsRadial = False
        Me.BtnSave.IsReadOnly = False
        Me.BtnSave.IsToggleButton = False
        Me.BtnSave.IsToggled = False
        Me.BtnSave.Location = New System.Drawing.Point(149, 158)
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
        Me.BtnSave.Size = New System.Drawing.Size(100, 35)
        Me.BtnSave.TabIndex = 15
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
        Me.Label2.Location = New System.Drawing.Point(21, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Stock Quantity"
        '
        'SiticoneTextBox2
        '
        Me.SiticoneTextBox2.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox2.AccessibleName = "Text Box"
        Me.SiticoneTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SiticoneTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneTextBox2.BlinkCount = 3
        Me.SiticoneTextBox2.BlinkShadow = False
        Me.SiticoneTextBox2.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox2.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox2.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox2.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox2.CanShake = True
        Me.SiticoneTextBox2.ContinuousBlink = False
        Me.SiticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox2.CursorBlinkRate = 500
        Me.SiticoneTextBox2.CursorColor = System.Drawing.Color.Black
        Me.SiticoneTextBox2.CursorHeight = 26
        Me.SiticoneTextBox2.CursorOffset = 0
        Me.SiticoneTextBox2.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.SiticoneTextBox2.CursorWidth = 1
        Me.SiticoneTextBox2.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox2.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.SiticoneTextBox2.DisabledTextColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox2.EnableDropShadow = False
        Me.SiticoneTextBox2.FillColor1 = System.Drawing.Color.White
        Me.SiticoneTextBox2.FillColor2 = System.Drawing.Color.White
        Me.SiticoneTextBox2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneTextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox2.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox2.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox2.IsEnabled = True
        Me.SiticoneTextBox2.Location = New System.Drawing.Point(25, 114)
        Me.SiticoneTextBox2.Name = "SiticoneTextBox2"
        Me.SiticoneTextBox2.PlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox2.PlaceholderText = "Enter text here..."
        Me.SiticoneTextBox2.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox2.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox2.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox2.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox2.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.SiticoneTextBox2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox2.ShadowAnimationDuration = 1
        Me.SiticoneTextBox2.ShadowBlur = 10
        Me.SiticoneTextBox2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneTextBox2.Size = New System.Drawing.Size(232, 29)
        Me.SiticoneTextBox2.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox2.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox2.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox2.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox2.TabIndex = 13
        Me.SiticoneTextBox2.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox2.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox2.ValidationFunction = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Category"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.SiticoneButton2)
        Me.Panel4.Controls.Add(Me.pb_ci)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(145, 202)
        Me.Panel4.TabIndex = 0
        '
        'SiticoneButton2
        '
        Me.SiticoneButton2.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton2.AccessibleName = "Choose Image"
        Me.SiticoneButton2.AutoSizeBasedOnText = False
        Me.SiticoneButton2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton2.BadgeBackColor = System.Drawing.Color.Black
        Me.SiticoneButton2.BadgeFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButton2.BadgeValue = 0
        Me.SiticoneButton2.BadgeValueForeColor = System.Drawing.Color.White
        Me.SiticoneButton2.BorderColor = System.Drawing.Color.Transparent
        Me.SiticoneButton2.BorderWidth = 2
        Me.SiticoneButton2.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton2.ButtonImage = Nothing
        Me.SiticoneButton2.ButtonTextLeftPadding = 0
        Me.SiticoneButton2.CanBeep = True
        Me.SiticoneButton2.CanGlow = False
        Me.SiticoneButton2.CanShake = True
        Me.SiticoneButton2.ContextMenuStripEx = Nothing
        Me.SiticoneButton2.CornerRadiusBottomLeft = 5
        Me.SiticoneButton2.CornerRadiusBottomRight = 5
        Me.SiticoneButton2.CornerRadiusTopLeft = 5
        Me.SiticoneButton2.CornerRadiusTopRight = 5
        Me.SiticoneButton2.CustomCursor = System.Windows.Forms.Cursors.Default
        Me.SiticoneButton2.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SiticoneButton2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SiticoneButton2.EnableLongPress = False
        Me.SiticoneButton2.EnablePressAnimation = True
        Me.SiticoneButton2.EnableRippleEffect = True
        Me.SiticoneButton2.EnableShadow = False
        Me.SiticoneButton2.EnableTextWrapping = False
        Me.SiticoneButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.SiticoneButton2.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton2.GlowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButton2.GlowIntensity = 100
        Me.SiticoneButton2.GlowRadius = 20.0!
        Me.SiticoneButton2.GradientBackground = False
        Me.SiticoneButton2.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SiticoneButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SiticoneButton2.HintText = Nothing
        Me.SiticoneButton2.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneButton2.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton2.HoverTextColor = System.Drawing.Color.Black
        Me.SiticoneButton2.HoverTransitionDuration = 250
        Me.SiticoneButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SiticoneButton2.ImagePadding = 5
        Me.SiticoneButton2.ImageSize = New System.Drawing.Size(16, 16)
        Me.SiticoneButton2.IsRadial = False
        Me.SiticoneButton2.IsReadOnly = False
        Me.SiticoneButton2.IsToggleButton = False
        Me.SiticoneButton2.IsToggled = False
        Me.SiticoneButton2.Location = New System.Drawing.Point(10, 157)
        Me.SiticoneButton2.LongPressDurationMS = 1000
        Me.SiticoneButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.SiticoneButton2.Name = "SiticoneButton2"
        Me.SiticoneButton2.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton2.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButton2.ParticleCount = 15
        Me.SiticoneButton2.PressAnimationScale = 0.97!
        Me.SiticoneButton2.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SiticoneButton2.PressedFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton2.PressTransitionDuration = 150
        Me.SiticoneButton2.ReadOnlyTextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SiticoneButton2.RippleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButton2.RippleOpacity = 0.3!
        Me.SiticoneButton2.RippleRadiusMultiplier = 0.6!
        Me.SiticoneButton2.ShadowBlur = 5
        Me.SiticoneButton2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneButton2.ShadowOffset = New System.Drawing.Point(2, 2)
        Me.SiticoneButton2.ShakeDuration = 500
        Me.SiticoneButton2.ShakeIntensity = 5
        Me.SiticoneButton2.Size = New System.Drawing.Size(125, 35)
        Me.SiticoneButton2.TabIndex = 7
        Me.SiticoneButton2.Text = "Choose Image"
        Me.SiticoneButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton2.TextColor = System.Drawing.Color.White
        Me.SiticoneButton2.TooltipText = Nothing
        Me.SiticoneButton2.UseAdvancedRendering = True
        Me.SiticoneButton2.UseParticles = False
        '
        'pb_ci
        '
        Me.pb_ci.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pb_ci.BackColor = System.Drawing.Color.Silver
        Me.pb_ci.Location = New System.Drawing.Point(11, 12)
        Me.pb_ci.Name = "pb_ci"
        Me.pb_ci.Size = New System.Drawing.Size(129, 131)
        Me.pb_ci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_ci.TabIndex = 6
        Me.pb_ci.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.SiticoneTextBox1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.SiticoneTextBox3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(154, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(297, 202)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Price"
        '
        'SiticoneTextBox3
        '
        Me.SiticoneTextBox3.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox3.AccessibleName = "Text Box"
        Me.SiticoneTextBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SiticoneTextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneTextBox3.BlinkCount = 3
        Me.SiticoneTextBox3.BlinkShadow = False
        Me.SiticoneTextBox3.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox3.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox3.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox3.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox3.CanShake = True
        Me.SiticoneTextBox3.ContinuousBlink = False
        Me.SiticoneTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox3.CursorBlinkRate = 500
        Me.SiticoneTextBox3.CursorColor = System.Drawing.Color.Black
        Me.SiticoneTextBox3.CursorHeight = 26
        Me.SiticoneTextBox3.CursorOffset = 0
        Me.SiticoneTextBox3.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.SiticoneTextBox3.CursorWidth = 1
        Me.SiticoneTextBox3.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox3.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.SiticoneTextBox3.DisabledTextColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox3.EnableDropShadow = False
        Me.SiticoneTextBox3.FillColor1 = System.Drawing.Color.White
        Me.SiticoneTextBox3.FillColor2 = System.Drawing.Color.White
        Me.SiticoneTextBox3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneTextBox3.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox3.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox3.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox3.IsEnabled = True
        Me.SiticoneTextBox3.Location = New System.Drawing.Point(26, 114)
        Me.SiticoneTextBox3.Name = "SiticoneTextBox3"
        Me.SiticoneTextBox3.PlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox3.PlaceholderText = "Enter text here..."
        Me.SiticoneTextBox3.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox3.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox3.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox3.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox3.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.SiticoneTextBox3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox3.ShadowAnimationDuration = 1
        Me.SiticoneTextBox3.ShadowBlur = 10
        Me.SiticoneTextBox3.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneTextBox3.Size = New System.Drawing.Size(232, 29)
        Me.SiticoneTextBox3.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox3.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox3.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox3.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox3.TabIndex = 13
        Me.SiticoneTextBox3.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox3.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox3.ValidationFunction = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Product Name"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.MintCream
        Me.Panel22.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(758, 208)
        Me.Panel22.TabIndex = 1
        '
        'SiticoneDashboardCard1
        '
        Me.SiticoneDashboardCard1.BackColor = System.Drawing.Color.Black
        Me.SiticoneDashboardCard1.BackgroundEndColor = System.Drawing.Color.White
        Me.SiticoneDashboardCard1.BackgroundStartColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneDashboardCard1.BorderColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard1.BorderEndColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard1.BorderStartColor = System.Drawing.Color.Silver
        Me.SiticoneDashboardCard1.Controls.Add(Me.SiticoneButton3)
        Me.SiticoneDashboardCard1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticoneDashboardCard1.Location = New System.Drawing.Point(0, 208)
        Me.SiticoneDashboardCard1.Name = "SiticoneDashboardCard1"
        Me.SiticoneDashboardCard1.Size = New System.Drawing.Size(758, 54)
        Me.SiticoneDashboardCard1.TabIndex = 2
        '
        'SiticoneButton3
        '
        Me.SiticoneButton3.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton3.AccessibleName = "Edit"
        Me.SiticoneButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneButton3.AutoSizeBasedOnText = False
        Me.SiticoneButton3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton3.BadgeBackColor = System.Drawing.Color.Black
        Me.SiticoneButton3.BadgeFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButton3.BadgeValue = 0
        Me.SiticoneButton3.BadgeValueForeColor = System.Drawing.Color.White
        Me.SiticoneButton3.BorderColor = System.Drawing.Color.Transparent
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
        Me.SiticoneButton3.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton3.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton3.HoverTextColor = System.Drawing.Color.Black
        Me.SiticoneButton3.HoverTransitionDuration = 250
        Me.SiticoneButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SiticoneButton3.ImagePadding = 5
        Me.SiticoneButton3.ImageSize = New System.Drawing.Size(16, 16)
        Me.SiticoneButton3.IsRadial = False
        Me.SiticoneButton3.IsReadOnly = False
        Me.SiticoneButton3.IsToggleButton = False
        Me.SiticoneButton3.IsToggled = False
        Me.SiticoneButton3.Location = New System.Drawing.Point(605, 9)
        Me.SiticoneButton3.LongPressDurationMS = 1000
        Me.SiticoneButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.SiticoneButton3.Name = "SiticoneButton3"
        Me.SiticoneButton3.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton3.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButton3.ParticleCount = 15
        Me.SiticoneButton3.PressAnimationScale = 0.97!
        Me.SiticoneButton3.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
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
        Me.SiticoneButton3.TabIndex = 16
        Me.SiticoneButton3.Text = "Edit"
        Me.SiticoneButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton3.TextColor = System.Drawing.Color.White
        Me.SiticoneButton3.TooltipText = Nothing
        Me.SiticoneButton3.UseAdvancedRendering = True
        Me.SiticoneButton3.UseParticles = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dgv_inventory)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 262)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(758, 274)
        Me.Panel3.TabIndex = 4
        '
        'dgv_inventory
        '
        Me.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_inventory.Location = New System.Drawing.Point(3, 13)
        Me.dgv_inventory.Name = "dgv_inventory"
        Me.dgv_inventory.Size = New System.Drawing.Size(752, 248)
        Me.dgv_inventory.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProductContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SiticoneDashboardCard1)
        Me.Controls.Add(Me.Panel22)
        Me.Name = "ProductContent"
        Me.Size = New System.Drawing.Size(758, 536)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.pb_ci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.SiticoneDashboardCard1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnSave As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents Label2 As Label
    Friend WithEvents SiticoneTextBox2 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SiticoneButton2 As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents pb_ci As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents SiticoneTextBox3 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneTextBox1 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents SiticoneDashboardCard1 As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents SiticoneButton3 As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_inventory As DataGridView
    Friend WithEvents cb_cate As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
