Public Class frmLab7
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
        txtAdd.Focus()

    End Sub

    Private Sub cboOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim n As Integer
        lstAdd.Items.Add(txtAdd.Text)
        n = lstAdd.Items.Count
        lstAdd.SelectedIndex = n - 1
        txtAdd.Text = ""
        txtAdd.Focus()
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim A, B As Integer
        A = lstAdd.Items.Count
        If A = 0 Then
            MessageBox.Show("No Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            cboOutput.Items.Add(lstAdd.SelectedItem)
            B = lstAdd.SelectedIndex
            If lstAdd.SelectedIndex = lstAdd.Items.Count - 1 Then
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = B
            End If
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If


    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        Dim a As Integer
        a = lstAdd.Items.Count
        If a < 1 Then
            MessageBox.Show("No Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            For aa = 1 To lstAdd.Items.Count
                cboOutput.Items.Add(lstAdd.SelectedItem)
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Next
            lblOutput.Text = cboOutput.SelectedItem
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        Dim b As Integer
        b = cboOutput.Items.Count
        If b < 1 Then
            MessageBox.Show("No Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            For bb = 1 To cboOutput.Items.Count
                lstAdd.Items.Add(cboOutput.SelectedItem)
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next
            cboOutput.Text = ""
            lblOutput.Text = cboOutput.SelectedItem
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        cboOutput.Text = ""
        txtAdd.Clear()
        lblOutput.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim a, b As Integer
        a = cboOutput.Items.Count
        If a < 1 Then
            MessageBox.Show("No Choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            cboOutput.Text = ""
            lstAdd.Items.Add(cboOutput.SelectedItem)
            b = lstAdd.SelectedIndex
            If cboOutput.SelectedIndex = cboOutput.Items.Count - 1 Then
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Else
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = b
            End If
            cboOutput.Items.Remove(cboOutput.SelectedItem)
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
        lblOutput.Text = cboOutput.SelectedItem
    End Sub
End Class