Public Class Stocks
    Public MyGame As Game

    Dim rnd As New Random()

    Function CalculateStocks()

        'Calculate Blueberry
        MyGame.PriceBlueberry = MyGame.PriceBlueberry + rnd.Next(-3, 3)

        If MyGame.PriceBlueberry < 2 Then
            MyGame.PriceBlueberry = 2
        End If

        'Calculate Apple
        MyGame.PriceApple = MyGame.PriceApple + rnd.Next(-2, 4)

        If MyGame.PriceApple < 2 Then
            MyGame.PriceApple = 2
        End If

        'Calculate Banana
        MyGame.PriceBanana = MyGame.PriceBanana + rnd.Next(-3, 5)

        If MyGame.PriceBanana < 2 Then
            MyGame.PriceBanana = 2
        End If

    End Function

End Class
