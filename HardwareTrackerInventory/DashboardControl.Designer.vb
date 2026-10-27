<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardControl
    Inherits System.Windows.Forms.UserControl
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tlpStats = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.pnlAvailable = New System.Windows.Forms.Panel()
        Me.lblAvailableCount = New System.Windows.Forms.Label()
        Me.lblAvailableLabel = New System.Windows.Forms.Label()
        Me.pnlLowStock = New System.Windows.Forms.Panel()
        Me.lblLowStockCount = New System.Windows.Forms.Label()
        Me.lblLowStockLabel = New System.Windows.Forms.Label()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.picPieChart = New System.Windows.Forms.PictureBox()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.pnlLowStockGrid = New System.Windows.Forms.Panel()
        Me.dgvLowStock = New System.Windows.Forms.DataGridView()
        Me.lblLowStockTitle = New System.Windows.Forms.Label()
        Me.pnlActivity = New System.Windows.Forms.Panel()
        Me.lvActivity = New System.Windows.Forms.ListView()
        Me.colTime = New System.Windows.Forms.ColumnHeader()
        Me.colUser = New System.Windows.Forms.ColumnHeader()
        Me.colAction = New System.Windows.Forms.ColumnHeader()
        Me.lblActivityTitle = New System.Windows.Forms.Label()

        Me.pnlTop.SuspendLayout()
        Me.tlpStats.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.pnlAvailable.SuspendLayout()
        Me.pnlLowStock.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.pnlPie.SuspendLayout()
        CType(Me.picPieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLowStockGrid.SuspendLayout()
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActivity.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.Controls.Add(Me.lblWelcome)
        Me.pnlTop.Controls.Add(Me.lblDate)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1100, 60)
        Me.pnlTop.TabIndex = 0

        ' lblWelcome
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.lblWelcome.Location = New System.Drawing.Point(10, 15)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(200, 30)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "👋 Welcome back!"

        ' lblDate
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.Gray
        Me.lblDate.Location = New System.Drawing.Point(850, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 19)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"

        ' tlpStats
        Me.tlpStats.ColumnCount = 3
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.tlpStats.Controls.Add(Me.pnlTotal, 0, 0)
        Me.tlpStats.Controls.Add(Me.pnlAvailable, 1, 0)
        Me.tlpStats.Controls.Add(Me.pnlLowStock, 2, 0)
        Me.tlpStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpStats.Location = New System.Drawing.Point(0, 60)
        Me.tlpStats.Name = "tlpStats"
        Me.tlpStats.RowCount = 1
        Me.tlpStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpStats.Size = New System.Drawing.Size(1100, 110)
        Me.tlpStats.TabIndex = 1

        ' pnlTotal
        Me.pnlTotal.BackColor = System.Drawing.Color.White
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.lblTotalCount)
        Me.pnlTotal.Controls.Add(Me.lblTotalLabel)
        Me.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTotal.Location = New System.Drawing.Point(5, 5)
        Me.pnlTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(356, 100)
        Me.pnlTotal.TabIndex = 0

        Me.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.lblTotalCount.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(354, 55)
        Me.lblTotalCount.TabIndex = 0
        Me.lblTotalCount.Text = "0"
        Me.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblTotalLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalLabel.Location = New System.Drawing.Point(0, 73)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(354, 25)
        Me.lblTotalLabel.TabIndex = 1
        Me.lblTotalLabel.Text = "TOTAL HARDWARE"
        Me.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' pnlAvailable
        Me.pnlAvailable.BackColor = System.Drawing.Color.White
        Me.pnlAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAvailable.Controls.Add(Me.lblAvailableCount)
        Me.pnlAvailable.Controls.Add(Me.lblAvailableLabel)
        Me.pnlAvailable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAvailable.Location = New System.Drawing.Point(371, 5)
        Me.pnlAvailable.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(356, 100)
        Me.pnlAvailable.TabIndex = 1

        Me.lblAvailableCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvailableCount.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailableCount.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113)
        Me.lblAvailableCount.Location = New System.Drawing.Point(0, 0)
        Me.lblAvailableCount.Name = "lblAvailableCount"
        Me.lblAvailableCount.Size = New System.Drawing.Size(354, 55)
        Me.lblAvailableCount.TabIndex = 0
        Me.lblAvailableCount.Text = "0"
        Me.lblAvailableCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblAvailableLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAvailableLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailableLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblAvailableLabel.Location = New System.Drawing.Point(0, 73)
        Me.lblAvailableLabel.Name = "lblAvailableLabel"
        Me.lblAvailableLabel.Size = New System.Drawing.Size(354, 25)
        Me.lblAvailableLabel.TabIndex = 1
        Me.lblAvailableLabel.Text = "AVAILABLE ITEMS"
        Me.lblAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' pnlLowStock
        Me.pnlLowStock.BackColor = System.Drawing.Color.White
        Me.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLowStock.Controls.Add(Me.lblLowStockCount)
        Me.pnlLowStock.Controls.Add(Me.lblLowStockLabel)
        Me.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLowStock.Location = New System.Drawing.Point(737, 5)
        Me.pnlLowStock.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlLowStock.Name = "pnlLowStock"
        Me.pnlLowStock.Size = New System.Drawing.Size(358, 100)
        Me.pnlLowStock.TabIndex = 4

        Me.lblLowStockCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLowStockCount.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblLowStockCount.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.lblLowStockCount.Location = New System.Drawing.Point(0, 0)
        Me.lblLowStockCount.Name = "lblLowStockCount"
        Me.lblLowStockCount.Size = New System.Drawing.Size(356, 55)
        Me.lblLowStockCount.TabIndex = 0
        Me.lblLowStockCount.Text = "0"
        Me.lblLowStockCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblLowStockLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLowStockLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLowStockLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblLowStockLabel.Location = New System.Drawing.Point(0, 73)
        Me.lblLowStockLabel.Name = "lblLowStockLabel"
        Me.lblLowStockLabel.Size = New System.Drawing.Size(356, 25)
        Me.lblLowStockLabel.TabIndex = 1
        Me.lblLowStockLabel.Text = "LOW STOCK ITEMS"
        Me.lblLowStockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' tlpBottom
        Me.tlpBottom.ColumnCount = 3
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.tlpBottom.Controls.Add(Me.pnlPie, 0, 0)
        Me.tlpBottom.Controls.Add(Me.pnlLowStockGrid, 1, 0)
        Me.tlpBottom.Controls.Add(Me.pnlActivity, 2, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Location = New System.Drawing.Point(0, 170)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 1
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(1100, 430)
        Me.tlpBottom.TabIndex = 2

        ' pnlPie
        Me.pnlPie.BackColor = System.Drawing.Color.White
        Me.pnlPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPie.Controls.Add(Me.picPieChart)
        Me.pnlPie.Controls.Add(Me.lblChartTitle)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPie.Location = New System.Drawing.Point(5, 5)
        Me.pnlPie.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlPie.Size = New System.Drawing.Size(356, 420)
        Me.pnlPie.TabIndex = 0

        ' lblChartTitle
        Me.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.lblChartTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblChartTitle.Name = "lblChartTitle"
        Me.lblChartTitle.Size = New System.Drawing.Size(334, 25)
        Me.lblChartTitle.TabIndex = 0
        Me.lblChartTitle.Text = "📊 INVENTORY DIST."

        ' picPieChart
        Me.picPieChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picPieChart.Location = New System.Drawing.Point(10, 35)
        Me.picPieChart.Name = "picPieChart"
        Me.picPieChart.Size = New System.Drawing.Size(334, 373)
        Me.picPieChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPieChart.TabIndex = 1
        Me.picPieChart.TabStop = False

        ' pnlLowStockGrid
        Me.pnlLowStockGrid.BackColor = System.Drawing.Color.White
        Me.pnlLowStockGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLowStockGrid.Controls.Add(Me.dgvLowStock)
        Me.pnlLowStockGrid.Controls.Add(Me.lblLowStockTitle)
        Me.pnlLowStockGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLowStockGrid.Location = New System.Drawing.Point(371, 5)
        Me.pnlLowStockGrid.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlLowStockGrid.Name = "pnlLowStockGrid"
        Me.pnlLowStockGrid.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlLowStockGrid.Size = New System.Drawing.Size(356, 420)
        Me.pnlLowStockGrid.TabIndex = 1

        ' lblLowStockTitle
        Me.lblLowStockTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLowStockTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.lblLowStockTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblLowStockTitle.Name = "lblLowStockTitle"
        Me.lblLowStockTitle.Size = New System.Drawing.Size(334, 25)
        Me.lblLowStockTitle.TabIndex = 0
        Me.lblLowStockTitle.Text = "⚠️ LOW STOCK ITEMS"

        ' dgvLowStock
        Me.dgvLowStock.AllowUserToAddRows = False
        Me.dgvLowStock.AllowUserToDeleteRows = False
        Me.dgvLowStock.BackgroundColor = System.Drawing.Color.White
        Me.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLowStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLowStock.Location = New System.Drawing.Point(10, 35)
        Me.dgvLowStock.Name = "dgvLowStock"
        Me.dgvLowStock.ReadOnly = True
        Me.dgvLowStock.RowHeadersVisible = False
        Me.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLowStock.Size = New System.Drawing.Size(334, 373)
        Me.dgvLowStock.TabIndex = 1
        Me.dgvLowStock.AllowUserToResizeRows = False
        Me.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        ' pnlActivity
        Me.pnlActivity.BackColor = System.Drawing.Color.White
        Me.pnlActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActivity.Controls.Add(Me.lvActivity)
        Me.pnlActivity.Controls.Add(Me.lblActivityTitle)
        Me.pnlActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlActivity.Location = New System.Drawing.Point(737, 5)
        Me.pnlActivity.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlActivity.Name = "pnlActivity"
        Me.pnlActivity.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlActivity.Size = New System.Drawing.Size(360, 420)
        Me.pnlActivity.TabIndex = 2

        ' lblActivityTitle
        Me.lblActivityTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblActivityTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(26, 54, 126)
        Me.lblActivityTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblActivityTitle.Name = "lblActivityTitle"
        Me.lblActivityTitle.Size = New System.Drawing.Size(338, 25)
        Me.lblActivityTitle.TabIndex = 0
        Me.lblActivityTitle.Text = "🕐 RECENT ACTIVITY"

        ' lvActivity
        Me.lvActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvActivity.FullRowSelect = True
        Me.lvActivity.GridLines = True
        Me.lvActivity.Location = New System.Drawing.Point(10, 35)
        Me.lvActivity.Name = "lvActivity"
        Me.lvActivity.Size = New System.Drawing.Size(338, 373)
        Me.lvActivity.TabIndex = 1
        Me.lvActivity.UseCompatibleStateImageBehavior = False
        Me.lvActivity.View = System.Windows.Forms.View.Details
        Me.lvActivity.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTime, Me.colUser, Me.colAction})

        Me.colTime.Text = "Time"
        Me.colTime.Width = 60
        Me.colUser.Text = "User"
        Me.colUser.Width = 80
        Me.colAction.Text = "Action"
        Me.colAction.Width = 180

        ' DashboardControl
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(240, 242, 245)
        Me.Controls.Add(Me.tlpBottom)
        Me.Controls.Add(Me.tlpStats)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(1100, 600)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.tlpStats.ResumeLayout(False)
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlAvailable.ResumeLayout(False)
        Me.pnlLowStock.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.pnlPie.ResumeLayout(False)
        CType(Me.picPieChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLowStockGrid.ResumeLayout(False)
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActivity.ResumeLayout(False)
        Me.ResumeLayout(False)
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