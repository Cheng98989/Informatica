namespace Esercizio_20261008
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
            this.btnSav = new System.Windows.Forms.Button();
            this.dtpSavDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSavCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSavAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSavAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSavId = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdId = new System.Windows.Forms.TextBox();
            this.lblUpdId = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.dtpUpdDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdAddres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelView = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDelName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnFil = new System.Windows.Forms.Button();
            this.chkFilDate = new System.Windows.Forms.CheckBox();
            this.chkFilAmount = new System.Windows.Forms.CheckBox();
            this.dtpFilMaxDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFilMinDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFilMaxAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFilMinAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoOrdName = new System.Windows.Forms.RadioButton();
            this.rdoOrdData = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoOrdAscendent = new System.Windows.Forms.RadioButton();
            this.rdoOrderDescendent = new System.Windows.Forms.RadioButton();
            this.btnVie = new System.Windows.Forms.Button();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnSta = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblStaOrders = new System.Windows.Forms.Label();
            this.lblStatAmount = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblStatAverage = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.chkStatDate = new System.Windows.Forms.CheckBox();
            this.dtpStatMaxDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpStatMinDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(302, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSav);
            this.tabPage1.Controls.Add(this.dtpSavDate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSavCost);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSavAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSavAddress);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSavName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSavId);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSav
            // 
            this.btnSav.Location = new System.Drawing.Point(40, 250);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(212, 66);
            this.btnSav.TabIndex = 13;
            this.btnSav.Text = "button1";
            this.btnSav.UseVisualStyleBackColor = true;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // dtpSavDate
            // 
            this.dtpSavDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavDate.Location = new System.Drawing.Point(111, 159);
            this.dtpSavDate.Name = "dtpSavDate";
            this.dtpSavDate.Size = new System.Drawing.Size(141, 20);
            this.dtpSavDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PREZZO";
            // 
            // txtSavCost
            // 
            this.txtSavCost.Location = new System.Drawing.Point(108, 211);
            this.txtSavCost.Name = "txtSavCost";
            this.txtSavCost.Size = new System.Drawing.Size(144, 20);
            this.txtSavCost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "QUANTITA\'";
            // 
            // txtSavAmount
            // 
            this.txtSavAmount.Location = new System.Drawing.Point(108, 185);
            this.txtSavAmount.Name = "txtSavAmount";
            this.txtSavAmount.Size = new System.Drawing.Size(144, 20);
            this.txtSavAmount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "INDIRIZZO";
            // 
            // txtSavAddress
            // 
            this.txtSavAddress.Location = new System.Drawing.Point(108, 133);
            this.txtSavAddress.Name = "txtSavAddress";
            this.txtSavAddress.Size = new System.Drawing.Size(144, 20);
            this.txtSavAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME";
            // 
            // txtSavName
            // 
            this.txtSavName.Location = new System.Drawing.Point(108, 107);
            this.txtSavName.Name = "txtSavName";
            this.txtSavName.Size = new System.Drawing.Size(144, 20);
            this.txtSavName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtSavId
            // 
            this.txtSavId.Location = new System.Drawing.Point(108, 81);
            this.txtSavId.Name = "txtSavId";
            this.txtSavId.Size = new System.Drawing.Size(144, 20);
            this.txtSavId.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdSearch);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtUpdId);
            this.tabPage2.Controls.Add(this.lblUpdId);
            this.tabPage2.Controls.Add(this.btnUpd);
            this.tabPage2.Controls.Add(this.dtpUpdDate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtUpdCost);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtUpdAmount);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtUpdAddres);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtUpdName);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdSearch
            // 
            this.btnUpdSearch.Location = new System.Drawing.Point(39, 75);
            this.btnUpdSearch.Name = "btnUpdSearch";
            this.btnUpdSearch.Size = new System.Drawing.Size(212, 48);
            this.btnUpdSearch.TabIndex = 30;
            this.btnUpdSearch.Text = "button2";
            this.btnUpdSearch.UseVisualStyleBackColor = true;
            this.btnUpdSearch.Click += new System.EventHandler(this.btnUpdSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "ID";
            // 
            // txtUpdId
            // 
            this.txtUpdId.Location = new System.Drawing.Point(107, 49);
            this.txtUpdId.Name = "txtUpdId";
            this.txtUpdId.Size = new System.Drawing.Size(144, 20);
            this.txtUpdId.TabIndex = 28;
            // 
            // lblUpdId
            // 
            this.lblUpdId.AutoSize = true;
            this.lblUpdId.Location = new System.Drawing.Point(107, 137);
            this.lblUpdId.Name = "lblUpdId";
            this.lblUpdId.Size = new System.Drawing.Size(41, 13);
            this.lblUpdId.TabIndex = 27;
            this.lblUpdId.Text = "label13";
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(39, 299);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(212, 66);
            this.btnUpd.TabIndex = 26;
            this.btnUpd.Text = "button1";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // dtpUpdDate
            // 
            this.dtpUpdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdDate.Location = new System.Drawing.Point(110, 208);
            this.dtpUpdDate.Name = "dtpUpdDate";
            this.dtpUpdDate.Size = new System.Drawing.Size(141, 20);
            this.dtpUpdDate.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "PREZZO";
            // 
            // txtUpdCost
            // 
            this.txtUpdCost.Location = new System.Drawing.Point(107, 260);
            this.txtUpdCost.Name = "txtUpdCost";
            this.txtUpdCost.Size = new System.Drawing.Size(144, 20);
            this.txtUpdCost.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "QUANTITA\'";
            // 
            // txtUpdAmount
            // 
            this.txtUpdAmount.Location = new System.Drawing.Point(107, 234);
            this.txtUpdAmount.Name = "txtUpdAmount";
            this.txtUpdAmount.Size = new System.Drawing.Size(144, 20);
            this.txtUpdAmount.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "DATA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "INDIRIZZO";
            // 
            // txtUpdAddres
            // 
            this.txtUpdAddres.Location = new System.Drawing.Point(107, 182);
            this.txtUpdAddres.Name = "txtUpdAddres";
            this.txtUpdAddres.Size = new System.Drawing.Size(144, 20);
            this.txtUpdAddres.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "NOME";
            // 
            // txtUpdName
            // 
            this.txtUpdName.Location = new System.Drawing.Point(107, 156);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(144, 20);
            this.txtUpdName.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnDelView);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtDelName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(294, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 20);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "button2";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelView
            // 
            this.btnDelView.Location = new System.Drawing.Point(41, 188);
            this.btnDelView.Name = "btnDelView";
            this.btnDelView.Size = new System.Drawing.Size(212, 20);
            this.btnDelView.TabIndex = 33;
            this.btnDelView.Text = "button2";
            this.btnDelView.UseVisualStyleBackColor = true;
            this.btnDelView.Click += new System.EventHandler(this.btnDelView_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Nome";
            // 
            // txtDelName
            // 
            this.txtDelName.Location = new System.Drawing.Point(109, 162);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(144, 20);
            this.txtDelName.TabIndex = 31;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnFil);
            this.tabPage4.Controls.Add(this.chkFilDate);
            this.tabPage4.Controls.Add(this.chkFilAmount);
            this.tabPage4.Controls.Add(this.dtpFilMaxDate);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.dtpFilMinDate);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.txtFilMaxAmount);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtFilMinAmount);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(294, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnFil
            // 
            this.btnFil.Location = new System.Drawing.Point(42, 182);
            this.btnFil.Name = "btnFil";
            this.btnFil.Size = new System.Drawing.Size(212, 37);
            this.btnFil.TabIndex = 33;
            this.btnFil.Text = "button1";
            this.btnFil.UseVisualStyleBackColor = true;
            this.btnFil.Click += new System.EventHandler(this.btnFil_Click);
            // 
            // chkFilDate
            // 
            this.chkFilDate.AutoSize = true;
            this.chkFilDate.Location = new System.Drawing.Point(42, 93);
            this.chkFilDate.Name = "chkFilDate";
            this.chkFilDate.Size = new System.Drawing.Size(80, 17);
            this.chkFilDate.TabIndex = 32;
            this.chkFilDate.Text = "checkBox2";
            this.chkFilDate.UseVisualStyleBackColor = true;
            // 
            // chkFilAmount
            // 
            this.chkFilAmount.AutoSize = true;
            this.chkFilAmount.Location = new System.Drawing.Point(42, 13);
            this.chkFilAmount.Name = "chkFilAmount";
            this.chkFilAmount.Size = new System.Drawing.Size(80, 17);
            this.chkFilAmount.TabIndex = 31;
            this.chkFilAmount.Text = "checkBox1";
            this.chkFilAmount.UseVisualStyleBackColor = true;
            // 
            // dtpFilMaxDate
            // 
            this.dtpFilMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilMaxDate.Location = new System.Drawing.Point(113, 142);
            this.dtpFilMaxDate.Name = "dtpFilMaxDate";
            this.dtpFilMaxDate.Size = new System.Drawing.Size(141, 20);
            this.dtpFilMaxDate.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "DATA";
            // 
            // dtpFilMinDate
            // 
            this.dtpFilMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilMinDate.Location = new System.Drawing.Point(113, 116);
            this.dtpFilMinDate.Name = "dtpFilMinDate";
            this.dtpFilMinDate.Size = new System.Drawing.Size(141, 20);
            this.dtpFilMinDate.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "DATA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "QUANTITA\'";
            // 
            // txtFilMaxAmount
            // 
            this.txtFilMaxAmount.Location = new System.Drawing.Point(110, 62);
            this.txtFilMaxAmount.Name = "txtFilMaxAmount";
            this.txtFilMaxAmount.Size = new System.Drawing.Size(144, 20);
            this.txtFilMaxAmount.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "QUANTITA\'";
            // 
            // txtFilMinAmount
            // 
            this.txtFilMinAmount.Location = new System.Drawing.Point(110, 36);
            this.txtFilMinAmount.Name = "txtFilMinAmount";
            this.txtFilMinAmount.Size = new System.Drawing.Size(144, 20);
            this.txtFilMinAmount.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(302, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 110);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoOrdName);
            this.panel3.Controls.Add(this.rdoOrdData);
            this.panel3.Location = new System.Drawing.Point(204, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 25);
            this.panel3.TabIndex = 18;
            // 
            // rdoOrdName
            // 
            this.rdoOrdName.AutoSize = true;
            this.rdoOrdName.Checked = true;
            this.rdoOrdName.Location = new System.Drawing.Point(3, 3);
            this.rdoOrdName.Name = "rdoOrdName";
            this.rdoOrdName.Size = new System.Drawing.Size(57, 17);
            this.rdoOrdName.TabIndex = 15;
            this.rdoOrdName.TabStop = true;
            this.rdoOrdName.Text = "NOME";
            this.rdoOrdName.UseVisualStyleBackColor = true;
            // 
            // rdoOrdData
            // 
            this.rdoOrdData.AutoSize = true;
            this.rdoOrdData.Location = new System.Drawing.Point(99, 3);
            this.rdoOrdData.Name = "rdoOrdData";
            this.rdoOrdData.Size = new System.Drawing.Size(54, 17);
            this.rdoOrdData.TabIndex = 16;
            this.rdoOrdData.TabStop = true;
            this.rdoOrdData.Text = "DATA";
            this.rdoOrdData.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoOrdAscendent);
            this.panel2.Controls.Add(this.rdoOrderDescendent);
            this.panel2.Location = new System.Drawing.Point(204, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 25);
            this.panel2.TabIndex = 17;
            // 
            // rdoOrdAscendent
            // 
            this.rdoOrdAscendent.AutoSize = true;
            this.rdoOrdAscendent.Checked = true;
            this.rdoOrdAscendent.Location = new System.Drawing.Point(3, 3);
            this.rdoOrdAscendent.Name = "rdoOrdAscendent";
            this.rdoOrdAscendent.Size = new System.Drawing.Size(90, 17);
            this.rdoOrdAscendent.TabIndex = 15;
            this.rdoOrdAscendent.TabStop = true;
            this.rdoOrdAscendent.Text = "CRESCENTE";
            this.rdoOrdAscendent.UseVisualStyleBackColor = true;
            // 
            // rdoOrderDescendent
            // 
            this.rdoOrderDescendent.AutoSize = true;
            this.rdoOrderDescendent.Location = new System.Drawing.Point(99, 3);
            this.rdoOrderDescendent.Name = "rdoOrderDescendent";
            this.rdoOrderDescendent.Size = new System.Drawing.Size(105, 17);
            this.rdoOrderDescendent.TabIndex = 16;
            this.rdoOrderDescendent.TabStop = true;
            this.rdoOrderDescendent.Text = "DECRESCENTE";
            this.rdoOrderDescendent.UseVisualStyleBackColor = true;
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(6, 12);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(181, 66);
            this.btnVie.TabIndex = 14;
            this.btnVie.Text = "button1";
            this.btnVie.UseVisualStyleBackColor = true;
            this.btnVie.Click += new System.EventHandler(this.btnVie_Click);
            // 
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewer.Location = new System.Drawing.Point(302, 110);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(498, 340);
            this.dgvViewer.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkStatDate);
            this.tabPage5.Controls.Add(this.dtpStatMaxDate);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.dtpStatMinDate);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.lblStatAverage);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.lblStatAmount);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.lblStaOrders);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.btnSta);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(294, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSta
            // 
            this.btnSta.Location = new System.Drawing.Point(29, 249);
            this.btnSta.Name = "btnSta";
            this.btnSta.Size = new System.Drawing.Size(75, 23);
            this.btnSta.TabIndex = 0;
            this.btnSta.Text = "button1";
            this.btnSta.UseVisualStyleBackColor = true;
            this.btnSta.Click += new System.EventHandler(this.btnSta_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "TOT ORDINI";
            // 
            // lblStaOrders
            // 
            this.lblStaOrders.AutoSize = true;
            this.lblStaOrders.Location = new System.Drawing.Point(105, 88);
            this.lblStaOrders.Name = "lblStaOrders";
            this.lblStaOrders.Size = new System.Drawing.Size(70, 13);
            this.lblStaOrders.TabIndex = 2;
            this.lblStaOrders.Text = "TOT ORDINI";
            // 
            // lblStatAmount
            // 
            this.lblStatAmount.AutoSize = true;
            this.lblStatAmount.Location = new System.Drawing.Point(105, 119);
            this.lblStatAmount.Name = "lblStatAmount";
            this.lblStatAmount.Size = new System.Drawing.Size(70, 13);
            this.lblStatAmount.TabIndex = 4;
            this.lblStatAmount.Text = "TOT ORDINI";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "TOT ARTICOLI";
            // 
            // lblStatAverage
            // 
            this.lblStatAverage.AutoSize = true;
            this.lblStatAverage.Location = new System.Drawing.Point(105, 148);
            this.lblStatAverage.Name = "lblStatAverage";
            this.lblStatAverage.Size = new System.Drawing.Size(70, 13);
            this.lblStatAverage.TabIndex = 6;
            this.lblStatAverage.Text = "TOT ORDINI";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "MEDIA";
            // 
            // chkStatDate
            // 
            this.chkStatDate.AutoSize = true;
            this.chkStatDate.Location = new System.Drawing.Point(43, 178);
            this.chkStatDate.Name = "chkStatDate";
            this.chkStatDate.Size = new System.Drawing.Size(80, 17);
            this.chkStatDate.TabIndex = 37;
            this.chkStatDate.Text = "checkBox2";
            this.chkStatDate.UseVisualStyleBackColor = true;
            // 
            // dtpStatMaxDate
            // 
            this.dtpStatMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatMaxDate.Location = new System.Drawing.Point(114, 227);
            this.dtpStatMaxDate.Name = "dtpStatMaxDate";
            this.dtpStatMaxDate.Size = new System.Drawing.Size(141, 20);
            this.dtpStatMaxDate.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "DATA";
            // 
            // dtpStatMinDate
            // 
            this.dtpStatMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatMinDate.Location = new System.Drawing.Point(114, 201);
            this.dtpStatMinDate.Name = "dtpStatMinDate";
            this.dtpStatMinDate.Size = new System.Drawing.Size(141, 20);
            this.dtpStatMinDate.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 208);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "DATA";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSavAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSavId;
        private System.Windows.Forms.DateTimePicker dtpSavDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSavCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSavAmount;
        private System.Windows.Forms.Button btnSav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoOrdName;
        private System.Windows.Forms.RadioButton rdoOrdData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoOrdAscendent;
        private System.Windows.Forms.RadioButton rdoOrderDescendent;
        private System.Windows.Forms.Button btnVie;
        private System.Windows.Forms.Button btnUpdSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUpdId;
        private System.Windows.Forms.Label lblUpdId;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.DateTimePicker dtpUpdDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdAddres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDelView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDelName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chkFilDate;
        private System.Windows.Forms.CheckBox chkFilAmount;
        private System.Windows.Forms.DateTimePicker dtpFilMaxDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpFilMinDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFilMaxAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFilMinAmount;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblStatAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblStaOrders;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSta;
        private System.Windows.Forms.Label lblStatAverage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkStatDate;
        private System.Windows.Forms.DateTimePicker dtpStatMaxDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpStatMinDate;
        private System.Windows.Forms.Label label23;
    }
}

