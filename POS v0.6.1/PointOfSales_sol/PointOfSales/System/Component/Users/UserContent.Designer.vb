<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserContent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cb_ur = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cb_sq = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SiticoneTextBox6 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiticoneTextBox5 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SiticoneTextBox7 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.SiticoneTextBox1 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SiticoneTextBox3 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneButton3 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SiticonePanel1 = New SiticoneNetFrameworkUI.SiticonePanel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel22.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SiticonePanel1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 51)
        Me.Panel1.TabIndex = 3
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.MintCream
        Me.Panel22.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 51)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(758, 212)
        Me.Panel22.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 212)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MintCream
        Me.Panel6.Controls.Add(Me.cb_ur)
        Me.Panel6.Controls.Add(Me.BtnSave)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(507, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(248, 206)
        Me.Panel6.TabIndex = 2
        '
        'cb_ur
        '
        Me.cb_ur.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_ur.FormattingEnabled = True
        Me.cb_ur.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cb_ur.Location = New System.Drawing.Point(26, 32)
        Me.cb_ur.Name = "cb_ur"
        Me.cb_ur.Size = New System.Drawing.Size(164, 29)
        Me.cb_ur.TabIndex = 17
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.BtnSave.AccessibleName = "Add Account"
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
        Me.BtnSave.Location = New System.Drawing.Point(104, 146)
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
        Me.BtnSave.Size = New System.Drawing.Size(115, 35)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "Add Account"
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
        Me.Label4.Location = New System.Drawing.Point(22, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "User Role"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.cb_sq)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.SiticoneTextBox6)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.SiticoneTextBox5)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(246, 206)
        Me.Panel4.TabIndex = 0
        '
        'cb_sq
        '
        Me.cb_sq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sq.FormattingEnabled = True
        Me.cb_sq.Items.AddRange(New Object() {"What is your mother’s maiden name?", "What was the name of your first pet?", "What city were you born in?", "What was the name of your elementary school?", "What is your favorite food?", "What was the model of your first phone?", "Who is your childhood best friend?", "What is your father’s middle name?", "What was the name of your first teacher?", "What is the title of your favorite movie?"})
        Me.cb_sq.Location = New System.Drawing.Point(22, 148)
        Me.cb_sq.Name = "cb_sq"
        Me.cb_sq.Size = New System.Drawing.Size(180, 29)
        Me.cb_sq.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Security Question"
        '
        'SiticoneTextBox6
        '
        Me.SiticoneTextBox6.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox6.AccessibleName = "Text Box"
        Me.SiticoneTextBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SiticoneTextBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox6.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneTextBox6.BlinkCount = 3
        Me.SiticoneTextBox6.BlinkShadow = False
        Me.SiticoneTextBox6.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox6.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox6.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox6.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox6.CanShake = True
        Me.SiticoneTextBox6.ContinuousBlink = False
        Me.SiticoneTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox6.CursorBlinkRate = 500
        Me.SiticoneTextBox6.CursorColor = System.Drawing.Color.Black
        Me.SiticoneTextBox6.CursorHeight = 26
        Me.SiticoneTextBox6.CursorOffset = 0
        Me.SiticoneTextBox6.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.SiticoneTextBox6.CursorWidth = 1
        Me.SiticoneTextBox6.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox6.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.SiticoneTextBox6.DisabledTextColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox6.EnableDropShadow = False
        Me.SiticoneTextBox6.FillColor1 = System.Drawing.Color.White
        Me.SiticoneTextBox6.FillColor2 = System.Drawing.Color.White
        Me.SiticoneTextBox6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneTextBox6.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox6.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox6.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox6.IsEnabled = True
        Me.SiticoneTextBox6.Location = New System.Drawing.Point(22, 90)
        Me.SiticoneTextBox6.Name = "SiticoneTextBox6"
        Me.SiticoneTextBox6.PlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox6.PlaceholderText = "Enter text here..."
        Me.SiticoneTextBox6.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox6.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox6.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox6.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox6.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.SiticoneTextBox6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox6.ShadowAnimationDuration = 1
        Me.SiticoneTextBox6.ShadowBlur = 10
        Me.SiticoneTextBox6.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneTextBox6.Size = New System.Drawing.Size(181, 33)
        Me.SiticoneTextBox6.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox6.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox6.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox6.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox6.TabIndex = 16
        Me.SiticoneTextBox6.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox6.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox6.ValidationFunction = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Password"
        '
        'SiticoneTextBox5
        '
        Me.SiticoneTextBox5.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox5.AccessibleName = "Text Box"
        Me.SiticoneTextBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SiticoneTextBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneTextBox5.BlinkCount = 3
        Me.SiticoneTextBox5.BlinkShadow = False
        Me.SiticoneTextBox5.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox5.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox5.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox5.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox5.CanShake = True
        Me.SiticoneTextBox5.ContinuousBlink = False
        Me.SiticoneTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox5.CursorBlinkRate = 500
        Me.SiticoneTextBox5.CursorColor = System.Drawing.Color.Black
        Me.SiticoneTextBox5.CursorHeight = 26
        Me.SiticoneTextBox5.CursorOffset = 0
        Me.SiticoneTextBox5.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.SiticoneTextBox5.CursorWidth = 1
        Me.SiticoneTextBox5.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox5.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.SiticoneTextBox5.DisabledTextColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox5.EnableDropShadow = False
        Me.SiticoneTextBox5.FillColor1 = System.Drawing.Color.White
        Me.SiticoneTextBox5.FillColor2 = System.Drawing.Color.White
        Me.SiticoneTextBox5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneTextBox5.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox5.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox5.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox5.IsEnabled = True
        Me.SiticoneTextBox5.Location = New System.Drawing.Point(21, 32)
        Me.SiticoneTextBox5.Name = "SiticoneTextBox5"
        Me.SiticoneTextBox5.PlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox5.PlaceholderText = "Enter text here..."
        Me.SiticoneTextBox5.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox5.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox5.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox5.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox5.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.SiticoneTextBox5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox5.ShadowAnimationDuration = 1
        Me.SiticoneTextBox5.ShadowBlur = 10
        Me.SiticoneTextBox5.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneTextBox5.Size = New System.Drawing.Size(181, 33)
        Me.SiticoneTextBox5.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox5.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox5.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox5.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox5.TabIndex = 14
        Me.SiticoneTextBox5.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox5.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox5.ValidationFunction = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Username"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.SiticoneTextBox7)
        Me.Panel5.Controls.Add(Me.SiticoneTextBox1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.SiticoneTextBox3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(255, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 206)
        Me.Panel5.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Security Answer"
        '
        'SiticoneTextBox7
        '
        Me.SiticoneTextBox7.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox7.AccessibleName = "Text Box"
        Me.SiticoneTextBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SiticoneTextBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiticoneTextBox7.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneTextBox7.BlinkCount = 3
        Me.SiticoneTextBox7.BlinkShadow = False
        Me.SiticoneTextBox7.BorderColor1 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox7.BorderColor2 = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox7.BorderFocusColor1 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox7.BorderFocusColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox7.CanShake = True
        Me.SiticoneTextBox7.ContinuousBlink = False
        Me.SiticoneTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SiticoneTextBox7.CursorBlinkRate = 500
        Me.SiticoneTextBox7.CursorColor = System.Drawing.Color.Black
        Me.SiticoneTextBox7.CursorHeight = 26
        Me.SiticoneTextBox7.CursorOffset = 0
        Me.SiticoneTextBox7.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        Me.SiticoneTextBox7.CursorWidth = 1
        Me.SiticoneTextBox7.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox7.DisabledBorderColor = System.Drawing.Color.LightGray
        Me.SiticoneTextBox7.DisabledTextColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox7.EnableDropShadow = False
        Me.SiticoneTextBox7.FillColor1 = System.Drawing.Color.White
        Me.SiticoneTextBox7.FillColor2 = System.Drawing.Color.White
        Me.SiticoneTextBox7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.SiticoneTextBox7.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox7.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox7.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox7.IsEnabled = True
        Me.SiticoneTextBox7.Location = New System.Drawing.Point(25, 148)
        Me.SiticoneTextBox7.Name = "SiticoneTextBox7"
        Me.SiticoneTextBox7.PlaceholderColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox7.PlaceholderText = "Enter text here..."
        Me.SiticoneTextBox7.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox7.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray
        Me.SiticoneTextBox7.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox7.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke
        Me.SiticoneTextBox7.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray
        Me.SiticoneTextBox7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox7.ShadowAnimationDuration = 1
        Me.SiticoneTextBox7.ShadowBlur = 10
        Me.SiticoneTextBox7.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneTextBox7.Size = New System.Drawing.Size(182, 33)
        Me.SiticoneTextBox7.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox7.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox7.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox7.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox7.TabIndex = 15
        Me.SiticoneTextBox7.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox7.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox7.ValidationFunction = Nothing
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
        Me.SiticoneTextBox1.Location = New System.Drawing.Point(26, 32)
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
        Me.SiticoneTextBox1.Size = New System.Drawing.Size(181, 33)
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
        Me.Label3.Location = New System.Drawing.Point(22, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirm Password"
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
        Me.SiticoneTextBox3.Location = New System.Drawing.Point(26, 90)
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
        Me.SiticoneTextBox3.Size = New System.Drawing.Size(181, 33)
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
        Me.Label1.Location = New System.Drawing.Point(22, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email"
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
        Me.SiticoneButton3.Location = New System.Drawing.Point(611, 10)
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
        Me.Panel3.Controls.Add(Me.Guna2DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(758, 219)
        Me.Panel3.TabIndex = 10
        '
        'SiticonePanel1
        '
        Me.SiticonePanel1.AcrylicTintColor = System.Drawing.Color.Transparent
        Me.SiticonePanel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center
        Me.SiticonePanel1.BorderDashPattern = Nothing
        Me.SiticonePanel1.BorderGradientEndColor = System.Drawing.Color.Transparent
        Me.SiticonePanel1.BorderGradientStartColor = System.Drawing.Color.Transparent
        Me.SiticonePanel1.BorderThickness = 2.0!
        Me.SiticonePanel1.Controls.Add(Me.SiticoneButton3)
        Me.SiticonePanel1.CornerRadiusBottomLeft = 16.0!
        Me.SiticonePanel1.CornerRadiusBottomRight = 16.0!
        Me.SiticonePanel1.CornerRadiusTopLeft = 16.0!
        Me.SiticonePanel1.CornerRadiusTopRight = 16.0!
        Me.SiticonePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SiticonePanel1.EnableAcrylicEffect = False
        Me.SiticonePanel1.EnableMicaEffect = False
        Me.SiticonePanel1.EnableRippleEffect = False
        Me.SiticonePanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticonePanel1.GradientColors = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.LightGray, System.Drawing.Color.Gray}
        Me.SiticonePanel1.GradientPositions = New Single() {0!, 0.5!, 1.0!}
        Me.SiticonePanel1.Location = New System.Drawing.Point(0, 263)
        Me.SiticonePanel1.Name = "SiticonePanel1"
        Me.SiticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid
        Me.SiticonePanel1.RippleAlpha = 50
        Me.SiticonePanel1.RippleAlphaDecrement = 3
        Me.SiticonePanel1.RippleColor = System.Drawing.Color.Transparent
        Me.SiticonePanel1.RippleMaxSize = 600.0!
        Me.SiticonePanel1.RippleSpeed = 15.0!
        Me.SiticonePanel1.ShowBorder = False
        Me.SiticonePanel1.Size = New System.Drawing.Size(758, 54)
        Me.SiticonePanel1.TabIndex = 9
        Me.SiticonePanel1.TabStop = True
        Me.SiticonePanel1.TrackSystemTheme = False
        Me.SiticonePanel1.UseBorderGradient = False
        Me.SiticonePanel1.UseMultiGradient = False
        Me.SiticonePanel1.UsePatternTexture = False
        Me.SiticonePanel1.UseRadialGradient = False
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
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(10, 7)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(735, 199)
        Me.Guna2DataGridView1.TabIndex = 0
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
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UserContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SiticonePanel1)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserContent"
        Me.Size = New System.Drawing.Size(758, 536)
        Me.Panel22.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.SiticonePanel1.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SiticoneTextBox6 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SiticoneTextBox5 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SiticoneTextBox1 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SiticoneTextBox3 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SiticoneTextBox7 As SiticoneNetFrameworkUI.SiticoneTextBox
    Friend WithEvents BtnSave As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents SiticoneDashboardCard1 As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents SiticoneButton3 As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents cb_ur As ComboBox
    Friend WithEvents cb_sq As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SiticonePanel1 As SiticonePanel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
