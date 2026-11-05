Public Class User
    Public Property ID As Integer
    Public Property Username As String
    Public Property FullName As String
    Public Property Role As String
    Public Property Status As String = "Active"

    Public ReadOnly Property RoleDisplay As String
        Get
            Select Case Role
                Case "Administrator" : Return "🔴 Administrator"
                Case "Inventory Manager" : Return "🔵 Inventory Manager"
                Case "Staff" : Return "🟢 Staff"
                Case Else : Return Role
            End Select
        End Get
    End Property

    ' PERMISSIONS
    Public Function CanManageUsers() As Boolean
        Return Role = "Administrator"
    End Function

    Public Function CanApproveReceivingsAndReturns() As Boolean
        Return Role = "Administrator"
    End Function

    Public Function CanApproveIssuances() As Boolean
        Return Role = "Administrator" OrElse Role = "Inventory Manager"
    End Function

    Public Function CanManageMasterList() As Boolean
        Return Role = "Administrator" OrElse Role = "Inventory Manager"
    End Function

    Public Function CanToggleStatus() As Boolean
        Return Role = "Administrator"
    End Function

    Public Function CanReceive() As Boolean
        Return Role = "Administrator" OrElse Role = "Inventory Manager"
    End Function

    Public Function CanIssue() As Boolean
        Return Role = "Administrator" OrElse Role = "Inventory Manager" OrElse Role = "Staff"
    End Function
End Class