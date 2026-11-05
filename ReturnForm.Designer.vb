<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
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
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(400, 50)

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Text = "↩️ Return Item"

        ' lblSearch
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 60)
        Me.lblSearch.Text = "Search Item / Issued To"

        ' txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(20, 80)
        Me.txtSearch.Size = New System.Drawing.Size(360, 23)
        Me.txtSearch.Text = "Type to filter dropdown..."

        ' lblIssuance
        Me.lblIssuance.AutoSize = True
        Me.lblIssuance.Location = New System.Drawing.Point(20, 115)
        Me.lblIssuance.Text = "Select Sold Item"

        ' cmbIssuance
        Me.cmbIssuance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIssuance.Location = New System.Drawing.Point(20, 135)
        Me.cmbIssuance.Size = New System.Drawing.Size(360, 23)

        ' lblQty
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(20, 170)
        Me.lblQty.Text = "Quantity to Return"

        ' numQty
        Me.numQty.Location = New System.Drawing.Point(20, 190)
        Me.numQty.Size = New System.Drawing.Size(100, 23)

        ' chkDefective
        Me.chkDefective.AutoSize = True
        Me.chkDefective.Location = New System.Drawing.Point(20, 225)
        Me.chkDefective.Size = New System.Drawing.Size(150, 19)
        Me.chkDefective.Text = "Item is Defective/Broken"

        ' btnSave
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnSave.Location = New System.Drawing.Point(150, 270)
        Me.btnSave.Size = New System.Drawing.Size(110, 35)
        Me.btnSave.Text = "Submit Return"

        ' btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(270, 270)
        Me.btnCancel.Size = New System.Drawing.Size(110, 35)
        Me.btnCancel.Text = "Cancel"

        ' ReturnForm
        Me.ClientSize = New System.Drawing.Size(400, 340)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkDefective)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.cmbIssuance)
        Me.Controls.Add(Me.lblIssuance)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.pnlHeader)
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
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblIssuance As System.Windows.Forms.Label
    Friend WithEvents cmbIssuance As System.Windows.Forms.ComboBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDefective As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class