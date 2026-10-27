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
        Me.btnApproveReturns = New System.Windows.Forms.Button()
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

        ' dgvHardware
        Me.dgvHardware.AllowUserToAddRows = False
        Me.dgvHardware.AllowUserToDeleteRows = False
        Me.dgvHardware.BackgroundColor = System.Drawing.Color.White
        Me.dgvHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHardware.Location = New System.Drawing.Point(0, 70)
        Me.dgvHardware.MultiSelect = False
        Me.dgvHardware.Name = "dgvHardware"
        Me.dgvHardware.ReadOnly = True
        Me.dgvHardware.RowHeadersVisible = False
        Me.dgvHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHardware.Size = New System.Drawing.Size(1100, 330)
        Me.dgvHardware.TabIndex = 1

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.pnlTop.Controls.Add(Me.lblCount)
        Me.pnlTop.Controls.Add(Me.btnApproveReturns)
        Me.pnlTop.Controls.Add(Me.btnRequestReturn)
        Me.pnlTop.Controls.Add(Me.btnApprovals)
        Me.pnlTop.Controls.Add(Me.btnDelete)
        Me.pnlTop.Controls.Add(Me.btnIssue)
        Me.pnlTop.Controls.Add(Me.btnRestock)
        Me.pnlTop.Controls.Add(Me.btnMasterList)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1100, 70)
        Me.pnlTop.TabIndex = 0

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(160, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Hardware List"

        ' btnMasterList
        Me.btnMasterList.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnMasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasterList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMasterList.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnMasterList.Location = New System.Drawing.Point(190, 18)
        Me.btnMasterList.Name = "btnMasterList"
        Me.btnMasterList.Size = New System.Drawing.Size(90, 35)
        Me.btnMasterList.TabIndex = 1
        Me.btnMasterList.Text = "➕ New"
        Me.btnMasterList.UseVisualStyleBackColor = False

        ' btnRestock
        Me.btnRestock.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestock.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnRestock.Location = New System.Drawing.Point(290, 18)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(90, 35)
        Me.btnRestock.TabIndex = 2
        Me.btnRestock.Text = "📥 Receive"
        Me.btnRestock.UseVisualStyleBackColor = False

        ' btnIssue
        Me.btnIssue.BackColor = System.Drawing.Color.White
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnIssue.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnIssue.Location = New System.Drawing.Point(390, 18)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(90, 35)
        Me.btnIssue.TabIndex = 3
        Me.btnIssue.Text = "📤 Issue"
        Me.btnIssue.UseVisualStyleBackColor = False

        ' btnDelete
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(490, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 35)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Toggle Status"
        Me.btnDelete.UseVisualStyleBackColor = False

        ' btnApprovals
        Me.btnApprovals.BackColor = System.Drawing.Color.FromArgb(241, 196, 15)
        Me.btnApprovals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprovals.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApprovals.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnApprovals.Location = New System.Drawing.Point(590, 18)
        Me.btnApprovals.Name = "btnApprovals"
        Me.btnApprovals.Size = New System.Drawing.Size(100, 35)
        Me.btnApprovals.TabIndex = 5
        Me.btnApprovals.Text = "⚠️ Approvals"
        Me.btnApprovals.UseVisualStyleBackColor = False

        ' btnRequestReturn
        Me.btnRequestReturn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.btnRequestReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestReturn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRequestReturn.ForeColor = System.Drawing.Color.White
        Me.btnRequestReturn.Location = New System.Drawing.Point(700, 18)
        Me.btnRequestReturn.Name = "btnRequestReturn"
        Me.btnRequestReturn.Size = New System.Drawing.Size(100, 35)
        Me.btnRequestReturn.TabIndex = 6
        Me.btnRequestReturn.Text = "↩️ Return"
        Me.btnRequestReturn.UseVisualStyleBackColor = False

        ' btnApproveReturns
        Me.btnApproveReturns.BackColor = System.Drawing.Color.FromArgb(155, 89, 182)
        Me.btnApproveReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveReturns.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveReturns.ForeColor = System.Drawing.Color.White
        Me.btnApproveReturns.Location = New System.Drawing.Point(810, 18)
        Me.btnApproveReturns.Name = "btnApproveReturns"
        Me.btnApproveReturns.Size = New System.Drawing.Size(130, 35)
        Me.btnApproveReturns.TabIndex = 7
        Me.btnApproveReturns.Text = "🔄 Manage Returns"
        Me.btnApproveReturns.UseVisualStyleBackColor = False

        ' lblCount
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(950, 25)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(120, 19)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "0 records found"

        ' pnlDetails
        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(236, 240, 241)
        Me.pnlDetails.Controls.Add(Me.lblStatus)
        Me.pnlDetails.Controls.Add(Me.lblQty)
        Me.pnlDetails.Controls.Add(Me.lblCategory)
        Me.pnlDetails.Controls.Add(Me.lblName)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDetails.Location = New System.Drawing.Point(0, 400)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(1100, 100)
        Me.pnlDetails.TabIndex = 2

        ' lblName
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(15, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Select an item"

        ' lblCategory
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCategory.Location = New System.Drawing.Point(15, 50)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(70, 15)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "Category: -"

        ' lblQty
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblQty.Location = New System.Drawing.Point(200, 50)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(40, 15)
        Me.lblQty.TabIndex = 2
        Me.lblQty.Text = "Qty: -"

        ' lblStatus
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(400, 50)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 15)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status: -"

        ' HardwareControl
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
    Friend WithEvents btnApproveReturns As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class