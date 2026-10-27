using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _26_1_25_SimuVerificaTeorica
{
    public class Noleggio
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string IdNoleggio => _id;
        private string _idUser;
        public string IdCliente
        {
            get { return this._idUser; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Id Cliente Vuoto");
                this._idUser = value;
            }
        }
        private DateTime _dataRitiro;
        public DateTime DataRitiro
        {
            get { return _dataRitiro; }
            set
            {
                if (value.TimeOfDay < new TimeSpan(8, 0, 0) ||
                    value.TimeOfDay > new TimeSpan(20, 0, 0))
                    throw new Exception("Data tra 8 e 20");
                this.DataRitiro = value;
            }
        }
        private static Dictionary<string, float> _types = new Dictionary<string, float>()
        {
            {"monopattino", 5},
            {"bicicletta", 7},
            {"e-bike", 3},
        };
        public static Dictionary<string, float> Tipi = _types.ToDictionary(t => t.Key, t => t.Value);
        private string _type;
        public string Tipo
        {
            get { return _type; }
            set
            {
                if (string.IsNullOrEmpty(value) || !Noleggio.Tipi.ContainsKey(value))
                    throw new Exception("Tipo non valido");
                _type = value;
            }
        }
        public string Note;
        private float _kilometers;
        public float Kilometri
        {
            get { return this._kilometers; }
            set
            {
                if (value < 0)
                    throw new Exception("Kilometri e' un numero reale positivo");
                this._kilometers = value;
            }
        }
        private DateTime? _dataRiconsegna = null;
        public DateTime? DataRiconsegna
        {
            get { return this._dataRiconsegna; }
            set
            {
                if (value.HasValue && value.Value < this._dataRitiro)
                    throw new Exception("Data riconsegna non precendete a ritiro");
                this._dataRiconsegna = value;
            }
        }
        public Noleggio(string id, string idCliente, string tipo, string note, DateTime ritiro)
        {
            if(id.Length != 6
                || char.IsLetter(id[0])
                || char.IsLetter(id[1])
                || char.IsDigit(id[2])
                || char.IsDigit(id[3])
                || char.IsDigit(id[4])
                || char.IsDigit(id[5]))
            {
                throw new Exception("Id Noleggio non valido");
            }
            this._id = id;
            this.IdCliente = idCliente;
            this.Tipo = tipo;
            this.DataRitiro = ritiro;
            this.Note = note;
            Noleggio._takenIds.Add(this._id);
        }
        public void Dispose()
        {
            Noleggio._takenIds.Remove(_id);
        }
        public int Durata()
        {
            if (!this.DataRiconsegna.HasValue)
                return -1;
            return (int)(this.DataRiconsegna.Value - this.DataRitiro).TotalMinutes;
        }
        public decimal Incasso()
        {
            if (!this.DataRiconsegna.HasValue)
                return -1;
            return (decimal)(Noleggio._types[this._type] * this._kilometers);
        }


    }
}
