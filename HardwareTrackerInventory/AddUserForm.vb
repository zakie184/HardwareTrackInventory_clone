Public Class AddUserForm
    Private _currentUser As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _currentUser = user
    End Sub

    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Roles
        cmbRole.DataSource = DatabaseHelper.GetAllRoles()
        cmbRole.DisplayMember = "RoleName"
        cmbRole.ValueMember = "RoleID"

        ' Load Branches
        cmbBranch.DataSource = DatabaseHelper.GetAllBranches()
        cmbBranch.DisplayMember = "Name"
        cmbBranch.ValueMember = "BranchID"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbRole.SelectedIndex < 0 OrElse cmbBranch.SelectedIndex < 0 Then
            MessageBox.Show("Please select a Role and Branch.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim un As String = txtUsername.Text.Trim()
        Dim pw As String = txtPassword.Text.Trim()
        Dim fn As String = txtFullName.Text.Trim()
        Dim rid As Integer = Convert.ToInt32(cmbRole.SelectedValue)
        Dim bid As Integer = Convert.ToInt32(cmbBranch.SelectedValue)

        If DatabaseHelper.AddUser(un, pw, fn, rid, bid) Then
            DatabaseHelper.LogActivity(_currentUser.Username, _currentUser.Role, "Added new user: " & un)
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to add user. Username might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class