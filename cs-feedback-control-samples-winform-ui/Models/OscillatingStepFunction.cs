using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID.AnalyzeGUI.Models
{
    public class OscillatingStepFunction : IModel
    {
        public double getValue(double x)
        {
            double val = System.Math.Sin(x);
            if (val < 0)
            {
                return -10;
            }
            return 10;
        }

        public override string ToString()
        {
            return "Oscillating Step Function";
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
