Public Class ShopForm

    Dim TotalPrice As Integer
    Public MyGame As Game

    Public IDefinitelyWantToClose As Boolean = False



    Function UpdatePrices()

        lbApple.Text = "Apple: " & MyGame.PriceApple
        lbBBerry.Text = "Blueberry: " & MyGame.PriceBlueberry
        lbBanana.Text = "Banana: " & MyGame.PriceBanana

        lstFluc.Items.Add("Day: " & MyGame.DayNumber)
        lstFluc.Items.Add("Blueberry: " & MyGame.PriceBlueberry)
        lstFluc.Items.Add("Apple: " & MyGame.PriceApple)
        lstFluc.Items.Add("Banana: " & MyGame.PriceBanana)
        lstFluc.Items.Add("---------")

    End Function

    Function BuyBlueberry()

        If MyGame.Money >= MyGame.PriceBlueberry Then

            MyGame.Money = MyGame.Money - MyGame.PriceBlueberry

            MyGame.BBerries = MyGame.BBerries + 1

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You don't have enough money!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Function

    Function BuyApple()

        If MyGame.Money >= MyGame.PriceApple Then

            MyGame.Money = MyGame.Money - MyGame.PriceApple

            MyGame.Apples = MyGame.Apples + 1

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You don't have enough money!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Function

    Function BuyBanana()

        If MyGame.Money >= MyGame.PriceBanana Then

            MyGame.Money = MyGame.Money - MyGame.PriceBanana

            MyGame.Bananas = MyGame.Bananas + 1

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You don't have enough money!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Function

    Function SellBlueberry()

        If MyGame.BBerries > 0 Then

            MyGame.Money = MyGame.Money + (MyGame.PriceBlueberry - 1)

            MyGame.BBerries = MyGame.BBerries - 1

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You have no blueberries to sell!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Function

    Function SellApple()

        If MyGame.Apples > 0 Then

            MyGame.Money = MyGame.Money + (MyGame.PriceApple - 1)

            MyGame.Apples = MyGame.Apples - 1

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You have no apples to sell!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Function

    Function SellBanana()

        If MyGame.Bananas > 0 Then

            MyGame.Money = MyGame.Money + (MyGame.PriceBanana - 1)

            MyGame.Bananas = MyGame.Bananas - 1

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You have no bananas to sell!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExitShop.Click

        Hide()

    End Sub

    Private Sub ShopForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Hide()
        If Not IDefinitelyWantToClose Then
            e.Cancel = True

        End If

    End Sub

    Private Sub ShopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lbTotal.Text = MyGame.DayNumber
        UpdatePrices()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuyBanana.Click

        BuyBanana()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBBerry.Click


        BuyBlueberry()

    End Sub

    Private Sub btnBuyApple_Click(sender As Object, e As EventArgs) Handles btnBuyApple.Click

        BuyApple()

    End Sub

    Private Sub btnSellBBerry_Click(sender As Object, e As EventArgs) Handles btnSellBBerry.Click

        SellBlueberry()

    End Sub

    Private Sub btnSellApple_Click(sender As Object, e As EventArgs) Handles btnSellApple.Click

        SellApple()

    End Sub

    Private Sub btnSellBanana_Click(sender As Object, e As EventArgs) Handles btnSellBanana.Click

        SellBanana()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If MyGame.Money >= 35 Then

            MyGame.Money = MyGame.Money - 35

            MyGame.MaxEnergy = MyGame.MaxEnergy + 5

            MyGame.MainForm.UpdateStats()

        Else

            MessageBox.Show("You don't have enough money!", "Uh-oh!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Sub
End Class