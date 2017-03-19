Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Charts",
                Function(c) New With
                    {
                        .ChartID = c.Int(nullable := False, identity := True),
                        .ChartSystem_ChartSystemID = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.ChartID) _
                .ForeignKey("dbo.ChartSystems", Function(t) t.ChartSystem_ChartSystemID) _
                .Index(Function(t) t.ChartSystem_ChartSystemID)
            
            CreateTable(
                "dbo.ChartSystems",
                Function(c) New With
                    {
                        .ChartSystemID = c.Int(nullable := False, identity := True)
                    }) _
                .PrimaryKey(Function(t) t.ChartSystemID)
            
            CreateTable(
                "dbo.DataSeries",
                Function(c) New With
                    {
                        .DataSeriesID = c.Int(nullable := False, identity := True),
                        .MarketDataSource_MarketDataSourceID = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.DataSeriesID) _
                .ForeignKey("dbo.MarketDataSources", Function(t) t.MarketDataSource_MarketDataSourceID) _
                .Index(Function(t) t.MarketDataSource_MarketDataSourceID)
            
            CreateTable(
                "dbo.MarketDataSources",
                Function(c) New With
                    {
                        .MarketDataSourceID = c.Int(nullable := False, identity := True),
                        .Market_MarketID = c.Int(),
                        .Project_ProjectID = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.MarketDataSourceID) _
                .ForeignKey("dbo.Markets", Function(t) t.Market_MarketID) _
                .ForeignKey("dbo.Projects", Function(t) t.Project_ProjectID) _
                .Index(Function(t) t.Market_MarketID) _
                .Index(Function(t) t.Project_ProjectID)
            
            CreateTable(
                "dbo.Markets",
                Function(c) New With
                    {
                        .MarketID = c.Int(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.MarketID)
            
            CreateTable(
                "dbo.Projects",
                Function(c) New With
                    {
                        .ProjectID = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .User_UserID = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.ProjectID) _
                .ForeignKey("dbo.Users", Function(t) t.User_UserID) _
                .Index(Function(t) t.User_UserID)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .UserID = c.Int(nullable := False, identity := True),
                        .Name = c.String()
                    }) _
                .PrimaryKey(Function(t) t.UserID)
            
            CreateTable(
                "dbo.Indicators",
                Function(c) New With
                    {
                        .IndicatorID = c.Int(nullable := False, identity := True)
                    }) _
                .PrimaryKey(Function(t) t.IndicatorID)
            
            CreateTable(
                "dbo.MarketConnections",
                Function(c) New With
                    {
                        .MarketConnectionID = c.Int(nullable := False, identity := True),
                        .APIKey = c.String(),
                        .APISecret = c.String()
                    }) _
                .PrimaryKey(Function(t) t.MarketConnectionID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.MarketDataSources", "Project_ProjectID", "dbo.Projects")
            DropForeignKey("dbo.Projects", "User_UserID", "dbo.Users")
            DropForeignKey("dbo.MarketDataSources", "Market_MarketID", "dbo.Markets")
            DropForeignKey("dbo.DataSeries", "MarketDataSource_MarketDataSourceID", "dbo.MarketDataSources")
            DropForeignKey("dbo.Charts", "ChartSystem_ChartSystemID", "dbo.ChartSystems")
            DropIndex("dbo.Projects", New String() { "User_UserID" })
            DropIndex("dbo.MarketDataSources", New String() { "Project_ProjectID" })
            DropIndex("dbo.MarketDataSources", New String() { "Market_MarketID" })
            DropIndex("dbo.DataSeries", New String() { "MarketDataSource_MarketDataSourceID" })
            DropIndex("dbo.Charts", New String() { "ChartSystem_ChartSystemID" })
            DropTable("dbo.MarketConnections")
            DropTable("dbo.Indicators")
            DropTable("dbo.Users")
            DropTable("dbo.Projects")
            DropTable("dbo.Markets")
            DropTable("dbo.MarketDataSources")
            DropTable("dbo.DataSeries")
            DropTable("dbo.ChartSystems")
            DropTable("dbo.Charts")
        End Sub
    End Class
End Namespace
