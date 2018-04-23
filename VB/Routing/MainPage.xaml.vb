#Region "#CodeBehind"
Imports DevExpress.Xpf.Map
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace Routing
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim waypoints As New List(Of RouteWaypoint)()
            waypoints.Add(New RouteWaypoint("New York", New GeoPoint(41.145556, -73.995)))
            waypoints.Add(New RouteWaypoint("Oklahoma", New GeoPoint(36.131389, -95.937222)))
            waypoints.Add(New RouteWaypoint("Las Vegas", New GeoPoint(36.175, -115.136389)))

            routeProvider.CalculateRoute(waypoints)
        End Sub
    End Class
End Namespace
#End Region ' #CodeBehind