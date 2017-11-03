using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Statistics;

namespace FeedbackControl.Kalman
{
    public class KalmanFilter1D
    {
        protected Gaussian mBeliefDistribution;
        protected Gaussian mMotionDistribution;
        protected Gaussian mMeasurementDistribution;

        public double State
        {
            get { return mBeliefDistribution.Mean; }
        }

        public double Uncertainty
        {
            get { return mBeliefDistribution.StdDev; }
        }

        public string BeliefDistributionDescription
        {
            get
            {
                return string.Format("[{0}, {1}]", mBeliefDistribution.Mean, mBeliefDistribution.StdDev);
            }
        }

        public Gaussian BeliefDistribution
        {
            get { return mBeliefDistribution; }
        }

        public KalmanFilter1D(double mu, double sigma, double measurement_sigma, double motion_sigma)
        {
            mMotionDistribution = new Gaussian(0, motion_sigma);
            mMeasurementDistribution = new Gaussian(0, measurement_sigma);
            mBeliefDistribution = new Gaussian(mu, sigma);
        }

        public void Update(double measurement)
        {
            mMeasurementDistribution.Mean = measurement;
            mBeliefDistribution = KalmanFilter1DHelper.Update(mBeliefDistribution, mMeasurementDistribution);
        }

        public void Predict(double motion)
        {
            mMotionDistribution.Mean = motion;
            mBeliefDistribution = KalmanFilter1DHelper.Predict(mBeliefDistribution, mMotionDistribution);
        }

    }
}
