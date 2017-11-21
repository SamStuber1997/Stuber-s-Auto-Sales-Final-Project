

Public Class FrmSellVehicle
    Public Property StockNumber As Integer
    Private mVehicle As New Vehicle
    Private mSoldVehicle As New SoldVehicle

    Private Sub FrmSellVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim row As DealerDataSet.Inventory1Row
        row = mVehicle.FindByStockNumber(StockNumber)
        txtStockNum.Text = row.StockNumber.ToString
        txtYear.Text = row.Year
        txtMake.Text = row.Make
        txtModel.Text = row.Model
        txtTrim.Text = row.Trim
        txtColor.Text = row.Color
        cboDrivetrain.Text = row.Drivetrain
        txtMileage.Text = row.Mileage
        txtTMV.Text = row.TrueMarketValue
        txtPrice.Text = row.Price
        dtpArrival.Value = row.ArrivalDate

        txtProfit.Text = txtPrice.Text - txtTMV.Text

        txtSaleID.Text = txtStockNum.Text + 105



    End Sub









    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        lblStatus.Text = ""

        If mSoldVehicle.Insert(CInt(txtSaleID.Text), CInt(txtYear.Text),
                           txtMake.Text, txtModel.Text, txtTrim.Text, txtColor.Text,
                           cboDrivetrain.Text, CInt(txtMileage.Text),
                              CDec(txtPrice.Text), CDec(txtProfit.Text)) Then


            mVehicle.Delete(CInt(txtStockNum.Text))
        End If
        lblStatus.Text = mSoldVehicle.LastStatus
    End Sub



    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

        txtProfit.Text = txtPrice.Text - txtTMV.Text


    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        errProvider.Clear()


        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

            errProvider.SetError(txtPrice, "Enter digits only")
        End If
    End Sub

    Private Sub txtTMV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTMV.KeyPress
        errProvider.Clear()


        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

            errProvider.SetError(txtTMV, "Enter digits only")
        End If
    End Sub
End Class