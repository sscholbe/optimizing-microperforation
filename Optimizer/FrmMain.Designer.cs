namespace Optimizer {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlPlot = new System.Windows.Forms.Panel();
            this.lblBest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clbFrequencies = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudReduceVariance = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.btnSavePlot = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.rngCavityDepth = new Optimizer.RangePicker();
            this.rngThickness = new Optimizer.RangePicker();
            this.rngHoleRepeatDistance = new Optimizer.RangePicker();
            this.rngHoleDiameter = new Optimizer.RangePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudReduceVariance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlot
            // 
            this.pnlPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlot.Location = new System.Drawing.Point(12, 26);
            this.pnlPlot.Name = "pnlPlot";
            this.pnlPlot.Size = new System.Drawing.Size(400, 170);
            this.pnlPlot.TabIndex = 0;
            this.pnlPlot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlot_Paint);
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.BackColor = System.Drawing.SystemColors.Control;
            this.lblBest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBest.Location = new System.Drawing.Point(12, 9);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(283, 13);
            this.lblBest.TabIndex = 0;
            this.lblBest.Text = "d = 0.000mm, b = 0.000mm, t = 0.000mm, D = 0.000mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hole diameter (d)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hole repeat distance (b)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thickness (t)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cavity depth (D)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Frequencies";
            // 
            // clbFrequencies
            // 
            this.clbFrequencies.FormattingEnabled = true;
            this.clbFrequencies.Location = new System.Drawing.Point(182, 212);
            this.clbFrequencies.Name = "clbFrequencies";
            this.clbFrequencies.Size = new System.Drawing.Size(73, 132);
            this.clbFrequencies.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reduce variance";
            // 
            // nudReduceVariance
            // 
            this.nudReduceVariance.DecimalPlaces = 2;
            this.nudReduceVariance.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudReduceVariance.Location = new System.Drawing.Point(264, 212);
            this.nudReduceVariance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudReduceVariance.Name = "nudReduceVariance";
            this.nudReduceVariance.Size = new System.Drawing.Size(65, 21);
            this.nudReduceVariance.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(264, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 1);
            this.panel1.TabIndex = 14;
            // 
            // btnOptimize
            // 
            this.btnOptimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOptimize.Location = new System.Drawing.Point(264, 251);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(148, 35);
            this.btnOptimize.TabIndex = 15;
            this.btnOptimize.Text = "&Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // btnSavePlot
            // 
            this.btnSavePlot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePlot.Location = new System.Drawing.Point(264, 292);
            this.btnSavePlot.Name = "btnSavePlot";
            this.btnSavePlot.Size = new System.Drawing.Size(148, 23);
            this.btnSavePlot.TabIndex = 16;
            this.btnSavePlot.Text = "&Save plot...";
            this.btnSavePlot.UseVisualStyleBackColor = true;
            this.btnSavePlot.Click += new System.EventHandler(this.btnSavePlot_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(264, 321);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(148, 23);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 17;
            // 
            // rngCavityDepth
            // 
            this.rngCavityDepth.AutoSize = true;
            this.rngCavityDepth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rngCavityDepth.Location = new System.Drawing.Point(11, 323);
            this.rngCavityDepth.Margin = new System.Windows.Forms.Padding(0);
            this.rngCavityDepth.Max = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rngCavityDepth.Min = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rngCavityDepth.Name = "rngCavityDepth";
            this.rngCavityDepth.Size = new System.Drawing.Size(168, 24);
            this.rngCavityDepth.TabIndex = 9;
            // 
            // rngThickness
            // 
            this.rngThickness.AutoSize = true;
            this.rngThickness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rngThickness.Location = new System.Drawing.Point(11, 286);
            this.rngThickness.Margin = new System.Windows.Forms.Padding(0);
            this.rngThickness.Max = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rngThickness.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rngThickness.Name = "rngThickness";
            this.rngThickness.Size = new System.Drawing.Size(168, 24);
            this.rngThickness.TabIndex = 7;
            // 
            // rngHoleRepeatDistance
            // 
            this.rngHoleRepeatDistance.AutoSize = true;
            this.rngHoleRepeatDistance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rngHoleRepeatDistance.Location = new System.Drawing.Point(11, 250);
            this.rngHoleRepeatDistance.Margin = new System.Windows.Forms.Padding(0);
            this.rngHoleRepeatDistance.Max = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rngHoleRepeatDistance.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rngHoleRepeatDistance.Name = "rngHoleRepeatDistance";
            this.rngHoleRepeatDistance.Size = new System.Drawing.Size(168, 24);
            this.rngHoleRepeatDistance.TabIndex = 5;
            // 
            // rngHoleDiameter
            // 
            this.rngHoleDiameter.AutoSize = true;
            this.rngHoleDiameter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rngHoleDiameter.Location = new System.Drawing.Point(11, 212);
            this.rngHoleDiameter.Margin = new System.Windows.Forms.Padding(0);
            this.rngHoleDiameter.Max = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rngHoleDiameter.Min = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.rngHoleDiameter.Name = "rngHoleDiameter";
            this.rngHoleDiameter.Size = new System.Drawing.Size(168, 24);
            this.rngHoleDiameter.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 356);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnSavePlot);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudReduceVariance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clbFrequencies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rngCavityDepth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rngThickness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rngHoleRepeatDistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rngHoleDiameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPlot);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimize microperforation";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudReduceVariance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlot;
        private System.Windows.Forms.Label label2;
        private Optimizer.RangePicker rngHoleDiameter;
        private Optimizer.RangePicker rngHoleRepeatDistance;
        private System.Windows.Forms.Label label3;
        private Optimizer.RangePicker rngThickness;
        private System.Windows.Forms.Label label4;
        private Optimizer.RangePicker rngCavityDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbFrequencies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudReduceVariance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.Button btnSavePlot;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblBest;
    }
}