using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._2_
{
    public class Batch
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string Id => _id;



        public Product Product { get; set; }
        public Factory Factory { get; set; }

        private DateTime _manufactoringDate;
        public DateTime ManufactoringDate
        {
            get { return _manufactoringDate; }
            set
            {
                if (value < DateTime.Today)
                    throw new Exception("Manufactoring date before today");
                if (value > _expiringDate)
                    throw new Exception("Manufactoring date after expiring date");
                _manufactoringDate = value;
            }
        }
        private DateTime _expiringDate;
        public DateTime ExpiringDate
        {
            get { return _expiringDate; }
            set
            {
                if (value > _manufactoringDate)
                    throw new Exception("Expiring date before manufactoring's one");
                _expiringDate = value;
            }
        }

        public Batch(string id, DateTime manufactoring, DateTime expiring)
        {
            if (string.IsNullOrEmpty(id) || id.Length != 6 || Batch._takenIds.Contains(id))
                throw new Exception("Id not valid or taken");
            _id = id;
            if (manufactoring < DateTime.Today
                || expiring > manufactoring)
                throw new Exception("Manufacoting and expiring date not valid");

        }
    }
}
