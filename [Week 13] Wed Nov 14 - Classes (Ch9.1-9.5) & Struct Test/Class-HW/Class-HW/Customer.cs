using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HW
{
    class Customer
    {
        // Customer fields
        private int _account;
        private string _name;

        // Constructor
        public Customer()
        {
            // Initialize fields
            _account = 0;
            _name = "";
        }

        // Parameterized constructor
        public Customer(int account, string name)
        {
            // Initialize fields
            _account = account;
            _name = name;
        }

        // Properties
        public int Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
