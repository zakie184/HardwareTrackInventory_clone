<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApprovalsForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvReceivings = New System.Windows.Forms.DataGridView()
        Me.pnlRecvActions = New System.Windows.Forms.Panel()
        Me.btnRejectRecv = New System.Windows.Forms.Button()
        Me.btnApproveRecv = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvIssuances = New System.Windows.Forms.DataGridView()
        Me.pnlIssueActions = New System.Windows.Forms.Panel()
        Me.btnRejectIssue = New System.Windows.Forms.Button()
        Me.btnApproveIssue = New System.Windows.Forms.Button()

        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvReceivings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRecvActions.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvIssuances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIssueActions.SuspendLayout()
        Me.SuspendLayout()

        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0

        Me.TabPage1.Controls.Add(Me.dgvReceivings)
        Me.TabPage1.Controls.Add(Me.pnlRecvActions)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 420)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pending Receivings (IN)"
        Me.TabPage1.UseVisualStyleBackColor = True

        Me.dgvReceivings.AllowUserToAddRows = False
        Me.dgvReceivings.BackgroundColor = System.Drawing.Color.White
        Me.dgvReceivings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReceivings.Location = New System.Drawing.Point(3, 3)
        Me.dgvReceivings.Name = "dgvReceivings"
        Me.dgvReceivings.ReadOnly = True
        Me.dgvReceivings.RowHeadersVisible = False
        Me.dgvReceivings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReceivings.Size = New System.Drawing.Size(786, 344)
        Me.dgvReceivings.TabIndex = 0

        Me.pnlRecvActions.Controls.Add(Me.btnRejectRecv)
        Me.pnlRecvActions.Controls.Add(Me.btnApproveRecv)
        Me.pnlRecvActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRecvActions.Location = New System.Drawing.Point(3, 347)
        Me.pnlRecvActions.Name = "pnlRecvActions"
        Me.pnlRecvActions.Size = New System.Drawing.Size(786, 70)
        Me.pnlRecvActions.TabIndex = 1

        Me.btnApproveRecv.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnApproveRecv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveRecv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveRecv.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnApproveRecv.Location = New System.Drawing.Point(10, 15)
        Me.btnApproveRecv.Name = "btnApproveRecv"
        Me.btnApproveRecv.Size = New System.Drawing.Size(150, 40)
        Me.btnApproveRecv.TabIndex = 0
        Me.btnApproveRecv.Text = "✅ Approve & Add Stock"
        Me.btnApproveRecv.UseVisualStyleBackColor = False

        Me.btnRejectRecv.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnRejectRecv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRejectRecv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRejectRecv.ForeColor = System.Drawing.Color.White
        Me.btnRejectRecv.Location = New System.Drawing.Point(170, 15)
        Me.btnRejectRecv.Name = "btnRejectRecv"
        Me.btnRejectRecv.Size = New System.Drawing.Size(150, 40)
        Me.btnRejectRecv.TabIndex = 1
        Me.btnRejectRecv.Text = "❌ Reject"
        Me.btnRejectRecv.UseVisualStyleBackColor = False

        Me.TabPage2.Controls.Add(Me.dgvIssuances)
        Me.TabPage2.Controls.Add(Me.pnlIssueActions)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pending Issuances (OUT)"
        Me.TabPage2.UseVisualStyleBackColor = True

        Me.dgvIssuances.AllowUserToAddRows = False
        Me.dgvIssuances.BackgroundColor = System.Drawing.Color.White
        Me.dgvIssuances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIssuances.Location = New System.Drawing.Point(3, 3)
        Me.dgvIssuances.Name = "dgvIssuances"
        Me.dgvIssuances.ReadOnly = True
        Me.dgvIssuances.RowHeadersVisible = False
        Me.dgvIssuances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIssuances.Size = New System.Drawing.Size(786, 344)
        Me.dgvIssuances.TabIndex = 0

        Me.pnlIssueActions.Controls.Add(Me.btnRejectIssue)
        Me.pnlIssueActions.Controls.Add(Me.btnApproveIssue)
        Me.pnlIssueActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlIssueActions.Location = New System.Drawing.Point(3, 347)
        Me.pnlIssueActions.Name = "pnlIssueActions"
        Me.pnlIssueActions.Size = New System.Drawing.Size(786, 70)
        Me.pnlIssueActions.TabIndex = 1

        Me.btnApproveIssue.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnApproveIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveIssue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveIssue.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.btnApproveIssue.Location = New System.Drawing.Point(10, 15)
        Me.btnApproveIssue.Name = "btnApproveIssue"
        Me.btnApproveIssue.Size = New System.Drawing.Size(150, 40)
        Me.btnApproveIssue.TabIndex = 0
        Me.btnApproveIssue.Text = "✅ Approve"
        Me.btnApproveIssue.UseVisualStyleBackColor = False

        Me.btnRejectIssue.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnRejectIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRejectIssue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRejectIssue.ForeColor = System.Drawing.Color.White
        Me.btnRejectIssue.Location = New System.Drawing.Point(170, 15)
        Me.btnRejectIssue.Name = "btnRejectIssue"
        Me.btnRejectIssue.Size = New System.Drawing.Size(150, 40)
        Me.btnRejectIssue.TabIndex = 1
        Me.btnRejectIssue.Text = "❌ Reject"
        Me.btnRejectIssue.UseVisualStyleBackColor = False

        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ApprovalsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pending Approvals"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvReceivings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRecvActions.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvIssuances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIssueActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvReceivings As System.Windows.Forms.DataGridView
    Friend WithEvents pnlRecvActions As System.Windows.Forms.Panel
    Friend WithEvents btnApproveRecv As System.Windows.Forms.Button
    Friend WithEvents btnRejectRecv As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvIssuances As System.Windows.Forms.DataGridView
    Friend WithEvents pnlIssueActions As System.Windows.Forms.Panel
    Friend WithEvents btnApproveIssue As System.Windows.Forms.Button
    Friend WithEvents btnRejectIssue As System.Windows.Forms.Button
End Class