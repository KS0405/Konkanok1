Public Class frmJob6
    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chkCarForme_Click(sender As Object, e As EventArgs) Handles chkCarForme.Click
        Dim F1, F2, F3 As Integer
        F1 = 25000
        F2 = 15000
        F3 = 35000

        If chkCarForme.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

            lblPaidPrice.Text = lblStartPrice.Text + F1 + F2 + F3
        Else
            If MessageBox.Show("คุณต้องการยกเลิกรายการหรือไม่", "ยกเลิกรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblPaidPrice.Text = ""
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
            Else
                chkCarForme.Checked = True
            End If
        End If


    End Sub

    Private Sub chkCarForme_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForme.CheckedChanged

    End Sub

    Private Sub chkItemsAdd1_Click(sender As Object, e As EventArgs) Handles chkItemsAdd1.Click
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice1.Text)
        End If

    End Sub

    Private Sub chkItemsAdd2_Click(sender As Object, e As EventArgs) Handles chkItemsAdd2.Click
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice2.Text)
        End If
    End Sub

    Private Sub chkItemsAdd3_Click(sender As Object, e As EventArgs) Handles chkItemsAdd3.Click
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice3.Text)
        End If
    End Sub

    Private Sub chkItemsAdd4_Click(sender As Object, e As EventArgs) Handles chkItemsAdd4.Click
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice4.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice4.Text)
        End If
    End Sub

    Private Sub chkFree1_Click(sender As Object, e As EventArgs) Handles chkFree1.Click
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        End If
    End Sub
End Class