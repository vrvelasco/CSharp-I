using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_RevHW
{
    class Car
    {
        private string _make;
        private string _model;
        private double _price;

        // Parameterized constructor
        public Car(string m, string mod, double p)
        {
            _make = m;
            _model = mod;
            _price = p;
        }


        //Properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
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
