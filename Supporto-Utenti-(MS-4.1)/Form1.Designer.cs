namespace Supporto_Utenti__MS_4._1_
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSavSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSavId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSavDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSavUrgency = new System.Windows.Forms.TextBox();
            this.dtpSavReqDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSavResDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSavReqTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSavResTime = new System.Windows.Forms.DateTimePicker();
            this.cboSavDepartment = new System.Windows.Forms.ComboBox();
            this.chkSavResolved = new System.Windows.Forms.CheckBox();
            this.dgvSav = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSav)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSav);
            this.tabPage1.Controls.Add(this.chkSavResolved);
            this.tabPage1.Controls.Add(this.cboSavDepartment);
            this.tabPage1.Controls.Add(this.dtpSavResTime);
            this.tabPage1.Controls.Add(this.dtpSavReqTime);
            this.tabPage1.Controls.Add(this.dtpSavResDate);
            this.tabPage1.Controls.Add(this.dtpSavReqDate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtSavUrgency);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSavDescription);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSavEmail);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSavId);
            this.tabPage1.Controls.Add(this.btnSavSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSavSave
            // 
            this.btnSavSave.Location = new System.Drawing.Point(11, 268);
            this.btnSavSave.Name = "btnSavSave";
            this.btnSavSave.Size = new System.Drawing.Size(301, 53);
            this.btnSavSave.TabIndex = 0;
            this.btnSavSave.Text = "button1";
            this.btnSavSave.UseVisualStyleBackColor = true;
            this.btnSavSave.Click += new System.EventHandler(this.btnSavSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSavId
            // 
            this.txtSavId.Location = new System.Drawing.Point(126, 50);
            this.txtSavId.Name = "txtSavId";
            this.txtSavId.Size = new System.Drawing.Size(186, 20);
            this.txtSavId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EMAIL";
            // 
            // txtSavEmail
            // 
            this.txtSavEmail.Location = new System.Drawing.Point(126, 76);
            this.txtSavEmail.Name = "txtSavEmail";
            this.txtSavEmail.Size = new System.Drawing.Size(186, 20);
            this.txtSavEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIZIONE";
            // 
            // txtSavDescription
            // 
            this.txtSavDescription.Location = new System.Drawing.Point(126, 128);
            this.txtSavDescription.Name = "txtSavDescription";
            this.txtSavDescription.Size = new System.Drawing.Size(186, 20);
            this.txtSavDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "REPARTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DATA RISOLUZIONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATA RICHIESTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "URGENZA";
            // 
            // txtSavUrgency
            // 
            this.txtSavUrgency.Location = new System.Drawing.Point(126, 154);
            this.txtSavUrgency.Name = "txtSavUrgency";
            this.txtSavUrgency.Size = new System.Drawing.Size(186, 20);
            this.txtSavUrgency.TabIndex = 9;
            // 
            // dtpSavReqDate
            // 
            this.dtpSavReqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavReqDate.Location = new System.Drawing.Point(126, 181);
            this.dtpSavReqDate.Name = "dtpSavReqDate";
            this.dtpSavReqDate.Size = new System.Drawing.Size(85, 20);
            this.dtpSavReqDate.TabIndex = 15;
            // 
            // dtpSavResDate
            // 
            this.dtpSavResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavResDate.Location = new System.Drawing.Point(126, 242);
            this.dtpSavResDate.Name = "dtpSavResDate";
            this.dtpSavResDate.Size = new System.Drawing.Size(85, 20);
            this.dtpSavResDate.TabIndex = 16;
            // 
            // dtpSavReqTime
            // 
            this.dtpSavReqTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavReqTime.Location = new System.Drawing.Point(217, 181);
            this.dtpSavReqTime.Name = "dtpSavReqTime";
            this.dtpSavReqTime.Size = new System.Drawing.Size(95, 20);
            this.dtpSavReqTime.TabIndex = 17;
            this.dtpSavReqTime.Value = new System.DateTime(2026, 10, 6, 10, 33, 0, 0);
            // 
            // dtpSavResTime
            // 
            this.dtpSavResTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavResTime.Location = new System.Drawing.Point(217, 242);
            this.dtpSavResTime.Name = "dtpSavResTime";
            this.dtpSavResTime.Size = new System.Drawing.Size(95, 20);
            this.dtpSavResTime.TabIndex = 18;
            // 
            // cboSavDepartment
            // 
            this.cboSavDepartment.FormattingEnabled = true;
            this.cboSavDepartment.Location = new System.Drawing.Point(126, 101);
            this.cboSavDepartment.Name = "cboSavDepartment";
            this.cboSavDepartment.Size = new System.Drawing.Size(186, 21);
            this.cboSavDepartment.TabIndex = 19;
            // 
            // chkSavResolved
            // 
            this.chkSavResolved.AutoSize = true;
            this.chkSavResolved.Location = new System.Drawing.Point(126, 213);
            this.chkSavResolved.Name = "chkSavResolved";
            this.chkSavResolved.Size = new System.Drawing.Size(73, 17);
            this.chkSavResolved.TabIndex = 20;
            this.chkSavResolved.Text = "RISOLTO";
            this.chkSavResolved.UseVisualStyleBackColor = true;
            // 
            // dgvSav
            // 
            this.dgvSav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSav.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvSav.Location = new System.Drawing.Point(318, 3);
            this.dgvSav.Name = "dgvSav";
            this.dgvSav.Size = new System.Drawing.Size(471, 418);
            this.dgvSav.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSavSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSavUrgency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSavDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSavId;
        private System.Windows.Forms.DataGridView dgvSav;
        private System.Windows.Forms.CheckBox chkSavResolved;
        private System.Windows.Forms.ComboBox cboSavDepartment;
        private System.Windows.Forms.DateTimePicker dtpSavResTime;
        private System.Windows.Forms.DateTimePicker dtpSavReqTime;
        private System.Windows.Forms.DateTimePicker dtpSavResDate;
        private System.Windows.Forms.DateTimePicker dtpSavReqDate;
    }
}

