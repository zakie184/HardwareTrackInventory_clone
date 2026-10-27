Imports MySql.Data.MySqlClient
Public Class KeyData
    Private Const SERVER As String = "127.0.0.1"
    Private Const PORT As String = "3306"
    Private Const DATABASE As String = "HardwareTrackInventory"
    Private Const USER As String = "root"
    Private Const PASSWORD As String = "root"

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return $"Server={SERVER};Port={PORT};Database={DATABASE};Uid={USER};Pwd={PASSWORD};Pooling=True;"
        End Get
    End Property

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Class