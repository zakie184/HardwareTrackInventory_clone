<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        btnNotifications = New Button()
        lblHeaderUser = New Label()
        pnlHeaderLine = New Panel()
        splitContainer = New SplitContainer()
        pnlSidebar = New Panel()
        tlpSidebar = New TableLayoutPanel()
        btnDashboard = New Button()
        btnHardware = New Button()
        btnUsers = New Button()
        pnlSidebarSpacer = New Panel()
        btnLogout = New Button()
        pnlContent = New Panel()
        pnlFooter = New Panel()
        lblFooterLeft = New Label()
        lblFooterRight = New Label()
        tmrNotifications = New Timer(components)
        pnlHeader.SuspendLayout()
        CType(splitContainer, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer.Panel1.SuspendLayout()
        splitContainer.Panel2.SuspendLayout()
        splitContainer.SuspendLayout()
        pnlSidebar.SuspendLayout()
        tlpSidebar.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(26), CByte(54), CByte(75))
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(btnNotifications)
        pnlHeader.Controls.Add(lblHeaderUser)
        pnlHeader.Controls.Add(pnlHeaderLine)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1100, 55)
        pnlHeader.TabIndex = 1
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(20, 8)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(175, 25)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "🛠️ HardwareTrack"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 9.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
        lblHeaderSub.Location = New Point(22, 33)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(0, 15)
        lblHeaderSub.TabIndex = 1
        ' 
        ' btnNotifications
        ' 
        btnNotifications.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNotifications.BackColor = Color.Transparent
        btnNotifications.FlatAppearance.BorderSize = 0
        btnNotifications.FlatStyle = FlatStyle.Flat
        btnNotifications.Font = New Font("Segoe UI", 12.0F)
        btnNotifications.ForeColor = Color.White
        btnNotifications.Location = New Point(840, 10)
        btnNotifications.Name = "btnNotifications"
        btnNotifications.Size = New Size(80, 35)
        btnNotifications.TabIndex = 2
        btnNotifications.Text = "🔔"
        btnNotifications.UseVisualStyleBackColor = False
        ' 
        ' lblHeaderUser
        ' 
        lblHeaderUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHeaderUser.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblHeaderUser.ForeColor = Color.White
        lblHeaderUser.Location = New Point(930, 10)
        lblHeaderUser.Name = "lblHeaderUser"
        lblHeaderUser.Size = New Size(150, 35)
        lblHeaderUser.TabIndex = 3
        lblHeaderUser.Text = "👤 John Doe"
        lblHeaderUser.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlHeaderLine
        ' 
        pnlHeaderLine.BackColor = Color.FromArgb(CByte(245), CByte(176), CByte(65))
        pnlHeaderLine.Dock = DockStyle.Bottom
        pnlHeaderLine.Location = New Point(0, 52)
        pnlHeaderLine.Name = "pnlHeaderLine"
        pnlHeaderLine.Size = New Size(1100, 3)
        pnlHeaderLine.TabIndex = 4
        ' 
        ' splitContainer
        ' 
        splitContainer.Dock = DockStyle.Fill
        splitContainer.Location = New Point(0, 55)
        splitContainer.Name = "splitContainer"
        ' 
        ' splitContainer.Panel1
        ' 
        splitContainer.Panel1.Controls.Add(pnlSidebar)
        splitContainer.Panel1MinSize = 180
        ' 
        ' splitContainer.Panel2
        ' 
        splitContainer.Panel2.Controls.Add(pnlContent)
        splitContainer.Size = New Size(1100, 600)
        splitContainer.SplitterDistance = 220
        splitContainer.SplitterWidth = 1
        splitContainer.TabIndex = 0
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(26), CByte(54), CByte(75))
        pnlSidebar.Controls.Add(tlpSidebar)
        pnlSidebar.Dock = DockStyle.Fill
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Padding = New Padding(6)
        pnlSidebar.Size = New Size(220, 600)
        pnlSidebar.TabIndex = 0
        ' 
        ' tlpSidebar
        ' 
        tlpSidebar.ColumnCount = 1
        tlpSidebar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpSidebar.Controls.Add(btnDashboard, 0, 0)
        tlpSidebar.Controls.Add(btnHardware, 0, 1)
        tlpSidebar.Controls.Add(btnUsers, 0, 2)
        tlpSidebar.Controls.Add(pnlSidebarSpacer, 0, 3)
        tlpSidebar.Controls.Add(btnLogout, 0, 4)
        tlpSidebar.Dock = DockStyle.Fill
        tlpSidebar.Location = New Point(6, 6)
        tlpSidebar.Name = "tlpSidebar"
        tlpSidebar.RowCount = 5
        tlpSidebar.RowStyles.Add(New RowStyle(SizeType.Absolute, 42.0F))
        tlpSidebar.RowStyles.Add(New RowStyle(SizeType.Absolute, 42.0F))
        tlpSidebar.RowStyles.Add(New RowStyle(SizeType.Absolute, 42.0F))
        tlpSidebar.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpSidebar.RowStyles.Add(New RowStyle(SizeType.Absolute, 42.0F))
        tlpSidebar.Size = New Size(208, 588)
        tlpSidebar.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(245), CByte(176), CByte(65))
        btnDashboard.Dock = DockStyle.Fill
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.FromArgb(CByte(26), CByte(54), CByte(75))
        btnDashboard.Location = New Point(3, 3)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(202, 36)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "📊  Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnHardware
        ' 
        btnHardware.Dock = DockStyle.Fill
        btnHardware.FlatAppearance.BorderSize = 0
        btnHardware.FlatStyle = FlatStyle.Flat
        btnHardware.Font = New Font("Segoe UI", 10.0F)
        btnHardware.ForeColor = Color.White
        btnHardware.Location = New Point(3, 45)
        btnHardware.Name = "btnHardware"
        btnHardware.Size = New Size(202, 36)
        btnHardware.TabIndex = 1
        btnHardware.Text = "💻  Hardware"
        btnHardware.TextAlign = ContentAlignment.MiddleLeft
        btnHardware.UseVisualStyleBackColor = True
        ' 
        ' btnUsers
        ' 
        btnUsers.Dock = DockStyle.Fill
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 10.0F)
        btnUsers.ForeColor = Color.White
        btnUsers.Location = New Point(3, 87)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(202, 36)
        btnUsers.TabIndex = 2
        btnUsers.Text = "👥  Users"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' pnlSidebarSpacer
        ' 
        pnlSidebarSpacer.Location = New Point(3, 129)
        pnlSidebarSpacer.Name = "pnlSidebarSpacer"
        pnlSidebarSpacer.Size = New Size(200, 100)
        pnlSidebarSpacer.TabIndex = 3
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Fill
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.FromArgb(CByte(245), CByte(176), CByte(65))
        btnLogout.Location = New Point(3, 549)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(202, 36)
        btnLogout.TabIndex = 4
        btnLogout.Text = "🚪  Log Out"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(15)
        pnlContent.Size = New Size(879, 600)
        pnlContent.TabIndex = 0
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(26), CByte(54), CByte(75))
        pnlFooter.Controls.Add(lblFooterLeft)
        pnlFooter.Controls.Add(lblFooterRight)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 655)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1100, 45)
        pnlFooter.TabIndex = 2
        ' 
        ' lblFooterLeft
        ' 
        lblFooterLeft.AutoSize = True
        lblFooterLeft.Font = New Font("Segoe UI", 9.0F)
        lblFooterLeft.ForeColor = Color.White
        lblFooterLeft.Location = New Point(20, 14)
        lblFooterLeft.Name = "lblFooterLeft"
        lblFooterLeft.Size = New Size(230, 15)
        lblFooterLeft.TabIndex = 0
        lblFooterLeft.Text = "© 2026 HardwareTrack. All rights reserved."
        ' 
        ' lblFooterRight
        ' 
        lblFooterRight.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFooterRight.AutoSize = True
        lblFooterRight.Font = New Font("Segoe UI", 9.0F)
        lblFooterRight.ForeColor = Color.White
        lblFooterRight.Location = New Point(772, 14)
        lblFooterRight.Name = "lblFooterRight"
        lblFooterRight.Size = New Size(203, 15)
        lblFooterRight.TabIndex = 1
        lblFooterRight.Text = "Logged in as: John Doe | Role: Admin"
        ' 
        ' tmrNotifications
        ' 
        tmrNotifications.Enabled = True
        tmrNotifications.Interval = 5000
        ' 
        ' MainForm
        ' 
        ClientSize = New Size(1100, 700)
        Controls.Add(splitContainer)
        Controls.Add(pnlHeader)
        Controls.Add(pnlFooter)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HardwareTrack - Inventory Management"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        splitContainer.Panel1.ResumeLayout(False)
        splitContainer.Panel2.ResumeLayout(False)
        CType(splitContainer, ComponentModel.ISupportInitialize).EndInit()
        splitContainer.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        tlpSidebar.ResumeLayout(False)
        pnlFooter.ResumeLayout(False)
        pnlFooter.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents btnNotifications As System.Windows.Forms.Button
    Friend WithEvents lblHeaderUser As System.Windows.Forms.Label
    Friend WithEvents pnlHeaderLine As System.Windows.Forms.Panel
    Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents tlpSidebar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnHardware As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents pnlSidebarSpacer As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblFooterLeft As System.Windows.Forms.Label
    Friend WithEvents lblFooterRight As System.Windows.Forms.Label
    Friend WithEvents tmrNotifications As System.Windows.Forms.Timer
End Class