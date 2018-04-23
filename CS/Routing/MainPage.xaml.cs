#region #CodeBehind
using DevExpress.Xpf.Map;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Routing {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
            waypoints.Add(new RouteWaypoint("New York", new GeoPoint(41.145556, -73.995)));
            waypoints.Add(new RouteWaypoint("Oklahoma", new GeoPoint(36.131389, -95.937222)));
            waypoints.Add(new RouteWaypoint("Las Vegas", new GeoPoint(36.175, -115.136389)));

            routeProvider.CalculateRoute(waypoints);
        }
    }
}
#endregion #CodeBehind