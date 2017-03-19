Public Class MarketDetailPanel
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Public WithEvents MarketGrid As MarketGrid
    Private components As System.ComponentModel.IContainer

#Region "Properties"

#End Region

#Region "Methods"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MarketGrid = New CryptoTrader.MarketGrid()
        CType(Me.MarketGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarketGrid
        '
        Me.MarketGrid.AllowUserToAddRows = False
        Me.MarketGrid.AllowUserToDeleteRows = False
        Me.MarketGrid.BindingSourceDataSource = Nothing
        Me.MarketGrid.CancellationSource = Nothing
        Me.MarketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarketGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MarketGrid.FireItemDoubleClick = False
        Me.MarketGrid.HynrSettings = Nothing
        Me.MarketGrid.IsBusy = False
        Me.MarketGrid.Location = New System.Drawing.Point(0, 0)
        Me.MarketGrid.Name = "MarketGrid"
        Me.MarketGrid.ReadOnly = True
        Me.MarketGrid.SelectedItem = Nothing
        Me.MarketGrid.SelectedItems = Nothing
        Me.MarketGrid.Size = New System.Drawing.Size(403, 350)
        Me.MarketGrid.TabIndex = 0
        '
        'MarketDetailPanel
        '
        Me.ClientSize = New System.Drawing.Size(403, 350)
        Me.Controls.Add(Me.MarketGrid)
        Me.HideOnClose = True
        Me.Name = "MarketDetailPanel"
        Me.Text = "Markets"
        CType(Me.MarketGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub MarketDetailPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class
