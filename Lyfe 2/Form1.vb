Public Class Form1

    Dim MyShop As New ShopForm()
    Dim MyGame As New Game()
    Dim MyLotto As New LottoShop()
    Dim MyStocks As New Stocks()
    Dim Energy As Integer


    Function UpdateStats()

        lbMoney.Text = "Money: " & MyGame.Money

        lbEnergy.Text = "Energy: " & Energy

        lbMaxEn.Text = "Max Energy: " & MyGame.MaxEnergy

        lbBBerries.Text = "Blueberries: " & MyGame.BBerries

        lbApples.Text = "Apples: " & MyGame.Apples

        lbBananas.Text = "Bananas: " & MyGame.Bananas

        progMaxEn.Maximum = MyGame.MaxEnergy

        progMaxEn.Value = Energy

        If Energy = 10 Then

            progMaxEn.ForeColor = Color.Yellow

        End If

    End Function
    Function EndGame()

        MessageBox.Show("Congratulations! You beat the game. Your score is " & (MyGame.Money * 3 + MyGame.MaxEnergy * 2) - 30, "~~~ THE END ~~~")

        Close()

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("The object of this game is to make as much money as possible within 30 days. To do this, you may invest in the stock market, gamble, or simply go to work. Some of these methods of making money come at their own risks. So be aware!", "Lyfe Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click

        MyShop.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyGame.DayNumber = 1
        MyStocks.MyGame = MyGame

        MyLotto.MyGame = MyGame

        MyShop.MyGame = MyGame

        MyGame.PriceBlueberry = 5
        MyGame.PriceApple = 10
        MyGame.PriceBanana = 15
        MyGame.MainForm = Me
        MyGame.ShopForm = MyShop
        Randomize()
        lbDay.Text = "Day Number: " & MyGame.DayNumber
        Energy = 15

        UpdateStats()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        MyStocks.CalculateStocks()
        MyGame.DayNumber = MyGame.DayNumber + 1
        lbDay.Text = "Day Number: " & MyGame.DayNumber

        MyShop.UpdatePrices()
        If MyGame.DayNumber = 30 Then
            EndGame()
        End If

        Energy = MyGame.MaxEnergy

        UpdateStats()

    End Sub

    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click

        If Energy > 0 Then

            Energy = Energy - 5
            MyGame.Money = MyGame.Money + 10

        ElseIf Energy <= 0 Then

            MessageBox.Show("You are too fatigued to work!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

        UpdateStats()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MyShop.IDefinitelyWantToClose = True

        MyLotto.IDefinitelyWantToClose = True

        Application.Exit()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnLottoShop.Click

        MyLotto.Show()

    End Sub

End Class
