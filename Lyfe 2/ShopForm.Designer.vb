<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopForm
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
        Me.btnExitShop = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSellBanana = New System.Windows.Forms.Button()
        Me.btnSellBBerry = New System.Windows.Forms.Button()
        Me.btnSellApple = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnBuyBanana = New System.Windows.Forms.Button()
        Me.btnBBerry = New System.Windows.Forms.Button()
        Me.btnBuyApple = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbBanana = New System.Windows.Forms.Label()
        Me.lbApple = New System.Windows.Forms.Label()
        Me.lbBBerry = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstFluc = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Prices = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Prices.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExitShop
        '
        Me.btnExitShop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExitShop.Location = New System.Drawing.Point(388, 352)
        Me.btnExitShop.Name = "btnExitShop"
        Me.btnExitShop.Size = New System.Drawing.Size(75, 23)
        Me.btnExitShop.TabIndex = 0
        Me.btnExitShop.Text = "Exit shop"
        Me.btnExitShop.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnSellBanana)
        Me.GroupBox1.Controls.Add(Me.btnSellBBerry)
        Me.GroupBox1.Controls.Add(Me.btnSellApple)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnBuyBanana)
        Me.GroupBox1.Controls.Add(Me.btnBBerry)
        Me.GroupBox1.Controls.Add(Me.btnBuyApple)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 355)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase and Sell"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Buy (Other):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Buy:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Sell:"
        '
        'btnSellBanana
        '
        Me.btnSellBanana.Location = New System.Drawing.Point(6, 195)
        Me.btnSellBanana.Name = "btnSellBanana"
        Me.btnSellBanana.Size = New System.Drawing.Size(118, 23)
        Me.btnSellBanana.TabIndex = 12
        Me.btnSellBanana.Text = "Sell Banana"
        Me.btnSellBanana.UseVisualStyleBackColor = True
        '
        'btnSellBBerry
        '
        Me.btnSellBBerry.Location = New System.Drawing.Point(6, 137)
        Me.btnSellBBerry.Name = "btnSellBBerry"
        Me.btnSellBBerry.Size = New System.Drawing.Size(118, 23)
        Me.btnSellBBerry.TabIndex = 14
        Me.btnSellBBerry.Text = "Sell Blueberry"
        Me.btnSellBBerry.UseVisualStyleBackColor = True
        '
        'btnSellApple
        '
        Me.btnSellApple.Location = New System.Drawing.Point(6, 166)
        Me.btnSellApple.Name = "btnSellApple"
        Me.btnSellApple.Size = New System.Drawing.Size(118, 23)
        Me.btnSellApple.TabIndex = 11
        Me.btnSellApple.Text = "Sell Apple"
        Me.btnSellApple.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 242)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Purchase Energy+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnBuyBanana
        '
        Me.btnBuyBanana.Location = New System.Drawing.Point(6, 90)
        Me.btnBuyBanana.Name = "btnBuyBanana"
        Me.btnBuyBanana.Size = New System.Drawing.Size(118, 23)
        Me.btnBuyBanana.TabIndex = 4
        Me.btnBuyBanana.Text = "Purchase Banana"
        Me.btnBuyBanana.UseVisualStyleBackColor = True
        '
        'btnBBerry
        '
        Me.btnBBerry.Location = New System.Drawing.Point(6, 32)
        Me.btnBBerry.Name = "btnBBerry"
        Me.btnBBerry.Size = New System.Drawing.Size(118, 23)
        Me.btnBBerry.TabIndex = 6
        Me.btnBBerry.Text = "Purchase Blueberry"
        Me.btnBBerry.UseVisualStyleBackColor = True
        '
        'btnBuyApple
        '
        Me.btnBuyApple.Location = New System.Drawing.Point(6, 61)
        Me.btnBuyApple.Name = "btnBuyApple"
        Me.btnBuyApple.Size = New System.Drawing.Size(118, 23)
        Me.btnBuyApple.TabIndex = 3
        Me.btnBuyApple.Text = "Purchase Apple"
        Me.btnBuyApple.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Energy+: 35"
        '
        'lbBanana
        '
        Me.lbBanana.AutoSize = True
        Me.lbBanana.Location = New System.Drawing.Point(8, 85)
        Me.lbBanana.Name = "lbBanana"
        Me.lbBanana.Size = New System.Drawing.Size(47, 13)
        Me.lbBanana.TabIndex = 9
        Me.lbBanana.Text = "Banana:"
        '
        'lbApple
        '
        Me.lbApple.AutoSize = True
        Me.lbApple.Location = New System.Drawing.Point(6, 62)
        Me.lbApple.Name = "lbApple"
        Me.lbApple.Size = New System.Drawing.Size(37, 13)
        Me.lbApple.TabIndex = 8
        Me.lbApple.Text = "Apple:"
        '
        'lbBBerry
        '
        Me.lbBBerry.AutoSize = True
        Me.lbBBerry.Location = New System.Drawing.Point(6, 39)
        Me.lbBBerry.Name = "lbBBerry"
        Me.lbBBerry.Size = New System.Drawing.Size(54, 13)
        Me.lbBBerry.TabIndex = 7
        Me.lbBBerry.Text = "Blueberry:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prices:"
        '
        'lstFluc
        '
        Me.lstFluc.FormattingEnabled = True
        Me.lstFluc.Location = New System.Drawing.Point(148, 46)
        Me.lstFluc.Name = "lstFluc"
        Me.lstFluc.Size = New System.Drawing.Size(187, 225)
        Me.lstFluc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stock Market Fluctuation:"
        '
        'Prices
        '
        Me.Prices.Controls.Add(Me.Label2)
        Me.Prices.Controls.Add(Me.lbApple)
        Me.Prices.Controls.Add(Me.lbBBerry)
        Me.Prices.Controls.Add(Me.lbBanana)
        Me.Prices.Controls.Add(Me.Label7)
        Me.Prices.Location = New System.Drawing.Point(341, 49)
        Me.Prices.Name = "Prices"
        Me.Prices.Size = New System.Drawing.Size(122, 222)
        Me.Prices.TabIndex = 11
        Me.Prices.TabStop = False
        Me.Prices.Text = "Prices:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Items will be sold for a fee of 1 money*"
        '
        'ShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 387)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Prices)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstFluc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExitShop)
        Me.Name = "ShopForm"
        Me.Text = "Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Prices.ResumeLayout(False)
        Me.Prices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExitShop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBuyBanana As Button
    Friend WithEvents btnBuyApple As Button
    Friend WithEvents btnBBerry As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstFluc As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbBanana As Label
    Friend WithEvents lbApple As Label
    Friend WithEvents lbBBerry As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSellBanana As Button
    Friend WithEvents btnSellBBerry As Button
    Friend WithEvents btnSellApple As Button
    Friend WithEvents Prices As GroupBox
    Friend WithEvents Label4 As Label
End Class
