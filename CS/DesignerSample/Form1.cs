using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"..\..\Data\T597206.xml");
        }

        private void dashboardDesigner1_DashboardItemControlCreated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            if (e.DashboardItemName == "chartDashboardItem1")
            {
                e.ChartControl.AxisScaleChanged += ChartControl_AxisScaleChanged;
            }
        }

        private void ChartControl_AxisScaleChanged(object sender, AxisScaleChangedEventArgs e)
        {
            if (e.Axis is SecondaryAxisY)
            {
                if (e.GridSpacingChange.NewValue<1)
                {
                    e.Axis.NumericScaleOptions.GridSpacing = 1;
                }
            }
        }

        private void dashboardDesigner1_DashboardItemBeforeControlDisposed(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            if (e.DashboardItemName == "chartDashboardItem1")
            {
                e.ChartControl.AxisScaleChanged -= ChartControl_AxisScaleChanged;
            }
        }
    }
}
