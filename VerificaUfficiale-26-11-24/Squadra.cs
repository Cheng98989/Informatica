using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu
{
    public class Squadra : IEquatable<Squadra>
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string IdSquadra => _id;
        private string _name;
        public string NomeSquadra
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 30)
                    throw new Exception("Nome non presente o supera 30 caratteri");
                _name = value;
            }
        }

        private string _city;
        public string Citta
        {
            get { return _city; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 50)
                    throw new Exception("Nome non presente o supera 50 caratteri");
                _city = value;
            }
        }

        private string _surname;
        public string CognomeAllenatore
        {
            get { return _surname; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new Exception("Cognome allenatore supera 50 caratteri");
                _surname = value;
            }
        }

        private int _points;
        public int Punti
        {
            get { return _points; }
            set
            {
                if (value < 0)
                    throw new Exception("Punti non minori di 0");
                _points = value;
            }
        }

        public Squadra(string id, string nome, string citta, int punti, string cognome = null)
        {
            if (string.IsNullOrEmpty(id) || Squadra._takenIds.Contains(id))
                throw new Exception("Id non presente o occupato");
            _id = id;
            NomeSquadra = nome;
            Citta = citta;
            CognomeAllenatore = cognome;
            Punti = punti;

            Squadra._takenIds.Add(_id);
        }

        public bool Equals(Squadra other)
        {
            if (other == null)
                return false;
            if (other.IdSquadra != this._id)
                return false;
            return true;
        }

        public override string ToString()
        {
            return this._id;
        }

        //bool _disposed = false;
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //private void Dispose(bool disposing)
        //{
        //    if (!_disposed)
        //    {
        //        _disposed = true;
        //        if (disposing)
        //        {
        //            Squadra._takenIds.Remove(_id);
        //        }
        //    }

        //}
        //~Squadra()
        //{
        //    Dispose(false);
        //}

    }
}
