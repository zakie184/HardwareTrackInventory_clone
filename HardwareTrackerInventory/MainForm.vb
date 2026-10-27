Public Class MainForm
    Private currentUser As User = Nothing
    Private dashboardPage As DashboardControl = Nothing
    Private hardwarePage As HardwareControl = Nothing
    Private usersPage As UserManagementControl = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub SetUser(user As User)
        currentUser = user
        lblHeaderUser.Text = "👤 " & user.FullName
        lblHeaderSub.Text = "Welcome, " & user.FullName
        lblFooterRight.Text = "Logged in as: " & user.FullName & " | Role: " & user.Role

        dashboardPage = New DashboardControl()
        dashboardPage.SetCurrentUser(currentUser)

        hardwarePage = New HardwareControl()
        hardwarePage.SetCurrentUser(currentUser)

        If currentUser.CanManageUsers() Then
            usersPage = New UserManagementControl()
            usersPage.SetCurrentUser(currentUser)
        End If

        btnUsers.Visible = currentUser.CanManageUsers()

        LoadPage(dashboardPage)
        HighlightButton(btnDashboard)

        ' Simulan ang timer
        tmrNotifications.Start()
        CheckNotifications()
    End Sub

    Private Sub LoadPage(page As UserControl)
        pnlContent.Controls.Clear()
        page.Dock = DockStyle.Fill
        pnlContent.Controls.Add(page)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadPage(dashboardPage)
        HighlightButton(btnDashboard)
    End Sub

    Private Sub btnHardware_Click(sender As Object, e As EventArgs) Handles btnHardware.Click
        LoadPage(hardwarePage)
        HighlightButton(btnHardware)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        If currentUser.CanManageUsers() Then
            LoadPage(usersPage)
            HighlightButton(btnUsers)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        tmrNotifications.Stop()
        Me.Hide()
        Dim login As New LoginForm()
        login.Show()
    End Sub

    Private Sub HighlightButton(activeBtn As Button)
        Dim btns As Button() = {btnDashboard, btnHardware, btnUsers}
        For Each b In btns
            b.BackColor = Color.Transparent
            b.ForeColor = Color.White
        Next
        activeBtn.BackColor = Color.FromArgb(245, 176, 65)
        activeBtn.ForeColor = Color.FromArgb(26, 54, 126)
    End Sub

    ' NOTIFICATION LOGIC
    Private Sub tmrNotifications_Tick(sender As Object, e As EventArgs) Handles tmrNotifications.Tick
        CheckNotifications()
    End Sub

    Private Sub CheckNotifications()
        If currentUser Is Nothing Then Return

        Dim unread As Integer = DatabaseHelper.GetUnreadNotificationCount(currentUser.Username)

        If unread > 0 Then
            btnNotifications.Text = "🔔 (" & unread & ")"
            btnNotifications.ForeColor = Color.FromArgb(245, 176, 65) ' Yellow highlight kapag may bago
        Else
            btnNotifications.Text = "🔔"
            btnNotifications.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        Using frm As New NotificationForm(currentUser)
            frm.ShowDialog(Me)
            ' Pagka-close, i-refresh ang count
            CheckNotifications()
        End Using
    End Sub
End Class