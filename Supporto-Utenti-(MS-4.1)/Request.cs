using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._1_
{
    public class Request
    {
        //CAMPI - PROPRIETA'
        #region ID
        //ID-static
        private static List<string> _takenIds = new List<string>() { };
        public static List<string> TakenIds => _takenIds.ToList();

        //id istanza
        private bool _disposed = false;
        public bool Disposed => _disposed;
        private readonly string _id;

        public string Id => _id;
        #endregion //in constructor controls

        #region DEPARTMENT
        private static readonly List<string> _departments = new List<string>()
        {
            "produzione", "amministrazione", "vendita",
        };

        public static List<string> Departments => _departments.ToList();

        private string _department;

        public string Department
        {
            get { return _department; }
            set
            {
                value = value.Trim().ToLower();
                if (string.IsNullOrEmpty(value) || !Request.Departments.Contains(value))
                    throw new Exception("department not present");
                _department = value;
            }
        }
            
        #endregion

        #region EMAIL
        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                    throw new Exception("Email senza \"@\"");
                _email = value.ToLower();
            }
        }
        #endregion

        #region URGENCY
        private int _urgency;

        public int Urgency
        {
            get { return _urgency; }
            set 
            {
                if (value < 1 || value > 100)
                    throw new Exception("urgency must be [1;100]");
                _urgency = value;
            }
        }
        #endregion

        #region REQUEST DATE
        private DateTime _reqDate;

        public DateTime ReqDate
        {
            get { return this._reqDate; }
            set
            {
                if (
                    value > DateTime.Now
                    || value.DayOfWeek == DayOfWeek.Saturday
                    || value.DayOfWeek == DayOfWeek.Sunday
                    || value.TimeOfDay < TimeSpan.FromHours(7)
                    || value.TimeOfDay > TimeSpan.FromHours(17)
                    )
                    throw new Exception("Request Date not valide");
                this._reqDate = value;
            }
        }
        #endregion

        #region RESOLUTION DATE
        public bool Resolved => _resDate.HasValue;

        private DateTime? _resDate;

        public DateTime? ResDate
        {
            get { return _resDate; }
            set
            {
                if (value.HasValue && value < ReqDate)
                    throw new Exception("Resolution Date not valide");
                _resDate = value;
            }
        }
        #endregion

        #region DESCRIPTION
        public string Description;
        #endregion

        //COSTRUTTORE
        #region CONSTRUCTORs

        public Request(string i, string e, string d, int u, DateTime req_d, DateTime? res_d = null, string des = null)
        {
            //id control
            if (
                string.IsNullOrEmpty(i)
                || i.Length != 5
                || !i.All(c => char.IsLetterOrDigit(c))
                || Request.TakenIds.Contains(i))
                throw new Exception("id not valid");

            //initialization
            //id
            this._id = i;
            //email
            this.Email = e;
            //department
            this.Department = d;
            //urgency
            this.Urgency = u;
            //req date
            this.ReqDate = req_d;
            //res date
            this.ResDate = res_d;
            //description
            this.Description = des;
            Request._takenIds.Add(i);
        }
        #endregion

        // MEDOTI
        #region METHODs

        public void Dispose()
        {
            if (!this._disposed)
            {
                Request._takenIds.Remove(Id);
                _disposed = true;
            }
            
        }

        public TimeSpan? TimeToResolve()
        {
            if(Resolved)
                return this.ResDate.Value - this.ReqDate;
            return null;
        }

        #endregion
    }
}
