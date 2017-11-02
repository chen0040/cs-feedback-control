namespace FeedbackControl.PID.AnalyzeGUI
{
    partial class FrmAnalyzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chtTimeSeries = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTimeSeries = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.wbProblem = new System.Windows.Forms.WebBrowser();
            this.txtNoiseSigma = new System.Windows.Forms.TextBox();
            this.txtNoiseMean = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.cboProblem = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimeStep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkDisplayControllerStateValue = new System.Windows.Forms.CheckBox();
            this.chkDisplayControllerStateVariable = new System.Windows.Forms.CheckBox();
            this.chkDisplayNoise = new System.Windows.Forms.CheckBox();
            this.chkDisplaySetpoints = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSeries)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 605);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chtTimeSeries);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Time Series";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chtTimeSeries
            // 
            this.chtTimeSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtTimeSeries.Location = new System.Drawing.Point(3, 3);
            this.chtTimeSeries.Name = "chtTimeSeries";
            this.chtTimeSeries.ScrollGrace = 0D;
            this.chtTimeSeries.ScrollMaxX = 0D;
            this.chtTimeSeries.ScrollMaxY = 0D;
            this.chtTimeSeries.ScrollMaxY2 = 0D;
            this.chtTimeSeries.ScrollMinX = 0D;
            this.chtTimeSeries.ScrollMinY = 0D;
            this.chtTimeSeries.ScrollMinY2 = 0D;
            this.chtTimeSeries.Size = new System.Drawing.Size(605, 573);
            this.chtTimeSeries.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTimeSeries);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time Series Tabular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTimeSeries
            // 
            this.dgvTimeSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeSeries.Location = new System.Drawing.Point(3, 3);
            this.dgvTimeSeries.Name = "dgvTimeSeries";
            this.dgvTimeSeries.Size = new System.Drawing.Size(605, 573);
            this.dgvTimeSeries.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.wbProblem);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(611, 579);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Problem";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // wbProblem
            // 
            this.wbProblem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbProblem.Location = new System.Drawing.Point(0, 0);
            this.wbProblem.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbProblem.Name = "wbProblem";
            this.wbProblem.Size = new System.Drawing.Size(611, 579);
            this.wbProblem.TabIndex = 0;
            // 
            // txtNoiseSigma
            // 
            this.txtNoiseSigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiseSigma.Location = new System.Drawing.Point(76, 344);
            this.txtNoiseSigma.Name = "txtNoiseSigma";
            this.txtNoiseSigma.Size = new System.Drawing.Size(108, 20);
            this.txtNoiseSigma.TabIndex = 3;
            this.txtNoiseSigma.Text = "0";
            // 
            // txtNoiseMean
            // 
            this.txtNoiseMean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiseMean.Location = new System.Drawing.Point(76, 318);
            this.txtNoiseMean.Name = "txtNoiseMean";
            this.txtNoiseMean.Size = new System.Drawing.Size(108, 20);
            this.txtNoiseMean.TabIndex = 3;
            this.txtNoiseMean.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(12, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvaluate.Location = new System.Drawing.Point(12, 134);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(172, 23);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // cboProblem
            // 
            this.cboProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProblem.FormattingEnabled = true;
            this.cboProblem.Location = new System.Drawing.Point(12, 84);
            this.cboProblem.Name = "cboProblem";
            this.cboProblem.Size = new System.Drawing.Size(172, 21);
            this.cboProblem.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(821, 605);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDisplaySetpoints);
            this.panel1.Controls.Add(this.chkDisplayNoise);
            this.panel1.Controls.Add(this.chkDisplayControllerStateVariable);
            this.panel1.Controls.Add(this.chkDisplayControllerStateValue);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNoiseSigma);
            this.panel1.Controls.Add(this.txtKd);
            this.panel1.Controls.Add(this.txtTimeStep);
            this.panel1.Controls.Add(this.txtKi);
            this.panel1.Controls.Add(this.txtEndTime);
            this.panel1.Controls.Add(this.txtKp);
            this.panel1.Controls.Add(this.txtStartTime);
            this.panel1.Controls.Add(this.txtNoiseMean);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEvaluate);
            this.panel1.Controls.Add(this.cboProblem);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboAlgorithm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 605);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Progress:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Command:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Problem:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAlgorithm
            // 
            this.cboAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlgorithm.FormattingEnabled = true;
            this.cboAlgorithm.Location = new System.Drawing.Point(12, 34);
            this.cboAlgorithm.Name = "cboAlgorithm";
            this.cboAlgorithm.Size = new System.Drawing.Size(172, 21);
            this.cboAlgorithm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartTime.Location = new System.Drawing.Point(76, 211);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(108, 20);
            this.txtStartTime.TabIndex = 3;
            this.txtStartTime.Text = "0";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndTime.Location = new System.Drawing.Point(76, 237);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(108, 20);
            this.txtEndTime.TabIndex = 3;
            this.txtEndTime.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "End Time:";
            // 
            // txtTimeStep
            // 
            this.txtTimeStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeStep.Location = new System.Drawing.Point(76, 263);
            this.txtTimeStep.Name = "txtTimeStep";
            this.txtTimeStep.Size = new System.Drawing.Size(108, 20);
            this.txtTimeStep.TabIndex = 3;
            this.txtTimeStep.Text = "0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Time Step:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "mu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "sigma:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Noise:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Display:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkDisplayControllerStateValue
            // 
            this.chkDisplayControllerStateValue.AutoSize = true;
            this.chkDisplayControllerStateValue.Checked = true;
            this.chkDisplayControllerStateValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayControllerStateValue.Location = new System.Drawing.Point(12, 405);
            this.chkDisplayControllerStateValue.Name = "chkDisplayControllerStateValue";
            this.chkDisplayControllerStateValue.Size = new System.Drawing.Size(165, 17);
            this.chkDisplayControllerStateValue.TabIndex = 5;
            this.chkDisplayControllerStateValue.Text = "Display Controller State Value";
            this.chkDisplayControllerStateValue.UseVisualStyleBackColor = true;
            // 
            // chkDisplayControllerStateVariable
            // 
            this.chkDisplayControllerStateVariable.AutoSize = true;
            this.chkDisplayControllerStateVariable.Location = new System.Drawing.Point(12, 428);
            this.chkDisplayControllerStateVariable.Name = "chkDisplayControllerStateVariable";
            this.chkDisplayControllerStateVariable.Size = new System.Drawing.Size(176, 17);
            this.chkDisplayControllerStateVariable.TabIndex = 5;
            this.chkDisplayControllerStateVariable.Text = "Display Controller State Variable";
            this.chkDisplayControllerStateVariable.UseVisualStyleBackColor = true;
            // 
            // chkDisplayNoise
            // 
            this.chkDisplayNoise.AutoSize = true;
            this.chkDisplayNoise.Location = new System.Drawing.Point(12, 451);
            this.chkDisplayNoise.Name = "chkDisplayNoise";
            this.chkDisplayNoise.Size = new System.Drawing.Size(90, 17);
            this.chkDisplayNoise.TabIndex = 5;
            this.chkDisplayNoise.Text = "Display Noise";
            this.chkDisplayNoise.UseVisualStyleBackColor = true;
            // 
            // chkDisplaySetpoints
            // 
            this.chkDisplaySetpoints.AutoSize = true;
            this.chkDisplaySetpoints.Checked = true;
            this.chkDisplaySetpoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplaySetpoints.Location = new System.Drawing.Point(12, 474);
            this.chkDisplaySetpoints.Name = "chkDisplaySetpoints";
            this.chkDisplaySetpoints.Size = new System.Drawing.Size(110, 17);
            this.chkDisplaySetpoints.TabIndex = 5;
            this.chkDisplaySetpoints.Text = "Display Set points";
            this.chkDisplaySetpoints.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "PID Controller Design:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKp
            // 
            this.txtKp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKp.Location = new System.Drawing.Point(76, 523);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(108, 20);
            this.txtKp.TabIndex = 3;
            this.txtKp.Text = "0.5";
            // 
            // txtKi
            // 
            this.txtKi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKi.Location = new System.Drawing.Point(76, 549);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(108, 20);
            this.txtKi.TabIndex = 3;
            this.txtKi.Text = "0.5";
            // 
            // txtKd
            // 
            this.txtKd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKd.Location = new System.Drawing.Point(76, 575);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(108, 20);
            this.txtKd.TabIndex = 3;
            this.txtKd.Text = "0.5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "k_P:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "k_I:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 578);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "k_D:";
            // 
            // FrmAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 605);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAnalyzer";
            this.Text = "PID Controller Analyzer";
            this.Load += new System.EventHandler(this.FrmAnalyzer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSeries)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl chtTimeSeries;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTimeSeries;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser wbProblem;
        private System.Windows.Forms.TextBox txtNoiseSigma;
        private System.Windows.Forms.TextBox txtNoiseMean;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.ComboBox cboProblem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeStep;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkDisplaySetpoints;
        private System.Windows.Forms.CheckBox chkDisplayNoise;
        private System.Windows.Forms.CheckBox chkDisplayControllerStateVariable;
        private System.Windows.Forms.CheckBox chkDisplayControllerStateValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label12;

    }
}

