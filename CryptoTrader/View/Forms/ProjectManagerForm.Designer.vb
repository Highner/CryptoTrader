<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectManagerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectManagerForm))
        Me.HynrToolStrip1 = New HynrFramework.HynrToolStrip()
        Me.SaveButton = New HynrFramework.HynrToolStripButton()
        Me.RefreshButton = New HynrFramework.HynrToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddProjectButton = New HynrFramework.HynrToolStripButton()
        Me.DeleteProjectButton = New HynrFramework.HynrToolStripButton()
        Me.OpenProjectButton = New HynrFramework.HynrToolStripButton()
        Me.HynrLabelStrip1 = New HynrFramework.HynrLabelStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UserGrid = New CryptoTrader.UserGrid()
        Me.ProjectGrid = New CryptoTrader.ProjectGrid()
        Me.HynrToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UserGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HynrToolStrip1
        '
        Me.HynrToolStrip1.HynrSettings = Nothing
        Me.HynrToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveButton, Me.RefreshButton, Me.ToolStripSeparator1, Me.AddProjectButton, Me.DeleteProjectButton, Me.OpenProjectButton})
        Me.HynrToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.HynrToolStrip1.Name = "HynrToolStrip1"
        Me.HynrToolStrip1.Size = New System.Drawing.Size(624, 25)
        Me.HynrToolStrip1.TabIndex = 0
        Me.HynrToolStrip1.Text = "HynrToolStrip1"
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.IsBusy = False
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveButton.Text = "HynrToolStripButton4"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.IsBusy = False
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshButton.Text = "HynrToolStripButton5"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddProjectButton
        '
        Me.AddProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddProjectButton.Image = CType(resources.GetObject("AddProjectButton.Image"), System.Drawing.Image)
        Me.AddProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddProjectButton.IsBusy = False
        Me.AddProjectButton.Name = "AddProjectButton"
        Me.AddProjectButton.Size = New System.Drawing.Size(23, 22)
        Me.AddProjectButton.Text = "HynrToolStripButton1"
        '
        'DeleteProjectButton
        '
        Me.DeleteProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteProjectButton.Image = CType(resources.GetObject("DeleteProjectButton.Image"), System.Drawing.Image)
        Me.DeleteProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteProjectButton.IsBusy = False
        Me.DeleteProjectButton.Name = "DeleteProjectButton"
        Me.DeleteProjectButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteProjectButton.Text = "HynrToolStripButton2"
        '
        'OpenProjectButton
        '
        Me.OpenProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenProjectButton.Image = CType(resources.GetObject("OpenProjectButton.Image"), System.Drawing.Image)
        Me.OpenProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenProjectButton.IsBusy = False
        Me.OpenProjectButton.Name = "OpenProjectButton"
        Me.OpenProjectButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenProjectButton.Text = "HynrToolStripButton3"
        '
        'HynrLabelStrip1
        '
        Me.HynrLabelStrip1.HynrSettings = Nothing
        Me.HynrLabelStrip1.LabelText = ""
        Me.HynrLabelStrip1.Location = New System.Drawing.Point(0, 25)
        Me.HynrLabelStrip1.Name = "HynrLabelStrip1"
        Me.HynrLabelStrip1.Size = New System.Drawing.Size(624, 25)
        Me.HynrLabelStrip1.TabIndex = 1
        Me.HynrLabelStrip1.Text = "HynrLabelStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UserGrid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProjectGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(624, 239)
        Me.SplitContainer1.SplitterDistance = 208
        Me.SplitContainer1.TabIndex = 2
        '
        'UserGrid
        '
        Me.UserGrid.AllowUserToAddRows = False
        Me.UserGrid.AllowUserToDeleteRows = False
        Me.UserGrid.BindingSourceDataSource = Nothing
        Me.UserGrid.CancellationSource = Nothing
        Me.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserGrid.FireItemDoubleClick = False
        Me.UserGrid.HynrSettings = Nothing
        Me.UserGrid.IsBusy = False
        Me.UserGrid.Location = New System.Drawing.Point(0, 0)
        Me.UserGrid.Name = "UserGrid"
        Me.UserGrid.ReadOnly = True
        Me.UserGrid.SelectedItem = Nothing
        Me.UserGrid.SelectedItems = Nothing
        Me.UserGrid.Size = New System.Drawing.Size(208, 239)
        Me.UserGrid.TabIndex = 0
        '
        'ProjectGrid
        '
        Me.ProjectGrid.AllowUserToAddRows = False
        Me.ProjectGrid.AllowUserToDeleteRows = False
        Me.ProjectGrid.BindingSourceDataSource = Nothing
        Me.ProjectGrid.CancellationSource = Nothing
        Me.ProjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProjectGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectGrid.FireItemDoubleClick = True
        Me.ProjectGrid.HynrSettings = Nothing
        Me.ProjectGrid.IsBusy = False
        Me.ProjectGrid.Location = New System.Drawing.Point(0, 0)
        Me.ProjectGrid.Name = "ProjectGrid"
        Me.ProjectGrid.SelectedItem = Nothing
        Me.ProjectGrid.SelectedItems = Nothing
        Me.ProjectGrid.Size = New System.Drawing.Size(412, 239)
        Me.ProjectGrid.TabIndex = 0
        '
        'ProjectManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 289)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.HynrLabelStrip1)
        Me.Controls.Add(Me.HynrToolStrip1)
        Me.Name = "ProjectManagerForm"
        Me.Text = "ProjectManagerForm"
        Me.HynrToolStrip1.ResumeLayout(False)
        Me.HynrToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UserGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HynrToolStrip1 As HynrToolStrip
    Friend WithEvents HynrLabelStrip1 As HynrLabelStrip
    Friend WithEvents SaveButton As HynrToolStripButton
    Friend WithEvents RefreshButton As HynrToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddProjectButton As HynrToolStripButton
    Friend WithEvents DeleteProjectButton As HynrToolStripButton
    Friend WithEvents OpenProjectButton As HynrToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents UserGrid As UserGrid
    Friend WithEvents ProjectGrid As ProjectGrid
End Class
