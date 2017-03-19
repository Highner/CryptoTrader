Imports HynrFramework

Public Class ProjectManagerProjectDataController
    Inherits DataControllerBase(Of Project, ProjectDataClass, ProjectManagerProjectDataContext)

    Public Sub New(ByVal userid As Integer)
        Me.UserID = userid
    End Sub

    Public Sub New()
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of ProjectDataClass)
        Dim items = GetItems("UserID = " & UserID)
        Return items
    End Function

    Public Property UserID As Integer

End Class
