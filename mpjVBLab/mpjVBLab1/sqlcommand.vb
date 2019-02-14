Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class sqlcommand
    Dim strCon As String =
       ConfigurationManager.ConnectionStrings("mpjVBLab1.My.MySettings.strCon").ConnectionString
    Dim myCon As New SqlConnection
    'Dim myDA As New SqlDataAdapter
    'Dim myDS As New DataSet
    Dim strSQL As String
    Dim myComm As sqlcommand
    Dim myDR As SqlDataAdapter


    Private Sub connetDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub sqlcommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connetDB()
        strSQL = "select categoryName From "
    End Sub

    Private Sub dgvData_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim r As Integer

    End Sub
End Class