Public Class ApprovalsForm
    Private _user As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub ApprovalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _user Is Nothing OrElse (Not _user.CanApproveReceivingsAndReturns() AndAlso Not _user.CanApproveIssuances()) Then
            MessageBox.Show("Access Denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        ' Role-Based Tab Visibility
        If Not _user.CanApproveReceivingsAndReturns() Then
            TabControl1.TabPages.Remove(TabPage1)
            TabControl1.TabPages.Remove(TabPage3)
        End If

        If Not _user.CanApproveIssuances() Then
            TabControl1.TabPages.Remove(TabPageIssuances)
        End If

        LoadAllData()
    End Sub

    Private Sub LoadAllData()
        Dim search As String = txtSearch.Text.Trim().Replace("'", "''") ' Escape quotes for SQL

        ' Receivings
        Dim dtRecv As DataTable = DatabaseHelper.GetPendingReceivings()
        Dim dvRecv As New DataView(dtRecv)
        If Not String.IsNullOrWhiteSpace(search) Then
            dvRecv.RowFilter = "Supplier LIKE '%" & search & "%' OR ReceivedBy LIKE '%" & search & "%'"
        End If
        dgvReceivings.DataSource = dvRecv
        dgvReceivings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvReceivings.Columns.Contains("ReceivingID") Then dgvReceivings.Columns("ReceivingID").Visible = False
        If dgvReceivings.Columns.Contains("SupplierID") Then dgvReceivings.Columns("SupplierID").Visible = False

        If dgvReceivings.Rows.Count > 0 Then
            dgvReceivings.Rows(0).Selected = True
            LoadReceivingItems(Convert.ToInt32(dgvReceivings.Rows(0).Cells("ReceivingID").Value))
        Else
            dgvRecvItems.DataSource = Nothing
        End If

        ' Issuances
        Dim dtIss As DataTable = DatabaseHelper.GetPendingIssuances()
        Dim dvIss As New DataView(dtIss)
        If Not String.IsNullOrWhiteSpace(search) Then
            dvIss.RowFilter = "ItemName LIKE '%" & search & "%' OR IssuedTo LIKE '%" & search & "%' OR IssuedBy LIKE '%" & search & "%'"
        End If
        dgvIssuances.DataSource = dvIss
        dgvIssuances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvIssuances.Columns.Contains("IssuanceID") Then dgvIssuances.Columns("IssuanceID").Visible = False

        ' Returns
        Dim dtRet As DataTable = DatabaseHelper.GetPendingReturns()
        Dim dvRet As New DataView(dtRet)
        If Not String.IsNullOrWhiteSpace(search) Then
            dvRet.RowFilter = "ItemName LIKE '%" & search & "%' OR IssuedTo LIKE '%" & search & "%' OR IssuedBy LIKE '%" & search & "%'"
        End If
        dgvReturns.DataSource = dvRet
        dgvReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvReturns.Columns.Contains("ReturnID") Then dgvReturns.Columns("ReturnID").Visible = False
        If dgvReturns.Columns.Contains("IsDefective") Then dgvReturns.Columns("IsDefective").Visible = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAllData()
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

    ' --- RECEIVINGS ---
    Private Sub btnApproveRecv_Click(sender As Object, e As EventArgs) Handles btnApproveRecv.Click
        If dgvReceivings.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReceivings.SelectedRows(0).Cells("ReceivingID").Value)
        If DatabaseHelper.ApproveReceiving(id, _user.Username) Then
            MessageBox.Show("Delivery Approved! Stock added.", "Success")
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Approved Receiving ID: " & id)
            LoadAllData()
        End If
    End Sub

    Private Sub btnRejectRecv_Click(sender As Object, e As EventArgs) Handles btnRejectRecv.Click
        If dgvReceivings.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReceivings.SelectedRows(0).Cells("ReceivingID").Value)
        If DatabaseHelper.RejectReceiving(id, _user.Username) Then
            MessageBox.Show("Delivery Rejected.", "Success")
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Rejected Receiving ID: " & id)
            LoadAllData()
        End If
    End Sub

    ' --- ISSUANCES ---
    Private Sub btnApproveIss_Click(sender As Object, e As EventArgs) Handles btnApproveIss.Click
        If dgvIssuances.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvIssuances.SelectedRows(0).Cells("IssuanceID").Value)
        If DatabaseHelper.ApproveIssuance(id, _user.Username) Then
            MessageBox.Show("Issuance Approved! Stock deducted.", "Success")
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Approved Issuance ID: " & id)
            LoadAllData()
        Else
            MessageBox.Show("Failed to approve. Stock may be insufficient.", "Error")
        End If
    End Sub

    Private Sub btnRejectIss_Click(sender As Object, e As EventArgs) Handles btnRejectIss.Click
        If dgvIssuances.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvIssuances.SelectedRows(0).Cells("IssuanceID").Value)
        If DatabaseHelper.RejectIssuance(id, _user.Username) Then
            MessageBox.Show("Issuance Request Rejected.", "Success")
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Rejected Issuance ID: " & id)
            LoadAllData()
        End If
    End Sub

    ' --- RETURNS ---
    Private Sub btnApproveReturn_Click(sender As Object, e As EventArgs) Handles btnApproveReturn.Click
        If dgvReturns.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReturns.SelectedRows(0).Cells("ReturnID").Value)
        If DatabaseHelper.ProcessReturn(id, _user.Username, False) Then
            MessageBox.Show("Return Approved. Stock restored.", "Success")
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Approved Return ID: " & id)
            LoadAllData()
        End If
    End Sub

    Private Sub btnWriteOff_Click(sender As Object, e As EventArgs) Handles btnWriteOff.Click
        If dgvReturns.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReturns.SelectedRows(0).Cells("ReturnID").Value)
        If MessageBox.Show("Write-off this item? It will not return to stock.", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If DatabaseHelper.ProcessReturn(id, _user.Username, True) Then
                MessageBox.Show("Item written off.", "Success")
                DatabaseHelper.LogActivity(_user.Username, _user.Role, "Written-off Return ID: " & id)
                LoadAllData()
            End If
        End If
    End Sub
End Class