using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_20261008
{
    public class Order
    {
        private static List<int> _takenIds = new List<int> { };

        public static List<int> TakenIds => _takenIds;

        private int _id;

        public int Id => _id;


        public string Name;

        public string Address;

        public DateTime Data;

        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set
            {
                if (value < 1 || value > 100)
                    throw new Exception("Amount must be [1;100]");
                _amount = value;
            }
        }

        private decimal _totalCost;

        public decimal TotalCost
        {
            get { return _totalCost; }
            set
            {
                if (value <= 0 || value > 10000)
                    throw new Exception("TotalCost must be (0;10000]");
                _totalCost = value;
            }
        }

        public Order(int i, string n, string a, DateTime d, decimal c, int amount = 1)
        {
            //controllo id
            if (Order.TakenIds.Contains(i))
                throw new Exception("Id already taken");
            //assegnazione
            _id = i;
            Name = n;
            Address = a;
            Data = d;
            TotalCost = c;
            Amount = amount;
            Order.TakenIds.Add(i);
        }
    }
}
