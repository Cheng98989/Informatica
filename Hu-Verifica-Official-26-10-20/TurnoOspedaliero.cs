using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu
{
    public class TurnoOspedaliero
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string IdTurno => _id;

        private string _name;
        public string NomePersonale
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome nullo");
                _name = value;
            }
        }

        private string _surname;
        public string CognomePersonale
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Cognome nullo");
                _surname = value;
            }
        }

        private static List<string> _categories = new List<string>()
        {
            "Medico",
            "Infermiere",
            "OSS",
        };

        public static List<string> Categories => _categories.ToList();

        private string _category;
        public string TipoPersonale
        {
            get { return _category; }
            set
            {
                if (string.IsNullOrEmpty(value) || !_categories.Contains(value))
                    throw new Exception("Tipo personale vuota o non valida");
                _category = value;
            }

        }

        private static List<string> _departments = new List<string>()
        {
            "Pronto Soccorso",
            "Cardiologia",
            "Pediatra",
            "Chirurgia Generale",
        };

        public static List<string> Departmens => _departments.ToList();

        private string _department;
        public string Reparto
        {
            get { return _department; }
            set
            {
                if (string.IsNullOrEmpty(value) || !_departments.Contains(value))
                    throw new Exception("Reparto vuota o non valida");
                _department = value;
            }

        }

        private DateTime _turnDate;
        public DateTime DataTurno
        {
            get { return _turnDate; }
            set
            {
                if (value < DateTime.Now)
                    throw new Exception("Data turno precedente odierna");
                _turnDate = value;
            }
        }

        private DateTime _startDate;

        public DateTime OraInizio
        {
            get { return _startDate; }
            set
            {
                if (value < DataTurno + TimeSpan.FromHours(1))
                    throw new Exception("Data inizio deve essere almeno una ora dopo registrazione");
                _startDate = value;
            }
        }

        private DateTime _finishDate;
        public DateTime OraFine
        {
            get { return _finishDate; }
            set
            {
                var durata = value - OraInizio;
                if (durata < TimeSpan.FromHours(2) || durata > TimeSpan.FromHours(8))
                    throw new Exception("La data di fine deve avere un turno tra 2 e 8 ore");
                _finishDate = value;
            }
        }

        public int DurataTurno()
        {
            var durata = OraFine - OraInizio;
            return (int)durata.TotalMinutes;
        }

        public TurnoOspedaliero(string id, string nome, string cognome, string tipoP, string reparto, DateTime registrazione, DateTime inizio, DateTime fine )
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id nullo o vuoto");
            if (TurnoOspedaliero._takenIds.Contains(id))
                throw new Exception("Id occupato");

            _id = id;
            NomePersonale = nome;
            CognomePersonale = cognome;
            TipoPersonale = tipoP;
            Reparto = reparto;
            DataTurno = registrazione;
            OraInizio = inizio;
            OraFine = fine;

            TurnoOspedaliero._takenIds.Add(id);     
        }

        public void Dispose()
        {
            TurnoOspedaliero._takenIds.Remove(IdTurno);
        }

    }
}
