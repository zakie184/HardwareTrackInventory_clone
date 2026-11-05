Public Class CategoryControl
    Inherits UserControl

    Private currentUser As User = Nothing
    Private selectedID As Integer = -1

    Public Sub SetCurrentUser(user As User)
        currentUser = user
        ApplyPermissions()
        LoadCategories()
    End Sub

    Private Sub ApplyPermissions()
        If currentUser Is Nothing Then Return
        Dim canManage As Boolean = currentUser.CanManageMasterList()
        pnlBottom.Visible = canManage
    End Sub

    Public Sub LoadCategories()
        Try
            Dim searchQuery As String = txtSearch.Text.Trim()
            If searchQuery = "Search category..." Then searchQuery = ""

            dgvCategories.DataSource = DatabaseHelper.GetAllCategories(searchQuery)
            If dgvCategories.Columns.Contains("CategoryID") Then dgvCategories.Columns("CategoryID").Visible = False
            If dgvCategories.Columns.Contains("CategoryName") Then dgvCategories.Columns("CategoryName").HeaderText = "Category Name"
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            selectedID = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCategories()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search category..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search category..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtCategoryName.Text) Then
            MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DatabaseHelper.AddCategory(txtCategoryName.Text.Trim()) Then
            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCategoryName.Clear()
            LoadCategories()
        Else
            MessageBox.Show("Failed to add category. It might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellClick
        If e.RowIndex >= 0 Then
            selectedID = Convert.ToInt32(dgvCategories.Rows(e.RowIndex).Cells("CategoryID").Value)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedID = -1 Then
            MessageBox.Show("Please select a category to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this category?" & vbCrLf &
                           "Existing hardware with this category will NOT be affected.",
                           "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DatabaseHelper.DeleteCategory(selectedID) Then
                MessageBox.Show("Category deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadCategories()
            Else
                MessageBox.Show("Failed to delete category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class