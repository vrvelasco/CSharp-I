using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Enrollment
{
    class Course
    {
        // Course fields
        private string _name, _instructor;
        private List<int> _students;

        // Constructor for empty course
        public Course()
        {
            // Initialize fields to default values
            _name = "";
            _instructor = "";
            _students = new List<int>();
        }

        // Parameterized constructor for new course
        public Course(string name)
        {
            // Initialize name field to parameter value
            _name = name;

            // Initialize other field to parameter value
            _instructor = "";
            _students = new List<int>();
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Instructor property
        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        // Student read-only property
        public List<int> Students
        {
            get { return _students; }
           // Not allowing setting of all students at once
        }

        // Add an individual student to the course
        public void AddStudent(int id)
        {
            // Add the student ID to the student List within the course
            _students.Add(id);
        }
    }
}
