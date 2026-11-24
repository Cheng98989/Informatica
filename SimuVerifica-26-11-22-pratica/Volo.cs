using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimuVerifica_26_11_22_pratica
{
    public class Volo : IDisposable
    {
        private static List<string> _takenIds = new List<string>() { };

        private string _id;
        public string Id => _id;
        public DateTime Partenza { get; set; }

        private int _postiDisp;
        public int PostiDisponibili
        {
            get { return _postiDisp; }
            set
            {
                if (value < 0)
                    throw new Exception("Posti disponibili non e' negativo");
                _postiDisp = value;
            }
        }

        private decimal _prezzo;
        public decimal Prezzo
        {
            get { return _prezzo; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prezzo deve essere maggiore di 0");
                _prezzo = value;
            }
        }

        private Tratta _tratta;
        public Tratta Tratta
        {
            get { return _tratta; }
            set
            {
                if (value == null)
                    throw new Exception("Tratta non presente");
                _tratta = value;
            }
        }
        public Volo(string id, DateTime partenza, int postiD, decimal prezzo, Tratta tratta)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id nullo");
            if (id.Length != 5)
                throw new Exception("Id deve contenere 5 caratteri alfanumerici");
            if (!(char.IsLetter(id[0]) &&
                char.IsLetter(id[1]) &&
                char.IsDigit(id[2]) &&
                char.IsDigit(id[3]) &&
                char.IsDigit(id[4])
                ))
                throw new Exception("Id non conforme es: \"AZ123\"");
            var i = id.ToUpper();
            if (Volo._takenIds.Contains(i))
                throw new Exception("Id gia utilizzato");

            _id = i;
            Partenza = partenza;
            PostiDisponibili = postiD;
            Prezzo = prezzo;
            Tratta = tratta;
            
            Volo._takenIds.Add(_id);
        }

        #region IDISPOSABLE
        bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
                if (disposing)
                {
                    Volo._takenIds.Remove(_id);
                }
            }
        }

        ~Volo()
        {
            Dispose(false);
        }
        #endregion
    }
}
