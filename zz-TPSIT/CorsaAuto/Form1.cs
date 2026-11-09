using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorsaAuto
{
    public class Auto
    {
        private Label _l;
        public Label Car => _l;

        private float _speed;
        public float speed
        {
            get { return _speed; }
            set {
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

        public Auto(Label l, float f)
        {
            if (l == null)
                throw new Exception("label...");
            
            _l = l;
            speed = f;
        }
        private void NewCarSpeed()
        {
            speed = new Random().Next(1, 11);
        }
        private void CarGiroFatto()
        {
            giro++;
        }
    }
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
                        new Auto(Car1, r.Next(1,11)),
                        new Auto(Car2, r.Next(1,11)),
                        new Auto(Car2, r.Next(1,11)),
                        new Auto(Car2, r.Next(1,11)),
                    };
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void CarMove(Auto a)
        {
            a.Car.Location = new Point((int)(a.Car.Location.X + a.speed), a.Car.Location.Y);
            
        }
    }
}
