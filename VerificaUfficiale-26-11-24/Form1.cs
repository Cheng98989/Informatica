using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hu
{
    public partial class Form1 : Form
    {
        List<Squadra> squadre = new List<Squadra>() { };

        List<Partita> partite = new List<Partita>()
        {
            



        };



        public Form1()
        {
            InitializeComponent();

            squadre.Add(new Squadra("A001", "NAPOLI", "NAPOLI", 0, "BIANCHI"));
            squadre.Add(new Squadra("A002", "INTER", "MILANO", 0, "NERI"));
            squadre.Add(new Squadra("A003", "ATALANTA", "BERGAMO", 0, "POLENTA"));
            squadre.Add(new Squadra("A004", "VANEZIA", "VENEZIA", 0, "POLO"));

            partite.Add(new Partita("001", new DateTime(2026, 1, 1), squadre[0], squadre[1]));
            partite[0].SetResult(4, 2);
            partite.Add(new Partita("002", new DateTime(2026, 1, 2), squadre[2], squadre[3]));
            partite[1].SetResult(2, 2);
            partite.Add(new Partita("003", new DateTime(2027, 1, 1), squadre[0], squadre[1]));
            partite.Add(new Partita("004", new DateTime(2026, 10, 1), squadre[0], squadre[2]));
            partite[3].SetResult(1, 3);


            cboSavCasa.Items.Clear();
            foreach (var i in squadre)
            {
                cboSavCasa.Items.Add(i);
                cboSavOspite.Items.Add(i);
            }

        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSavId.Text) ||
                string.IsNullOrEmpty(cboSavOspite.Text) ||
                string.IsNullOrEmpty(cboSavCasa.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            Squadra casa = cboSavCasa.SelectedItem as Squadra;
            Squadra ospite = cboSavOspite.SelectedItem as Squadra;

            Partita p;
            try
            {
                p = new Partita
                    (
                    txtSavId.Text,
                    dtpSavDate.Value.Date + dtpSavTime.Value.TimeOfDay,
                    casa,
                    ospite
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            partite.Add(p);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelId.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            var sel = partite.FirstOrDefault(p => p.Id == txtDelId.Text);
            if (sel == null)
            {
                MessageBox.Show("Partita non presente");
                return;
            }
            if (sel.Giocata)
            {
                MessageBox.Show("Partita già disputata, impossibile elimintare");
                return;
            }

            sel.Dispose();
            partite.Remove(sel);
            MessageBox.Show("Eliminata");
        }

        private void btnViewClassifica_Click(object sender, EventArgs e)
        {
            updateDataGridView(squadre.OrderBy(s => s.NomeSquadra).OrderByDescending(s => s.Punti).ToList());
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResId.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            var sel = partite.FirstOrDefault(p => p.Id == txtResId.Text);
            if (sel == null)
            {
                MessageBox.Show("Partita non presente");
                return;
            }
            if (sel.Giocata)
            {
                MessageBox.Show("Partita già disputata, impossibile riassegnare punti, vai nella scheda modifica");
                return;
            }

            try
            {
                sel.SetResult((int)nudResCasa.Value, (int)nudResOspite.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            updateDataGridView(
                partite.Where(p => p.Giocata && (p.GoalCasa + p.GoalOspite) == (int)nudGoalNumber.Value).ToList()
                );
        }


        private void updateDataGridView<T>(List<T> l)
        {
            dgvViewer.DataSource = null;
            dgvViewer.DataSource = l;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModId.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            var sel = partite.FirstOrDefault(p => p.Id == txtModId.Text);
            if (sel == null)
            {
                MessageBox.Show("Partita non presente");
                return;
            }

            try
            {
                sel.ModifyResult((int)nudModCasa.Value, (int)nudModOspite.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btnViewPartite_Click(object sender, EventArgs e)
        {
            updateDataGridView(partite);
        }
    }
}
