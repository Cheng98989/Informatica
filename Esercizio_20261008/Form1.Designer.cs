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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSavId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSavAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSavCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSavAmount = new System.Windows.Forms.TextBox();
            this.dtpSavDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.btnSav = new System.Windows.Forms.Button();
            this.btnVie = new System.Windows.Forms.Button();
            this.rdoOrdAscendent = new System.Windows.Forms.RadioButton();
            this.rdoOrderDescendent = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoOrdName = new System.Windows.Forms.RadioButton();
            this.rdoOrdData = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSavId
            // 
            this.txtSavId.Location = new System.Drawing.Point(108, 81);
            this.txtSavId.Name = "txtSavId";
            this.txtSavId.Size = new System.Drawing.Size(144, 20);
            this.txtSavId.TabIndex = 0;
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
            // dtpSavDate
            // 
            this.dtpSavDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSavDate.Location = new System.Drawing.Point(111, 159);
            this.dtpSavDate.Name = "dtpSavDate";
            this.dtpSavDate.Size = new System.Drawing.Size(141, 20);
            this.dtpSavDate.TabIndex = 12;
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
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewer.Location = new System.Drawing.Point(302, 110);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(498, 340);
            this.dgvViewer.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoOrdAscendent);
            this.panel2.Controls.Add(this.rdoOrderDescendent);
            this.panel2.Location = new System.Drawing.Point(204, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 25);
            this.panel2.TabIndex = 17;
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}

