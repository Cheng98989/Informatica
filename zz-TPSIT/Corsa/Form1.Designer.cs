namespace Corsa
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
            this.nudGiri = new System.Windows.Forms.NumericUpDown();
            this.nudAuto = new System.Windows.Forms.NumericUpDown();
            this.lblFineGiro = new System.Windows.Forms.Label();
            this.lblInizioGiro = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnPrepara = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGiri
            // 
            this.nudGiri.Location = new System.Drawing.Point(12, 310);
            this.nudGiri.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGiri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGiri.Name = "nudGiri";
            this.nudGiri.Size = new System.Drawing.Size(93, 20);
            this.nudGiri.TabIndex = 0;
            this.nudGiri.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAuto
            // 
            this.nudAuto.Location = new System.Drawing.Point(12, 336);
            this.nudAuto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAuto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAuto.Name = "nudAuto";
            this.nudAuto.Size = new System.Drawing.Size(93, 20);
            this.nudAuto.TabIndex = 1;
            this.nudAuto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFineGiro
            // 
            this.lblFineGiro.AutoSize = true;
            this.lblFineGiro.Location = new System.Drawing.Point(757, 310);
            this.lblFineGiro.Name = "lblFineGiro";
            this.lblFineGiro.Size = new System.Drawing.Size(31, 13);
            this.lblFineGiro.TabIndex = 2;
            this.lblFineGiro.Text = "FINE";
            // 
            // lblInizioGiro
            // 
            this.lblInizioGiro.AutoSize = true;
            this.lblInizioGiro.Location = new System.Drawing.Point(148, 310);
            this.lblInizioGiro.Name = "lblInizioGiro";
            this.lblInizioGiro.Size = new System.Drawing.Size(39, 13);
            this.lblInizioGiro.TabIndex = 3;
            this.lblInizioGiro.Text = "INIZIO";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 390);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(151, 347);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(637, 95);
            this.lstLog.TabIndex = 5;
            // 
            // btnPrepara
            // 
            this.btnPrepara.Location = new System.Drawing.Point(12, 362);
            this.btnPrepara.Name = "btnPrepara";
            this.btnPrepara.Size = new System.Drawing.Size(93, 23);
            this.btnPrepara.TabIndex = 6;
            this.btnPrepara.Text = "PREPARA";
            this.btnPrepara.UseVisualStyleBackColor = true;
            this.btnPrepara.Click += new System.EventHandler(this.btnPrepara_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 419);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RIPRISTINA";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrepara);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInizioGiro);
            this.Controls.Add(this.lblFineGiro);
            this.Controls.Add(this.nudAuto);
            this.Controls.Add(this.nudGiri);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGiri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGiri;
        private System.Windows.Forms.NumericUpDown nudAuto;
        private System.Windows.Forms.Label lblFineGiro;
        private System.Windows.Forms.Label lblInizioGiro;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnPrepara;
        private System.Windows.Forms.Button btnReset;
    }
}

