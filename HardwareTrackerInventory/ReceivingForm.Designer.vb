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
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblItemsTitle = New System.Windows.Forms.Label()
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
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.lblHeaderSub)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(760, 70)
        Me.pnlHeader.TabIndex = 0

        ' lblHeaderTitle
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(160, 25)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Receive Delivery"

        ' lblHeaderSub
        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.lblHeaderSub.Location = New System.Drawing.Point(22, 42)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(250, 15)
        Me.lblHeaderSub.TabIndex = 1
        Me.lblHeaderSub.Text = "Administrator — stock will be added immediately"

        ' lblSupplier
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplier.Location = New System.Drawing.Point(20, 90)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(58, 15)
        Me.lblSupplier.TabIndex = 2
        Me.lblSupplier.Text = "Supplier"

        ' cmbSupplier
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(20, 110)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(300, 25)
        Me.cmbSupplier.TabIndex = 3

        ' lblNotes
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.Location = New System.Drawing.Point(350, 90)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(42, 15)
        Me.lblNotes.TabIndex = 4
        Me.lblNotes.Text = "Notes"

        ' txtNotes
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNotes.Location = New System.Drawing.Point(350, 110)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(390, 25)
        Me.txtNotes.TabIndex = 5

        ' lblItemsTitle
        Me.lblItemsTitle.AutoSize = True
        Me.lblItemsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemsTitle.Location = New System.Drawing.Point(20, 160)
        Me.lblItemsTitle.Name = "lblItemsTitle"
        Me.lblItemsTitle.Size = New System.Drawing.Size(120, 19)
        Me.lblItemsTitle.TabIndex = 6
        Me.lblItemsTitle.Text = "Items to Receive"

        ' dgvItems
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.Location = New System.Drawing.Point(20, 185)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.Size = New System.Drawing.Size(720, 250)
        Me.dgvItems.TabIndex = 7

        ' btnAddItem
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(20, 445)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(120, 30)
        Me.btnAddItem.TabIndex = 8
        Me.btnAddItem.Text = "➕ Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False

        ' btnRemoveItem
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.Location = New System.Drawing.Point(150, 445)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(130, 30)
        Me.btnRemoveItem.TabIndex = 9
        Me.btnRemoveItem.Text = "🗑️ Remove Selected"
        Me.btnRemoveItem.UseVisualStyleBackColor = False

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 490)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(760, 70)
        Me.pnlBottom.TabIndex = 10

        ' btnSave
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnSave.Location = New System.Drawing.Point(480, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Receive Now"
        Me.btnSave.UseVisualStyleBackColor = False

        ' btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.Location = New System.Drawing.Point(640, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        ' ReceivingForm
        Me.ClientSize = New System.Drawing.Size(760, 560)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.lblItemsTitle)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.lblSupplier)
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
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblItemsTitle As System.Windows.Forms.Label
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class