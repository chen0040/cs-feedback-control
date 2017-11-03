using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FeedbackControl.Fuzzy
{
    using System.Windows.Forms.DataVisualization.Charting;
    using Memberships;
    public partial class UcFuzzySet : UserControl
    {
        private FuzzySet mFuzzySet;
        private string mFuzzySetName;

        public FuzzySet FuzzySet
        {
            set { mFuzzySet = value; }
        }

        public string FuzzySetName
        {
            set { mFuzzySetName = value; }
        }

        public UcFuzzySet()
        {
            InitializeComponent();
        }

        public UcFuzzySet(string name, FuzzySet fuzzy_set)
        {
            InitializeComponent();
            mFuzzySetName = name;
            mFuzzySet = fuzzy_set;
        }

        private void UcFuzzySetCanvas_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            int count=mFuzzySet.GetMembershipCount();
            double minX = mFuzzySet.GetMinX();
            double maxX = mFuzzySet.GetMaxX();
            chtFuzzySet.Series.Clear();

            double deltaX = mFuzzySet.GetDeltaX();
            for (int i = 0; i < count; ++i)
            {
                Membership ms=mFuzzySet.GetMembership(i);
                Series series = new Series(mFuzzySet.GetMembershipName(i));
                series.ChartType = SeriesChartType.FastLine;
                for (double x = minX; x <= maxX; x += deltaX)
                {
                    double y=ms.degree(x);
                    series.Points.AddXY(x, y);
                }
                chtFuzzySet.Series.Add(series);
            }
            chtFuzzySet.ChartAreas[0].AxisX.Title = "Crisp Value";
            chtFuzzySet.ChartAreas[0].AxisY.Title = "Membership Degree";
            chtFuzzySet.ChartAreas[0].RecalculateAxesScale();
            chtFuzzySet.Titles.Add(string.Format("FuzzySet: {0}", mFuzzySetName));
        }
    }
}
