using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Product
    {
        // Fields
        private string _name;
        private string _category;
        private double _price;

        // Parameterized constructor with price
        public Product(string name, string category, double price)
        {
            _name = name;
            _category = category;
            _price = price;
        }

        //Parameterized constructor without price
        public Product(string name, string category)
        {
            _name = name;
            _category = category;
            _price = 0.0;
        }

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        // Accessor method to get price
        public double GetPrice()
        {
            return _price;
        }

        // Accessor method to set price
        public void SetPrice(double price)
        {
            _price = price;
        }
    }
}
