Public Module MarketFactory
    Public Function CreateMarket() As MarketDataClass
        Dim market As New MarketDataClass
        market.Name = "New market"
        Return market
    End Function
End Module
