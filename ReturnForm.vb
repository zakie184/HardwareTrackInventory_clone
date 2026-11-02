Public Class ReturnForm
    Private _user As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' FIX: Added permission check to match documentation
        If _user Is Nothing OrElse Not _user.CanIssue() Then
            MessageBox.Show("Permission denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        Dim dt As DataTable = DatabaseHelper.GetApprovedIssuances()
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Walang active na sold item na pwedeng ibalik.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If
        cmbIssuance.DataSource = dt
        cmbIssuance.DisplayMember = "ItemName"
        cmbIssuance.ValueMember = "IssuanceID"
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
            MessageBox.Show("Return request submitted! Waiting for Admin approval.", "Success")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to submit return.", "Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class