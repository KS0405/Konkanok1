Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLab11
    Dim strCon As String =
        ConfigurationManager.ConnectionStrings("mpjVBLab1.My.MySettings.strCon").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim myDS As DataSet
    Dim mysql As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub connetDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub btnChoice1_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click
        connetDB()
        mysql = "select *From Products where ProductName like 'N%'"
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myProducts")
        dgvData.DataSource = myDS.Tables("myProducts")
        myCon.Close()

    End Sub

    Private Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click
        connetDB()
        mysql = "select ProductID,ProductName, (UnitPrice * UnitsInStock) From Products where ProductID like '64'"
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myProducts")
        dgvData.DataSource = myDS.Tables("myProducts")
        dgvData.Columns(0).HeaderText = "ProductID"
        dgvData.Columns(1).HeaderText = "ProductName"
        dgvData.Columns(2).HeaderText = "Value of Products"
        myCon.Close()
    End Sub

    Private Sub btnChoice3_Click(sender As Object, e As EventArgs) Handles btnChoice3.Click
        connetDB()
        mysql = "select  Count*From Customers where Country like '%Brazil%'"
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myCus")
        dgvData.DataSource = myDS.Tables("myCus")
        dgvData.Columns(0).HeaderText = "Country Brazil"
        myCon.Close()
    End Sub

    Private Sub btnChoice4_Click(sender As Object, e As EventArgs) Handles btnChoice4.Click
        connetDB()
        'mysql = "select From Products where ProductName like 'Yang Wang%'"
        'myDA = New SqlDataAdapter(mysql, myCon)
        'myDS = New DataSet
        'myDS.Clear()

        'myDA.Fill(myDS, "myPro")
        'dgvData.DataSource = myDS.Tables("myPro")
        'dgvData.Columns(0).HeaderText = "ProductName"
        'dgvData.Columns(1).HeaderText = "UnitsOnOrder"
        'myCon.Close()
    End Sub

    Private Sub btnChoice5_Click(sender As Object, e As EventArgs) Handles btnChoice5.Click
        connetDB()
        mysql = "select ProductName,UnitsInStock From Products where UnitsInstock < 10 "
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myPro")
        dgvData.DataSource = myDS.Tables("myPro")
        dgvData.Columns(0).HeaderText = "ProductName"
        dgvData.Columns(1).HeaderText = "UnitsInStock"
        myCon.Close()
    End Sub

    Private Sub btnChoice6_Click(sender As Object, e As EventArgs) Handles btnChoice6.Click
        connetDB()
        mysql = "select *From Orders where OrderID like '10255' "
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myOrder")
        dgvData.DataSource = myDS.Tables("myOrder")
        myCon.Close()
    End Sub

    Private Sub btnChoice7_Click(sender As Object, e As EventArgs) Handles btnChoice7.Click
        connetDB()
        mysql = "select Freight From Orders where OrderID like '10255' "
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myOrder")
        dgvData.DataSource = myDS.Tables("myOrder")
        myCon.Close()
    End Sub

    Private Sub btnChoice8_Click(sender As Object, e As EventArgs) Handles btnChoice8.Click
        connetDB()
        mysql = "select Customers From Orders where OrderID like '10347' "
        myDA = New SqlDataAdapter(mysql, myCon)
        myDS = New DataSet
        myDS.Clear()

        myDA.Fill(myDS, "myOrder")
        dgvData.DataSource = myDS.Tables("myOrder")
        myCon.Close()
    End Sub
End Class