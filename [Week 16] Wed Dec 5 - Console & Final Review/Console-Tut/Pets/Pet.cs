using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        // Parameterized Constructor
        public Pet(string name)
        {
            Name = name;
        }

        // Auto-Properties
        public string Name { get; set; }
        public string Owner { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
