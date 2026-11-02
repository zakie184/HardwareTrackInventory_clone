<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotificationForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstNotifications = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(450, 50)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Text = "🔔 Notifications"

        Me.lstNotifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstNotifications.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lstNotifications.FormattingEnabled = True
        Me.lstNotifications.ItemHeight = 17

        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnClose.Size = New System.Drawing.Size(450, 40)
        Me.btnClose.Text = "Mark as Read & Close"
        Me.btnClose.UseVisualStyleBackColor = False

        Me.ClientSize = New System.Drawing.Size(450, 390)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstNotifications)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "NotificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notifications"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lstNotifications As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class