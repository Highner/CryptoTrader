Imports HynrFramework

Public Class UserManagerMarketConnectionDataController
    Inherits DataControllerBase(Of MarketConnection, MarketConnectionDataClass, UserManagerMarketConnectionDataContext)

    Public Sub New(ByVal marketid As Integer, userid As Integer)
        Me.UserID = userid
        Me.MarketID = marketid
    End Sub

    Public Sub New()
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of MarketConnectionDataClass)
        Dim items = GetItems("UserID = " & UserID & " and MarketID = " & MarketID)
        Return items
    End Function

    Public Property UserID As Integer
    Public Property MarketID As Integer
End Class
