<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryForm
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
        Me.SiticoneLabel1 = New SiticoneNetFrameworkUI.SiticoneLabel()
        Me.BtnSave = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SiticoneLabel3 = New SiticoneNetFrameworkUI.SiticoneLabel()
        Me.SiticoneTextBox1 = New SiticoneNetFrameworkUI.SiticoneTextBox()
        Me.SiticoneLabel2 = New SiticoneNetFrameworkUI.SiticoneLabel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.SiticoneLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 50)
        Me.Panel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PointOfSales.My.Resources.Resources.Back_To
        Me.PictureBox1.Location = New System.Drawing.Point(33, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'SiticoneLabel1
        '
        Me.SiticoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneLabel1.ForeColor = System.Drawing.Color.White
        Me.SiticoneLabel1.Location = New System.Drawing.Point(76, 14)
        Me.SiticoneLabel1.Name = "SiticoneLabel1"
        Me.SiticoneLabel1.Size = New System.Drawing.Size(181, 23)
        Me.SiticoneLabel1.TabIndex = 0
        Me.SiticoneLabel1.Text = "Create Category"
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
        Me.BtnSave.Location = New System.Drawing.Point(41, 278)
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
        Me.BtnSave.TabIndex = 23
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.TextColor = System.Drawing.Color.White
        Me.BtnSave.TooltipText = Nothing
        Me.BtnSave.UseAdvancedRendering = True
        Me.BtnSave.UseParticles = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(41, 165)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 95)
        Me.TextBox1.TabIndex = 22
        '
        'SiticoneLabel3
        '
        Me.SiticoneLabel3.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneLabel3.ForeColor = System.Drawing.Color.Black
        Me.SiticoneLabel3.Location = New System.Drawing.Point(41, 139)
        Me.SiticoneLabel3.Name = "SiticoneLabel3"
        Me.SiticoneLabel3.Size = New System.Drawing.Size(181, 23)
        Me.SiticoneLabel3.TabIndex = 21
        Me.SiticoneLabel3.Text = "Description"
        '
        'SiticoneTextBox1
        '
        Me.SiticoneTextBox1.AccessibleDescription = "A customizable text input field."
        Me.SiticoneTextBox1.AccessibleName = "Text Box"
        Me.SiticoneTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
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
        Me.SiticoneTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.SiticoneTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.SiticoneTextBox1.HoverBorderColor1 = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.HoverBorderColor2 = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.IsEnabled = True
        Me.SiticoneTextBox1.Location = New System.Drawing.Point(41, 87)
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
        Me.SiticoneTextBox1.Size = New System.Drawing.Size(358, 39)
        Me.SiticoneTextBox1.SolidBorderColor = System.Drawing.Color.LightSlateGray
        Me.SiticoneTextBox1.SolidBorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneTextBox1.SolidBorderHoverColor = System.Drawing.Color.Gray
        Me.SiticoneTextBox1.SolidFillColor = System.Drawing.Color.White
        Me.SiticoneTextBox1.TabIndex = 20
        Me.SiticoneTextBox1.TextPadding = New System.Windows.Forms.Padding(16, 0, 6, 0)
        Me.SiticoneTextBox1.ValidationErrorMessage = "Invalid input."
        Me.SiticoneTextBox1.ValidationFunction = Nothing
        '
        'SiticoneLabel2
        '
        Me.SiticoneLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneLabel2.ForeColor = System.Drawing.Color.Black
        Me.SiticoneLabel2.Location = New System.Drawing.Point(41, 61)
        Me.SiticoneLabel2.Name = "SiticoneLabel2"
        Me.SiticoneLabel2.Size = New System.Drawing.Size(181, 23)
        Me.SiticoneLabel2.TabIndex = 19
        Me.SiticoneLabel2.Text = "Category Name"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 337)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SiticoneLabel3)
        Me.Controls.Add(Me.SiticoneTextBox1)
        Me.Controls.Add(Me.SiticoneLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CategoryForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SiticoneLabel1 As SiticoneLabel
    Friend WithEvents BtnSave As SiticoneButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SiticoneLabel3 As SiticoneLabel
    Friend WithEvents SiticoneTextBox1 As SiticoneTextBox
    Friend WithEvents SiticoneLabel2 As SiticoneLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
