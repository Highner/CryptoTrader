Imports HynrFramework

Public Class MarketUserManagerListViewModel
    Inherits ListViewModelBase(Of Market, MarketDataClass, UserManagerMarketDataController, MarketUserManagerItemViewModel)

    Public Overrides Sub CreateNewItem()
        _DataController.CreateNewItem(CreateMarket)
        GetData()
    End Sub
End Class
