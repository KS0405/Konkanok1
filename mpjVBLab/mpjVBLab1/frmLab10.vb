Public Class frmLab10
    Dim decSale(4, 2), i As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale, sumA, sumB, sumC As Integer

    Private Sub frmLab10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
    End Sub

    Private Sub txtSaleA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaleA.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then 'backspace
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub txtSaleB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaleB.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then 'backspace
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub txtSaleC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaleC.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then 'backspace
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSaleName.Text.Trim = "" Then
            MessageBox.Show("กรุณาป้อนชื่อ")
            Exit Sub
        End If
        If txtSaleA.Text = "" Or txtSaleB.Text = "" Or txtSaleC.Text = "" Then
            MessageBox.Show("กรุณาป้อนตัวเลข")
            Exit Sub
        End If

        saleName(cboIndex.SelectedIndex) = txtSaleName.Text
        decSale(cboIndex.SelectedIndex, 0) = txtSaleA.Text
        decSale(cboIndex.SelectedIndex, 1) = txtSaleB.Text
        decSale(cboIndex.SelectedIndex, 2) = txtSaleC.Text
        Call showData()

    End Sub

    Sub showData()
        sumA = 0
        sumB = 0
        sumC = 0
        For i = 0 To saleName.Length - 1
            If Not IsNothing(saleName) Then
                lstData.Items.Add(saleName(i) & "," & (decSale(i, 0) & "," & (decSale(i, 1) & "," & (decSale(i, 2)))))
                sumA = +decSale(i, 0)
                sumB = +decSale(i, 1)
                sumC = +decSale(i, 2)
                intIndex = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)
            End If
        Next


    End Sub
End Class