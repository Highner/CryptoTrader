Public Class ProjectManagerForm

#Region "Properties"
    Private Property ViewModel As ProjectManagerMainViewModel

#End Region

#Region "Methods"
    Private Sub ProjectManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewModel = New ProjectManagerMainViewModel
        UserGrid.BindToListViewModel(ViewModel.Users)
        ProjectGrid.BindToListViewModel(ViewModel.Projects)
        SaveButton.BindToViewModel(ViewModel.Projects, ViewModel.Projects.UpdateAllCommand, "Save")
        AddProjectButton.BindToViewModel(ViewModel.Projects, ViewModel.Projects.CreateCommand, "Add new project")
        DeleteProjectButton.BindToViewModel(ViewModel.Projects, ViewModel.Projects.DeleteSelectedItemsCommand, "Delete projects")
        OpenProjectButton.BindToViewModel(ViewModel.Projects, ViewModel.Projects.OpenNewFormCommand, "Open project")
    End Sub
#End Region

#Region "Buttons"

#End Region

End Class