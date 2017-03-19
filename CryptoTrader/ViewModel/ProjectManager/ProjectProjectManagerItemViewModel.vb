Imports HynrFramework

<Serializable>
Public Class ProjectProjectManagerItemViewModel
    Inherits ItemViewModelBase(Of ProjectDataClass)

    Public Property Name As String
        Get
            Return Data.Name
        End Get
        Set(value As String)
            Data.Name = value
        End Set
    End Property
End Class
