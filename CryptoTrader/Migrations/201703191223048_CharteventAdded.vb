Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CharteventAdded
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ChartEvents",
                Function(c) New With
                    {
                        .ChartEventID = c.Int(nullable := False, identity := True)
                    }) _
                .PrimaryKey(Function(t) t.ChartEventID)
            
            AddColumn("dbo.Charts", "DataSeries_DataSeriesID", Function(c) c.Int())
            AddColumn("dbo.Charts", "ChartEvent_ChartEventID", Function(c) c.Int())
            AddColumn("dbo.DataSeries", "ChartEvent_ChartEventID", Function(c) c.Int())
            AddColumn("dbo.Indicators", "ChartSystem_ChartSystemID", Function(c) c.Int())
            AddColumn("dbo.Indicators", "DataSeries_DataSeriesID", Function(c) c.Int())
            AddColumn("dbo.MarketConnections", "Market_MarketID", Function(c) c.Int())
            AddColumn("dbo.MarketConnections", "User_UserID", Function(c) c.Int())
            CreateIndex("dbo.Charts", "DataSeries_DataSeriesID")
            CreateIndex("dbo.Charts", "ChartEvent_ChartEventID")
            CreateIndex("dbo.DataSeries", "ChartEvent_ChartEventID")
            CreateIndex("dbo.Indicators", "ChartSystem_ChartSystemID")
            CreateIndex("dbo.Indicators", "DataSeries_DataSeriesID")
            CreateIndex("dbo.MarketConnections", "Market_MarketID")
            CreateIndex("dbo.MarketConnections", "User_UserID")
            AddForeignKey("dbo.Charts", "DataSeries_DataSeriesID", "dbo.DataSeries", "DataSeriesID")
            AddForeignKey("dbo.Indicators", "ChartSystem_ChartSystemID", "dbo.ChartSystems", "ChartSystemID")
            AddForeignKey("dbo.Indicators", "DataSeries_DataSeriesID", "dbo.DataSeries", "DataSeriesID")
            AddForeignKey("dbo.MarketConnections", "Market_MarketID", "dbo.Markets", "MarketID")
            AddForeignKey("dbo.MarketConnections", "User_UserID", "dbo.Users", "UserID")
            AddForeignKey("dbo.DataSeries", "ChartEvent_ChartEventID", "dbo.ChartEvents", "ChartEventID")
            AddForeignKey("dbo.Charts", "ChartEvent_ChartEventID", "dbo.ChartEvents", "ChartEventID")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Charts", "ChartEvent_ChartEventID", "dbo.ChartEvents")
            DropForeignKey("dbo.DataSeries", "ChartEvent_ChartEventID", "dbo.ChartEvents")
            DropForeignKey("dbo.MarketConnections", "User_UserID", "dbo.Users")
            DropForeignKey("dbo.MarketConnections", "Market_MarketID", "dbo.Markets")
            DropForeignKey("dbo.Indicators", "DataSeries_DataSeriesID", "dbo.DataSeries")
            DropForeignKey("dbo.Indicators", "ChartSystem_ChartSystemID", "dbo.ChartSystems")
            DropForeignKey("dbo.Charts", "DataSeries_DataSeriesID", "dbo.DataSeries")
            DropIndex("dbo.MarketConnections", New String() { "User_UserID" })
            DropIndex("dbo.MarketConnections", New String() { "Market_MarketID" })
            DropIndex("dbo.Indicators", New String() { "DataSeries_DataSeriesID" })
            DropIndex("dbo.Indicators", New String() { "ChartSystem_ChartSystemID" })
            DropIndex("dbo.DataSeries", New String() { "ChartEvent_ChartEventID" })
            DropIndex("dbo.Charts", New String() { "ChartEvent_ChartEventID" })
            DropIndex("dbo.Charts", New String() { "DataSeries_DataSeriesID" })
            DropColumn("dbo.MarketConnections", "User_UserID")
            DropColumn("dbo.MarketConnections", "Market_MarketID")
            DropColumn("dbo.Indicators", "DataSeries_DataSeriesID")
            DropColumn("dbo.Indicators", "ChartSystem_ChartSystemID")
            DropColumn("dbo.DataSeries", "ChartEvent_ChartEventID")
            DropColumn("dbo.Charts", "ChartEvent_ChartEventID")
            DropColumn("dbo.Charts", "DataSeries_DataSeriesID")
            DropTable("dbo.ChartEvents")
        End Sub
    End Class
End Namespace
