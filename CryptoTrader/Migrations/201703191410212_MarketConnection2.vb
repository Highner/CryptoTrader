Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class MarketConnection2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.MarketConnections", New String() { "Market_MarketID1" })
            DropIndex("dbo.MarketConnections", New String() { "User_UserID1" })
            DropColumn("dbo.MarketConnections", "Market_MarketID")
            DropColumn("dbo.MarketConnections", "User_UserID")
            RenameColumn(table := "dbo.MarketConnections", name := "Market_MarketID1", newName := "Market_MarketID")
            RenameColumn(table := "dbo.MarketConnections", name := "User_UserID1", newName := "User_UserID")
            AlterColumn("dbo.MarketConnections", "User_UserID", Function(c) c.Int())
            AlterColumn("dbo.MarketConnections", "Market_MarketID", Function(c) c.Int())
            CreateIndex("dbo.MarketConnections", "Market_MarketID")
            CreateIndex("dbo.MarketConnections", "User_UserID")
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.MarketConnections", New String() { "User_UserID" })
            DropIndex("dbo.MarketConnections", New String() { "Market_MarketID" })
            AlterColumn("dbo.MarketConnections", "Market_MarketID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.MarketConnections", "User_UserID", Function(c) c.Int(nullable := False))
            RenameColumn(table := "dbo.MarketConnections", name := "User_UserID", newName := "User_UserID1")
            RenameColumn(table := "dbo.MarketConnections", name := "Market_MarketID", newName := "Market_MarketID1")
            AddColumn("dbo.MarketConnections", "User_UserID", Function(c) c.Int(nullable := False))
            AddColumn("dbo.MarketConnections", "Market_MarketID", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.MarketConnections", "User_UserID1")
            CreateIndex("dbo.MarketConnections", "Market_MarketID1")
        End Sub
    End Class
End Namespace
