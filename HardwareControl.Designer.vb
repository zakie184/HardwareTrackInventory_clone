<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HardwareControl
    Inherits System.Windows.Forms.UserControl
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvHardware = New System.Windows.Forms.DataGridView()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMasterList = New System.Windows.Forms.Button()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnApprovals = New System.Windows.Forms.Button()
        Me.btnRequestReturn = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()

        CType(Me.dgvHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()

        Me.dgvHardware.AllowUserToAddRows = False
        Me.dgvHardware.BackgroundColor = System.Drawing.Color.White
        Me.dgvHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHardware.Location = New System.Drawing.Point(0, 70)
        Me.dgvHardware.MultiSelect = False
        Me.dgvHardware.Name = "dgvHardware"
        Me.dgvHardware.ReadOnly = True
        Me.dgvHardware.RowHeadersVisible = False
        Me.dgvHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHardware.Size = New System.Drawing.Size(1100, 330)

        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.pnlTop.Controls.Add(Me.lblCount)
        Me.pnlTop.Controls.Add(Me.btnRequestReturn)
        Me.pnlTop.Controls.Add(Me.btnApprovals)
        Me.pnlTop.Controls.Add(Me.btnDelete)
        Me.pnlTop.Controls.Add(Me.btnIssue)
        Me.pnlTop.Controls.Add(Me.btnRestock)
        Me.pnlTop.Controls.Add(Me.btnMasterList)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Size = New System.Drawing.Size(1100, 70)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 20)
        Me.lblTitle.Text = "Hardware List"

        Me.btnMasterList.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnMasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasterList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMasterList.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnMasterList.Location = New System.Drawing.Point(190, 18)
        Me.btnMasterList.Size = New System.Drawing.Size(90, 35)
        Me.btnMasterList.Text = "➕ New"
        Me.btnMasterList.UseVisualStyleBackColor = False

        Me.btnRestock.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestock.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnRestock.Location = New System.Drawing.Point(290, 18)
        Me.btnRestock.Size = New System.Drawing.Size(90, 35)
        Me.btnRestock.Text = "📥 Receive"
        Me.btnRestock.UseVisualStyleBackColor = False

        Me.btnIssue.BackColor = System.Drawing.Color.White
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnIssue.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnIssue.Location = New System.Drawing.Point(390, 18)
        Me.btnIssue.Size = New System.Drawing.Size(90, 35)
        Me.btnIssue.Text = "📤 Issue"
        Me.btnIssue.UseVisualStyleBackColor = False

        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(490, 18)
        Me.btnDelete.Size = New System.Drawing.Size(90, 35)
        Me.btnDelete.Text = "Toggle"
        Me.btnDelete.UseVisualStyleBackColor = False

        Me.btnRequestReturn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.btnRequestReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestReturn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRequestReturn.ForeColor = System.Drawing.Color.White
        Me.btnRequestReturn.Location = New System.Drawing.Point(590, 18)
        Me.btnRequestReturn.Size = New System.Drawing.Size(90, 35)
        Me.btnRequestReturn.Text = "↩️ Return"
        Me.btnRequestReturn.UseVisualStyleBackColor = False

        Me.btnApprovals.BackColor = System.Drawing.Color.FromArgb(241, 196, 15)
        Me.btnApprovals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprovals.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApprovals.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnApprovals.Location = New System.Drawing.Point(690, 18)
        Me.btnApprovals.Size = New System.Drawing.Size(130, 35)
        Me.btnApprovals.Text = "⚠️ Approvals Hub"
        Me.btnApprovals.UseVisualStyleBackColor = False

        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(950, 25)
        Me.lblCount.Text = "0 records found"

        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(236, 240, 241)
        Me.pnlDetails.Controls.Add(Me.lblStatus)
        Me.pnlDetails.Controls.Add(Me.lblQty)
        Me.pnlDetails.Controls.Add(Me.lblCategory)
        Me.pnlDetails.Controls.Add(Me.lblName)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDetails.Size = New System.Drawing.Size(1100, 100)

        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(15, 20)
        Me.lblName.Text = "Select an item"

        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(15, 50)
        Me.lblCategory.Text = "Category: -"

        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(200, 50)
        Me.lblQty.Text = "Qty: -"

        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(400, 50)
        Me.lblStatus.Text = "Status: -"

        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvHardware)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "HardwareControl"
        Me.Size = New System.Drawing.Size(1100, 500)
        CType(Me.dgvHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents dgvHardware As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnMasterList As System.Windows.Forms.Button
    Friend WithEvents btnRestock As System.Windows.Forms.Button
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnApprovals As System.Windows.Forms.Button
    Friend WithEvents btnRequestReturn As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class