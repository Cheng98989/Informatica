namespace ProcessManager
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
            this.btnOpenProgram = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoViewOrderByName = new System.Windows.Forms.RadioButton();
            this.rdoViewOrderById = new System.Windows.Forms.RadioButton();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoOrderByDescending = new System.Windows.Forms.RadioButton();
            this.rdoOrderByAscending = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenProgram
            // 
            this.btnOpenProgram.Location = new System.Drawing.Point(16, 58);
            this.btnOpenProgram.Name = "btnOpenProgram";
            this.btnOpenProgram.Size = new System.Drawing.Size(339, 64);
            this.btnOpenProgram.TabIndex = 0;
            this.btnOpenProgram.Text = "Avvia Eseguibile";
            this.btnOpenProgram.UseVisualStyleBackColor = true;
            this.btnOpenProgram.Click += new System.EventHandler(this.btnOpenProgram_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 2;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(36, 20);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(274, 37);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "Visualizza processi";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnKill);
            this.panel1.Controls.Add(this.btnOpenProgram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 450);
            this.panel1.TabIndex = 7;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(16, 309);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(339, 51);
            this.btnKill.TabIndex = 3;
            this.btnKill.Text = "Termina processo";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnViewAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(394, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 162);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoViewOrderByName);
            this.groupBox1.Controls.Add(this.rdoViewOrderById);
            this.groupBox1.Location = new System.Drawing.Point(36, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordina per:";
            // 
            // rdoViewOrderByName
            // 
            this.rdoViewOrderByName.AutoSize = true;
            this.rdoViewOrderByName.Location = new System.Drawing.Point(119, 13);
            this.rdoViewOrderByName.Name = "rdoViewOrderByName";
            this.rdoViewOrderByName.Size = new System.Drawing.Size(53, 17);
            this.rdoViewOrderByName.TabIndex = 8;
            this.rdoViewOrderByName.TabStop = true;
            this.rdoViewOrderByName.Text = "Nome";
            this.rdoViewOrderByName.UseVisualStyleBackColor = true;
            // 
            // rdoViewOrderById
            // 
            this.rdoViewOrderById.AutoSize = true;
            this.rdoViewOrderById.Location = new System.Drawing.Point(26, 13);
            this.rdoViewOrderById.Name = "rdoViewOrderById";
            this.rdoViewOrderById.Size = new System.Drawing.Size(43, 17);
            this.rdoViewOrderById.TabIndex = 7;
            this.rdoViewOrderById.TabStop = true;
            this.rdoViewOrderById.Text = "PID";
            this.rdoViewOrderById.UseVisualStyleBackColor = true;
            // 
            // dgvProcess
            // 
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcess.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProcess.Location = new System.Drawing.Point(394, 162);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcess.Size = new System.Drawing.Size(406, 288);
            this.dgvProcess.TabIndex = 7;
            this.dgvProcess.SelectionChanged += new System.EventHandler(this.dgvProcess_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoOrderByDescending);
            this.groupBox2.Controls.Add(this.rdoOrderByAscending);
            this.groupBox2.Location = new System.Drawing.Point(36, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 40);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordinamento:";
            // 
            // rdoOrderByDescending
            // 
            this.rdoOrderByDescending.AutoSize = true;
            this.rdoOrderByDescending.Location = new System.Drawing.Point(119, 13);
            this.rdoOrderByDescending.Name = "rdoOrderByDescending";
            this.rdoOrderByDescending.Size = new System.Drawing.Size(86, 17);
            this.rdoOrderByDescending.TabIndex = 8;
            this.rdoOrderByDescending.TabStop = true;
            this.rdoOrderByDescending.Text = "Decrescente";
            this.rdoOrderByDescending.UseVisualStyleBackColor = true;
            // 
            // rdoOrderByAscending
            // 
            this.rdoOrderByAscending.AutoSize = true;
            this.rdoOrderByAscending.Location = new System.Drawing.Point(26, 13);
            this.rdoOrderByAscending.Name = "rdoOrderByAscending";
            this.rdoOrderByAscending.Size = new System.Drawing.Size(73, 17);
            this.rdoOrderByAscending.TabIndex = 7;
            this.rdoOrderByAscending.TabStop = true;
            this.rdoOrderByAscending.Text = "Crescente";
            this.rdoOrderByAscending.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 258);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(339, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ricerca";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Location = new System.Drawing.Point(16, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selezionato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProcess);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProgram;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoViewOrderByName;
        private System.Windows.Forms.RadioButton rdoViewOrderById;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoOrderByDescending;
        private System.Windows.Forms.RadioButton rdoOrderByAscending;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

