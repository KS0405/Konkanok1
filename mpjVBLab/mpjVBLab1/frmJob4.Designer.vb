<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob4
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.lblAllIncome = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "วันที่"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เงินเดือน"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ยอดขายทั้งปี"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เงินเดือนทั้งปี"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "เงินรับโบนัส"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "รวมรายได้"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ภาษีที่ต้องชำระ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "หักค่าลดหย่อน"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Silver
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDate.Location = New System.Drawing.Point(262, 116)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(214, 23)
        Me.lblDate.TabIndex = 9
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.Silver
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.Location = New System.Drawing.Point(262, 367)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(214, 23)
        Me.lblTax.TabIndex = 14
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllowance
        '
        Me.lblAllowance.BackColor = System.Drawing.Color.Silver
        Me.lblAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAllowance.Location = New System.Drawing.Point(262, 331)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(214, 23)
        Me.lblAllowance.TabIndex = 13
        Me.lblAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllIncome
        '
        Me.lblAllIncome.BackColor = System.Drawing.Color.Silver
        Me.lblAllIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAllIncome.Location = New System.Drawing.Point(262, 294)
        Me.lblAllIncome.Name = "lblAllIncome"
        Me.lblAllIncome.Size = New System.Drawing.Size(214, 23)
        Me.lblAllIncome.TabIndex = 12
        Me.lblAllIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.Silver
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(262, 258)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(214, 23)
        Me.lblBonus.TabIndex = 11
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYearSalary
        '
        Me.lblYearSalary.BackColor = System.Drawing.Color.Silver
        Me.lblYearSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblYearSalary.Location = New System.Drawing.Point(262, 222)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(214, 23)
        Me.lblYearSalary.TabIndex = 10
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(266, 151)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(210, 26)
        Me.txtSalary.TabIndex = 15
        '
        'txtSale
        '
        Me.txtSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSale.Location = New System.Drawing.Point(266, 184)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(210, 26)
        Me.txtSale.TabIndex = 16
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radShortDate.Location = New System.Drawing.Point(28, 26)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(162, 24)
        Me.radShortDate.TabIndex = 17
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radGenDate.Location = New System.Drawing.Point(28, 56)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(180, 24)
        Me.radGenDate.TabIndex = 18
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ General Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radLongDate.Location = New System.Drawing.Point(28, 86)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(159, 24)
        Me.radLongDate.TabIndex = 19
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(498, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 128)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'btnCalTax
        '
        Me.btnCalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalTax.Location = New System.Drawing.Point(526, 274)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(171, 60)
        Me.btnCalTax.TabIndex = 21
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = True
        '
        'frmJob4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 466)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.lblAllIncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob4"
        Me.Text = "Calculate of Texation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblAllowance As Label
    Friend WithEvents lblAllIncome As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblYearSalary As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents radShortDate As RadioButton
    Friend WithEvents radGenDate As RadioButton
    Friend WithEvents radLongDate As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalTax As Button
End Class
