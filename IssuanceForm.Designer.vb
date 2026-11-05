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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchItem = New System.Windows.Forms.TextBox()
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

        ' pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(600, 60)

        ' lblHeaderTitle
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblHeaderTitle.Text = "📤 Issue Hardware"

        ' lblIssuedTo
        Me.lblIssuedTo.AutoSize = True
        Me.lblIssuedTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIssuedTo.Location = New System.Drawing.Point(20, 80)
        Me.lblIssuedTo.Text = "Customer / Issued To"

        ' txtIssuedTo
        Me.txtIssuedTo.Location = New System.Drawing.Point(20, 100)
        Me.txtIssuedTo.Size = New System.Drawing.Size(250, 25)

        ' lblSearch
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(290, 80)
        Me.lblSearch.Text = "Search Item to Add"

        ' txtSearchItem
        Me.txtSearchItem.Location = New System.Drawing.Point(290, 100)
        Me.txtSearchItem.Size = New System.Drawing.Size(290, 25)
        Me.txtSearchItem.Text = "Type to filter dropdown..."

        ' dgvItems
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.Location = New System.Drawing.Point(20, 140)
        Me.dgvItems.Size = New System.Drawing.Size(560, 200)
        Me.dgvItems.RowHeadersVisible = False

        ' btnAddItem
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(20, 350)
        Me.btnAddItem.Size = New System.Drawing.Size(100, 30)
        Me.btnAddItem.Text = "➕ Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False

        ' btnRemoveItem
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Location = New System.Drawing.Point(130, 350)
        Me.btnRemoveItem.Size = New System.Drawing.Size(130, 30)
        Me.btnRemoveItem.Text = "🗑️ Remove Selected"

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 400)
        Me.pnlBottom.Size = New System.Drawing.Size(600, 60)

        ' btnSave
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnSave.Location = New System.Drawing.Point(350, 10)
        Me.btnSave.Size = New System.Drawing.Size(120, 40)
        Me.btnSave.Text = "Issue Now"

        ' btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(480, 10)
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.Text = "Cancel"

        ' IssuanceForm
        Me.ClientSize = New System.Drawing.Size(600, 460)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.txtSearchItem)
        Me.Controls.Add(Me.lblSearch)
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
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchItem As System.Windows.Forms.TextBox
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class