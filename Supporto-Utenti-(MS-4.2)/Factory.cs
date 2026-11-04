using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public Factory(string id, string name, string town)
        {
            if (string.IsNullOrEmpty(id) || id.Length != 6)
                throw new Exception("Factory's id is not valid");
            if (Factory._takenIds.Contains(id))
                throw new Exception("Factory's id is already taken");
            _id = id;
            Name = name;
            Town = town;
            Factory._takenIds.Add(town);
        }

        private Certificates

        private HashSet<FoodCategories> _producedCategories = new HashSet<FoodCategories>() { };
        public List<FoodCategories> GetFoodCategories() => _producedCategories.ToList();
        public void ClearFoodCategories() => _producedCategories = new HashSet<FoodCategories>();
        public bool AddFoodCategory(FoodCategories f) => _producedCategories.Add(f);
        public bool RemoveFoodCategorY(FoodCategories f) => _producedCategories.Remove(f);
    }
}
