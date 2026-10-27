Imports System.Drawing

Public Class ReceivingForm
    Private _user As User = Nothing
    Private _preselectedItemID As Integer = 0

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

        If _user.Role <> "Administrator" Then
            lblHeaderSub.Text = "Your request will be sent to the Administrator for approval."
            btnSave.Text = "Submit Request"
        End If

        LoadSuppliers()
        SetupGrid()

        If _preselectedItemID > 0 Then
            Dim dt As DataTable = DatabaseHelper.GetActiveHardware()
            Dim drv As DataRowView = dt.DefaultView.FindRows(_preselectedItemID).FirstOrDefault()
            If drv IsNot Nothing Then
                Dim newRowIndex As Integer = dgvItems.Rows.Add()
                dgvItems.Rows(newRowIndex).Cells("ItemName").Value = drv("HardwareID")
                dgvItems.Rows(newRowIndex).Cells("Category").Value = drv("Category").ToString()
                dgvItems.Rows(newRowIndex).Cells("Location").Value = "Storage Room"
                dgvItems.Rows(newRowIndex).Cells("Qty").Value = 1
            End If
        End If
    End Sub

    Private Sub LoadSuppliers()
        Dim dt As DataTable = DatabaseHelper.GetAllSuppliers()
        cmbSupplier.DataSource = dt
        cmbSupplier.DisplayMember = "Name"
        cmbSupplier.ValueMember = "SupplierID"
    End Sub

    Private Sub SetupGrid()
        dgvItems.AutoGenerateColumns = False
        dgvItems.AllowUserToAddRows = True

        Dim colItem As New DataGridViewComboBoxColumn()
        colItem.HeaderText = "Item Name"
        colItem.Name = "ItemName"
        colItem.DataSource = DatabaseHelper.GetActiveHardware()
        colItem.DisplayMember = "Name"
        colItem.ValueMember = "HardwareID"
        colItem.FlatStyle = FlatStyle.Flat
        colItem.Width = 220
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
        If dgvItems.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvItems.SelectedRows
                If Not row.IsNewRow Then dgvItems.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbSupplier.SelectedIndex < 0 Then
            MessageBox.Show("Please select a supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim lines As New List(Of ReceivingLine)
        For Each row As DataGridViewRow In dgvItems.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("ItemName").Value IsNot Nothing AndAlso row.Cells("Qty").Value IsNot Nothing Then
                Dim hid As Integer = 0
                Dim qty As Integer = 0
                Integer.TryParse(row.Cells("ItemName").Value.ToString(), hid)
                Integer.TryParse(row.Cells("Qty").Value.ToString(), qty)
                If hid > 0 AndAlso qty > 0 Then
                    lines.Add(New ReceivingLine With {.HardwareID = hid, .Quantity = qty})
                End If
            End If
        Next

        If lines.Count = 0 Then
            MessageBox.Show("Please add at least one valid item with a quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim supID As Integer = Convert.ToInt32(cmbSupplier.SelectedValue)
        Dim branchID As Integer = _user.BranchID.GetValueOrDefault(1)

        If DatabaseHelper.CreateReceivingRequest(supID, branchID, _user.Username, lines) Then
            MessageBox.Show("Receiving saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to save receiving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class