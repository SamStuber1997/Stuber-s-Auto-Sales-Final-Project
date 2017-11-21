
Public Class FrmDealerStatus
    Private mVehicle As New Vehicle
    Private mSoldVehicle As New SoldVehicle

    Private Sub FrmDealerStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblValue.Text = mVehicle.GetSumOfValue()
        lblProfit.Text = mSoldVehicle.GetSumOfProfit()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class