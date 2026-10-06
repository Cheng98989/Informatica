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


            // formattazione datagridview
            format = requests.Select<Request,object>(r => new
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
        IEnumerable<object> format;
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

        private DateTime mergeDateTime(DateTime date, DateTime time)
        {
            return date.Date + time.TimeOfDay;
        }

        private void updateDataGridView<T>(DataGridView dgv, List<T> list)
        {
            dgv.DataSource = null;
            dgv.DataSource = list;
            dgv.Update();
        }


    }
}
