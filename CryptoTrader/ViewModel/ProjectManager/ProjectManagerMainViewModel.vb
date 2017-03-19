Imports HynrFramework

Public Class ProjectManagerMainViewModel
    Inherits ViewModelBase

#Region "Properties"
    Public WithEvents Users As New UserListViewModel
    Public WithEvents Projects As New ProjectProjectManagerListViewModel(0)
#End Region

#Region "Methods"
    Public Sub New()
        getdata
    End Sub
    Private Sub GetData()
        Users.GetData()
    End Sub
    Private Sub UserSelected() Handles Users.SelectedItemChanged
        Projects.UserID = Users.SelectedItemID
        Projects.GetData()
    End Sub
#End Region

#Region "Events"

#End Region
End Class
