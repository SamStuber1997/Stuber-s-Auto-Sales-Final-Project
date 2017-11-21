

Public Class Vehicle

    Public Property LastStatus As String

    Private adapter As New DealerDataSetTableAdapters.Inventory1TableAdapter


    Public ReadOnly Property InventoryList As DataTable
        Get
            Dim listAdapter As New DealerDataSetTableAdapters.Inventory1TableAdapter

            Return listAdapter.GetData()
        End Get
    End Property



    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function GetByStockNum(ByVal pStockNumber As Integer)
        Dim table As DataTable = adapter.GetData
        table.DefaultView.RowFilter = "StockNumber" = pStockNumber

        Return table
    End Function

    Public Function Insert(pStockNumber As Integer, pYear As Integer,
                           pMake As String, pModel As String, pTrim As String,
                           pColor As String, pDriveTrain As String, pMiles As Integer,
                           pTMV As Decimal, pPrice As Decimal, pArrivalDate As DateTime) As Boolean

        Dim Result As Boolean = False
        Try

            If adapter.Insert(pStockNumber, pYear, pMake, pModel, pTrim, pColor, pDriveTrain,
                          pTMV, pPrice, pArrivalDate) > 0 Then
                LastStatus = "Vehicle added Successfully"
                Result = True
            Else
                LastStatus = "Error adding vehicle"
            End If

        Catch ex As Exception
            LastStatus = "Exception thrown while adding vehicle"

        End Try

        Return Result
    End Function

    Public Function GetSumOfValue()

        Return adapter.CalcDealerValue()

    End Function

    Public Function GetByStockNumber(ByVal StockNumber As Short) As DataTable

        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "Stock Number = " & StockNumber
        Return table
    End Function


    Public Function Update(pStockNumber As Integer, pYear As Integer,
                           pMake As String, pModel As String, pTrim As String,
                           pColor As String, pDriveTrain As String, pMiles As Integer,
                           pPrice As Decimal) As Boolean

        Dim result As Boolean = False

        If adapter.Update(pStockNumber, pYear, pMake, pModel, pTrim, pColor, pDriveTrain, pMiles,
                          pPrice) > 0 Then
            LastStatus = "Record Updated"
            result = True
        Else
            LastStatus = "Error updating record#: " & pStockNumber
        End If

        Return result

    End Function



    Public Function Delete(ByVal pStockNumber As Integer) As Boolean

        Dim result As Boolean = False

        If (adapter.Delete(pStockNumber)) > 0 Then
            LastStatus = "Vehicle Deleted form database with Stock Number:" & pStockNumber
            result = True
        Else
            LastStatus = "Vehicle does not exist"
        End If


        Return result

    End Function

    Public Function FindByStockNumber(ByVal pStockNumber As Integer) As DealerDataSet.Inventory1Row

        Dim table As DealerDataSet.Inventory1DataTable
        table = adapter.GetData()
        Return table.FindByStockNumber(pStockNumber)
    End Function



End Class
