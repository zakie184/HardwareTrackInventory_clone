Imports System.Drawing

Public Class ReceivingForm
    Private _user As User = Nothing
    Private _preselectedItemID As Integer = 0
    Private isInitializing As Boolean = True
    Private _hardwareList As DataTable = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Public Sub New(user As User, preselectedItemID As Integer)
        InitializeComponent()
        _user = user
        _preselectedItemID = preselectedItemID
    End Sub

    Private Sub ReceivingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _user Is Nothing OrElse Not _user.CanReceive() Then
            MessageBox.Show("Permission denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        isInitializing = True
        txtSearchItem.ForeColor = Color.Gray
        _hardwareList = DatabaseHelper.GetActiveHardware()

        SetupGrid()
        LoadSuppliers()
        LoadPendingRequests()
        LoadLowStockItems()

        If _preselectedItemID > 0 Then
            Dim rows As DataRow() = _hardwareList.Select("HardwareID = " & _preselectedItemID)
            If rows.Length > 0 Then
                Dim drv As DataRow = rows(0)
                Dim newRowIndex As Integer = dgvItems.Rows.Add()
                dgvItems.Rows(newRowIndex).Cells("ItemName").Value = drv("HardwareID")
                dgvItems.Rows(newRowIndex).Cells("Category").Value = drv("Category").ToString()
                dgvItems.Rows(newRowIndex).Cells("Location").Value = "Storage Room"
                dgvItems.Rows(newRowIndex).Cells("Qty").Value = 1
            End If
        End If
        isInitializing = False
    End Sub

    ' --- FIX: Suppress the ComboBox "Value is not valid" error ---
    Private Sub dgvItems_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvItems.DataError
        e.ThrowException = False
    End Sub

    ' SEARCH BAR LOGIC
    Private Sub txtSearchItem_TextChanged(sender As Object, e As EventArgs) Handles txtSearchItem.TextChanged
        If _hardwareList Is Nothing Then Return

        dgvItems.EndEdit() ' Commit any active edits before changing the list

        Dim search As String = txtSearchItem.Text.Trim().Replace("'", "''")
        Dim dv As New DataView(_hardwareList)

        If search <> "" AndAlso search <> "Type to filter dropdown..." Then
            dv.RowFilter = "Name LIKE '%" & search & "%' OR Category LIKE '%" & search & "%'"
        End If

        If dgvItems.Columns.Contains("ItemName") Then
            Dim comboCol As DataGridViewComboBoxColumn = TryCast(dgvItems.Columns("ItemName"), DataGridViewComboBoxColumn)
            If comboCol IsNot Nothing Then
                comboCol.DataSource = dv
            End If
        End If
    End Sub

    Private Sub txtSearchItem_Enter(sender As Object, e As EventArgs) Handles txtSearchItem.Enter
        If txtSearchItem.Text = "Type to filter dropdown..." Then
            txtSearchItem.Text = ""
            txtSearchItem.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchItem_Leave(sender As Object, e As EventArgs) Handles txtSearchItem.Leave
        If String.IsNullOrWhiteSpace(txtSearchItem.Text) Then
            txtSearchItem.Text = "Type to filter dropdown..."
            txtSearchItem.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub LoadLowStockItems()
        dgvItems.Rows.Clear()
        Dim dtLow As DataTable = DatabaseHelper.GetLowStockItems(5)
        For Each row As DataRow In dtLow.Rows
            Dim idx As Integer = dgvItems.Rows.Add()
            dgvItems.Rows(idx).Cells("ItemName").Value = row("HardwareID")
            dgvItems.Rows(idx).Cells("Category").Value = row("Category").ToString()
            dgvItems.Rows(idx).Cells("Location").Value = "Storage Room"
            dgvItems.Rows(idx).Cells("Qty").Value = 1
        Next
    End Sub

    Private Sub LoadSuppliers()
        Dim dt As DataTable = DatabaseHelper.GetAllSuppliers()
        cmbSupplier.DataSource = dt
        cmbSupplier.DisplayMember = "Name"
        cmbSupplier.ValueMember = "SupplierID"
    End Sub

    Private Sub LoadPendingRequests()
        Dim dt As DataTable = DatabaseHelper.GetPendingReceivings()
        Dim dr As DataRow = dt.NewRow()
        dr("ReceivingID") = 0
        dr("Supplier") = "None (Create New Request)"
        dt.Rows.InsertAt(dr, 0)

        cmbLoadRequest.DataSource = dt
        cmbLoadRequest.DisplayMember = "Supplier"
        cmbLoadRequest.ValueMember = "ReceivingID"
    End Sub

    Private Sub cmbLoadRequest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoadRequest.SelectedIndexChanged
        If isInitializing Then Exit Sub

        If cmbLoadRequest.SelectedIndex > 0 Then
            Dim drv As DataRowView = TryCast(cmbLoadRequest.SelectedItem, DataRowView)
            If drv IsNot Nothing Then
                Dim id As Integer = Convert.ToInt32(drv("ReceivingID"))
                Dim supID As Integer = Convert.ToInt32(drv("SupplierID"))
                cmbSupplier.SelectedValue = supID
                cmbSupplier.Enabled = False

                dgvItems.Rows.Clear()
                Dim dtItems As DataTable = DatabaseHelper.GetReceivingItems(id)
                For Each row As DataRow In dtItems.Rows
                    Dim idx As Integer = dgvItems.Rows.Add()
                    dgvItems.Rows(idx).Cells("ItemName").Value = row("HardwareID")
                    dgvItems.Rows(idx).Cells("Category").Value = row("Category").ToString()
                    dgvItems.Rows(idx).Cells("Location").Value = "Storage Room"
                    dgvItems.Rows(idx).Cells("Qty").Value = row("Quantity")
                Next
            End If
        Else
            cmbSupplier.Enabled = True
            LoadLowStockItems()
        End If
    End Sub

    Private Sub SetupGrid()
        dgvItems.AutoGenerateColumns = False
        dgvItems.AllowUserToAddRows = True
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim colItem As New DataGridViewComboBoxColumn()
        colItem.HeaderText = "Item Name"
        colItem.Name = "ItemName"
        colItem.DataSource = _hardwareList
        colItem.DisplayMember = "Name"
        colItem.ValueMember = "HardwareID"
        colItem.FlatStyle = FlatStyle.Flat
        colItem.Width = 250
        dgvItems.Columns.Add(colItem)

        Dim colCat As New DataGridViewTextBoxColumn()
        colCat.HeaderText = "Category"
        colCat.Name = "Category"
        colCat.ReadOnly = True
        colCat.Width = 150
        dgvItems.Columns.Add(colCat)

        Dim colLoc As New DataGridViewComboBoxColumn()
        colLoc.HeaderText = "Location"
        colLoc.Name = "Location"
        colLoc.Items.AddRange(New String() {"Storage Room", "Main Office", "Warehouse A", "Branch B"})
        colLoc.FlatStyle = FlatStyle.Flat
        colLoc.Width = 150
        dgvItems.Columns.Add(colLoc)

        Dim colQty As New DataGridViewTextBoxColumn()
        colQty.HeaderText = "Qty"
        colQty.Name = "Qty"
        colQty.Width = 80
        dgvItems.Columns.Add(colQty)
    End Sub

    Private Sub dgvItems_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvItems.EditingControlShowing
        If dgvItems.CurrentCell.ColumnIndex = 0 Then
            Dim combo As ComboBox = TryCast(e.Control, ComboBox)
            If combo IsNot Nothing Then
                combo.DropDownStyle = ComboBoxStyle.DropDown
                combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                combo.AutoCompleteSource = AutoCompleteSource.ListItems

                RemoveHandler combo.SelectedIndexChanged, AddressOf Combo_SelectedIndexChanged
                AddHandler combo.SelectedIndexChanged, AddressOf Combo_SelectedIndexChanged
            End If
        End If
    End Sub

    Private Sub Combo_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim combo As ComboBox = TryCast(sender, ComboBox)
        If combo IsNot Nothing AndAlso combo.SelectedItem IsNot Nothing Then
            Dim drv As DataRowView = TryCast(combo.SelectedItem, DataRowView)
            If drv IsNot Nothing Then
                dgvItems.CurrentRow.Cells("Category").Value = drv("Category").ToString()
            End If
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        dgvItems.EndEdit()
        dgvItems.Rows.Add()
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        For i As Integer = dgvItems.SelectedRows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = dgvItems.SelectedRows(i)
            If Not row.IsNewRow Then dgvItems.Rows.Remove(row)
        Next
        If dgvItems.SelectedRows.Count = 0 AndAlso dgvItems.CurrentRow IsNot Nothing Then
            If Not dgvItems.CurrentRow.IsNewRow Then dgvItems.Rows.Remove(dgvItems.CurrentRow)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbSupplier.SelectedIndex < 0 Then
            MessageBox.Show("Please select a supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim lines As New List(Of ReceivingLine)
        Dim processedIDs As New HashSet(Of Integer)()

        For Each row As DataGridViewRow In dgvItems.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("ItemName").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ItemName").Value) AndAlso row.Cells("Qty").Value IsNot Nothing Then
                Dim hid As Integer = 0
                Dim qty As Integer = 0
                Integer.TryParse(row.Cells("ItemName").Value.ToString(), hid)
                Integer.TryParse(row.Cells("Qty").Value.ToString(), qty)

                If hid > 0 AndAlso qty > 0 Then
                    If processedIDs.Contains(hid) Then
                        MessageBox.Show("Duplicate item detected. Please combine the quantities into a single row.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    processedIDs.Add(hid)
                    lines.Add(New ReceivingLine With {.HardwareID = hid, .Quantity = qty})
                End If
            End If
        Next

        If lines.Count = 0 Then
            MessageBox.Show("Please add at least one valid item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim supID As Integer = Convert.ToInt32(cmbSupplier.SelectedValue)

        If DatabaseHelper.CreateReceivingRequest(supID, _user.Username, lines) Then
            MessageBox.Show("Request submitted! Waiting for Admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class