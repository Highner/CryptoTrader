Imports HynrFramework

Public Class Project
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return ProjectID
        End Get
        Set(value As Object)
            ProjectID = value
        End Set
    End Property

    Public Property ProjectID As Integer
    Public Property UserID As Integer
    Public Property User As User
    Public Property Name As String

    Public Property MarketDataSources As ICollection(Of MarketDataSource) = New HashSet(Of MarketDataSource)
End Class