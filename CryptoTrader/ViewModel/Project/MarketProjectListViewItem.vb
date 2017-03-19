Imports HynrFramework

<Serializable>
Public Class MarketProjectListViewItem
    Inherits ItemViewModelBase(Of MarketDataClass)

    Public ReadOnly Property Name As String
        Get
            Return Data.Name
        End Get
    End Property
End Class
