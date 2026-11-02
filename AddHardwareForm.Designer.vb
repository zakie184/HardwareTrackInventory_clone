<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddHardwareForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(420, 50)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Text = "➕ Add Hardware"

        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(20, 70)
        Me.lblName.Text = "Item Name"

        Me.txtName.Location = New System.Drawing.Point(20, 90)
        Me.txtName.Size = New System.Drawing.Size(380, 23)

        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(20, 130)
        Me.lblCategory.Text = "Category"

        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbCategory.Location = New System.Drawing.Point(20, 150)
        Me.cmbCategory.Size = New System.Drawing.Size(380, 23)

        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(20, 190)
        Me.lblBranch.Text = "Branch"

        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.Location = New System.Drawing.Point(20, 210)
        Me.cmbBranch.Size = New System.Drawing.Size(230, 23)

        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(270, 190)
        Me.lblQty.Text = "Initial Quantity"

        Me.numQty.Location = New System.Drawing.Point(270, 210)
        Me.numQty.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numQty.Size = New System.Drawing.Size(130, 23)

        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnSave.Location = New System.Drawing.Point(160, 270)
        Me.btnSave.Size = New System.Drawing.Size(110, 35)
        Me.btnSave.Text = "Save Item"
        Me.btnSave.UseVisualStyleBackColor = False

        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(290, 270)
        Me.btnCancel.Size = New System.Drawing.Size(110, 35)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        Me.ClientSize = New System.Drawing.Size(420, 330)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "AddHardwareForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Hardware"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblBranch As System.Windows.Forms.Label
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class