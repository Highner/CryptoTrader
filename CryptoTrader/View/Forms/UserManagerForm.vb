Public Class UserManagerForm
#Region "Properties"
    Private ViewModel As UserManagerMainViewModel
#End Region

#Region "Methods"
    Private Sub UserManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewModel = New UserManagerMainViewModel
        UserUserManagerGrid.BindToListViewModel(ViewModel.Users)
        MarketGrid.BindToListViewModel(ViewModel.Markets)
        MarketConnectionGrid.BindToListViewModel(ViewModel.Connections)
        AddUserButton.BindToViewModel(ViewModel.Users, ViewModel.Users.CreateCommand, "Add user")
        DeleteUserButton.BindToViewModel(ViewModel.Users, ViewModel.Users.DeleteSelectedItemsCommand, "Delete selected users")
        SaveAllButton.BindToViewModel(ViewModel, ViewModel.SaveAllCommand, "Save")
        RefreshButton.BindToViewModel(ViewModel, ViewModel.RefreshDataCommand, "Refresh")
        AddConnectionButton.BindToViewModel(ViewModel.Connections, ViewModel.Connections.CreateCommand, "Add connection details")
        DeleteConnectionButton.BindToViewModel(ViewModel.Connections, ViewModel.Connections.DeleteSelectedItemsCommand, "Delete selected connection details")
        LabelStrip.BindToListViewModel(ViewModel.Users, "Header")
    End Sub


#End Region

#Region "Events"

#End Region

End Class