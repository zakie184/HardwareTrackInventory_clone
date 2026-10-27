<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIssuance = New System.Windows.Forms.Label()
        Me.cmbIssuance = New System.Windows.Forms.ComboBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.chkDefective = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(400, 50)
        Me.pnlHeader.TabIndex = 0

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(150, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Return Item"

        ' lblIssuance
        Me.lblIssuance.AutoSize = True
        Me.lblIssuance.Location = New System.Drawing.Point(20, 70)
        Me.lblIssuance.Name = "lblIssuance"
        Me.lblIssuance.Size = New System.Drawing.Size(100, 15)
        Me.lblIssuance.TabIndex = 1
        Me.lblIssuance.Text = "Select Issued Item"

        ' cmbIssuance
        Me.cmbIssuance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIssuance.Location = New System.Drawing.Point(20, 90)
        Me.cmbIssuance.Name = "cmbIssuance"
        Me.cmbIssuance.Size = New System.Drawing.Size(360, 23)
        Me.cmbIssuance.TabIndex = 2

        ' lblQty
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(20, 130)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(100, 15)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "Quantity to Return"

        ' numQty
        Me.numQty.Location = New System.Drawing.Point(20, 150)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(100, 23)
        Me.numQty.TabIndex = 4

        ' chkDefective
        Me.chkDefective.AutoSize = True
        Me.chkDefective.Location = New System.Drawing.Point(20, 190)
        Me.chkDefective.Name = "chkDefective"
        Me.chkDefective.Size = New System.Drawing.Size(150, 19)
        Me.chkDefective.TabIndex = 5
        Me.chkDefective.Text = "Item is Defective/Broken"
        Me.chkDefective.UseVisualStyleBackColor = True

        ' btnSave
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnSave.Location = New System.Drawing.Point(150, 240)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 35)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Submit Return"
        Me.btnSave.UseVisualStyleBackColor = False

        ' btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(270, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 35)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        ' ReturnForm
        Me.AcceptButton = Me.btnSave
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkDefective)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.cmbIssuance)
        Me.Controls.Add(Me.lblIssuance)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReturnForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Return Item"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblIssuance As System.Windows.Forms.Label
    Friend WithEvents cmbIssuance As System.Windows.Forms.ComboBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDefective As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class