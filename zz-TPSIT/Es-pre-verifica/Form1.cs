using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_pre_verifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            int numSportelli = (int)nudSportelli.Value;
            string[] clienti = IstanziaClienti((int)nudClienti.Value);
            int clientiCount = clienti.Count();

            Sportello[] sportelli = new Sportello[numSportelli];
            for(var i = 0; i < numSportelli; i++)
            {
                int x = 20 + i * 150;
                int y = 200;

                sportelli[i].label = newSportelloLabel(new Point(x, y));
                sportelli[i].label.Show();
                this.Controls.Add(sportelli[i].label);
            }

        }

        public enum Stato
        {
            LIBERO,
            IN_SERVIZIO,
            CHIUSO,

        }

        private void ServizioSportello(Sportello s, ref int countCliente, string[] clienti, ListBox l)
        {
            Random rnd = new Random();
            while(countCliente < clienti.Length)
            {
                Invoke(new Action(() =>
                {
                    int index = countCliente;
                    s.label.Text = Enum.GetName(typeof(Stato), Stato.IN_SERVIZIO);
                    l.Items.Add($"{clienti[]}");
                            }
                            ));
                int time = rnd.Next(1000, 3001);
                Thread.Sleep(time);
                Invoke(new Action(() =>
                {
                    s.label.Text = Enum.GetName(typeof(Stato), Stato.LIBERO);
                }
                ));
            }
            


        }

        private string[] IstanziaClienti(int numero)
        {
            string[] s = new string[numero];
            for(int i = 0; i < s.Count(); i++)
            {
                s[i] = $"Cliente n. {i + 1}";
            }
            return s;
        }

        private Label newSportelloLabel(Point location)
        {
            Label l = new Label();
            l.AutoSize = false;
            l.BackColor = Color.LightGray;
            l.Text = Enum.GetName(typeof(Stato), Stato.LIBERO);
            l.Location = location;
            return l;
        }
        public struct Sportello
        {
            public int count;
            public Label label;
        }
        //public class Sportello
        //{
        //    private Random rnd;
        //    private Label _obj;
        //    public Label label => _obj;

        //    private int _serviti;
        //    public int Serviti => _serviti;
        //    //public string ServizioCliente()
        //    //{
        //    //    label.Text = Enum.GetName(typeof(Stato), Stato.IN_SERVIZIO);
        //    //    Thread.Sleep(rnd.Next(1000,3001));
        //    //    _serviti++;
        //    //    label.Text = Enum.GetName(typeof(Stato), Stato.IN_SERVIZIO);

        //    //}
        //    public Sportello(Label l, )
        //}
    }
}
