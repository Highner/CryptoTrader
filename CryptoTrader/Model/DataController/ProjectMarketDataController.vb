Imports CryptoTrader

Public Class ProjectMarketDataController
    Inherits DataControllerBase(Of Market, MarketDataClass, MarketDataContext)

    Public Sub New(ByVal userid As Integer)
        Me.UserID = userid
    End Sub

    Public Sub New()
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of MarketDataClass)
        Dim items = GetItems("MarketConnections.Any(User.UserID = " & UserID & ")")
        Return items
    End Function

    Public Property UserID As Integer

    Public Overrides Function ToData(entityitem As Market) As MarketDataClass
        Dim item = MyBase.ToData(entityitem)
        item.CurrentUserID = UserID
        Return item
    End Function
End Class