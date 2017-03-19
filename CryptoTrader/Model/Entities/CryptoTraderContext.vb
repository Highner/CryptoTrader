Imports System.Data.Entity

Public Class CryptoTraderContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("CryptoTraderDBConnectionString")
    End Sub

    Public Property Charts As DbSet(Of Chart)
    Public Property ChartSystems As DbSet(Of ChartSystem)
    Public Property DataSeries As DbSet(Of DataSeries)
    Public Property Indicators As DbSet(Of Indicator)
    Public Property Markets As DbSet(Of Market)
    Public Property MarketConnections As DbSet(Of MarketConnection)
    Public Property MarketDataSources As DbSet(Of MarketDataSource)
    Public Property Projects As DbSet(Of Project)
    Public Property Users As DbSet(Of User)
End Class
