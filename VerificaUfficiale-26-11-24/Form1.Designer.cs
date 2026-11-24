namespace Hu
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
            this.btnRes = new System.Windows.Forms.Button();
            this.nudResOspite = new System.Windows.Forms.NumericUpDown();
            this.nudResCasa = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSav = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSavOspite = new System.Windows.Forms.ComboBox();
            this.cboSavCasa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSavTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSavDate = new System.Windows.Forms.DateTimePicker();
            this.txtSavId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtDelId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFilter = new System.Windows.Forms.Button();
            this.nudGoalNumber = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnMod = new System.Windows.Forms.Button();
            this.nudModOspite = new System.Windows.Forms.NumericUpDown();
            this.nudModCasa = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewPartite = new System.Windows.Forms.Button();
            this.btnViewClassifica = new System.Windows.Forms.Button();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResOspite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResCasa)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalNumber)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModOspite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModCasa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRes);
            this.tabPage1.Controls.Add(this.nudResOspite);
            this.tabPage1.Controls.Add(this.nudResCasa);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtResId);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnSav);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboSavOspite);
            this.tabPage1.Controls.Add(this.cboSavCasa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpSavTime);
            this.tabPage1.Controls.Add(this.dtpSavDate);
            this.tabPage1.Controls.Add(this.txtSavId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(48, 333);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(242, 62);
            this.btnRes.TabIndex = 18;
            this.btnRes.Text = "RISULTATI PARTITA";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // nudResOspite
            // 
            this.nudResOspite.Location = new System.Drawing.Point(158, 307);
            this.nudResOspite.Name = "nudResOspite";
            this.nudResOspite.Size = new System.Drawing.Size(120, 20);
            this.nudResOspite.TabIndex = 17;
            // 
            // nudResCasa
            // 
            this.nudResCasa.Location = new System.Drawing.Point(158, 281);
            this.nudResCasa.Name = "nudResCasa";
            this.nudResCasa.Size = new System.Drawing.Size(120, 20);
            this.nudResCasa.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SQUADRA CASA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "SQUADRA OSPITE";
            // 
            // txtResId
            // 
            this.txtResId.Location = new System.Drawing.Point(133, 241);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(100, 20);
            this.txtResId.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // btnSav
            // 
            this.btnSav.Location = new System.Drawing.Point(38, 149);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(242, 62);
            this.btnSav.TabIndex = 9;
            this.btnSav.Text = "REGISTRA PARTITA";
            this.btnSav.UseVisualStyleBackColor = true;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SQUADRA CASA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SQUADRA OSPITE";
            // 
            // cboSavOspite
            // 
            this.cboSavOspite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavOspite.FormattingEnabled = true;
            this.cboSavOspite.Location = new System.Drawing.Point(159, 122);
            this.cboSavOspite.Name = "cboSavOspite";
            this.cboSavOspite.Size = new System.Drawing.Size(121, 21);
            this.cboSavOspite.TabIndex = 6;
            // 
            // cboSavCasa
            // 
            this.cboSavCasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavCasa.FormattingEnabled = true;
            this.cboSavCasa.Location = new System.Drawing.Point(158, 95);
            this.cboSavCasa.Name = "cboSavCasa";
            this.cboSavCasa.Size = new System.Drawing.Size(121, 21);
            this.cboSavCasa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DATA ORA";
            // 
            // dtpSavTime
            // 
            this.dtpSavTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavTime.Location = new System.Drawing.Point(239, 52);
            this.dtpSavTime.Name = "dtpSavTime";
            this.dtpSavTime.ShowUpDown = true;
            this.dtpSavTime.Size = new System.Drawing.Size(97, 20);
            this.dtpSavTime.TabIndex = 3;
            // 
            // dtpSavDate
            // 
            this.dtpSavDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavDate.Location = new System.Drawing.Point(133, 52);
            this.dtpSavDate.Name = "dtpSavDate";
            this.dtpSavDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSavDate.TabIndex = 2;
            // 
            // txtSavId
            // 
            this.txtSavId.Location = new System.Drawing.Point(133, 19);
            this.txtSavId.Name = "txtSavId";
            this.txtSavId.Size = new System.Drawing.Size(100, 20);
            this.txtSavId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDel);
            this.tabPage2.Controls.Add(this.txtDelId);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(66, 228);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(242, 62);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "ELIMINA UNA PARTITA NON ANCORA DISPUTATA";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtDelId
            // 
            this.txtDelId.Location = new System.Drawing.Point(182, 202);
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(100, 20);
            this.txtDelId.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFilter);
            this.tabPage3.Controls.Add(this.nudGoalNumber);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(365, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(69, 194);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(242, 62);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "PARTITE COMPLETATE CON NUMERO DI GOAL SELEZIONATO";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // nudGoalNumber
            // 
            this.nudGoalNumber.Location = new System.Drawing.Point(224, 168);
            this.nudGoalNumber.Name = "nudGoalNumber";
            this.nudGoalNumber.Size = new System.Drawing.Size(120, 20);
            this.nudGoalNumber.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Partite con questo numero di goal";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnMod);
            this.tabPage4.Controls.Add(this.nudModOspite);
            this.tabPage4.Controls.Add(this.nudModCasa);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtModId);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(365, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(69, 227);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(242, 62);
            this.btnMod.TabIndex = 25;
            this.btnMod.Text = "MODIFICA";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // nudModOspite
            // 
            this.nudModOspite.Location = new System.Drawing.Point(179, 201);
            this.nudModOspite.Name = "nudModOspite";
            this.nudModOspite.Size = new System.Drawing.Size(120, 20);
            this.nudModOspite.TabIndex = 24;
            // 
            // nudModCasa
            // 
            this.nudModCasa.Location = new System.Drawing.Point(179, 175);
            this.nudModCasa.Name = "nudModCasa";
            this.nudModCasa.Size = new System.Drawing.Size(120, 20);
            this.nudModCasa.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "SQUADRA CASA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "SQUADRA OSPITE";
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(154, 135);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(100, 20);
            this.txtModId.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewPartite);
            this.panel1.Controls.Add(this.btnViewClassifica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(373, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnViewPartite
            // 
            this.btnViewPartite.Location = new System.Drawing.Point(18, 48);
            this.btnViewPartite.Name = "btnViewPartite";
            this.btnViewPartite.Size = new System.Drawing.Size(397, 23);
            this.btnViewPartite.TabIndex = 1;
            this.btnViewPartite.Text = "ELENCO PARTITE";
            this.btnViewPartite.UseVisualStyleBackColor = true;
            this.btnViewPartite.Click += new System.EventHandler(this.btnViewPartite_Click);
            // 
            // btnViewClassifica
            // 
            this.btnViewClassifica.Location = new System.Drawing.Point(18, 12);
            this.btnViewClassifica.Name = "btnViewClassifica";
            this.btnViewClassifica.Size = new System.Drawing.Size(397, 23);
            this.btnViewClassifica.TabIndex = 0;
            this.btnViewClassifica.Text = "CLASSIFICA";
            this.btnViewClassifica.UseVisualStyleBackColor = true;
            this.btnViewClassifica.Click += new System.EventHandler(this.btnViewClassifica_Click);
            // 
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewer.Location = new System.Drawing.Point(373, 100);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(427, 350);
            this.dgvViewer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudResOspite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResCasa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalNumber)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModOspite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModCasa)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button btnSav;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSavOspite;
        private System.Windows.Forms.ComboBox cboSavCasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSavTime;
        private System.Windows.Forms.DateTimePicker dtpSavDate;
        private System.Windows.Forms.TextBox txtSavId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtDelId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewPartite;
        private System.Windows.Forms.Button btnViewClassifica;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.NumericUpDown nudResOspite;
        private System.Windows.Forms.NumericUpDown nudResCasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.NumericUpDown nudGoalNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.NumericUpDown nudModOspite;
        private System.Windows.Forms.NumericUpDown nudModCasa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.Label label12;
    }
}

