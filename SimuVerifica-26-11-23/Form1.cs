using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuVerifica_26_11_23
{
    public partial class Form1 : Form
    {
        List<ComboBox> teamLeadComboboxs = new List<ComboBox>() { };
        Dictionary<string, TeamLead> teamLeads = new Dictionary<string, TeamLead>()
        {
            {"TA000", new TeamLead("TA000","MARCO", "ROSSI", 4) },
            {"TA001", new TeamLead("TA001","LUCA", "BROWN", 1) },
            {"TA002", new TeamLead("TA002","CHIARA", "BIANCHI", 8) },
        };
        List<Project> projects = new List<Project>()
        {
            
        };


        public Form1()
        {
            InitializeComponent();


            projects.Add(new Project("PROJ-2000-001", "ALFA", "NVIDIA COPIA", Project.Stati[0], 10000, new DateTime(2026, 10, 11), new DateTime(2027, 11, 1), teamLeads["TA000"]));
            projects.Add(new Project("PROJ-2000-002", "BETA", "AMD COPIA", Project.Stati[1], 15000, new DateTime(2020, 4, 11), new DateTime(2029, 6, 10), teamLeads["TA000"]));
            projects.Add(new Project("PROJ-2000-003", "GAMMA", "INTEL COPIA", Project.Stati[2], 20000, new DateTime(2024, 1, 11), new DateTime(2027, 11, 4), teamLeads["TA001"]));

            teamLeadComboboxs.Add(cboProjSavLead);
            teamLeadComboboxs.Add(cboProjModLead);

            cboProjSavState.Items.Clear();
            cboProjModState.Items.Clear();
            foreach(var i in Project.Stati)
            {
                cboProjModState.Items.Add(i);
                cboProjSavState.Items.Add(i);
            }

            updateTeamLeadComboboxs();
        }
        private void updateDataGridView<T>(List<T> l)
        {
            dgvViewer.DataSource = null;
            dgvViewer.DataSource = l;
        }

        private void updateTeamLeadComboboxs()
        {
            foreach(var i in teamLeadComboboxs)
            {
                i.Items.Clear();
            }
            foreach(var i in teamLeads)
            {
                foreach (var c in teamLeadComboboxs)
                {
                    c.Items.Add(i.Value.Id);
                }
            }
        }
        private void btnLeadSav_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLeadSavId.Text) ||
                string.IsNullOrEmpty(txtLeadSavName.Text) ||
                string.IsNullOrEmpty(txtLeadSavSurname.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            TeamLead l;
            try
            {
                l = new TeamLead(
                    txtLeadSavId.Text,
                    txtLeadSavName.Text,
                    txtLeadSavSurname.Text,
                    (int)nudLeadSavExp.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            teamLeads.Add(l.Id,l);

            updateDataGridView(teamLeads.Values.ToList());
            updateTeamLeadComboboxs();
        }

        private void btnProjSav_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtProjSavId.Text) ||
                string.IsNullOrEmpty(txtProjSavName.Text) ||
                string.IsNullOrEmpty(txtProjSavDesc.Text) ||
                string.IsNullOrEmpty(cboProjSavState.Text) ||
                string.IsNullOrEmpty(cboProjSavLead.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            if (!teamLeads.ContainsKey(cboProjSavLead.Text))
            {
                MessageBox.Show("Team lead non esiste");
                return;
            }


            Project p;
            try
            {
                p = new Project(
                    txtProjSavId.Text,
                    txtProjSavName.Text,
                    txtProjSavDesc.Text,
                    cboProjSavState.Text,
                    nudProjSavBudget.Value,
                    dtpProjSavStart.Value,
                    dtpProjSavEnd.Value,
                    teamLeads[cboProjSavLead.Text]
                    );
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            projects.Add(p);
            updateDataGridView(projects);
        }

        private void btnLeadModSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLeadModId.Text))
            {
                MessageBox.Show("Non esiste team lead");
                return;
            }

            
            if(!teamLeads.ContainsKey(txtLeadModId.Text))
            {
                MessageBox.Show("Non inserito");
                return;
            }

            lblLeadModId.Text = teamLeads[txtLeadModId.Text].Id;
            txtLeadModName.Text = teamLeads[txtLeadModId.Text].Name;
            txtLeadModSurname.Text = teamLeads[txtLeadModId.Text].Surname;
            nudLeadModExp.Value= teamLeads[txtLeadModId.Text].Experience;
        }

        private void btnLeadMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblLeadModId.Text))
            {
                MessageBox.Show("Non inserito team lead");
                return;
            }


            if (!teamLeads.ContainsKey(lblLeadModId.Text))
            {
                MessageBox.Show("Non esiste");
                return;
            }

            try
            {
                teamLeads[lblLeadModId.Text].Name = txtLeadModName.Text;
                teamLeads[lblLeadModId.Text].Surname = txtLeadModSurname.Text;
                teamLeads[lblLeadModId.Text].Experience = (int)nudLeadModExp.Value;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            updateDataGridView(teamLeads.Values.ToList());
        }

        private void btnViewLead_Click(object sender, EventArgs e)
        {
            updateDataGridView(teamLeads.Values.ToList());
        }

        private void btnViewProj_Click(object sender, EventArgs e)
        {
            updateDataGridView(projects.Select(p => new
            {
                p.Id,
                Progetto = p.Name,
                Descrizione = p.Description,
                DataInizio = p.StartDate,
                DataFine = p.EndDate,
                Stato = p.State,
                p.Budget,
                LeadNome = p.Lead.Name,
                LeadCognome = p.Lead.Surname,
            }).ToList()
                );
        }

        private void btnProjModSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProjModId.Text))
            {
                MessageBox.Show("Non inserito");
                return;
            }


            var sel = projects.FirstOrDefault(p => p.Id == txtProjModId.Text);
            if (sel == null)
            {
                MessageBox.Show("Non esiste");
                return;
            }

            lblProjModId.Text = sel.Id;
            txtProjModName.Text = sel.Name;
            txtProjModDesc.Text = sel.Description;
            cboProjModState.Text = sel.State;
            dtpProjModStart.Value= sel.StartDate;
            dtpProjModEnd.Value = sel.EndDate;
            cboProjModLead.Text = sel.Lead.Id;
            nudProjModBuget.Value = sel.Budget;
        }

        private void btnProjMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblProjModId.Text))
            {
                MessageBox.Show("Non inserito");
                return;
            }


            var sel = projects.FirstOrDefault(p => p.Id == lblProjModId.Text);
            if (sel == null)
            {
                MessageBox.Show("Non esiste");
                return;
            }

            if(!teamLeads.ContainsKey(cboProjModLead.Text))
            {
                MessageBox.Show("Non esiste il lead");
                return;
            }


            try
            {

                sel.Name = txtProjModName.Text;
                sel.Description = txtProjModDesc.Text;
                sel.Budget = nudProjModBuget.Value;
                sel.State = cboProjModState.Text;
                sel.StartDate = dtpProjModStart.Value;
                sel.EndDate = dtpProjModEnd.Value;
                sel.Lead = teamLeads[cboProjModLead.Text];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void btnProjDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProjDelId.Text))
            {
                MessageBox.Show("Non inserito");
                return;
            }
            var sel = projects.FirstOrDefault(p => p.Id == txtProjDelId.Text);
            if (sel == null)
            {
                MessageBox.Show("Non esiste");
                return;
            }

            sel.Dispose();
            projects.Remove(sel);
        }

        private void txtLeadDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLeadDelId.Text))
            {
                MessageBox.Show("Non inserito team lead");
                return;
            }


            if (!teamLeads.ContainsKey(txtLeadDelId.Text))
            {
                MessageBox.Show("Non esiste");
                return;
            }

            var assegnatiNonCancellabili = projects.Where(p => p.Lead.Equals(teamLeads[txtLeadDelId.Text]) && (p.State == Project.Stati[0] || p.State == Project.Stati[2])).ToList();
            if(assegnatiNonCancellabili.Count > 0)
            {
                string[] a = new string[assegnatiNonCancellabili.Count];
                
                for(int i = 0; i<assegnatiNonCancellabili.Count; i++)
                {
                    a[i] = assegnatiNonCancellabili[i].Id;
                }

                MessageBox.Show($"Il teamlead e' ancora occupato nei seguenti progetti\n" +
                    $"{string.Join(", ", a)}");
                return;
            }

            teamLeads[txtLeadDelId.Text].Dispose();
            teamLeads.Remove(txtLeadDelId.Text);
            updateTeamLeadComboboxs();
            updateDataGridView(teamLeads.Values.ToList());
        }
    }
}
