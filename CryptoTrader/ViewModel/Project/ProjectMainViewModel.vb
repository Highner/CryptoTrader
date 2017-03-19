Imports HynrFramework

Public Class ProjectMainViewModel
    Inherits ViewModelBase

#Region "Properties"
    Property _ProjectData As ProjectDataClass
    Property _UserID As Integer
    Public ReadOnly Property ProjectName As String
        Get
            Return _ProjectData.Name
        End Get
    End Property

    Public WithEvents Markets As MarketProjectListViewModel
#End Region

#Region "Methods"
    Public Sub New(ByVal projectdata As ProjectDataClass)
        _ProjectData = projectdata
        Markets = New MarketProjectListViewModel(_ProjectData.UserID)
        GetData()
    End Sub
    Public Sub GetData()
        Markets.GetData()
    End Sub
#End Region

#Region "Events"


#End Region
End Class
