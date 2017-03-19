<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectForm))
        Me.LabelStrip = New HynrFramework.HynrLabelStrip()
        Me.Toolstrip = New HynrFramework.HynrToolStrip()
        Me.HynrToolStripButton1 = New HynrFramework.HynrToolStripButton()
        Me.DockPanel = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.MarketGrid1 = New CryptoTrader.MarketGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toolstrip.SuspendLayout()
        CType(Me.MarketGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelStrip
        '
        Me.LabelStrip.HynrSettings = Nothing
        Me.LabelStrip.LabelText = ""
        Me.LabelStrip.Location = New System.Drawing.Point(0, 25)
        Me.LabelStrip.Name = "LabelStrip"
        Me.LabelStrip.Size = New System.Drawing.Size(1920, 25)
        Me.LabelStrip.TabIndex = 1
        Me.LabelStrip.Text = "HynrLabelStrip1"
        '
        'Toolstrip
        '
        Me.Toolstrip.HynrSettings = Nothing
        Me.Toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HynrToolStripButton1})
        Me.Toolstrip.Location = New System.Drawing.Point(0, 0)
        Me.Toolstrip.Name = "Toolstrip"
        Me.Toolstrip.Size = New System.Drawing.Size(1920, 25)
        Me.Toolstrip.TabIndex = 0
        Me.Toolstrip.Text = "HynrToolStrip1"
        '
        'HynrToolStripButton1
        '
        Me.HynrToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HynrToolStripButton1.Image = CType(resources.GetObject("HynrToolStripButton1.Image"), System.Drawing.Image)
        Me.HynrToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HynrToolStripButton1.IsBusy = False
        Me.HynrToolStripButton1.Name = "HynrToolStripButton1"
        Me.HynrToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.HynrToolStripButton1.Text = "HynrToolStripButton1"
        '
        'DockPanel
        '
        Me.DockPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockPanel.Location = New System.Drawing.Point(946, 50)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.Size = New System.Drawing.Size(974, 784)
        Me.DockPanel.TabIndex = 2
        '
        'MarketGrid1
        '
        Me.MarketGrid1.AllowUserToAddRows = False
        Me.MarketGrid1.AllowUserToDeleteRows = False
        Me.MarketGrid1.BindingSourceDataSource = Nothing
        Me.MarketGrid1.CancellationSource = Nothing
        Me.MarketGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarketGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.MarketGrid1.FireItemDoubleClick = False
        Me.MarketGrid1.HynrSettings = Nothing
        Me.MarketGrid1.IsBusy = False
        Me.MarketGrid1.Location = New System.Drawing.Point(158, 159)
        Me.MarketGrid1.Name = "MarketGrid1"
        Me.MarketGrid1.SelectedItem = Nothing
        Me.MarketGrid1.SelectedItems = CType(resources.GetObject("MarketGrid1.SelectedItems"), System.Collections.Generic.List(Of CryptoTrader.MarketUserManagerItemViewModel))
        Me.MarketGrid1.Size = New System.Drawing.Size(416, 387)
        Me.MarketGrid1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'ProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 834)
        Me.Controls.Add(Me.MarketGrid1)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.LabelStrip)
        Me.Controls.Add(Me.Toolstrip)
        Me.IsMdiContainer = True
        Me.Name = "ProjectForm"
        Me.Text = "ProjectForm"
        Me.Toolstrip.ResumeLayout(False)
        Me.Toolstrip.PerformLayout()
        CType(Me.MarketGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Toolstrip As HynrToolStrip
    Friend WithEvents LabelStrip As HynrLabelStrip
    Friend WithEvents HynrToolStripButton1 As HynrToolStripButton
    Friend WithEvents DockPanel As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents MarketGrid1 As MarketGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
