using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam___Caves
{
    class Cave
    {
        // Fields
        private string _name;
        private string _location;
        private double _length;

        public Cave(string n, string loc, double l)
        {
            _name = n;
            _location = loc;
            _length = l;
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

        // Accessor method to get length
        public double GetLength()
        {
            return _length;
        }

        // Accessor method to set length
        public void SetLength(double length)
        {
            _length = length;
        }
    }
}
