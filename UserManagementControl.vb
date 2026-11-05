Public Class UserManagementControl
    Inherits UserControl

    Private currentUser As User = Nothing

    Public Sub SetCurrentUser(user As User)
        currentUser = user

        If currentUser Is Nothing OrElse Not currentUser.CanManageUsers() Then
            btnAddUser.Visible = False
        End If

        LoadUsers()
    End Sub

    Public Sub LoadUsers()
        Try
            Dim searchQuery As String = txtSearch.Text.Trim()
            If searchQuery = "Search user..." Then searchQuery = ""

            dgvUsers.DataSource = DatabaseHelper.GetAllUsers(searchQuery)
            If dgvUsers.Columns.Contains("UserID") Then dgvUsers.Columns("UserID").Visible = False
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadUsers()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search user..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search user..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If currentUser Is Nothing OrElse Not currentUser.CanManageUsers() Then
            MessageBox.Show("Only Administrators can add new users.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using frm As New AddUserForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadUsers()
            End If
        End Using
    End Sub
End Class