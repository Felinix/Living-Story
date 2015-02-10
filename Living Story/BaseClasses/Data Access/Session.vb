Imports System.Data.SqlClient

Public Class Session

#Region "Properties"

    Private _Connection As SqlConnection
    Private _ConnectionString As String
    Private _DataLayer As DataLayer
    Private _Dictionary As Dictionary(Of Object, Object)
    Private _InTransaction As Boolean
    Private _IsConnected As Boolean
    Private _ObjectLayer As ObjectLayer

#End Region

#Region "Functions"

    Public Sub BeginTransaction()

    End Sub
    Public Sub CommitTransaction()

    End Sub
    Public Sub Connect()

    End Sub
    Public Sub Delete(_Object As Object)

    End Sub
    Public Sub Delete(_Collection As Collection)

    End Sub
    Public Sub Disconnect()

    End Sub
    Public Sub Dispose(_Dispose As Boolean)

    End Sub
    Public Sub DropChanges()

    End Sub
    Public Sub New()

    End Sub
    Public Sub Reload(_Object As Object)

    End Sub
    Public Sub RollbackTransaction()

    End Sub
    Public Sub Save(_Object As Object)

    End Sub
    Public Sub Save(_Collection As Collection)

    End Sub
    Public Sub UpdateSchema(_ParamArray As Reflection.Assembly)

    End Sub
    Public Sub UpdateSchema(_ParamArray As System.Type)

    End Sub
    Public Sub ExecuteNonQuery(_Query As String)

    End Sub
    Public Sub ExecuteNonQuery(_Query As String, _Object As Object)

    End Sub
    Public Sub ExecuteNonQuery(_Query As String, _Parameters As String(), _Objects As Object())

    End Sub
    Public Sub ExecuteQuery(_Query As String)

    End Sub
    Public Sub ExecuteQuery(_Query As String, _Object As Object)

    End Sub
    Public Sub ExecuteQuery(_Query As String, _Paramters As String(), _Objects As Object())

    End Sub
    Public Function FindObject(Of T)(_Criteria As String) As Type
        Return Nothing
    End Function
    Public Function FindObject(_Type As Type, _Criteria As String) As Object
        Return Nothing
    End Function
    Public Function GetKeyValue(_Object As Object) As Object
        Return Nothing
    End Function
    Public Function GetObjectByKey(Of T)(_Object As Object) As Object
        Return Nothing
    End Function
    Public Function GetObjects(Of T)() As Collection
        Return Nothing
    End Function
    Public Function GetObjectsByKey(Of T)(_Object As Object) As Collection
        Return Nothing
    End Function

#End Region

End Class
