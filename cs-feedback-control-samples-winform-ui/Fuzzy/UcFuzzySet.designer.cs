namespace FeedbackControl.Fuzzy
{
    partial class UcFuzzySet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtFuzzySet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtFuzzySet)).BeginInit();
            this.SuspendLayout();
            // 
            // chtFuzzySet
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chtFuzzySet.ChartAreas.Add(chartArea1);
            this.chtFuzzySet.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtFuzzySet.Legends.Add(legend1);
            this.chtFuzzySet.Location = new System.Drawing.Point(0, 0);
            this.chtFuzzySet.Name = "chtFuzzySet";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtFuzzySet.Series.Add(series1);
            this.chtFuzzySet.Size = new System.Drawing.Size(736, 448);
            this.chtFuzzySet.TabIndex = 0;
            this.chtFuzzySet.Text = "chart1";
            // 
            // UcFuzzySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chtFuzzySet);
            this.Name = "UcFuzzySet";
            this.Size = new System.Drawing.Size(736, 448);
            this.Load += new System.EventHandler(this.UcFuzzySetCanvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtFuzzySet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtFuzzySet;
    }
}
