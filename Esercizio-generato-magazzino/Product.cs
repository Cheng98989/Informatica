using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_generato_magazzino
{
    public class Product
    {
        private static List<string> _takenSkus = new List<string>() { };
        private string _sku;
        public string Sku => _sku;

        public string descr;
        private static Dictionary<string, string> _types = new Dictionary<string,string>() { };
        public static Dictionary<string, string> Type => _types.ToList();

        public bool AddType(string newtype)
        {
            if (Product.Type.Count > 256)
                return false;
            var t = newtype.Trim().ToLower();
            if (string.IsNullOrEmpty(t) || Product.Type.ContainsValue(t))
                return false;
            var hex = Product.Type.Count.ToString("x2");

            
        }

        private DateTime _lastDate;
        public DateTime LastDate
        {
            get { return _lastDate; }
            set
            {
                if(value.Date > DateTime.Today)
                    throw new Exception("Last date can't be referred to the future");
                _lastDate = value;
            }
        }

        private int _totAmount;
        public int TotAmount
        {
            get { return _totAmount; }
            set
            {
                if (value > 5000)
                    throw new Exception("Tot Amount can't be greater than 5000 units");
                _totAmount = value;
            }
        }

        private int _minAmount;
        public int MinAmount
        {
            get { return _minAmount; }
            set
            {
                if (value > 5000)
                    throw new Exception("Min Amount can't be greater than 5000 units");
                _minAmount = value;
            }
        }

        private decimal _perUnitPrice;
        public decimal PerUnitPrice
        {
            get { return _perUnitPrice; }
            set
            {
                if (value > 1000 || value <= 0)
                    throw new Exception("Per unit price is a decimal (0;1000]");
                _perUnitPrice = value;
            }
        }

        public Product(string des, string c, DateTime dat, int totA, int minA, decimal p)
        {
            
        }

        public static string newSku()
        {
            int count = Product.Type.Count();
            string hex = 255.ToString("X2");
            return hex;
        }
    }
}
