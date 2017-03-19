Imports HynrFramework

Public Class MarketDataSource
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return MarketDataSourceID
        End Get
        Set(value As Object)
            MarketDataSourceID = value
        End Set
    End Property

    Public Property MarketDataSourceID As Integer
    Public Property ProjectID As Integer
    Public Property Project As Project
    Public Property MarketID As Integer
    Public Property Market As Market

    Public Property DataSeries As ICollection(Of DataSeries) = New HashSet(Of DataSeries)
End Class