using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supporto_Utenti__MS_4._2_
{
    public partial class Form1 : Form
    {
        List<Factory> factories = new List<Factory>() { };
        List<Product> products = new List<Product>() { };


        public Form1()
        {
            InitializeComponent();
        }
        #region Factory
        private void btnFactSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactSavId.Text) ||
                string.IsNullOrEmpty(txtFactSavName.Text) ||
                string.IsNullOrEmpty(txtFactSavTown.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            Factory f;
            try
            {
                f = new Factory(txtFactSavId.Text, txtFactSavName.Text, txtFactSavTown.Text, (int)nudFactSavMaxCap.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            factories.Add(f);
            MessageBox.Show("Added");


        }

        private void btnFactView_Click(object sender, EventArgs e)
        {
            dgvFact.DataSource = null;
            dgvFact.DataSource = factoryForDataGridView(factories).ToList();
        }

        private IEnumerable<object> factoryForDataGridView(List<Factory> f)
        {
            return f.Select(_f => new
            {
                _f.Id,
                RagioneSociale = _f.Name,
                Citta = _f.Town,
                Capacita = _f.MaxCapacity.ToString() + "/day",
                Categorie = string.Join(", ", _f.ProducedCategories)
            });
        }


        private void btnFactEditSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactEditId.Text))
            {
                MessageBox.Show("Inserire id");
                return;
            }

            var sel = factories.FirstOrDefault(f => f.Id == txtFactEditId.Text);
            if(sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }

            txtFactEditFoodCategories.Text = string.Join(", ", sel.ProducedCategories);
            txtFactEditCertifications.Text = sel.Certifications == null 
                ? ""
                : string.Join(", ", sel.Certifications);
        }
        private void btnFactEditFoodCateAndCertificationsSav_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFactEditId.Text))
            {
                MessageBox.Show("Inserire id");
                return;
            }

            var sel = factories.FirstOrDefault(f => f.Id == txtFactEditId.Text);
            if (sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }


            var certifications = txtFactEditCertifications.Text.Split(',');
            for (int i = 0; i < certifications.Length; i++)
            {
                certifications[i] = certifications[i].Trim();

            }
            var certValidi = new List<string>();
            for (int i = 0; i < certifications.Length; i++)
            {
                if (string.IsNullOrEmpty(certifications[i]))
                    continue;
                certValidi.Add(certifications[i]);
            }

            try
            {
                var foodStrings = txtFactEditFoodCategories.Text.Split(',');
                for (int i = 0; i < foodStrings.Length; i++)
                {
                    foodStrings[i] = foodStrings[i].Trim();
                }

                List<FoodCategory> foodOk = new List<FoodCategory>();
                foreach (var i in foodStrings)
                {
                    if (string.IsNullOrEmpty(i))
                        foodOk.Add(new FoodCategory(i));
                }


                sel.SetCertifications(certValidi);
                sel.SetProducedCategories(foodOk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        #endregion

        #region Prodotto
        private void btnProdSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdSavId.Text) ||
                string.IsNullOrEmpty(txtProdSavName.Text) ||
                string.IsNullOrEmpty(cboProdSavCategoria.Text))
            {
                MessageBox.Show("Dati mancanti");
                return;
            }

            Product p;
            try
            {
                p = new Product(txtProdSavId.Text, txtProdSavName.Text, new FoodCategory(cboProdSavCategoria.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            products.Add(p);
            MessageBox.Show("Added");
        }
        #endregion

        private void btnProdEditSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdEditId.Text))
            {
                MessageBox.Show("Inserire id");
                return;
            }

            var sel = products.FirstOrDefault(f => f.Id == txtProdEditId.Text);
            if (sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }
            txtProdEditCertifications.Text = sel.Certification;
        }

        private void btnProdEditApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdEditId.Text))
            {
                MessageBox.Show("Inserire id");
                return;
            }

            var sel = products.FirstOrDefault(f => f.Id == txtProdEditId.Text);
            if (sel == null)
            {
                MessageBox.Show("Non trovato");
                return;
            }

            sel.Certification = txtProdEditCertifications.Text;
        }

        private void btnProdView_Click(object sender, EventArgs e)
        {
            dgvProd.DataSource = null;
            dgvProd.DataSource = prodForDataGridView(products).ToList();
        }


        private IEnumerable<object> prodForDataGridView(List<Product> f)
        {
            return f.Select(_f => new
            {
                _f.Id,
                Prodotto = _f.Name,
                Categoria = _f.Category,
                Certificato = _f.Certification,
            });
        }
    }
}
