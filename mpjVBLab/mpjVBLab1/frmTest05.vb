Public Class frmTest05
    Dim decTotal, decDiscount, decNet As Decimal

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Call bntCalculate_Click(sender, e)
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Call bntCalculate_Click(sender, e)
    End Sub

    Private Sub bntCalculate_Click(sender As Object, e As EventArgs) Handles bntCalculate.Click
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        If decTotal < 1000 Then
            decDiscount = 0
        ElseIf decTotal < 5000 Then
            decDiscount = 300
        ElseIf decTotal < 10000 Then
            decDiscount = 500
        Else
            decDiscount = 1000
        End If
        DecNet = decTotal - decDiscount
        lblTotal.Text = FormatNumber(decTotal)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblNet.Text = FormatNumber(decNet)
    End Sub

    Private Sub frmTest05_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class