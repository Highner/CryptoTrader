Module UserFactory
    Public Function CreateUserManagerUser() As UserDataClass
        Dim userdata As New UserDataClass
        userdata.Name = "New user"
        Return userdata
    End Function
End Module
