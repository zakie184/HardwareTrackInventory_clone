Public Class NotificationForm
    Private _user As User = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotifications()
    End Sub

    Private Sub LoadNotifications()
        lstNotifications.Items.Clear()
        Dim dt As DataTable = DatabaseHelper.GetUnreadNotifications(_user.Username)

        If dt.Rows.Count = 0 Then
            lstNotifications.Items.Add("Wala kang bagong notification.")
        Else
            For Each row As DataRow In dt.Rows
                Dim time As String = Convert.ToDateTime(row("DateCreated")).ToString("MMM dd, hh:mm tt")
                lstNotifications.Items.Add("[" & time & "] " & row("Message").ToString())
            Next
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        DatabaseHelper.MarkNotificationsAsRead(_user.Username)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class