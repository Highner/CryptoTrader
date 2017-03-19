Imports HynrFramework

<Serializable>
Public Class UserItemViewModel
    Inherits ItemViewModelBase(Of UserDataClass)

    Public Property Name As String
        Get
            Return Data.Name
        End Get
        Set(value As String)
            Data.Name = value
        End Set
    End Property
End Class
