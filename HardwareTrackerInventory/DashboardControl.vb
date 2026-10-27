Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class DashboardControl
    Inherits UserControl

    Private currentUser As User = Nothing

    Public Sub SetCurrentUser(user As User)
        currentUser = user
        lblWelcome.Text = "👋 Welcome back, " & user.FullName & "!"
        lblDate.Text = "Branch: " & user.BranchDisplay & " | Role: " & user.RoleDisplay
        LoadDashboard()
    End Sub

    Public Sub LoadDashboard()
        lblTotalCount.Text = DatabaseHelper.GetTotalCount().ToString()
        lblAvailableCount.Text = DatabaseHelper.GetAvailableCount().ToString()
        lblLowStockCount.Text = DatabaseHelper.GetLowStockCount(5).ToString()

        DrawFuturisticChart()

        dgvLowStock.DataSource = DatabaseHelper.GetLowStockItems(5)
        If dgvLowStock.Columns.Contains("HardwareID") Then dgvLowStock.Columns("HardwareID").Visible = False

        lvActivity.Items.Clear()
        Dim dtAct As DataTable = DatabaseHelper.GetRecentActivities(currentUser)
        For Each row As DataRow In dtAct.Rows
            Dim item As New ListViewItem(Convert.ToDateTime(row("ActivityDate")).ToString("HH:mm"))
            item.SubItems.Add(row("Username").ToString())
            item.SubItems.Add(row("Action").ToString())
            lvActivity.Items.Add(item)
        Next

        ResizeActivityColumns()
    End Sub

    ' Responsive Pie Chart
    Private Sub picPieChart_SizeChanged(sender As Object, e As EventArgs) Handles picPieChart.SizeChanged
        DrawFuturisticChart()
    End Sub

    ' Responsive ListView Columns
    Private Sub lvActivity_SizeChanged(sender As Object, e As EventArgs) Handles lvActivity.SizeChanged
        ResizeActivityColumns()
    End Sub

    Private Sub ResizeActivityColumns()
        If lvActivity.Columns.Count = 3 AndAlso lvActivity.Width > 50 Then
            ' I-set ang fixed widths para sa Time at User, tapos yung natitira ay mapupunta sa Action
            lvActivity.Columns(0).Width = 55 ' Time
            lvActivity.Columns(1).Width = 70 ' User
            lvActivity.Columns(2).Width = lvActivity.Width - 135 ' Action (fill remaining)
        End If
    End Sub

    Private Sub DrawFuturisticChart()
        If picPieChart.Width <= 0 OrElse picPieChart.Height <= 0 Then Return

        Dim bmp As New Bitmap(picPieChart.Width, picPieChart.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

            Dim dtCategories As DataTable = DatabaseHelper.GetInventoryByCategory()
            Dim grandTotal As Integer = 0
            For Each row As DataRow In dtCategories.Rows
                grandTotal += Convert.ToInt32(row("Total"))
            Next

            Dim centerX As Integer = bmp.Width \ 2
            Dim centerY As Integer = (bmp.Height \ 2) - 30
            Dim maxRadius As Integer = Math.Min(centerX, centerY) - 30
            Dim outerRadius As Integer = If(maxRadius > 50, maxRadius, 50)
            Dim innerRadius As Integer = CInt(outerRadius * 0.55)

            If grandTotal = 0 Then
                Dim emptyRect As New Rectangle(centerX - outerRadius, centerY - outerRadius, outerRadius * 2, outerRadius * 2)
                g.DrawEllipse(New Pen(Color.LightGray, 10), emptyRect)
                g.DrawString("No Data", New Font("Segoe UI", 14, FontStyle.Bold), Brushes.Gray, centerX - 40, centerY - 10)
            Else
                Dim colors As Color() = {
                    Color.FromArgb(26, 54, 126),   ' Blue
                    Color.FromArgb(245, 176, 65),  ' Yellow
                    Color.FromArgb(46, 204, 113),  ' Green
                    Color.FromArgb(155, 89, 182),  ' Purple
                    Color.FromArgb(231, 76, 60),   ' Red
                    Color.FromArgb(52, 152, 219),  ' Light Blue
                    Color.FromArgb(230, 126, 34)   ' Orange
                }

                Dim startAngle As Single = -90
                Dim colorIndex As Integer = 0

                For Each row As DataRow In dtCategories.Rows
                    Dim catTotal As Integer = Convert.ToInt32(row("Total"))
                    Dim sweepAngle As Single = CSng(catTotal / grandTotal * 360)

                    Dim col As Color = colors(colorIndex Mod colors.Length)
                    Dim colDark As Color = Color.FromArgb(
                        Math.Max(0, col.R - 40),
                        Math.Max(0, col.G - 40),
                        Math.Max(0, col.B - 40)
                    )

                    DrawArcSlice(g, centerX, centerY, outerRadius, innerRadius, startAngle, sweepAngle, col, colDark)
                    startAngle += sweepAngle
                    colorIndex += 1
                Next

                Dim centerFont As New Font("Segoe UI", 22, FontStyle.Bold)
                Dim textSize As SizeF = g.MeasureString(grandTotal.ToString(), centerFont)
                g.DrawString(grandTotal.ToString(), centerFont, Brushes.Black, centerX - (textSize.Width / 2), centerY - (textSize.Height / 2))

                Dim subTextFont As New Font("Segoe UI", 9, FontStyle.Regular)
                Dim subTextSize As SizeF = g.MeasureString("Items", subTextFont)
                g.DrawString("Items", subTextFont, Brushes.Gray, centerX - (subTextSize.Width / 2), centerY + (textSize.Height / 2) + 2)

                ' Dynamic Legend
                Dim legendY As Integer = centerY + outerRadius + 20
                Dim legendStartX As Integer = 10
                colorIndex = 0

                For Each row As DataRow In dtCategories.Rows
                    Dim catName As String = row("Category").ToString()
                    Dim catTotal As Integer = Convert.ToInt32(row("Total"))
                    Dim col As Color = colors(colorIndex Mod colors.Length)

                    g.FillEllipse(New SolidBrush(col), legendStartX, legendY, 12, 12)

                    Dim legendText As String = catName & " (" & catTotal & ")"
                    g.DrawString(legendText, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, legendStartX + 18, legendY - 2)

                    legendStartX += 110
                    If legendStartX > bmp.Width - 100 Then
                        legendStartX = 10
                        legendY += 20
                    End If

                    colorIndex += 1
                Next
            End If
        End Using

        picPieChart.Image = bmp
    End Sub

    Private Sub DrawArcSlice(g As Graphics, cx As Integer, cy As Integer, outerR As Integer, innerR As Integer, startAngle As Single, sweepAngle As Single, c1 As Color, c2 As Color)
        Using path As New GraphicsPath()
            Dim outerRect As New Rectangle(cx - outerR, cy - outerR, outerR * 2, outerR * 2)
            Dim innerRect As New Rectangle(cx - innerR, cy - innerR, innerR * 2, innerR * 2)

            path.AddArc(outerRect, startAngle, sweepAngle)
            path.AddArc(innerRect, startAngle + sweepAngle, -sweepAngle)
            path.CloseFigure()

            Using brush As New LinearGradientBrush(outerRect, c1, c2, LinearGradientMode.ForwardDiagonal)
                g.FillPath(brush, path)
            End Using
            g.DrawPath(New Pen(Color.White, 2), path)
        End Using
    End Sub

    Private Sub dgvLowStock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLowStock.CellDoubleClick
        If e.RowIndex >= 0 Then
            If currentUser Is Nothing OrElse Not currentUser.CanReceive() Then
                MessageBox.Show("Only Managers and Administrators can receive stock.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim hwID As Integer = Convert.ToInt32(dgvLowStock.Rows(e.RowIndex).Cells("HardwareID").Value)

            Using frm As New ReceivingForm(currentUser, hwID)
                If frm.ShowDialog(Me) = DialogResult.OK Then
                    LoadDashboard()
                End If
            End Using
        End If
    End Sub
End Class