using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Enrollment
{
    class Student
    {
        // Student fields
        private int _id;
        private string _name;

        // Constructor
        public Student()
        {
            // Initialize fields
            _id = 0;
            _name = "";
        }

        // Parameterized Constructor
        public Student(int id, string name)
        {
            // Initialize fields
            _id = id;
            _name = name;
        }

        // Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
