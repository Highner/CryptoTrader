Imports HynrFramework

Public Class MarketConnectionDataClass
    Implements IHasID

    Public Property ID As Object Implements IHasID.ID

    Public Property APIKey As String
    Public Property APISecret As String
    Public Property Name As String
    Public Property UserID As Integer
    Public Property MarketID As Integer
End Class