Imports HynrFramework

Public Class Chart
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return ChartID
        End Get
        Set(value As Object)
            ChartID = value
        End Set
    End Property

    Public Property ChartID As Integer
    Public Property ChartSystemID As Integer
    Public Property ChartSystem As ChartSystem
    Public Property ChartEventID As Integer
    Public Property ChartEvent As ChartEvent
End Class
