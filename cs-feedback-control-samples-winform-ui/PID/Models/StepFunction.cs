using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID.AnalyzeGUI.Models
{
    public class StepFunction : IModel
    {
        public double getValue(double x)
        {
            if (x < 10)
            {
                return 0;
            }
            return 10;
        }

        public override string ToString()
        {
            return "Step Function";
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
