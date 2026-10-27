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
        List<TurnoOspedaliero> turni = new List<TurnoOspedaliero>()
        {
            new TurnoOspedaliero(
                "1a",
                "marco",
                "bianchi",
                "Medico",
                "Pronto Soccorso",
                new DateTime(2026, 10, 21,10,00,00),
                new DateTime(2026, 10, 21,12,00,00),
                new DateTime(2026, 10, 21,19,00,00)
                ),
            new TurnoOspedaliero(
                "1b",
                "marco",
                "bianchi",
                "Medico",
                "Pronto Soccorso",
                new DateTime(2026, 10, 22,0,00,00),
                new DateTime(2026, 10, 22,6,00,00),
                new DateTime(2026, 10, 22,10,00,00)
                ),
            new TurnoOspedaliero(
                "1c",
                "marco",
                "bianchi",
                "Medico",
                "Pronto Soccorso",
                new DateTime(2026, 10, 26,10,00,00),
                new DateTime(2026, 10, 26,12,00,00),
                new DateTime(2026, 10, 26,19,00,00)
                ),
            new TurnoOspedaliero(
                "2b",
                "chiara",
                "rossi",
                "Infermiere",
                "Pronto Soccorso",
                new DateTime(2026, 10, 25,16,00,00),
                new DateTime(2026, 10, 25,20,00,00),
                new DateTime(2026, 10, 26,3,00,00)
                ),
            new TurnoOspedaliero(
                "3c",
                "giovanni",
                "brown",
                "Infermiere",
                "Pediatra",
                new DateTime(2026, 10, 25,13,00,00),
                new DateTime(2026, 10, 25,19,00,00),
                new DateTime(2026, 10, 26,1,00,00)
                ),
        };




        public Form1()
        {
            InitializeComponent();
            cboSavDepart.Items.Clear();
            

            foreach(var i in TurnoOspedaliero.Departmens)
            {
                cboSavDepart.Items.Add(i);
                cboModDepart.Items.Add(i);
                cboFilDepart.Items.Add(i);
            }

            cboSavType.Items.Clear();
            foreach (var i in TurnoOspedaliero.Categories)
            {
                cboSavType.Items.Add(i);
                cboModType.Items.Add(i);
            }
            UpdateDgv(turni);
        }

        private void UpdateDgv(List<TurnoOspedaliero> l)
        {
            dgvViewer.DataSource = null;
            dgvViewer.DataSource = l;
        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSavId.Text) ||
                string.IsNullOrEmpty(txtSavName.Text) ||
                string.IsNullOrEmpty(txtSavSurname.Text) ||
                string.IsNullOrEmpty(cboSavType.Text) ||
                string.IsNullOrEmpty(cboSavDepart.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            TurnoOspedaliero t;

            try
            {
                t = new TurnoOspedaliero(
                    txtSavId.Text,
                    txtSavName.Text,
                    txtSavSurname.Text,
                    cboSavType.Text,
                    cboSavDepart.Text,
                    dtpSavRegDate.Value.Date + dtpSavRegTime.Value.TimeOfDay,
                    dtpSavStaDate.Value.Date + dtpSavStaTime.Value.TimeOfDay,
                    dtpSavEndDate.Value.Date + dtpSavEndTime.Value.TimeOfDay
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            turni.Add(t);
            UpdateDgv(turni);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            UpdateDgv(turni);
        }

        private void btnModSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModId.Text))
            {
                MessageBox.Show("Id MANCANTE");
                return;
            }

            TurnoOspedaliero selected = turni.FirstOrDefault(t => t.IdTurno == txtModId.Text);

            if(selected == null)
            {
                MessageBox.Show("ID non trovato");
                return;
            }

            lblModId.Text = selected.IdTurno;
            txtModName.Text = selected.NomePersonale;
            txtModSurname.Text = selected.CognomePersonale;
            cboModType.Text = selected.TipoPersonale;
            cboModDepart.Text = selected.Reparto;

            dtpModRegDate.Value = selected.DataTurno;
            dtpModRegTime.Value = selected.DataTurno;

            dtpModStaDate.Value = selected.OraInizio;
            dtpModStaTime.Value = selected.OraInizio;

            dtpModEndDate.Value = selected.OraFine;
            dtpModEndTime.Value = selected.OraFine;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblModId.Text) ||
                string.IsNullOrEmpty(txtModName.Text) ||
                string.IsNullOrEmpty(txtModSurname.Text) ||
                string.IsNullOrEmpty(cboModType.Text) ||
                string.IsNullOrEmpty(cboModDepart.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            TurnoOspedaliero selected = turni.FirstOrDefault(t => t.IdTurno == txtModId.Text);

            if (selected == null)
            {
                MessageBox.Show("ID non trovato");
                return;
            }

            try
            {
                selected.NomePersonale = txtModName.Text;
                selected.CognomePersonale = txtModSurname.Text;
                selected.Reparto= cboModDepart.Text;
                selected.TipoPersonale= cboModType.Text;
                selected.DataTurno= dtpModRegDate.Value.Date + dtpModRegTime.Value.TimeOfDay;
                selected.OraInizio = dtpModStaDate.Value.Date + dtpModStaTime.Value.TimeOfDay;
                selected.OraFine = dtpModEndDate.Value.Date + dtpModEndTime.Value.TimeOfDay;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            UpdateDgv(turni);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelId.Text))
            {
                MessageBox.Show("Id MANCANTE");
                return;
            }

            TurnoOspedaliero selected = turni.FirstOrDefault(t => t.IdTurno == txtDelId.Text);

            if (selected == null)
            {
                MessageBox.Show("ID non trovato");
                return;
            }

            selected.Dispose();
            turni.Remove(selected);
            UpdateDgv(turni);
            MessageBox.Show("Eliminato");
        }

        private void btnFilDepart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboFilDepart.Text))
            {
                MessageBox.Show("Selezionare reparto");
                return;
            }

            List<TurnoOspedaliero> toDisplay = turni.Where(t => t.Reparto == cboFilDepart.Text).ToList();

            UpdateDgv(toDisplay);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearchName.Text) ||
                string.IsNullOrEmpty(txtSearchSurname.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            DateTime start = dtpSearchStartDate.Value.Date + dtpSearchStartTime.Value.TimeOfDay;
            DateTime end = dtpSearchEndDate.Value.Date + dtpSearchEndTime.Value.TimeOfDay;

            var wanted = turni.Where(t => 
                t.NomePersonale == txtSearchName.Text
                && t.CognomePersonale == txtSearchSurname.Text
                && t.OraInizio > start
                && t.OraFine < end)
                .OrderBy(t => t.OraInizio)
                .OrderBy(t => t.DataTurno);

            UpdateDgv(wanted.ToList());
            
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text) ||
                string.IsNullOrEmpty(txtSearchSurname.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            

            var minStart = turni.Min(t => t.OraInizio);
            var maxEnd = turni.Max(t => t.OraFine);

            var wanted = turni.Where(t =>
                t.NomePersonale == txtAnaName.Text && t.CognomePersonale == txtAnaSurname.Text
                &&
                t.OraInizio > minStart && t.OraInizio < maxEnd
                ||
                t.OraFine > minStart && t.OraFine < maxEnd
                )
                .ToList();

            lsvAna.Items.Clear();
            foreach (var item in wanted)
            {
                lsvAna.Items.Add(item.IdTurno);
            }

            UpdateDgv(wanted);
        }
    }
}
