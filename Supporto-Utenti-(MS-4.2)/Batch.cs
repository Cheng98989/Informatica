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


        private Product _product;
        public Product Product
        {
            get { return _product; }
            set
            {
                if (value == null)
                    throw new Exception("Product is null");
                if (!_factory.ProducedCategories.Contains(value.Category))
                    throw new Exception("Factory can't produce this product category");
                if (!_factory.Certifications.CanProduce(value))
                    throw new Exception("Factory doesn't have requirements to produce the product");
                _product = value;
            }
        }
        private Factory _factory;
        public Factory Factory
        {
            get { return _factory; }
            set
            {
                if (value == null || value.MaxCapacity < this._quantity)
                    throw new Exception("Batch quantity is bigger than the per day production of the factory");
                if (!value.ProducedCategories.Contains(_product.Category))
                    throw new Exception("Factory can't produce this product category");
                if (!value.Certifications.CanProduce(_product))
                    throw new Exception("Factory doesn't have requirements to produce the product");
                _factory = value;
            }
        }

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

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 100 || value > 3000)
                    throw new Exception("Quantity must be between [100;3000]");
                if (_quantity > Factory.MaxCapacity)
                    throw new Exception("Batch quantity is bigger than the per day production of the factory");

                _quantity = value;
            }
        }

        private int _healthScore;
        public int HeathScore
        {
            get { return _healthScore; }
            set
            {
                if (value < 10 || value > 100)
                    throw new Exception("Health score must be between [10;100]");
                _healthScore = value;
            }
        }

        public enum QualityRanks
        {
            RESPINTO,
            RISCHIO,
            APPROVATO,
        }

        public QualityRanks Quality
        {
            get
            {
                int dif = (ExpiringDate.Date - DateTime.Today).Days;
                if (dif > 10)
                {
                    if (_healthScore >= 60) return QualityRanks.APPROVATO;
                    return QualityRanks.RESPINTO;
                }
                    
                if( dif > 1)
                {
                    var liv = _healthScore - (10 - dif) * 3;
                    if (liv >= 80)
                        return QualityRanks.APPROVATO;
                    if (liv < 60)
                        return QualityRanks.RESPINTO;
                    return QualityRanks.RISCHIO;
                }

                return QualityRanks.RESPINTO;
            }
        }

        public Batch(
            string id,
            DateTime manufactoring,
            DateTime expiring,
            Product p,
            Factory f,
            int quantity,
            int healthScore
            )
        {
            if (string.IsNullOrEmpty(id) || id.Length != 6 || Batch._takenIds.Contains(id))
                throw new Exception("Id not valid or taken");
            _id = id;
            if (manufactoring < DateTime.Today
                || expiring > manufactoring)
                throw new Exception("Manufacoting and expiring date not valid");

            if (f == null || f.MaxCapacity > quantity)
                throw new Exception("Batch quantity is bigger than the per day production of the factory");

            //conrtollo incrociato stabilitmento e prdotto categorie e certificazioni
            if (!f.ProducedCategories.Contains(p.Category))
                throw new Exception("Factory can't produce this product category");
            if (!f.Certifications.CanProduce(p))
                throw new Exception("Factory doesn't have requirements to produce the product");


            _manufactoringDate = manufactoring;
            _expiringDate = expiring;
            Product = p;
            _factory = f;
            _quantity = quantity;

        }




    }
}
