Public Class ReturnForm
    Private _user As User = Nothing
    Private _issuancesDt As DataTable = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _user Is Nothing OrElse Not _user.CanIssue() Then
            MessageBox.Show("Permission denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        txtSearch.ForeColor = Color.Gray
        _issuancesDt = DatabaseHelper.GetApprovedIssuances()

        If _issuancesDt.Rows.Count = 0 Then
            MessageBox.Show("No eligible issued items found for return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If

        cmbIssuance.DataSource = _issuancesDt
        cmbIssuance.DisplayMember = "ItemName"
        cmbIssuance.ValueMember = "IssuanceID"
    End Sub

    ' SEARCH BAR LOGIC
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If _issuancesDt Is Nothing Then Return
        Dim search As String = txtSearch.Text.Trim().Replace("'", "''")
        Dim dv As New DataView(_issuancesDt)

        If search <> "" AndAlso search <> "Type to filter dropdown..." Then
            dv.RowFilter = "ItemName LIKE '%" & search & "%' OR IssuedTo LIKE '%" & search & "%'"
        End If

        cmbIssuance.DataSource = dv
        cmbIssuance.DisplayMember = "ItemName"
        cmbIssuance.ValueMember = "IssuanceID"
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Type to filter dropdown..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Type to filter dropdown..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub cmbIssuance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIssuance.SelectedIndexChanged
        If cmbIssuance.SelectedIndex >= 0 Then
            Dim drv As DataRowView = TryCast(cmbIssuance.SelectedItem, DataRowView)
            If drv IsNot Nothing Then
                numQty.Maximum = Convert.ToDecimal(drv("RemainingQty"))
                numQty.Value = numQty.Maximum
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbIssuance.SelectedIndex < 0 Then Return
        Dim id As Integer = Convert.ToInt32(cmbIssuance.SelectedValue)
        Dim qty As Integer = CInt(numQty.Value)
        Dim isDefective As Boolean = chkDefective.Checked

        If DatabaseHelper.CreateReturnRequest(id, qty, isDefective) Then
            MessageBox.Show("Return request submitted! Waiting for Admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Submitted return request for Issuance ID: " & id)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to submit return request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class