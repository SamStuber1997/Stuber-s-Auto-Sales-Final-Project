Option Strict On
Option Explicit On

Public Class FrmRemoveVehicle

    Private mVehicle As New Vehicle
    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub

    Private Sub FrmRemoveVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DealerDataSet.Inventory1' table. You can move, or remove it, as needed.
        Me.Inventory1TableAdapter.Fill(Me.DealerDataSet.Inventory1)

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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
		If dgvInventory.SelectedRows.Count > 0 Then
			Dim ID As Integer = CShort(dgvInventory.SelectedRows(0).Cells(0).Value)

			If (mVehicle.Delete(ID)) Then
				dgvInventory.DataSource = mVehicle.Items()
			End If
		End If
		lblStatus.Text = mVehicle.LastStatus
    End Sub

End Class