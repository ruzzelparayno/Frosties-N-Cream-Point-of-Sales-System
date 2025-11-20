<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.SiticoneBorderlessForm1 = New SiticoneNetFrameworkUI.SiticoneBorderlessForm(Me.components)
        Me.SiticoneHProgressBar1 = New SiticoneNetFrameworkUI.SiticoneHProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SiticoneShimmerLabel1 = New SiticoneNetFrameworkUI.SiticoneShimmerLabel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiticoneBorderlessForm1
        '
        Me.SiticoneBorderlessForm1.CanDrag = False
        Me.SiticoneBorderlessForm1.CornerRadius = 30
        Me.SiticoneBorderlessForm1.FormDragArea = SiticoneNetFrameworkUI.SiticoneBorderlessForm.DragArea.None
        Me.SiticoneBorderlessForm1.NavBarColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SiticoneBorderlessForm1.ShowNavBar = False
        Me.SiticoneBorderlessForm1.TargetForm = Me
        '
        'SiticoneHProgressBar1
        '
        Me.SiticoneHProgressBar1.AccessibleDescription = "This control shows the value of the horizontal progress bar."
        Me.SiticoneHProgressBar1.AccessibleName = "Advanced and modern horizontal progress bar control"
        Me.SiticoneHProgressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar
        Me.SiticoneHProgressBar1.AnimationDurationMs = 500.0R
        Me.SiticoneHProgressBar1.AnimationTimerInterval = 15
        Me.SiticoneHProgressBar1.AutoLabelColor = False
        Me.SiticoneHProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneHProgressBar1.BackgroundBarColor = System.Drawing.Color.White
        Me.SiticoneHProgressBar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneHProgressBar1.CanBeep = True
        Me.SiticoneHProgressBar1.CanShake = True
        Me.SiticoneHProgressBar1.CornerRadiusBottomLeft = 15
        Me.SiticoneHProgressBar1.CornerRadiusBottomRight = 15
        Me.SiticoneHProgressBar1.CornerRadiusTopLeft = 15
        Me.SiticoneHProgressBar1.CornerRadiusTopRight = 15
        Me.SiticoneHProgressBar1.CustomLabel = ""
        Me.SiticoneHProgressBar1.EnableGradient = False
        Me.SiticoneHProgressBar1.EnableValueDragging = False
        Me.SiticoneHProgressBar1.ErrorColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneHProgressBar1.ForeColor = System.Drawing.Color.Transparent
        Me.SiticoneHProgressBar1.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.SiticoneHProgressBar1.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.SiticoneHProgressBar1.Indeterminate = False
        Me.SiticoneHProgressBar1.IndeterminateBarColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneHProgressBar1.IsReadonly = False
        Me.SiticoneHProgressBar1.LabelColor = System.Drawing.Color.Transparent
        Me.SiticoneHProgressBar1.LabelFont = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SiticoneHProgressBar1.Location = New System.Drawing.Point(328, 401)
        Me.SiticoneHProgressBar1.Maximum = 100
        Me.SiticoneHProgressBar1.Minimum = 0
        Me.SiticoneHProgressBar1.MinimumSize = New System.Drawing.Size(50, 20)
        Me.SiticoneHProgressBar1.Name = "SiticoneHProgressBar1"
        Me.SiticoneHProgressBar1.ReadonlyBorderColor = System.Drawing.Color.DimGray
        Me.SiticoneHProgressBar1.ReadonlyFillColor1 = System.Drawing.Color.Gray
        Me.SiticoneHProgressBar1.ReadonlyFillColor2 = System.Drawing.Color.DarkGray
        Me.SiticoneHProgressBar1.ReadonlyForeColor = System.Drawing.Color.Transparent
        Me.SiticoneHProgressBar1.ShowFocusCue = False
        Me.SiticoneHProgressBar1.Size = New System.Drawing.Size(431, 20)
        Me.SiticoneHProgressBar1.SuccessColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneHProgressBar1.TabIndex = 0
        Me.SiticoneHProgressBar1.Text = "SiticoneHProgressBar1"
        Me.SiticoneHProgressBar1.Value = 0
        Me.SiticoneHProgressBar1.ValueOrientation = SiticoneNetFrameworkUI.Helpers.[Enum].ProgressBarOrientation.Horizontal
        Me.SiticoneHProgressBar1.WarningColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PointOfSales.My.Resources.Resources._1000051999_ezgif_com_video_to_gif_converter
        Me.PictureBox1.Location = New System.Drawing.Point(356, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'SiticoneShimmerLabel1
        '
        Me.SiticoneShimmerLabel1.AutoReverse = False
        Me.SiticoneShimmerLabel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SiticoneShimmerLabel1.Direction = SiticoneNetFrameworkUI.ShimmerDirection.LeftToRight
        Me.SiticoneShimmerLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiticoneShimmerLabel1.IsAnimating = True
        Me.SiticoneShimmerLabel1.IsPaused = False
        Me.SiticoneShimmerLabel1.Location = New System.Drawing.Point(392, 427)
        Me.SiticoneShimmerLabel1.Name = "SiticoneShimmerLabel1"
        Me.SiticoneShimmerLabel1.PauseDuration = 0
        Me.SiticoneShimmerLabel1.ShimmerColor = System.Drawing.Color.Cyan
        Me.SiticoneShimmerLabel1.ShimmerOpacity = 1.0!
        Me.SiticoneShimmerLabel1.ShimmerSpeed = 50
        Me.SiticoneShimmerLabel1.ShimmerWidth = 0.2!
        Me.SiticoneShimmerLabel1.Size = New System.Drawing.Size(318, 26)
        Me.SiticoneShimmerLabel1.TabIndex = 2
        Me.SiticoneShimmerLabel1.Text = "One bite closer to happiness."
        Me.SiticoneShimmerLabel1.ToolTipText = ""
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1078, 658)
        Me.Controls.Add(Me.SiticoneShimmerLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SiticoneHProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SiticoneBorderlessForm1 As SiticoneBorderlessForm
    Friend WithEvents SiticoneHProgressBar1 As SiticoneHProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SiticoneShimmerLabel1 As SiticoneShimmerLabel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
