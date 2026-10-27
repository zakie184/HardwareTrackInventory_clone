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
        LoadApprovals()
    End Sub

    Private Sub LoadApprovals()
        ' --- LOAD RECEIVINGS (IN) ---
        Dim dtRecv As DataTable = DatabaseHelper.GetPendingReceivings()
        dgvReceivings.AutoGenerateColumns = True ' Siguradong lalabas lahat ng columns
        dgvReceivings.DataSource = dtRecv
        If dgvReceivings.Columns.Contains("ReceivingID") Then dgvReceivings.Columns("ReceivingID").Visible = False
        dgvReceivings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' --- LOAD ISSUANCES (OUT) ---
        Dim dtIss As DataTable = DatabaseHelper.GetPendingIssuances()
        dgvIssuances.AutoGenerateColumns = True ' Siguradong lalabas lahat ng columns
        dgvIssuances.DataSource = dtIss
        If dgvIssuances.Columns.Contains("IssuanceID") Then dgvIssuances.Columns("IssuanceID").Visible = False
        dgvIssuances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' --- RECEIVINGS ACTIONS ---
    Private Sub btnApproveRecv_Click(sender As Object, e As EventArgs) Handles btnApproveRecv.Click
        If dgvReceivings.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReceivings.SelectedRows(0).Cells("ReceivingID").Value)

        If DatabaseHelper.ApproveReceiving(id, _user.Username) Then
            MessageBox.Show("Receiving Approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadApprovals()
        End If
    End Sub

    Private Sub btnRejectRecv_Click(sender As Object, e As EventArgs) Handles btnRejectRecv.Click
        If dgvReceivings.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvReceivings.SelectedRows(0).Cells("ReceivingID").Value)

        If DatabaseHelper.RejectReceiving(id, _user.Username) Then
            MessageBox.Show("Receiving Rejected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadApprovals()
        End If
    End Sub

    ' --- ISSUANCES ACTIONS ---
    Private Sub btnApproveIssue_Click(sender As Object, e As EventArgs) Handles btnApproveIssue.Click
        If dgvIssuances.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvIssuances.SelectedRows(0).Cells("IssuanceID").Value)

        If DatabaseHelper.ApproveIssuance(id, _user.Username) Then
            MessageBox.Show("Issuance Approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadApprovals()
        Else
            MessageBox.Show("Failed to approve. Insufficient stock in this specific branch.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRejectIssue_Click(sender As Object, e As EventArgs) Handles btnRejectIssue.Click
        If dgvIssuances.SelectedRows.Count = 0 Then Return
        Dim id As Integer = Convert.ToInt32(dgvIssuances.SelectedRows(0).Cells("IssuanceID").Value)

        If DatabaseHelper.RejectIssuance(id, _user.Username) Then
            MessageBox.Show("Issuance Rejected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadApprovals()
        End If
    End Sub
End Class