Imports HynrFramework

Public Class MarketConnection
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return MarketConnectionID
        End Get
        Set(value As Object)
            MarketConnectionID = value
        End Set
    End Property

    Public Property MarketConnectionID As Integer
    Public Property APIKey As String
    Public Property APISecret As String
    Public Property Name As String
    Public Property UserID As Integer
    Public Property User As User
    Public Property MarketID As Integer
    Public Property Market As Market
End Class
