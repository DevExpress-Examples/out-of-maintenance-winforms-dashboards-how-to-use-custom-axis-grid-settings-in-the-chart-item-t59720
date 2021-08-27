<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581444/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T597206)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DesignerSample/Form1.cs) (VB: [Form1.vb](./VB/DesignerSample/Form1.vb))
* [Program.cs](./CS/DesignerSample/Program.cs) (VB: [Program.vb](./VB/DesignerSample/Program.vb))
<!-- default file list end -->
# WinForms Dashboards - How to use custom axis grid settings in the Chart Item


<p>For better appearance, our Dashboard Chart Items automatically calculate such axis grid settings like <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleGridOptionsBase.GridSpacing.property">GridSpacing</a> (the interval between <a href="https://documentation.devexpress.com/WindowsForms/1992/Controls-and-Libraries/Chart-Control/Visual-Elements/Grid-Lines">grid lines</a> and <a href="https://documentation.devexpress.com/WindowsForms/1991/Controls-and-Libraries/Chart-Control/Visual-Elements/Axis-Tickmarks">major tickmarks</a> in axis units). In certain cases, automatically calculated values are not suitable. For instance, the Y axis' labels can display fractional numbers when the chart contains only whole number values - measures with the Count summary type. This example illustrates how to customize automatically calculated grid settings via code, so that only whole numbers are displayed in the Y axis' labels. For this, access the underlying Chart Control in the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlCreated.event">DashboardItemControlCreated</a> event handler and handle the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.AxisScaleChanged.event">AxisScaleChanged</a> event to modify automatically calculated axis settings.<br><br>Refer to the <a href="https://documentation.devexpress.com/Dashboard/18019/Building-the-Designer-and-Viewer-Applications/WinForms-Viewer/Access-to-Underlying-Controls">Access to Underlying Controls</a> topic to learn more about accessing inner controls and customizing their settings to add specific capabilities.<br><strong>Note</strong> that printed or exported documents containing a dashboard/dashboard item do not reflect appearance settings applied using the events for accessing underlying controls.</p>
<br>The flowing screencast demonstrates this approach and default behavior.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/winforms-dashboards-how-to-use-custom-axis-grid-settings-in-the-chart-item-t597206/17.1.3+/media/a249a17c-9d90-4015-ac88-09a8581b8bcb.png"><br><br>See also:<a href="https://www.devexpress.com/Support/Center/p/T607149">Web Dashboards - How to make the Chart Item display only whole numbers in the Y axis' labels</a>

<br/>


