Public Class UserManagementControl
    Inherits UserControl

    Private currentUser As User = Nothing

    Public Sub SetCurrentUser(user As User)
        currentUser = user

        ' Kung hindi Admin, itago ang Add User button
        If currentUser Is Nothing OrElse Not currentUser.CanManageUsers() Then
            btnAddUser.Visible = False
        End If

        LoadUsers()
    End Sub

    Public Sub LoadUsers()
        Try
            dgvUsers.DataSource = DatabaseHelper.GetAllUsers()
            If dgvUsers.Columns.Contains("UserID") Then dgvUsers.Columns("UserID").Visible = False
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If currentUser Is Nothing OrElse Not currentUser.CanManageUsers() Then
            MessageBox.Show("Only Administrators can add new users.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using frm As New AddUserForm(currentUser)
            If frm.ShowDialog(Me) = DialogResult.OK Then
                LoadUsers() ' Refresh ang grid
            End If
        End Using
    End Sub
End Class