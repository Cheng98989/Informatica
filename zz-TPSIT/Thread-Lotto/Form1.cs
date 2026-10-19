
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

namespace Thread_Lotto
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        Label[] cities = new Label[5];
        Label[][] numbers = new Label[5][];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            cities = createCityLabel((int)numericUpDown1.Value);
            numbers = new Label[cities.Length][];

            btnExtract.Enabled = true;
            btnClear.Enabled = true;
            btnInit.Enabled = false;

            for (int i = 0; i < cities.Length; i++)
            {
                numbers[i] = createNumberLabel(cities[i]);
            }
        }

        private Label[] createCityLabel(int i)
        {
            Label[] f = new Label[i];

            for (int n = 0; n < i; n++)
            {
                Label a = new Label();
                a.Location = new Point(50, 60 + 25 * n);
                a.Text = $"Città{n + 1}";
                a.Font = new Font("Arial", 12, FontStyle.Regular);
                a.AutoSize = false;
                a.Width = 50;
                a.TextAlign = ContentAlignment.MiddleCenter;
                a.ForeColor = Color.Black;
                a.BackColor = Color.LightBlue;
                a.BorderStyle = BorderStyle.FixedSingle;

                this.Controls.Add(a);
                f[n] = a;
            }

            return f;
        }

        private Label[] createNumberLabel(Label l)
        {
            Label[] created = new Label[5];

            for (int i = 0; i < 5; i++)
            {
                Label a = new Label();
                a.Location = new Point(
                    l.Location.X + (i + 1) * 80,
                    l.Location.Y
                );
                a.Text = "?";
                a.Font = new Font("Arial", 12, FontStyle.Bold);
                a.AutoSize = false;
                a.Width = 50;
                a.TextAlign = ContentAlignment.MiddleCenter;
                a.ForeColor = Color.Black;
                a.BackColor = Color.LightYellow;
                a.BorderStyle = BorderStyle.FixedSingle;

                this.Controls.Add(a);
                created[i] = a;
            }

            return created;
        }

        private int[] GenerateNumbers()
        {
            int[] ints = new int[5];

            for (int i = 0; i < ints.Length; i++)
            {
                int a;

                do
                {
                    a = rnd.Next(1, 91);
                }
                while (ints.Contains(a));

                ints[i] = a;
            }

            return ints;
        }

        private void CombineLabelNumber(Label[] l, int[] i)
        {
            for (int n = 0; n < l.Length; n++)
            {
                int index = n;

                Invoke(new Action(() =>
                {
                    l[index].Text = i[index].ToString();
                    l[index].BackColor = Color.LightGreen;
                }));

                Thread.Sleep(rnd.Next(500, 1001));
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            Thread[] t = new Thread[cities.Length];

            for (int i = 0; i < cities.Length; i++)
            {
                int index = i;

                t[index] = new Thread(() =>
                {
                    CombineLabelNumber(numbers[index], GenerateNumbers());
                });

                t[index].Start();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Label[] l in numbers)
            {
                foreach (Label ll in l)
                {
                    ll.Text = "?";
                    ll.BackColor = Color.LightYellow;
                }
            }
        }
    }
}
