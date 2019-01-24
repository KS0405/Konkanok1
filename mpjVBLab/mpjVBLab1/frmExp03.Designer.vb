<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExp03
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblBgRed = New System.Windows.Forms.Label()
        Me.lblBgYellow = New System.Windows.Forms.Label()
        Me.lblFgRed = New System.Windows.Forms.Label()
        Me.lblFgYellow = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.txtMyNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "วันที่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ตัวเลข"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(488, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(488, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblBgRed
        '
        Me.lblBgRed.BackColor = System.Drawing.Color.Red
        Me.lblBgRed.Location = New System.Drawing.Point(98, 286)
        Me.lblBgRed.Name = "lblBgRed"
        Me.lblBgRed.Size = New System.Drawing.Size(42, 32)
        Me.lblBgRed.TabIndex = 6
        '
        'lblBgYellow
        '
        Me.lblBgYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBgYellow.Location = New System.Drawing.Point(146, 286)
        Me.lblBgYellow.Name = "lblBgYellow"
        Me.lblBgYellow.Size = New System.Drawing.Size(42, 32)
        Me.lblBgYellow.TabIndex = 7
        '
        'lblFgRed
        '
        Me.lblFgRed.BackColor = System.Drawing.Color.Red
        Me.lblFgRed.Location = New System.Drawing.Point(236, 286)
        Me.lblFgRed.Name = "lblFgRed"
        Me.lblFgRed.Size = New System.Drawing.Size(42, 32)
        Me.lblFgRed.TabIndex = 8
        '
        'lblFgYellow
        '
        Me.lblFgYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFgYellow.Location = New System.Drawing.Point(284, 286)
        Me.lblFgYellow.Name = "lblFgYellow"
        Me.lblFgYellow.Size = New System.Drawing.Size(42, 32)
        Me.lblFgYellow.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "ขนาด"
        '
        'cboSelect
        '
        Me.cboSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14", "16", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54", "56", "58", "60", "62", "64"})
        Me.cboSelect.Location = New System.Drawing.Point(289, 211)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(180, 33)
        Me.cboSelect.TabIndex = 11
        '
        'lblToday
        '
        Me.lblToday.BackColor = System.Drawing.Color.White
        Me.lblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblToday.Location = New System.Drawing.Point(193, 77)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(276, 35)
        Me.lblToday.TabIndex = 12
        Me.lblToday.Text = "Label9"
        '
        'txtMyNumber
        '
        Me.txtMyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMyNumber.Location = New System.Drawing.Point(198, 137)
        Me.txtMyNumber.Name = "txtMyNumber"
        Me.txtMyNumber.Size = New System.Drawing.Size(271, 31)
        Me.txtMyNumber.TabIndex = 13
        '
        'frmTest03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 478)
        Me.Controls.Add(Me.txtMyNumber)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblFgYellow)
        Me.Controls.Add(Me.lblFgRed)
        Me.Controls.Add(Me.lblBgYellow)
        Me.Controls.Add(Me.lblBgRed)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTest03"
        Me.Text = "frmTest03"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblBgRed As Label
    Friend WithEvents lblBgYellow As Label
    Friend WithEvents lblFgRed As Label
    Friend WithEvents lblFgYellow As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSelect As ComboBox
    Friend WithEvents lblToday As Label
    Friend WithEvents txtMyNumber As TextBox
End Class
