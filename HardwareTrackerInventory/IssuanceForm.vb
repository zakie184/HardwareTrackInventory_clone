Public Class IssuanceForm
    Private _user As User = Nothing

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

        SetupGrid()
    End Sub

    Private Sub SetupGrid()
        dgvItems.AutoGenerateColumns = False
        dgvItems.AllowUserToAddRows = True

        Dim colItem As New DataGridViewComboBoxColumn()
        colItem.HeaderText = "Item Name"
        colItem.Name = "ItemName"
        ' DITO NATIN GINAMIT ANG BRANCH HARDWARE PARA SA ISSUANCE
        colItem.DataSource = DatabaseHelper.GetBranchHardware(_user.BranchID.GetValueOrDefault(1))
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
                dgvItems.CurrentRow.Cells("Stock").Value = drv("Quantity").ToString()
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
        If String.IsNullOrWhiteSpace(txtIssuedTo.Text) Then
            MessageBox.Show("Please enter who this is being issued to.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim success As Boolean = True
        Dim issuedTo As String = txtIssuedTo.Text.Trim()
        Dim branchID As Integer = _user.BranchID.GetValueOrDefault(1)
        Dim hasItems As Boolean = False

        For Each row As DataGridViewRow In dgvItems.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("ItemName").Value IsNot Nothing AndAlso row.Cells("Qty").Value IsNot Nothing Then
                Dim hid As Integer = 0
                Dim qty As Integer = 0
                Integer.TryParse(row.Cells("ItemName").Value.ToString(), hid)
                Integer.TryParse(row.Cells("Qty").Value.ToString(), qty)

                If hid > 0 AndAlso qty > 0 Then
                    hasItems = True
                    If Not DatabaseHelper.CreateIssuanceRequest(hid, branchID, issuedTo, qty, _user.Username) Then
                        success = False
                    End If
                End If
            End If
        Next

        If Not hasItems Then
            MessageBox.Show("Please add at least one valid item with a quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If success Then
            MessageBox.Show("Issuance requested successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Some items failed to process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class