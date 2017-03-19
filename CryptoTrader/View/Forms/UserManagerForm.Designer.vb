<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagerForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagerForm))
        Me.ToolStrip = New HynrFramework.HynrToolStrip()
        Me.SaveAllButton = New HynrFramework.HynrToolStripButton()
        Me.RefreshButton = New HynrFramework.HynrToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddUserButton = New HynrFramework.HynrToolStripButton()
        Me.DeleteUserButton = New HynrFramework.HynrToolStripButton()
        Me.LabelStrip = New HynrFramework.HynrLabelStrip()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerMarkets = New System.Windows.Forms.SplitContainer()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddConnectionButton = New HynrFramework.HynrToolStripButton()
        Me.DeleteConnectionButton = New HynrFramework.HynrToolStripButton()
        Me.UserUserManagerGrid = New CryptoTrader.UserGrid()
        Me.MarketGrid = New CryptoTrader.MarketGrid()
        Me.MarketConnectionGrid = New CryptoTrader.MarketConnectionGrid()
        Me.ToolStrip.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.SplitContainerMarkets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMarkets.Panel1.SuspendLayout()
        Me.SplitContainerMarkets.Panel2.SuspendLayout()
        Me.SplitContainerMarkets.SuspendLayout()
        CType(Me.UserUserManagerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketConnectionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.HynrSettings = Nothing
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAllButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.AddUserButton, Me.DeleteUserButton, Me.ToolStripSeparator2, Me.AddConnectionButton, Me.DeleteConnectionButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "HynrToolStrip1"
        '
        'SaveAllButton
        '
        Me.SaveAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAllButton.Image = CType(resources.GetObject("SaveAllButton.Image"), System.Drawing.Image)
        Me.SaveAllButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAllButton.IsBusy = False
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveAllButton.Text = "HynrToolStripButton1"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.IsBusy = False
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshButton.Text = "HynrToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddUserButton
        '
        Me.AddUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddUserButton.Image = CType(resources.GetObject("AddUserButton.Image"), System.Drawing.Image)
        Me.AddUserButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddUserButton.IsBusy = False
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(23, 22)
        Me.AddUserButton.Text = "HynrToolStripButton1"
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteUserButton.Image = CType(resources.GetObject("DeleteUserButton.Image"), System.Drawing.Image)
        Me.DeleteUserButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteUserButton.IsBusy = False
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteUserButton.Text = "HynrToolStripButton2"
        '
        'LabelStrip
        '
        Me.LabelStrip.HynrSettings = Nothing
        Me.LabelStrip.LabelText = ""
        Me.LabelStrip.Location = New System.Drawing.Point(0, 25)
        Me.LabelStrip.Name = "LabelStrip"
        Me.LabelStrip.Size = New System.Drawing.Size(792, 25)
        Me.LabelStrip.TabIndex = 1
        Me.LabelStrip.Text = "HynrLabelStrip1"
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.UserUserManagerGrid)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.SplitContainerMarkets)
        Me.SplitContainer.Size = New System.Drawing.Size(792, 278)
        Me.SplitContainer.SplitterDistance = 188
        Me.SplitContainer.TabIndex = 2
        '
        'SplitContainerMarkets
        '
        Me.SplitContainerMarkets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMarkets.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerMarkets.Name = "SplitContainerMarkets"
        '
        'SplitContainerMarkets.Panel1
        '
        Me.SplitContainerMarkets.Panel1.Controls.Add(Me.MarketGrid)
        '
        'SplitContainerMarkets.Panel2
        '
        Me.SplitContainerMarkets.Panel2.Controls.Add(Me.MarketConnectionGrid)
        Me.SplitContainerMarkets.Size = New System.Drawing.Size(600, 278)
        Me.SplitContainerMarkets.SplitterDistance = 267
        Me.SplitContainerMarkets.TabIndex = 0
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AddConnectionButton
        '
        Me.AddConnectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddConnectionButton.Image = CType(resources.GetObject("AddConnectionButton.Image"), System.Drawing.Image)
        Me.AddConnectionButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddConnectionButton.IsBusy = False
        Me.AddConnectionButton.Name = "AddConnectionButton"
        Me.AddConnectionButton.Size = New System.Drawing.Size(23, 22)
        Me.AddConnectionButton.Text = "HynrToolStripButton1"
        '
        'DeleteConnectionButton
        '
        Me.DeleteConnectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteConnectionButton.Image = CType(resources.GetObject("DeleteConnectionButton.Image"), System.Drawing.Image)
        Me.DeleteConnectionButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteConnectionButton.IsBusy = False
        Me.DeleteConnectionButton.Name = "DeleteConnectionButton"
        Me.DeleteConnectionButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteConnectionButton.Text = "HynrToolStripButton2"
        '
        'UserUserManagerGrid
        '
        Me.UserUserManagerGrid.AllowUserToAddRows = False
        Me.UserUserManagerGrid.AllowUserToDeleteRows = False
        Me.UserUserManagerGrid.BindingSourceDataSource = Nothing
        Me.UserUserManagerGrid.CancellationSource = Nothing
        Me.UserUserManagerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserUserManagerGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserUserManagerGrid.FireItemDoubleClick = False
        Me.UserUserManagerGrid.HynrSettings = Nothing
        Me.UserUserManagerGrid.IsBusy = False
        Me.UserUserManagerGrid.Location = New System.Drawing.Point(0, 0)
        Me.UserUserManagerGrid.Name = "UserUserManagerGrid"
        Me.UserUserManagerGrid.SelectedItem = Nothing
        Me.UserUserManagerGrid.SelectedItems = Nothing
        Me.UserUserManagerGrid.Size = New System.Drawing.Size(188, 278)
        Me.UserUserManagerGrid.TabIndex = 0
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
        Me.MarketGrid.SelectedItem = Nothing
        Me.MarketGrid.SelectedItems = Nothing
        Me.MarketGrid.Size = New System.Drawing.Size(267, 278)
        Me.MarketGrid.TabIndex = 0
        '
        'MarketConnectionGrid
        '
        Me.MarketConnectionGrid.AllowUserToAddRows = False
        Me.MarketConnectionGrid.AllowUserToDeleteRows = False
        Me.MarketConnectionGrid.BindingSourceDataSource = Nothing
        Me.MarketConnectionGrid.CancellationSource = Nothing
        Me.MarketConnectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarketConnectionGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MarketConnectionGrid.FireItemDoubleClick = False
        Me.MarketConnectionGrid.HynrSettings = Nothing
        Me.MarketConnectionGrid.IsBusy = False
        Me.MarketConnectionGrid.Location = New System.Drawing.Point(0, 0)
        Me.MarketConnectionGrid.Name = "MarketConnectionGrid"
        Me.MarketConnectionGrid.SelectedItem = Nothing
        Me.MarketConnectionGrid.SelectedItems = Nothing
        Me.MarketConnectionGrid.Size = New System.Drawing.Size(329, 278)
        Me.MarketConnectionGrid.TabIndex = 0
        '
        'UserManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 328)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.LabelStrip)
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "UserManagerForm"
        Me.Text = "Users"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.SplitContainerMarkets.Panel1.ResumeLayout(False)
        Me.SplitContainerMarkets.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMarkets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMarkets.ResumeLayout(False)
        CType(Me.UserUserManagerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketConnectionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As HynrToolStrip
    Friend WithEvents LabelStrip As HynrLabelStrip
    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents UserUserManagerGrid As UserGrid
    Friend WithEvents AddUserButton As HynrToolStripButton
    Friend WithEvents DeleteUserButton As HynrToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveAllButton As HynrToolStripButton
    Friend WithEvents RefreshButton As HynrToolStripButton
    Friend WithEvents SplitContainerMarkets As SplitContainer
    Friend WithEvents MarketGrid As MarketGrid
    Friend WithEvents MarketConnectionGrid As MarketConnectionGrid
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AddConnectionButton As HynrToolStripButton
    Friend WithEvents DeleteConnectionButton As HynrToolStripButton
End Class
