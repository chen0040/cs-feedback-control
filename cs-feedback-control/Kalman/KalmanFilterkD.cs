using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Generic;
using MathNet.Numerics.LinearAlgebra.Double;

namespace FeedbackControl.Kalman
{
    public class KalmanFilterkD
    {
        protected Matrix<double> mStates;
        protected Matrix<double> mUncertainty;

        protected Matrix<double> mNextStateFunction;

        protected Matrix<double> mMeasurementFunction;
        protected Matrix<double> mMeasurementUncertainty;

        protected Matrix<double> mIMatrix;

        protected int mDimension;
        protected int mNumMeasures;

        public int Dimension
        {
            get { return mDimension; }
        }

        public int NumMeasures
        {
            get { return mNumMeasures; }
        }

        public double[] States
        {
            get
            {
                double[] states = new double[mDimension];
                for (int i = 0; i < mDimension; ++i)
                {
                    states[i] = mStates[i, 0];
                }
                return states;
            }
            set
            {
                new DenseMatrix(mDimension, 1, value);
            }
        }

        public double[,] StateUncertainty
        {
            get
            {
                double[,] states = new double[mDimension, mDimension];

                for (int row = 0; row < mDimension; ++row)
                {
                    for (int col = 0; col < mDimension; ++col)
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
                double[,] states = new double[mDimension, mDimension];

                for (int row = 0; row < mDimension; ++row)
                {
                    for (int col = 0; col < mDimension; ++col)
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

        public double[,] MeasurementFunction
        {
            get
            {
                double[,] measurement_function = new double[mNumMeasures, mDimension];
                for(int i=0; i < mDimension; ++i)
                {
                    for (int j = 0; j < mNumMeasures; ++j)
                    {
                        measurement_function[j, i] = mMeasurementFunction[j, i];
                    }
                }
                return measurement_function;
            }
            set
            {
                mMeasurementFunction = new DenseMatrix(value);
            }
        }

        public double[] MeasurementUncertainty
        {
            get
            {
                double[] uncertainty = new double[mNumMeasures];
                for (int j = 0; j < mNumMeasures; ++j)
                {
                    uncertainty[j] = mMeasurementUncertainty[j, 0];
                }
                return uncertainty;
            }
            set
            {
                mMeasurementUncertainty = new DenseMatrix(mNumMeasures, 1, value);
            }
        }

        public KalmanFilterkD(int dimension, int number_of_measures)
        {
            mDimension = dimension;
            mNumMeasures = number_of_measures;

            mStates = new DenseMatrix(mDimension, 1, 0); 

            double[,] initial_uncertainty=new double[mDimension, mDimension];
            for (int i = 0; i < mDimension; ++i)
            {
                for (int j = 0; j < mDimension; ++j)
                {
                    initial_uncertainty[i, j] = (i == j) ? 1000.0 : 0;
                }
            }
            mUncertainty = new DenseMatrix(initial_uncertainty);

            double[,] next_state_function=new double[mDimension, mDimension];
            mNextStateFunction = new DenseMatrix(next_state_function);

            double[,] measurement_function = new double[mNumMeasures, mDimension];
            for (int j = 0; j < mNumMeasures; ++j)
            {
                measurement_function[j, j] = 1.0;
            }
            mMeasurementFunction = new DenseMatrix(measurement_function);
            mMeasurementUncertainty = new DenseMatrix(mNumMeasures, 1, 1.0);

            mIMatrix = DenseMatrix.Identity(mDimension);
        }

        public void Update(double[] measurement)
        {
            Matrix<double> Z = new DenseMatrix(mNumMeasures, 1, measurement);
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
                external_motion = new double[mDimension];
            }
            Matrix<double> external_motion_matrix=new DenseMatrix(mDimension, 1, external_motion);
            mStates = mNextStateFunction.Multiply(mStates) + external_motion_matrix;
            mUncertainty = mNextStateFunction.Multiply(mUncertainty).Multiply(mNextStateFunction.Transpose());
        }

        public string StateDescription
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("[");
                for (int i = 0; i < mDimension; ++i)
                {
                    if (i != 0)
                    {
                        sb.Append(", ");
                    }
                    sb.AppendFormat("[{0}]", mStates[i, 0]);
                }
                sb.Append("]");
                return sb.ToString();
            }
        }

        public string UncertaintyDescription
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("[");
                for (int i = 0; i < mDimension; ++i)
                {
                    if (i != 0)
                    {
                        sb.Append(", ");
                    }
                    sb.Append("[");
                    for (int j = 0; j < mDimension; ++j)
                    {
                        if (j != 0)
                        {
                            sb.Append(", ");
                        }
                        sb.AppendFormat("{0}", mStates[i, j]);
                    }
                    sb.Append("]");
                }
                sb.Append("]");
                return sb.ToString();
            }
        }

    }
}
