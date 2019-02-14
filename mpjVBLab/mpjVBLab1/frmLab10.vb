Public Class frmLab10
    Dim decSale(4, 2), i As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale As Integer
    Dim sumA, sumB, sumC, total As Decimal



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
            txtSaleName.Focus()
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
        Call showDatagrit()

        txtSaleA.Clear()
        txtSaleB.Clear()
        txtSaleC.Clear()
        txtSaleName.Clear()

        txtSaleName.Select()
    End Sub

    Sub showData()
        lstData.Items.Clear()
        sumA = 0
        sumB = 0
        sumC = 0
        For i = 0 To saleName.Length - 1
            If Not IsNothing(saleName) Then
                lstData.Items.Add(saleName(i) & "," & (decSale(i, 0) & "," & (decSale(i, 1) & "," & (decSale(i, 2)))))
                sumA += decSale(i, 0)
                sumB += decSale(i, 1)
                sumC += decSale(i, 2)
                intIndex = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

                If decSumSale < intIndex Then
                    decSumSale = intIndex
                    total = i

                End If
            End If

        Next
        lblSumA.Text = sumA
        lblSumB.Text = sumB
        lblSumC.Text = sumC
        lblMaxSaleName.Text = saleName(total)
        lblMaxSaleAmount.Text = decSumSale


    End Sub
    Private Sub showDatagrit()
        Dim i, total As Integer
        For i = 0 To saleName.Length - 1
            datagrit.Rows.Add()
            datagrit.Item(0, i).Value = saleName(i)
            datagrit.Item(1, i).Value = decSale(i, 0)
            datagrit.Item(2, i).Value = decSale(i, 1)
            datagrit.Item(3, i).Value = decSale(i, 2)

            total = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

            datagrit.Item(4, i).Value = total
        Next
    End Sub

End Class