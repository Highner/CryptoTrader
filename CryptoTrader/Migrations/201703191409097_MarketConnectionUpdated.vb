Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class MarketConnectionUpdated
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.MarketConnections", "Market_MarketID", "dbo.Markets")
            DropForeignKey("dbo.MarketConnections", "User_UserID", "dbo.Users")
            DropIndex("dbo.MarketConnections", New String() { "Market_MarketID" })
            DropIndex("dbo.MarketConnections", New String() { "User_UserID" })
            AddColumn("dbo.MarketConnections", "Market_MarketID1", Function(c) c.Int())
            AddColumn("dbo.MarketConnections", "User_UserID1", Function(c) c.Int())
            AlterColumn("dbo.MarketConnections", "Market_MarketID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.MarketConnections", "User_UserID", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.MarketConnections", "Market_MarketID1")
            CreateIndex("dbo.MarketConnections", "User_UserID1")
            AddForeignKey("dbo.MarketConnections", "Market_MarketID1", "dbo.Markets", "MarketID")
            AddForeignKey("dbo.MarketConnections", "User_UserID1", "dbo.Users", "UserID")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.MarketConnections", "User_UserID1", "dbo.Users")
            DropForeignKey("dbo.MarketConnections", "Market_MarketID1", "dbo.Markets")
            DropIndex("dbo.MarketConnections", New String() { "User_UserID1" })
            DropIndex("dbo.MarketConnections", New String() { "Market_MarketID1" })
            AlterColumn("dbo.MarketConnections", "User_UserID", Function(c) c.Int())
            AlterColumn("dbo.MarketConnections", "Market_MarketID", Function(c) c.Int())
            DropColumn("dbo.MarketConnections", "User_UserID1")
            DropColumn("dbo.MarketConnections", "Market_MarketID1")
            CreateIndex("dbo.MarketConnections", "User_UserID")
            CreateIndex("dbo.MarketConnections", "Market_MarketID")
            AddForeignKey("dbo.MarketConnections", "User_UserID", "dbo.Users", "UserID")
            AddForeignKey("dbo.MarketConnections", "Market_MarketID", "dbo.Markets", "MarketID")
        End Sub
    End Class
End Namespace
