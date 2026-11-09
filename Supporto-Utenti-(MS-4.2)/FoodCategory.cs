using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._2_
{
    public class FoodCategory: ICloneable
    {
        private readonly HashSet<string> _admitedFoodCategories = new HashSet<string>()
        {
            "ORTOFRUTTTA",
            "LATTICINI",
            "CARNI",
            "CONSERVE",
        };

        public HashSet<string> AdmitedFoodCategories => _admitedFoodCategories.ToHashSet();
        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                var s = value.Trim().ToUpper();
                if (string.IsNullOrEmpty(s) || !_admitedFoodCategories.Contains(s))
                    throw new Exception("Food category not valid");
                _category = s;
            }
        }
        public FoodCategory(string s)
        {
            Category = s;
        }

        #region IClonable
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    };
}

