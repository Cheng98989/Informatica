using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuVerifica_26_11_23
{
    public class Project : IDisposable, IEquatable<Project>
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string Id => _id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome progetto e' vuoto");
                _name = value;
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Descrizione e' vuota");
                _description = value;
            }
        }

        private decimal _budget;
        public decimal Budget
        {
            get { return _budget; }
            set
            {
                if (value <= 0)
                    throw new Exception("Anni di esperienza non possono essere minori o uguale a zero");
                _budget = value;
            }
        }

        //incrociati
        private DateTime _startD;
        public DateTime StartDate
        {
            get { return _startD; }
            set
            {
                value = value.Date;
                if (value > _endD)
                    throw new Exception("Data inizio non puo essere successiva alla data di fine");
                _startD = value;
            }
        }
        private DateTime _endD;
        public DateTime EndDate
        {
            get { return _endD; }
            set
            {
                value = value.Date;
                if (_startD > value)
                    throw new Exception("Data fine non puo essere precedente alla data di inizio");
                _endD = value;
            }
        }

        private readonly static List<string> _states = new List<string>()
        {
            "In Corso",
            "Completato",
            "In Pausa",
            "Annullato"
        };

        public static List<string> Stati = _states.ToList();

        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                if (string.IsNullOrEmpty(value) || !Project._states.Contains(value))
                    throw new Exception("Stato progetto non valido");
                _state = value;
            }
        }


        private TeamLead _lead;
        public TeamLead Lead
        {
            get { return _lead; }
            set
            {
                if (value == null)
                    throw new Exception("Team lead null");
                _lead = value;
            }
        }


        public Project
            (
            string id,
            string n,
            string d,
            string state,
            decimal budget,
            DateTime start,
            DateTime end,
            TeamLead lead
            )
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id non presente");
            if (!id.Contains('-'))
                throw new Exception("Formato errato es: PROJ-2025-001");
            var pieces = id.Split('-');
            if(pieces.Length != 3 || pieces[0].Length != 4 || pieces[1].Length != 4 || pieces[2].Length != 3)
                throw new Exception("Formato errato es: PROJ-2025-001");
            if (Project._takenIds.Contains(id))
                throw new Exception("Id occuato");


            //incrociato
            start = start.Date;
            end = end.Date;
            if(start > end)
                throw new Exception("Data fine non puo essere precedente alla data di inizio");


            _id = id;
            Name = n;
            Description = d;
            State = state;
            Budget = budget;
            _startD = start;
            _endD = end;
            Lead = lead;

            Project._takenIds.Add(_id);
        }

        #region IDisposable
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
                    Project._takenIds.Remove(this._id);
                }
            }
        }

        ~Project()
        {
            Dispose(false);
        }

        #endregion


        public bool Equals(Project other)
        {
            if (other == null)
                return false;
            return string.Equals(this._id, other.Id);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Project);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }


        /*
         // 5: filtro per stato
var r = projects.Where(p => string.Equals(p.State, txtStato.Text, StringComparison.OrdinalIgnoreCase)).ToList();

// 6: progetti di un lead, ordinati per inizio
var r = projects.Where(p => p.Lead.Id == txtId.Text).OrderBy(p => p.StartDate).ToList();

// 7: budget medio in scadenza entro 90 giorni
var oggi = DateTime.Today;
var inScad = projects.Where(p => p.State == Project.Stati[0]
                              && p.EndDate >= oggi && p.EndDate <= oggi.AddDays(90)).ToList();
decimal media = inScad.Count == 0 ? 0 : inScad.Average(p => p.Budget);

// 8: lead con più progetti completati (tutti in caso di pari merito)
var comp = projects.Where(p => p.State == Project.Stati[1])
                   .GroupBy(p => p.Lead)
                   .Select(g => new { g.Key.Name, g.Key.Surname, g.Key.Experience, Completati = g.Count() })
                   .ToList();
if (comp.Count > 0)
{
    int max = comp.Max(x => x.Completati);
    var best = comp.Where(x => x.Completati == max).ToList();
}
         
         */
    }
}
