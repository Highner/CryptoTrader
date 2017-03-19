Imports HynrFramework
Imports System.Windows.Input

Public Class UserManagerMainViewModel
    Inherits ViewModelBase

#Region "Properties"
    Public WithEvents Users As New UserListViewModel
    Public WithEvents Markets As New MarketUserManagerListViewModel
    Public WithEvents Connections As New MarketConnectionUserManagerListViewModel(0, 0)
#End Region

#Region "Commands"
    Public Property SaveAllCommand As ICommand = New Command(AddressOf SaveAll)
    Public Property RefreshDataCommand As ICommand = New Command(AddressOf GetData)
#End Region

#Region "Methods"
    Public Sub New()
        GetData()
    End Sub
    Private Sub ItemsSelected() Handles Users.SelectedItemChanged, Markets.SelectedItemChanged
        Connections.UserID = Users.SelectedItemID
        Connections.MarketID = Markets.SelectedItemID
            Connections.GetData()
    End Sub
    Private Sub GetData()
        Users.GetData()
        Markets.GetData()
    End Sub
    Private Sub SaveAll()
        Users.UpdateAllCommand.Execute(Nothing)
        Markets.UpdateAllCommand.Execute(Nothing)
        Connections.UpdateAllCommand.Execute(Nothing)
    End Sub
#End Region
End Class
