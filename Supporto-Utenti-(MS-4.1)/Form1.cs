using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supporto_Utenti__MS_4._1_
{
    public partial class Form1 : Form
    {
        IEnumerable<object> format;
        public Form1()
        {
            InitializeComponent();
            //inizializzazione combo
            cboSavDepartment.Items.Clear();
            foreach(string d in Request.Departments)
            {
                cboSavDepartment.Items.Add(d);
            }
            cboSavDepartment.SelectedIndex = 0;
            //inizializzazione checkbox
            chkSavResolved.Checked = false;
            chkUpdResolved.Checked = false;

            // formattazione datagridview
            format = requests.Select(r => new
             {
                 ID = r.Id,
                 EMAIL = r.Email,
                 REPARTO = r.Department,
                 DESCRIZIONE = r.Description,
                 URGENZA = r.Urgency,
                 RICHIESTA = r.ReqDate.ToString(),
                 RISOLUZIONE = r.Resolved ? r.ResDate.ToString() : "Non risolto",
             });



        }

        //LIST
        List<Request> requests = new List<Request>()
        {
            //preinseriti
        };
     
        private void btnSavSave_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtSavId.Text)
                || string.IsNullOrEmpty(txtSavEmail.Text)
                || string.IsNullOrEmpty(cboSavDepartment.Text)
                || string.IsNullOrEmpty(txtSavDescription.Text)
                || string.IsNullOrEmpty(txtSavUrgency.Text)
                )
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            if (!int.TryParse(txtSavUrgency.Text, out int u))
            {
                MessageBox.Show("Urgenza e' un numero intero");
                return;
            }

            var req_d = mergeDateTime(dtpSavReqDate.Value, dtpSavReqTime.Value);
            DateTime? res_d = null;
            if (chkSavResolved.Checked)
                res_d = mergeDateTime(dtpSavResDate.Value, dtpSavResTime.Value);

            Request r;
            try
            {
                r = new Request(
                    txtSavId.Text,
                    txtSavEmail.Text,
                    cboSavDepartment.Text,
                    u,
                    req_d,
                    res_d,
                    txtSavDescription.Text
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            requests.Add(r);
            updateDataGridView(dgvSav, format.ToList());
        }

        
        private void btnUpdSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdSearch.Text))
            {
                MessageBox.Show("ID mancante");
                return;
            }

            var selected = requests.Where(r => r.Id == txtUpdSearch.Text).FirstOrDefault();

            if (selected == null)
            {
                MessageBox.Show("ID non trovato");
                lblUpdId.Text = "---";
                lblUpdEmail.Text = "---";
                lblUpdDepartment.Text = "---";
                lblUpdDescription.Text = "---";
                lblUpdReqDateTime.Text = "---";
                lblUpdUrgency.Text = "---";
                chkUpdResolved.Checked = false;
                dtpUpdResDate.Value = DateTime.Now;
                dtpUpdResTime.Value = DateTime.Now;
                return;
            }

            lblUpdId.Text = selected.Id;
            lblUpdEmail.Text = selected.Email;
            lblUpdDepartment.Text = selected.Department;
            lblUpdDescription.Text = selected.Description;
            lblUpdReqDateTime.Text = selected.ReqDate.ToString();
            lblUpdUrgency.Text = selected.Urgency.ToString();
            chkUpdResolved.Checked = selected.Resolved;
            if(selected.Resolved)
            {
                dtpUpdResDate.Value = selected.ResDate.Value.Date;
                dtpUpdResTime.Value = new DateTime() + selected.ResDate.Value.TimeOfDay;
            }


        }

        private DateTime mergeDateTime(DateTime date, DateTime time)
        {
            return date.Date + time.TimeOfDay;
        }

        private void updateDataGridView<T>(DataGridView dgv, List<T> list)
        {
            dgv.DataSource = null;
            dgv.DataSource = list;
        }

        private void chkSavResolved_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSavResolved.Checked)
            {
                dtpSavResDate.Enabled = true;
                dtpSavResTime.Enabled = true;
                return;
            }
            dtpSavResDate.Enabled = false;
            dtpSavResTime.Enabled = false;
        }

        private void chkUpdResolved_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdResolved.Checked)
            {
                dtpUpdResDate.Enabled = true;
                dtpUpdResTime.Enabled = true;
                return;
            }
            dtpUpdResDate.Enabled = false;
            dtpUpdResTime.Enabled = false;
        }
    }
}
