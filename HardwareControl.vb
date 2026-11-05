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

    Protected Overrides Sub OnVisibleChanged(e As EventArgs)
        MyBase.OnVisibleChanged(e)
        ' Auto-refresh when the user navigates back to this tab
        If Me.Visible AndAlso currentUser IsNot Nothing Then
            LoadHardware()
        End If
    End Sub

    Private Sub ApplyPermissions()
        If currentUser Is Nothing Then Return

        btnMasterList.Visible = currentUser.CanManageMasterList()
        btnRestock.Visible = currentUser.CanReceive()
        btnIssue.Visible = currentUser.CanIssue()
        btnRequestReturn.Visible = currentUser.CanIssue()

        ' Manager can now access Approvals for Issuances
        btnApprovals.Visible = currentUser.CanApproveReceivingsAndReturns() OrElse currentUser.CanApproveIssuances()

        btnDelete.Visible = currentUser.CanToggleStatus()
    End Sub

    Public Sub LoadHardware()
        Try
            ' Handle the search bar placeholder text
            Dim searchQuery As String = txtSearch.Text.Trim()
            If searchQuery = "Search item or category..." Then
                searchQuery = ""
            End If

            ' Fetch from Database using the new Search parameter
            dgvHardware.DataSource = DatabaseHelper.GetAllHardware(searchQuery)

            ' Format Columns
            If dgvHardware.Columns.Contains("HardwareID") Then dgvHardware.Columns("HardwareID").Visible = False
            If dgvHardware.Columns.Contains("Name") Then dgvHardware.Columns("Name").HeaderText = "Item Name"
            If dgvHardware.Columns.Contains("StockIn") Then dgvHardware.Columns("StockIn").HeaderText = "Total In"
            If dgvHardware.Columns.Contains("StockOut") Then dgvHardware.Columns("StockOut").HeaderText = "Total Out"
            If dgvHardware.Columns.Contains("OnHand") Then dgvHardware.Columns("OnHand").HeaderText = "On Hand"

            dgvHardware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ClearDetails()
            lblCount.Text = dgvHardware.RowCount & " records found"
        Catch ex As Exception
            ' Silent catch to prevent UI crash
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

            If status = "Active" Then
                lblStatus.ForeColor = Color.Green
            Else
                lblStatus.ForeColor = Color.Gray
            End If

            btnIssue.Enabled = currentUser.CanIssue() AndAlso stock > 0 AndAlso status = "Active"
            btnDelete.Enabled = currentUser.CanToggleStatus()
        End If
    End Sub

    ' ==========================================
    ' SEARCH BAR EVENTS (Placeholder logic)
    ' ==========================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadHardware()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search item or category..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search item or category..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    ' ==========================================
    ' BUTTON EVENTS
    ' ==========================================
    Private Sub btnMasterList_Click(sender As Object, e As EventArgs) Handles btnMasterList.Click
        Using frm As New AddHardwareForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then LoadHardware()
        End Using
    End Sub

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Using frm As New ReceivingForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then LoadHardware()
        End Using
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        Using frm As New IssuanceForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then LoadHardware()
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedID = -1 Then Return
        If MessageBox.Show("Are you sure you want to toggle the status of this item (Active/Inactive)?", "Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim currentStatus As String = lblStatus.Text.Replace("Status: ", "")
            Dim newStatus As String = If(currentStatus = "Active", "Inactive", "Active")
            If DatabaseHelper.SetHardwareStatus(selectedID, newStatus) Then
                LoadHardware()
            End If
        End If
    End Sub

    Private Sub btnApprovals_Click(sender As Object, e As EventArgs) Handles btnApprovals.Click
        Using frm As New ApprovalsForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then LoadHardware()
        End Using
    End Sub

    Private Sub btnRequestReturn_Click(sender As Object, e As EventArgs) Handles btnRequestReturn.Click
        Using frm As New ReturnForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then LoadHardware()
        End Using
    End Sub
End Class