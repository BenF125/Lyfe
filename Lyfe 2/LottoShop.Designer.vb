<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LottoShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LottoShop))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPAP = New System.Windows.Forms.Button()
        Me.btnLT = New System.Windows.Forms.Button()
        Me.btnST = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PickAPot = New System.Windows.Forms.Panel()
        Me.btnPC = New System.Windows.Forms.Button()
        Me.btnPB = New System.Windows.Forms.Button()
        Me.btnPA = New System.Windows.Forms.Button()
        Me.ScratchTicket = New System.Windows.Forms.Panel()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.LottoTicket = New System.Windows.Forms.Panel()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtC = New System.Windows.Forms.MaskedTextBox()
        Me.txtB = New System.Windows.Forms.MaskedTextBox()
        Me.txtA = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLottoAnswers = New System.Windows.Forms.Panel()
        Me.pnlLottoAnswers2 = New System.Windows.Forms.Panel()
        Me.lbA = New System.Windows.Forms.Label()
        Me.lbGuess = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbC = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PickAPot.SuspendLayout()
        Me.ScratchTicket.SuspendLayout()
        Me.LottoTicket.SuspendLayout()
        Me.pnlLottoAnswers.SuspendLayout()
        Me.pnlLottoAnswers2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnPAP)
        Me.GroupBox1.Controls.Add(Me.btnLT)
        Me.GroupBox1.Controls.Add(Me.btnST)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 202)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pick: 5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Scratch: 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ticket: 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price:"
        '
        'btnPAP
        '
        Me.btnPAP.Location = New System.Drawing.Point(6, 77)
        Me.btnPAP.Name = "btnPAP"
        Me.btnPAP.Size = New System.Drawing.Size(153, 23)
        Me.btnPAP.TabIndex = 4
        Me.btnPAP.Text = "Purchase Pick-a-Pot"
        Me.btnPAP.UseVisualStyleBackColor = True
        '
        'btnLT
        '
        Me.btnLT.Location = New System.Drawing.Point(6, 19)
        Me.btnLT.Name = "btnLT"
        Me.btnLT.Size = New System.Drawing.Size(153, 23)
        Me.btnLT.TabIndex = 6
        Me.btnLT.Text = "Purchase Lotto Ticket"
        Me.btnLT.UseVisualStyleBackColor = True
        '
        'btnST
        '
        Me.btnST.Location = New System.Drawing.Point(6, 48)
        Me.btnST.Name = "btnST"
        Me.btnST.Size = New System.Drawing.Size(153, 23)
        Me.btnST.TabIndex = 3
        Me.btnST.Text = "Purchase Scratch Ticket"
        Me.btnST.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(357, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit shop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PickAPot)
        Me.GroupBox2.Controls.Add(Me.ScratchTicket)
        Me.GroupBox2.Controls.Add(Me.LottoTicket)
        Me.GroupBox2.Location = New System.Drawing.Point(183, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 309)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Your Ticket:"
        '
        'PickAPot
        '
        Me.PickAPot.BackColor = System.Drawing.Color.White
        Me.PickAPot.Controls.Add(Me.btnPC)
        Me.PickAPot.Controls.Add(Me.btnPB)
        Me.PickAPot.Controls.Add(Me.btnPA)
        Me.PickAPot.Location = New System.Drawing.Point(6, 211)
        Me.PickAPot.Name = "PickAPot"
        Me.PickAPot.Size = New System.Drawing.Size(237, 91)
        Me.PickAPot.TabIndex = 2
        Me.PickAPot.Visible = False
        '
        'btnPC
        '
        Me.btnPC.Location = New System.Drawing.Point(159, 3)
        Me.btnPC.Name = "btnPC"
        Me.btnPC.Size = New System.Drawing.Size(75, 85)
        Me.btnPC.TabIndex = 13
        Me.btnPC.Text = "Pot C"
        Me.btnPC.UseVisualStyleBackColor = True
        '
        'btnPB
        '
        Me.btnPB.Location = New System.Drawing.Point(81, 3)
        Me.btnPB.Name = "btnPB"
        Me.btnPB.Size = New System.Drawing.Size(75, 85)
        Me.btnPB.TabIndex = 12
        Me.btnPB.Text = "Pot B"
        Me.btnPB.UseVisualStyleBackColor = True
        '
        'btnPA
        '
        Me.btnPA.Location = New System.Drawing.Point(3, 3)
        Me.btnPA.Name = "btnPA"
        Me.btnPA.Size = New System.Drawing.Size(75, 85)
        Me.btnPA.TabIndex = 11
        Me.btnPA.Text = "Pot A"
        Me.btnPA.UseVisualStyleBackColor = True
        '
        'ScratchTicket
        '
        Me.ScratchTicket.BackColor = System.Drawing.Color.White
        Me.ScratchTicket.Controls.Add(Me.btnC)
        Me.ScratchTicket.Controls.Add(Me.btnB)
        Me.ScratchTicket.Controls.Add(Me.btnA)
        Me.ScratchTicket.Location = New System.Drawing.Point(6, 115)
        Me.ScratchTicket.Name = "ScratchTicket"
        Me.ScratchTicket.Size = New System.Drawing.Size(237, 90)
        Me.ScratchTicket.TabIndex = 1
        Me.ScratchTicket.Visible = False
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.btnC.Location = New System.Drawing.Point(159, 2)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(75, 85)
        Me.btnC.TabIndex = 16
        Me.btnC.Text = "?"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.btnB.Location = New System.Drawing.Point(81, 3)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 85)
        Me.btnB.TabIndex = 15
        Me.btnB.Text = "?"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.btnA.Location = New System.Drawing.Point(3, 2)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 85)
        Me.btnA.TabIndex = 14
        Me.btnA.Text = "?"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'LottoTicket
        '
        Me.LottoTicket.BackColor = System.Drawing.Color.White
        Me.LottoTicket.Controls.Add(Me.btnCheck)
        Me.LottoTicket.Controls.Add(Me.txtC)
        Me.LottoTicket.Controls.Add(Me.txtB)
        Me.LottoTicket.Controls.Add(Me.txtA)
        Me.LottoTicket.Location = New System.Drawing.Point(6, 19)
        Me.LottoTicket.Name = "LottoTicket"
        Me.LottoTicket.Size = New System.Drawing.Size(237, 90)
        Me.LottoTicket.TabIndex = 0
        Me.LottoTicket.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(3, 64)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(231, 23)
        Me.btnCheck.TabIndex = 11
        Me.btnCheck.Text = "Check Ticket"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(183, 9)
        Me.txtC.Mask = "0"
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(36, 49)
        Me.txtC.TabIndex = 13
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(100, 9)
        Me.txtB.Mask = "0"
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(36, 49)
        Me.txtB.TabIndex = 12
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(20, 9)
        Me.txtA.Mask = "0"
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(36, 49)
        Me.txtA.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Correct Lotto Answers"
        '
        'pnlLottoAnswers
        '
        Me.pnlLottoAnswers.Controls.Add(Me.pnlLottoAnswers2)
        Me.pnlLottoAnswers.Controls.Add(Me.Label1)
        Me.pnlLottoAnswers.Location = New System.Drawing.Point(12, 228)
        Me.pnlLottoAnswers.Name = "pnlLottoAnswers"
        Me.pnlLottoAnswers.Size = New System.Drawing.Size(165, 147)
        Me.pnlLottoAnswers.TabIndex = 12
        Me.pnlLottoAnswers.Visible = False
        '
        'pnlLottoAnswers2
        '
        Me.pnlLottoAnswers2.Controls.Add(Me.lbA)
        Me.pnlLottoAnswers2.Controls.Add(Me.lbGuess)
        Me.pnlLottoAnswers2.Controls.Add(Me.lbB)
        Me.pnlLottoAnswers2.Controls.Add(Me.Label6)
        Me.pnlLottoAnswers2.Controls.Add(Me.lbC)
        Me.pnlLottoAnswers2.Location = New System.Drawing.Point(3, 22)
        Me.pnlLottoAnswers2.Name = "pnlLottoAnswers2"
        Me.pnlLottoAnswers2.Size = New System.Drawing.Size(159, 122)
        Me.pnlLottoAnswers2.TabIndex = 16
        Me.pnlLottoAnswers2.Visible = False
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Location = New System.Drawing.Point(3, 0)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(17, 13)
        Me.lbA.TabIndex = 10
        Me.lbA.Text = "A:"
        '
        'lbGuess
        '
        Me.lbGuess.AutoSize = True
        Me.lbGuess.Location = New System.Drawing.Point(3, 75)
        Me.lbGuess.Name = "lbGuess"
        Me.lbGuess.Size = New System.Drawing.Size(40, 13)
        Me.lbGuess.TabIndex = 15
        Me.lbGuess.Text = "Guess:"
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Location = New System.Drawing.Point(3, 19)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(17, 13)
        Me.lbB.TabIndex = 12
        Me.lbB.Text = "B:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Your Guess"
        '
        'lbC
        '
        Me.lbC.AutoSize = True
        Me.lbC.Location = New System.Drawing.Point(3, 37)
        Me.lbC.Name = "lbC"
        Me.lbC.Size = New System.Drawing.Size(17, 13)
        Me.lbC.TabIndex = 13
        Me.lbC.Text = "C:"
        '
        'LottoShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 387)
        Me.Controls.Add(Me.pnlLottoAnswers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LottoShop"
        Me.Text = "Lottery Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.PickAPot.ResumeLayout(False)
        Me.ScratchTicket.ResumeLayout(False)
        Me.LottoTicket.ResumeLayout(False)
        Me.LottoTicket.PerformLayout()
        Me.pnlLottoAnswers.ResumeLayout(False)
        Me.pnlLottoAnswers.PerformLayout()
        Me.pnlLottoAnswers2.ResumeLayout(False)
        Me.pnlLottoAnswers2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPAP As Button
    Friend WithEvents btnLT As Button
    Friend WithEvents btnST As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PickAPot As Panel
    Friend WithEvents ScratchTicket As Panel
    Friend WithEvents LottoTicket As Panel
    Friend WithEvents btnPC As Button
    Friend WithEvents btnPB As Button
    Friend WithEvents btnPA As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents txtC As MaskedTextBox
    Friend WithEvents txtB As MaskedTextBox
    Friend WithEvents txtA As MaskedTextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlLottoAnswers As Panel
    Friend WithEvents lbC As Label
    Friend WithEvents lbB As Label
    Friend WithEvents lbA As Label
    Friend WithEvents lbGuess As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlLottoAnswers2 As Panel
End Class
