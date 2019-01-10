<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest02
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
        Me.txtBaht = New System.Windows.Forms.TextBox()
        Me.radUs = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radKorea = New System.Windows.Forms.RadioButton()
        Me.radLock = New System.Windows.Forms.RadioButton()
        Me.radUnlock = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณอัตราแลกเปลี่ยน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินไทย"
        '
        'txtBaht
        '
        Me.txtBaht.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBaht.Location = New System.Drawing.Point(225, 130)
        Me.txtBaht.Name = "txtBaht"
        Me.txtBaht.Size = New System.Drawing.Size(132, 31)
        Me.txtBaht.TabIndex = 2
        '
        'radUs
        '
        Me.radUs.AutoSize = True
        Me.radUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radUs.Location = New System.Drawing.Point(142, 216)
        Me.radUs.Name = "radUs"
        Me.radUs.Size = New System.Drawing.Size(110, 29)
        Me.radUs.TabIndex = 3
        Me.radUs.TabStop = True
        Me.radUs.Text = "US (39)"
        Me.radUs.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radFrench.Location = New System.Drawing.Point(142, 265)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(145, 29)
        Me.radFrench.TabIndex = 4
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "french (37)"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radKorea
        '
        Me.radKorea.AutoSize = True
        Me.radKorea.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radKorea.Location = New System.Drawing.Point(142, 314)
        Me.radKorea.Name = "radKorea"
        Me.radKorea.Size = New System.Drawing.Size(141, 29)
        Me.radKorea.TabIndex = 5
        Me.radKorea.TabStop = True
        Me.radKorea.Text = "Korea (30)"
        Me.radKorea.UseVisualStyleBackColor = True
        '
        'radLock
        '
        Me.radLock.AutoSize = True
        Me.radLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radLock.Location = New System.Drawing.Point(57, 38)
        Me.radLock.Name = "radLock"
        Me.radLock.Size = New System.Drawing.Size(80, 29)
        Me.radLock.TabIndex = 6
        Me.radLock.TabStop = True
        Me.radLock.Text = "Lock"
        Me.radLock.UseVisualStyleBackColor = True
        '
        'radUnlock
        '
        Me.radUnlock.AutoSize = True
        Me.radUnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radUnlock.Location = New System.Drawing.Point(57, 73)
        Me.radUnlock.Name = "radUnlock"
        Me.radUnlock.Size = New System.Drawing.Size(102, 29)
        Me.radUnlock.TabIndex = 7
        Me.radUnlock.TabStop = True
        Me.radUnlock.Text = "Unlock"
        Me.radUnlock.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLock)
        Me.GroupBox1.Controls.Add(Me.radUnlock)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(376, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 127)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ควบคุม"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Silver
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(155, 372)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(241, 76)
        Me.lblResult.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Location = New System.Drawing.Point(433, 381)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 54)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "แลกได้"
        '
        'frmTest02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 486)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.radKorea)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radUs)
        Me.Controls.Add(Me.txtBaht)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTest02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTest02"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBaht As TextBox
    Friend WithEvents radUs As RadioButton
    Friend WithEvents radFrench As RadioButton
    Friend WithEvents radKorea As RadioButton
    Friend WithEvents radLock As RadioButton
    Friend WithEvents radUnlock As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
End Class
