using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID
{
    /// <summary>
    /// for PID parameter optimization
    /// </summary>
    public class Twiddle
    {
        public delegate double RunMethod(double kP, double kI, double kD);

        public double Optimize(out double kP, out double kI, out double kD, RunMethod run_method, double tolerance=0.000001, double increment_step_size=1.1, double decrement_step_size=0.9, int max_iterations=100000)
        {
            double[] P = new double[3];
            double[] dP = new double[3];
            for (int i = 0; i < 3; ++i)
            {
                P[i] = 0;
                dP[i] = 1;
            }

            double best_error = double.MaxValue;
            int iteration = 0;
            while (dP.Sum() > tolerance && iteration < max_iterations)
            {
                for (int i = 0; i < 3; ++i)
                {
                    P[i] += dP[i];

                    double error = run_method(P[0], P[1], P[2]);
                    if (error < best_error)
                    {
                        dP[i] *= increment_step_size;
                    }
                    else
                    {
                        P[i] -= dP[i] * 2;
                        error = run_method(P[0], P[1], P[2]);
                        if (error < best_error)
                        {
                            dP[i] *= increment_step_size;
                        }
                        else
                        {
                            P[i] += dP[i];
                            dP[i] *= decrement_step_size;
                        }
                    }
                }
                iteration++;
            }

            kP = P[0];
            kI = P[1];
            kD = P[2];

            return best_error;
        }

        
    }
}
