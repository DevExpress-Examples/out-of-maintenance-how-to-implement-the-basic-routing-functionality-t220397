<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570951/14.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T220397)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainPage.xaml](./CS/Routing/MainPage.xaml) (VB: [MainPage.xaml](./VB/Routing/MainPage.xaml))**
* [MainPage.xaml.cs](./CS/Routing/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/Routing/MainPage.xaml.vb))
<!-- default file list end -->
# How to implement the basic routing functionality


This example demonstrates how to implement the basic routing functionality.<br /><br />To do this, create an <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfMapInformationLayertopic">InformationLayer</a> object and add it to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_Layerstopic">MapControl.Layers</a> collection. Then create a <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfMapBingRouteDataProvidertopic">BingRouteDataProvider</a> object specify its parameters, and assign it to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapInformationLayer_DataProvidertopic">InformationLayer.DataProvider</a> property.<br />To build a route, call the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapBingRouteDataProvider_CalculateRoutetopic">BingRouteDataProvider.CalculateRoute</a> method.

<br/>


