Public Class frmTest04
    Const decDISCOUNT_RATE As Double = 0.05
    Dim strId, strName As String
    Dim intAmount As Integer
    Dim dblPrice, dblTotal, dblDiscount, dblNet As Double

    Private Sub radProCredit_Click(sender As Object, e As EventArgs) Handles radProCredit.Click
        lblProNet.Text = lblProTotal.Text
    End Sub

    Private Sub radProCash_click(sender As Object, e As EventArgs) Handles radProCash.CheckedChanged
        dblDiscount = Val(lblProTotal.Text) * decDISCOUNT_RATE
        lblProNet.Text = Val(lblProTotal.Text) - dblDiscount
    End Sub

    Private Sub txtProAmount_TextChanged(sender As Object, e As EventArgs) Handles txtProAmount.TextChanged
        lblProTotal.Text = Val(txtProAmount.Text) * dblPrice
        radProCash.Checked = True
        Call radProCash_Click(sender, e)
    End Sub

    Private Sub frmTest04_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strId = "P001"
        strName = "Computer"
        dblPrice = 55000
        lblProID.Text = strId
        lblProName.Text = strName
        lblProPrice.Text = dblPrice
    End Sub
End Class