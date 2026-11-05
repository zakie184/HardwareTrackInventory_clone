Public Class AddHardwareForm
    Private _currentUser As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _currentUser = user
    End Sub

    Private Sub AddHardwareForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _currentUser Is Nothing OrElse Not _currentUser.CanManageMasterList() Then
            MessageBox.Show("Permission denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        ' FIX: Passed an empty string "" to fetch all categories for the dropdown
        Dim dtCategories As DataTable = DatabaseHelper.GetAllCategories("")
        cmbCategory.DataSource = dtCategories
        cmbCategory.DisplayMember = "CategoryName"
        cmbCategory.ValueMember = "CategoryName"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(cmbCategory.Text) Then
            MessageBox.Show("Please enter Item Name and Category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim itemName As String = txtName.Text.Trim()
        Dim itemCategory As String = cmbCategory.Text.Trim()
        Dim initialQty As Integer = CInt(numQty.Value)

        If DatabaseHelper.AddHardwareWithStock(itemName, itemCategory, initialQty) Then
            DatabaseHelper.LogActivity(_currentUser.Username, _currentUser.Role, "Added new hardware: " & itemName)
            MessageBox.Show("Hardware added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to add hardware. This item name already exists in the master list.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class