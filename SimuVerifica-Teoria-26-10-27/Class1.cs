using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuVerifica_Teoria_26_10_27
{
    public class Prenotazione
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string Id => _id;
        private string _socio;
        public string Socio
        {
            get { return _socio; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Socio obbligatiorio");
                _socio = value;
            }
        }
        private static List<string> _sale = new List<string>()
        {
            "piccola", "media", "grande"
        };
        public static List<string> Sale => _sale.ToList();
        private string _sala;
        public string Sala
        {
            get { return _sala; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Sala mancante");
                _sala = value; 
            }
        }

        private DateTime _inizio;
        public DateTime Inizio
        {
            get { return _inizio; }
            set
            {
                if (!Prenotazione.timeCheck(value))
                    throw new Exception("Inizio tra ore 9 e 23");
                _inizio = value;
            }
        }

        private int _durata;
        public int Durata
        {
            get { return _durata; }
            set
            {
                if (value % 30 != 0 || Prenotazione.timeCheck(_inizio.AddMinutes(value)))
                    throw new Exception("Durata e' un multiplo di 30 o termina in orario di chiusura");
                _durata = value;
            }
        }
        private static bool timeCheck(DateTime d)
        {
            return d.TimeOfDay >= TimeSpan.FromHours(9) && d.TimeOfDay <= TimeSpan.FromHours(23);
        }
        public bool Active => Fine.HasValue;
        private DateTime? _fine;
        public DateTime? Fine
        {
            get { return _fine; }
            set
            {
                if (value.HasValue)
                {
                    if (value.Value.Date != _inizio.Date || value.Value < _inizio || !Prenotazione.timeCheck(value.Value))
                        throw new Exception("ora fine precendete a inizio, o in orario di chiusura o giorno diverso");
                    _fine = value;
                }
                _fine = null;
            }
        }

        public Prenotazione(string id, string socio, string sala, DateTime inizio, int durata)
        {
            if (string.IsNullOrEmpty(id) ||
                !char.IsLetter(id[0]) ||
                !char.IsLetter(id[1]) ||
                !char.IsLetter(id[2]) ||
                !char.IsDigit(id[3]) ||
                !char.IsDigit(id[4])
                || Prenotazione._takenIds.Contains(id))
                throw new Exception("ID non valido");

            _id = id;
            Socio = socio;
            Sala = sala;
            Inizio = inizio;
        }
    }
}
