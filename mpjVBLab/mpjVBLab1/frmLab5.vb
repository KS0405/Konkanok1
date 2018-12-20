Public Class frmLab5
    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Dc1, Dc2, Dc3, Dc4 As Double
        Dc1 = 0
        Dc2 = 0.05
        Dc3 = 0.1
        Dc4 = 0.15

        If txtProduct.Text.Trim = "" Or Val(txtPrice.Text) = 0 Or Val(txtUnit.Text) = 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        End If

        If radMember.Checked = True And radPaid.Checked = True Then
            If lblTotal.Text < 1000 Then
                lblDiscount.Text = Val(lblTotal.Text) * Dc1
            ElseIf lblTotal.Text < 5000 Then
                lblDiscount.Text = Val(lblTotal.Text) * Dc2
            ElseIf lblTotal.Text < 10000 Then
                lblDiscount.Text = Val(lblTotal.Text) * Dc3
            Else
                lblDiscount.Text = Val(lblTotal.Text) * Dc4
            End If
            lblPaid.Text = Val(lblTotal.Text) - Val(lblDiscount.Text)
            lblCredit.Text = 0
        End If

        If radMember.Checked = True And radCredit.Checked = True Then
            lblDiscount.Text = 0
            lblPaid.Text = lblTotal.Text
            lblCredit.Text = lblPaid.Text
        End If

        If radOther.Checked = True And radPaid.Checked = True Then
            lblDiscount.Text = 0
            lblPaid.Text = lblTotal.Text
            lblCredit.Text = 0

        End If



    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub lblTotal_ControlAdded(sender As Object, e As ControlEventArgs) Handles lblTotal.ControlAdded

    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

        gpbPaid.Enabled = True


    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""

        gpbPaid.Enabled = False
        radPaid.Checked = True


    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub
End Class