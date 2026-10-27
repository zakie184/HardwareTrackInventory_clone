<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IssuanceForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblIssuedTo = New System.Windows.Forms.Label()
        Me.txtIssuedTo = New System.Windows.Forms.TextBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(600, 60)
        Me.pnlHeader.TabIndex = 0

        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(150, 25)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Issue Hardware"

        Me.lblIssuedTo.AutoSize = True
        Me.lblIssuedTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIssuedTo.Location = New System.Drawing.Point(20, 80)
        Me.lblIssuedTo.Name = "lblIssuedTo"
        Me.lblIssuedTo.Size = New System.Drawing.Size(100, 15)
        Me.lblIssuedTo.TabIndex = 1
        Me.lblIssuedTo.Text = "Issued To (Name)"

        Me.txtIssuedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIssuedTo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIssuedTo.Location = New System.Drawing.Point(20, 100)
        Me.txtIssuedTo.Name = "txtIssuedTo"
        Me.txtIssuedTo.Size = New System.Drawing.Size(300, 25)
        Me.txtIssuedTo.TabIndex = 2

        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.Location = New System.Drawing.Point(20, 140)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.Size = New System.Drawing.Size(560, 200)
        Me.dgvItems.TabIndex = 3

        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(20, 350)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(100, 30)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "➕ Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False

        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.Location = New System.Drawing.Point(130, 350)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(130, 30)
        Me.btnRemoveItem.TabIndex = 5
        Me.btnRemoveItem.Text = "🗑️ Remove Selected"
        Me.btnRemoveItem.UseVisualStyleBackColor = False

        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 400)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(600, 60)
        Me.pnlBottom.TabIndex = 6

        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnSave.Location = New System.Drawing.Point(350, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Issue Now"
        Me.btnSave.UseVisualStyleBackColor = False

        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.Location = New System.Drawing.Point(480, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        Me.ClientSize = New System.Drawing.Size(600, 460)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.txtIssuedTo)
        Me.Controls.Add(Me.lblIssuedTo)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "IssuanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Issue Hardware"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblIssuedTo As System.Windows.Forms.Label
    Friend WithEvents txtIssuedTo As System.Windows.Forms.TextBox
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class