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
                    throw new Exception("Product's name is null or empty");
                _name = value;
            }
        }
        public FoodCategory Category { get; set; }

        private string _certification;
        public string Certification
        {
            get { return _certification; }
            set
            {
                string c = null;
                if (value != null)
                    c = value.Trim().ToUpper();
                _certification = c;
            }
        }

        public Product(string id, string name, FoodCategory f, string certification = null)
        {
            if (string.IsNullOrEmpty(id) || id.Length != 10 || Product._takenIds.Contains(id))
            {
                throw new Exception("Id non conforme o gia occupato");
            }
            
            this._id = id;
            Name = name;
            Category = f;
            Certification = certification;
            Product._takenIds.Add(id);
        }
    }
}
