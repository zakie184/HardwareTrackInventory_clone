Public Class IssuanceForm
    Private _user As User = Nothing
    Private _hardwareList As DataTable = Nothing

    Public Sub New(user As User)
        InitializeComponent()
        _user = user
    End Sub

    Private Sub IssuanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _user Is Nothing OrElse Not _user.CanIssue() Then
            MessageBox.Show("Permission denied.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        txtSearchItem.ForeColor = Color.Gray
        _hardwareList = DatabaseHelper.GetActiveHardware()
        SetupGrid()
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
        colItem.Width = 200
        dgvItems.Columns.Add(colItem)

        Dim colStock As New DataGridViewTextBoxColumn()
        colStock.HeaderText = "Available"
        colStock.Name = "Stock"
        colStock.ReadOnly = True
        colStock.Width = 80
        dgvItems.Columns.Add(colStock)

        Dim colQty As New DataGridViewTextBoxColumn()
        colQty.HeaderText = "Qty to Issue"
        colQty.Name = "Qty"
        colQty.Width = 100
        dgvItems.Columns.Add(colQty)
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
                dgvItems.CurrentRow.Cells("Stock").Value = drv("Quantity").ToString()
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
        If String.IsNullOrWhiteSpace(txtIssuedTo.Text) Then
            MessageBox.Show("Please enter the recipient's name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim customerName As String = txtIssuedTo.Text.Trim()
        Dim hasItems As Boolean = False
        Dim requestedItems As New Dictionary(Of Integer, Integer)()

        For Each row As DataGridViewRow In dgvItems.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("ItemName").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ItemName").Value) AndAlso row.Cells("Qty").Value IsNot Nothing Then
                Dim hid As Integer = 0
                Dim qty As Integer = 0
                Integer.TryParse(row.Cells("ItemName").Value.ToString(), hid)
                Integer.TryParse(row.Cells("Qty").Value.ToString(), qty)

                If hid > 0 AndAlso qty > 0 Then
                    hasItems = True

                    If requestedItems.ContainsKey(hid) Then
                        MessageBox.Show("Duplicate item detected. Please combine the quantities into a single row.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    Else
                        requestedItems.Add(hid, qty)
                    End If
                End If
            End If
        Next

        If Not hasItems Then
            MessageBox.Show("Please add at least one valid item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim success As Boolean = True
        For Each kvp In requestedItems
            If Not DatabaseHelper.CreateIssuanceRequest(kvp.Key, customerName, kvp.Value, _user.Username) Then
                success = False
            End If
        Next

        If success Then
            MessageBox.Show("Issuance Request Submitted! Please wait for Manager/Admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DatabaseHelper.LogActivity(_user.Username, _user.Role, "Submitted issuance request for " & customerName)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Transaction failed. Please verify available stock quantities.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class