Module ProjectFactory
    Public Function CreateProject(ByVal userid As Integer) As ProjectDataClass
        Dim project As New ProjectDataClass
        project.UserID = userid
        project.Name = "New project"
        Return project
    End Function
End Module
