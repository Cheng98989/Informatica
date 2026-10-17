using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoyoverse
{
    public partial class Form1 : Form
    {
        List<Worker> workers = new List<Worker>() { };


        public Form1()
        {
            InitializeComponent();

            cboSavDepartments.Items.Clear();
            foreach( var d in Enum.GetValues(typeof(Worker.Departents)))
            {
                cboSavDepartments.Items.Add(d);
            }
            cboSavDepartments.SelectedIndex = 0;
            ViewList(workers);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSavName.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavSurname.Text.Trim()) ||
                string.IsNullOrEmpty(cboSavDepartments.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            Worker.Departents d = (Worker.Departents)Enum.Parse(typeof(Worker.Departents) ,cboSavDepartments.Text);

            Worker w;
            try
            {
                w = new Worker(
                    dtpSavHireDate.Value,
                    txtSavName.Text.Trim(),
                    txtSavSurname.Text.Trim(),
                    d,
                    nudSavSalary.Value
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            workers.Add(w);
            MessageBox.Show($"Il dipendente {w.Name} {w.Surname} e' stato aggiunto sotto l'ID {w}");
            ViewList(workers);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewList(workers);
        }

        private void ViewList(List<Worker> w)
        {
            w.Select(i => new
            {
                Id = i.Id,
                Nome = i.Name,
                Cognome = i.Surname,
                Assunzione = i.HireDate.Date,
                Dipartimento = i.Department,
                Progetti = i.GetProjects().Keys
            });
            dgvView.DataSource = null;
            dgvView.DataSource = w.ToList();
        }
    }
}
