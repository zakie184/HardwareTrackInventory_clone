<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()

        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()

        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.pnlLogin.Controls.Add(Me.lblIcon)
        Me.pnlLogin.Controls.Add(Me.lblTitle)
        Me.pnlLogin.Controls.Add(Me.lblSubTitle)
        Me.pnlLogin.Controls.Add(Me.lblUsername)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.btnCancel)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogin.Size = New System.Drawing.Size(420, 420)

        Me.lblIcon.AutoSize = True
        Me.lblIcon.Font = New System.Drawing.Font("Segoe UI", 48.0!)
        Me.lblIcon.ForeColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.lblIcon.Location = New System.Drawing.Point(152, 15)
        Me.lblIcon.Text = "🛠️"

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(85, 105)
        Me.lblTitle.Text = "HardwareTrack"

        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.lblSubTitle.Location = New System.Drawing.Point(107, 148)
        Me.lblSubTitle.Text = "Inventory Management System"

        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(60, 200)
        Me.lblUsername.Text = "USERNAME"

        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(240, 242, 245)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(60, 220)
        Me.txtUsername.Size = New System.Drawing.Size(300, 25)

        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(60, 260)
        Me.lblPassword.Text = "PASSWORD"

        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(240, 242, 245)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(60, 280)
        Me.txtPassword.Size = New System.Drawing.Size(300, 25)
        Me.txtPassword.UseSystemPasswordChar = True

        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnLogin.Location = New System.Drawing.Point(60, 325)
        Me.btnLogin.Size = New System.Drawing.Size(145, 40)
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False

        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(215, 325)
        Me.btnCancel.Size = New System.Drawing.Size(145, 40)
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True

        Me.AcceptButton = Me.btnLogin
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(420, 420)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HardwareTrack - Login"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblIcon As System.Windows.Forms.Label
End Class