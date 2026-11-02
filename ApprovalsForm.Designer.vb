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

        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvReturns = New System.Windows.Forms.DataGridView()
        Me.pnlReturnActions = New System.Windows.Forms.Panel()
        Me.btnWriteOff = New System.Windows.Forms.Button()
        Me.btnApproveReturn = New System.Windows.Forms.Button()

        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvReceivings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRecvActions.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReturnActions.SuspendLayout()
        Me.SuspendLayout()

        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Size = New System.Drawing.Size(850, 550)

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

        Me.ClientSize = New System.Drawing.Size(850, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ApprovalsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Approvals Hub"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvReceivings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRecvActions.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvReturns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReturnActions.ResumeLayout(False)
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
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvReturns As System.Windows.Forms.DataGridView
    Friend WithEvents pnlReturnActions As System.Windows.Forms.Panel
    Friend WithEvents btnApproveReturn As System.Windows.Forms.Button
    Friend WithEvents btnWriteOff As System.Windows.Forms.Button
End Class