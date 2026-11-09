using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._2_
{
    public class Factory
    {
        #region ID
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string Id => _id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                value = value.Trim().ToLower();
                if (string.IsNullOrEmpty(value) || value.Length > 50)
                    throw new Exception("Factory's name is null or empty");
                _name = value;
            }
        }
        #endregion
        private string _town;
        public string Town
        {
            get { return _town; }
            set
            {
                value = value.Trim().ToLower();
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Factory's town is null or empty");
                _town = value;
            }
        }

        private HashSet<FoodCategory> _producedCategories = new HashSet<FoodCategory>() { };
        public HashSet<FoodCategory> ProducedCategories => _producedCategories;
        private int _maxCapacity;
        public int MaxCapacity
        {
            get { return _maxCapacity; }
            set
            {
                if (value < 100 || value > 1000)
                    throw new Exception("Factory's max capacity must be between [100;1000]");
                _maxCapacity = value;
            }
        }
        private HashSet<Certifications> _ownedCertifications= new HashSet<Certifications>() { };
        public HashSet<Certifications> OwnedCertifications => _ownedCertifications;
    }
}
