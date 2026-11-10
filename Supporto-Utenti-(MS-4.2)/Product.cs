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
                var c = value.Trim().ToUpper();
                if (string.IsNullOrEmpty(c))
                    throw new Exception("Not valid certification");
                _certification = c;
            }
        }
    }
}
