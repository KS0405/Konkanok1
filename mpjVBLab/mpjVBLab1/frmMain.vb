Public Class frmMain
    Private Sub แบบฝกหด1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles แบบฝกหด1ToolStripMenuItem2.Click

    End Sub

    Private Sub ใบงานท1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท1ToolStripMenuItem.Click
        Dim Lab1 As New frmSalary
        Lab1.ShowDialog()
    End Sub

    Private Sub ใบงานท2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท2ToolStripMenuItem.Click
        Dim Lab2 As New frmSale
        Lab2.ShowDialog()
    End Sub

    Private Sub ใบงานท3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท3ToolStripMenuItem.Click
        Dim Lab3 As New frmLab3
        Lab3.ShowDialog()
    End Sub

    Private Sub ใบงานท4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท4ToolStripMenuItem.Click
        Dim Lab4 As New frmJob4
        Lab4.ShowDialog()
    End Sub

    Private Sub ใบงานท5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท5ToolStripMenuItem.Click
        Dim Lab5 As New frmLab5
        Lab5.ShowDialog()
    End Sub

    Private Sub ใบงานท6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท6ToolStripMenuItem.Click
        Dim Lab6 As New frmJob6
        Lab6.ShowDialog()
    End Sub

    Private Sub ใบงานท7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท7ToolStripMenuItem.Click
        Dim Lab7 As New frmLab7
        Lab7.ShowDialog()
    End Sub

    Private Sub ใบงานท8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท8ToolStripMenuItem.Click
        Dim Lab8 As New frmLab8
        Lab8.ShowDialog()
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub แบบฝกหด1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles แบบฝกหด1ToolStripMenuItem.Click
        Dim Test01 As New frmTest01
        Test01.ShowDialog()
    End Sub

    Private Sub แบบฝกหด1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles แบบฝกหด1ToolStripMenuItem1.Click
        Dim Test02 As New frmTest02
        Test02.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabToolStripMenuItem.Click

    End Sub
End Class