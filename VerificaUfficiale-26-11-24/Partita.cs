using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hu
{
    public class Partita
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string Id => _id;
        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                if (Giocata && value < DateTime.Now)
                    throw new Exception("Partita giocata messa pero' in data futura");
                _dateTime = value;
            }
        }

        private bool _giocata;
        public bool Giocata => _giocata;



        private Squadra _sCasa;
        public Squadra SquadraCasa
        {
            get { return _sCasa; }
            set
            {
                if (value== null)
                    throw new Exception("Squadra in casa nulla");
                if (value.Equals(_sOspite))
                    throw new Exception("Squadra in casa e ospite uguali");
                _sCasa = value;
            }
        }

        private Squadra _sOspite;
        public Squadra SquadraOspite
        {
            get { return _sOspite; }
            set
            {
                if (value == null)
                    throw new Exception("Squadra ospite nulla");
                if (value.Equals(_sCasa))
                    throw new Exception("Squadra in casa e ospite uguali");
                _sOspite = value;
            }
        }

        private int _goalCasa;
        public int GoalCasa
        {
            get { return _goalCasa; }
        }

        private int _goalOspite;
        public int GoalOspite
        {
            get { return _goalOspite; }
        }




        public Partita(string id, DateTime data, Squadra casa, Squadra ospite)
        {
            if (string.IsNullOrEmpty(id) || Partita._takenIds.Contains(id))
                throw new Exception("Id nullo o già occupato");
            _id = id;

            if (casa == null)
                throw new Exception("Squadra in casa nulla");
            if (ospite == null)
                throw new Exception("Squadra ospite nulla");
            if (casa.Equals(ospite))
                throw new Exception("Squadra in casa e ospite uguali");


            _sCasa = casa;
            _sOspite = ospite;
            DateTime = data;

            Partita._takenIds.Add(_id);
        }


        public void SetResult(int puntiCasa, int puntiOspite)
        {
            if (Giocata)
                throw new Exception("Partita già disputata");

            if (_dateTime > DateTime.Now)
                throw new Exception("Partita non ancora iniziata");

            if (puntiCasa < 0)
                throw new Exception("Punti casa non validi");
            if (puntiOspite < 0)
                throw new Exception("Punti ospite non validi");
            
            _giocata = true;

            _goalOspite = puntiOspite;
            _goalCasa = puntiCasa;


            var pCasa = 0;
            var pOspite = 0;
            if (puntiCasa > puntiOspite)
                pCasa = 3;
            else if (puntiOspite > puntiCasa)
                pOspite = 3;
            else
            {
                pCasa = 1;
                pOspite = 1;
            }

            this._sCasa.Punti += pCasa;
            this._sOspite.Punti += pOspite;
        }
        public void ModifyResult(int puntiCasa, int puntiOspite)
        {
            if (!Giocata)
                throw new Exception("Partita non ancora giocata");

            if (_dateTime > DateTime.Now)
                throw new Exception("Partita non ancora iniziata");

            if (puntiCasa < 0)
                throw new Exception("Punti casa non validi");
            if (puntiOspite < 0)
                throw new Exception("Punti ospite non validi");



            var pCasaVecchio = 0;
            var pOspiteVecchio = 0;
            if (GoalCasa > GoalOspite)
                pCasaVecchio = 3;
            else if (GoalCasa > GoalOspite)
                pOspiteVecchio = 3;
            else
            {
                pCasaVecchio = 1;
                pOspiteVecchio = 1;
            }

            _goalOspite = puntiOspite;
            _goalCasa = puntiCasa;

            var pCasa = 0;
            var pOspite = 0;
            if (puntiCasa > puntiOspite)
                pCasa = 3;
            else if (puntiOspite > puntiCasa)
                pOspite = 3;
            else
            {
                pCasa = 1;
                pOspite = 1;
            }

            this._sCasa.Punti -= pCasaVecchio;
            this._sOspite.Punti -= pOspiteVecchio;

            this._sCasa.Punti += pCasa;
            this._sOspite.Punti += pOspite;
        }


        public bool Equals(Partita other)
        {
            if (other == null)
                return false;
            if (other._id != this._id)
                return false;
            return true;
        }

        bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
                if (disposing)
                {
                    Partita._takenIds.Remove(_id);
                }
            }

        }
        ~Partita()
        {
            Dispose(false);
        }
    }
}
