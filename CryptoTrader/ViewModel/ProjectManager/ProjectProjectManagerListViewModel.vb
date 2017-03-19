Imports HynrFramework

Public Class ProjectProjectManagerListViewModel
    Inherits ListViewModelBase(Of Project, ProjectDataClass, ProjectManagerProjectDataController, ProjectProjectManagerItemViewModel)

    Public Overrides Sub CreateNewItem()
        _DataController.CreateNewItem(CreateProject(UserID))
        GetData()
    End Sub

    Protected Overrides Sub OpenNewForm()
        If Not IsNothing(SelectedItem) Then
            Dim project As New ProjectForm(SelectedItem.Data)
            project.Show()
        Else
            MsgBox("No project selected")
        End If
    End Sub

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
