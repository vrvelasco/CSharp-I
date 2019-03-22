using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Enrollment
{
    public partial class Form1 : Form
    {
        // Declare and create List of Courses
        private List<Course> courseList = new List<Course>();

        // Declare and create List of Students
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // Create a new course
        private void createCourseButton_Click(object sender, EventArgs e)
        {
            // Validate course and instructor
            if (courseNameTextBox.Text.Length > 0 && courseInstructorTextBox.Text.Length > 0)
            {
                // Instantiate a Course object with the name field
                Course course = new Course(courseNameTextBox.Text);

                // Set the instructor name field by using the property
                course.Instructor = courseInstructorTextBox.Text;

                // Add the course to the List of Courses
                courseList.Add(course);
            }
            else
            {
                MessageBox.Show("Please enter valid course and instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayCoursesButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add("Courses: ");

            foreach (Course course in courseList)
            {
                displayListBox.Items.Add(course.Name);
                displayListBox.Items.Add("\tInstructor: " + course.Instructor);

                foreach (int student in course.Students)
                {
                    displayListBox.Items.Add("\tStudent:" + student.ToString());
                }
            }
        }

        private void admitStudentButton_Click(object sender, EventArgs e)
        {
            // Validate ID and Name
            int id;
            if (int.TryParse(studentIDTextBox.Text, out id) && studentNameTextBox.Text.Length > 0 && id > 0)
            {
                // Instantiate student object and initialize fields
                Student student = new Student(id, studentNameTextBox.Text);

                // Add student to list of students
                studentList.Add(student);
            }
        }

        private void displayStudentsButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add("Students:");

            foreach (Student student in studentList)
            {
            displayListBox.Items.Add(student.ID + "\t" + student.Name);
            }
        }

        private void enrollStudentButton_Click(object sender, EventArgs e)
        {
            // Validate 
            int sid;

            if(int.TryParse(enrollmentStudentTextBox.Text, out sid) && enrollmentCourseTextBox.Text.Length > 0)
            {
                foreach (Course c in courseList)
                {
                    // Check each course
                    if (c.Name == enrollmentCourseTextBox.Text)
                    {
                        c.AddStudent(sid);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
