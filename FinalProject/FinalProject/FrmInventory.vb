Option Strict On
Option Explicit On

Public Class FrmInventory
    Private Sub FrmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DealerDataSet.Inventory1' table. You can move, or remove it, as needed.
        Me.Inventory1TableAdapter.Fill(Me.DealerDataSet.Inventory1)


        Dim mInventory As New Vehicle
        dgvInventory.DataSource = mInventory.InventoryList
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
		If dgvInventory.SelectedRows.Count > 0 Then
			Dim id As Integer = CShort(dgvInventory.SelectedRows(0).Cells(0).Value)
			Dim frmSellVehicle As New FrmSellVehicle
			frmSellVehicle.StockNumber = id
			frmSellVehicle.ShowDialog()

		End If


	End Sub



    Private Sub txtStockNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockNum.KeyPress
        errProvider.Clear()


        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

            errProvider.SetError(txtStockNum, "Enter digits only")
        End If
    End Sub
End Class