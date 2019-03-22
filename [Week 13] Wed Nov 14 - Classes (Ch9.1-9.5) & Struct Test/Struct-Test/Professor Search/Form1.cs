using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Professor_Search
{
    public partial class Form1 : Form
    {
        struct School
        {
            public string professorName;
            public string courseName;
        }

        List<School> schoolList = new List<School>();

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            School school = new School();

            if (professorTextBox.Text.Length > 0 && courseTextBox.Text.Length > 0) // Not empty
            {
                school.professorName = professorTextBox.Text.ToUpper();
                school.courseName = courseTextBox.Text.ToUpper();
            }
            else
            {
                // Error
                MessageBox.Show("Please enter a valid name for both Professor and Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Add to List
            schoolList.Add(school);

            // Clear TextBox
            professorTextBox.Clear();
            courseTextBox.Clear();
            professorTextBox.Focus();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (schoolList.Count != 0)
            {
                // Clear ListBox
                schoolListBox.Items.Clear();

                // Get info
                foreach (School school in schoolList)
                {
                    schoolListBox.Items.Add("Professor: " + school.professorName + " - (Course: " + school.courseName + ")");
                }
            }
            else
            {
                schoolListBox.Items.Add("\t\tThe list is empty.");
                schoolListBox.Items.Add("\tPlease add to the list before displaying.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0)
            {
                string search = searchTextBox.Text.ToUpper();
                bool found = false;

                foreach (School professor in schoolList)
                {
                    if (professor.professorName == search)
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show(search + " was not found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(search + " was found!", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a the professor's name.", "Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0)
            {
                string searchLINQ = searchTextBox.Text.ToUpper();
                bool found = false;

                var foundPro = schoolList.Where(schoolPro => schoolPro.professorName.Contains(searchLINQ));

                foreach (School professor in foundPro)
                {
                    if (professor.professorName == searchLINQ)
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show(searchLINQ + " was not found.", "LINQ Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(searchLINQ + " was found!", "LINQ Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a the professor's name.", "Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
