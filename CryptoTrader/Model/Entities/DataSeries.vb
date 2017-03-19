Imports HynrFramework

Public Class DataSeries
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return DataSeriesID
        End Get
        Set(value As Object)
            DataSeriesID = value
        End Set
    End Property

    Public Property DataSeriesID As Integer
    Public Property MarketDataSourceID As Integer
    Public Property MarketDataSource As MarketDataSource

    Public Property Charts As ICollection(Of Chart) = New HashSet(Of Chart)
    Public Property Indicators As ICollection(Of Indicator) = New HashSet(Of Indicator)
End Class
