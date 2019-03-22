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
            }
        }
    }
}
