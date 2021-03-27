namespace Optimizer {
    partial class RangePicker {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMin
            // 
            this.nudMin.DecimalPlaces = 3;
            this.nudMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMin.Location = new System.Drawing.Point(0, 0);
            this.nudMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(80, 20);
            this.nudMin.TabIndex = 0;
            // 
            // nudMax
            // 
            this.nudMax.DecimalPlaces = 3;
            this.nudMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMax.Location = new System.Drawing.Point(85, 0);
            this.nudMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(80, 20);
            this.nudMax.TabIndex = 1;
            // 
            // RangePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RangePicker";
            this.Size = new System.Drawing.Size(168, 23);
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
    }
}
