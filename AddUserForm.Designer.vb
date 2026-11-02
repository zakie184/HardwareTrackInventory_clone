<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUserForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(400, 50)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Text = "Add New User"

        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(20, 70)
        Me.lblUsername.Text = "Username"

        Me.txtUsername.Location = New System.Drawing.Point(20, 90)
        Me.txtUsername.Size = New System.Drawing.Size(360, 23)

        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 125)
        Me.lblPassword.Text = "Password"

        Me.txtPassword.Location = New System.Drawing.Point(20, 145)
        Me.txtPassword.Size = New System.Drawing.Size(360, 23)
        Me.txtPassword.UseSystemPasswordChar = True

        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(20, 180)
        Me.lblFullName.Text = "Full Name"

        Me.txtFullName.Location = New System.Drawing.Point(20, 200)
        Me.txtFullName.Size = New System.Drawing.Size(360, 23)

        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(20, 235)
        Me.lblRole.Text = "Role"

        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.Location = New System.Drawing.Point(20, 255)
        Me.cmbRole.Size = New System.Drawing.Size(170, 23)

        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(210, 235)
        Me.lblBranch.Text = "Branch"

        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.Location = New System.Drawing.Point(210, 255)
        Me.cmbBranch.Size = New System.Drawing.Size(170, 23)

        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(26, 54, 75)
        Me.btnSave.Location = New System.Drawing.Point(150, 310)
        Me.btnSave.Size = New System.Drawing.Size(110, 35)
        Me.btnSave.Text = "Save User"
        Me.btnSave.UseVisualStyleBackColor = False

        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(270, 310)
        Me.btnCancel.Size = New System.Drawing.Size(110, 35)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True

        Me.ClientSize = New System.Drawing.Size(400, 370)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "AddUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add User"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblBranch As System.Windows.Forms.Label
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class