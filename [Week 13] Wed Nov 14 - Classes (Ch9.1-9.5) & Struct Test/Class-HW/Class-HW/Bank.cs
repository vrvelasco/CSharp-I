using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HW
{
    class Bank
    {
        // Fields
        private string _name;
        private string _location;
        private List<int> _customers;

        // Constructor
        public Bank()
        {
            // Initialize
            _name = "";
            _location = "";
            _customers = new List<int>();
        }

        // Parameterized
        public Bank(string name)
        {
            // Parameter value
            _name = name;

            // Just initialize
            _location = "";
            _customers = new List<int>();

        }

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        // Read-only
        public List<int> Customers
        {
            get { return _customers; }
        }

        // Add individual customer
        public void AddCustomer(int account)
        {
            _customers.Add(account);
        }
    }
}
