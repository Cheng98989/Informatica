namespace DownloadsRace
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.btnPrepara = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(12, 12);
            this.nudCount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 20);
            this.nudCount.TabIndex = 0;
            this.nudCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(12, 38);
            this.nudSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 1;
            this.nudSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnPrepara
            // 
            this.btnPrepara.Location = new System.Drawing.Point(12, 65);
            this.btnPrepara.Name = "btnPrepara";
            this.btnPrepara.Size = new System.Drawing.Size(120, 23);
            this.btnPrepara.TabIndex = 2;
            this.btnPrepara.Text = "PREPARA";
            this.btnPrepara.UseVisualStyleBackColor = true;
            this.btnPrepara.Click += new System.EventHandler(this.btnPrepara_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "INIZIA";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(162, 12);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(593, 108);
            this.lstLog.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(12, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPrepara);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.nudCount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Button btnPrepara;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnReset;
    }
}

