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

namespace Hu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //visto che la location di riferimento della label e' nell'angolo
            //in alto a destra devo aggiungere un offset al bordo inferiore
            bordoInferiore = panel.Height - 20;
            rnd = new Random();
        }

        //Variabili globali

        //bordi del panel che imposto readonly per evitare che li modifichi per sbaglio
        readonly int bordoSuperiore = 0;
        readonly int bordoInferiore;

        //array contentente la struct dei caratteri da muovere e i thread
        Carattere[] caratteri;
        Thread[] thread;

        //contatore per tenere conto di quanti thread sono terminati
        int conteggioThreadTerminati = 0;

        //oggetto per numeri randomici (readonly per sicurezza, evitare che venga cambiato)
        readonly Random rnd;

        //struttura che contiene label e altezza
        public struct Carattere
        {
            public Label label;
            public int altezzaIniziale;
        }



        //funzione per istanziare label
        private Label newCharLabel(char c, int x, int y)
        {
            var label = new Label();
            label.Text = c.ToString();
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.Font = new Font("Arial", 16);
            return label;
        }

        private void MoveLabelDown(Carattere c)
        {
            //imposto una velocita random
            int speed = rnd.Next(4, 10);
            
            //preparo l'altezza di riferimento che determina l'altezza a cui il rimbalzo arriva
            int altezzaRiferimento = c.altezzaIniziale;
            //try catch con "ObjectDisposedException" e "InvalidOperationException" per catturare le
            //eccezioni lanciate quando l'invoke prova a eseguire l'azione su istanze non piu esitenti
            //(le eccezioni partivano quando si chiude la form senza aspettare che i thread finiscano)
            try
            {
                do
                {
                    //trovo la distanza da percorrere
                    int distanzaInDiscesa = Math.Max(bordoInferiore - altezzaRiferimento, 0);
                    //meta della distanza, + 1 serve perche se ho una distanza da percorre = 1,
                    //la divisione mi restituisce 0, evitando la termine del ciclo
                    int altezzaDaPercorrereInMeno = distanzaInDiscesa / 2 + 1;
                    //applico l'altezza nuova trovata
                    //math.min serve per prevenire valori che superino il bordo inferiore
                    altezzaRiferimento = (int)Math.Min(altezzaRiferimento + altezzaDaPercorrereInMeno, bordoInferiore);

                    //ciclo per movimento in discesa
                    while (c.label.Location.Y < bordoInferiore)
                    {
                        //math.min serve per prevenire valori che superino il bordo inferiore
                        int y = (int)Math.Min(c.label.Location.Y + speed, bordoInferiore);
                        Invoke(new Action(() =>
                        {
                            c.label.Location = new Point(c.label.Location.X, y);
                        }));
                        Thread.Sleep(20);
                    }

                    while (c.label.Location.Y > altezzaRiferimento)
                    {
                        //math.min serve per prevenire valori che superino il bordo superiore stabilito dall'altezza di riferimento
                        int y = (int)Math.Max(c.label.Location.Y - speed, altezzaRiferimento);
                        Invoke(new Action(() =>
                        {
                            c.label.Location = new Point(c.label.Location.X, y);
                        }));
                        Thread.Sleep(20);
                    }

                } while (altezzaRiferimento < bordoInferiore);
                //quando finisce un thread incremento il contatore dei thread completati
                Invoke(new Action(() =>
                {
                    conteggioThreadTerminati++;
                }));
            }
            catch (ObjectDisposedException) { }
            catch (InvalidOperationException) { }


        }
        //bottone START
        private void btnStart_Click(object sender, EventArgs e)
        {
            

            //controllo l'input
            var input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Inserire un valore");
                return;
            }

            //disabilito e abilito i bottoni necessari
            btnStart.Enabled = false;
            btnReset.Enabled = true;

            //prepare l'array con dimensione corretta
            caratteri = new Carattere[input.Length];

            //ciclo per istanziare label e assegnarle alla struttura
            for (int i = 0; i < input.Length; i++)
            {
                //segno l'altezza iniziale da dove parte la label (dal bordo supeiore a fino a meta dell'altezza per panel)
                int altezzaIniziale = rnd.Next(bordoSuperiore, bordoInferiore / 2 + 1);
                //istanzio label
                var label = newCharLabel(input[i], 10 + (i * 20), altezzaIniziale);
                //assegno valori alla struttura
                caratteri[i] = new Carattere
                {
                    label = label,
                    altezzaIniziale = altezzaIniziale
                };
                //aggiungo la label al pannello per renderli visibili
                panel.Controls.Add(label);
            }
            //preparo l'array dei thread
            thread = new Thread[caratteri.Length];

            //ciclo per inzializzare thread
            for (int i = 0; i < caratteri.Length; i++)
            {
                //variabile che salva l'indice perche' con la chiamta lambda se utilizzassi i
                //i varia valore in base alla iterazione, devo quindi salvarmi staticamente l'indice
                int index = i;
                //thread che esegue la funzione MoveLabelDown()
                thread[i] = new Thread(() => MoveLabelDown(caratteri[index]));
                //imposto il thread come uno in background che muore quando chiudo il principale,
                //ovvero il thread UI della form
                thread[i].IsBackground = true;
                //avvio il thread
                thread[i].Start();
            }


        }

        // bottone RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            //controllo per controllare se i thread siano presenti e se si sono tutti terminati
            if(thread == null || conteggioThreadTerminati < thread.Length)
            {
                MessageBox.Show("Aspettare la fine di tutti i thread");
                return;
            }
            thread = null;
            //chiamo dispose alle label
            if(caratteri != null)
            {
                foreach(var i in caratteri)
                {
                    i.label.Dispose();
                }
                caratteri = null;
            }
            //azzero il conteggio dei thread terminati
            conteggioThreadTerminati = 0;
            //attivo o disabilito i bottoni necessari
            btnStart.Enabled = true;
            btnReset.Enabled = false;

        }
    }
}
