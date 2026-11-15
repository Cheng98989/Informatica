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

namespace DownloadsRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        Download[] downloads;
        Thread[] process;
        int downloadSize;
        int downloadCount;
        Random rnd;

        int classifica;

        private void btnPrepara_Click(object sender, EventArgs e)
        {
            downloadCount = (int)nudCount.Value;
            downloadSize= (int)nudSize.Value;
            downloads = new Download[downloadCount];
            for (int i = 0; i < downloadCount; i++)
            {
                int x = 20 + i * 120;
                int y = 150;
                downloads[i] = newDownload($"Download {i + 1}", new Point(x, y), downloadSize);
                this.Controls.Add(downloads[i].groupbox);
            }
            btnPrepara.Enabled = false;
            btnStart.Enabled = true;
            btnReset.Enabled = true;
        }

        private struct Download
        {
            public GroupBox groupbox;
            public Label label;
            public ProgressBar bar;
        }

        private Download newDownload(string name, Point location, int downloadSize)
        {
            Label l = new Label();
            l.AutoSize = false;
            l.Text = name;
            l.BackColor = Color.LightGray;
            l.Width = 90;
            l.Height = 14;
            l.Location = new Point(5, 10);
            

            ProgressBar p = new ProgressBar();
            p.Height = 20;
            p.Width = 90;
            p.Location = new Point(5, 30);
            p.Maximum = downloadSize;


            GroupBox g = new GroupBox();
            g.Width = 100;
            g.Height = 60;
            g.Location = location;
            g.Controls.Add(l);
            g.Controls.Add(p);

            g.Show();
            Download d = default;
            d.groupbox = g;
            d.label = l;
            d.bar = p;
            return d;
        }

        private void Downloading(Download d, ListBox l)
        {
            try
            {
                bool halfDownload = false;
                while (d.bar.Value < d.bar.Maximum)
                {
                    int speed = rnd.Next(1, 11);
                    Invoke(new Action(() =>
                    {
                        d.bar.Value = Math.Min(d.bar.Value + speed, d.bar.Maximum);
                    }));
                    if (!halfDownload && d.bar.Value >= d.bar.Maximum / 2)
                    {
                        Invoke(new Action(() =>
                        {
                            l.Items.Add($"{d.label.Text} ha raggiunto il 50%");
                        }));
                        halfDownload = true;
                    }
                    Thread.Sleep(200);
                }
                Invoke(new Action(() =>
                {
                    classifica++;
                    l.Items.Add($"{d.label.Text} ha completato il Download, posizione {classifica}#");
                    d.groupbox.BackColor = Color.Green;
                }));
                if (classifica >= downloadCount)
                {
                    Invoke(new Action(() =>
                    {
                        l.Items.Add($"Tutti i download completati");
                        btnReset.Enabled = true;
                    }));

                    
                }
            }
            catch (ObjectDisposedException) { }
            catch (InvalidOperationException) { }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            process = new Thread[downloadCount];
            for(int i = 0; i < downloadCount; i++)
            {
                int index = i;
                process[i] = new Thread(() => Downloading(downloads[index], lstLog));
                process[i].IsBackground = true;
                process[i].Start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(downloads != null)
            {
                foreach (var d in downloads)
                {
                    d.label.Dispose();
                    d.bar.Dispose();
                    d.groupbox.Dispose();
                }
                downloads = null;
            }
            process = null;
            classifica = 0;
            btnPrepara.Enabled = true;
            btnStart.Enabled = false;
            btnReset.Enabled = false;
            lstLog.Items.Clear();
        }
    }
}
