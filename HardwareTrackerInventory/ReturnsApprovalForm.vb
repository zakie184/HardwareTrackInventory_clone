Public Class ReturnsApprovalForm
    Private _user As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub ReturnsApprovalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPending()
    End Sub

    Private Sub LoadPending()
        dgvReturns.DataSource = DatabaseHelper.GetPendingReturns()
        If dgvReturns.Columns.Count > 0 Then
            If dgvReturns.Columns.Contains("ReturnID") Then dgvReturns.Columns("ReturnID").Visible = False
            If dgvReturns.Columns.Contains("IsDefective") Then dgvReturns.Columns("IsDefective").Visible = False
            If dgvReturns.Columns.Contains("ItemName") Then dgvReturns.Columns("ItemName").HeaderText = "Item"
            If dgvReturns.Columns.Contains("QuantityReturned") Then dgvReturns.Columns("QuantityReturned").HeaderText = "Qty"
            If dgvReturns.Columns.Contains("IssuedTo") Then dgvReturns.Columns("IssuedTo").HeaderText = "Issued To"
            If dgvReturns.Columns.Contains("ReturnDate") Then dgvReturns.Columns("ReturnDate").HeaderText = "Date Requested"
            dgvReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvReturns.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReturns.SelectedRows(0).Cells("ReturnID").Value)

        If DatabaseHelper.ProcessReturn(id, _user.Username, False) Then
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Approved return of Item ID: " & id)
            MessageBox.Show("Return Approved. Item added back to stock.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPending()
        End If
    End Sub

    Private Sub btnWriteOff_Click(sender As Object, e As EventArgs) Handles btnWriteOff.Click
        If dgvReturns.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReturns.SelectedRows(0).Cells("ReturnID").Value)

        If MessageBox.Show("Write-off this item? It will NOT be returned to inventory.", "Confirm Write-Off", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If DatabaseHelper.ProcessReturn(id, _user.Username, True) Then
                DatabaseHelper.LogActivity(_user.Username, _user.Role, "Written off Item ID: " & id)
                MessageBox.Show("Item written off. Stock not modified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPending()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class