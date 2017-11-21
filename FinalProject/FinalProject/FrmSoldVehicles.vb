Option Strict On
Option Explicit On

Public Class FrmSoldVehicles
    Private Sub FrmSoldVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DealerDataSet.Sold' table. You can move, or remove it, as needed.
        Me.SoldTableAdapter.Fill(Me.DealerDataSet.Sold)

    End Sub
End Class