using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContinuousOptimization;
using FeedbackControl.PID.AnalyzeGUI.Models;
using ZedGraph;

namespace FeedbackControl.PID.AnalyzeGUI
{
    public partial class FrmAnalyzer : Form
    {
        private Gaussian mNoise = new Gaussian();

        public FrmAnalyzer()
        {
            InitializeComponent();
        }

        private void FrmAnalyzer_Load(object sender, EventArgs e)
        {
            cboProblem.Items.Add(new StepFunction());
            cboProblem.Items.Add(new SinFunction());
            cboProblem.Items.Add(new OscillatingStepFunction());
            cboProblem.SelectedIndex = 0;

            cboAlgorithm.Items.Add(new PIDController());
            cboAlgorithm.SelectedIndex = 0;

            GraphPane gpane=chtTimeSeries.GraphPane;
            gpane.Title.Text = "Time Series";
            gpane.XAxis.Title.Text = "Time";
            gpane.YAxis.Title.Text = "Value";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GraphPane gpane = chtTimeSeries.GraphPane;
            gpane.CurveList.Clear();
            gpane.AxisChange();

            chtTimeSeries.Invalidate();
        }

        public PIDController FindController()
        {
            return (PIDController)cboAlgorithm.SelectedItem;
        }

        public IModel FindProblem()
        {
            return (IModel)cboProblem.SelectedItem;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            double time_step = 0.1;
            double start_time = 0;
            double end_time = 40;
            double mu = 0;
            double sigma = 0;
            double Kp=0.5;
            double Ki=0.5;
            double Kd=0.5;
            double.TryParse(txtTimeStep.Text, out time_step);
            double.TryParse(txtStartTime.Text, out start_time);
            double.TryParse(txtEndTime.Text, out end_time);
            double.TryParse(txtNoiseMean.Text, out mu);
            double.TryParse(txtNoiseSigma.Text, out sigma);
            double.TryParse(txtKd.Text, out Kd);
            double.TryParse(txtKp.Text, out Kp);
            double.TryParse(txtKi.Text, out Ki);

            mNoise.Mean = mu;
            mNoise.StdDev = sigma;

            PIDController controller = FindController();
            IModel model = FindProblem();

            PointPairList setpoint_ppl = new PointPairList();
            PointPairList state_value_ppl = new PointPairList();
            PointPairList noise_ppl = new PointPairList();
            PointPairList state_variable_ppl = new PointPairList();

            controller.MaxOutput = model.MaxOutput;
            controller.MinOutput = model.MinOutput;
            controller.Kp = Kp;
            controller.Ki = Ki;
            controller.Kd = Kd;

            controller.ResetState();
            double state_value = 0;

            GraphPane gpane = chtTimeSeries.GraphPane;
            gpane.CurveList.Clear();

            if (chkDisplaySetpoints.Checked)
            {
                LineItem litem = gpane.AddCurve("Setpoint Trajectory", setpoint_ppl, Color.Blue);
                litem.Symbol.IsVisible = false;

            }

            if (chkDisplayControllerStateValue.Checked)
            {
                LineItem litem = gpane.AddCurve("State value Trajectory", state_value_ppl, Color.Red);
                litem.Symbol.IsVisible = false;
            }

            if (chkDisplayControllerStateVariable.Checked)
            {
                LineItem litem = gpane.AddCurve("State variable Trajectory", state_variable_ppl, Color.Black);
                litem.Symbol.IsVisible = false;
            }

            if (chkDisplayNoise.Checked)
            {
                LineItem litem = gpane.AddCurve("Noise Trajectory", noise_ppl, Color.Orange);
                litem.Symbol.IsVisible = false;
            }
            
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.DoWork += (s1, e1) =>
                {
                    for (double time = start_time; time < end_time; time += time_step)
                    {
                        double setpoint = model.getValue(time);

                        controller.Input = state_value; // input value
                        controller.Setpoint = setpoint; // target value

                        double state_variable = controller.PerformPID();
                        double noise=mNoise.Next();

                        state_value += state_variable;
                        state_value += noise;

                        setpoint_ppl.Add(time, setpoint);
                        state_value_ppl.Add(time, state_value);
                        noise_ppl.Add(time, noise);
                        state_variable_ppl.Add(time, state_variable);

                        worker.ReportProgress(0);
                    }
                };
            worker.RunWorkerCompleted += (s1, e1) =>
                {
                    gpane.AxisChange();
                    chtTimeSeries.Invalidate();
                };

            worker.ProgressChanged += (s1, e1) =>
                {
                    gpane.AxisChange();
                    chtTimeSeries.Invalidate();

                    DataTable table = new DataTable();
                    table.Columns.Add("Time");
                    table.Columns.Add("Setpoint");
                    table.Columns.Add("StateValue");
                    table.Columns.Add("StateVariable");
                    table.Columns.Add("Noise");

                    int point_count = setpoint_ppl.Count;
                    
                    for (int i = 0; i < point_count; ++i)
                    {
                        table.Rows.Add(setpoint_ppl[i].X, setpoint_ppl[i].Y, state_value_ppl[i].Y, state_variable_ppl[i].Y, noise_ppl[i].Y);
                    }

                    dgvTimeSeries.DataSource = table;
                };
            worker.RunWorkerAsync();

            
        }
    }
}
