Imports HynrFramework

Public Class ProjectDataClass
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
    Public Property Name As String
    Public Property UserID As Integer
End Class
