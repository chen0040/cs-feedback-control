namespace FeedbackControl.AnalyzeGUI
{
    partial class FrmMainMenu
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
            this.btnPID = new System.Windows.Forms.Button();
            this.btnFuzzy = new System.Windows.Forms.Button();
            this.btnKalman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPID
            // 
            this.btnPID.Location = new System.Drawing.Point(28, 49);
            this.btnPID.Name = "btnPID";
            this.btnPID.Size = new System.Drawing.Size(161, 176);
            this.btnPID.TabIndex = 0;
            this.btnPID.Text = "PID Controller";
            this.btnPID.UseVisualStyleBackColor = true;
            this.btnPID.Click += new System.EventHandler(this.btnPID_Click);
            // 
            // btnFuzzy
            // 
            this.btnFuzzy.Location = new System.Drawing.Point(220, 49);
            this.btnFuzzy.Name = "btnFuzzy";
            this.btnFuzzy.Size = new System.Drawing.Size(161, 176);
            this.btnFuzzy.TabIndex = 0;
            this.btnFuzzy.Text = "Fuzzy Controller";
            this.btnFuzzy.UseVisualStyleBackColor = true;
            // 
            // btnKalman
            // 
            this.btnKalman.Location = new System.Drawing.Point(412, 49);
            this.btnKalman.Name = "btnKalman";
            this.btnKalman.Size = new System.Drawing.Size(161, 176);
            this.btnKalman.TabIndex = 0;
            this.btnKalman.Text = "Kalman Filter";
            this.btnKalman.UseVisualStyleBackColor = true;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 283);
            this.Controls.Add(this.btnKalman);
            this.Controls.Add(this.btnFuzzy);
            this.Controls.Add(this.btnPID);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPID;
        private System.Windows.Forms.Button btnFuzzy;
        private System.Windows.Forms.Button btnKalman;
    }
}