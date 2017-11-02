using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID.AnalyzeGUI.Models
{
    class SinFunction : IModel
    {
        public double getValue(double x)
        {
            return 10 * System.Math.Sin(x);
        }

        public override string ToString()
        {
            return "Sin Function";
        }

        public double MaxOutput
        {
            get { return 10; }
        }

        public double MinOutput
        {
            get { return -10; }
        }
    }
}
