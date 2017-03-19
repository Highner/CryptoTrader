Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class marketconnectionupdate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.MarketConnections", "Name", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.MarketConnections", "Name")
        End Sub
    End Class
End Namespace
