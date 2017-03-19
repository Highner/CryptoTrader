Imports HynrFramework

Public Class MarketConnectionUserManagerListViewModel
    Inherits ListViewModelBase(Of MarketConnection, MarketConnectionDataClass, UserManagerMarketConnectionDataController, MarketConnectionUserManagerItemViewModel)

    Public Overrides Sub CreateNewItem()
        _DataController.CreateNewItem(CreateMarketConnection(UserID, MarketID))
        GetData()
    End Sub

    Public Sub New(ByVal userid As Integer, ByVal marketid As Integer)
        Me.UserID = userid
        Me.MarketID = marketid
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

    Private _MarketID As Integer
    Public Property MarketID As Integer
        Get
            Return _MarketID
        End Get
        Set(value As Integer)
            _MarketID = value
            _DataController.MarketID = value
        End Set
    End Property
End Class