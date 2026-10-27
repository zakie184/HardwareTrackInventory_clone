Imports System.Drawing

Public Class HardwareControl
    Inherits UserControl

    Private currentUser As User = Nothing
    Private selectedID As Integer = -1

    Public Sub SetCurrentUser(user As User)
        currentUser = user
        ApplyPermissions()
        LoadHardware()
    End Sub

    Private Sub ApplyPermissions()
        If currentUser Is Nothing Then Return
        btnRestock.Enabled = currentUser.CanReceive()
        btnMasterList.Enabled = currentUser.CanApprove()
        btnIssue.Enabled = currentUser.CanIssue()
        btnDelete.Enabled = currentUser.CanApprove()
        btnApprovals.Visible = currentUser.CanApprove()

        btnRequestReturn.Visible = currentUser.CanIssue()
        btnApproveReturns.Visible = currentUser.CanApprove()
    End Sub

    Public Sub LoadHardware()
        Try
            dgvHardware.DataSource = DatabaseHelper.GetAllHardware()

            If dgvHardware.Columns.Contains("HardwareID") Then dgvHardware.Columns("HardwareID").Visible = False
            If dgvHardware.Columns.Contains("Name") Then dgvHardware.Columns("Name").HeaderText = "Item Name"
            If dgvHardware.Columns.Contains("StockIn") Then dgvHardware.Columns("StockIn").HeaderText = "Total In"
            If dgvHardware.Columns.Contains("StockOut") Then dgvHardware.Columns("StockOut").HeaderText = "Total Out"
            If dgvHardware.Columns.Contains("OnHand") Then dgvHardware.Columns("OnHand").HeaderText = "On Hand"

            dgvHardware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ClearDetails()
            lblCount.Text = dgvHardware.RowCount & " records found"
        Catch ex As Exception
            MessageBox.Show("Error loading hardware: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearDetails()
        lblName.Text = "Select an item"
        lblCategory.Text = "Category: -"
        lblQty.Text = "Qty: -"
        lblStatus.Text = "Status: -"
        btnIssue.Enabled = False
        btnDelete.Enabled = False
        selectedID = -1
    End Sub

    Private Sub dgvHardware_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHardware.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvHardware.Rows(e.RowIndex)
            selectedID = Convert.ToInt32(row.Cells("HardwareID").Value)
            Dim stock = Convert.ToInt32(row.Cells("OnHand").Value)
            Dim status = row.Cells("Status").Value.ToString()

            lblName.Text = row.Cells("Name").Value.ToString()
            lblCategory.Text = "Category: " & row.Cells("Category").Value.ToString()
            lblQty.Text = "Qty: " & stock.ToString()
            lblStatus.Text = "Status: " & status

            If status = "Active" Then lblStatus.ForeColor = Color.Green Else lblStatus.ForeColor = Color.Gray

            btnIssue.Enabled = currentUser.CanIssue() AndAlso stock > 0 AndAlso status = "Active"
            btnDelete.Enabled = currentUser.CanApprove()
        End If
    End Sub

    ' BINAGO NATIN ITO PARA GAMITIN ANG BAGONG FORM
    Private Sub btnMasterList_Click(sender As Object, e As EventArgs) Handles btnMasterList.Click
        Using frm As New AddHardwareForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadHardware()
            End If
        End Using
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Using frm As New ReceivingForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadHardware()
            End If
        End Using
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        Using frm As New IssuanceForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadHardware()
            End If
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedID = -1 Then Return
        If MessageBox.Show("Toggle status (Active/Inactive)?", "Status Change", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim currentStatus As String = lblStatus.Text.Replace("Status: ", "")
            Dim newStatus As String = If(currentStatus = "Active", "Inactive", "Active")
            If DatabaseHelper.SetHardwareStatus(selectedID, newStatus) Then LoadHardware()
        End If
    End Sub

    Private Sub btnApprovals_Click(sender As Object, e As EventArgs) Handles btnApprovals.Click
        Using frm As New ApprovalsForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadHardware()
            End If
        End Using
    End Sub

    Private Sub btnRequestReturn_Click(sender As Object, e As EventArgs) Handles btnRequestReturn.Click
        Using frm As New ReturnForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadHardware()
            End If
        End Using
    End Sub

    Private Sub btnApproveReturns_Click(sender As Object, e As EventArgs) Handles btnApproveReturns.Click
        Using frm As New ReturnsApprovalForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadHardware()
            End If
        End Using
    End Sub
End Class