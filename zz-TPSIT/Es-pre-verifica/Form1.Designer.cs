namespace Es_pre_verifica
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
            this.nudSportelli = new System.Windows.Forms.NumericUpDown();
            this.nudClienti = new System.Windows.Forms.NumericUpDown();
            this.btnApri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSportelli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSportelli
            // 
            this.nudSportelli.Location = new System.Drawing.Point(308, 37);
            this.nudSportelli.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSportelli.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSportelli.Name = "nudSportelli";
            this.nudSportelli.Size = new System.Drawing.Size(120, 20);
            this.nudSportelli.TabIndex = 0;
            this.nudSportelli.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudClienti
            // 
            this.nudClienti.Location = new System.Drawing.Point(308, 63);
            this.nudClienti.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudClienti.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudClienti.Name = "nudClienti";
            this.nudClienti.Size = new System.Drawing.Size(120, 20);
            this.nudClienti.TabIndex = 1;
            this.nudClienti.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnApri
            // 
            this.btnApri.Location = new System.Drawing.Point(308, 98);
            this.btnApri.Name = "btnApri";
            this.btnApri.Size = new System.Drawing.Size(120, 23);
            this.btnApri.TabIndex = 2;
            this.btnApri.Text = "APRI UFFICIO";
            this.btnApri.UseVisualStyleBackColor = true;
            this.btnApri.Click += new System.EventHandler(this.btnApri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApri);
            this.Controls.Add(this.nudClienti);
            this.Controls.Add(this.nudSportelli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSportelli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSportelli;
        private System.Windows.Forms.NumericUpDown nudClienti;
        private System.Windows.Forms.Button btnApri;
    }
}

