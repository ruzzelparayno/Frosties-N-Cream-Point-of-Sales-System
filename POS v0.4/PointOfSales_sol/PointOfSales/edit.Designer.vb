<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.lbl_getproductname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SiticoneImageButton1 = New SiticoneNetFrameworkUI.SiticoneImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiticoneButton1 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.SiticoneUpDown1 = New SiticoneNetFrameworkUI.SiticoneUpDown()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_getproductname
        '
        Me.lbl_getproductname.AutoSize = True
        Me.lbl_getproductname.Location = New System.Drawing.Point(47, 60)
        Me.lbl_getproductname.Name = "lbl_getproductname"
        Me.lbl_getproductname.Size = New System.Drawing.Size(10, 13)
        Me.lbl_getproductname.TabIndex = 1
        Me.lbl_getproductname.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SiticoneImageButton1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 57)
        Me.Panel1.TabIndex = 7
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Edit"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(35, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 80)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 80)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Use This label to Display The Product Name"
        '
        'SiticoneButton1
        '
        Me.SiticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton1.AccessibleName = "Save"
        Me.SiticoneButton1.AutoSizeBasedOnText = False
        Me.SiticoneButton1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.BadgeBackColor = System.Drawing.Color.Black
        Me.SiticoneButton1.BadgeFont = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton1.BadgeValue = 0
        Me.SiticoneButton1.BadgeValueForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.BorderColor = System.Drawing.Color.Transparent
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
        Me.SiticoneButton1.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.SiticoneButton1.HoverFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton1.HoverTextColor = System.Drawing.Color.Black
        Me.SiticoneButton1.HoverTransitionDuration = 250
        Me.SiticoneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SiticoneButton1.ImagePadding = 5
        Me.SiticoneButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.SiticoneButton1.IsRadial = False
        Me.SiticoneButton1.IsReadOnly = False
        Me.SiticoneButton1.IsToggleButton = False
        Me.SiticoneButton1.IsToggled = False
        Me.SiticoneButton1.Location = New System.Drawing.Point(39, 240)
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
        Me.SiticoneButton1.TabIndex = 11
        Me.SiticoneButton1.Text = "Save"
        Me.SiticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton1.TextColor = System.Drawing.Color.White
        Me.SiticoneButton1.TooltipText = Nothing
        Me.SiticoneButton1.UseAdvancedRendering = True
        Me.SiticoneButton1.UseParticles = False
        '
        'SiticoneUpDown1
        '
        Me.SiticoneUpDown1.AccessibleDescription = "An advanced numeric up/down control."
        Me.SiticoneUpDown1.AccessibleName = "SiticoneUpDown"
        Me.SiticoneUpDown1.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton
        Me.SiticoneUpDown1.ActiveBorderColor = System.Drawing.Color.DodgerBlue
        Me.SiticoneUpDown1.AllowMouseWheel = True
        Me.SiticoneUpDown1.AnimateValueChanges = True
        Me.SiticoneUpDown1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneUpDown1.BorderColor = System.Drawing.Color.Gray
        Me.SiticoneUpDown1.CanBeep = False
        Me.SiticoneUpDown1.CanShake = False
        Me.SiticoneUpDown1.CornerRadiusBottomLeft = 4
        Me.SiticoneUpDown1.CornerRadiusBottomRight = 4
        Me.SiticoneUpDown1.CornerRadiusTopLeft = 4
        Me.SiticoneUpDown1.CornerRadiusTopRight = 4
        Me.SiticoneUpDown1.DecimalPlaces = 0
        Me.SiticoneUpDown1.EnableDirectInput = True
        Me.SiticoneUpDown1.FillColor = System.Drawing.Color.White
        Me.SiticoneUpDown1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneUpDown1.ForeColor = System.Drawing.Color.Black
        Me.SiticoneUpDown1.GradientColorEnd = System.Drawing.Color.LightGray
        Me.SiticoneUpDown1.GradientColorStart = System.Drawing.Color.White
        Me.SiticoneUpDown1.GradientMode = SiticoneNetFrameworkUI.Helpers.[Enum].GradientModes.None
        Me.SiticoneUpDown1.HoverBorderColor = System.Drawing.Color.Transparent
        Me.SiticoneUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SiticoneUpDown1.InitialRepeatDelay = 500
        Me.SiticoneUpDown1.InputType = SiticoneNetFrameworkUI.Helpers.[Enum].InputType.WholeNumbers
        Me.SiticoneUpDown1.IsReadOnly = False
        Me.SiticoneUpDown1.Location = New System.Drawing.Point(40, 183)
        Me.SiticoneUpDown1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.SiticoneUpDown1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SiticoneUpDown1.Name = "SiticoneUpDown1"
        Me.SiticoneUpDown1.RepeatSpeed = 50
        Me.SiticoneUpDown1.ShowBorder = True
        Me.SiticoneUpDown1.Size = New System.Drawing.Size(314, 38)
        Me.SiticoneUpDown1.StepPoints = CType(resources.GetObject("SiticoneUpDown1.StepPoints"), System.Collections.Generic.List(Of Decimal))
        Me.SiticoneUpDown1.TabIndex = 15
        Me.SiticoneUpDown1.Text = "0"
        Me.SiticoneUpDown1.TextAlignment = SiticoneNetFrameworkUI.Helpers.Text.TextAlignment.Center
        Me.SiticoneUpDown1.UseGradient = False
        Me.SiticoneUpDown1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 330)
        Me.Controls.Add(Me.SiticoneUpDown1)
        Me.Controls.Add(Me.SiticoneButton1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_getproductname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "edit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_getproductname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SiticoneButton1 As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents Label3 As Label
    Friend WithEvents SiticoneImageButton1 As SiticoneNetFrameworkUI.SiticoneImageButton
    Friend WithEvents SiticoneUpDown1 As SiticoneNetFrameworkUI.SiticoneUpDown
End Class
