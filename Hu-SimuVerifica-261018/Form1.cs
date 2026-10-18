using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hu_SimuVerifica_261018
{
    public partial class Form1 : Form
    {
        List<PartitaTorneo> partite = new List<PartitaTorneo>()
        {
            new PartitaTorneo(
                    "1",
                    "calcio",
                    new DateTime(2020,10,1),
                    "milan",
                    "napoli",
                    3,
                    2
                    ),
            new PartitaTorneo(
                    "2",
                    "calcio",
                    new DateTime(2026,10,15),
                    "usa",
                    "ita",
                    5,
                    0
                    ),
            new PartitaTorneo(
                    "3",
                    "calcio",
                    new DateTime(2020,10,1),
                    "milan",
                    "napoli",
                    5,
                    9
                    ),
            new PartitaTorneo(
                    "32",
                    "calcio",
                    new DateTime(2026,10,15),
                    "usa",
                    "ita",
                    1,
                    1
                    ),
        };


        public Form1()
        {
            InitializeComponent();
            FormFuncs.UpdateViewer(dgvViewer, partite);
        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSavId.Text) ||
                string.IsNullOrEmpty(txtSavName.Text) ||
                string.IsNullOrEmpty(txtSavNomeSq1.Text) ||
                string.IsNullOrEmpty(txtSavNomeSq2.Text) ||
                string.IsNullOrEmpty(txtSavPuntiSq1.Text) ||
                string.IsNullOrEmpty(txtSavPuntiSq2.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            if(!int.TryParse(txtSavPuntiSq1.Text, out int punti1))
            {
                MessageBox.Show("Punti squadra 1 sono un intero");
                return;
            }
            if (!int.TryParse(txtSavPuntiSq2.Text, out int punti2))
            {
                MessageBox.Show("Punti squadra 2 sono un intero");
                return;
            }

            PartitaTorneo p;
            try
            {
                p = new PartitaTorneo(
                    txtSavId.Text,
                    txtSavName.Text,
                    dtpSavDate.Value,
                    txtSavNomeSq1.Text,
                    txtSavNomeSq2.Text,
                    punti1,
                    punti2
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            partite.Add(p);

            FormFuncs.UpdateViewer(dgvViewer, partite);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormFuncs.UpdateViewer(dgvViewer, partite);
        }

        private void btnModSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModId.Text))
            {
                MessageBox.Show("Id mancante");
                return;
            }

            PartitaTorneo sel = partite.FirstOrDefault(p => p.CodicePartita == txtModId.Text);

            if(sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }

            lblModId.Text = sel.CodicePartita;
            txtModName.Text = sel.NomeGioco;
            txtModNomeSq1.Text = sel.NomeSquadra1;
            txtModNomeSq2.Text = sel.NomeSquadra2;
            txtModPuntiSq1.Text = sel.PunteggioSquadra1.ToString();
            txtModPuntiSq2.Text = sel.PunteggioSquadra2.ToString();
            dtpModData.Value = sel.DataPartita;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblModId.Text) ||
                string.IsNullOrEmpty(txtModName.Text) ||
                string.IsNullOrEmpty(txtModNomeSq1.Text) ||
                string.IsNullOrEmpty(txtModNomeSq2.Text) ||
                string.IsNullOrEmpty(txtModPuntiSq1.Text) ||
                string.IsNullOrEmpty(txtModPuntiSq2.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            if (!int.TryParse(txtModPuntiSq1.Text, out int punti1))
            {
                MessageBox.Show("Punti squadra 1 sono un intero");
                return;
            }
            if (!int.TryParse(txtModPuntiSq2.Text, out int punti2))
            {
                MessageBox.Show("Punti squadra 2 sono un intero");
                return;
            }

            PartitaTorneo sel = partite.FirstOrDefault(p => p.CodicePartita == lblModId.Text);

            if (sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }

            try
            {
                sel.NomeGioco = txtModName.Text;
                sel.NomeSquadra1 = txtModNomeSq1.Text;
                sel.NomeSquadra2 = txtModNomeSq2.Text;
                sel.PunteggioSquadra1 = punti1;
                sel.PunteggioSquadra2 = punti2;
                sel.DataPartita = dtpModData.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            FormFuncs.UpdateViewer(dgvViewer, partite);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelId.Text))
            {
                MessageBox.Show("Id mancante");
                return;
            }

            PartitaTorneo sel = partite.FirstOrDefault(p => p.CodicePartita == txtDelId.Text);

            if (sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }

            sel.Dispose();
            partite.Remove(sel);
            MessageBox.Show("ELIMINATO");
            FormFuncs.UpdateViewer(dgvViewer, partite);
        }

        private void btnFil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilName.Text))
            {
                MessageBox.Show("Nome gioco mancante");
                return;
            }

            List<PartitaTorneo> sel = partite.Where(p => p.NomeGioco == txtFilName.Text).ToList();

            FormFuncs.UpdateViewer(dgvViewer, sel);
        }

        private void btnFilNomeSq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilNomeSq.Text))
            {
                MessageBox.Show("Nome gioco mancante");
                return;
            }

            var sel = partite.Where(p => p.NomeSquadra1 == txtFilNomeSq.Text || p.NomeSquadra2 == txtFilNomeSq.Text).
                Select(p => new
                {
                    p.CodicePartita,
                    p.NomeGioco,
                    p.DataPartita,
                    p.NomeSquadra1,
                    p.NomeSquadra2,
                    Esito = p.SquadraVincente == txtFilNomeSq.Text
                        ? "VITTORIA"
                        : p.SquadraVincente == p.NomeSquadra1 || p.SquadraVincente == p.NomeSquadra2
                            ? "SCONFITTA"
                            : "PAREGGIO",
                    p.PunteggioSquadra1,
                    p.PunteggioSquadra2,
                });

            FormFuncs.UpdateViewer(dgvViewer, sel.ToList());
        }

        private void btnMaxPunti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaxName.Text))
            {
                MessageBox.Show("Nome gioco mancante");
                return;
            }

            var l = partite.Where(p => p.NomeGioco == txtMaxName.Text)
                .Select(p => new
                {
                    p.SquadraVincente,
                    score = p.PunteggioSquadra1 > p.PunteggioSquadra2
                        ? p.PunteggioSquadra1
                        : p.PunteggioSquadra2,
                })
                .OrderByDescending(p => p.score)
                .FirstOrDefault();

            label21.Text = $"{l.SquadraVincente} ha totalizzato {l.score} come recordi di punti assoluto";

        }

        private void btnSta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaxName.Text))
            {
                MessageBox.Show("Nome gioco mancante");
                return;
            }

            var l = partite.Where(p => p.NomeGioco == txtMaxName.Text);

            var aveWin = l.Where(p => p.SquadraVincente == p.NomeSquadra1 || p.SquadraVincente == p.NomeSquadra2)
                .Average(p => p.SquadraVincente == p.NomeSquadra1
                    ? p.PunteggioSquadra1
                    : p.PunteggioSquadra2
                    );
            var aveLos = l.Where(p => p.SquadraVincente == p.NomeSquadra1 || p.SquadraVincente == p.NomeSquadra2)
                .Average(p => p.SquadraVincente != p.NomeSquadra1
                    ? p.PunteggioSquadra1
                    : p.PunteggioSquadra2
                    );

            lblStaCount.Text = $"Partite: {l.ToList().Count}";
            lblStatAveWin.Text = $"Score: {aveWin}";
            lblStaAveLos.Text = $"Score: {aveLos}";
        }
    }
}
