<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardControl
    Inherits System.Windows.Forms.UserControl
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlTop = New Panel()
        lblWelcome = New Label()
        lblDate = New Label()
        tlpStats = New TableLayoutPanel()
        pnlTotal = New Panel()
        lblTotalCount = New Label()
        lblTotalLabel = New Label()
        pnlAvailable = New Panel()
        lblAvailableCount = New Label()
        lblAvailableLabel = New Label()
        pnlLowStock = New Panel()
        lblLowStockCount = New Label()
        lblLowStockLabel = New Label()
        tlpBottom = New TableLayoutPanel()
        pnlPie = New Panel()
        picPieChart = New PictureBox()
        lblChartTitle = New Label()
        pnlLowStockGrid = New Panel()
        dgvLowStock = New DataGridView()
        lblLowStockTitle = New Label()
        pnlActivity = New Panel()
        lvActivity = New ListView()
        colTime = New ColumnHeader()
        colUser = New ColumnHeader()
        colAction = New ColumnHeader()
        lblActivityTitle = New Label()
        pnlTop.SuspendLayout()
        tlpStats.SuspendLayout()
        pnlTotal.SuspendLayout()
        pnlAvailable.SuspendLayout()
        pnlLowStock.SuspendLayout()
        tlpBottom.SuspendLayout()
        pnlPie.SuspendLayout()
        CType(picPieChart, ComponentModel.ISupportInitialize).BeginInit()
        pnlLowStockGrid.SuspendLayout()
        CType(dgvLowStock, ComponentModel.ISupportInitialize).BeginInit()
        pnlActivity.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTop
        ' 
        pnlTop.Controls.Add(lblWelcome)
        pnlTop.Controls.Add(lblDate)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1100, 60)
        pnlTop.TabIndex = 0
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(26), CByte(54), CByte(126))
        lblWelcome.Location = New Point(10, 15)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(207, 30)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "👋 Welcome back!"
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 10.0F)
        lblDate.ForeColor = Color.Gray
        lblDate.Location = New Point(850, 20)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(38, 19)
        lblDate.TabIndex = 1
        lblDate.Text = "Date"
        ' 
        ' tlpStats
        ' 
        tlpStats.ColumnCount = 3
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.34F))
        tlpStats.Controls.Add(pnlTotal, 0, 0)
        tlpStats.Controls.Add(pnlAvailable, 1, 0)
        tlpStats.Controls.Add(pnlLowStock, 2, 0)
        tlpStats.Dock = DockStyle.Top
        tlpStats.Location = New Point(0, 60)
        tlpStats.Name = "tlpStats"
        tlpStats.RowCount = 1
        tlpStats.RowStyles.Add(New RowStyle(SizeType.Absolute, 110.0F))
        tlpStats.Size = New Size(1100, 110)
        tlpStats.TabIndex = 1
        ' 
        ' pnlTotal
        ' 
        pnlTotal.BackColor = Color.White
        pnlTotal.BorderStyle = BorderStyle.FixedSingle
        pnlTotal.Controls.Add(lblTotalCount)
        pnlTotal.Controls.Add(lblTotalLabel)
        pnlTotal.Dock = DockStyle.Fill
        pnlTotal.Location = New Point(5, 5)
        pnlTotal.Margin = New Padding(5)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Size = New Size(356, 100)
        pnlTotal.TabIndex = 0
        ' 
        ' lblTotalCount
        ' 
        lblTotalCount.Dock = DockStyle.Top
        lblTotalCount.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblTotalCount.ForeColor = Color.FromArgb(CByte(26), CByte(54), CByte(126))
        lblTotalCount.Location = New Point(0, 0)
        lblTotalCount.Name = "lblTotalCount"
        lblTotalCount.Size = New Size(354, 55)
        lblTotalCount.TabIndex = 0
        lblTotalCount.Text = "0"
        lblTotalCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalLabel
        ' 
        lblTotalLabel.Dock = DockStyle.Bottom
        lblTotalLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTotalLabel.ForeColor = Color.Gray
        lblTotalLabel.Location = New Point(0, 73)
        lblTotalLabel.Name = "lblTotalLabel"
        lblTotalLabel.Size = New Size(354, 25)
        lblTotalLabel.TabIndex = 1
        lblTotalLabel.Text = "TOTAL HARDWARE"
        lblTotalLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlAvailable
        ' 
        pnlAvailable.BackColor = Color.White
        pnlAvailable.BorderStyle = BorderStyle.FixedSingle
        pnlAvailable.Controls.Add(lblAvailableCount)
        pnlAvailable.Controls.Add(lblAvailableLabel)
        pnlAvailable.Dock = DockStyle.Fill
        pnlAvailable.Location = New Point(371, 5)
        pnlAvailable.Margin = New Padding(5)
        pnlAvailable.Name = "pnlAvailable"
        pnlAvailable.Size = New Size(356, 100)
        pnlAvailable.TabIndex = 1
        ' 
        ' lblAvailableCount
        ' 
        lblAvailableCount.Dock = DockStyle.Top
        lblAvailableCount.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblAvailableCount.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        lblAvailableCount.Location = New Point(0, 0)
        lblAvailableCount.Name = "lblAvailableCount"
        lblAvailableCount.Size = New Size(354, 55)
        lblAvailableCount.TabIndex = 0
        lblAvailableCount.Text = "0"
        lblAvailableCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAvailableLabel
        ' 
        lblAvailableLabel.Dock = DockStyle.Bottom
        lblAvailableLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblAvailableLabel.ForeColor = Color.Gray
        lblAvailableLabel.Location = New Point(0, 73)
        lblAvailableLabel.Name = "lblAvailableLabel"
        lblAvailableLabel.Size = New Size(354, 25)
        lblAvailableLabel.TabIndex = 1
        lblAvailableLabel.Text = "AVAILABLE ITEMS"
        lblAvailableLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLowStock
        ' 
        pnlLowStock.BackColor = Color.White
        pnlLowStock.BorderStyle = BorderStyle.FixedSingle
        pnlLowStock.Controls.Add(lblLowStockCount)
        pnlLowStock.Controls.Add(lblLowStockLabel)
        pnlLowStock.Dock = DockStyle.Fill
        pnlLowStock.Location = New Point(737, 5)
        pnlLowStock.Margin = New Padding(5)
        pnlLowStock.Name = "pnlLowStock"
        pnlLowStock.Size = New Size(358, 100)
        pnlLowStock.TabIndex = 4
        ' 
        ' lblLowStockCount
        ' 
        lblLowStockCount.Dock = DockStyle.Top
        lblLowStockCount.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblLowStockCount.ForeColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        lblLowStockCount.Location = New Point(0, 0)
        lblLowStockCount.Name = "lblLowStockCount"
        lblLowStockCount.Size = New Size(356, 55)
        lblLowStockCount.TabIndex = 0
        lblLowStockCount.Text = "0"
        lblLowStockCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLowStockLabel
        ' 
        lblLowStockLabel.Dock = DockStyle.Bottom
        lblLowStockLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblLowStockLabel.ForeColor = Color.Gray
        lblLowStockLabel.Location = New Point(0, 73)
        lblLowStockLabel.Name = "lblLowStockLabel"
        lblLowStockLabel.Size = New Size(356, 25)
        lblLowStockLabel.TabIndex = 1
        lblLowStockLabel.Text = "LOW STOCK ITEMS"
        lblLowStockLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tlpBottom
        ' 
        tlpBottom.ColumnCount = 3
        tlpBottom.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpBottom.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpBottom.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.34F))
        tlpBottom.Controls.Add(pnlPie, 0, 0)
        tlpBottom.Controls.Add(pnlLowStockGrid, 1, 0)
        tlpBottom.Controls.Add(pnlActivity, 2, 0)
        tlpBottom.Dock = DockStyle.Fill
        tlpBottom.Location = New Point(0, 170)
        tlpBottom.Name = "tlpBottom"
        tlpBottom.RowCount = 1
        tlpBottom.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpBottom.Size = New Size(1100, 430)
        tlpBottom.TabIndex = 2
        ' 
        ' pnlPie
        ' 
        pnlPie.BackColor = Color.White
        pnlPie.BorderStyle = BorderStyle.FixedSingle
        pnlPie.Controls.Add(picPieChart)
        pnlPie.Controls.Add(lblChartTitle)
        pnlPie.Dock = DockStyle.Fill
        pnlPie.Location = New Point(5, 5)
        pnlPie.Margin = New Padding(5)
        pnlPie.Name = "pnlPie"
        pnlPie.Padding = New Padding(10)
        pnlPie.Size = New Size(356, 420)
        pnlPie.TabIndex = 0
        ' 
        ' picPieChart
        ' 
        picPieChart.Dock = DockStyle.Fill
        picPieChart.Location = New Point(10, 35)
        picPieChart.Name = "picPieChart"
        picPieChart.Size = New Size(334, 373)
        picPieChart.SizeMode = PictureBoxSizeMode.Zoom
        picPieChart.TabIndex = 1
        picPieChart.TabStop = False
        ' 
        ' lblChartTitle
        ' 
        lblChartTitle.Dock = DockStyle.Top
        lblChartTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblChartTitle.ForeColor = Color.FromArgb(CByte(26), CByte(54), CByte(126))
        lblChartTitle.Location = New Point(10, 10)
        lblChartTitle.Name = "lblChartTitle"
        lblChartTitle.Size = New Size(334, 25)
        lblChartTitle.TabIndex = 0
        lblChartTitle.Text = "📊 INVENTORY DIST."
        ' 
        ' pnlLowStockGrid
        ' 
        pnlLowStockGrid.BackColor = Color.White
        pnlLowStockGrid.BorderStyle = BorderStyle.FixedSingle
        pnlLowStockGrid.Controls.Add(dgvLowStock)
        pnlLowStockGrid.Controls.Add(lblLowStockTitle)
        pnlLowStockGrid.Dock = DockStyle.Fill
        pnlLowStockGrid.Location = New Point(371, 5)
        pnlLowStockGrid.Margin = New Padding(5)
        pnlLowStockGrid.Name = "pnlLowStockGrid"
        pnlLowStockGrid.Padding = New Padding(10)
        pnlLowStockGrid.Size = New Size(356, 420)
        pnlLowStockGrid.TabIndex = 1
        ' 
        ' dgvLowStock
        ' 
        dgvLowStock.AllowUserToAddRows = False
        dgvLowStock.AllowUserToDeleteRows = False
        dgvLowStock.AllowUserToResizeRows = False
        dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLowStock.BackgroundColor = Color.White
        dgvLowStock.BorderStyle = BorderStyle.None
        dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLowStock.Dock = DockStyle.Fill
        dgvLowStock.Location = New Point(10, 35)
        dgvLowStock.Name = "dgvLowStock"
        dgvLowStock.ReadOnly = True
        dgvLowStock.RowHeadersVisible = False
        dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLowStock.Size = New Size(334, 373)
        dgvLowStock.TabIndex = 1
        ' 
        ' lblLowStockTitle
        ' 
        lblLowStockTitle.Dock = DockStyle.Top
        lblLowStockTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblLowStockTitle.ForeColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        lblLowStockTitle.Location = New Point(10, 10)
        lblLowStockTitle.Name = "lblLowStockTitle"
        lblLowStockTitle.Size = New Size(334, 25)
        lblLowStockTitle.TabIndex = 0
        lblLowStockTitle.Text = "⚠️ LOW STOCK ITEMS"
        ' 
        ' pnlActivity
        ' 
        pnlActivity.BackColor = Color.White
        pnlActivity.BorderStyle = BorderStyle.FixedSingle
        pnlActivity.Controls.Add(lvActivity)
        pnlActivity.Controls.Add(lblActivityTitle)
        pnlActivity.Dock = DockStyle.Fill
        pnlActivity.Location = New Point(737, 5)
        pnlActivity.Margin = New Padding(5)
        pnlActivity.Name = "pnlActivity"
        pnlActivity.Padding = New Padding(10)
        pnlActivity.Size = New Size(358, 420)
        pnlActivity.TabIndex = 2
        ' 
        ' lvActivity
        ' 
        lvActivity.BorderStyle = BorderStyle.None
        lvActivity.Columns.AddRange(New ColumnHeader() {colTime, colUser, colAction})
        lvActivity.Dock = DockStyle.Fill
        lvActivity.FullRowSelect = True
        lvActivity.GridLines = True
        lvActivity.Location = New Point(10, 35)
        lvActivity.Name = "lvActivity"
        lvActivity.Size = New Size(336, 373)
        lvActivity.TabIndex = 1
        lvActivity.UseCompatibleStateImageBehavior = False
        lvActivity.View = View.Details
        ' 
        ' colTime
        ' 
        colTime.Text = "Time"
        ' 
        ' colUser
        ' 
        colUser.Text = "User"
        colUser.Width = 80
        ' 
        ' colAction
        ' 
        colAction.Text = "Action"
        colAction.Width = 180
        ' 
        ' lblActivityTitle
        ' 
        lblActivityTitle.Dock = DockStyle.Top
        lblActivityTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblActivityTitle.ForeColor = Color.FromArgb(CByte(26), CByte(54), CByte(126))
        lblActivityTitle.Location = New Point(10, 10)
        lblActivityTitle.Name = "lblActivityTitle"
        lblActivityTitle.Size = New Size(336, 25)
        lblActivityTitle.TabIndex = 0
        lblActivityTitle.Text = "🕐 RECENT ACTIVITY"
        ' 
        ' DashboardControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(tlpBottom)
        Controls.Add(tlpStats)
        Controls.Add(pnlTop)
        Font = New Font("Segoe UI", 9.0F)
        Name = "DashboardControl"
        Size = New Size(1100, 600)
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        tlpStats.ResumeLayout(False)
        pnlTotal.ResumeLayout(False)
        pnlAvailable.ResumeLayout(False)
        pnlLowStock.ResumeLayout(False)
        tlpBottom.ResumeLayout(False)
        pnlPie.ResumeLayout(False)
        CType(picPieChart, ComponentModel.ISupportInitialize).EndInit()
        pnlLowStockGrid.ResumeLayout(False)
        CType(dgvLowStock, ComponentModel.ISupportInitialize).EndInit()
        pnlActivity.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tlpStats As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalLabel As System.Windows.Forms.Label
    Friend WithEvents pnlAvailable As System.Windows.Forms.Panel
    Friend WithEvents lblAvailableCount As System.Windows.Forms.Label
    Friend WithEvents lblAvailableLabel As System.Windows.Forms.Label
    Friend WithEvents pnlLowStock As System.Windows.Forms.Panel
    Friend WithEvents lblLowStockCount As System.Windows.Forms.Label
    Friend WithEvents lblLowStockLabel As System.Windows.Forms.Label
    Friend WithEvents tlpBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlPie As System.Windows.Forms.Panel
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    Friend WithEvents picPieChart As System.Windows.Forms.PictureBox
    Friend WithEvents pnlLowStockGrid As System.Windows.Forms.Panel
    Friend WithEvents lblLowStockTitle As System.Windows.Forms.Label
    Friend WithEvents dgvLowStock As System.Windows.Forms.DataGridView
    Friend WithEvents pnlActivity As System.Windows.Forms.Panel
    Friend WithEvents lblActivityTitle As System.Windows.Forms.Label
    Friend WithEvents lvActivity As System.Windows.Forms.ListView
    Friend WithEvents colTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAction As System.Windows.Forms.ColumnHeader
End Class