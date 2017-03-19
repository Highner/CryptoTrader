Module MarketConnectionFactory
    Public Function CreateMarketConnection(ByVal userid As Integer, ByVal marketid As Integer) As MarketConnectionDataClass
        Dim con As New MarketConnectionDataClass
        con.UserID = userid
        con.MarketID = marketid
        con.Name = "New connection"
        Return con
    End Function
End Module
