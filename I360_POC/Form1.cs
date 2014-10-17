using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraCharts;


namespace I360_POC
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            InitChartControl();

        }
        void InitChartControl()
        {
            chartControl.AppearanceName = "Northern Lights";
            chartControl.PaletteName = "Marquee";
            ChangeSeries(ViewType.Gantt);
            chartControl.Legend.Visible = false;
            chartControl.Series[0].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
        }
        void ChangeSeries(ViewType viewType)
        {
            double[] values = { 3.1, 2.3, 3.2, 3.9, 5.1 };
            Series series = new Series("Series", viewType);
            for (int i = 0; i < values.Length; i++)
                series.Points.Add(new SeriesPoint((i + 1) * 10, new double[] { values[i], values[i] + 3, values[i] + 2, values[i] + 1 }));
            chartControl.Series.Clear();
            chartControl.Series.Add(series);
        }

    }
}