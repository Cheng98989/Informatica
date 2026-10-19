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
            this.tbpSav = new System.Windows.Forms.TabPage();
            this.tbpVis = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSavId = new System.Windows.Forms.TextBox();
            this.txtSavPilota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavVelocita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSavTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSavMescola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSavMilSec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSavSec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSavMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSav = new System.Windows.Forms.Button();
            this.lsvVisOutput = new System.Windows.Forms.ListBox();
            this.btnVis = new System.Windows.Forms.Button();
            this.tbpMod = new System.Windows.Forms.TabPage();
            this.btnMod = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModMilSec = new System.Windows.Forms.TextBox();
            this.txtModMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModSec = new System.Windows.Forms.TextBox();
            this.txtModMescola = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModVelocita = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModTeam = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtModPilota = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModInputId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnModCerca = new System.Windows.Forms.Button();
            this.tbpDel = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtDelInputId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbpAna = new System.Windows.Forms.TabPage();
            this.btnAna = new System.Windows.Forms.Button();
            this.lblAnaOutput = new System.Windows.Forms.Label();
            this.tbpDis = new System.Windows.Forms.TabPage();
            this.btnDisWrite = new System.Windows.Forms.Button();
            this.btnDisRead = new System.Windows.Forms.Button();
            this.tbpRic = new System.Windows.Forms.TabPage();
            this.btnRic = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpSav.SuspendLayout();
            this.tbpVis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpMod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpDel.SuspendLayout();
            this.tbpAna.SuspendLayout();
            this.tbpDis.SuspendLayout();
            this.tbpRic.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSav);
            this.tabControl1.Controls.Add(this.tbpVis);
            this.tabControl1.Controls.Add(this.tbpMod);
            this.tabControl1.Controls.Add(this.tbpDel);
            this.tabControl1.Controls.Add(this.tbpAna);
            this.tabControl1.Controls.Add(this.tbpDis);
            this.tabControl1.Controls.Add(this.tbpRic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpSav
            // 
            this.tbpSav.Controls.Add(this.btnSav);
            this.tbpSav.Controls.Add(this.groupBox1);
            this.tbpSav.Controls.Add(this.txtSavMescola);
            this.tbpSav.Controls.Add(this.label5);
            this.tbpSav.Controls.Add(this.txtSavVelocita);
            this.tbpSav.Controls.Add(this.label3);
            this.tbpSav.Controls.Add(this.txtSavTeam);
            this.tbpSav.Controls.Add(this.label4);
            this.tbpSav.Controls.Add(this.txtSavPilota);
            this.tbpSav.Controls.Add(this.label2);
            this.tbpSav.Controls.Add(this.txtSavId);
            this.tbpSav.Controls.Add(this.label1);
            this.tbpSav.Location = new System.Drawing.Point(4, 22);
            this.tbpSav.Name = "tbpSav";
            this.tbpSav.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSav.Size = new System.Drawing.Size(792, 424);
            this.tbpSav.TabIndex = 0;
            this.tbpSav.Text = "salva";
            this.tbpSav.UseVisualStyleBackColor = true;
            // 
            // tbpVis
            // 
            this.tbpVis.Controls.Add(this.btnVis);
            this.tbpVis.Controls.Add(this.lsvVisOutput);
            this.tbpVis.Location = new System.Drawing.Point(4, 22);
            this.tbpVis.Name = "tbpVis";
            this.tbpVis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVis.Size = new System.Drawing.Size(792, 424);
            this.tbpVis.TabIndex = 1;
            this.tbpVis.Text = "visualizza";
            this.tbpVis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // txtSavId
            // 
            this.txtSavId.Location = new System.Drawing.Point(147, 53);
            this.txtSavId.Name = "txtSavId";
            this.txtSavId.Size = new System.Drawing.Size(100, 20);
            this.txtSavId.TabIndex = 1;
            // 
            // txtSavPilota
            // 
            this.txtSavPilota.Location = new System.Drawing.Point(147, 79);
            this.txtSavPilota.Name = "txtSavPilota";
            this.txtSavPilota.Size = new System.Drawing.Size(100, 20);
            this.txtSavPilota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "pilota";
            // 
            // txtSavVelocita
            // 
            this.txtSavVelocita.Location = new System.Drawing.Point(147, 131);
            this.txtSavVelocita.Name = "txtSavVelocita";
            this.txtSavVelocita.Size = new System.Drawing.Size(100, 20);
            this.txtSavVelocita.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "velocita max";
            // 
            // txtSavTeam
            // 
            this.txtSavTeam.Location = new System.Drawing.Point(147, 105);
            this.txtSavTeam.Name = "txtSavTeam";
            this.txtSavTeam.Size = new System.Drawing.Size(100, 20);
            this.txtSavTeam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "team";
            // 
            // txtSavMescola
            // 
            this.txtSavMescola.Location = new System.Drawing.Point(147, 157);
            this.txtSavMescola.Name = "txtSavMescola";
            this.txtSavMescola.Size = new System.Drawing.Size(100, 20);
            this.txtSavMescola.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "mescola";
            // 
            // txtSavMilSec
            // 
            this.txtSavMilSec.Location = new System.Drawing.Point(77, 71);
            this.txtSavMilSec.Name = "txtSavMilSec";
            this.txtSavMilSec.Size = new System.Drawing.Size(100, 20);
            this.txtSavMilSec.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "millisecondi";
            // 
            // txtSavSec
            // 
            this.txtSavSec.Location = new System.Drawing.Point(77, 45);
            this.txtSavSec.Name = "txtSavSec";
            this.txtSavSec.Size = new System.Drawing.Size(100, 20);
            this.txtSavSec.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "secondi";
            // 
            // txtSavMin
            // 
            this.txtSavMin.Location = new System.Drawing.Point(77, 19);
            this.txtSavMin.Name = "txtSavMin";
            this.txtSavMin.Size = new System.Drawing.Size(100, 20);
            this.txtSavMin.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "minuti";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSavMilSec);
            this.groupBox1.Controls.Add(this.txtSavMin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSavSec);
            this.groupBox1.Location = new System.Drawing.Point(71, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tempo";
            // 
            // btnSav
            // 
            this.btnSav.Location = new System.Drawing.Point(95, 308);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(152, 23);
            this.btnSav.TabIndex = 17;
            this.btnSav.Text = "salva";
            this.btnSav.UseVisualStyleBackColor = true;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // lsvVisOutput
            // 
            this.lsvVisOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvVisOutput.FormattingEnabled = true;
            this.lsvVisOutput.Location = new System.Drawing.Point(3, 66);
            this.lsvVisOutput.Name = "lsvVisOutput";
            this.lsvVisOutput.Size = new System.Drawing.Size(786, 355);
            this.lsvVisOutput.TabIndex = 0;
            // 
            // btnVis
            // 
            this.btnVis.Location = new System.Drawing.Point(18, 16);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(307, 44);
            this.btnVis.TabIndex = 1;
            this.btnVis.Text = "visualizza";
            this.btnVis.UseVisualStyleBackColor = true;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // tbpMod
            // 
            this.tbpMod.Controls.Add(this.btnModCerca);
            this.tbpMod.Controls.Add(this.txtModInputId);
            this.tbpMod.Controls.Add(this.label17);
            this.tbpMod.Controls.Add(this.btnMod);
            this.tbpMod.Controls.Add(this.groupBox2);
            this.tbpMod.Controls.Add(this.txtModMescola);
            this.tbpMod.Controls.Add(this.label12);
            this.tbpMod.Controls.Add(this.txtModVelocita);
            this.tbpMod.Controls.Add(this.label13);
            this.tbpMod.Controls.Add(this.txtModTeam);
            this.tbpMod.Controls.Add(this.label14);
            this.tbpMod.Controls.Add(this.txtModPilota);
            this.tbpMod.Controls.Add(this.label15);
            this.tbpMod.Controls.Add(this.txtModId);
            this.tbpMod.Controls.Add(this.label16);
            this.tbpMod.Location = new System.Drawing.Point(4, 22);
            this.tbpMod.Name = "tbpMod";
            this.tbpMod.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMod.Size = new System.Drawing.Size(792, 424);
            this.tbpMod.TabIndex = 2;
            this.tbpMod.Text = "modifica";
            this.tbpMod.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(497, 327);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(152, 23);
            this.btnMod.TabIndex = 29;
            this.btnMod.Text = "salva";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtModMilSec);
            this.groupBox2.Controls.Add(this.txtModMin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtModSec);
            this.groupBox2.Location = new System.Drawing.Point(473, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tempo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "minuti";
            // 
            // txtModMilSec
            // 
            this.txtModMilSec.Location = new System.Drawing.Point(77, 71);
            this.txtModMilSec.Name = "txtModMilSec";
            this.txtModMilSec.Size = new System.Drawing.Size(100, 20);
            this.txtModMilSec.TabIndex = 15;
            // 
            // txtModMin
            // 
            this.txtModMin.Location = new System.Drawing.Point(77, 19);
            this.txtModMin.Name = "txtModMin";
            this.txtModMin.Size = new System.Drawing.Size(100, 20);
            this.txtModMin.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "millisecondi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "secondi";
            // 
            // txtModSec
            // 
            this.txtModSec.Location = new System.Drawing.Point(77, 45);
            this.txtModSec.Name = "txtModSec";
            this.txtModSec.Size = new System.Drawing.Size(100, 20);
            this.txtModSec.TabIndex = 13;
            // 
            // txtModMescola
            // 
            this.txtModMescola.Location = new System.Drawing.Point(549, 176);
            this.txtModMescola.Name = "txtModMescola";
            this.txtModMescola.Size = new System.Drawing.Size(100, 20);
            this.txtModMescola.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(494, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "mescola";
            // 
            // txtModVelocita
            // 
            this.txtModVelocita.Location = new System.Drawing.Point(549, 150);
            this.txtModVelocita.Name = "txtModVelocita";
            this.txtModVelocita.Size = new System.Drawing.Size(100, 20);
            this.txtModVelocita.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(494, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "velocita max";
            // 
            // txtModTeam
            // 
            this.txtModTeam.Location = new System.Drawing.Point(549, 124);
            this.txtModTeam.Name = "txtModTeam";
            this.txtModTeam.Size = new System.Drawing.Size(100, 20);
            this.txtModTeam.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(494, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "team";
            // 
            // txtModPilota
            // 
            this.txtModPilota.Location = new System.Drawing.Point(549, 98);
            this.txtModPilota.Name = "txtModPilota";
            this.txtModPilota.Size = new System.Drawing.Size(100, 20);
            this.txtModPilota.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(494, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "pilota";
            // 
            // txtModId
            // 
            this.txtModId.Location = new System.Drawing.Point(549, 72);
            this.txtModId.Name = "txtModId";
            this.txtModId.ReadOnly = true;
            this.txtModId.Size = new System.Drawing.Size(100, 20);
            this.txtModId.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(494, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "id";
            // 
            // txtModInputId
            // 
            this.txtModInputId.Location = new System.Drawing.Point(132, 114);
            this.txtModInputId.Name = "txtModInputId";
            this.txtModInputId.Size = new System.Drawing.Size(100, 20);
            this.txtModInputId.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(77, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "id";
            // 
            // btnModCerca
            // 
            this.btnModCerca.Location = new System.Drawing.Point(80, 140);
            this.btnModCerca.Name = "btnModCerca";
            this.btnModCerca.Size = new System.Drawing.Size(152, 23);
            this.btnModCerca.TabIndex = 32;
            this.btnModCerca.Text = "cerca";
            this.btnModCerca.UseVisualStyleBackColor = true;
            this.btnModCerca.Click += new System.EventHandler(this.btnModCerca_Click);
            // 
            // tbpDel
            // 
            this.tbpDel.Controls.Add(this.btnDel);
            this.tbpDel.Controls.Add(this.txtDelInputId);
            this.tbpDel.Controls.Add(this.label18);
            this.tbpDel.Location = new System.Drawing.Point(4, 22);
            this.tbpDel.Name = "tbpDel";
            this.tbpDel.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDel.Size = new System.Drawing.Size(792, 424);
            this.tbpDel.TabIndex = 3;
            this.tbpDel.Text = "elimina";
            this.tbpDel.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(322, 214);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(152, 23);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "elimina";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtDelInputId
            // 
            this.txtDelInputId.Location = new System.Drawing.Point(374, 188);
            this.txtDelInputId.Name = "txtDelInputId";
            this.txtDelInputId.Size = new System.Drawing.Size(100, 20);
            this.txtDelInputId.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(319, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "id";
            // 
            // tbpAna
            // 
            this.tbpAna.Controls.Add(this.lblAnaOutput);
            this.tbpAna.Controls.Add(this.btnAna);
            this.tbpAna.Location = new System.Drawing.Point(4, 22);
            this.tbpAna.Name = "tbpAna";
            this.tbpAna.Size = new System.Drawing.Size(792, 424);
            this.tbpAna.TabIndex = 4;
            this.tbpAna.Text = "Analisi dati";
            this.tbpAna.UseVisualStyleBackColor = true;
            // 
            // btnAna
            // 
            this.btnAna.Location = new System.Drawing.Point(175, 68);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(152, 23);
            this.btnAna.TabIndex = 0;
            this.btnAna.Text = "Analisi Top Speed";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // lblAnaOutput
            // 
            this.lblAnaOutput.AutoSize = true;
            this.lblAnaOutput.Location = new System.Drawing.Point(175, 98);
            this.lblAnaOutput.Name = "lblAnaOutput";
            this.lblAnaOutput.Size = new System.Drawing.Size(25, 13);
            this.lblAnaOutput.TabIndex = 1;
            this.lblAnaOutput.Text = "???";
            // 
            // tbpDis
            // 
            this.tbpDis.Controls.Add(this.btnDisRead);
            this.tbpDis.Controls.Add(this.btnDisWrite);
            this.tbpDis.Location = new System.Drawing.Point(4, 22);
            this.tbpDis.Name = "tbpDis";
            this.tbpDis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDis.Size = new System.Drawing.Size(792, 424);
            this.tbpDis.TabIndex = 5;
            this.tbpDis.Text = "Disco";
            this.tbpDis.UseVisualStyleBackColor = true;
            // 
            // btnDisWrite
            // 
            this.btnDisWrite.Location = new System.Drawing.Point(308, 109);
            this.btnDisWrite.Name = "btnDisWrite";
            this.btnDisWrite.Size = new System.Drawing.Size(162, 23);
            this.btnDisWrite.TabIndex = 0;
            this.btnDisWrite.Text = "SALVA SU FILE";
            this.btnDisWrite.UseVisualStyleBackColor = true;
            this.btnDisWrite.Click += new System.EventHandler(this.btnDisWrite_Click);
            // 
            // btnDisRead
            // 
            this.btnDisRead.Location = new System.Drawing.Point(308, 160);
            this.btnDisRead.Name = "btnDisRead";
            this.btnDisRead.Size = new System.Drawing.Size(162, 23);
            this.btnDisRead.TabIndex = 1;
            this.btnDisRead.Text = "CARICA DA FILE";
            this.btnDisRead.UseVisualStyleBackColor = true;
            this.btnDisRead.Click += new System.EventHandler(this.btnDisRead_Click);
            // 
            // tbpRic
            // 
            this.tbpRic.Controls.Add(this.btnRic);
            this.tbpRic.Location = new System.Drawing.Point(4, 22);
            this.tbpRic.Name = "tbpRic";
            this.tbpRic.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRic.Size = new System.Drawing.Size(792, 424);
            this.tbpRic.TabIndex = 6;
            this.tbpRic.Text = "Ricorsione";
            this.tbpRic.UseVisualStyleBackColor = true;
            // 
            // btnRic
            // 
            this.btnRic.Location = new System.Drawing.Point(206, 71);
            this.btnRic.Name = "btnRic";
            this.btnRic.Size = new System.Drawing.Size(146, 23);
            this.btnRic.TabIndex = 0;
            this.btnRic.Text = "Tempo Totale";
            this.btnRic.UseVisualStyleBackColor = true;
            this.btnRic.Click += new System.EventHandler(this.btnRic_Click);
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
            this.tbpSav.ResumeLayout(false);
            this.tbpSav.PerformLayout();
            this.tbpVis.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpMod.ResumeLayout(false);
            this.tbpMod.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpDel.ResumeLayout(false);
            this.tbpDel.PerformLayout();
            this.tbpAna.ResumeLayout(false);
            this.tbpAna.PerformLayout();
            this.tbpDis.ResumeLayout(false);
            this.tbpRic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSav;
        private System.Windows.Forms.TabPage tbpVis;
        private System.Windows.Forms.TextBox txtSavPilota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSav;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSavMilSec;
        private System.Windows.Forms.TextBox txtSavMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSavSec;
        private System.Windows.Forms.TextBox txtSavMescola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSavVelocita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSavTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVis;
        private System.Windows.Forms.ListBox lsvVisOutput;
        private System.Windows.Forms.TabPage tbpMod;
        private System.Windows.Forms.Button btnModCerca;
        private System.Windows.Forms.TextBox txtModInputId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModMilSec;
        private System.Windows.Forms.TextBox txtModMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModSec;
        private System.Windows.Forms.TextBox txtModMescola;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtModVelocita;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtModTeam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtModPilota;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tbpDel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtDelInputId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tbpAna;
        private System.Windows.Forms.Label lblAnaOutput;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.TabPage tbpDis;
        private System.Windows.Forms.Button btnDisRead;
        private System.Windows.Forms.Button btnDisWrite;
        private System.Windows.Forms.TabPage tbpRic;
        private System.Windows.Forms.Button btnRic;
    }
}

