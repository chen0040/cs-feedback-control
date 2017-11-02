using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedbackControl.PID
{
    public class FastPIDController : PIDController
    {
        protected double mDeltaKp = 0.001;

        public override double PerformPID()
        {
            Tune();
            return Compute();
        }

        protected void Tune()
        {
            if (mKi == 0 && mKd == 0)
            {
                if (!IsOscillating)
                {
                    mKp += mDeltaKp;
                }
            }
            
        }

        public bool IsOscillating
        {
            get
            {
                return false;
            }
        }

        public override void ResetState()
        {
            mKi = 0;
            mKd = 0;

            base.ResetState();
        }
    }
}
