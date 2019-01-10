Public Class frmTest02
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radLock.CheckedChanged
        txtBaht.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles radUnlock.CheckedChanged
        txtBaht.Enabled = True
        radUs.Enabled = True
        radFrench.Enabled = True
        radKorea.Enabled = True
    End Sub

    Private Sub radUs_CheckedChanged(sender As Object, e As EventArgs) Handles radUs.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 39
    End Sub

    Private Sub radFrench_CheckedChanged(sender As Object, e As EventArgs) Handles radFrench.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 37
    End Sub

    Private Sub radKorea_CheckedChanged(sender As Object, e As EventArgs) Handles radKorea.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 30
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class