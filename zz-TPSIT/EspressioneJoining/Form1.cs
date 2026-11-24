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

namespace EspressioneJoining
{
    public partial class Form1 : Form
    {
        

        double prodotto = 0;
        double somma = 0;
        double quoziente = 0;
        double somma2 = 0;

        const double costante = 2;


        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread raddoppia;
            Thread incrementa2;
            Thread divisione;
            Thread sommaFattori;

            raddoppia = new Thread(() => { prodotto = operazione(Operatore.Moltiplicazione,(double)nudB.Value, costante); });
            incrementa2 = new Thread(() => { somma = operazione(Operatore.Addizione, (double)nudC.Value, costante); });
            
            divisione = new Thread(() => { quoziente = operazione(Operatore.Divisione, prodotto, somma); });
            sommaFattori = new Thread(() => { somma2 = operazione(Operatore.Addizione, (double)nudA.Value, quoziente); });

            Thread t = new Thread(() => Operazione(raddoppia, incrementa2, divisione, sommaFattori));
            t.Start();
        }

        private void Write(string m)
        {
            lstOutput.Invoke(new Action(() =>
            {
                lstOutput.Items.Add(m);
            }));
        }

        private void Operazione(
            Thread raddoppia,
            Thread incrementa2,
            Thread divisione,
            Thread sommaFattori
            )
        {
            raddoppia.Start();
            incrementa2.Start();

            raddoppia.Join();
            incrementa2.Join();

            Write($"{costante}b = {prodotto}");
            Write($"c + {costante} = {somma}");

            divisione.Start();

            divisione.Join();
            Write($"{costante}b/(c + {costante}) = {quoziente}");

            sommaFattori.Start();
            sommaFattori.Join();
            Write($"a + {costante}b/(c + {costante}) = {somma2}");
            Write($"Operazione finita, risultato finale: {somma2}");
        }



        private double Raddoppia(double b)
        {
            return 2 * b;
        }
        private double Incrementa2(double c)
        {
            return c + 2;
        }
        private double Divisione(double n, double m)
        {
            if (m == 0)
                MessageBox.Show("Divisore è zero");
            return n / m;
        }
        private double SommaA(double a, double n)
        {
            return a + n;
        }


        //private void AttendiThread
        //{

        //}





        enum Operatore
        {
            Addizione,
            Sottrazione,
            Moltiplicazione,
            Divisione,
        }

        private double operazione(Operatore operazione, double a, double b)
        {
            double res;
            switch (operazione)
            {
                case Operatore.Addizione:
                    res = a + b;
                    break;
                case Operatore.Sottrazione:
                    res = a - b;
                    break;
                case Operatore.Moltiplicazione:
                    res = a * b;
                    break;
                default:
                    res = a / b;
                    break;
            }
            Thread.Sleep(2000);
            return res;
        }


    }
}
