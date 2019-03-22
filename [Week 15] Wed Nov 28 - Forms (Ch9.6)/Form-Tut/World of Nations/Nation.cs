﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_of_Nations
{
    class Nation
    {
        // Declare fields
        string _name;
        string _continent;
        int _population;

        // Parameterized constructor
        public Nation(string name, string con, int pop)
        {
            _name = name;
            _continent = con;
            _population = pop;
        }

        // Name property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // Continent property
        public string Continent
        {
            get { return _continent; }
            set { _continent = value; }
        }

        // Population property
        public int Population
        {
            get;
            set;
        }

        // Return paragraph containing information
        public string GetInfo()
        {
            return "The nation of " + _name + " is on the continent of " + _continent + " and has a population of " + _population.ToString() + " people.";
        }
    }
}
