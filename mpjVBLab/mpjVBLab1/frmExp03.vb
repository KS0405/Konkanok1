Public Class frmExp03
    Private Sub frmTest03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim today As Date = Date.Now
        lblToday.Text = FormatDateTime(today, DateFormat.LongDate)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblToday.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Integer = Val(cboSelect.Text)

        txtMyNumber.Font = New Font(txtMyNumber.Font.Name, size, FontStyle.Regular)
        txtMyNumber.Text = FormatNumber(txtMyNumber.Text, 2)
    End Sub

    Private Sub lblBgRed_Click(sender As Object, e As EventArgs) Handles lblBgRed.Click
        txtMyNumber.BackColor = lblBgRed.BackColor
    End Sub

    Private Sub lblBgYellow_Click(sender As Object, e As EventArgs) Handles lblBgYellow.Click
        txtMyNumber.BackColor = lblBgYellow.BackColor
    End Sub

    Private Sub lblFgRed_Click(sender As Object, e As EventArgs) Handles lblFgRed.Click
        txtMyNumber.ForeColor = lblBgRed.BackColor
    End Sub

    Private Sub lblFgYellow_Click(sender As Object, e As EventArgs) Handles lblFgYellow.Click
        txtMyNumber.ForeColor = lblBgYellow.BackColor
    End Sub
End Class