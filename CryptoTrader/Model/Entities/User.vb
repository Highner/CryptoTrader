Imports HynrFramework

Public Class User
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID
        Get
            Return UserID
        End Get
        Set(value As Object)
            UserID = value
        End Set
    End Property

    Public Property UserID As Integer
    Public Property Name As String
    Public Property Projects As ICollection(Of Project) = New HashSet(Of Project)
    Public Property MarketConnections As ICollection(Of MarketConnection) = New HashSet(Of MarketConnection)
End Class