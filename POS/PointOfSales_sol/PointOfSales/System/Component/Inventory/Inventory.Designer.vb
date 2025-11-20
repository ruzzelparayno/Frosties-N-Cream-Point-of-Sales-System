<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCategory = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.SiticoneButton1 = New SiticoneNetFrameworkUI.SiticoneButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCategory)
        Me.Panel1.Controls.Add(Me.SiticoneButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 51)
        Me.Panel1.TabIndex = 2
        '
        'btnCategory
        '
        Me.btnCategory.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.btnCategory.AccessibleName = "Category"
        Me.btnCategory.AutoSizeBasedOnText = False
        Me.btnCategory.BackColor = System.Drawing.Color.Transparent
        Me.btnCategory.BadgeBackColor = System.Drawing.Color.Black
        Me.btnCategory.BadgeFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCategory.BadgeValue = 0
        Me.btnCategory.BadgeValueForeColor = System.Drawing.Color.White
        Me.btnCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCategory.BorderWidth = 2
        Me.btnCategory.ButtonBackColor = System.Drawing.Color.White
        Me.btnCategory.ButtonImage = Nothing
        Me.btnCategory.ButtonTextLeftPadding = 0
        Me.btnCategory.CanBeep = True
        Me.btnCategory.CanGlow = False
        Me.btnCategory.CanShake = True
        Me.btnCategory.ContextMenuStripEx = Nothing
        Me.btnCategory.CornerRadiusBottomLeft = 5
        Me.btnCategory.CornerRadiusBottomRight = 5
        Me.btnCategory.CornerRadiusTopLeft = 5
        Me.btnCategory.CornerRadiusTopRight = 5
        Me.btnCategory.CustomCursor = System.Windows.Forms.Cursors.Default
        Me.btnCategory.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnCategory.EnableLongPress = False
        Me.btnCategory.EnablePressAnimation = True
        Me.btnCategory.EnableRippleEffect = True
        Me.btnCategory.EnableShadow = False
        Me.btnCategory.EnableTextWrapping = False
        Me.btnCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCategory.GlowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCategory.GlowIntensity = 100
        Me.btnCategory.GlowRadius = 20.0!
        Me.btnCategory.GradientBackground = False
        Me.btnCategory.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCategory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCategory.HintText = Nothing
        Me.btnCategory.HoverBackColor = System.Drawing.Color.Transparent
        Me.btnCategory.HoverFontStyle = System.Drawing.FontStyle.Bold
        Me.btnCategory.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCategory.HoverTransitionDuration = 250
        Me.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.ImagePadding = 5
        Me.btnCategory.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCategory.IsRadial = False
        Me.btnCategory.IsReadOnly = False
        Me.btnCategory.IsToggleButton = False
        Me.btnCategory.IsToggled = False
        Me.btnCategory.Location = New System.Drawing.Point(141, 6)
        Me.btnCategory.LongPressDurationMS = 1000
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.btnCategory.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCategory.ParticleCount = 15
        Me.btnCategory.PressAnimationScale = 0.97!
        Me.btnCategory.PressedBackColor = System.Drawing.Color.Transparent
        Me.btnCategory.PressedFontStyle = System.Drawing.FontStyle.Regular
        Me.btnCategory.PressTransitionDuration = 150
        Me.btnCategory.ReadOnlyTextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCategory.RippleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCategory.RippleOpacity = 0.3!
        Me.btnCategory.RippleRadiusMultiplier = 0.6!
        Me.btnCategory.ShadowBlur = 5
        Me.btnCategory.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCategory.ShadowOffset = New System.Drawing.Point(2, 2)
        Me.btnCategory.ShakeDuration = 500
        Me.btnCategory.ShakeIntensity = 5
        Me.btnCategory.Size = New System.Drawing.Size(125, 40)
        Me.btnCategory.TabIndex = 4
        Me.btnCategory.Text = "Category"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCategory.TextColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCategory.TooltipText = Nothing
        Me.btnCategory.UseAdvancedRendering = True
        Me.btnCategory.UseParticles = False
        '
        'SiticoneButton1
        '
        Me.SiticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" &
    ""
        Me.SiticoneButton1.AccessibleName = "Product"
        Me.SiticoneButton1.AutoSizeBasedOnText = False
        Me.SiticoneButton1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.BadgeBackColor = System.Drawing.Color.Black
        Me.SiticoneButton1.BadgeFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneButton1.BadgeValue = 0
        Me.SiticoneButton1.BadgeValueForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.BorderColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.BorderWidth = 2
        Me.SiticoneButton1.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton1.ButtonImage = Nothing
        Me.SiticoneButton1.ButtonTextLeftPadding = 0
        Me.SiticoneButton1.CanBeep = True
        Me.SiticoneButton1.CanGlow = False
        Me.SiticoneButton1.CanShake = True
        Me.SiticoneButton1.ContextMenuStripEx = Nothing
        Me.SiticoneButton1.CornerRadiusBottomLeft = 5
        Me.SiticoneButton1.CornerRadiusBottomRight = 5
        Me.SiticoneButton1.CornerRadiusTopLeft = 5
        Me.SiticoneButton1.CornerRadiusTopRight = 5
        Me.SiticoneButton1.CustomCursor = System.Windows.Forms.Cursors.Default
        Me.SiticoneButton1.DisabledTextColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SiticoneButton1.EnableLongPress = False
        Me.SiticoneButton1.EnablePressAnimation = True
        Me.SiticoneButton1.EnableRippleEffect = True
        Me.SiticoneButton1.EnableShadow = False
        Me.SiticoneButton1.EnableTextWrapping = False
        Me.SiticoneButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneButton1.ForeColor = System.Drawing.Color.White
        Me.SiticoneButton1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButton1.GlowIntensity = 100
        Me.SiticoneButton1.GlowRadius = 20.0!
        Me.SiticoneButton1.GradientBackground = False
        Me.SiticoneButton1.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SiticoneButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SiticoneButton1.HintText = Nothing
        Me.SiticoneButton1.HoverBackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.HoverFontStyle = System.Drawing.FontStyle.Bold
        Me.SiticoneButton1.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SiticoneButton1.HoverTransitionDuration = 250
        Me.SiticoneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SiticoneButton1.ImagePadding = 5
        Me.SiticoneButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.SiticoneButton1.IsRadial = False
        Me.SiticoneButton1.IsReadOnly = False
        Me.SiticoneButton1.IsToggleButton = False
        Me.SiticoneButton1.IsToggled = False
        Me.SiticoneButton1.Location = New System.Drawing.Point(10, 6)
        Me.SiticoneButton1.LongPressDurationMS = 1000
        Me.SiticoneButton1.Name = "SiticoneButton1"
        Me.SiticoneButton1.NormalFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton1.ParticleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.SiticoneButton1.ParticleCount = 15
        Me.SiticoneButton1.PressAnimationScale = 0.97!
        Me.SiticoneButton1.PressedBackColor = System.Drawing.Color.Transparent
        Me.SiticoneButton1.PressedFontStyle = System.Drawing.FontStyle.Regular
        Me.SiticoneButton1.PressTransitionDuration = 150
        Me.SiticoneButton1.ReadOnlyTextColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SiticoneButton1.RippleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiticoneButton1.RippleOpacity = 0.3!
        Me.SiticoneButton1.RippleRadiusMultiplier = 0.6!
        Me.SiticoneButton1.ShadowBlur = 5
        Me.SiticoneButton1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SiticoneButton1.ShadowOffset = New System.Drawing.Point(2, 2)
        Me.SiticoneButton1.ShakeDuration = 500
        Me.SiticoneButton1.ShakeIntensity = 5
        Me.SiticoneButton1.Size = New System.Drawing.Size(125, 40)
        Me.SiticoneButton1.TabIndex = 3
        Me.SiticoneButton1.Text = "Product"
        Me.SiticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SiticoneButton1.TextColor = System.Drawing.Color.White
        Me.SiticoneButton1.TooltipText = Nothing
        Me.SiticoneButton1.UseAdvancedRendering = True
        Me.SiticoneButton1.UseParticles = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 536)
        Me.Panel2.TabIndex = 3
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inventory"
        Me.Size = New System.Drawing.Size(758, 587)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCategory As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents SiticoneButton1 As SiticoneNetFrameworkUI.SiticoneButton
    Friend WithEvents Panel2 As Panel
End Class
