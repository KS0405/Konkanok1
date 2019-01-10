Public Class frmTest01
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub test1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblFullName.Text = txtFirstName.Text & " " & txtlastName.Text
    End Sub
End Class