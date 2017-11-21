Option Strict On
Option Explicit On

Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVehicleToolStripMenuItem.Click
        FrmAddVehicle.ShowDialog()
    End Sub

    Private Sub RemoveVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveVehicleToolStripMenuItem.Click
        FrmRemoveVehicle.ShowDialog()
    End Sub

    Private Sub ViewInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInventoryToolStripMenuItem.Click
        FrmInventory.ShowDialog()

    End Sub


    Private Sub InventoryStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryStatusToolStripMenuItem.Click
        FrmDealerStatus.ShowDialog()
    End Sub

    Private Sub SoldVehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoldVehiclesToolStripMenuItem.Click
        FrmSoldVehicles.ShowDialog()
    End Sub

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
