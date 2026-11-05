<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.lblHeaderUser = New System.Windows.Forms.Label()
        Me.pnlHeaderLine = New System.Windows.Forms.Panel()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.tlpSidebar = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnHardware = New System.Windows.Forms.Button()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.pnlSidebarSpacer = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblFooterLeft = New System.Windows.Forms.Label()
        Me.lblFooterRight = New System.Windows.Forms.Label()
        Me.tmrNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.tlpSidebar.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.btnNotifications)
        Me.pnlHeader.Controls.Add(Me.lblHeaderUser)
        Me.pnlHeader.Controls.Add(Me.pnlHeaderLine)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 55)
        Me.pnlHeader.TabIndex = 1
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(175, 25)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "🛠️ HardwareTrack"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblHeaderSub.Location = New System.Drawing.Point(22, 33)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(0, 15)
        Me.lblHeaderSub.TabIndex = 1
        '
        'btnNotifications
        '
        Me.btnNotifications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotifications.BackColor = System.Drawing.Color.Transparent
        Me.btnNotifications.FlatAppearance.BorderSize = 0
        Me.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifications.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNotifications.ForeColor = System.Drawing.Color.White
        Me.btnNotifications.Location = New System.Drawing.Point(840, 10)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(80, 35)
        Me.btnNotifications.TabIndex = 2
        Me.btnNotifications.Text = "🔔"
        Me.btnNotifications.UseVisualStyleBackColor = False
        '
        'lblHeaderUser
        '
        Me.lblHeaderUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderUser.ForeColor = System.Drawing.Color.White
        Me.lblHeaderUser.Location = New System.Drawing.Point(930, 10)
        Me.lblHeaderUser.Name = "lblHeaderUser"
        Me.lblHeaderUser.Size = New System.Drawing.Size(150, 35)
        Me.lblHeaderUser.TabIndex = 3
        Me.lblHeaderUser.Text = "👤 John Doe"
        Me.lblHeaderUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlHeaderLine
        '
        Me.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlHeaderLine.Location = New System.Drawing.Point(0, 52)
        Me.pnlHeaderLine.Name = "pnlHeaderLine"
        Me.pnlHeaderLine.Size = New System.Drawing.Size(1100, 3)
        Me.pnlHeaderLine.TabIndex = 4
        '
        'splitContainer
        '
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.Location = New System.Drawing.Point(0, 55)
        Me.splitContainer.Name = "splitContainer"
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.Controls.Add(Me.pnlSidebar)
        Me.splitContainer.Panel1MinSize = 180
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.pnlContent)
        Me.splitContainer.Size = New System.Drawing.Size(1100, 600)
        Me.splitContainer.SplitterDistance = 220
        Me.splitContainer.SplitterWidth = 1
        Me.splitContainer.TabIndex = 0
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.tlpSidebar)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 600)
        Me.pnlSidebar.TabIndex = 0
        '
        'tlpSidebar
        '
        Me.tlpSidebar.ColumnCount = 1
        Me.tlpSidebar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSidebar.Controls.Add(Me.btnDashboard, 0, 0)
        Me.tlpSidebar.Controls.Add(Me.btnHardware, 0, 1)
        Me.tlpSidebar.Controls.Add(Me.btnCategories, 0, 2)
        Me.tlpSidebar.Controls.Add(Me.btnUsers, 0, 3)
        Me.tlpSidebar.Controls.Add(Me.pnlSidebarSpacer, 0, 4)
        Me.tlpSidebar.Controls.Add(Me.btnLogout, 0, 5)
        Me.tlpSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSidebar.Location = New System.Drawing.Point(6, 6)
        Me.tlpSidebar.Name = "tlpSidebar"
        Me.tlpSidebar.RowCount = 6
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.Size = New System.Drawing.Size(208, 588)
        Me.tlpSidebar.TabIndex = 0
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(3, 3)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(202, 36)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "📊  Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnHardware
        '
        Me.btnHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHardware.FlatAppearance.BorderSize = 0
        Me.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHardware.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnHardware.ForeColor = System.Drawing.Color.White
        Me.btnHardware.Location = New System.Drawing.Point(3, 45)
        Me.btnHardware.Name = "btnHardware"
        Me.btnHardware.Size = New System.Drawing.Size(202, 36)
        Me.btnHardware.TabIndex = 1
        Me.btnHardware.Text = "💻  Hardware"
        Me.btnHardware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHardware.UseVisualStyleBackColor = True
        '
        'btnCategories
        '
        Me.btnCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCategories.FlatAppearance.BorderSize = 0
        Me.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategories.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCategories.ForeColor = System.Drawing.Color.White
        Me.btnCategories.Location = New System.Drawing.Point(3, 87)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(202, 36)
        Me.btnCategories.TabIndex = 2
        Me.btnCategories.Text = "🗂️  Categories"
        Me.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(3, 129)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(202, 36)
        Me.btnUsers.TabIndex = 3
        Me.btnUsers.Text = "👥  Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'pnlSidebarSpacer
        '
        Me.pnlSidebarSpacer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSidebarSpacer.Location = New System.Drawing.Point(3, 171)
        Me.pnlSidebarSpacer.Name = "pnlSidebarSpacer"
        Me.pnlSidebarSpacer.Size = New System.Drawing.Size(202, 372)
        Me.pnlSidebarSpacer.TabIndex = 4
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(3, 549)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(202, 36)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "🚪  Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlContent.Size = New System.Drawing.Size(879, 600)
        Me.pnlContent.TabIndex = 0
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.lblFooterLeft)
        Me.pnlFooter.Controls.Add(Me.lblFooterRight)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 655)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1100, 45)
        Me.pnlFooter.TabIndex = 2
        '
        'lblFooterLeft
        '
        Me.lblFooterLeft.AutoSize = True
        Me.lblFooterLeft.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFooterLeft.ForeColor = System.Drawing.Color.White
        Me.lblFooterLeft.Location = New System.Drawing.Point(20, 14)
        Me.lblFooterLeft.Name = "lblFooterLeft"
        Me.lblFooterLeft.Size = New System.Drawing.Size(230, 15)
        Me.lblFooterLeft.TabIndex = 0
        Me.lblFooterLeft.Text = "© 2026 HardwareTrack. All rights reserved."
        '
        'lblFooterRight
        '
        Me.lblFooterRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooterRight.AutoSize = True
        Me.lblFooterRight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFooterRight.ForeColor = System.Drawing.Color.White
        Me.lblFooterRight.Location = New System.Drawing.Point(772, 14)
        Me.lblFooterRight.Name = "lblFooterRight"
        Me.lblFooterRight.Size = New System.Drawing.Size(203, 15)
        Me.lblFooterRight.TabIndex = 1
        Me.lblFooterRight.Text = "Logged in as: John Doe | Role: Admin"
        '
        'tmrNotifications
        '
        Me.tmrNotifications.Enabled = True
        Me.tmrNotifications.Interval = 5000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.splitContainer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HardwareTrack - Inventory Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.tlpSidebar.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)
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
    Friend WithEvents btnCategories As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents pnlSidebarSpacer As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblFooterLeft As System.Windows.Forms.Label
    Friend WithEvents lblFooterRight As System.Windows.Forms.Label
    Friend WithEvents tmrNotifications As System.Windows.Forms.Timer
End Class