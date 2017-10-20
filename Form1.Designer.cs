namespace WindowsFormsApplication1
{
    partial class MaxCPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxCPU));
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfProcessors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberofCores = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.CPULevel = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayLoadLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPULevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Processors:";
            // 
            // NumberOfProcessors
            // 
            this.NumberOfProcessors.AutoSize = true;
            this.NumberOfProcessors.Location = new System.Drawing.Point(161, 13);
            this.NumberOfProcessors.Name = "NumberOfProcessors";
            this.NumberOfProcessors.Size = new System.Drawing.Size(0, 13);
            this.NumberOfProcessors.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Cores per CPU:";
            // 
            // NumberofCores
            // 
            this.NumberofCores.AutoSize = true;
            this.NumberofCores.Location = new System.Drawing.Point(161, 39);
            this.NumberofCores.Name = "NumberofCores";
            this.NumberofCores.Size = new System.Drawing.Size(0, 13);
            this.NumberofCores.TabIndex = 3;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(12, 136);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 4;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(93, 136);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // CPULevel
            // 
            this.CPULevel.Location = new System.Drawing.Point(12, 85);
            this.CPULevel.Maximum = 100;
            this.CPULevel.Minimum = 1;
            this.CPULevel.Name = "CPULevel";
            this.CPULevel.Size = new System.Drawing.Size(156, 45);
            this.CPULevel.TabIndex = 7;
            this.CPULevel.Value = 50;
            this.CPULevel.Scroll += new System.EventHandler(this.CPULevel_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPU Utilization";
            // 
            // DisplayLoadLevel
            // 
            this.DisplayLoadLevel.AutoSize = true;
            this.DisplayLoadLevel.Location = new System.Drawing.Point(130, 69);
            this.DisplayLoadLevel.Name = "DisplayLoadLevel";
            this.DisplayLoadLevel.Size = new System.Drawing.Size(19, 13);
            this.DisplayLoadLevel.TabIndex = 9;
            this.DisplayLoadLevel.Text = "50";
            // 
            // MaxCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 171);
            this.Controls.Add(this.DisplayLoadLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPULevel);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.NumberofCores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfProcessors);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(198, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(198, 209);
            this.Name = "MaxCPU";
            this.Text = "MaxCPU";
            this.Load += new System.EventHandler(this.MaxCPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPULevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberOfProcessors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumberofCores;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TrackBar CPULevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisplayLoadLevel;
    }
}

