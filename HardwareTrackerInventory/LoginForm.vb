Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private _currentUser As User = Nothing

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Set(value As User)
            _currentUser = value
        End Set
    End Property

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dt As DataTable = DatabaseHelper.GetUser(txtUsername.Text.Trim())
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Username not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataRow = dt.Rows(0)
        If row("PasswordHash").ToString() <> txtPassword.Text Then
            MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If row("Status").ToString() <> "Active" Then
            MessageBox.Show("This account is inactive. Please contact an Administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        CurrentUser = New User()
        CurrentUser.ID = Convert.ToInt32(row("UserID"))
        CurrentUser.Username = row("Username").ToString()
        CurrentUser.FullName = row("FullName").ToString()
        CurrentUser.Role = row("Role").ToString()
        CurrentUser.Status = row("Status").ToString()

        If row("BranchID") IsNot DBNull.Value Then CurrentUser.BranchID = Convert.ToInt32(row("BranchID"))
        If row("BranchName") IsNot DBNull.Value Then CurrentUser.BranchName = row("BranchName").ToString()

        DatabaseHelper.UpdateLastLogin(CurrentUser.Username)
        DatabaseHelper.LogActivity(CurrentUser.Username, CurrentUser.Role, "Logged in")

        Dim mainForm As New MainForm()
        mainForm.SetUser(CurrentUser)
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class