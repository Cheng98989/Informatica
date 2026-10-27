namespace _26_1_25_SimuVerificaTeorica
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
            this.dtpSavTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSavDate = new System.Windows.Forms.DateTimePicker();
            this.btnSav = new System.Windows.Forms.Button();
            this.txtSavNote = new System.Windows.Forms.TextBox();
            this.txtSavIdNole = new System.Windows.Forms.TextBox();
            this.txtSavIdClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSavType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpModTime = new System.Windows.Forms.DateTimePicker();
            this.dtpModData = new System.Windows.Forms.DateTimePicker();
            this.btnMod = new System.Windows.Forms.Button();
            this.txtModKilo = new System.Windows.Forms.TextBox();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.cboViewType = new System.Windows.Forms.ComboBox();
            this.rdoViewAsce = new System.Windows.Forms.RadioButton();
            this.rdoViewDesc = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtDelId = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtCalcMin = new System.Windows.Forms.TextBox();
            this.txtCalcMax = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCalcOutput = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dtpTotMinTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTotMinDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTotMaxTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTotMaxDate = new System.Windows.Forms.DateTimePicker();
            this.lstTot = new System.Windows.Forms.ListBox();
            this.btnTotale = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblStatsOutput = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnNonRiconsegnati = new System.Windows.Forms.Button();
            this.dgvNonRiconsegnati = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonRiconsegnati)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpSavTime);
            this.tabPage1.Controls.Add(this.dtpSavDate);
            this.tabPage1.Controls.Add(this.btnSav);
            this.tabPage1.Controls.Add(this.txtSavNote);
            this.tabPage1.Controls.Add(this.txtSavIdNole);
            this.tabPage1.Controls.Add(this.txtSavIdClient);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cboSavType);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpSavTime
            // 
            this.dtpSavTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavTime.Location = new System.Drawing.Point(186, 113);
            this.dtpSavTime.Name = "dtpSavTime";
            this.dtpSavTime.ShowUpDown = true;
            this.dtpSavTime.Size = new System.Drawing.Size(69, 20);
            this.dtpSavTime.TabIndex = 12;
            // 
            // dtpSavDate
            // 
            this.dtpSavDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavDate.Location = new System.Drawing.Point(111, 113);
            this.dtpSavDate.Name = "dtpSavDate";
            this.dtpSavDate.Size = new System.Drawing.Size(69, 20);
            this.dtpSavDate.TabIndex = 11;
            // 
            // btnSav
            // 
            this.btnSav.Location = new System.Drawing.Point(47, 174);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(207, 23);
            this.btnSav.TabIndex = 10;
            this.btnSav.Text = "button1";
            this.btnSav.UseVisualStyleBackColor = true;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // txtSavNote
            // 
            this.txtSavNote.Location = new System.Drawing.Point(111, 139);
            this.txtSavNote.Name = "txtSavNote";
            this.txtSavNote.Size = new System.Drawing.Size(143, 20);
            this.txtSavNote.TabIndex = 8;
            // 
            // txtSavIdNole
            // 
            this.txtSavIdNole.Location = new System.Drawing.Point(111, 38);
            this.txtSavIdNole.Name = "txtSavIdNole";
            this.txtSavIdNole.Size = new System.Drawing.Size(143, 20);
            this.txtSavIdNole.TabIndex = 7;
            // 
            // txtSavIdClient
            // 
            this.txtSavIdClient.Location = new System.Drawing.Point(111, 63);
            this.txtSavIdClient.Name = "txtSavIdClient";
            this.txtSavIdClient.Size = new System.Drawing.Size(143, 20);
            this.txtSavIdClient.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
            // 
            // cboSavType
            // 
            this.cboSavType.FormattingEnabled = true;
            this.cboSavType.Location = new System.Drawing.Point(111, 88);
            this.cboSavType.Name = "cboSavType";
            this.cboSavType.Size = new System.Drawing.Size(143, 21);
            this.cboSavType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "DataRitiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Clienti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID noleggio";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpModTime);
            this.tabPage2.Controls.Add(this.dtpModData);
            this.tabPage2.Controls.Add(this.btnMod);
            this.tabPage2.Controls.Add(this.txtModKilo);
            this.tabPage2.Controls.Add(this.txtModId);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpModTime
            // 
            this.dtpModTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModTime.Location = new System.Drawing.Point(433, 208);
            this.dtpModTime.Name = "dtpModTime";
            this.dtpModTime.ShowUpDown = true;
            this.dtpModTime.Size = new System.Drawing.Size(69, 20);
            this.dtpModTime.TabIndex = 24;
            // 
            // dtpModData
            // 
            this.dtpModData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModData.Location = new System.Drawing.Point(358, 208);
            this.dtpModData.Name = "dtpModData";
            this.dtpModData.Size = new System.Drawing.Size(69, 20);
            this.dtpModData.TabIndex = 23;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(294, 269);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(207, 23);
            this.btnMod.TabIndex = 22;
            this.btnMod.Text = "button1";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // txtModKilo
            // 
            this.txtModKilo.Location = new System.Drawing.Point(358, 234);
            this.txtModKilo.Name = "txtModKilo";
            this.txtModKilo.Size = new System.Drawing.Size(143, 20);
            this.txtModKilo.TabIndex = 21;
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(358, 133);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(143, 20);
            this.txtModId.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kilometri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "DataRitiro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID noleggio";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdoViewDesc);
            this.tabPage3.Controls.Add(this.rdoViewAsce);
            this.tabPage3.Controls.Add(this.cboViewType);
            this.tabPage3.Controls.Add(this.btnView);
            this.tabPage3.Controls.Add(this.dgvView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvView.Location = new System.Drawing.Point(3, 271);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(786, 150);
            this.dgvView.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(112, 82);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "button1";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cboViewType
            // 
            this.cboViewType.FormattingEnabled = true;
            this.cboViewType.Location = new System.Drawing.Point(224, 82);
            this.cboViewType.Name = "cboViewType";
            this.cboViewType.Size = new System.Drawing.Size(121, 21);
            this.cboViewType.TabIndex = 2;
            // 
            // rdoViewAsce
            // 
            this.rdoViewAsce.AutoSize = true;
            this.rdoViewAsce.Location = new System.Drawing.Point(112, 112);
            this.rdoViewAsce.Name = "rdoViewAsce";
            this.rdoViewAsce.Size = new System.Drawing.Size(85, 17);
            this.rdoViewAsce.TabIndex = 3;
            this.rdoViewAsce.TabStop = true;
            this.rdoViewAsce.Text = "radioButton1";
            this.rdoViewAsce.UseVisualStyleBackColor = true;
            // 
            // rdoViewDesc
            // 
            this.rdoViewDesc.AutoSize = true;
            this.rdoViewDesc.Location = new System.Drawing.Point(112, 135);
            this.rdoViewDesc.Name = "rdoViewDesc";
            this.rdoViewDesc.Size = new System.Drawing.Size(85, 17);
            this.rdoViewDesc.TabIndex = 4;
            this.rdoViewDesc.TabStop = true;
            this.rdoViewDesc.Text = "radioButton2";
            this.rdoViewDesc.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDel);
            this.tabPage4.Controls.Add(this.txtDelId);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtDelId
            // 
            this.txtDelId.Location = new System.Drawing.Point(269, 131);
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(100, 20);
            this.txtDelId.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(269, 158);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "button1";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblCalcOutput);
            this.tabPage5.Controls.Add(this.btnCalc);
            this.tabPage5.Controls.Add(this.txtCalcMax);
            this.tabPage5.Controls.Add(this.txtCalcMin);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtCalcMin
            // 
            this.txtCalcMin.Location = new System.Drawing.Point(217, 77);
            this.txtCalcMin.Name = "txtCalcMin";
            this.txtCalcMin.Size = new System.Drawing.Size(100, 20);
            this.txtCalcMin.TabIndex = 0;
            // 
            // txtCalcMax
            // 
            this.txtCalcMax.Location = new System.Drawing.Point(217, 103);
            this.txtCalcMax.Name = "txtCalcMax";
            this.txtCalcMax.Size = new System.Drawing.Size(100, 20);
            this.txtCalcMax.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(217, 140);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "button1";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblCalcOutput
            // 
            this.lblCalcOutput.AutoSize = true;
            this.lblCalcOutput.Location = new System.Drawing.Point(217, 187);
            this.lblCalcOutput.Name = "lblCalcOutput";
            this.lblCalcOutput.Size = new System.Drawing.Size(35, 13);
            this.lblCalcOutput.TabIndex = 3;
            this.lblCalcOutput.Text = "label6";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnTotale);
            this.tabPage6.Controls.Add(this.lstTot);
            this.tabPage6.Controls.Add(this.dtpTotMaxTime);
            this.tabPage6.Controls.Add(this.dtpTotMaxDate);
            this.tabPage6.Controls.Add(this.dtpTotMinTime);
            this.tabPage6.Controls.Add(this.dtpTotMinDate);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(792, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dtpTotMinTime
            // 
            this.dtpTotMinTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTotMinTime.Location = new System.Drawing.Point(298, 111);
            this.dtpTotMinTime.Name = "dtpTotMinTime";
            this.dtpTotMinTime.ShowUpDown = true;
            this.dtpTotMinTime.Size = new System.Drawing.Size(69, 20);
            this.dtpTotMinTime.TabIndex = 14;
            // 
            // dtpTotMinDate
            // 
            this.dtpTotMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTotMinDate.Location = new System.Drawing.Point(223, 111);
            this.dtpTotMinDate.Name = "dtpTotMinDate";
            this.dtpTotMinDate.Size = new System.Drawing.Size(69, 20);
            this.dtpTotMinDate.TabIndex = 13;
            // 
            // dtpTotMaxTime
            // 
            this.dtpTotMaxTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTotMaxTime.Location = new System.Drawing.Point(298, 137);
            this.dtpTotMaxTime.Name = "dtpTotMaxTime";
            this.dtpTotMaxTime.ShowUpDown = true;
            this.dtpTotMaxTime.Size = new System.Drawing.Size(69, 20);
            this.dtpTotMaxTime.TabIndex = 16;
            // 
            // dtpTotMaxDate
            // 
            this.dtpTotMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTotMaxDate.Location = new System.Drawing.Point(223, 137);
            this.dtpTotMaxDate.Name = "dtpTotMaxDate";
            this.dtpTotMaxDate.Size = new System.Drawing.Size(69, 20);
            this.dtpTotMaxDate.TabIndex = 15;
            // 
            // lstTot
            // 
            this.lstTot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTot.FormattingEnabled = true;
            this.lstTot.Location = new System.Drawing.Point(3, 326);
            this.lstTot.Name = "lstTot";
            this.lstTot.Size = new System.Drawing.Size(786, 95);
            this.lstTot.TabIndex = 17;
            // 
            // btnTotale
            // 
            this.btnTotale.Location = new System.Drawing.Point(223, 210);
            this.btnTotale.Name = "btnTotale";
            this.btnTotale.Size = new System.Drawing.Size(75, 23);
            this.btnTotale.TabIndex = 18;
            this.btnTotale.Text = "button1";
            this.btnTotale.UseVisualStyleBackColor = true;
            this.btnTotale.Click += new System.EventHandler(this.btnTotale_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lblStatsOutput);
            this.tabPage7.Controls.Add(this.btnStats);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(792, 424);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(87, 55);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 0;
            this.btnStats.Text = "button1";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // lblStatsOutput
            // 
            this.lblStatsOutput.AutoSize = true;
            this.lblStatsOutput.Location = new System.Drawing.Point(84, 93);
            this.lblStatsOutput.Name = "lblStatsOutput";
            this.lblStatsOutput.Size = new System.Drawing.Size(35, 13);
            this.lblStatsOutput.TabIndex = 1;
            this.lblStatsOutput.Text = "label6";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgvNonRiconsegnati);
            this.tabPage8.Controls.Add(this.btnNonRiconsegnati);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(792, 424);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btnNonRiconsegnati
            // 
            this.btnNonRiconsegnati.Location = new System.Drawing.Point(313, 166);
            this.btnNonRiconsegnati.Name = "btnNonRiconsegnati";
            this.btnNonRiconsegnati.Size = new System.Drawing.Size(75, 23);
            this.btnNonRiconsegnati.TabIndex = 2;
            this.btnNonRiconsegnati.Text = "button1";
            this.btnNonRiconsegnati.UseVisualStyleBackColor = true;
            this.btnNonRiconsegnati.Click += new System.EventHandler(this.btnNonRiconsegnati_Click);
            // 
            // dgvNonRiconsegnati
            // 
            this.dgvNonRiconsegnati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonRiconsegnati.Location = new System.Drawing.Point(6, 223);
            this.dgvNonRiconsegnati.Name = "dgvNonRiconsegnati";
            this.dgvNonRiconsegnati.Size = new System.Drawing.Size(778, 193);
            this.dgvNonRiconsegnati.TabIndex = 3;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonRiconsegnati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSavType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSav;
        private System.Windows.Forms.TextBox txtSavNote;
        private System.Windows.Forms.TextBox txtSavIdNole;
        private System.Windows.Forms.TextBox txtSavIdClient;
        private System.Windows.Forms.DateTimePicker dtpSavTime;
        private System.Windows.Forms.DateTimePicker dtpSavDate;
        private System.Windows.Forms.DateTimePicker dtpModTime;
        private System.Windows.Forms.DateTimePicker dtpModData;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtModKilo;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cboViewType;
        private System.Windows.Forms.RadioButton rdoViewDesc;
        private System.Windows.Forms.RadioButton rdoViewAsce;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtDelId;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCalcMax;
        private System.Windows.Forms.TextBox txtCalcMin;
        private System.Windows.Forms.Label lblCalcOutput;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnTotale;
        private System.Windows.Forms.ListBox lstTot;
        private System.Windows.Forms.DateTimePicker dtpTotMaxTime;
        private System.Windows.Forms.DateTimePicker dtpTotMaxDate;
        private System.Windows.Forms.DateTimePicker dtpTotMinTime;
        private System.Windows.Forms.DateTimePicker dtpTotMinDate;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblStatsOutput;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgvNonRiconsegnati;
        private System.Windows.Forms.Button btnNonRiconsegnati;
    }
}

