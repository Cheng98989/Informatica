using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoOrderByAscending.Checked = true;
            rdoViewOrderById.Checked = true;
        }
        private void btnOpenProgram_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            fileDialog.Title = "Select a Program to Open";
            fileDialog.Multiselect = false;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show($"Selected Program: {fileDialog.FileName}", "Program Selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    
                    var p = Process.Start(fileDialog.FileName);
                    MessageBox.Show($"Nuovo processo {p.Id}, {p.ProcessName} avviato");
                }
            }
            UpdateProcessList(Process.GetProcesses().ToList());
        }
        private void dgvProcess_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProcess.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProcess.SelectedRows[0];
                txtId.Text = selectedRow.Cells["PID"].Value.ToString();
                txtName.Text = selectedRow.Cells["Nome"].Value.ToString();
            }
        }

        private void UpdateProcessList(List<Process> processes)
        {
            dgvProcess.DataSource = null;

            var toShow = processes.Where(p => !p.HasExited);

            toShow = rdoViewOrderById.Checked
                ? rdoOrderByAscending.Checked
                    ? processes.OrderBy(p => p.Id)
                    : processes.OrderByDescending(p => p.Id)
                : rdoOrderByAscending.Checked
                    ? processes.OrderBy(p => p.ProcessName)
                    : processes.OrderByDescending(p => p.ProcessName);

            dgvProcess.DataSource = toShow.Select(p =>
            new
            {
                PID = p.Id,
                Nome = p.ProcessName,
            }).ToList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            var all = Process.GetProcesses();
            UpdateProcessList(all.ToList());
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            var all = Process.GetProcesses();
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("No process selected");
                return;
            }
            if (!int.TryParse(txtId.Text, out int id) || id < 0)
            {
                MessageBox.Show("PID must be a positive number");
                return;
            }
            var toDel = all.FirstOrDefault(p => p.Id == id);
            try
            {
                if (toDel != null)
                    toDel.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error killing process: {ex.Message}");
                return;
            }
            UpdateProcessList(all.ToList());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("No process selected");
                return;
            }
            var all = Process.GetProcessesByName(txtName.Text.Trim());

            UpdateProcessList(all.ToList());
            MessageBox.Show($"{all.Length} instanze di {txtName.Text.Trim()} trovate");
        }
    }
}
