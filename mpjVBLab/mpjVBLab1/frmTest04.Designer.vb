<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest04
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProID = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProTotal = New System.Windows.Forms.Label()
        Me.lblProNet = New System.Windows.Forms.Label()
        Me.radProCash = New System.Windows.Forms.RadioButton()
        Me.radProCredit = New System.Windows.Forms.RadioButton()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ราคาต่อหน่วย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(165, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(165, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(165, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "การชำระเงิน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ยอดชำระ"
        '
        'lblProID
        '
        Me.lblProID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblProID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProID.Location = New System.Drawing.Point(272, 41)
        Me.lblProID.Name = "lblProID"
        Me.lblProID.Size = New System.Drawing.Size(210, 27)
        Me.lblProID.TabIndex = 7
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProName.Location = New System.Drawing.Point(272, 91)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(210, 27)
        Me.lblProName.TabIndex = 8
        '
        'lblProPrice
        '
        Me.lblProPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProPrice.Location = New System.Drawing.Point(272, 133)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(210, 27)
        Me.lblProPrice.TabIndex = 9
        '
        'lblProTotal
        '
        Me.lblProTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblProTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProTotal.Location = New System.Drawing.Point(272, 229)
        Me.lblProTotal.Name = "lblProTotal"
        Me.lblProTotal.Size = New System.Drawing.Size(210, 27)
        Me.lblProTotal.TabIndex = 10
        '
        'lblProNet
        '
        Me.lblProNet.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblProNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProNet.Location = New System.Drawing.Point(272, 335)
        Me.lblProNet.Name = "lblProNet"
        Me.lblProNet.Size = New System.Drawing.Size(217, 87)
        Me.lblProNet.TabIndex = 11
        '
        'radProCash
        '
        Me.radProCash.AutoSize = True
        Me.radProCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radProCash.Location = New System.Drawing.Point(282, 291)
        Me.radProCash.Name = "radProCash"
        Me.radProCash.Size = New System.Drawing.Size(66, 24)
        Me.radProCash.TabIndex = 12
        Me.radProCash.TabStop = True
        Me.radProCash.Text = "เงินสด"
        Me.radProCash.UseVisualStyleBackColor = True
        '
        'radProCredit
        '
        Me.radProCredit.AutoSize = True
        Me.radProCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radProCredit.Location = New System.Drawing.Point(379, 291)
        Me.radProCredit.Name = "radProCredit"
        Me.radProCredit.Size = New System.Drawing.Size(72, 24)
        Me.radProCredit.TabIndex = 13
        Me.radProCredit.TabStop = True
        Me.radProCredit.Text = "เงินเชื่อ"
        Me.radProCredit.UseVisualStyleBackColor = True
        '
        'txtProAmount
        '
        Me.txtProAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProAmount.Location = New System.Drawing.Point(272, 181)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(210, 26)
        Me.txtProAmount.TabIndex = 14
        '
        'frmTest04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 483)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.radProCredit)
        Me.Controls.Add(Me.radProCash)
        Me.Controls.Add(Me.lblProNet)
        Me.Controls.Add(Me.lblProTotal)
        Me.Controls.Add(Me.lblProPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTest04"
        Me.Text = "แบบฝึกปฎิบัติสัปดาห์ที่ 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblProID As Label
    Friend WithEvents lblProName As Label
    Friend WithEvents lblProPrice As Label
    Friend WithEvents lblProTotal As Label
    Friend WithEvents lblProNet As Label
    Friend WithEvents radProCash As RadioButton
    Friend WithEvents radProCredit As RadioButton
    Friend WithEvents txtProAmount As TextBox
End Class
