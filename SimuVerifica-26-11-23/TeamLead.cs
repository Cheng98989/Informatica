using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuVerifica_26_11_23
{
    public class TeamLead : IDisposable, IEquatable<TeamLead>, IComparable<TeamLead>, IComparable
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
                    throw new Exception("Nome e' vuoto");
                _name = value;
            }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Cognome e' vuoto");
                _surname = value;
            }
        }

        private int _exp;
        public int Experience
        {
            get { return _exp; }
            set
            {
                if (value <= 0)
                    throw new Exception("Anni di esperienza non possono essere minori o uguale a zero");
                _exp = value;
            }
        }

        public TeamLead
            (
            string id,
            string n,
            string s,
            int exp
            )
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id non presente");
            if (id.Length != 5 ||
                !char.IsLetter(id[0]) ||
                !char.IsLetter(id[1]) ||
                !char.IsDigit(id[2]) ||
                !char.IsDigit(id[3]) ||
                !char.IsDigit(id[4]))
                throw new Exception("Id non conforme es: \"TI001\"");
            if (TeamLead._takenIds.Contains(id))
                throw new Exception("Id occuato");

            _id = id;
            Name = n;
            Surname = s;
            Experience = exp;

            TeamLead._takenIds.Add(_id);
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
                    TeamLead._takenIds.Remove(this._id);
                }
            }
        }

        ~TeamLead(){
            Dispose(false);
        }

        #endregion

        public override string ToString()
        {
            return $"{this._id}";
        }
        public bool Equals(TeamLead other)
        {
            if (other == null)
                return false;
            return string.Equals(this._id, other.Id);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TeamLead);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public int CompareTo(TeamLead l)
        {
            if (l == null)
                return 1;

            return string.Compare(this._surname + this._name, l._surname+l._name);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new Exception("Istanza da comparare nulla");
            TeamLead other = obj as TeamLead;
            if (other == null)
                throw new Exception("L'istanza non è un team lead");
            return CompareTo(other);
        }

    }
}
