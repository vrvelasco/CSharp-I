using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    // Declare struct and enum data types at namespace level
    struct Student
    {
        public string name;   // Student name
        public int[] scores; // Array of scores
    }

    enum Test { LoopTest, ArrayTest, ClassTest, FinalExam }

    public partial class Form1 : Form
    {
        // Declare List of Student as a field at Class level
        private List<Student> studentList;

        // Declare constants fields at class level
        const int NAME_INDEX = 0;
        const int NUM_TEST = 4;

        public Form1()
        {
            InitializeComponent();
        }

        // Read scores from CSV file
        private bool readScores(string fileName)
        {
            // Declare file and string variables
            StreamReader csvFile;
            string csvLine;
            char[] delim = { ',' };
            string[] tokens;

            // Catch file system errors
            try
            {
                // Open CSV file
                csvFile = File.OpenText(fileName);

                // Create Student List
                studentList = new List<Student>();

                // Read to end of file
                while (!csvFile.EndOfStream)
                {
                    // Read one line
                    csvLine = csvFile.ReadLine();

                    // Split line into tokens
                    tokens = csvLine.Split(delim);

                    // Create a Student and populate from CSV
                    Student student = new Student();
                    student.name = tokens[NAME_INDEX];
                    student.scores = new int[NUM_TEST];

                    for (int t = 0; t < NUM_TEST; t++)
                    {
                        student.scores[t] = int.Parse(tokens[1 + t]);
                    }

                    // Add Student to List
                    studentList.Add(student);
                }

                // Close CSV file
                csvFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Calculate and display average scores
        private void DisplayAverages(List<Student> stuList)
        {
            // Calculate average score for all students
            foreach (Student student in stuList)
            {
                // Calculate average score for one student
                double total = 0;

                for (Test t = Test.LoopTest; t <= Test.FinalExam; t++)
                {
                    total += student.scores[(int)t];
                }

                double average = total / NUM_TEST;

                // Display student name and average
                studentListBox.Items.Add(student.name + "\t" + average.ToString("n1"));
            }
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            // Get scores filename
            string fileName = "Scores.csv";

            // Read scores file
            if (readScores(fileName))
            {
                // Process and display scores
                DisplayAverages(studentList);
            }
            else
            {
                studentListBox.Items.Add("Error reading file: " + fileName);
            }
        }

        // Search for students by name
        // Display names and averages
        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            string searchName;

            // Read search term from TextBox
            searchName = searchTextBox.Text;

            // Search for student in struct in list
            // using LINQ extension method with lambda expression
            var foundStuVar = studentList.Where(stuStruct => stuStruct.name.Contains(searchName));

            // Copy structs from var to List
            List<Student> foundStuList = new List<Student>();

             foreach(Student foundStuStruct in foundStuVar)
            {
                foundStuList.Add(foundStuStruct);
            }

            // Calculate average and display results
            studentListBox.Items.Add("Search Results: ");
            DisplayAverages(foundStuList);
        }
    }
}
