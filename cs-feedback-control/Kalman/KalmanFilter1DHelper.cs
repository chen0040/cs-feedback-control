using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Statistics;

namespace FeedbackControl.Kalman
{
    public class KalmanFilter1DHelper
    {
        //apply product + bayesian rule
        public static Gaussian Update(Gaussian prior, Gaussian conditional_probability)
        {
            double mean1 = prior.Mean;
            double mean2 = conditional_probability.Mean;
            double sigma1 = prior.StdDev;
            double sigma2 = conditional_probability.StdDev;
            double var1 = sigma1 * sigma1;
            double var2 = sigma2 * sigma2;

            double mean_out, var_out;
            Update(mean1, var1, mean2, var2, out mean_out, out var_out);
            return new Gaussian(mean_out, System.Math.Sqrt(var_out));
        }

        //apply convolution + total probablity
        public static Gaussian Predict(Gaussian prior, Gaussian motion_spread)
        {
            double mean1 = prior.Mean;
            double mean2 = motion_spread.Mean;
            double sigma1 = prior.StdDev;
            double sigma2 = motion_spread.StdDev;
            double var1 = sigma1 * sigma1;
            double var2 = sigma2 * sigma2;

            double mean_out, var_out;
            Predict(mean1, var1, mean2, var2, out mean_out, out var_out);
            return new Gaussian(mean_out, System.Math.Sqrt(var_out));

        }

        public static void Update(double mean1, double var1, double mean2, double var2, out double mean_out, out double var_out)
        {
            mean_out = (var1 * mean2 + var2 * mean1) / (var1 + var2);
            var_out = 1 / (1 / var1 + 1 / var2);
        }

        public static void Predict(double mean1, double var1, double mean2, double var2, out double mean_out, out double var_out)
        {
            mean_out = mean1 + mean2;
            var_out = var1 + var2;
        }
    }
}
