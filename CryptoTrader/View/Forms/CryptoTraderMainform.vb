Public Class CryptoTraderMainform

#Region "Properties"
    Private Settings As New HynrUISettings
#End Region

#Region "Methods"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Settings.ApplyToControlContainer(Me)

    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        Dim usermanagerform As New UserManagerForm
        usermanagerform.Show()
    End Sub

    Private Sub ProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectsToolStripMenuItem.Click
        Dim projectmanagerform As New ProjectManagerForm
        projectmanagerform.Show()
    End Sub
#End Region

#Region "ButtonClicks"

#End Region

End Class
