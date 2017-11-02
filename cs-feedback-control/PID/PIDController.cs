using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID
{
    public class PIDController
    {
        protected double mKp=0.5; // proportional coefficient
        protected double mKi=0.5; // integral coefficient
        protected double mKd=0.5; // derivative coefficient
        protected double mInput; // input
        protected double mSetpoint; // setpoint
        protected double mError=0;
        protected double mPrevError=0;
        protected double mTotalError = 0;
        protected double mResult = 0;
        protected double mMaxInput = 1;
        protected double mMinInput = -1;
        protected double mMaxOutput = 0;
        protected double mMinOutput = 0;
        protected double mTolerance = 0.05; // percentage of error that irn s considered on the target input
        protected bool mEnabled = true;

        //proportional band where proportional gain acts upon
        public double Pb
        {
            get { return 1 / mKp; }
            set { mKp = 1 / value; }
        }

        //integral time, this is the time over which error is average. 
        public double It
        {
            get { return 1 / mKi; }
            set { mKi = 1 / value; }
        }

        //derivative time, this is the time over which the derivative of the error is evaluated
        public double Dt
        {
            get { return mKd; }
            set { mKd = value; }
        }

        public virtual void ResetState()
        {
            mPrevError = 0;
            mTotalError = 0;
        }

        public double Tolerance
        {
            get { return mTolerance; }
            set { mTolerance = value; }
        }

        public bool Enabled
        {
            get { return mEnabled; }
            set { mEnabled = value; }
        }

        public bool IsOnTarget
        {
            get
            {
                return mError < mTolerance * (mMaxInput - mMinInput) / 100;
            }
        }

        public double MaxInput
        {
            get { return mMaxInput; }
            set { mMaxInput = value; }
        }

        public double MinInput
        {
            get { return mMinInput; }
            set { mMinInput = value; }
        }

        public double MaxOutput
        {
            get { return mMaxOutput; }
            set { mMaxOutput = value; }
        }

        public double MinOutput
        {
            get { return mMinOutput; }
            set { mMinOutput = value; }
        }

        public double Kp
        {
            get { return mKp; }
            set { mKp = value; }
        }

        public double Ki
        {
            get { return mKi; }
            set { mKi = value; }
        }

        public double Kd
        {
            get { return mKd; }
            set { mKd = value; }
        }

        public double Input
        {
            get { return mInput; }
            set { mInput = value; }
        }

        public double Setpoint
        {
            get { return mSetpoint; }
            set { mSetpoint = value; }
        }

        public virtual double PerformPID()
        {
            return Compute();
        }

        public double Compute()
        {
            if (!mEnabled) return mResult;

            mError = mSetpoint - mInput;

            if((mTotalError+mError) * mKi < mMaxOutput &&
                (mTotalError + mError) * mKi > mMinOutput)
            {
                mTotalError += mError;
            }

            mResult = mKp * mError + mKi * mTotalError + mKd * (mError - mPrevError);

            mPrevError = mError;

            if (mResult > mMaxOutput)
            {
                mResult = mMaxOutput;
            }
            else if (mResult < mMinOutput)
            {
                mResult = mMinOutput;
            }

            return mResult;
        }

        public override string ToString()
        {
            return "PID Controller";
        }
    }
}
