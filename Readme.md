<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581444/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T597206)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DesignerSample/Form1.cs) (VB: [Form1.vb](./VB/DesignerSample/Form1.vb))
* [Program.cs](./CS/DesignerSample/Program.cs) (VB: [Program.vb](./VB/DesignerSample/Program.vb))
<!-- default file list end -->
# Dashboard for WinForms - How to Customize the Chart Item's Axis Grid Settings


The Dashboard Chart Item automatically calculate most of the axis grid settings, such as the [GridSpacing](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleGridOptionsBase.GridSpacing).

There are situations when automatically calculated values are not suitable. Consider Y axis labels that display fractional numbers when the chart contains only whole number values - measures with the Count summary type. 

This example demonstrates how to customize grid settings at runtime, so that only whole numbers are displayed in the Y axis' labels. 

> Run-time customization does not affect printed or exported documents.


![screenshot](/images/screenshot.png)

## Documentation

* [Access to Underlying Controls](https://docs.devexpress.com/Dashboard/18019)



