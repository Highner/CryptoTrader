Public Class ProjectForm


#Region "Properties"
    Private _ProjectData As ProjectDataClass
    Private Property ViewModel As ProjectMainViewModel
    Private MarketWindow As MarketDetailPanel
#End Region

#Region "Methods"
    Public Sub New(ByVal projectdata As ProjectDataClass)
        InitializeComponent()
        _ProjectData = projectdata
    End Sub
    Private Sub ProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ViewModel = New ProjectMainViewModel(_ProjectData)
        DataBindings.Add("Text", ViewModel, "ProjectName")
        MarketGrid1.BindToListViewModel(ViewModel.Markets)
        'MarketWindow = New MarketDetailPanel()

        ' MarketWindow.MarketGrid.BindToListViewModel(ViewModel.Markets)
        ' MarketWindow.Show(DockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom)
        'ViewModel.GetData()
    End Sub

    Private Sub HynrToolStripButton1_Click(sender As Object, e As EventArgs) Handles HynrToolStripButton1.Click

    End Sub



#End Region

#Region "Buttons"


#End Region

#Region "Events"

#End Region

End Class