Public Class frmJob4
    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        Dim dayS As String = Format(Now, "short Date")
        lblDate.Text = dayS
        'lblDate.Text = Format(Now, "short Date")
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        Dim dayG As String = Format(Now, "General Date")
        lblDate.Text = dayG
        'lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        Dim dayL As String = Format(Now, "Long Date")
        lblDate.Text = dayL
        'lblDate.Text = Format(Now, "Long Date")
    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim day As String = Now.Date
        lblDate.Text = day
        'lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS, decR_ALLOW, decR_TAX, dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
        decR_BONUS = 0.2
        decR_ALLOW = 0.01
        decR_TAX = 0.07

        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = (Val(txtSale.Text) * decR_BONUS)
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = FormatNumber(dblYearSalary, 2)
        lblBonus.Text = FormatNumber(dblBonus, 2)
        lblAllIncome.Text = FormatNumber(dblAllIncome, 2)
        lblAllowance.Text = FormatNumber(dblAllowance, 2)
        lblTax.Text = FormatNumber(dblTax, 2)

    End Sub
End Class