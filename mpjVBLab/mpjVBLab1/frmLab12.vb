Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLab12
    'Dim strCon As String = ConfigurationManager.ConnectionStrings("mpjVBLab1.My.MySettings.strCompany").ConnectionString
    'Dim myCon As New SqlConnection
    'Dim myDA As New SqlDataAdapter
    'Dim myDS As DataSet
    'Dim mysql As String
    Dim strCon As String = ConfigurationManager.ConnectionStrings("mpjVBLab1.My.MySettings.strCompany").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection(strCon)

    Dim myDA As SqlDataAdapter
    Dim myDS As DataSet

    Dim myComm As SqlCommand
    Dim myDR As SqlDataReader

    Dim userAct As String
    Dim oldEmpID As String

    Private Function Datatable()

        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS = New DataSet
        myDA.Fill(myDS, "table")
        Return myDS.Tables("table")
    End Function


    Private Sub frmLab12_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        dgvEmp.Enabled = True
        panEmp.Enabled = False

        btnInsert.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True

        connectDB()



        strSQL = "select depName from tbDepartment"
        myComm = New SqlCommand(strSQL, myCon)
        myDR = myComm.ExecuteReader()

        If myDR.HasRows Then
            While myDR.Read
                cboDepart.Items.Add(myDR.Item("depName"))
            End While
            cboDepart.SelectedIndex = 0
        Else
            MessageBox.Show("ยังไม่มีข้อมูลแผนกงานในระบบ ไม่สามารถจัดการข้อมูลพนักงานได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการแผนกก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        myDR.Close()

        strSQL = "select empID,empName,empLname,IIF(sex=1, 'ชาย', 'หญิง') As gender ,address,salary,depID from tbEmployee"
        dgvEmp.DataSource = Datatable()

        dgvEmp.Columns(0).HeaderText = "รหัสประจำตัว"
        dgvEmp.Columns(1).HeaderText = "ชื่อ"
        dgvEmp.Columns(2).HeaderText = "นามสกุล"
        dgvEmp.Columns(3).HeaderText = "ที่อยู่"
        dgvEmp.Columns(4).HeaderText = "เพศ"
        dgvEmp.Columns(5).HeaderText = "เงินเดือน"
        dgvEmp.Columns(6).HeaderText = "แผนกงาน"

        myCon.Close()
        cboDepart.SelectedIndex = 0
        panEmp.Enabled = False
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub connectDB()
        If myCon.State = ConnectionState.Closed Then
            myCon.Open()
        End If

    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        dgvEmp.Enabled = False
        panEmp.Enabled = True

        txtEmpID.Focus()

        userAct = "insert"
        panEmp.Enabled = True
        txtEmpID.Select()
        txtAddress.Clear()
        txtEmpID.Clear()
        txtEmpName.Clear()
        txtEmpLname.Clear()
        txtSalary.Clear()
        cboDepart.SelectedIndex = 0

        radMale.Checked = True
        dgvEmp.Enabled = False

        btnEdit.Enabled = False
        btnInsert.Enabled = False
        btnClose.Enabled = False
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectDB()

        Dim delete_ As DialogResult = MessageBox.Show("คุณต้องการลบข้อมูลพนักงานหรือไม่", "ลบพนักงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Dim i As Integer = dgvEmp.CurrentRow.Index
        Dim delete_id As String = dgvEmp.Item(0, i).Value

        If delete_ = DialogResult.Yes Then
            strSQL = "delete from tbEmployee where empID = @eid"
            myComm = New SqlClient.SqlCommand(strSQL, myCon)
            myComm.Parameters.AddWithValue("eid", txtEmpID.Text)

            If myComm.ExecuteNonQuery = 0 Then
                MsgBox("delete fail")
            Else
                MsgBox("delete success")

                strSQL = "select empID,empName,empLname,IIF(sex=1, 'ชาย', 'หญิง') As gender ,address,salary,depID from tbEmployee"
                myDA = New SqlClient.SqlDataAdapter(strSQL, myCon)
                myDS = New DataSet
                myDA.Fill(myDS, "table")
                dgvEmp.DataSource = myDS.Tables("table")
            End If
        Else
        End If
        myCon.Close()

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        panEmp.Enabled = True
        oldEmpID = txtEmpID.Text
        userAct = "update"
        panEmp.Enabled = True




        radMale.Checked = True
        dgvEmp.Enabled = False
        btnInsert.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtEmpID.Text = txtEmpID.Text.Trim
        txtEmpName.Text = txtEmpName.Text.Trim
        txtEmpLname.Text = txtEmpLname.Text.Trim
        txtSalary.Text = txtSalary.Text.Trim
        txtAddress.Text = txtAddress.Text.Trim
        If txtEmpID.Text = "" Or txtEmpName.Text = "" Or txtEmpLname.Text = "" Or txtAddress.Text = "" Or txtSalary.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        ElseIf Not IsNumeric(txtSalary.Text) Then
            MessageBox.Show("กรุณากรอกตัวเลข")
        Else
            Dim gender As Boolean
            If radMale.Checked = True Then
                gender = True
            Else
                gender = False
            End If
            connectDB()

            If userAct = "insert" Then


                strSQL = "select empID from tbEmployee where empID = @eid"
                myComm = New SqlCommand(strSQL, myCon)
                myComm.Parameters.AddWithValue("eid", txtEmpID.Text)
                myDR = myComm.ExecuteReader()

                If myDR.HasRows Then
                    MessageBox.Show("ข้อมูลที่แก้ไขเข้ามีอยู่แล้ว")
                    myDR.Close()
                    Exit Sub

                End If
                myDR.Close()

                strSQL = "insert into tbEmployee (empID ,empName ,empLname ,sex ,address ,salary ,depID) values(@1 ,@2 ,@3 ,@4 ,@5 ,@6  ,(select depID from tbDepartment where depName = '" & cboDepart.SelectedItem & "'))"
                myComm = New SqlCommand(strSQL, myCon)
                myComm.Parameters.Clear()
                With myComm.Parameters
                    .AddWithValue("1", txtEmpID.Text)
                    .AddWithValue("2", txtEmpName.Text)
                    .AddWithValue("3", txtEmpLname.Text)
                    .AddWithValue("4", gender)
                    .AddWithValue("5", txtAddress.Text)
                    .AddWithValue("6", txtSalary.Text)

                End With

                If myComm.ExecuteNonQuery = 0 Then
                    MsgBox("ADD Fail")
                Else


                    txtAddress.Clear()
                    txtEmpID.Clear()
                    txtEmpName.Clear()
                    txtEmpLname.Clear()
                    txtSalary.Clear()
                    cboDepart.SelectedIndex = 0
                    radFemale.Checked = False
                    radMale.Checked = False
                    panEmp.Enabled = False

                    '  strSQL = "select empID,empName,empLname,IIF(sex=1, 'ชาย', 'หญิง') As gender ,address,salary,depID from tbEmployee "
                    strSQL = "select * from tbEmployee"
                    myDA = New SqlDataAdapter(strSQL, myCon)
                    myDS = New DataSet
                    myDA.Fill(myDS, "table")
                    dgvEmp.DataSource = myDS.Tables("table")
                    MsgBox("ADD OK")
                    dgvEmp.Enabled = True
                    panEmp.Enabled = False
                    btnInsert.Enabled = True
                    btnEdit.Enabled = True
                    btnDelete.Enabled = True
                    btnClose.Enabled = True
                End If

            Else

                If oldEmpID <> txtEmpID.Text Then
                    strSQL = "select empID from tbEmployee where empID = @eid"
                    myComm = New SqlCommand(strSQL, myCon)
                    myComm.Parameters.AddWithValue("eid", txtEmpID.Text)
                    myDR = myComm.ExecuteReader()

                    If myDR.HasRows Then
                        MessageBox.Show("ข้อมูลที่แก้ไขเข้ามีอยู่แล้ว")
                        myDR.Close()
                        Exit Sub
                    End If
                End If
                myDR.Close()



                strSQL = "update tbEmployee set empID=@1,empName=@2 ,empLname=@3 ,sex=@4 ,address=@5 ,salary=@6 ,depID = (select depID from tbDepartment where depName = '" & cboDepart.SelectedItem & "') where empID = @eid"
                myComm = New SqlCommand(strSQL, myCon)
                myComm.Parameters.Clear()
                With myComm.Parameters
                    .AddWithValue("1", txtEmpID.Text)
                    .AddWithValue("2", txtEmpName.Text)
                    .AddWithValue("3", txtEmpLname.Text)
                    .AddWithValue("4", gender)
                    .AddWithValue("5", txtAddress.Text)
                    .AddWithValue("6", txtSalary.Text)
                    .AddWithValue("eid", oldEmpID)
                End With


                If myComm.ExecuteNonQuery = 0 Then
                    MsgBox("Edit Fail")
                Else


                    txtAddress.Clear()
                    txtEmpID.Clear()
                    txtEmpName.Clear()
                    txtEmpLname.Clear()
                    txtSalary.Clear()
                    cboDepart.SelectedIndex = 0
                    radFemale.Checked = False
                    radMale.Checked = False
                    panEmp.Enabled = False

                    strSQL = "select empID,empName,empLname,IIF(sex=1, 'ชาย', 'หญิง') As Gender ,address,salary,depID from tbEmployee"
                    myDA = New SqlDataAdapter(strSQL, myCon)
                    myDS = New DataSet
                    myDA.Fill(myDS, "table")
                    dgvEmp.DataSource = myDS.Tables("table")
                    MsgBox("Edit OK")
                    dgvEmp.Enabled = True
                    panEmp.Enabled = False
                    btnInsert.Enabled = True
                    btnEdit.Enabled = True
                    btnDelete.Enabled = True
                    btnClose.Enabled = True
                End If
            End If


        End If




        myCon.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtEmpID.Select()
        txtAddress.Clear()
        txtEmpID.Clear()
        txtEmpName.Clear()
        txtEmpLname.Clear()
        txtSalary.Clear()
        cboDepart.SelectedIndex = 0

        radMale.Checked = True
        dgvEmp.Enabled = True
        btnInsert.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
    End Sub



    Private Sub dgvEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellClick

    End Sub

    Private Sub dgvEmp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellEnter
        If dgvEmp.RowCount = 0 Or dgvEmp.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        connectDB()

        Dim x As Integer = dgvEmp.CurrentRow.Index
        Dim selectA As String = dgvEmp.Item(0, x).Value
        'strSQL = "select * from tbEmployee,tbDepartment where empID = '" & selectA & "'"
        strSQL = "select tbEmployee.*,tbDepartment.depName from tbEmployee,tbDepartment where tbEmployee.depID = tbDepartment.depID and empID = @eid"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.Parameters.AddWithValue("eid", selectA)
        myDR = myComm.ExecuteReader
        myDR.Read()


        txtEmpID.Text = myDR.Item("EmpID")
        txtEmpName.Text = myDR.Item("EmpName")
        txtEmpLname.Text = myDR.Item("EmpLname")
        txtAddress.Text = myDR.Item("address")
        txtSalary.Text = myDR.Item("salary")
        If myDR.Item("sex") = True Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If

        cboDepart.SelectedItem = myDR.Item("depName")

        myDR.Close()
        myCon.Close()

    End Sub
End Class