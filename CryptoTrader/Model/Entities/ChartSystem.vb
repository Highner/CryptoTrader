Imports HynrFramework

Public Class ChartSystem
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return ChartSystemID
        End Get
        Set(value As Object)
            ChartSystemID = value
        End Set
    End Property

    Public Property ChartSystemID As Integer

    Public Property Charts As ICollection(Of Chart) = New HashSet(Of Chart)
    Public Property Indicators As ICollection(Of Indicator) = New HashSet(Of Indicator)
End Class
