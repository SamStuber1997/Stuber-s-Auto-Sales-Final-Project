Option Strict On
Option Explicit On

Public Class FrmAddVehicle

    Private mVehicle As New Vehicle

    Private Sub ValidateYear(ByVal ctrl As Control)
        If Not IsNumeric(txtYear.Text) Then
            errProvider.SetError(ctrl, "Must be an integer")
            txtYear.Focus()
        Else
            errProvider.SetError(ctrl, String.Empty)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmAddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDrivetrain.Items.Add("FWD")
        cboDrivetrain.Items.Add("RWD")
        cboDrivetrain.Items.Add("AWD")
        cboDrivetrain.Items.Add("4WD")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtStockNum.Text = "" Then
            MessageBox.Show("All text boxes must be filled")

        ElseIf txtTMV.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtYear.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtMake.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtModel.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtTrim.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtColor.Text = "" Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf cboDrivetrain.SelectedIndex = -1 Then
            MessageBox.Show("All text boxes must be filled")
        ElseIf txtMileage.Text = "" Then
            MessageBox.Show("All text boxes must be filled")

            Exit Sub

        End If

        txtStockNum.Focus()

        lblStatus.Text = ""

        If cboDrivetrain.SelectedIndex = -1 Then
            errProvider.SetError(cboDrivetrain, "Nothing is selected")
        End If



        If mVehicle.Insert(CInt(txtStockNum.Text), CInt(txtYear.Text),
                           txtMake.Text, txtModel.Text, txtTrim.Text, txtColor.Text,
                           cboDrivetrain.Text, CInt(txtMileage.Text),
                              CDec(txtTMV.Text), CDec(txtPrice.Text), dtpArrival.Value) Then



        End If
        lblStatus.Text = mVehicle.LastStatus
    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        errProvider.Clear()


        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

            errProvider.SetError(txtYear, "Enter digits only")
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

    Private Sub txtMileage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMileage.KeyPress
        errProvider.Clear()


        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

            errProvider.SetError(txtMileage, "Enter digits only")
        End If
    End Sub
End Class