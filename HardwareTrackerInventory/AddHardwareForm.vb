Public Class AddHardwareForm
    Private _currentUser As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _currentUser = user
    End Sub

    Private Sub AddHardwareForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maglagay ng default suggestions para madali mag-add
        cmbCategory.Items.AddRange(New String() {"Laptop", "Desktop", "Monitor", "Peripheral", "Printer", "Network"})

        ' I-load ang mga branches
        Dim dtBranches As DataTable = DatabaseHelper.GetAllBranches()
        cmbBranch.DataSource = dtBranches
        cmbBranch.DisplayMember = "Name"
        cmbBranch.ValueMember = "BranchID"

        ' I-set ang default branch base sa user (kung may branch siya)
        If _currentUser.BranchID.HasValue Then
            cmbBranch.SelectedValue = _currentUser.BranchID.Value
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(cmbCategory.Text) Then
            MessageBox.Show("Please enter both Item Name and Category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbBranch.SelectedIndex < 0 Then
            MessageBox.Show("Please select a Branch.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim itemName As String = txtName.Text.Trim()
        Dim itemCategory As String = cmbCategory.Text.Trim()
        Dim branchID As Integer = Convert.ToInt32(cmbBranch.SelectedValue)
        Dim initialQty As Integer = CInt(numQty.Value)

        If DatabaseHelper.AddHardwareWithStock(itemName, itemCategory, branchID, initialQty) Then
            DatabaseHelper.LogActivity(_currentUser.Username, _currentUser.Role, "Added new hardware: " & itemName & " (" & initialQty & " pcs)")
            MessageBox.Show("Hardware added successfully with " & initialQty & " initial stock!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to add hardware. Item might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class