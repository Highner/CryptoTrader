Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class entitiesupdatetoincludeIDs
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Charts", "ChartEvent_ChartEventID", "dbo.ChartEvents")
            DropForeignKey("dbo.Charts", "ChartSystem_ChartSystemID", "dbo.ChartSystems")
            DropForeignKey("dbo.Indicators", "DataSeries_DataSeriesID", "dbo.DataSeries")
            DropForeignKey("dbo.DataSeries", "MarketDataSource_MarketDataSourceID", "dbo.MarketDataSources")
            DropForeignKey("dbo.Indicators", "ChartSystem_ChartSystemID", "dbo.ChartSystems")
            DropForeignKey("dbo.MarketDataSources", "Market_MarketID", "dbo.Markets")
            DropForeignKey("dbo.MarketDataSources", "Project_ProjectID", "dbo.Projects")
            DropForeignKey("dbo.Projects", "User_UserID", "dbo.Users")
            DropIndex("dbo.Charts", New String() { "ChartSystem_ChartSystemID" })
            DropIndex("dbo.Charts", New String() { "ChartEvent_ChartEventID" })
            DropIndex("dbo.DataSeries", New String() { "MarketDataSource_MarketDataSourceID" })
            DropIndex("dbo.Indicators", New String() { "ChartSystem_ChartSystemID" })
            DropIndex("dbo.Indicators", New String() { "DataSeries_DataSeriesID" })
            DropIndex("dbo.MarketDataSources", New String() { "Project_ProjectID" })
            DropIndex("dbo.MarketDataSources", New String() { "Market_MarketID" })
            DropIndex("dbo.Projects", New String() { "User_UserID" })
            RenameColumn(table := "dbo.Charts", name := "ChartEvent_ChartEventID", newName := "ChartEventID")
            RenameColumn(table := "dbo.Charts", name := "ChartSystem_ChartSystemID", newName := "ChartSystemID")
            RenameColumn(table := "dbo.Indicators", name := "DataSeries_DataSeriesID", newName := "DataSeriesID")
            RenameColumn(table := "dbo.DataSeries", name := "MarketDataSource_MarketDataSourceID", newName := "MarketDataSourceID")
            RenameColumn(table := "dbo.Indicators", name := "ChartSystem_ChartSystemID", newName := "ChartSystemID")
            RenameColumn(table := "dbo.MarketDataSources", name := "Market_MarketID", newName := "MarketID")
            RenameColumn(table := "dbo.MarketDataSources", name := "Project_ProjectID", newName := "ProjectID")
            RenameColumn(table := "dbo.Projects", name := "User_UserID", newName := "UserID")
            AlterColumn("dbo.Charts", "ChartSystemID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.Charts", "ChartEventID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.DataSeries", "MarketDataSourceID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.Indicators", "ChartSystemID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.Indicators", "DataSeriesID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.MarketDataSources", "ProjectID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.MarketDataSources", "MarketID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.Projects", "UserID", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.Charts", "ChartSystemID")
            CreateIndex("dbo.Charts", "ChartEventID")
            CreateIndex("dbo.DataSeries", "MarketDataSourceID")
            CreateIndex("dbo.Indicators", "DataSeriesID")
            CreateIndex("dbo.Indicators", "ChartSystemID")
            CreateIndex("dbo.MarketDataSources", "ProjectID")
            CreateIndex("dbo.MarketDataSources", "MarketID")
            CreateIndex("dbo.Projects", "UserID")
            AddForeignKey("dbo.Charts", "ChartEventID", "dbo.ChartEvents", "ChartEventID", cascadeDelete := True)
            AddForeignKey("dbo.Charts", "ChartSystemID", "dbo.ChartSystems", "ChartSystemID", cascadeDelete := True)
            AddForeignKey("dbo.Indicators", "DataSeriesID", "dbo.DataSeries", "DataSeriesID", cascadeDelete := True)
            AddForeignKey("dbo.DataSeries", "MarketDataSourceID", "dbo.MarketDataSources", "MarketDataSourceID", cascadeDelete := True)
            AddForeignKey("dbo.Indicators", "ChartSystemID", "dbo.ChartSystems", "ChartSystemID", cascadeDelete := True)
            AddForeignKey("dbo.MarketDataSources", "MarketID", "dbo.Markets", "MarketID", cascadeDelete := True)
            AddForeignKey("dbo.MarketDataSources", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete := True)
            AddForeignKey("dbo.Projects", "UserID", "dbo.Users", "UserID", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Projects", "UserID", "dbo.Users")
            DropForeignKey("dbo.MarketDataSources", "ProjectID", "dbo.Projects")
            DropForeignKey("dbo.MarketDataSources", "MarketID", "dbo.Markets")
            DropForeignKey("dbo.Indicators", "ChartSystemID", "dbo.ChartSystems")
            DropForeignKey("dbo.DataSeries", "MarketDataSourceID", "dbo.MarketDataSources")
            DropForeignKey("dbo.Indicators", "DataSeriesID", "dbo.DataSeries")
            DropForeignKey("dbo.Charts", "ChartSystemID", "dbo.ChartSystems")
            DropForeignKey("dbo.Charts", "ChartEventID", "dbo.ChartEvents")
            DropIndex("dbo.Projects", New String() { "UserID" })
            DropIndex("dbo.MarketDataSources", New String() { "MarketID" })
            DropIndex("dbo.MarketDataSources", New String() { "ProjectID" })
            DropIndex("dbo.Indicators", New String() { "ChartSystemID" })
            DropIndex("dbo.Indicators", New String() { "DataSeriesID" })
            DropIndex("dbo.DataSeries", New String() { "MarketDataSourceID" })
            DropIndex("dbo.Charts", New String() { "ChartEventID" })
            DropIndex("dbo.Charts", New String() { "ChartSystemID" })
            AlterColumn("dbo.Projects", "UserID", Function(c) c.Int())
            AlterColumn("dbo.MarketDataSources", "MarketID", Function(c) c.Int())
            AlterColumn("dbo.MarketDataSources", "ProjectID", Function(c) c.Int())
            AlterColumn("dbo.Indicators", "DataSeriesID", Function(c) c.Int())
            AlterColumn("dbo.Indicators", "ChartSystemID", Function(c) c.Int())
            AlterColumn("dbo.DataSeries", "MarketDataSourceID", Function(c) c.Int())
            AlterColumn("dbo.Charts", "ChartEventID", Function(c) c.Int())
            AlterColumn("dbo.Charts", "ChartSystemID", Function(c) c.Int())
            RenameColumn(table := "dbo.Projects", name := "UserID", newName := "User_UserID")
            RenameColumn(table := "dbo.MarketDataSources", name := "ProjectID", newName := "Project_ProjectID")
            RenameColumn(table := "dbo.MarketDataSources", name := "MarketID", newName := "Market_MarketID")
            RenameColumn(table := "dbo.Indicators", name := "ChartSystemID", newName := "ChartSystem_ChartSystemID")
            RenameColumn(table := "dbo.DataSeries", name := "MarketDataSourceID", newName := "MarketDataSource_MarketDataSourceID")
            RenameColumn(table := "dbo.Indicators", name := "DataSeriesID", newName := "DataSeries_DataSeriesID")
            RenameColumn(table := "dbo.Charts", name := "ChartSystemID", newName := "ChartSystem_ChartSystemID")
            RenameColumn(table := "dbo.Charts", name := "ChartEventID", newName := "ChartEvent_ChartEventID")
            CreateIndex("dbo.Projects", "User_UserID")
            CreateIndex("dbo.MarketDataSources", "Market_MarketID")
            CreateIndex("dbo.MarketDataSources", "Project_ProjectID")
            CreateIndex("dbo.Indicators", "DataSeries_DataSeriesID")
            CreateIndex("dbo.Indicators", "ChartSystem_ChartSystemID")
            CreateIndex("dbo.DataSeries", "MarketDataSource_MarketDataSourceID")
            CreateIndex("dbo.Charts", "ChartEvent_ChartEventID")
            CreateIndex("dbo.Charts", "ChartSystem_ChartSystemID")
            AddForeignKey("dbo.Projects", "User_UserID", "dbo.Users", "UserID")
            AddForeignKey("dbo.MarketDataSources", "Project_ProjectID", "dbo.Projects", "ProjectID")
            AddForeignKey("dbo.MarketDataSources", "Market_MarketID", "dbo.Markets", "MarketID")
            AddForeignKey("dbo.Indicators", "ChartSystem_ChartSystemID", "dbo.ChartSystems", "ChartSystemID")
            AddForeignKey("dbo.DataSeries", "MarketDataSource_MarketDataSourceID", "dbo.MarketDataSources", "MarketDataSourceID")
            AddForeignKey("dbo.Indicators", "DataSeries_DataSeriesID", "dbo.DataSeries", "DataSeriesID")
            AddForeignKey("dbo.Charts", "ChartSystem_ChartSystemID", "dbo.ChartSystems", "ChartSystemID")
            AddForeignKey("dbo.Charts", "ChartEvent_ChartEventID", "dbo.ChartEvents", "ChartEventID")
        End Sub
    End Class
End Namespace