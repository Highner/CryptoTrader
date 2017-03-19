Imports HynrFramework

Public Class ChartEvent
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return ChartEventID
        End Get
        Set(value As Object)
            ChartEventID = value
        End Set
    End Property

    Public Property ChartEventID As Integer
    Public Property Charts As ICollection(Of DataSeries) = New HashSet(Of DataSeries)
End Class
