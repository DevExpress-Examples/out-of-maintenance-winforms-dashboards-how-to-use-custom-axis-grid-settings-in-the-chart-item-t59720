Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DesignerSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			dashboardDesigner1.LoadDashboard("..\..\Data\T597206.xml")
		End Sub

		Private Sub dashboardDesigner1_DashboardItemControlCreated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner1.DashboardItemControlCreated
			If e.DashboardItemName = "chartDashboardItem1" Then
				AddHandler e.ChartControl.AxisScaleChanged, AddressOf ChartControl_AxisScaleChanged
			End If
		End Sub

		Private Sub ChartControl_AxisScaleChanged(ByVal sender As Object, ByVal e As AxisScaleChangedEventArgs)
			If TypeOf e.Axis Is SecondaryAxisY Then
				If e.GridSpacingChange.NewValue<1 Then
					e.Axis.NumericScaleOptions.GridSpacing = 1
				End If
			End If
		End Sub

		Private Sub dashboardDesigner1_DashboardItemBeforeControlDisposed(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner1.DashboardItemBeforeControlDisposed
			If e.DashboardItemName = "chartDashboardItem1" Then
				RemoveHandler e.ChartControl.AxisScaleChanged, AddressOf ChartControl_AxisScaleChanged
			End If
		End Sub
	End Class
End Namespace
