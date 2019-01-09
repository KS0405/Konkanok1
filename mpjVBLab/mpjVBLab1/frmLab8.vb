Public Class frmLab8
    Dim oldScore, oldCredit, newGPA As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtSubject.Text.Trim = "" Or txtScore.Text.Trim = "" Or txtCredit.Text.Trim = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSubject.Focus()
        Else
            Dim Grade As String = getGrade(Val(txtScore.Text))
            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(txtScore.Text)
            lstCredit.Items.Add(txtCredit.Text)
            lstGrade.Items.Add(Grade)
            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstCredit.SelectedIndex = lstCredit.Items.Count - 1
            lstGrade.SelectedIndex = lstGrade.Items.Count - 1
            txtSubject.Focus()

            txtSubject.Clear()
            txtScore.Clear()
            txtCredit.Clear()

        End If

        SumScore()



    End Sub
    Private Sub SumScore()
        Dim grade As Decimal
        Dim cradit As Integer = lstCredit.Items(lstCredit.Items.Count - 1)
        Dim gradestr As String = lstGrade.Items(lstGrade.Items.Count - 1)

        Select Case gradestr
            Case "A"
                grade = 4
            Case "B+"
                grade = 3.5
            Case "B"
                grade = 3
            Case "C+"
                grade = 2.5
            Case "C"
                grade = 2
            Case "D+"
                grade = 1.5
            Case "D"
                grade = 1
            Case Else
                grade = 0

        End Select

        oldScore = oldScore + (cradit * grade)
        oldCredit = oldCredit + cradit

        newGPA = oldScore / oldCredit
        lblNewGPA.Text = FormatNumber(newGPA, 2)


    End Sub
    Private Sub txtScore_TextChanged(sender As Object, e As EventArgs) Handles txtScore.TextChanged

    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then 'backspace
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then 'backspace
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oldScore = Val(lblOldTotalScore.Text)
        oldCredit = Val(lblOldTotalCredit.Text)
        lblOldGPA.Text = oldScore / oldCredit
        lblOldGPA.Text = FormatNumber(lblOldGPA.Text, 2)


    End Sub


    Private Function getGrade(score As Integer) As String
        Dim A As String
        If score >= 80 Then
            A = "A"
        ElseIf score >= 75 Then
            A = "B+"
        ElseIf score >= 70 Then
            A = "B"
        ElseIf score >= 65 Then
            A = "D+"
        ElseIf score >= 60 Then
            A = "D"
        ElseIf score >= 55 Then
            A = "D+"
        ElseIf score >= 50 Then
            A = "D"
        Else
            A = "F"
        End If
        Return A
    End Function

    Private Sub lstSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubject.SelectedIndexChanged
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex


    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubject.SelectedIndex = lstScore.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubject.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        txtSubject.Clear()
        txtScore.Clear()
        txtCredit.Clear()
        lblNewGPA.Text = ""

    End Sub
End Class