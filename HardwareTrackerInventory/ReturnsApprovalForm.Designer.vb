<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnsApprovalForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvReturns = New System.Windows.Forms.DataGridView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnWriteOff = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 60)
        Me.pnlHeader.TabIndex = 0

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Return Approvals"

        ' dgvReturns
        Me.dgvReturns.AllowUserToAddRows = False
        Me.dgvReturns.AllowUserToDeleteRows = False
        Me.dgvReturns.BackgroundColor = System.Drawing.Color.White
        Me.dgvReturns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReturns.Location = New System.Drawing.Point(0, 60)
        Me.dgvReturns.Name = "dgvReturns"
        Me.dgvReturns.ReadOnly = True
        Me.dgvReturns.RowHeadersVisible = False
        Me.dgvReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturns.Size = New System.Drawing.Size(800, 290)
        Me.dgvReturns.TabIndex = 1

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Controls.Add(Me.btnWriteOff)
        Me.pnlBottom.Controls.Add(Me.btnApprove)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 350)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(800, 70)
        Me.pnlBottom.TabIndex = 2

        ' btnApprove
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApprove.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnApprove.Location = New System.Drawing.Point(15, 15)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(180, 40)
        Me.btnApprove.TabIndex = 0
        Me.btnApprove.Text = "✅ Approve (Good Condition)"
        Me.btnApprove.UseVisualStyleBackColor = False

        ' btnWriteOff
        Me.btnWriteOff.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnWriteOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWriteOff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnWriteOff.ForeColor = System.Drawing.Color.White
        Me.btnWriteOff.Location = New System.Drawing.Point(205, 15)
        Me.btnWriteOff.Name = "btnWriteOff"
        Me.btnWriteOff.Size = New System.Drawing.Size(180, 40)
        Me.btnWriteOff.TabIndex = 1
        Me.btnWriteOff.Text = "🗑️ Write-Off (Defective)"
        Me.btnWriteOff.UseVisualStyleBackColor = False

        ' btnClose
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(685, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 40)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True

        ' ReturnsApprovalForm
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(Me.dgvReturns)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "ReturnsApprovalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Return Approvals"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvReturns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgvReturns As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents btnWriteOff As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class