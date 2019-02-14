Public Class ExamMidterm
    Private Sub ExamMidterm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim sum1, sum2, km1, km2, km3, km4, price1, price2, price3, price4, goback As Decimal
        sum1 = 20
        sum2 = 50
        goback = 50

        If radmoto.Checked Then
            price1 = 2
            km1 = txtKM.Text * price1
            lblSum.Text = km1 + sum1
            lblsumKM.Text = km1
            lblPriceStart.Text = sum1
            lblSumGoback.Text = ""
            If chkGoBack.Checked Then
                lblsumKM.Text = ""
                lblSum.Text = ((km1 * 2) + sum1) + goback
                lblSumGoback.Text = (km1 * 2)

            End If
        ElseIf radkab.Checked Then
            price2 = 4
            km2 = txtKM.Text * price2
            lblSum.Text = km2 + sum2
            lblsumKM.Text = km2
            lblPriceStart.Text = sum2
            lblSumGoback.Text = ""
            If chkGoBack.Checked Then
                lblsumKM.Text = ""
                lblSum.Text = ((km2 * 2) + sum2) + goback
                lblSumGoback.Text = (km2 * 2)

            End If
        ElseIf radcar.Checked Then
            price3 = 6
            km3 = txtKM.Text * price3
            lblSum.Text = km3 + sum2
            lblsumKM.Text = km3
            lblPriceStart.Text = sum2
            lblSumGoback.Text = ""
            If chkGoBack.Checked Then
                lblsumKM.Text = ""
                lblSum.Text = ((km3 * 2) + sum2) + goback
                lblSumGoback.Text = (km3 * 2)

            End If
        ElseIf radsuv.Checked Then
            price4 = 8
            km4 = txtKM.Text * price4
            lblSum.Text = sum2 + km4
            lblsumKM.Text = km4
            lblPriceStart.Text = sum2
            lblSumGoback.Text = ""
            If chkGoBack.Checked Then
                lblsumKM.Text = ""
                lblSum.Text = ((km4 * 2) + sum2) + goback
                lblSumGoback.Text = (km4 * 2)

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        radmoto.Checked = True
        txtKM.Clear()
        lblSum.Text = ""
        lblsumKM.Text = ""
        chkGoBack.Checked = False
        lblPriceStart.Text = ""
        lblSumGoback.Text = ""

    End Sub
End Class