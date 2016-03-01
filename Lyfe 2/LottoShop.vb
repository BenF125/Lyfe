Public Class LottoShop

    Public IDefinitelyWantToClose As Boolean = False
    Dim rnd As New Random()
    Dim SA, SB, SC, PA, PB, PC As Integer
    Dim Rand As Integer
    Public MyGame As Game

    Function PickAPrizeA()

        Rand = rnd.Next(1, 7)
        If Rand = 1 Then
            PA = 100
        ElseIf Rand = 2 Then
            PA = 50
        ElseIf Rand = 3 Then
            PA = 10
        ElseIf Rand = 4 Then
            PA = 0
        ElseIf Rand = 5 Then
            PA = 0
        ElseIf Rand = 6 Then
            PA = 0
        ElseIf Rand = 7 Then
            PA = 0
        End If

    End Function

    Function PickAPrizeB()

        Rand = rnd.Next(1, 5)
        If Rand = 1 Then
            PB = 100
        ElseIf Rand = 2 Then
            PB = 50
        ElseIf Rand = 3 Then
            PB = 10
        ElseIf Rand = 4 Then
            PB = 0
        ElseIf Rand = 5 Then
            PB = 0
        ElseIf Rand = 6 Then
            PB = 0
        ElseIf Rand = 7 Then
            PB = 0
        End If

    End Function

    Function PickAPrizeC()

        Rand = rnd.Next(1, 5)
        If Rand = 1 Then
            PC = 100
        ElseIf Rand = 2 Then
            PC = 50
        ElseIf Rand = 3 Then
            PC = 10
        ElseIf Rand = 4 Then
            PC = 0
        ElseIf Rand = 5 Then
            PC = 0
        ElseIf Rand = 6 Then
            PC = 0
        ElseIf Rand = 7 Then
            PC = 0
        End If

    End Function

    Private Sub LottoShop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Hide()
        If Not IDefinitelyWantToClose Then
            e.Cancel = True

        End If

    End Sub

    Private Sub btnLT_Click(sender As Object, e As EventArgs) Handles btnLT.Click

        PickAPot.Visible = False

        If MyGame.Money >= 2 Then

            btnPAP.Enabled = False
            btnLT.Enabled = False
            btnST.Enabled = False
            LottoTicket.Visible = True
        Else
            MessageBox.Show("Please come back when you have 2 or more money.", "Sorry", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If MyGame.Money < 2 Then
            MessageBox.Show("You don't have enough money to play. Come back when you have at least 5 money.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        ' Anything that happens after this, is guaranteed to be done by someone with at least $2
        MyGame.Money = MyGame.Money - 2

        Dim A, B, C As Integer
        A = rnd.Next(0, 9)
        B = rnd.Next(0, 9)
        C = rnd.Next(0, 9)

        If Val(txtA.Text = A And txtB.Text = B And txtC.Text = C) Then

            MessageBox.Show("Woah! You won the jackpot of 1000 money!!", "Wow!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            MyGame.Money = MyGame.Money + 1000

        ElseIf Val(txtA.Text = A And txtB.Text = B) Or Val(txtA.Text = A And txtC.Text = C) Or Val(txtB.Text = B And txtC.Text = C) Then

            MessageBox.Show("Nice job! You won 50 money!", "Good job!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            MyGame.Money = MyGame.Money + 50

        ElseIf Val(txtA.Text = A) Or Val(txtB.Text = B) Or Val(txtC.Text = C) Then

            MessageBox.Show("Nice! You won 10 money!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            MyGame.Money = MyGame.Money + 10

        ElseIf Not Val(txtA.Text = A And txtB.Text = B And txtC.Text = C) Then

            MessageBox.Show("Aw man, you didn't win any money", "Better luck next time!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        pnlLottoAnswers.Visible = True
        pnlLottoAnswers2.Visible = True

        lbA.Text = "A: " & A
        lbB.Text = "B: " & B
        lbC.Text = "C: " & C

        btnPAP.Enabled = True
        btnLT.Enabled = True
        btnST.Enabled = True

        LottoTicket.Visible = False

        lbGuess.Text = "Guess: " & txtA.Text & txtB.Text & txtC.Text

        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
    End Sub



    Private Sub btnST_Click(sender As Object, e As EventArgs) Handles btnST.Click

        PickAPot.Visible = False

        pnlLottoAnswers.Visible = False
        pnlLottoAnswers2.Visible = False

        If MyGame.Money >= 3 Then

            MyGame.Money = MyGame.Money - 3

            btnPAP.Enabled = False
            btnLT.Enabled = False
            btnST.Enabled = False

            btnA.Enabled = True
            btnB.Enabled = False
            btnC.Enabled = False

            ScratchTicket.Visible = True
        Else
            MessageBox.Show("Please come back when you have 3 or more money.", "Sorry", MessageBoxButtons.OK)
        End If

        MyGame.MainForm.UpdateStats()

    End Sub


    Private Sub LottoShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlLottoAnswers.Visible = False
        pnlLottoAnswers2.Visible = False

    End Sub

    Private Sub btnPA_Click(sender As Object, e As EventArgs) Handles btnPA.Click

        PickAPrizeA()

        btnPA.Text = PA

        PickAPrizeB()

        btnPB.Text = PB

        PickAPrizeC()

        btnPC.Text = PC

        btnPA.Enabled = False
        btnPB.Enabled = False
        btnPC.Enabled = False

        MessageBox.Show("You got " & PA & " money.", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MyGame.Money = MyGame.Money + PA

        btnLT.Enabled = True
        btnST.Enabled = True
        btnPAP.Enabled = True

        MyGame.MainForm.UpdateStats()

    End Sub

    Private Sub btnPB_Click(sender As Object, e As EventArgs) Handles btnPB.Click

        PickAPrizeA()

        btnPA.Text = PA

        PickAPrizeB()

        btnPB.Text = PB

        PickAPrizeC()

        btnPC.Text = PC

        btnPA.Enabled = False
        btnPB.Enabled = False
        btnPC.Enabled = False

        MessageBox.Show("You got " & PB & " money.", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MyGame.Money = MyGame.Money + PB

        btnLT.Enabled = True
        btnST.Enabled = True
        btnPAP.Enabled = True

        MyGame.MainForm.UpdateStats()

    End Sub

    Private Sub btnPC_Click(sender As Object, e As EventArgs) Handles btnPC.Click

        PickAPrizeA()

        btnPA.Text = PA

        PickAPrizeB()

        btnPB.Text = PB

        PickAPrizeC()

        btnPC.Text = PC

        btnPA.Enabled = False
        btnPB.Enabled = False
        btnPC.Enabled = False

        MessageBox.Show("You got " & PC & " money.", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MyGame.Money = MyGame.Money + PC

        btnLT.Enabled = True
        btnST.Enabled = True
        btnPAP.Enabled = True

        MyGame.MainForm.UpdateStats()

    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click

        SA = rnd.Next(1, 5)
        btnA.Text = SA
        btnB.Enabled = True
        btnA.Enabled = False
    End Sub

    Private Sub LotteryTicketText_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged, txtB.TextChanged, txtA.TextChanged
        btnCheck.Enabled = (txtC.Text <> "" And txtA.Text <> "" And txtB.Text <> "")
    End Sub

    Private Sub btnPAP_Click(sender As Object, e As EventArgs) Handles btnPAP.Click

        btnPA.Text = "Pot A"
        btnPB.Text = "Pot B"
        btnPC.Text = "Pot C"

        btnPA.Enabled = True
        btnPB.Enabled = True
        btnPC.Enabled = True

        If MyGame.Money < 5 Then
            MessageBox.Show("You don't have enough money to play. Come back when you have at least 5 money.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        btnLT.Enabled = False
        btnST.Enabled = False
        btnPAP.Enabled = False

        '~~HE DEFIANTLY HAS AT LEAST 5 DOLLARS BELOW THIS POINT~~

        MyGame.Money = MyGame.Money - 5

        PickAPot.Visible = True

        MyGame.MainForm.UpdateStats()

    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click

        SB = rnd.Next(1, 5)
        btnB.Text = SB
        btnC.Enabled = True
        btnB.Enabled = False

    End Sub
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        SC = rnd.Next(1, 5)
        btnC.Text = SC

        If (SA = SB) And (SB = SC) Then

            MessageBox.Show("It was a winner! You won 100 money.", "Jackpot!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            MyGame.Money = MyGame.Money + 100

        ElseIf SA = SB Or SA = SC Or SB = SC Then



            MessageBox.Show("It was a winner! You won a free ticket.", "Good job!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            MyGame.Money = MyGame.Money + 3

        Else

            MessageBox.Show("It wasn't a winner.", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

        MyGame.MainForm.UpdateStats()

        ScratchTicket.Visible = False

        pnlLottoAnswers.Visible = True

        Label1.Visible = True

        Label1.Text = "Your ticket: " & SA & SB & SC

        btnPAP.Enabled = True
        btnLT.Enabled = True
        btnST.Enabled = True

        btnA.Text = "?"
        btnB.Text = "?"
        btnC.Text = "?"

        btnC.Enabled = False

    End Sub

End Class