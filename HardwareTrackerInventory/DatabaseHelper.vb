Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    ' AUTHENTICATION
    Public Shared Function GetUser(username As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT u.UserID, u.Username, u.PasswordHash, u.FullName, r.RoleName AS Role, u.Status, u.BranchID, b.Name AS BranchName, u.LastLogin " &
                                  "FROM Users u JOIN Roles r ON u.RoleID = r.RoleID LEFT JOIN Branches b ON u.BranchID = b.BranchID WHERE u.Username = @u"
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

    ' USERS & DROPDOWNS
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

    Public Shared Function GetAllBranches() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim adapter As New MySqlDataAdapter("SELECT BranchID, Name FROM Branches", conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetAllUsers() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT u.UserID, u.Username, u.FullName, r.RoleName AS Role, b.Name AS Branch, u.Status " &
                                  "FROM Users u JOIN Roles r ON u.RoleID = r.RoleID LEFT JOIN Branches b ON u.BranchID = b.BranchID ORDER BY u.Username"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function AddUser(username As String, password As String, fullName As String, roleID As Integer, branchID As Integer) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "INSERT INTO Users (Username, PasswordHash, FullName, RoleID, BranchID, Status) VALUES (@u, @p, @f, @r, @b, 'Active')"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    cmd.Parameters.AddWithValue("@f", fullName)
                    cmd.Parameters.AddWithValue("@r", roleID)
                    cmd.Parameters.AddWithValue("@b", branchID)
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

    Public Shared Function GetAllHardware() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT h.HardwareID, h.Name, h.Category, h.Status, COALESCE(SUM(bs.Quantity), 0) AS Quantity, " &
                                  "COALESCE(SUM(bs.Quantity), 0) AS OnHand, " &
                                  "COALESCE((SELECT SUM(ri.Quantity) FROM ReceivingItems ri JOIN Receivings r ON r.ReceivingID = ri.ReceivingID WHERE ri.HardwareID = h.HardwareID AND r.Status='Approved'), 0) AS StockIn, " &
                                  "COALESCE((SELECT SUM(i.QuantityIssued) FROM Issuances i WHERE i.HardwareID = h.HardwareID AND i.Status='Approved'), 0) AS StockOut " &
                                  "FROM Hardware h LEFT JOIN BranchStock bs ON h.HardwareID = bs.HardwareID GROUP BY h.HardwareID ORDER BY h.Name"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
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
                Dim q As String = "SELECT h.HardwareID, h.Name, h.Category, h.Status, COALESCE(SUM(bs.Quantity), 0) AS Quantity " &
                                  "FROM Hardware h LEFT JOIN BranchStock bs ON h.HardwareID = bs.HardwareID WHERE h.Status='Active' GROUP BY h.HardwareID ORDER BY h.Name"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function GetBranchHardware(branchID As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT h.HardwareID, h.Name, h.Category, COALESCE(bs.Quantity, 0) AS Quantity " &
                                  "FROM Hardware h " &
                                  "LEFT JOIN BranchStock bs ON h.HardwareID = bs.HardwareID AND bs.BranchID = @b " &
                                  "WHERE h.Status='Active' AND COALESCE(bs.Quantity, 0) > 0"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@b", branchID)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch
        End Try
        Return dt
    End Function

    Public Shared Function AddHardwareWithStock(name As String, category As String, branchID As Integer, initialQty As Integer) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim newHwID As Integer
                        Using cmd As New MySqlCommand("INSERT INTO Hardware (Name, Category, Status) VALUES (@n, @c, 'Active'); SELECT LAST_INSERT_ID();", conn, trans)
                            cmd.Parameters.AddWithValue("@n", name)
                            cmd.Parameters.AddWithValue("@c", category)
                            newHwID = Convert.ToInt32(cmd.ExecuteScalar())
                        End Using
                        If initialQty > 0 Then
                            Using cmd As New MySqlCommand("INSERT INTO BranchStock (BranchID, HardwareID, Quantity) VALUES (@b, @h, @q)", conn, trans)
                                cmd.Parameters.AddWithValue("@b", branchID)
                                cmd.Parameters.AddWithValue("@h", newHwID)
                                cmd.Parameters.AddWithValue("@q", initialQty)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                        trans.Commit()
                        Return True
                    Catch
                        trans.Rollback()
                        Return False
                    End Try
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
                Using cmd As New MySqlCommand("SELECT COALESCE(SUM(Quantity),0) FROM BranchStock", conn)
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
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM (SELECT h.HardwareID FROM Hardware h LEFT JOIN BranchStock bs ON h.HardwareID=bs.HardwareID WHERE h.Status='Active' GROUP BY h.HardwareID HAVING COALESCE(SUM(bs.Quantity),0) <= @t) as low", conn)
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
                Dim q As String = "SELECT h.HardwareID, h.Name, h.Category, 'N/A' AS Location, COALESCE(SUM(bs.Quantity), 0) AS Quantity " &
                                  "FROM Hardware h LEFT JOIN BranchStock bs ON h.HardwareID = bs.HardwareID " &
                                  "WHERE h.Status='Active' GROUP BY h.HardwareID HAVING Quantity <= @t ORDER BY Quantity"
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
                Dim q As String = "SELECT h.Category, COALESCE(SUM(bs.Quantity), 0) AS Total " &
                                  "FROM Hardware h LEFT JOIN BranchStock bs ON h.HardwareID = bs.HardwareID " &
                                  "GROUP BY h.Category HAVING Total > 0"
                Dim adapter As New MySqlDataAdapter(q, conn)
                adapter.Fill(dt)
            End Using
        Catch
        End Try
        Return dt
    End Function

    ' RECEIVINGS
    Public Shared Function CreateReceivingRequest(supplierID As Integer, branchID As Integer, receivedBy As String, lines As List(Of ReceivingLine)) As Boolean
        If lines Is Nothing OrElse lines.Count = 0 Then Return False
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim rid As Integer
                        Using cmd As New MySqlCommand("INSERT INTO Receivings (SupplierID, BranchID, ReceivedBy, Status) VALUES (@s, @b, @u, 'Pending'); SELECT LAST_INSERT_ID();", conn, trans)
                            cmd.Parameters.AddWithValue("@s", supplierID)
                            cmd.Parameters.AddWithValue("@b", branchID)
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
                        trans.Rollback()
                        Return False
                    End Try
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function GetPendingReceivings() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = KeyData.GetConnection()
            conn.Open()
            Dim q As String = "SELECT r.ReceivingID, s.Name AS Supplier, b.Name AS Branch, r.ReceivedBy, r.DateReceived " &
                              "FROM Receivings r " &
                              "JOIN Suppliers s ON r.SupplierID = s.SupplierID " &
                              "JOIN Branches b ON r.BranchID = b.BranchID " &
                              "WHERE r.Status='Pending'"
            Dim adapter As New MySqlDataAdapter(q, conn)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Shared Function ApproveReceiving(receivingID As Integer, approvedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim branchID As Integer
                        Dim receivedBy As String = ""
                        Using cmd As New MySqlCommand("SELECT BranchID, ReceivedBy FROM Receivings WHERE ReceivingID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", receivingID)
                            Using r As MySqlDataReader = cmd.ExecuteReader()
                                If r.Read() Then
                                    branchID = Convert.ToInt32(r("BranchID"))
                                    receivedBy = r("ReceivedBy").ToString()
                                End If
                                r.Close()
                            End Using
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
                            Using cmd As New MySqlCommand("INSERT INTO BranchStock (BranchID, HardwareID, Quantity) VALUES (@b, @h, @q) ON DUPLICATE KEY UPDATE Quantity = Quantity + @q", conn, trans)
                                cmd.Parameters.AddWithValue("@b", branchID)
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
                        trans.Rollback()
                        Return False
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
    Public Shared Function CreateIssuanceRequest(hardwareID As Integer, branchID As Integer, issuedTo As String, quantity As Integer, issuedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "INSERT INTO Issuances (HardwareID, BranchID, IssuedTo, QuantityIssued, IssuedBy, Status) VALUES (@h, @b, @to, @q, @by, 'Pending'); SELECT LAST_INSERT_ID();"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@h", hardwareID)
                    cmd.Parameters.AddWithValue("@b", branchID)
                    cmd.Parameters.AddWithValue("@to", issuedTo)
                    cmd.Parameters.AddWithValue("@q", quantity)
                    cmd.Parameters.AddWithValue("@by", issuedBy)
                    Dim newID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    Using cmd2 As New MySqlCommand("INSERT INTO Notifications (RecipientUsername, Message) SELECT Username, @msg FROM Users WHERE RoleID = 1", conn)
                        cmd2.Parameters.AddWithValue("@msg", "New Issuance Request from " & issuedBy & " (ID: " & newID & ")")
                        cmd2.ExecuteNonQuery()
                    End Using

                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Shared Function GetPendingIssuances() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = KeyData.GetConnection()
            conn.Open()
            Dim q As String = "SELECT i.IssuanceID, h.Name AS ItemName, b.Name AS Branch, i.IssuedTo, i.QuantityIssued, i.IssuedBy " &
                              "FROM Issuances i " &
                              "LEFT JOIN Hardware h ON i.HardwareID = h.HardwareID " &
                              "LEFT JOIN Branches b ON i.BranchID = b.BranchID " &
                              "WHERE i.Status='Pending'"
            Dim adapter As New MySqlDataAdapter(q, conn)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Shared Function ApproveIssuance(issuanceID As Integer, approvedBy As String) As Boolean
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim hid As Integer, qty As Integer, branchID As Integer
                        Dim issuedBy As String = ""
                        Using cmd As New MySqlCommand("SELECT HardwareID, QuantityIssued, BranchID, IssuedBy FROM Issuances WHERE IssuanceID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", issuanceID)
                            Using r As MySqlDataReader = cmd.ExecuteReader()
                                If r.Read() Then
                                    hid = Convert.ToInt32(r("HardwareID"))
                                    qty = Convert.ToInt32(r("QuantityIssued"))
                                    branchID = Convert.ToInt32(r("BranchID"))
                                    issuedBy = r("IssuedBy").ToString()
                                Else
                                    r.Close() : trans.Rollback() : Return False
                                End If
                                r.Close()
                            End Using
                        End Using
                        Using cmd As New MySqlCommand("UPDATE BranchStock SET Quantity = Quantity - @q WHERE HardwareID=@h AND BranchID=@b AND Quantity >= @q", conn, trans)
                            cmd.Parameters.AddWithValue("@q", qty)
                            cmd.Parameters.AddWithValue("@h", hid)
                            cmd.Parameters.AddWithValue("@b", branchID)
                            If cmd.ExecuteNonQuery() = 0 Then
                                trans.Rollback() : Return False
                            End If
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

    ' RETURNS & WRITE-OFFS
    Public Shared Function GetApprovedIssuances() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = KeyData.GetConnection()
                conn.Open()
                Dim q As String = "SELECT i.IssuanceID, h.Name AS ItemName, i.IssuedTo, " &
                                  "(i.QuantityIssued - COALESCE((SELECT SUM(r.QuantityReturned) FROM Returns r WHERE r.IssuanceID = i.IssuanceID AND r.Status != 'Rejected'), 0)) AS RemainingQty " &
                                  "FROM Issuances i JOIN Hardware h ON i.HardwareID = h.HardwareID " &
                                  "WHERE i.Status = 'Approved' HAVING RemainingQty > 0"
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
                        Dim issuanceID As Integer, qty As Integer, isDefective As Boolean
                        Dim issuedBy As String = ""
                        Using cmd As New MySqlCommand("SELECT r.IssuanceID, r.QuantityReturned, r.IsDefective, i.IssuedBy " &
                                                      "FROM Returns r JOIN Issuances i ON r.IssuanceID = i.IssuanceID WHERE r.ReturnID=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", returnID)
                            Using r As MySqlDataReader = cmd.ExecuteReader()
                                If r.Read() Then
                                    issuanceID = Convert.ToInt32(r("IssuanceID"))
                                    qty = Convert.ToInt32(r("QuantityReturned"))
                                    isDefective = Convert.ToBoolean(r("IsDefective"))
                                    issuedBy = r("IssuedBy").ToString()
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
                            Dim hid As Integer, branchID As Integer
                            Using cmd As New MySqlCommand("SELECT HardwareID, BranchID FROM Issuances WHERE IssuanceID=@id", conn, trans)
                                cmd.Parameters.AddWithValue("@id", issuanceID)
                                Using r As MySqlDataReader = cmd.ExecuteReader()
                                    r.Read()
                                    hid = Convert.ToInt32(r("HardwareID"))
                                    branchID = Convert.ToInt32(r("BranchID"))
                                    r.Close()
                                End Using
                            End Using

                            Using cmd As New MySqlCommand("INSERT INTO BranchStock (BranchID, HardwareID, Quantity) VALUES (@b, @h, @q) ON DUPLICATE KEY UPDATE Quantity = Quantity + @q", conn, trans)
                                cmd.Parameters.AddWithValue("@b", branchID)
                                cmd.Parameters.AddWithValue("@h", hid)
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