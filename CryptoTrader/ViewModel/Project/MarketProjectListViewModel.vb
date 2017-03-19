Imports HynrFramework

Public Class MarketProjectListViewModel
    Inherits ListViewModelBase(Of Market, MarketDataClass, ProjectMarketDataController, MarketProjectListViewItem)

    Public Sub New(ByVal userid As Integer)
        Me.UserID = userid
    End Sub

    Private _UserID As Integer
    Public Property UserID As Integer
        Get
            Return _UserID
        End Get
        Set(value As Integer)
            _UserID = value
            _DataController.UserID = value
        End Set
    End Property
End Class
