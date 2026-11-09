namespace CorsaAuto
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
            this.btnStart = new System.Windows.Forms.Button();
            this.Car1 = new System.Windows.Forms.Label();
            this.Car2 = new System.Windows.Forms.Label();
            this.Car4 = new System.Windows.Forms.Label();
            this.Car3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(909, 426);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Car1
            // 
            this.Car1.Location = new System.Drawing.Point(43, 34);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(64, 31);
            this.Car1.TabIndex = 1;
            this.Car1.Text = "label1";
            // 
            // Car2
            // 
            this.Car2.Location = new System.Drawing.Point(43, 58);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(64, 31);
            this.Car2.TabIndex = 2;
            this.Car2.Text = "label2";
            // 
            // Car4
            // 
            this.Car4.Location = new System.Drawing.Point(43, 113);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(64, 21);
            this.Car4.TabIndex = 4;
            this.Car4.Text = "label4";
            // 
            // Car3
            // 
            this.Car3.Location = new System.Drawing.Point(43, 87);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(64, 21);
            this.Car3.TabIndex = 3;
            this.Car3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FINE GIRO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Car1;
        private System.Windows.Forms.Label Car2;
        private System.Windows.Forms.Label Car4;
        private System.Windows.Forms.Label Car3;
        private System.Windows.Forms.Label label1;
    }
}

