Imports HynrFramework
Imports System.ComponentModel

<Serializable>
Public Class MarketConnectionUserManagerItemViewModel
    Inherits ItemViewModelBase(Of MarketConnectionDataClass)

    Public Property Name As String
        Get
            Return Data.Name
        End Get
        Set(value As String)
            Data.Name = value
        End Set
    End Property
    <DisplayName("API Key")>
    Public Property APIKey As String
        Get
            Return Data.APIKey
        End Get
        Set(value As String)
            Data.APIKey = value
        End Set
    End Property

    <DisplayName("API Secret")>
    Public Property APISecret As String
        Get
            Return Data.APISecret
        End Get
        Set(value As String)
            Data.APISecret = value
        End Set
    End Property
End Class
