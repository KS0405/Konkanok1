<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamMidterm
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
        Me.radmoto = New System.Windows.Forms.RadioButton()
        Me.radkab = New System.Windows.Forms.RadioButton()
        Me.radcar = New System.Windows.Forms.RadioButton()
        Me.radsuv = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkGoBack = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblsumKM = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSumGoback = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblPriceStart = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณค่าเดินทาง"
        '
        'radmoto
        '
        Me.radmoto.AutoSize = True
        Me.radmoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radmoto.ForeColor = System.Drawing.Color.Black
        Me.radmoto.Location = New System.Drawing.Point(54, 39)
        Me.radmoto.Name = "radmoto"
        Me.radmoto.Size = New System.Drawing.Size(138, 28)
        Me.radmoto.TabIndex = 1
        Me.radmoto.TabStop = True
        Me.radmoto.Text = "รถจักรยานยนต์"
        Me.radmoto.UseVisualStyleBackColor = True
        '
        'radkab
        '
        Me.radkab.AutoSize = True
        Me.radkab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radkab.ForeColor = System.Drawing.Color.Black
        Me.radkab.Location = New System.Drawing.Point(54, 73)
        Me.radkab.Name = "radkab"
        Me.radkab.Size = New System.Drawing.Size(93, 28)
        Me.radkab.TabIndex = 2
        Me.radkab.TabStop = True
        Me.radkab.Text = "รถกระบะ"
        Me.radkab.UseVisualStyleBackColor = True
        '
        'radcar
        '
        Me.radcar.AutoSize = True
        Me.radcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radcar.ForeColor = System.Drawing.Color.Black
        Me.radcar.Location = New System.Drawing.Point(54, 107)
        Me.radcar.Name = "radcar"
        Me.radcar.Size = New System.Drawing.Size(68, 28)
        Me.radcar.TabIndex = 3
        Me.radcar.TabStop = True
        Me.radcar.Text = "รถเก๋ง"
        Me.radcar.UseVisualStyleBackColor = True
        '
        'radsuv
        '
        Me.radsuv.AutoSize = True
        Me.radsuv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radsuv.ForeColor = System.Drawing.Color.Black
        Me.radsuv.Location = New System.Drawing.Point(54, 141)
        Me.radsuv.Name = "radsuv"
        Me.radsuv.Size = New System.Drawing.Size(89, 28)
        Me.radsuv.TabIndex = 4
        Me.radsuv.TabStop = True
        Me.radsuv.Text = "รถ SUV"
        Me.radsuv.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radcar)
        Me.GroupBox1.Controls.Add(Me.radkab)
        Me.GroupBox1.Controls.Add(Me.radsuv)
        Me.GroupBox1.Controls.Add(Me.radmoto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(78, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 183)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทรถ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ค่าบริการเริ่มต้น"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "20 บาท"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "50 บาท"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "50 บาท"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "50 บาท"
        '
        'txtKM
        '
        Me.txtKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtKM.Location = New System.Drawing.Point(132, 355)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Size = New System.Drawing.Size(182, 29)
        Me.txtKM.TabIndex = 11
        Me.txtKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ระยะทาง"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "กิโลเมตร"
        '
        'chkGoBack
        '
        Me.chkGoBack.AutoSize = True
        Me.chkGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGoBack.Location = New System.Drawing.Point(144, 285)
        Me.chkGoBack.Name = "chkGoBack"
        Me.chkGoBack.Size = New System.Drawing.Size(183, 28)
        Me.chkGoBack.TabIndex = 14
        Me.chkGoBack.Text = "เดินทางแบบไป - กลับ"
        Me.chkGoBack.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(558, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "คิดค่ารอคอย 50 บาท"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "รวมราคาค่าเดินทาง"
        '
        'lblSum
        '
        Me.lblSum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSum.Enabled = False
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSum.ForeColor = System.Drawing.Color.Black
        Me.lblSum.Location = New System.Drawing.Point(379, 413)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(121, 32)
        Me.lblSum.TabIndex = 17
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(522, 421)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 24)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "บาท"
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCal.Location = New System.Drawing.Point(263, 469)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(108, 49)
        Me.btnCal.TabIndex = 19
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(566, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "อัตราค่าเดินทาง"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(566, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 24)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "กิโลเมตร ละ 2 บาท"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(566, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 24)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "กิโลเมตร ละ 4 บาท"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(566, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 24)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "กิโลเมตร ละ 6 บาท"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(566, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 24)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "กิโลเมตร ละ 8 บาท"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(434, 273)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 24)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "ราคาต่อกิโลเมตร"
        '
        'lblsumKM
        '
        Me.lblsumKM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblsumKM.Enabled = False
        Me.lblsumKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblsumKM.ForeColor = System.Drawing.Color.Black
        Me.lblsumKM.Location = New System.Drawing.Point(566, 266)
        Me.lblsumKM.Name = "lblsumKM"
        Me.lblsumKM.Size = New System.Drawing.Size(121, 32)
        Me.lblsumKM.TabIndex = 26
        Me.lblsumKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(693, 270)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 24)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "บาท"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(392, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 49)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "เคลียร์"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(693, 351)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 24)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "บาท"
        '
        'lblSumGoback
        '
        Me.lblSumGoback.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSumGoback.Enabled = False
        Me.lblSumGoback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumGoback.ForeColor = System.Drawing.Color.Black
        Me.lblSumGoback.Location = New System.Drawing.Point(566, 347)
        Me.lblSumGoback.Name = "lblSumGoback"
        Me.lblSumGoback.Size = New System.Drawing.Size(121, 32)
        Me.lblSumGoback.TabIndex = 30
        Me.lblSumGoback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl.Location = New System.Drawing.Point(413, 351)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(147, 24)
        Me.lbl.TabIndex = 29
        Me.lbl.Text = "ราคาต่อกิโลไป-กลับ"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(693, 311)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 24)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "บาท"
        '
        'lblPriceStart
        '
        Me.lblPriceStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPriceStart.Enabled = False
        Me.lblPriceStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPriceStart.ForeColor = System.Drawing.Color.Black
        Me.lblPriceStart.Location = New System.Drawing.Point(566, 307)
        Me.lblPriceStart.Name = "lblPriceStart"
        Me.lblPriceStart.Size = New System.Drawing.Size(121, 32)
        Me.lblPriceStart.TabIndex = 33
        Me.lblPriceStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(434, 315)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(122, 24)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "ค่าบริการเริ่มต้น"
        '
        'ExamMidterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 530)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblPriceStart)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblSumGoback)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblsumKM)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkGoBack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtKM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ExamMidterm"
        Me.Text = "ExamMidterm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radmoto As RadioButton
    Friend WithEvents radkab As RadioButton
    Friend WithEvents radcar As RadioButton
    Friend WithEvents radsuv As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKM As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkGoBack As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSum As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblsumKM As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents lblSumGoback As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblPriceStart As Label
    Friend WithEvents Label22 As Label
End Class
