Imports HynrFramework

Public Class Market
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return MarketID
        End Get
        Set(value As Object)
            MarketID = value
        End Set
    End Property

    Public Property MarketID As Integer
    Public Property Name As String

    Public Property MarketConnections As ICollection(Of MarketConnection) = New HashSet(Of MarketConnection)
    Public Property MarketDataSources As ICollection(Of MarketDataSource) = New HashSet(Of MarketDataSource)
End Class
