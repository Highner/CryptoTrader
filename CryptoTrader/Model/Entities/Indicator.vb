Imports HynrFramework

Public Class Indicator
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return IndicatorID
        End Get
        Set(value As Object)
            IndicatorID = value
        End Set
    End Property

    Public Property IndicatorID As Integer
    Public Property DataSeriesID As Integer
    Public Property DataSeries As DataSeries
    Public Property ChartSystemID As Integer
    Public Property ChartSystem As ChartSystem
End Class
