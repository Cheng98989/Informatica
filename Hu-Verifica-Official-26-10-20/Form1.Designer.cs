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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSavId = new System.Windows.Forms.TextBox();
            this.txtSavName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSavSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSavDepart = new System.Windows.Forms.ComboBox();
            this.cboSavType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSavRegDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSavRegTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSavStaTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSavStaDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSavEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSavEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSav = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.dtpModEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpModEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpModStaTime = new System.Windows.Forms.DateTimePicker();
            this.dtpModStaDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpModRegTime = new System.Windows.Forms.DateTimePicker();
            this.dtpModRegDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboModType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboModDepart = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModSurname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnModSearch = new System.Windows.Forms.Button();
            this.lblModId = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtDelId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cboFilDepart = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFilDepart = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpSearchStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchStartDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpSearchEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchEndDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtAnaSurname = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAnaName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAna = new System.Windows.Forms.Button();
            this.lsvAna = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSav);
            this.tabPage1.Controls.Add(this.dtpSavEndTime);
            this.tabPage1.Controls.Add(this.dtpSavEndDate);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtpSavStaTime);
            this.tabPage1.Controls.Add(this.dtpSavStaDate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtpSavRegTime);
            this.tabPage1.Controls.Add(this.dtpSavRegDate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cboSavType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cboSavDepart);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSavSurname);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSavName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSavId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblModId);
            this.tabPage2.Controls.Add(this.btnModSearch);
            this.tabPage2.Controls.Add(this.txtModId);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btnMod);
            this.tabPage2.Controls.Add(this.dtpModEndTime);
            this.tabPage2.Controls.Add(this.dtpModEndDate);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtpModStaTime);
            this.tabPage2.Controls.Add(this.dtpModStaDate);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtpModRegTime);
            this.tabPage2.Controls.Add(this.dtpModRegDate);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cboModType);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cboModDepart);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtModSurname);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtModName);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 100);
            this.panel1.TabIndex = 1;
            // 
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewer.Location = new System.Drawing.Point(358, 100);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(442, 350);
            this.dgvViewer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtSavId
            // 
            this.txtSavId.Location = new System.Drawing.Point(124, 71);
            this.txtSavId.Name = "txtSavId";
            this.txtSavId.Size = new System.Drawing.Size(100, 20);
            this.txtSavId.TabIndex = 1;
            // 
            // txtSavName
            // 
            this.txtSavName.Location = new System.Drawing.Point(124, 97);
            this.txtSavName.Name = "txtSavName";
            this.txtSavName.Size = new System.Drawing.Size(100, 20);
            this.txtSavName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "REPARTO";
            // 
            // txtSavSurname
            // 
            this.txtSavSurname.Location = new System.Drawing.Point(124, 123);
            this.txtSavSurname.Name = "txtSavSurname";
            this.txtSavSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSavSurname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "COGNOME";
            // 
            // cboSavDepart
            // 
            this.cboSavDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavDepart.FormattingEnabled = true;
            this.cboSavDepart.Location = new System.Drawing.Point(124, 148);
            this.cboSavDepart.Name = "cboSavDepart";
            this.cboSavDepart.Size = new System.Drawing.Size(121, 21);
            this.cboSavDepart.TabIndex = 7;
            // 
            // cboSavType
            // 
            this.cboSavType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavType.FormattingEnabled = true;
            this.cboSavType.Location = new System.Drawing.Point(124, 175);
            this.cboSavType.Name = "cboSavType";
            this.cboSavType.Size = new System.Drawing.Size(121, 21);
            this.cboSavType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TIPO PERSONALE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "REGISTRAZIONE";
            // 
            // dtpSavRegDate
            // 
            this.dtpSavRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavRegDate.Location = new System.Drawing.Point(124, 203);
            this.dtpSavRegDate.Name = "dtpSavRegDate";
            this.dtpSavRegDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSavRegDate.TabIndex = 11;
            // 
            // dtpSavRegTime
            // 
            this.dtpSavRegTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavRegTime.Location = new System.Drawing.Point(230, 203);
            this.dtpSavRegTime.Name = "dtpSavRegTime";
            this.dtpSavRegTime.ShowUpDown = true;
            this.dtpSavRegTime.Size = new System.Drawing.Size(100, 20);
            this.dtpSavRegTime.TabIndex = 12;
            // 
            // dtpSavStaTime
            // 
            this.dtpSavStaTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavStaTime.Location = new System.Drawing.Point(230, 229);
            this.dtpSavStaTime.Name = "dtpSavStaTime";
            this.dtpSavStaTime.ShowUpDown = true;
            this.dtpSavStaTime.Size = new System.Drawing.Size(100, 20);
            this.dtpSavStaTime.TabIndex = 15;
            this.dtpSavStaTime.UseWaitCursor = true;
            // 
            // dtpSavStaDate
            // 
            this.dtpSavStaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavStaDate.Location = new System.Drawing.Point(124, 229);
            this.dtpSavStaDate.Name = "dtpSavStaDate";
            this.dtpSavStaDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSavStaDate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "INIZIO";
            // 
            // dtpSavEndTime
            // 
            this.dtpSavEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSavEndTime.Location = new System.Drawing.Point(230, 255);
            this.dtpSavEndTime.Name = "dtpSavEndTime";
            this.dtpSavEndTime.ShowUpDown = true;
            this.dtpSavEndTime.Size = new System.Drawing.Size(100, 20);
            this.dtpSavEndTime.TabIndex = 18;
            // 
            // dtpSavEndDate
            // 
            this.dtpSavEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavEndDate.Location = new System.Drawing.Point(124, 255);
            this.dtpSavEndDate.Name = "dtpSavEndDate";
            this.dtpSavEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSavEndDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "FINE TURNO";
            // 
            // btnSav
            // 
            this.btnSav.Location = new System.Drawing.Point(23, 296);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(305, 23);
            this.btnSav.TabIndex = 19;
            this.btnSav.Text = "salva";
            this.btnSav.UseVisualStyleBackColor = true;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(95, 22);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "button1";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(20, 391);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(305, 23);
            this.btnMod.TabIndex = 39;
            this.btnMod.Text = "modifica";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // dtpModEndTime
            // 
            this.dtpModEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModEndTime.Location = new System.Drawing.Point(227, 350);
            this.dtpModEndTime.Name = "dtpModEndTime";
            this.dtpModEndTime.ShowUpDown = true;
            this.dtpModEndTime.Size = new System.Drawing.Size(100, 20);
            this.dtpModEndTime.TabIndex = 38;
            // 
            // dtpModEndDate
            // 
            this.dtpModEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModEndDate.Location = new System.Drawing.Point(121, 350);
            this.dtpModEndDate.Name = "dtpModEndDate";
            this.dtpModEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpModEndDate.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "FINE TURNO";
            // 
            // dtpModStaTime
            // 
            this.dtpModStaTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModStaTime.Location = new System.Drawing.Point(227, 324);
            this.dtpModStaTime.Name = "dtpModStaTime";
            this.dtpModStaTime.ShowUpDown = true;
            this.dtpModStaTime.Size = new System.Drawing.Size(100, 20);
            this.dtpModStaTime.TabIndex = 35;
            this.dtpModStaTime.UseWaitCursor = true;
            // 
            // dtpModStaDate
            // 
            this.dtpModStaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModStaDate.Location = new System.Drawing.Point(121, 324);
            this.dtpModStaDate.Name = "dtpModStaDate";
            this.dtpModStaDate.Size = new System.Drawing.Size(100, 20);
            this.dtpModStaDate.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "INIZIO";
            // 
            // dtpModRegTime
            // 
            this.dtpModRegTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModRegTime.Location = new System.Drawing.Point(227, 298);
            this.dtpModRegTime.Name = "dtpModRegTime";
            this.dtpModRegTime.ShowUpDown = true;
            this.dtpModRegTime.Size = new System.Drawing.Size(100, 20);
            this.dtpModRegTime.TabIndex = 32;
            // 
            // dtpModRegDate
            // 
            this.dtpModRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModRegDate.Location = new System.Drawing.Point(121, 298);
            this.dtpModRegDate.Name = "dtpModRegDate";
            this.dtpModRegDate.Size = new System.Drawing.Size(100, 20);
            this.dtpModRegDate.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "REGISTRAZIONE";
            // 
            // cboModType
            // 
            this.cboModType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModType.FormattingEnabled = true;
            this.cboModType.Location = new System.Drawing.Point(121, 270);
            this.cboModType.Name = "cboModType";
            this.cboModType.Size = new System.Drawing.Size(121, 21);
            this.cboModType.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "TIPO PERSONALE";
            // 
            // cboModDepart
            // 
            this.cboModDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModDepart.FormattingEnabled = true;
            this.cboModDepart.Location = new System.Drawing.Point(121, 243);
            this.cboModDepart.Name = "cboModDepart";
            this.cboModDepart.Size = new System.Drawing.Size(121, 21);
            this.cboModDepart.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "REPARTO";
            // 
            // txtModSurname
            // 
            this.txtModSurname.Location = new System.Drawing.Point(121, 218);
            this.txtModSurname.Name = "txtModSurname";
            this.txtModSurname.Size = new System.Drawing.Size(100, 20);
            this.txtModSurname.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "COGNOME";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(121, 192);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(100, 20);
            this.txtModName.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "NOME";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "ID";
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(121, 19);
            this.txtModId.Name = "txtModId";
            this.txtModId.Size = new System.Drawing.Size(100, 20);
            this.txtModId.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "ID";
            // 
            // btnModSearch
            // 
            this.btnModSearch.Location = new System.Drawing.Point(20, 55);
            this.btnModSearch.Name = "btnModSearch";
            this.btnModSearch.Size = new System.Drawing.Size(305, 23);
            this.btnModSearch.TabIndex = 42;
            this.btnModSearch.Text = "cerca";
            this.btnModSearch.UseVisualStyleBackColor = true;
            this.btnModSearch.Click += new System.EventHandler(this.btnModSearch_Click);
            // 
            // lblModId
            // 
            this.lblModId.AutoSize = true;
            this.lblModId.Location = new System.Drawing.Point(121, 173);
            this.lblModId.Name = "lblModId";
            this.lblModId.Size = new System.Drawing.Size(41, 13);
            this.lblModId.TabIndex = 43;
            this.lblModId.Text = "label18";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDel);
            this.tabPage3.Controls.Add(this.txtDelId);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(350, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(24, 219);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(305, 23);
            this.btnDel.TabIndex = 45;
            this.btnDel.Text = "elimina";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtDelId
            // 
            this.txtDelId.Location = new System.Drawing.Point(125, 183);
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(100, 20);
            this.txtDelId.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnFilDepart);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.cboFilDepart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(350, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cboFilDepart
            // 
            this.cboFilDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilDepart.FormattingEnabled = true;
            this.cboFilDepart.Location = new System.Drawing.Point(142, 57);
            this.cboFilDepart.Name = "cboFilDepart";
            this.cboFilDepart.Size = new System.Drawing.Size(121, 21);
            this.cboFilDepart.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "REPARTO";
            // 
            // btnFilDepart
            // 
            this.btnFilDepart.Location = new System.Drawing.Point(26, 84);
            this.btnFilDepart.Name = "btnFilDepart";
            this.btnFilDepart.Size = new System.Drawing.Size(305, 23);
            this.btnFilDepart.TabIndex = 46;
            this.btnFilDepart.Text = "filtra";
            this.btnFilDepart.UseVisualStyleBackColor = true;
            this.btnFilDepart.Click += new System.EventHandler(this.btnFilDepart_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnSearch);
            this.tabPage5.Controls.Add(this.dtpSearchEndTime);
            this.tabPage5.Controls.Add(this.dtpSearchEndDate);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.dtpSearchStartTime);
            this.tabPage5.Controls.Add(this.dtpSearchStartDate);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.txtSearchSurname);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.txtSearchName);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(350, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(177, 215);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSearchSurname.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 222);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "COGNOME";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(177, 189);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(73, 196);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "NOME";
            // 
            // dtpSearchStartTime
            // 
            this.dtpSearchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSearchStartTime.Location = new System.Drawing.Point(231, 250);
            this.dtpSearchStartTime.Name = "dtpSearchStartTime";
            this.dtpSearchStartTime.ShowUpDown = true;
            this.dtpSearchStartTime.Size = new System.Drawing.Size(100, 20);
            this.dtpSearchStartTime.TabIndex = 15;
            // 
            // dtpSearchStartDate
            // 
            this.dtpSearchStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchStartDate.Location = new System.Drawing.Point(125, 250);
            this.dtpSearchStartDate.Name = "dtpSearchStartDate";
            this.dtpSearchStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSearchStartDate.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 254);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "INIZIO INTERVALLO";
            // 
            // dtpSearchEndTime
            // 
            this.dtpSearchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSearchEndTime.Location = new System.Drawing.Point(231, 276);
            this.dtpSearchEndTime.Name = "dtpSearchEndTime";
            this.dtpSearchEndTime.ShowUpDown = true;
            this.dtpSearchEndTime.Size = new System.Drawing.Size(100, 20);
            this.dtpSearchEndTime.TabIndex = 18;
            // 
            // dtpSearchEndDate
            // 
            this.dtpSearchEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchEndDate.Location = new System.Drawing.Point(125, 276);
            this.dtpSearchEndDate.Name = "dtpSearchEndDate";
            this.dtpSearchEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSearchEndDate.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 280);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "FINE INTERVALLO";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(90, 315);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "TROVA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lsvAna);
            this.tabPage6.Controls.Add(this.btnAna);
            this.tabPage6.Controls.Add(this.txtAnaSurname);
            this.tabPage6.Controls.Add(this.label24);
            this.tabPage6.Controls.Add(this.txtAnaName);
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(350, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtAnaSurname
            // 
            this.txtAnaSurname.Location = new System.Drawing.Point(159, 93);
            this.txtAnaSurname.Name = "txtAnaSurname";
            this.txtAnaSurname.Size = new System.Drawing.Size(100, 20);
            this.txtAnaSurname.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(55, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "COGNOME";
            // 
            // txtAnaName
            // 
            this.txtAnaName.Location = new System.Drawing.Point(159, 67);
            this.txtAnaName.Name = "txtAnaName";
            this.txtAnaName.Size = new System.Drawing.Size(100, 20);
            this.txtAnaName.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(55, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "NOME";
            // 
            // btnAna
            // 
            this.btnAna.Location = new System.Drawing.Point(58, 138);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(75, 23);
            this.btnAna.TabIndex = 14;
            this.btnAna.Text = "Analisi";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // lsvAna
            // 
            this.lsvAna.HideSelection = false;
            this.lsvAna.Location = new System.Drawing.Point(58, 215);
            this.lsvAna.Name = "lsvAna";
            this.lsvAna.Size = new System.Drawing.Size(121, 97);
            this.lsvAna.TabIndex = 15;
            this.lsvAna.UseCompatibleStateImageBehavior = false;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.ComboBox cboSavType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSavDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSavSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSavName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSav;
        private System.Windows.Forms.DateTimePicker dtpSavEndTime;
        private System.Windows.Forms.DateTimePicker dtpSavEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSavStaTime;
        private System.Windows.Forms.DateTimePicker dtpSavStaDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSavRegTime;
        private System.Windows.Forms.DateTimePicker dtpSavRegDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblModId;
        private System.Windows.Forms.Button btnModSearch;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.DateTimePicker dtpModEndTime;
        private System.Windows.Forms.DateTimePicker dtpModEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpModStaTime;
        private System.Windows.Forms.DateTimePicker dtpModStaDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpModRegTime;
        private System.Windows.Forms.DateTimePicker dtpModRegDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboModType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboModDepart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtModSurname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtDelId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboFilDepart;
        private System.Windows.Forms.Button btnFilDepart;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DateTimePicker dtpSearchEndTime;
        private System.Windows.Forms.DateTimePicker dtpSearchEndDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpSearchStartTime;
        private System.Windows.Forms.DateTimePicker dtpSearchStartDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSearchSurname;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.TextBox txtAnaSurname;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAnaName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListView lsvAna;
    }
}

