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

namespace Corsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }
        Random rnd;
        Label[] macchine;
        Thread[] processi;
        int giriNum;
        int autoNum;

        private Label newLabel(string text, Point location)
        {
            Label l = new Label();
            l.Text = text;
            l.AutoSize = false;
            l.Width = 30;
            l.Height = 15;
            l.BackColor = Color.Red;
            l.Location = location;
            return l;
        }

        private void moveLabel(Label l, int giriDaFare, ListBox logs)
        {
            
            int giriFatti = 0;
            try
            {
                do
                {
                    Invoke(new Action(() =>
                    {
                        l.Location = new Point(lblInizioGiro.Location.X, l.Location.Y);
                    }));
                    int speed = rnd.Next(3, 10);
                    while (l.Location.X < lblFineGiro.Location.X)
                    {
                        Invoke(new Action(() =>
                        {
                            l.Location = new Point(l.Location.X + speed, l.Location.Y);
                        }));
                        Thread.Sleep(20);
                    }
                    giriFatti++;
                    Invoke(new Action(() =>
                    {
                        logs.Items.Add($"{l.Text} ha completato il {giriFatti}# giro!");
                    }));
                } while (giriFatti < giriDaFare);

                Invoke(new Action(() =>
                {
                    logs.Items.Add($"{l.Text} ha completato la gara");
                    l.BackColor = Color.Green;
                }));
            }
            catch (ObjectDisposedException) { }
            catch (InvalidOperationException) { }
            catch (ThreadAbortException) { }


        }

        private void btnPrepara_Click(object sender, EventArgs e)
        {
            btnPrepara.Enabled = false;
            giriNum = (int)nudGiri.Value;
            autoNum = (int)nudAuto.Value;

            macchine = new Label[autoNum];
            for (int i = 0; i < macchine.Length; i++)
            {
                int x = lblInizioGiro.Location.X;
                int y = 20 + i * 30     ;
                macchine[i] = newLabel($"Auto {i + 1}", new Point(x, y));


                macchine[i].Show();
                this.Controls.Add(macchine[i]);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            processi = new Thread[autoNum];
            for(int i = 0; i<autoNum; i++)
            {
                int index = i;
                processi[i] = new Thread(() => moveLabel(macchine[index], giriNum, lstLog));
                processi[i].IsBackground = true;
                processi[i].Start();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(processi != null)
                foreach(var i in processi)
                {
                    i.Abort();
                }
            if(macchine != null)
                foreach(var i in macchine)
                {
                    i.Dispose();
                }
            macchine = null;

            btnPrepara.Enabled = true;
            btnStart.Enabled = true;
            lstLog.Items.Clear();
        }
    }

    
}
