

Public Class SoldVehicle

    Public Property LastStatus As String
    Private adapter As New DealerDataSetTableAdapters.SoldTableAdapter
    Private adapter1 As New DealerDataSetTableAdapters.Inventory1TableAdapter


    Public Function GetSumOfProfit()

        Return adapter.CalcDealerProfit()

    End Function


    Public ReadOnly Property SoldList As DataTable
        Get
            Dim listAdapter As New DealerDataSetTableAdapters.SoldTableAdapter

            Return listAdapter.GetData()
        End Get
    End Property



    Public Function Insert(pSaleID As Integer, pYear As Integer,
                      pMake As String, pModel As String, pTrim As String,
                      pColor As String, pDriveTrain As String, pMiles As Integer,
                      pSalePrice As Decimal, pProfit As Decimal) As Boolean
        Dim Result As Boolean = False
        Try

            If adapter.Insert(pSaleID, pYear, pMake, pModel, pTrim, pColor, pDriveTrain,
                              pMiles, pSalePrice, pProfit) > 0 Then
                LastStatus = "Vehicle sold successfully!"
                Result = True
            Else
                LastStatus = "Error Selling Vehicle"

            End If
        Catch ex As Exception
            LastStatus = "Exception thrown while selling vehicle."

        End Try
        Return Result
    End Function


End Class
