using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corsa2
{
    
    public partial class Form1 : Form
    {
        List<Auto> cars;


        public Form1()
        {
            Random r = new Random();
            InitializeComponent();
            try
            {
                cars = new List<Auto>()
                    {
                        new Auto(Car1, r.Next(1,11), giri1),
                        new Auto(Car2, r.Next(1,11), giri2),
                        new Auto(Car3, r.Next(1,11), giri3),
                        new Auto(Car4, r.Next(1,11), giri4),
                    };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread[] t = new Thread[4];
            for(int y = 0; y < 4; y++) {
                int index = y;

                t[y] = new Thread(() => CarMove(cars[index]));
                t[y].Start();
            }
        }

        private void CarMove(Auto a)
        {
            for (int i = 0; i < 10000; i++)
            {

                Invoke(new Action(() =>
            {
                a.Car.Location = new Point((int)(a.Car.Location.X + a.speed), a.Car.Location.Y);
                if (a.Car.Location.X >= CURVA1.Location.X)
                {
                    a.Car.Location = new Point(INIZIO.Location.X, a.Car.Location.Y);
                    a.CarGiroFatto();
                    a.NewCarSpeed();
                }
                    

            }));
            }
            
        }
    }
    public class Auto
    {
        private Label _l;
        public Label _a;

        public Label Car => _l;

        private float _speed;
        public float speed
        {
            get { return _speed; }
            set
            {
                if (value <= 0)
                    throw new Exception("velocita...");
                _speed = value;
            }
        }
        private int _giro;
        public int giro
        {
            get { return _giro; }
            set
            {
                if (value <= 0) throw new Exception("giro non negativo");
                _giro = value;
            }
        }

        public Auto(Label l, float f, Label a)
        {
            if (l == null)
                throw new Exception("label...");

            _l = l;
            speed = f;
            _a = a;
        }
        public void NewCarSpeed()
        {
            speed = new Random().Next(1, 11);
        }
        public void CarGiroFatto()
        {
            giro++;
            _a.Text = _giro.ToString();
        }
    }
    }
