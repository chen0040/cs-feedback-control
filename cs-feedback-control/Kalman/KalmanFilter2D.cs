using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Generic;
using MathNet.Numerics.LinearAlgebra.Double;

namespace FeedbackControl.Kalman
{
    public class KalmanFilter2D
    {
        protected Matrix<double> mStates;
        protected Matrix<double> mUncertainty;

        protected Matrix<double> mNextStateFunction;

        protected Matrix<double> mMeasurementFunction;
        protected Matrix<double> mMeasurementUncertainty;

        protected Matrix<double> mIMatrix;

        public double[] States
        {
            get
            {
                double[] states = new double[2];
                states[0] = mStates[0, 0];
                states[1] = mStates[1, 0];
                return states;
            }
            set
            {
                new DenseMatrix(2, 1, value);
            }
        }

        public double[,] StateUncertainty
        {
            get
            {
                double[,] states = new double[2, 2];

                for (int row = 0; row < 2; ++row)
                {
                    for (int col = 0; col < 2; ++col)
                    {
                        states[row, col] = mUncertainty[row, col];
                    }
                }
                return states;
            }
            set
            {
                mUncertainty = new DenseMatrix(value);
            }
        }

        public double[,] NextStateFunction
        {
            get
            {
                double[,] states = new double[2, 2];

                for (int row = 0; row < 2; ++row)
                {
                    for (int col = 0; col < 2; ++col)
                    {
                        states[row, col] = mNextStateFunction[row, col];
                    }
                }
                return states;
            }
            set
            {
                mNextStateFunction = new DenseMatrix(value);
            }
        }

        public double[] MeasurementFunction
        {
            get
            {
                double[] measurement_function = new double[2];
                measurement_function[0] = mMeasurementFunction[0, 0];
                measurement_function[1] = mMeasurementFunction[0, 1];
                return measurement_function;
            }
            set
            {
                mMeasurementFunction = new DenseMatrix(1, 2, value);
            }
        }

        public double MeasurementUncertainty
        {
            get
            {
                return mMeasurementUncertainty[0, 0];
            }
            set
            {
                mMeasurementUncertainty = new DenseMatrix(0, 0, value);
            }
        }

        public KalmanFilter2D()
        {
            mStates = new DenseMatrix(2, 1, new double[2] { 0, 0 }); 

            double[,] initial_uncertainty=new double[2, 2];
            initial_uncertainty[0, 0] = 1000.0;
            initial_uncertainty[0, 1] = 0;
            initial_uncertainty[1, 0] = 0;
            initial_uncertainty[1, 1] = 1000.0;
            mUncertainty = new DenseMatrix(initial_uncertainty);

            //next state function which assumes the x[0] is the position and x[1] is the velocity
            //therefore we have:
            //x[0](t)=x[0](t-1)+x[1](t-1)
            //x[1](t)=x[1](t-1)
            double[,] next_state_function=new double[2, 2];
            next_state_function[0, 0]=1;
            next_state_function[0, 1]=1;
            next_state_function[1, 0]=0;
            next_state_function[1, 1]=1;
            mNextStateFunction = new DenseMatrix(next_state_function);

            mMeasurementFunction = new DenseMatrix(1, 2, new double[2] { 1.0, 0 });
            mMeasurementUncertainty = new DenseMatrix(1, 1, 1.0);

            mIMatrix = DenseMatrix.Identity(2);
        }

        public void Update(double measurement)
        {
            Matrix<double> Z = new DenseMatrix(1, 1, measurement);
            Matrix<double> y = Z - mMeasurementFunction.Multiply(mStates);

            Matrix<double> Ht = mMeasurementFunction.Transpose();
            Matrix<double> S = mMeasurementFunction.Multiply(mUncertainty).Multiply(Ht) + mMeasurementUncertainty;

            Matrix<double> K = mUncertainty.Multiply(Ht).Multiply(S.Inverse());

            mStates = mStates + K.Multiply(y);

            mUncertainty = (mIMatrix - K.Multiply(mMeasurementFunction)).Multiply(mUncertainty);
        }

        public void Predict(double[] external_motion = null)
        {
            if (external_motion == null)
            {
                external_motion = new double[2] { 0, 0 };
            }
            Matrix<double> external_motion_matrix=new DenseMatrix(2, 1, external_motion);
            mStates = mNextStateFunction.Multiply(mStates) + external_motion_matrix;
            mUncertainty = mNextStateFunction.Multiply(mUncertainty).Multiply(mNextStateFunction.Transpose());
        }

        public string StateDescription
        {
            get
            {
                return string.Format("[[{0}], [{1}]]", mStates[0, 0], mStates[1, 0]);
            }
        }

        public string UncertaintyDescription
        {
            get
            {
                return string.Format("[[{0}, {1}], [{2}, {3}]]", mUncertainty[0, 0],
                    mUncertainty[1, 0], mUncertainty[1, 0], mUncertainty[1, 1]);
            }
        }

    }
}
