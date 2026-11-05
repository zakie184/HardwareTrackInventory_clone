Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    ' AUTH
    Public Shared Function GetUser(username As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT u.UserID, u.Username, u.PasswordHash, u.FullName, r.RoleName AS Role, u.Status " &
                                  "FROM Users u JOIN Roles r ON u.RoleID = r.RoleID WHERE u.Username = @u"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Sub UpdateLastLogin(username As String)
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE Users SET LastLogin = NOW() WHERE Username = @u", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
        End Try
    End Sub

    Public Shared Function AddUser(username As String, password As String, fullName As String, roleID As Integer) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "INSERT INTO Users (Username, PasswordHash, FullName, RoleID, Status) VALUES (@u, @p, @f, @r, 'Active')"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", SecurityHelper.HashPassword(password))
                    cmd.Parameters.AddWithValue("@f", fullName)
                    cmd.Parameters.AddWithValue("@r", roleID)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' NOTIFICATIONS
    Public Shared Sub AddNotification(recipient As String, message As String)
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO Notifications (RecipientUsername, Message) VALUES (@u, @msg)", conn)
                    cmd.Parameters.AddWithValue("@u", recipient)
                    cmd.Parameters.AddWithValue("@msg", message)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
        End Try
    End Sub

    Public Shared Function GetUnreadNotificationCount(username As String) As Integer
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Notifications WHERE RecipientUsername = @u AND IsRead = 0", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function GetUnreadNotifications(username As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT Message, DateCreated FROM Notifications WHERE RecipientUsername = @u AND IsRead = 0 ORDER BY DateCreated DESC"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Sub MarkNotificationsAsRead(username As String)
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE Notifications SET IsRead = 1 WHERE RecipientUsername = @u", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
        End Try
    End Sub

    ' USERS, ROLES, CATEGORIES
    Public Shared Function GetAllRoles() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter("SELECT RoleID, RoleName FROM Roles", conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetAllUsers(searchQuery As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT u.UserID, u.Username, u.FullName, r.RoleName AS Role, u.Status " &
                                  "FROM Users u JOIN Roles r ON u.RoleID = r.RoleID " &
                                  "WHERE (@search = '' OR u.Username LIKE @search OR u.FullName LIKE @search OR r.RoleName LIKE @search) " &
                                  "ORDER BY u.Username"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetAllCategories(searchQuery As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT CategoryID, CategoryName FROM Categories " &
                                  "WHERE (@search = '' OR CategoryName LIKE @search) ORDER BY CategoryName"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function AddCategory(name As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO Categories (CategoryName) VALUES (@n)", conn)
                    cmd.Parameters.AddWithValue("@n", name)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function DeleteCategory(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM Categories WHERE CategoryID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' HARDWARE
    Public Shared Function GetAllSuppliers() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter("SELECT * FROM Suppliers ORDER BY Name", conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetAllHardware(searchQuery As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT h.HardwareID, h.Name, h.Category, h.Status, h.Quantity AS OnHand, " &
                                  "COALESCE((SELECT SUM(ri.Quantity) FROM ReceivingItems ri JOIN Receivings r ON r.ReceivingID = ri.ReceivingID WHERE ri.HardwareID = h.HardwareID AND r.Status='Approved'), 0) AS StockIn, " &
                                  "COALESCE((SELECT SUM(i.QuantityIssued) FROM Issuances i WHERE i.HardwareID = h.HardwareID AND i.Status='Approved'), 0) AS StockOut " &
                                  "FROM Hardware h WHERE (@search = '' OR h.Name LIKE @search OR h.Category LIKE @search) ORDER BY h.Name"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetActiveHardware() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter("SELECT HardwareID, Name, Category, Quantity FROM Hardware WHERE Status='Active' ORDER BY Name", conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function AddHardwareWithStock(name As String, category As String, initialQty As Integer) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()

                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM Hardware WHERE Name = @n", conn)
                    checkCmd.Parameters.AddWithValue("@n", name)
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then Return False
                End Using

                Using cmd As New MySqlCommand("INSERT INTO Hardware (Name, Category, Status, Quantity) VALUES (@n, @c, 'Active', @q)", conn)
                    cmd.Parameters.AddWithValue("@n", name)
                    cmd.Parameters.AddWithValue("@c", category)
                    cmd.Parameters.AddWithValue("@q", initialQty)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function SetHardwareStatus(id As Integer, status As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE Hardware SET Status=@s WHERE HardwareID=@id", conn)
                    cmd.Parameters.AddWithValue("@s", status)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' DASHBOARD
    Public Shared Function GetTotalCount() As Integer
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COALESCE(SUM(Quantity),0) FROM Hardware", conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function GetAvailableCount() As Integer
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Hardware WHERE Status='Active'", conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function GetLowStockCount(threshold As Integer) As Integer
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Hardware WHERE Status='Active' AND Quantity <= @t", conn)
                    cmd.Parameters.AddWithValue("@t", threshold)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function GetLowStockItems(threshold As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT HardwareID, Name, Category, 'N/A' AS Location, Quantity FROM Hardware WHERE Status='Active' AND Quantity <= @t ORDER BY Quantity"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@t", threshold)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetInventoryByCategory() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT Category, COALESCE(SUM(Quantity), 0) AS Total FROM Hardware GROUP BY Category HAVING Total > 0"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    ' RECEIVINGS
    Public Shared Function CreateReceivingRequest(supplierID As Integer, receivedBy As String, lines As List(Of ReceivingLine)) As Boolean
        If lines Is Nothing OrElse lines.Count = 0 Then Return False
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim rid As Integer
                        Using cmd As New MySqlCommand("INSERT INTO Receivings (SupplierID, ReceivedBy, Status) VALUES (@s, @u, 'Pending'); SELECT LAST_INSERT_ID();", conn, trans)
                            cmd.Parameters.AddWithValue("@s", supplierID)
                            cmd.Parameters.AddWithValue("@u", receivedBy)
                            rid = Convert.ToInt32(cmd.ExecuteScalar())
                        End Using
                        For Each line In lines
                            Using cmd As New MySqlCommand("INSERT INTO ReceivingItems (ReceivingID, HardwareID, Quantity) VALUES (@rid, @hid, @q)", conn, trans)
                                cmd.Parameters.AddWithValue("@rid", rid)
                                cmd.Parameters.AddWithValue("@hid", line.HardwareID)
                                cmd.Parameters.AddWithValue("@q", line.Quantity)
                                cmd.ExecuteNonQuery()
                            End Using
                        Next
                        trans.Commit()
                        Using cmd As New MySqlCommand("INSERT INTO Notifications (RecipientUsername, Message) SELECT Username, @msg FROM Users WHERE RoleID = 1", conn)
                            cmd.Parameters.AddWithValue("@msg", "New Receiving Request from " & receivedBy & " (ID: " & rid & ")")
                            cmd.ExecuteNonQuery()
                        End Using
                        Return True
                    Catch
                        trans.Rollback() : Return False
                    End Try
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function GetPendingReceivings() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT r.ReceivingID, r.SupplierID, s.Name AS Supplier, r.ReceivedBy, r.DateReceived " &
                                  "FROM Receivings r JOIN Suppliers s ON r.SupplierID = s.SupplierID WHERE r.Status='Pending'"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetReceivingItems(receivingID As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT ri.HardwareID, h.Name AS ItemName, h.Category, ri.Quantity " &
                                  "FROM ReceivingItems ri JOIN Hardware h ON ri.HardwareID = h.HardwareID WHERE ri.ReceivingID=@id"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@id", receivingID)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function ApproveReceiving(receivingID As Integer, approvedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim receivedBy As String = ""
                        Using cmd As New MySqlCommand("SELECT ReceivedBy FROM Receivings WHERE ReceivingID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", receivingID)
                            receivedBy = cmd.ExecuteScalar().ToString()
                        End Using

                        Dim itemsDt As New DataTable()
                        Using cmd As New MySqlCommand("SELECT HardwareID, Quantity FROM ReceivingItems WHERE ReceivingID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", receivingID)
                            Dim adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(itemsDt)
                        End Using

                        For Each row As DataRow In itemsDt.Rows
                            Dim hid = Convert.ToInt32(row("HardwareID"))
                            Dim qty = Convert.ToInt32(row("Quantity"))
                            Using cmd As New MySqlCommand("UPDATE Hardware SET Quantity = Quantity + @q WHERE HardwareID = @h", conn, trans)
                                cmd.Parameters.AddWithValue("@h", hid)
                                cmd.Parameters.AddWithValue("@q", qty)
                                cmd.ExecuteNonQuery()
                            End Using
                        Next

                        Using cmd As New MySqlCommand("UPDATE Receivings SET Status='Approved', ApprovedBy=@u, ApprovalDate=NOW() WHERE ReceivingID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@u", approvedBy)
                            cmd.Parameters.AddWithValue("@id", receivingID)
                            cmd.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                        AddNotification(receivedBy, "Your Receiving Request (ID: " & receivingID & ") has been APPROVED.")
                        Return True
                    Catch
                        trans.Rollback() : Return False
                    End Try
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function RejectReceiving(receivingID As Integer, rejectedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim receivedBy As String = ""
                Using cmd As New MySqlCommand("SELECT ReceivedBy FROM Receivings WHERE ReceivingID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", receivingID)
                    receivedBy = cmd.ExecuteScalar().ToString()
                End Using

                Using cmd As New MySqlCommand("UPDATE Receivings SET Status='Rejected', ApprovedBy=@u, ApprovalDate=NOW() WHERE ReceivingID=@id", conn)
                    cmd.Parameters.AddWithValue("@u", rejectedBy)
                    cmd.Parameters.AddWithValue("@id", receivingID)
                    If cmd.ExecuteNonQuery() > 0 Then
                        AddNotification(receivedBy, "Your Receiving Request (ID: " & receivingID & ") has been REJECTED.")
                        Return True
                    End If
                    Return False
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' ISSUANCES
    Public Shared Function CreateIssuanceRequest(hardwareID As Integer, customerName As String, quantity As Integer, soldBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()

                Dim currentStock As Integer = 0
                Using cmd As New MySqlCommand("SELECT Quantity FROM Hardware WHERE HardwareID=@h", conn)
                    cmd.Parameters.AddWithValue("@h", hardwareID)
                    Dim res = cmd.ExecuteScalar()
                    If res IsNot Nothing Then currentStock = Convert.ToInt32(res)
                End Using

                If currentStock < quantity Then Return False

                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Using cmd As New MySqlCommand("INSERT INTO Issuances (HardwareID, IssuedTo, QuantityIssued, IssuedBy, Status) VALUES (@h, @to, @q, @by, 'Pending')", conn, trans)
                            cmd.Parameters.AddWithValue("@h", hardwareID)
                            cmd.Parameters.AddWithValue("@to", customerName)
                            cmd.Parameters.AddWithValue("@q", quantity)
                            cmd.Parameters.AddWithValue("@by", soldBy)
                            cmd.ExecuteNonQuery()
                        End Using
                        trans.Commit()
                        Using cmd As New MySqlCommand("INSERT INTO Notifications (RecipientUsername, Message) SELECT Username, @msg FROM Users WHERE RoleID IN (1, 2)", conn)
                            cmd.Parameters.AddWithValue("@msg", "New Issuance Request from " & soldBy & " for " & customerName)
                            cmd.ExecuteNonQuery()
                        End Using
                        Return True
                    Catch
                        trans.Rollback() : Return False
                    End Try
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function GetPendingIssuances() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT i.IssuanceID, h.Name AS ItemName, i.IssuedTo, i.QuantityIssued, i.IssuedBy, i.IssuedDate " &
                                  "FROM Issuances i JOIN Hardware h ON i.HardwareID = h.HardwareID WHERE i.Status = 'Pending'"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function ApproveIssuance(issuanceID As Integer, approvedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim hardwareID As Integer, qty As Integer, issuedBy As String
                        Using cmd As New MySqlCommand("SELECT HardwareID, QuantityIssued, IssuedBy FROM Issuances WHERE IssuanceID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", issuanceID)
                            Using r As MySqlDataReader = cmd.ExecuteReader()
                                If r.Read() Then
                                    hardwareID = Convert.ToInt32(r("HardwareID"))
                                    qty = Convert.ToInt32(r("QuantityIssued"))
                                    issuedBy = r("IssuedBy").ToString()
                                Else
                                    r.Close() : trans.Rollback() : Return False
                                End If
                                r.Close()
                            End Using
                        End Using

                        Dim currentStock As Integer = 0
                        Using cmd As New MySqlCommand("SELECT Quantity FROM Hardware WHERE HardwareID=@h", conn, trans)
                            cmd.Parameters.AddWithValue("@h", hardwareID)
                            Dim res = cmd.ExecuteScalar()
                            If res IsNot Nothing Then currentStock = Convert.ToInt32(res)
                        End Using

                        If currentStock < qty Then
                            trans.Rollback() : Return False
                        End If

                        Using cmd As New MySqlCommand("UPDATE Hardware SET Quantity = Quantity - @q WHERE HardwareID=@h", conn, trans)
                            cmd.Parameters.AddWithValue("@q", qty)
                            cmd.Parameters.AddWithValue("@h", hardwareID)
                            cmd.ExecuteNonQuery()
                        End Using

                        Using cmd As New MySqlCommand("UPDATE Issuances SET Status='Approved', ApprovedBy=@u, ApprovalDate=NOW() WHERE IssuanceID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@u", approvedBy)
                            cmd.Parameters.AddWithValue("@id", issuanceID)
                            cmd.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                        AddNotification(issuedBy, "Your Issuance Request (ID: " & issuanceID & ") has been APPROVED.")
                        Return True
                    Catch
                        trans.Rollback() : Return False
                    End Try
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function RejectIssuance(issuanceID As Integer, rejectedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim issuedBy As String = ""
                Using cmd As New MySqlCommand("SELECT IssuedBy FROM Issuances WHERE IssuanceID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", issuanceID)
                    issuedBy = cmd.ExecuteScalar().ToString()
                End Using

                Using cmd As New MySqlCommand("UPDATE Issuances SET Status='Rejected', ApprovedBy=@u, ApprovalDate=NOW() WHERE IssuanceID=@id", conn)
                    cmd.Parameters.AddWithValue("@u", rejectedBy)
                    cmd.Parameters.AddWithValue("@id", issuanceID)
                    If cmd.ExecuteNonQuery() > 0 Then
                        AddNotification(issuedBy, "Your Issuance Request (ID: " & issuanceID & ") has been REJECTED.")
                        Return True
                    End If
                    Return False
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' RETURNS
    Public Shared Function GetApprovedIssuances() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT i.IssuanceID, h.Name AS ItemName, i.IssuedTo, " &
                                  "i.QuantityIssued, COALESCE(SUM(r.QuantityReturned), 0) AS TotalReturned, " &
                                  "(i.QuantityIssued - COALESCE(SUM(r.QuantityReturned), 0)) AS RemainingQty " &
                                  "FROM Issuances i " &
                                  "JOIN Hardware h ON i.HardwareID = h.HardwareID " &
                                  "LEFT JOIN Returns r ON i.IssuanceID = r.IssuanceID AND r.Status != 'Rejected' " &
                                  "WHERE i.Status = 'Approved' " &
                                  "GROUP BY i.IssuanceID, h.Name, i.IssuedTo, i.QuantityIssued " &
                                  "HAVING RemainingQty > 0"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function CreateReturnRequest(issuanceID As Integer, quantity As Integer, isDefective As Boolean) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "INSERT INTO Returns (IssuanceID, QuantityReturned, IsDefective, Status) VALUES (@id, @qty, @def, 'Pending')"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@id", issuanceID)
                    cmd.Parameters.AddWithValue("@qty", quantity)
                    cmd.Parameters.AddWithValue("@def", If(isDefective, 1, 0))
                    If cmd.ExecuteNonQuery() > 0 Then
                        Using cmd2 As New MySqlCommand("INSERT INTO Notifications (RecipientUsername, Message) SELECT Username, @msg FROM Users WHERE RoleID = 1", conn)
                            cmd2.Parameters.AddWithValue("@msg", "New Return Request for Issuance ID: " & issuanceID)
                            cmd2.ExecuteNonQuery()
                        End Using
                        Return True
                    End If
                    Return False
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function GetPendingReturns() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT r.ReturnID, h.Name AS ItemName, r.QuantityReturned, r.IsDefective, i.IssuedTo, r.ReturnDate, i.IssuedBy " &
                                  "FROM Returns r JOIN Issuances i ON r.IssuanceID = i.IssuanceID JOIN Hardware h ON i.HardwareID = h.HardwareID " &
                                  "WHERE r.Status = 'Pending'"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function ProcessReturn(returnID As Integer, approvedBy As String, writeOff As Boolean) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim issuanceID As Integer, qty As Integer, isDefective As Boolean, hardwareID As Integer
                        Dim issuedBy As String = ""
                        Using cmd As New MySqlCommand("SELECT r.IssuanceID, r.QuantityReturned, r.IsDefective, i.IssuedBy, i.HardwareID " &
                                                      "FROM Returns r JOIN Issuances i ON r.IssuanceID = i.IssuanceID WHERE r.ReturnID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", returnID)
                            Using r As MySqlDataReader = cmd.ExecuteReader()
                                If r.Read() Then
                                    issuanceID = Convert.ToInt32(r("IssuanceID"))
                                    qty = Convert.ToInt32(r("QuantityReturned"))
                                    isDefective = Convert.ToBoolean(r("IsDefective"))
                                    issuedBy = r("IssuedBy").ToString()
                                    hardwareID = Convert.ToInt32(r("HardwareID"))
                                Else
                                    r.Close() : trans.Rollback() : Return False
                                End If
                                r.Close()
                            End Using
                        End Using

                        If writeOff Or isDefective Then
                            Using cmd As New MySqlCommand("UPDATE Returns SET Status='WrittenOff' WHERE ReturnID=@id", conn, trans)
                                cmd.Parameters.AddWithValue("@id", returnID)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            Using cmd As New MySqlCommand("UPDATE Hardware SET Quantity = Quantity + @q WHERE HardwareID = @h", conn, trans)
                                cmd.Parameters.AddWithValue("@h", hardwareID)
                                cmd.Parameters.AddWithValue("@q", qty)
                                cmd.ExecuteNonQuery()
                            End Using

                            Using cmd As New MySqlCommand("UPDATE Returns SET Status='Approved' WHERE ReturnID=@id", conn, trans)
                                cmd.Parameters.AddWithValue("@id", returnID)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If

                        trans.Commit()
                        AddNotification(issuedBy, "Your Return Request (ID: " & returnID & ") has been processed.")
                        Return True
                    Catch
                        trans.Rollback() : Return False
                    End Try
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' ACTIVITIES
    Public Shared Sub LogActivity(username As String, role As String, action As String)
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO Activities (Username, UserRole, Action) VALUES (@u, @r, @a)", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@r", role)
                    cmd.Parameters.AddWithValue("@a", action)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
        End Try
    End Sub

    Public Shared Function GetRecentActivities(user As User) As DataTable
        Dim dt As New DataTable()
        If user Is Nothing Then Return dt
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String
                If user.Role = "Administrator" Then
                    q = "SELECT ActivityDate, Username, UserRole, Action FROM Activities ORDER BY ActivityDate DESC LIMIT 15"
                Else
                    q = "SELECT ActivityDate, Username, UserRole, Action FROM Activities WHERE Username = @u ORDER BY ActivityDate DESC LIMIT 15"
                End If
                Using cmd As New MySqlCommand(q, conn)
                    If user.Role <> "Administrator" Then cmd.Parameters.AddWithValue("@u", user.Username)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function
End Class

Public Class ReceivingLine
    Public Property HardwareID As Integer
    Public Property Quantity As Integer
End Class