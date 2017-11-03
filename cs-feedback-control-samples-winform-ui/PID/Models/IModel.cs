using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID.AnalyzeGUI.Models
{
    public interface IModel
    {
        double getValue(double x);
        double MaxOutput
        {
            get; 
        }

        double MinOutput
        {
            get;
        }

        
    }
}
