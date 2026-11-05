<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceivingForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.lblLoadRequest = New System.Windows.Forms.Label()
        Me.cmbLoadRequest = New System.Windows.Forms.ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchItem = New System.Windows.Forms.TextBox()
        Me.lblItemsTitle = New System.Windows.Forms.Label()
        Me.lblAutoFill = New System.Windows.Forms.Label()
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
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(800, 70)

        ' lblHeaderTitle
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblHeaderTitle.Text = "Receive Delivery"

        ' lblHeaderSub
        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.lblHeaderSub.Location = New System.Drawing.Point(22, 42)
        Me.lblHeaderSub.Text = "Create or load a pending delivery"

        ' lblLoadRequest
        Me.lblLoadRequest.AutoSize = True
        Me.lblLoadRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoadRequest.Location = New System.Drawing.Point(20, 90)
        Me.lblLoadRequest.Text = "Load Pending Request"

        ' cmbLoadRequest
        Me.cmbLoadRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoadRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbLoadRequest.Location = New System.Drawing.Point(20, 110)
        Me.cmbLoadRequest.Size = New System.Drawing.Size(250, 25)

        ' lblSupplier
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplier.Location = New System.Drawing.Point(290, 90)
        Me.lblSupplier.Text = "Supplier"

        ' cmbSupplier
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSupplier.Location = New System.Drawing.Point(290, 110)
        Me.cmbSupplier.Size = New System.Drawing.Size(250, 25)

        ' lblSearch
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(560, 90)
        Me.lblSearch.Text = "Search Item"

        ' txtSearchItem
        Me.txtSearchItem.Location = New System.Drawing.Point(560, 110)
        Me.txtSearchItem.Size = New System.Drawing.Size(200, 25)
        Me.txtSearchItem.Text = "Type to filter dropdown..."

        ' lblItemsTitle
        Me.lblItemsTitle.AutoSize = True
        Me.lblItemsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemsTitle.Location = New System.Drawing.Point(20, 150)
        Me.lblItemsTitle.Text = "Items to Receive"

        ' lblAutoFill
        Me.lblAutoFill.AutoSize = True
        Me.lblAutoFill.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAutoFill.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.lblAutoFill.Location = New System.Drawing.Point(180, 152)
        Me.lblAutoFill.Text = "⚠️ Low Stock Items are automatically listed below."

        ' dgvItems
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.Location = New System.Drawing.Point(20, 180)
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.Size = New System.Drawing.Size(740, 210)

        ' btnAddItem
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(20, 405)
        Me.btnAddItem.Size = New System.Drawing.Size(120, 30)
        Me.btnAddItem.Text = "➕ Add Item"

        ' btnRemoveItem
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.Location = New System.Drawing.Point(150, 405)
        Me.btnRemoveItem.Size = New System.Drawing.Size(130, 30)
        Me.btnRemoveItem.Text = "🗑️ Remove Selected"

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 450)
        Me.pnlBottom.Size = New System.Drawing.Size(800, 70)

        ' btnSave
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnSave.Location = New System.Drawing.Point(500, 15)
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.Text = "Submit Request"

        ' btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(660, 15)
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.Text = "Cancel"

        ' ReceivingForm
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.lblAutoFill)
        Me.Controls.Add(Me.lblItemsTitle)
        Me.Controls.Add(Me.txtSearchItem)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.cmbLoadRequest)
        Me.Controls.Add(Me.lblLoadRequest)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "ReceivingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receive Delivery"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoadRequest As System.Windows.Forms.Label
    Friend WithEvents cmbLoadRequest As System.Windows.Forms.ComboBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchItem As System.Windows.Forms.TextBox
    Friend WithEvents lblItemsTitle As System.Windows.Forms.Label
    Friend WithEvents lblAutoFill As System.Windows.Forms.Label
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class