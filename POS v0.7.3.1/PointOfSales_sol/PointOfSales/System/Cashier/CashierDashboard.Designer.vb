<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierDashboard
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
        Dim SiticoneNavbar1 As SiticoneNetFrameworkUI.SiticoneNavbar
        Dim NavBarItem1 As SiticoneNetFrameworkUI.NavBarItem = New SiticoneNetFrameworkUI.NavBarItem()
        Dim NavBarItem2 As SiticoneNetFrameworkUI.NavBarItem = New SiticoneNetFrameworkUI.NavBarItem()
        Dim NavBarItem3 As SiticoneNetFrameworkUI.NavBarItem = New SiticoneNetFrameworkUI.NavBarItem()
        Dim NavBarItem4 As SiticoneNetFrameworkUI.NavBarItem = New SiticoneNetFrameworkUI.NavBarItem()
        Dim NavBarItem5 As SiticoneNetFrameworkUI.NavBarItem = New SiticoneNetFrameworkUI.NavBarItem()
        Dim LayoutState1 As SiticoneNetFrameworkUI.SiticoneFlowPanel.LayoutState = New SiticoneNetFrameworkUI.SiticoneFlowPanel.LayoutState()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SiticoneDashboardCard = New SiticoneNetFrameworkUI.SiticoneDashboardCard()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContentPanel = New SiticoneNetFrameworkUI.SiticoneContentPanel()
        Me.PosControl1 = New PointOfSales.PosControl()
        Me.DashboardContent1 = New PointOfSales.DashboardContent()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        SiticoneNavbar1 = New SiticoneNetFrameworkUI.SiticoneNavbar()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SiticoneNavbar1
        '
        SiticoneNavbar1.AnimationDuration = 0
        SiticoneNavbar1.AnimationEasing = SiticoneNetFrameworkUI.NavAnimationEasing.EaseInOutQuad
        SiticoneNavbar1.AutoShowScrollbars = False
        SiticoneNavbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        SiticoneNavbar1.ButtonBorderColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.ButtonBorderWidth = 3
        SiticoneNavbar1.ButtonImage = Nothing
        SiticoneNavbar1.ButtonInnerMargin = 6
        SiticoneNavbar1.ButtonPressColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.ButtonSpacing = 10
        SiticoneNavbar1.ButtonStyle = SiticoneNetFrameworkUI.NavBarStyle.Rounded
        SiticoneNavbar1.CollapseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        SiticoneNavbar1.Cursor = System.Windows.Forms.Cursors.Default
        SiticoneNavbar1.DisabledButtonForeColor = System.Drawing.Color.DarkGray
        SiticoneNavbar1.Dock = System.Windows.Forms.DockStyle.Fill
        SiticoneNavbar1.FocusedButtonBorderColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        SiticoneNavbar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(84, Byte), Integer))
        SiticoneNavbar1.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(240, Byte), Integer))
        SiticoneNavbar1.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        SiticoneNavbar1.HeaderTitle = " "
        SiticoneNavbar1.HeaderTitleAlignment = System.Drawing.ContentAlignment.MiddleCenter
        SiticoneNavbar1.HeaderTitleBackColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.HeaderTitleFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiticoneNavbar1.HeaderTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        SiticoneNavbar1.HeaderTitlePadding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        SiticoneNavbar1.HoverButtonBorderColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.IndicatorCornerRadius = 9
        SiticoneNavbar1.IndicatorGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(240, Byte), Integer))
        SiticoneNavbar1.IndicatorGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        NavBarItem1.BackColor = System.Drawing.Color.Empty
        NavBarItem1.BorderColor = System.Drawing.Color.Empty
        NavBarItem1.FocusedBorderColor = System.Drawing.Color.Transparent
        NavBarItem1.ForeColor = System.Drawing.Color.Empty
        NavBarItem1.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem1.PressBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem1.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        NavBarItem1.SelectedBorderColor = System.Drawing.Color.Empty
        NavBarItem1.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        NavBarItem1.Text = "Dashboard"
        NavBarItem2.BackColor = System.Drawing.Color.Empty
        NavBarItem2.BorderColor = System.Drawing.Color.Empty
        NavBarItem2.FocusedBorderColor = System.Drawing.Color.Transparent
        NavBarItem2.ForeColor = System.Drawing.Color.Empty
        NavBarItem2.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem2.PressBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem2.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        NavBarItem2.SelectedBorderColor = System.Drawing.Color.Empty
        NavBarItem2.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        NavBarItem2.Text = "Point Of Sales"
        NavBarItem3.BackColor = System.Drawing.Color.Empty
        NavBarItem3.BorderColor = System.Drawing.Color.Empty
        NavBarItem3.FocusedBorderColor = System.Drawing.Color.Transparent
        NavBarItem3.ForeColor = System.Drawing.Color.Empty
        NavBarItem3.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem3.PressBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem3.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        NavBarItem3.SelectedBorderColor = System.Drawing.Color.Empty
        NavBarItem3.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        NavBarItem3.Text = "Transaction"
        NavBarItem4.BackColor = System.Drawing.Color.Empty
        NavBarItem4.BorderColor = System.Drawing.Color.Empty
        NavBarItem4.ForeColor = System.Drawing.Color.Empty
        NavBarItem4.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem4.PressBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem4.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        NavBarItem4.SelectedBorderColor = System.Drawing.Color.Empty
        NavBarItem4.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        NavBarItem4.Text = "Shift"
        NavBarItem5.BackColor = System.Drawing.Color.Empty
        NavBarItem5.BorderColor = System.Drawing.Color.Empty
        NavBarItem5.ForeColor = System.Drawing.Color.Empty
        NavBarItem5.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem5.PressBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        NavBarItem5.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        NavBarItem5.SelectedBorderColor = System.Drawing.Color.Empty
        NavBarItem5.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        NavBarItem5.Text = "Logout"
        SiticoneNavbar1.Items.Add(NavBarItem1)
        SiticoneNavbar1.Items.Add(NavBarItem2)
        SiticoneNavbar1.Items.Add(NavBarItem3)
        SiticoneNavbar1.Items.Add(NavBarItem4)
        SiticoneNavbar1.Items.Add(NavBarItem5)
        SiticoneNavbar1.LimitButtonHeight = False
        SiticoneNavbar1.Location = New System.Drawing.Point(0, 0)
        SiticoneNavbar1.MaterialTabIndicatorPosition = SiticoneNetFrameworkUI.IndicatorPosition.Top
        SiticoneNavbar1.MaterialTabSelectedIndicatorColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.MaxButtonHeight = 40
        SiticoneNavbar1.MaximumSize = New System.Drawing.Size(0, 350)
        SiticoneNavbar1.MinButtonHeight = 0
        SiticoneNavbar1.MinimumHeight = 700
        SiticoneNavbar1.Name = "SiticoneNavbar1"
        SiticoneNavbar1.PressButtonBorderColor = System.Drawing.Color.DarkGray
        SiticoneNavbar1.RippleEffectNavColor = System.Drawing.Color.LightGray
        SiticoneNavbar1.SelectedButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        SiticoneNavbar1.SelectedButtonBorderColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.SelectedButtonCursor = System.Windows.Forms.Cursors.Hand
        SiticoneNavbar1.SelectedButtonFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiticoneNavbar1.SelectedButtonForeColor = System.Drawing.Color.White
        SiticoneNavbar1.SelectedIndex = 0
        SiticoneNavbar1.SelectedIndicatorSideColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.SelectedItem = NavBarItem1
        SiticoneNavbar1.ShowTitleSections = False
        SiticoneNavbar1.ShowTooltips = False
        SiticoneNavbar1.SidebarBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        SiticoneNavbar1.Size = New System.Drawing.Size(0, 350)
        SiticoneNavbar1.TabIndex = 2
        SiticoneNavbar1.TitleSeparatorColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.UnselectedButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        SiticoneNavbar1.UnselectedButtonBorderColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.UnselectedButtonCursor = System.Windows.Forms.Cursors.Default
        SiticoneNavbar1.UnselectedButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(141, Byte), Integer))
        SiticoneNavbar1.UnselectedButtonHoverColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        SiticoneNavbar1.UnselectedTabIndicatorColor = System.Drawing.Color.Transparent
        SiticoneNavbar1.UseDottedFocusStyle = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(SiticoneNavbar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 658)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.SiticoneDashboardCard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(300, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(778, 658)
        Me.Panel2.TabIndex = 2
        '
        'SiticoneDashboardCard
        '
        Me.SiticoneDashboardCard.AutoSize = True
        Me.SiticoneDashboardCard.BackColor = System.Drawing.Color.Transparent
        Me.SiticoneDashboardCard.BackgroundEndColor = System.Drawing.Color.Transparent
        Me.SiticoneDashboardCard.BackgroundStartColor = System.Drawing.Color.White
        Me.SiticoneDashboardCard.BorderColor = System.Drawing.Color.Transparent
        Me.SiticoneDashboardCard.BorderEndColor = System.Drawing.Color.Transparent
        Me.SiticoneDashboardCard.BorderStartColor = System.Drawing.Color.Transparent
        Me.SiticoneDashboardCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiticoneDashboardCard.Location = New System.Drawing.Point(10, 10)
        Me.SiticoneDashboardCard.Name = "SiticoneDashboardCard"
        Me.SiticoneDashboardCard.Size = New System.Drawing.Size(758, 638)
        Me.SiticoneDashboardCard.TabIndex = 3
        LayoutState1.Location = New System.Drawing.Point(3, 3)
        LayoutState1.Size = New System.Drawing.Size(0, 0)
        LayoutState1.Visible = True
        Me.SiticoneDashboardCard.Tag = LayoutState1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(300, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 31)
        Me.Panel3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(778, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dec 10 2006"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.White
        Me.ContentPanel.ContentBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ContentPanel.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.ContentPanel.Controls.Add(Me.PosControl1)
        Me.ContentPanel.Controls.Add(Me.DashboardContent1)
        Me.ContentPanel.DefaultTitleFont = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.EmptyContentMessageColor = System.Drawing.Color.Gray
        Me.ContentPanel.EmptyContentMessageFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ContentPanel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ContentPanel.Location = New System.Drawing.Point(300, 31)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.ShowTitle = False
        Me.ContentPanel.ShowTitleSeparator = False
        Me.ContentPanel.Size = New System.Drawing.Size(778, 627)
        Me.ContentPanel.TabIndex = 4
        Me.ContentPanel.TargetNavbar = SiticoneNavbar1
        Me.ContentPanel.TitleBackColor = System.Drawing.Color.White
        Me.ContentPanel.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ContentPanel.TitlePadding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ContentPanel.TitleSeparatorColor = System.Drawing.Color.White
        '
        'PosControl1
        '
        Me.PosControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PosControl1.Location = New System.Drawing.Point(0, 48)
        Me.PosControl1.Name = "PosControl1"
        Me.PosControl1.Size = New System.Drawing.Size(758, 590)
        Me.PosControl1.TabIndex = 4
        '
        'DashboardContent1
        '
        Me.DashboardContent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DashboardContent1.Location = New System.Drawing.Point(4, 48)
        Me.DashboardContent1.Name = "DashboardContent1"
        Me.DashboardContent1.Size = New System.Drawing.Size(752, 600)
        Me.DashboardContent1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CashierDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 658)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CashierDashboard"
        Me.Text = "CashierDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ContentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SiticoneDashboardCard1 As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents SiticoneDashboardCard As SiticoneNetFrameworkUI.SiticoneDashboardCard
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ContentPanel As SiticoneContentPanel
    Friend WithEvents PosControl1 As PosControl
    Friend WithEvents DashboardContent1 As DashboardContent
    Friend WithEvents Timer1 As Timer
End Class
