<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBwhite = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(171, 58)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(365, 86)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUp.Location = New System.Drawing.Point(542, 58)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(82, 41)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDown.Location = New System.Drawing.Point(542, 105)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(82, 41)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'cboSize
        '
        Me.cboSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSize.ForeColor = System.Drawing.Color.Black
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"10", "12", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "45", "50", "70"})
        Me.cboSize.Location = New System.Drawing.Point(415, 161)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 28)
        Me.cboSize.TabIndex = 3
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.ForeColor = System.Drawing.Color.Black
        Me.lblFRed.Location = New System.Drawing.Point(14, 30)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(37, 28)
        Me.lblFRed.TabIndex = 4
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Location = New System.Drawing.Point(14, 70)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(37, 28)
        Me.lblFOrange.TabIndex = 5
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(62, 70)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(37, 28)
        Me.lblFYellow.TabIndex = 7
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(62, 30)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(37, 28)
        Me.lblFBlue.TabIndex = 6
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.Maroon
        Me.lblFBrown.Location = New System.Drawing.Point(111, 70)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(37, 28)
        Me.lblFBrown.TabIndex = 11
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFGreen.Location = New System.Drawing.Point(111, 30)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(37, 28)
        Me.lblFGreen.TabIndex = 10
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(159, 70)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(37, 28)
        Me.lblFWhite.TabIndex = 9
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.Location = New System.Drawing.Point(159, 30)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(37, 28)
        Me.lblFViolet.TabIndex = 8
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.Aqua
        Me.lblFSky.Location = New System.Drawing.Point(207, 70)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(37, 28)
        Me.lblFSky.TabIndex = 13
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(207, 30)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(37, 28)
        Me.lblFBlack.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 136)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(46, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 20)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "กำหนดตัวเลข"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(310, 164)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 20)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "ขนาดฟอนต์"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.lblBwhite)
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Location = New System.Drawing.Point(369, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 136)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblBwhite
        '
        Me.lblBwhite.BackColor = System.Drawing.Color.White
        Me.lblBwhite.Location = New System.Drawing.Point(159, 70)
        Me.lblBwhite.Name = "lblBwhite"
        Me.lblBwhite.Size = New System.Drawing.Size(37, 28)
        Me.lblBwhite.TabIndex = 9
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.Aqua
        Me.lblBSky.Location = New System.Drawing.Point(207, 70)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(37, 28)
        Me.lblBSky.TabIndex = 13
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.ForeColor = System.Drawing.Color.Black
        Me.lblBRed.Location = New System.Drawing.Point(14, 30)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(37, 28)
        Me.lblBRed.TabIndex = 4
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(207, 30)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(37, 28)
        Me.lblBBlack.TabIndex = 12
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.Location = New System.Drawing.Point(14, 70)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(37, 28)
        Me.lblBOrange.TabIndex = 5
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.Maroon
        Me.lblBBrown.Location = New System.Drawing.Point(111, 70)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(37, 28)
        Me.lblBBrown.TabIndex = 11
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(62, 30)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(37, 28)
        Me.lblBBlue.TabIndex = 6
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBGreen.Location = New System.Drawing.Point(111, 30)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(37, 28)
        Me.lblBGreen.TabIndex = 10
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(62, 70)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(37, 28)
        Me.lblBYellow.TabIndex = 7
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.Location = New System.Drawing.Point(159, 30)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(37, 28)
        Me.lblBViolet.TabIndex = 8
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 446)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents lblFRed As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblBwhite As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBViolet As Label
End Class
