namespace Corsa2
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
            this.Car1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Car2 = new System.Windows.Forms.Label();
            this.Car4 = new System.Windows.Forms.Label();
            this.Car3 = new System.Windows.Forms.Label();
            this.CURVA1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.INIZIO = new System.Windows.Forms.Label();
            this.giri1 = new System.Windows.Forms.Label();
            this.giri2 = new System.Windows.Forms.Label();
            this.giri4 = new System.Windows.Forms.Label();
            this.giri3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Car1
            // 
            this.Car1.AutoSize = true;
            this.Car1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Car1.Location = new System.Drawing.Point(56, 38);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(35, 13);
            this.Car1.TabIndex = 0;
            this.Car1.Text = "label1";
            // 
            // Car2
            // 
            this.Car2.AutoSize = true;
            this.Car2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Car2.Location = new System.Drawing.Point(56, 92);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(35, 13);
            this.Car2.TabIndex = 1;
            this.Car2.Text = "label2";
            // 
            // Car4
            // 
            this.Car4.AutoSize = true;
            this.Car4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Car4.Location = new System.Drawing.Point(56, 183);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(35, 13);
            this.Car4.TabIndex = 3;
            this.Car4.Text = "label3";
            // 
            // Car3
            // 
            this.Car3.AutoSize = true;
            this.Car3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Car3.Location = new System.Drawing.Point(56, 129);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(35, 13);
            this.Car3.TabIndex = 2;
            this.Car3.Text = "label4";
            // 
            // CURVA1
            // 
            this.CURVA1.AutoSize = true;
            this.CURVA1.Location = new System.Drawing.Point(546, 197);
            this.CURVA1.Name = "CURVA1";
            this.CURVA1.Size = new System.Drawing.Size(35, 13);
            this.CURVA1.TabIndex = 4;
            this.CURVA1.Text = "label3";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(156, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // INIZIO
            // 
            this.INIZIO.AutoSize = true;
            this.INIZIO.Location = new System.Drawing.Point(56, 221);
            this.INIZIO.Name = "INIZIO";
            this.INIZIO.Size = new System.Drawing.Size(35, 13);
            this.INIZIO.TabIndex = 6;
            this.INIZIO.Text = "label3";
            // 
            // giri1
            // 
            this.giri1.AutoSize = true;
            this.giri1.Location = new System.Drawing.Point(59, 330);
            this.giri1.Name = "giri1";
            this.giri1.Size = new System.Drawing.Size(35, 13);
            this.giri1.TabIndex = 7;
            this.giri1.Text = "label1";
            // 
            // giri2
            // 
            this.giri2.AutoSize = true;
            this.giri2.Location = new System.Drawing.Point(121, 330);
            this.giri2.Name = "giri2";
            this.giri2.Size = new System.Drawing.Size(35, 13);
            this.giri2.TabIndex = 8;
            this.giri2.Text = "label1";
            // 
            // giri4
            // 
            this.giri4.AutoSize = true;
            this.giri4.Location = new System.Drawing.Point(245, 330);
            this.giri4.Name = "giri4";
            this.giri4.Size = new System.Drawing.Size(35, 13);
            this.giri4.TabIndex = 10;
            this.giri4.Text = "label2";
            // 
            // giri3
            // 
            this.giri3.AutoSize = true;
            this.giri3.Location = new System.Drawing.Point(183, 330);
            this.giri3.Name = "giri3";
            this.giri3.Size = new System.Drawing.Size(35, 13);
            this.giri3.TabIndex = 9;
            this.giri3.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giri4);
            this.Controls.Add(this.giri3);
            this.Controls.Add(this.giri2);
            this.Controls.Add(this.giri1);
            this.Controls.Add(this.INIZIO);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.CURVA1);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Car1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Car2;
        private System.Windows.Forms.Label Car4;
        private System.Windows.Forms.Label Car3;
        private System.Windows.Forms.Label CURVA1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label INIZIO;
        private System.Windows.Forms.Label giri1;
        private System.Windows.Forms.Label giri2;
        private System.Windows.Forms.Label giri4;
        private System.Windows.Forms.Label giri3;
    }
}

