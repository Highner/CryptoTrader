Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class marketconnection3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.MarketConnections", "Market_MarketID", "dbo.Markets")
            DropForeignKey("dbo.MarketConnections", "User_UserID", "dbo.Users")
            DropIndex("dbo.MarketConnections", New String() { "Market_MarketID" })
            DropIndex("dbo.MarketConnections", New String() { "User_UserID" })
            RenameColumn(table := "dbo.MarketConnections", name := "Market_MarketID", newName := "MarketID")
            RenameColumn(table := "dbo.MarketConnections", name := "User_UserID", newName := "UserID")
            AlterColumn("dbo.MarketConnections", "MarketID", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.MarketConnections", "UserID", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.MarketConnections", "UserID")
            CreateIndex("dbo.MarketConnections", "MarketID")
            AddForeignKey("dbo.MarketConnections", "MarketID", "dbo.Markets", "MarketID", cascadeDelete := True)
            AddForeignKey("dbo.MarketConnections", "UserID", "dbo.Users", "UserID", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.MarketConnections", "UserID", "dbo.Users")
            DropForeignKey("dbo.MarketConnections", "MarketID", "dbo.Markets")
            DropIndex("dbo.MarketConnections", New String() { "MarketID" })
            DropIndex("dbo.MarketConnections", New String() { "UserID" })
            AlterColumn("dbo.MarketConnections", "UserID", Function(c) c.Int())
            AlterColumn("dbo.MarketConnections", "MarketID", Function(c) c.Int())
            RenameColumn(table := "dbo.MarketConnections", name := "UserID", newName := "User_UserID")
            RenameColumn(table := "dbo.MarketConnections", name := "MarketID", newName := "Market_MarketID")
            CreateIndex("dbo.MarketConnections", "User_UserID")
            CreateIndex("dbo.MarketConnections", "Market_MarketID")
            AddForeignKey("dbo.MarketConnections", "User_UserID", "dbo.Users", "UserID")
            AddForeignKey("dbo.MarketConnections", "Market_MarketID", "dbo.Markets", "MarketID")
        End Sub
    End Class
End Namespace
