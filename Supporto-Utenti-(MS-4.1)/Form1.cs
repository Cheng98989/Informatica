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

            cboFilDepartment.Items.Clear();
            foreach (string d in Request.Departments)
            {
                cboFilDepartment.Items.Add(d);
            }
            cboFilDepartment.SelectedIndex = 0;

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
            #region preinseriti
            new Request(
                "A1001",
                "mario.rossi@email.it",
                "produzione",
                80,
                new DateTime(2026, 9, 21, 9, 15, 0),
                new DateTime(2026, 9, 21, 14, 30, 0),
                "Problema con la linea di produzione."
            ),

            new Request(
                "A1002",
                "laura.bianchi@email.it",
                "amministrazione",
                40,
                new DateTime(2026, 9, 22, 10, 0, 0),
                new DateTime(2026, 9, 22, 15, 20, 0),
                "Errore nella registrazione di una fattura."
            ),

            new Request(
                "A1003",
                "luca.verdi@email.it",
                "vendita",
                65,
                new DateTime(2026, 9, 23, 8, 45, 0),
                null,
                "Cliente in attesa di conferma dell'ordine."
            ),

            new Request(
                "A1004",
                "anna.neri@email.it",
                "produzione",
                95,
                new DateTime(2026, 9, 24, 13, 30, 0),
                new DateTime(2026, 9, 24, 16, 45, 0),
                "Fermo macchina improvviso."
            ),

            new Request(
                "A1005",
                "mario.rossi@email.it",
                "amministrazione",
                55,
                new DateTime(2026, 9, 25, 11, 20, 0),
                null,
                "Richiesta di modifica dei dati di fatturazione."
            ),

            new Request(
                "A1006",
                "paolo.gialli@email.it",
                "amministrazione",
                20,
                new DateTime(2026, 9, 28, 15, 10, 0),
                new DateTime(2026, 9, 29, 9, 30, 0),
                "Richiesta di verifica di un documento."
            ),

            new Request(
                "A1007",
                "chiara.rosa@email.it",
                "vendita",
                70,
                new DateTime(2026, 9, 28, 9, 30, 0),
                new DateTime(2026, 9, 28, 12, 15, 0),
                "Problema con un ordine cliente."
            ),

            new Request(
                "A1008",
                "marco.blu@email.it",
                "produzione",
                50,
                new DateTime(2026, 9, 29, 11, 45, 0),
                null,
                "Controllo necessario su una macchina."
            ),

            new Request(
                "A1009",
                "laura.bianchi@email.it",
                "vendita",
                75,
                new DateTime(2026, 9, 30, 9, 10, 0),
                null,
                "Il cliente segnala un errore nell'ordine."
            ),

            new Request(
                "A1010",
                "simona.verdi@email.it",
                "amministrazione",
                85,
                new DateTime(2026, 9, 30, 14, 20, 0),
                new DateTime(2026, 10, 1, 9, 10, 0),
                "Pagamento non registrato correttamente."
            ),

            new Request(
                "A1011",
                "fabio.rossi@email.it",
                "vendita",
                30,
                new DateTime(2026, 10, 1, 8, 15, 0),
                null,
                "Richiesta informazioni su un prodotto."
            ),

            new Request(
                "A1012",
                "mario.rossi@email.it",
                "vendita",
                90,
                new DateTime(2026, 10, 1, 13, 40, 0),
                new DateTime(2026, 10, 2, 9, 25, 0),
                "Cliente impossibilitato a completare l'acquisto."
            ),

            new Request(
                "A1013",
                "elena.bianchi@email.it",
                "produzione",
                100,
                new DateTime(2026, 10, 2, 16, 0, 0),
                null,
                "Guasto urgente alla linea di produzione."
            ),

            new Request(
                "A1014",
                "luca.verdi@email.it",
                "vendita",
                45,
                new DateTime(2026, 10, 2, 10, 30, 0),
                null,
                "Richiesta di aggiornamento sui tempi di consegna."
            ),

            new Request(
                "A1015",
                "anna.neri@email.it",
                "produzione",
                88,
                new DateTime(2026, 10, 5, 8, 20, 0),
                new DateTime(2026, 10, 5, 12, 50, 0),
                "Rumore anomalo proveniente da un macchinario."
            ),

            new Request(
                "A1016",
                "paolo.gialli@email.it",
                "amministrazione",
                35,
                new DateTime(2026, 10, 5, 14, 15, 0),
                null,
                "Documento fiscale non disponibile nel sistema."
            ),

            new Request(
                "A1017",
                "chiara.rosa@email.it",
                "vendita",
                60,
                new DateTime(2026, 10, 6, 9, 45, 0),
                null,
                "Il cliente richiede una modifica all'ordine."
            ),

            new Request(
                "A1018",
                "marco.blu@email.it",
                "produzione",
                92,
                new DateTime(2026, 10, 6, 11, 10, 0),
                new DateTime(2026, 10, 6, 15, 40, 0),
                "Blocco temporaneo del sistema di controllo."
            ),

            new Request(
                "A1019",
                "simona.verdi@email.it",
                "amministrazione",
                25,
                new DateTime(2026, 10, 7, 10, 20, 0),
                null,
                "Richiesta di controllo di una nota spese."
            ),

            new Request(
                "A1020",
                "laura.bianchi@email.it",
                "amministrazione",
                65,
                new DateTime(2026, 10, 7, 15, 30, 0),
                null,
                "Errore nei dati presenti nella fattura del cliente."
            )
            #endregion
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
            updateDataGridView(dgvList, format.ToList());
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
                dtpUpdResTime.Value = DateTime.Today + selected.ResDate.Value.TimeOfDay;
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

        private void btnViewList_Click(object sender, EventArgs e)
        {
            updateDataGridView(dgvList, format.ToList());
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblUpdId.Text))
            {
                MessageBox.Show("Nessuna richiesta selezionata");
                return;
            }

            var selected = requests.Where(r => r.Id == txtUpdSearch.Text).FirstOrDefault();

            if (selected == null)
            {
                MessageBox.Show("ID non trovato");
                return;
            }

            DateTime? res_d = null;
            if (chkUpdResolved.Checked)
                 res_d = mergeDateTime(dtpUpdResDate.Value, dtpUpdResTime.Value);

            try
            {
                selected.ResDate = res_d;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboFilDepartment.Text))
            {
                MessageBox.Show("Nessun reparto selezionato");
                return;
            }

            var filtered = requests.Where(r => r.Department == cboFilDepartment.Text);

            if (rdoFilOrderByUrgency.Checked)
                filtered = filtered.OrderBy(r => r.Urgency);
            else
                filtered = filtered.OrderBy(r => r.ReqDate);

            updateDataGridView(dgvList, filtered.ToList());
        }

        private void btnDelView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelEmail.Text))
            {
                MessageBox.Show("Email non inserita");
                return;
            }
            var users = requests.Where(r => r.Email == txtDelEmail.Text.Trim().ToLower());
            updateDataGridView(dgvList, users.ToList());

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelEmail.Text))
            {
                MessageBox.Show("Email non inserita");
                return;
            }

            string email = txtDelEmail.Text.Trim().ToLower();

            var toDel = requests.Where(r => r.Email == email).ToList();

            foreach(var r in toDel)
            {
                r.Dispose();
                requests.Remove(r);
            }
            MessageBox.Show($"removed: {toDel.Count} request/s");
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMatUrgencyMin.Text, out int u_min))
            {
                MessageBox.Show("Urgenza e' un numero intero");
                return;
            }
            if (!int.TryParse(txtMatUrgencyMax.Text, out int u_max))
            {
                MessageBox.Show("Urgenza e' un numero intero");
                return;
            }

            var filtered = requests.Where(r => r.Urgency >= u_min && r.Urgency <= u_max && r.Resolved);
            updateDataGridView(dgvList, filtered.ToList());
            var sum_tick = filtered.Sum(r => r.TimeToResolve().Value.Ticks);
            var sum_timespam = TimeSpan.FromTicks(sum_tick);

            lblMat.Text = $"ticks:{sum_tick}, {sum_timespam.ToString()}";
        }
    }
}
