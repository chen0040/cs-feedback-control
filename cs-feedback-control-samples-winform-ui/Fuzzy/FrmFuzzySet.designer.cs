namespace FeedbackControl.Fuzzy
{
    partial class FrmFuzzySet
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
            this.mFuzzySetView = new FeedbackControl.Fuzzy.UcFuzzySet();
            this.SuspendLayout();
            // 
            // mFuzzySetView
            // 
            this.mFuzzySetView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFuzzySetView.Location = new System.Drawing.Point(0, 0);
            this.mFuzzySetView.Name = "mFuzzySetView";
            this.mFuzzySetView.Size = new System.Drawing.Size(621, 386);
            this.mFuzzySetView.TabIndex = 0;
            // 
            // FrmFuzzySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 386);
            this.Controls.Add(this.mFuzzySetView);
            this.Name = "FrmFuzzySet";
            this.Text = "FrmFuzzySet";
            this.ResumeLayout(false);

        }

        #endregion

        private UcFuzzySet mFuzzySetView;
    }
}