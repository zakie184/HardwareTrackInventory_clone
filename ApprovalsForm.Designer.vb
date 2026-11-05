<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApprovalsForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvReceivings = New System.Windows.Forms.DataGridView()
        Me.lblRecvItemsTitle = New System.Windows.Forms.Label()
        Me.dgvRecvItems = New System.Windows.Forms.DataGridView()
        Me.pnlRecvActions = New System.Windows.Forms.Panel()
        Me.btnRejectRecv = New System.Windows.Forms.Button()
        Me.btnApproveRecv = New System.Windows.Forms.Button()
        Me.TabPageIssuances = New System.Windows.Forms.TabPage()
        Me.dgvIssuances = New System.Windows.Forms.DataGridView()
        Me.pnlIssActions = New System.Windows.Forms.Panel()
        Me.btnRejectIss = New System.Windows.Forms.Button()
        Me.btnApproveIss = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvReturns = New System.Windows.Forms.DataGridView()
        Me.pnlReturnActions = New System.Windows.Forms.Panel()
        Me.btnWriteOff = New System.Windows.Forms.Button()
        Me.btnApproveReturn = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchTitle = New System.Windows.Forms.Label()

        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvReceivings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRecvActions.SuspendLayout()
        Me.TabPageIssuances.SuspendLayout()
        CType(Me.dgvIssuances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIssActions.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReturnActions.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()

        ' pnlSearch
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(240, 242, 245)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.lblSearchTitle)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(850, 50)
        Me.pnlSearch.TabIndex = 1

        ' lblSearchTitle
        Me.lblSearchTitle.AutoSize = True
        Me.lblSearchTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchTitle.Location = New System.Drawing.Point(15, 16)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(105, 15)
        Me.lblSearchTitle.TabIndex = 0
        Me.lblSearchTitle.Text = "Search Requests:"

        ' txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(126, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 25)
        Me.txtSearch.TabIndex = 1

        ' TabControl1
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPageIssuances)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Size = New System.Drawing.Size(850, 500)

        ' TabPage1 (Receivings)
        Me.TabPage1.Controls.Add(Me.dgvRecvItems)
        Me.TabPage1.Controls.Add(Me.lblRecvItemsTitle)
        Me.TabPage1.Controls.Add(Me.dgvReceivings)
        Me.TabPage1.Controls.Add(Me.pnlRecvActions)
        Me.TabPage1.Text = "Pending Deliveries (IN)"
        Me.TabPage1.UseVisualStyleBackColor = True

        Me.dgvReceivings.AllowUserToAddRows = False
        Me.dgvReceivings.BackgroundColor = System.Drawing.Color.White
        Me.dgvReceivings.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvReceivings.ReadOnly = True
        Me.dgvReceivings.RowHeadersVisible = False
        Me.dgvReceivings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReceivings.Size = New System.Drawing.Size(840, 200)

        Me.lblRecvItemsTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRecvItemsTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecvItemsTitle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241)
        Me.lblRecvItemsTitle.Text = "   📦 Items inside this Delivery:"
        Me.lblRecvItemsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRecvItemsTitle.Size = New System.Drawing.Size(840, 25)

        Me.dgvRecvItems.AllowUserToAddRows = False
        Me.dgvRecvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecvItems.ReadOnly = True
        Me.dgvRecvItems.RowHeadersVisible = False
        Me.dgvRecvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.pnlRecvActions.Controls.Add(Me.btnRejectRecv)
        Me.pnlRecvActions.Controls.Add(Me.btnApproveRecv)
        Me.pnlRecvActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRecvActions.Size = New System.Drawing.Size(840, 60)

        Me.btnApproveRecv.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnApproveRecv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveRecv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveRecv.Text = "✅ Approve & Add Stock"
        Me.btnApproveRecv.Size = New System.Drawing.Size(150, 40)
        Me.btnApproveRecv.Location = New System.Drawing.Point(10, 10)

        Me.btnRejectRecv.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnRejectRecv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRejectRecv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRejectRecv.ForeColor = System.Drawing.Color.White
        Me.btnRejectRecv.Text = "❌ Reject"
        Me.btnRejectRecv.Size = New System.Drawing.Size(150, 40)
        Me.btnRejectRecv.Location = New System.Drawing.Point(170, 10)

        ' TabPageIssuances
        Me.TabPageIssuances.Controls.Add(Me.dgvIssuances)
        Me.TabPageIssuances.Controls.Add(Me.pnlIssActions)
        Me.TabPageIssuances.Text = "Pending Issuances (OUT)"
        Me.TabPageIssuances.UseVisualStyleBackColor = True

        Me.dgvIssuances.AllowUserToAddRows = False
        Me.dgvIssuances.BackgroundColor = System.Drawing.Color.White
        Me.dgvIssuances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIssuances.ReadOnly = True
        Me.dgvIssuances.RowHeadersVisible = False
        Me.dgvIssuances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.pnlIssActions.Controls.Add(Me.btnRejectIss)
        Me.pnlIssActions.Controls.Add(Me.btnApproveIss)
        Me.pnlIssActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlIssActions.Size = New System.Drawing.Size(840, 60)

        Me.btnApproveIss.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnApproveIss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveIss.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveIss.Text = "✅ Approve & Deduct Stock"
        Me.btnApproveIss.Size = New System.Drawing.Size(170, 40)
        Me.btnApproveIss.Location = New System.Drawing.Point(10, 10)

        Me.btnRejectIss.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnRejectIss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRejectIss.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRejectIss.ForeColor = System.Drawing.Color.White
        Me.btnRejectIss.Text = "❌ Reject"
        Me.btnRejectIss.Size = New System.Drawing.Size(150, 40)
        Me.btnRejectIss.Location = New System.Drawing.Point(190, 10)

        ' TabPage3 (Returns)
        Me.TabPage3.Controls.Add(Me.dgvReturns)
        Me.TabPage3.Controls.Add(Me.pnlReturnActions)
        Me.TabPage3.Text = "Pending Returns"
        Me.TabPage3.UseVisualStyleBackColor = True

        Me.dgvReturns.AllowUserToAddRows = False
        Me.dgvReturns.BackgroundColor = System.Drawing.Color.White
        Me.dgvReturns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReturns.ReadOnly = True
        Me.dgvReturns.RowHeadersVisible = False
        Me.dgvReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        Me.pnlReturnActions.Controls.Add(Me.btnWriteOff)
        Me.pnlReturnActions.Controls.Add(Me.btnApproveReturn)
        Me.pnlReturnActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlReturnActions.Size = New System.Drawing.Size(840, 60)

        Me.btnApproveReturn.BackColor = System.Drawing.Color.FromArgb(245, 176, 65)
        Me.btnApproveReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveReturn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApproveReturn.Text = "✅ Approve (Add to Stock)"
        Me.btnApproveReturn.Size = New System.Drawing.Size(180, 40)
        Me.btnApproveReturn.Location = New System.Drawing.Point(10, 10)

        Me.btnWriteOff.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnWriteOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWriteOff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnWriteOff.ForeColor = System.Drawing.Color.White
        Me.btnWriteOff.Text = "🗑️ Write-Off (Defective)"
        Me.btnWriteOff.Size = New System.Drawing.Size(180, 40)
        Me.btnWriteOff.Location = New System.Drawing.Point(200, 10)

        ' ApprovalsForm
        Me.ClientSize = New System.Drawing.Size(850, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlSearch)
        Me.Name = "ApprovalsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Approvals Hub"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvReceivings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRecvActions.ResumeLayout(False)
        Me.TabPageIssuances.ResumeLayout(False)
        CType(Me.dgvIssuances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIssActions.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvReturns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReturnActions.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvReceivings As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecvItemsTitle As System.Windows.Forms.Label
    Friend WithEvents dgvRecvItems As System.Windows.Forms.DataGridView
    Friend WithEvents pnlRecvActions As System.Windows.Forms.Panel
    Friend WithEvents btnApproveRecv As System.Windows.Forms.Button
    Friend WithEvents btnRejectRecv As System.Windows.Forms.Button
    Friend WithEvents TabPageIssuances As System.Windows.Forms.TabPage
    Friend WithEvents dgvIssuances As System.Windows.Forms.DataGridView
    Friend WithEvents pnlIssActions As System.Windows.Forms.Panel
    Friend WithEvents btnApproveIss As System.Windows.Forms.Button
    Friend WithEvents btnRejectIss As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvReturns As System.Windows.Forms.DataGridView
    Friend WithEvents pnlReturnActions As System.Windows.Forms.Panel
    Friend WithEvents btnApproveReturn As System.Windows.Forms.Button
    Friend WithEvents btnWriteOff As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchTitle As System.Windows.Forms.Label
End Class