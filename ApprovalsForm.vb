Public Class ApprovalsForm
    Private _user As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub ApprovalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _user Is Nothing OrElse Not _user.CanApprove() Then
            MessageBox.Show("Access Denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If
        LoadAllData()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        LoadAllData()
    End Sub

    Private Sub LoadAllData()
        ' Receivings
        dgvReceivings.DataSource = DatabaseHelper.GetPendingReceivings()
        dgvReceivings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvReceivings.Columns.Contains("ReceivingID") Then dgvReceivings.Columns("ReceivingID").Visible = False
        If dgvReceivings.Columns.Contains("SupplierID") Then dgvReceivings.Columns("SupplierID").Visible = False

        If dgvReceivings.Rows.Count > 0 Then
            dgvReceivings.Rows(0).Selected = True
            LoadReceivingItems(Convert.ToInt32(dgvReceivings.Rows(0).Cells("ReceivingID").Value))
        Else
            dgvRecvItems.DataSource = Nothing
        End If

        ' Returns
        dgvReturns.DataSource = DatabaseHelper.GetPendingReturns()
        dgvReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvReturns.Columns.Contains("ReturnID") Then dgvReturns.Columns("ReturnID").Visible = False
        If dgvReturns.Columns.Contains("IsDefective") Then dgvReturns.Columns("IsDefective").Visible = False
    End Sub

    Private Sub dgvReceivings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReceivings.CellClick
        If e.RowIndex >= 0 Then
            Dim id As Integer = Convert.ToInt32(dgvReceivings.Rows(e.RowIndex).Cells("ReceivingID").Value)
            LoadReceivingItems(id)
        End If
    End Sub

    Private Sub LoadReceivingItems(receivingID As Integer)
        dgvRecvItems.DataSource = DatabaseHelper.GetReceivingItems(receivingID)
        dgvRecvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvRecvItems.Columns.Contains("HardwareID") Then dgvRecvItems.Columns("HardwareID").Visible = False
    End Sub

    Private Sub btnApproveRecv_Click(sender As Object, e As EventArgs) Handles btnApproveRecv.Click
        If dgvReceivings.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReceivings.SelectedRows(0).Cells("ReceivingID").Value)
        If DatabaseHelper.ApproveReceiving(id, _user.Username) Then
            MessageBox.Show("Delivery Approved! Stock added.", "Success")
            LoadAllData()
        End If
    End Sub

    Private Sub btnRejectRecv_Click(sender As Object, e As EventArgs) Handles btnRejectRecv.Click
        If dgvReceivings.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReceivings.SelectedRows(0).Cells("ReceivingID").Value)
        If DatabaseHelper.RejectReceiving(id, _user.Username) Then
            MessageBox.Show("Delivery Rejected.", "Success")
            LoadAllData()
        End If
    End Sub

    Private Sub btnApproveReturn_Click(sender As Object, e As EventArgs) Handles btnApproveReturn.Click
        If dgvReturns.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReturns.SelectedRows(0).Cells("ReturnID").Value)
        If DatabaseHelper.ProcessReturn(id, _user.Username, False) Then
            MessageBox.Show("Return Approved. Stock restored.", "Success")
            LoadAllData()
        End If
    End Sub

    Private Sub btnWriteOff_Click(sender As Object, e As EventArgs) Handles btnWriteOff.Click
        If dgvReturns.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReturns.SelectedRows(0).Cells("ReturnID").Value)
        If MessageBox.Show("Write-off this item? It will not return to stock.", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If DatabaseHelper.ProcessReturn(id, _user.Username, True) Then
                MessageBox.Show("Item written off.", "Success")
                LoadAllData()
            End If
        End If
    End Sub
End Class