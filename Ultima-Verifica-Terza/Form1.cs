using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public Form1()
        {
            InitializeComponent();

            //#region Preinseriti
            //rilevamenti[count].id = 1;
            //rilevamenti[count].pilota = "marco ferrari";
            //rilevamenti[count].team = "ferrari";
            //rilevamenti[count].velocitaMax = 250;
            //rilevamenti[count].mescola = "soft";
            //rilevamenti[count].tempoGiro.minuti = 10;
            //rilevamenti[count].tempoGiro.secondi = 50;
            //rilevamenti[count].tempoGiro.millisecondi = 400;
            //count++;

            //rilevamenti[count].id = 5;
            //rilevamenti[count].pilota = "alberto redbull";
            //rilevamenti[count].team = "redbull";
            //rilevamenti[count].velocitaMax = 400;
            //rilevamenti[count].mescola = "hard";
            //rilevamenti[count].tempoGiro.minuti = 9;
            //rilevamenti[count].tempoGiro.secondi = 12;
            //rilevamenti[count].tempoGiro.millisecondi = 200;
            //count++;

            //rilevamenti[count].id = 10;
            //rilevamenti[count].pilota = "antonio antonini";
            //rilevamenti[count].team = "antonini";
            //rilevamenti[count].velocitaMax = 112;
            //rilevamenti[count].mescola = "soft";
            //rilevamenti[count].tempoGiro.minuti = 20;
            //rilevamenti[count].tempoGiro.secondi = 34;
            //rilevamenti[count].tempoGiro.millisecondi = 210;
            //count++;
            //#endregion

        }
        MyLib.Rilevamento[] rilevamenti = new MyLib.Rilevamento[100];
        int count = default;
        private void btnSav_Click(object sender, EventArgs e)
        {
            if(count > 99)
            {
                MessageBox.Show("Archivio Pieno");
                return;
            }

            if(string.IsNullOrEmpty(txtSavId.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavPilota.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavTeam.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavVelocita.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavMescola.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavMin.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavSec.Text.Trim()) ||
                string.IsNullOrEmpty(txtSavMilSec.Text.Trim()))
            {
                MessageBox.Show("dati mancanti");
                return;
            }

            MyLib.Rilevamento r = default;

            if(!int.TryParse(txtSavId.Text.Trim(), out r.id))
            {
                MessageBox.Show("ID è un intero");
                return;
            }

            if(MyLib.FindRilevamentoIndexById(r.id,rilevamenti,count) != -1)
            {
                MessageBox.Show("ID già occupato");
                return;
            }

            if (!int.TryParse(txtSavVelocita.Text.Trim(), out r.velocitaMax) || r.velocitaMax < 0)
            {
                MessageBox.Show("velocità è un intero non negativo");
                return;
            }

            if (!int.TryParse(txtSavMin.Text.Trim(), out r.tempoGiro.minuti) || r.tempoGiro.minuti < 0)
            {
                MessageBox.Show("Minuti è un intero non negativo");
                return;
            }
            if (!int.TryParse(txtSavSec.Text.Trim(), out r.tempoGiro.secondi) || r.tempoGiro.secondi < 0 || r.tempoGiro.secondi > 59)
            {
                MessageBox.Show("Secondi è un intero non negativo [0-59]");
                return;
            }
            if (!int.TryParse(txtSavMilSec.Text.Trim(), out r.tempoGiro.millisecondi) || r.tempoGiro.millisecondi < 0 || r.tempoGiro.millisecondi > 999)
            {
                MessageBox.Show("Millisecondi è un intero non negativo [0-999]");
                return;
            }

            r.pilota = txtSavPilota.Text.Trim();
            r.team = txtSavTeam.Text.Trim();
            r.mescola = txtSavMescola.Text.Trim();

            rilevamenti[count] = r;
            count++;
            MessageBox.Show("Rilevamento archiviato");
            

        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                MessageBox.Show("Archivio Vuoto");
                return;
            }

            lsvVisOutput.Items.Clear();
            int x = default;
            while(x < count)
            {
                lsvVisOutput.Items.Add(MyLib.RilevamentoToString(rilevamenti[x]));
                x++;
            }
        }

        private void btnModCerca_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                MessageBox.Show("Archivio Vuoto");
                return;
            }

            if (!int.TryParse(txtModInputId.Text.Trim(), out int id))
            {
                MessageBox.Show("ID è un intero");
                return;
            }
            int index = MyLib.FindRilevamentoIndexById(id, rilevamenti, count);
            if ( index == -1)
            {
                MessageBox.Show("ID non trovato");
                return;
            }

            txtModId.Text = rilevamenti[index].id.ToString();
            txtModPilota.Text = rilevamenti[index].pilota;
            txtModTeam.Text = rilevamenti[index].team;
            txtModVelocita.Text = rilevamenti[index].velocitaMax.ToString();
            txtModMescola.Text = rilevamenti[index].mescola;
            txtModMin.Text = rilevamenti[index].tempoGiro.minuti.ToString();
            txtModSec.Text = rilevamenti[index].tempoGiro.secondi.ToString();
            txtModMilSec.Text = rilevamenti[index].tempoGiro.millisecondi.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModId.Text.Trim()) ||
                string.IsNullOrEmpty(txtModPilota.Text.Trim()) ||
                string.IsNullOrEmpty(txtModTeam.Text.Trim()) ||
                string.IsNullOrEmpty(txtModVelocita.Text.Trim()) ||
                string.IsNullOrEmpty(txtModMescola.Text.Trim()) ||
                string.IsNullOrEmpty(txtModMin.Text.Trim()) ||
                string.IsNullOrEmpty(txtModSec.Text.Trim()) ||
                string.IsNullOrEmpty(txtModMilSec.Text.Trim()))
            {
                MessageBox.Show("dati mancanti");
                return;
            }

            MyLib.Rilevamento r = default;

            if (!int.TryParse(txtModId.Text.Trim(), out r.id))
            {
                MessageBox.Show("ID è un intero");
                return;
            }

            int index = MyLib.FindRilevamentoIndexById(r.id, rilevamenti, count);
            if (index == -1)
            {
                MessageBox.Show("ID non trovato");
                return;
            }
            if (!int.TryParse(txtModVelocita.Text.Trim(), out r.velocitaMax) || r.velocitaMax < 0)
            {
                MessageBox.Show("velocità è un intero non negativo");
                return;
            }
            if (!int.TryParse(txtModMin.Text.Trim(), out r.tempoGiro.minuti) || r.tempoGiro.minuti < 0)
            {
                MessageBox.Show("Minuti è un intero non negativo");
                return;
            }
            if (!int.TryParse(txtModSec.Text.Trim(), out r.tempoGiro.secondi) || r.tempoGiro.secondi < 0 || r.tempoGiro.secondi > 59)
            {
                MessageBox.Show("Secondi è un intero non negativo [0-59]");
                return;
            }
            if (!int.TryParse(txtModMilSec.Text.Trim(), out r.tempoGiro.millisecondi) || r.tempoGiro.millisecondi < 0 || r.tempoGiro.millisecondi > 999)
            {
                MessageBox.Show("Millisecondi è un intero non negativo  [0-999]");
                return;
            }

            r.pilota = txtModPilota.Text.Trim();
            r.team = txtModTeam.Text.Trim();
            r.mescola = txtModMescola.Text.Trim();
            rilevamenti[index] = r;
            MessageBox.Show("Modificato con successo");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = default;
            if (!int.TryParse(txtDelInputId.Text.Trim(), out id))
            {
                MessageBox.Show("ID è un intero");
                return;
            }

            int index = MyLib.FindRilevamentoIndexById(id, rilevamenti, count);
            if (index == -1)
            {
                MessageBox.Show("ID non trovato");
                return;
            }

            MyLib.Elimina(index, rilevamenti, ref count);
            MessageBox.Show("Eliminato con successo");
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                MessageBox.Show("Archivio Vuoto");
                return;
            }
            int index = MyLib.IndexMaxVelMaxInRilevamento(rilevamenti, count);
            lblAnaOutput.Text = $"PILOTA: {rilevamenti[index].pilota}, TEAM: {rilevamenti[index].team}, Velocità MAX: {rilevamenti[index].velocitaMax} km/h";
        }

        private void btnDisWrite_Click(object sender, EventArgs e)
        {
            if(!MyLib.RilevamentiStreamWriter("rilevamenti.txt", rilevamenti, count))
            {
                MessageBox.Show("Salvaggio file fallito");
                return;
            }
            MessageBox.Show($"{count} rilevamento/i salvato/i in rilevamenti.txt");
        }

        private void btnDisRead_Click(object sender, EventArgs e)
        {
            if(!MyLib.RilevamentiStreamReader("rilevamenti.txt", rilevamenti, ref count))
            {
                MessageBox.Show("Caricamento file fallito");
                return;
            }
            MessageBox.Show($"{count} rilevamento/i caricato/i da rilevamenti.txt");
        }

        private void btnRic_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                MessageBox.Show("Archivio Vuoto");
                return;
            }

            int millisecondi = MyLib.SommaTempiRicorsiva(count - 1, rilevamenti);
            
            MessageBox.Show(MyLib.TempoToString(MyLib.millisecondiToTempo(millisecondi)));
        }
    }
}
