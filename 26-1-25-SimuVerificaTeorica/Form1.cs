using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_1_25_SimuVerificaTeorica
{
    public partial class Form1 : Form
    {
        List<Noleggio> noleggi = new List<Noleggio>() { };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSavIdNole.Text) ||
                string.IsNullOrEmpty(txtSavIdClient.Text) ||
                string.IsNullOrEmpty(cboSavType.Text) ||
                string.IsNullOrEmpty(txtSavNote.Text))
            {
                MessageBox.Show("Dati Mancanti");
                return;
            }

            Noleggio n;

            try
            {
                n = new Noleggio(txtSavIdNole.Text, txtSavIdClient.Text, cboSavType.Text, txtSavNote.Text, dtpSavDate.Value.Date + dtpSavTime.Value.TimeOfDay);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            noleggi.Add(n);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtModId.Text) ||
                string.IsNullOrEmpty(txtModKilo.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }
            if(!float.TryParse(txtModKilo.Text, out float k))
            {
                MessageBox.Show("Kilometers e' un numero reale");
                return;
            }
            var selected = noleggi.FirstOrDefault(n => n.IdNoleggio == txtModId.Text);
            if(selected == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }
            try
            {
                selected.DataRiconsegna = dtpModData.Value.Date + dtpModTime.Value.TimeOfDay;
                selected.Kilometri = k;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Modificato");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboViewType.Text))
            {
                MessageBox.Show("Selezionare tipo bici");
                return;
            }
            var toDisplay = noleggi.Where(n => !n.DataRiconsegna.HasValue && n.Tipo == cboViewType.Text);
            toDisplay = rdoViewAsce.Checked
                ? toDisplay.OrderBy(n => n.DataRitiro)
                : toDisplay.OrderByDescending(n => DateTime.Now - n.DataRitiro);
            dgvView.DataSource = null;
            dgvView.DataSource = toDisplay.ToList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelId.Text))
            {
                MessageBox.Show("Dati mancati");
                return;
            }
            var selecteds = noleggi.Where(n => n.IdCliente == txtDelId.Text).ToList();
            foreach(var n in selecteds)
            {
                n.Dispose();
                noleggi.Remove(n);
            }
            MessageBox.Show($"Eliminati {selecteds.Count} noleggi");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCalcMin.Text) ||
                string.IsNullOrEmpty(txtCalcMax.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }
            if(!float.TryParse(txtCalcMin.Text, out float min))
            {
                MessageBox.Show("Min e' un numero reale");
                return;
            }
            if (!float.TryParse(txtCalcMax.Text, out float max))
            {
                MessageBox.Show("Max e' un numero reale");
                return;
            }
            var avarage = noleggi.Where(n => n.DataRiconsegna.HasValue
            && n.Kilometri >= min
            && n.Kilometri <= max)
                .Average(n => n.Durata());

            lblCalcOutput.Text = avarage.ToString();
        }

        private void btnTotale_Click(object sender, EventArgs e)
        {
            DateTime min = dtpTotMinDate.Value.Date + dtpTotMinDate.Value.TimeOfDay;
            DateTime max= dtpTotMaxDate.Value.Date + dtpTotMaxTime.Value.TimeOfDay;

            var riconsegnati = noleggi.Where(n => n.DataRiconsegna.HasValue);

            lstTot.Items.Clear();
            foreach(var t in Noleggio.Tipi)
            {
                decimal incasso = riconsegnati.Where(n => n.Tipo == t.Key).Sum(n => n.Incasso());
                lstTot.Items.Add($"Incasso {t.Key}: {incasso}");
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var sorted = noleggi.OrderBy(n => n.IdCliente).ToList();
            if(sorted.Count <= 0)
            {
                MessageBox.Show("Nessun elemento");
                return;
            }
            
            string current = sorted[0].IdCliente;
            string maxClient = current;
            int count = 1;
            int maxCount = count;

            for(int i = 1; i < sorted.Count; i++)
            {
                if (sorted[i].IdCliente == current)
                    count++;
                else
                {
                    if(count > maxCount)
                    {
                        maxCount = count;
                        maxClient = current;
                    }
                    count = 1;
                    current = sorted[i].IdCliente;
                }

            }

            lblStatsOutput.Text = $"idcliente: {maxClient}, count: {maxCount}";
        }

        private void btnNonRiconsegnati_Click(object sender, EventArgs e)
        {
            var nonConsegnati = noleggi.Where(n => !n.DataRiconsegna.HasValue && n.DataRitiro > DateTime.Now - TimeSpan.FromHours(24)).ToList();
            dgvNonRiconsegnati.DataSource = null;
            dgvNonRiconsegnati.DataSource = nonConsegnati;
        }
    }
}
