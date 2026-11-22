using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuVerifica_26_11_22_pratica
{
    public class Tratta : IDisposable
    {
        private static List<string> _takenIds = new List<string>() { };

        private string _id;
        public string Id => _id;
        private string _partenza;
        public string Partenza
        {
            get { return _partenza; }
            set
            {
                if (!Tratta.IsAITAid(value))
                    throw new Exception("Partenza e' un codice AITA");
                if (_arrivo == value)
                    throw new Exception("Codice partenza e arrivo devono essere diversi");
                _partenza = value.ToUpper();
            }
        }
        private string _arrivo;
        public string Arrivo
        {
            get { return _arrivo; }
            set
            {
                if (!Tratta.IsAITAid(value))
                    throw new Exception("Destinazione non e' un id AITA");
                if (value == _partenza)
                    throw new Exception("Codice partenza e arrivo devono essere diversi");
                _arrivo = value.ToUpper();
            }
        }

        private int _distanza;
        public int Distanza
        {
            get { return _distanza; }
            set
            {
                if (value <= 0)
                    throw new Exception("Distanza deve essere maggiore di 0");
                _distanza = value;
            }
        }

        private int _durata;
        public int Durata
        {
            get { return _durata; }
            set
            {
                if (value <= 0)
                    throw new Exception("Durata deve essere maggiore di 0");
                _durata = value;
            }
        }

        public static bool IsAITAid(string i)
        {
            return (!string.IsNullOrEmpty(i) && i.Length == 3 &&
                    char.IsLetter(i[0]) &&
                    char.IsLetter(i[1]) &&
                    char.IsLetter(i[2]));
        }
        public Tratta(string id, string part, string arri, int dist, int dura)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id nullo");
            if (!id.Contains('-'))
                throw new Exception("Id deve contenere '-' es: \"ROMA-MILANO\"");
            string[] parti = id.Split('-');
            if (parti.Length != 2 || parti[0].Length == 0 || parti[1].Length == 0)
                throw new Exception("Id non conforme es: \"ROMA-MILANO\"");
            var i = id.ToUpper();
            if (Tratta._takenIds.Contains(i))
                throw new Exception("Id gia utilizzato");


            //controllo incrociato
            if (!Tratta.IsAITAid(part))
                throw new Exception("Partenza non e' un id AITA");
            if (!Tratta.IsAITAid(arri))
                throw new Exception("Arrivo non e' un id AITA");
            if (part == arri)
                throw new Exception("Codice partenza e arrivo devono essere diversi");
            
            _id = i;
            _arrivo = arri.ToUpper();
            _partenza = part.ToUpper();

            Distanza = dist;
            Durata = dura;

            Tratta._takenIds.Add(_id);
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
                    Tratta._takenIds.Remove(_id);
                }
            }
        }

        ~Tratta()
        {
            Dispose(false);
        }
        #endregion
    }
}
