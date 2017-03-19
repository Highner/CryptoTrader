Imports HynrFramework

Public Class UserListViewModel
    Inherits ListViewModelBase(Of User, UserDataClass, UserManagerUserDataController, UserItemViewModel)

    Public Overrides Sub CreateNewItem()
        _DataController.CreateNewItem(CreateUserManagerUser)
        GetData()
    End Sub

    Public ReadOnly Property Header As String
        Get
            If Not IsNothing(SelectedItem) Then
                Return "Selected user: " + SelectedItem.Name
            Else
                Return "No user selected"
            End If
        End Get
    End Property
End Class
