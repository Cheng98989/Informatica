using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._2_
{
    public class Product
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
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Product's name is null or empty");
                _name = value;
            }
        }
        #endregion
        #region Category/ies
        

        private FoodCategory _category;
        public FoodCategory Category
        {
            get { return _category; }
            set { _category = value;}
        }
        #endregion
        #region Certificate

        private Certifications? _certificate;
        public Certifications? Certificate
        {
            get { return _certificate; }
            set { _certificate = value; }
        }
        #endregion

        public Product(string id, Product.Categories category, Certifications certificate)
        {
            var i = id.Trim();
            if (string.IsNullOrEmpty(i) || i.Length != 10 || Product._takenIds.Contains(i))
                throw new Exception("Product's ID must be 10 chars long");
            _id = i;
            Category = category;
            Certificate = certificate;
            Product._takenIds.Add(i);
        }
    }
}
