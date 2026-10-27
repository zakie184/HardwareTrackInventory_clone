<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.lblHeaderUser = New System.Windows.Forms.Label()
        Me.btnHeaderLogout = New System.Windows.Forms.Button()
        Me.pnlHeaderLine = New System.Windows.Forms.Panel()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.tlpSidebar = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnHardware = New System.Windows.Forms.Button()
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

        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 75) ' BAGONG KULAY
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Controls.Add(Me.btnNotifications)
        Me.pnlHeader.Controls.Add(Me.lblHeaderUser)
        Me.pnlHeader.Controls.Add(Me.btnHeaderLogout)
        Me.pnlHeader.Controls.Add(Me.pnlHeaderLine)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 55)

        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblHeaderTitle.Text = "🛠️ HardwareTrack"

        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.lblHeaderSub.Location = New System.Drawing.Point(22, 33)

        Me.btnNotifications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotifications.BackColor = System.Drawing.Color.Transparent
        Me.btnNotifications.FlatAppearance.BorderSize = 0
        Me.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifications.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnNotifications.ForeColor = System.Drawing.Color.White
        Me.btnNotifications.Location = New System.Drawing.Point(730, 10)
        Me.btnNotifications.Size = New System.Drawing.Size(80, 35)
        Me.btnNotifications.Text = "🔔"
        Me.btnNotifications.UseVisualStyleBackColor = False

        Me.lblHeaderUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderUser.ForeColor = System.Drawing.Color.White
        Me.lblHeaderUser.Location = New System.Drawing.Point(820, 10)
        Me.lblHeaderUser.Size = New System.Drawing.Size(200, 35)
        Me.lblHeaderUser.Text = "👤 John Doe"
        Me.lblHeaderUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.btnHeaderLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHeaderLogout.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnHeaderLogout.FlatAppearance.BorderSize = 0
        Me.btnHeaderLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeaderLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHeaderLogout.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75) ' BAGONG KULAY
        Me.btnHeaderLogout.Location = New System.Drawing.Point(1030, 10)
        Me.btnHeaderLogout.Size = New System.Drawing.Size(55, 35)
        Me.btnHeaderLogout.Text = "🚪"
        Me.btnHeaderLogout.UseVisualStyleBackColor = False

        Me.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlHeaderLine.Size = New System.Drawing.Size(1100, 3)

        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.Location = New System.Drawing.Point(0, 55)
        Me.splitContainer.Panel1.Controls.Add(Me.pnlSidebar)
        Me.splitContainer.Panel1MinSize = 180
        Me.splitContainer.Panel2.Controls.Add(Me.pnlContent)
        Me.splitContainer.Size = New System.Drawing.Size(1100, 600)
        Me.splitContainer.SplitterDistance = 220
        Me.splitContainer.SplitterWidth = 1

        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(26, 54, 75) ' BAGONG KULAY
        Me.pnlSidebar.Controls.Add(Me.tlpSidebar)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(6)

        Me.tlpSidebar.ColumnCount = 1
        Me.tlpSidebar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSidebar.Controls.Add(Me.btnDashboard, 0, 0)
        Me.tlpSidebar.Controls.Add(Me.btnHardware, 0, 1)
        Me.tlpSidebar.Controls.Add(Me.btnUsers, 0, 2)
        Me.tlpSidebar.Controls.Add(Me.pnlSidebarSpacer, 0, 3)
        Me.tlpSidebar.Controls.Add(Me.btnLogout, 0, 4)
        Me.tlpSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSidebar.RowCount = 5
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSidebar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))

        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75) ' BAGONG KULAY
        Me.btnDashboard.Text = "📊  Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False

        Me.btnHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHardware.FlatAppearance.BorderSize = 0
        Me.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHardware.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnHardware.ForeColor = System.Drawing.Color.White
        Me.btnHardware.Text = "💻  Hardware"
        Me.btnHardware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHardware.UseVisualStyleBackColor = True

        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Text = "👥  Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.UseVisualStyleBackColor = True

        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnLogout.Text = "🚪  Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True

        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(240, 242, 245)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(15)

        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(26, 54, 75) ' BAGONG KULAY
        Me.pnlFooter.Controls.Add(Me.lblFooterLeft)
        Me.pnlFooter.Controls.Add(Me.lblFooterRight)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Size = New System.Drawing.Size(1100, 45)

        Me.lblFooterLeft.AutoSize = True
        Me.lblFooterLeft.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFooterLeft.ForeColor = System.Drawing.Color.White
        Me.lblFooterLeft.Location = New System.Drawing.Point(20, 14)
        Me.lblFooterLeft.Text = "© 2026 HardwareTrack. All rights reserved."

        Me.lblFooterRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooterRight.AutoSize = True
        Me.lblFooterRight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFooterRight.ForeColor = System.Drawing.Color.White
        Me.lblFooterRight.Location = New System.Drawing.Point(890, 14)
        Me.lblFooterRight.Text = "Logged in as: John Doe | Role: Admin"

        Me.tmrNotifications.Enabled = True
        Me.tmrNotifications.Interval = 5000

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
    Friend WithEvents btnHeaderLogout As System.Windows.Forms.Button
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