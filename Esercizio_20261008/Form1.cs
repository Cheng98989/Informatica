using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_20261008
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>
        {
            #region Pre
            new Order(
                1,
                "Mario Rossi",
                "Via Roma 10, Milano",
                new DateTime(2026, 9, 15),
                125.50m,
                3
            ),

            new Order(
                2,
                "Luca Bianchi",
                "Via Dante 25, Torino",
                new DateTime(2026, 9, 16),
                450.00m,
                10
            ),

            new Order(
                3,
                "Anna Verdi",
                "Corso Italia 8, Milano",
                new DateTime(2026, 9, 17),
                78.90m,
                2
            ),

            new Order(
                4,
                "Mario Rossi",
                "Via Roma 10, Milano",
                new DateTime(2026, 9, 18),
                320.75m,
                5
            ),

            new Order(
                5,
                "Giulia Ferrari",
                "Via Garibaldi 42, Bologna",
                new DateTime(2026, 9, 19),
                1250.00m,
                20
            ),

            new Order(
                6,
                "Marco Esposito",
                "Via Napoli 17, Napoli",
                new DateTime(2026, 9, 20),
                89.99m,
                1
            ),

            new Order(
                7,
                "Luca Bianchi",
                "Via Dante 25, Torino",
                new DateTime(2026, 9, 21),
                675.40m,
                15
            ),

            new Order(
                8,
                "Francesca Romano",
                "Via Veneto 31, Roma",
                new DateTime(2026, 9, 22),
                2300.00m,
                25
            ),

            new Order(
                9,
                "Alessandro Conti",
                "Via Manzoni 5, Firenze",
                new DateTime(2026, 9, 23),
                55.75m,
                2
            ),

            new Order(
                10,
                "Anna Verdi",
                "Corso Italia 8, Milano",
                new DateTime(2026, 9, 24),
                910.20m,
                12
            ),

            new Order(
                11,
                "Stefano Galli",
                "Via Mazzini 14, Genova",
                new DateTime(2026, 9, 25),
                340.00m,
                8
            ),

            new Order(
                12,
                "Mario Rossi",
                "Via Roma 10, Milano",
                new DateTime(2026, 9, 26),
                150.00m,
                4
            ),

            new Order(
                13,
                "Elena Costa",
                "Via Torino 22, Parma",
                new DateTime(2026, 9, 27),
                2750.50m,
                30
            ),

            new Order(
                14,
                "Marco Esposito",
                "Via Napoli 17, Napoli",
                new DateTime(2026, 9, 28),
                199.99m,
                3
            ),

            new Order(
                15,
                "Chiara Moretti",
                "Via Cavour 19, Verona",
                new DateTime(2026, 9, 29),
                820.00m,
                10
            ),

            new Order(
                16,
                "Giulia Ferrari",
                "Via Garibaldi 42, Bologna",
                new DateTime(2026, 9, 30),
                4300.00m,
                50
            ),

            new Order(
                17,
                "Alessandro Conti",
                "Via Manzoni 5, Firenze",
                new DateTime(2026, 10, 1),
                65.30m,
                2
            ),

            new Order(
                18,
                "Francesca Romano",
                "Via Veneto 31, Roma",
                new DateTime(2026, 10, 2),
                1780.90m,
                18
            ),

            new Order(
                19,
                "Stefano Galli",
                "Via Mazzini 14, Genova",
                new DateTime(2026, 10, 3),
                540.00m,
                7
            ),

            new Order(
                20,
                "Elena Costa",
                "Via Torino 22, Parma",
                new DateTime(2026, 10, 4),
                9999.99m,
                100
            )
            #endregion
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSavId.Text)
                || string.IsNullOrEmpty(txtSavName.Text)
                || string.IsNullOrEmpty(txtSavAddress.Text)
                || string.IsNullOrEmpty(txtSavAmount.Text)
                || string.IsNullOrEmpty(txtSavCost.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            if (!int.TryParse(txtSavId.Text, out int id))
            {
                MessageBox.Show("ID e' intero");
                return;
            }

            if (!int.TryParse(txtSavAmount.Text, out int amount))
            {
                MessageBox.Show("Quantita' e' intero");
                return;
            }

            if (!decimal.TryParse(txtSavCost.Text, out decimal cost))
            {
                MessageBox.Show("Costo e' decimale");
                return;
            }

            Order order;
            //istanza
            try
            {
                order = new Order(
                    id,
                    txtSavName.Text,
                    txtSavAddress.Text,
                    dtpSavDate.Value,
                    cost,
                    amount);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            orders.Add(order);
            updateViewer(orders.ToList());
        }

        private void btnVie_Click(object sender, EventArgs e)
        {
            updateViewer(orders.ToList());
        }

        private void updateViewer(List<Order> list)
        {
            var sorted = rdoOrdName.Checked
                ? (rdoOrdAscendent.Checked
                    ? list.OrderBy(o => o.Name)
                    : list.OrderByDescending(o => o.Name))
                : (rdoOrdAscendent.Checked
                    ? list.OrderBy(o => o.Data)
                    : list.OrderByDescending(o => o.Data));

            var selected = sorted.Select(o => new
            {
                Id = o.Id,
                Cliente = o.Name,
                Indirizzo = o.Address,
                DataOrdine = o.Data,
                Quantita = o.Amount,
                Prezzo = o.TotalCost,
            });

            dgvViewer.DataSource = null;
            dgvViewer.DataSource = selected.ToList();
        }

        private void btnUpdSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdId.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }
            if (!int.TryParse(txtUpdId.Text, out int id))
            {
                MessageBox.Show("ID e' intero");
                return;
            }
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                MessageBox.Show("Ordine non trovato");
                return;
            }

            lblUpdId.Text = order.Id.ToString();
            txtUpdName.Text = order.Name;
            txtUpdAddres.Text = order.Address;
            txtUpdAmount.Text = order.Amount.ToString();
            txtUpdCost.Text = order.TotalCost.ToString();
            dtpUpdDate.Value = order.Data;


        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblUpdId.Text)
                || string.IsNullOrEmpty(txtUpdName.Text)
                || string.IsNullOrEmpty(txtUpdAddres.Text)
                || string.IsNullOrEmpty(txtUpdAmount.Text)
                || string.IsNullOrEmpty(txtUpdCost.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            if (!int.TryParse(lblUpdId.Text, out int id))
            {
                MessageBox.Show("ID e' intero");
                return;
            }

            if (!int.TryParse(txtUpdAmount.Text, out int amount))
            {
                MessageBox.Show("Quantita' e' intero");
                return;
            }

            if (!decimal.TryParse(txtUpdCost.Text, out decimal cost))
            {
                MessageBox.Show("Costo e' decimale");
                return;
            }

            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                MessageBox.Show("Ordine non trovato");
                return;
            }
            try
            {
                order.Name = txtUpdName.Text;
                order.Address = txtUpdAddres.Text;
                order.Amount = amount;
                order.TotalCost = cost;
                order.Data = dtpUpdDate.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            updateViewer(orders.ToList());
        }

        private void btnDelView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelName.Text))
            {
                MessageBox.Show("Nome mancante");
                return;
            }

            updateViewer(orders.Where(o => o.Name == txtDelName.Text).ToList());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelName.Text))
            {
                MessageBox.Show("Nome mancante");
                return;
            }
            var toDel = orders.Where(o => o.Name == txtDelName.Text).ToList();
            if (toDel.Count <= 0)
            {
                MessageBox.Show("Nessun ordine associato");
                return;
            }
            if(MessageBox.Show($"Sei sicuro di voler eliminare {toDel.Count} ordini","Conferma",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Eliminazione abolita");
                return;
            }
            foreach(var o in toDel)
            {
                orders.Remove(o);
                o.Dispose();
            }
            MessageBox.Show("Eliminazione completata");
            updateViewer(orders.ToList());
        }
    }
}
