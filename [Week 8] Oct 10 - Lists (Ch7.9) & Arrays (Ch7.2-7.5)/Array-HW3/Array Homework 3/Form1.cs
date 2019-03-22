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

namespace Array_Homework_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Class level
        int numListBox = 0;
        const int SIZE = 50;
       // string[] strItems = new string[50];
        double[] numbers = new double[SIZE];

        private void readButton_Click(object sender, EventArgs e)
        {
            // Get File
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                ReadDefaultFile(fileName, numbers, SIZE);
                DisplayDoubles(numbers, numListBox);
            }
            else
            {
                MessageBox.Show("Error Reading File\n\nPlease Try Again.", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double parsedUserDouble;

            // Add double
            if (double.TryParse(addTextBox.Text, out parsedUserDouble))
            {
                if (numListBox < SIZE)
                {
                    numbers[numListBox] = parsedUserDouble;
                }
                else
                {
                    MessageBox.Show("The array is too small.", "Array Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Increment numListBox
                numListBox++;

                // Display
                DisplayDoubles(numbers, numListBox);
            }
            else
            {
                MessageBox.Show("Please enter a valid floating point number.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            // string[] items = new string[numListBox]; // Declare array and set size to numListBox
            double userDouble;
            int location;

            //  Get number array .ToString() in items array
            // for (int i = 0; i < numListBox; i++)
            //{
              //items[i] = numbers[i].ToString();
            //}

            // Read user's string from TextBox
            if (double.TryParse(searchTraditionalTextBox.Text, out userDouble))
                {
                // Search for user input
                location = SearchNumberArray(numbers, userDouble, numListBox);

                // Display search results
                if (location == 0) // Not found
                {
                    MessageBox.Show("Sorry, \"" + userDouble.ToString() + "\" was not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // Was found
                {
                    MessageBox.Show(userDouble.ToString() + " was found on line: " + location.ToString() + ".", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            double userLINQ;
            // string[] items = new string[numListBox];

            //  Get numbers.ToString() in items array
            //for (int i = 0; i < numListBox; i++)
            //{
            //  items[i] = numbers[i].ToString();
            //}

            // Read user's string from TextBox
            if (double.TryParse(searchLINQTextBox.Text, out userLINQ))
            {
                //Search for userLINQ using LINQ extension method with lambda expression
                var matchedEntry = numbers.Where(d => d.Equals(userLINQ));

                //Display search results
                foreach (double d in matchedEntry)
                {
                    MessageBox.Show(d + " was found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // *** METHODS ***

        // Read array from file
        private void ReadDefaultFile(string fileName, double[] numbers, int maxSize)
        {
            // Declare variables
            int count;
            string lineEntry;
            double parsedEntry;

            try
            {
                // Open file
                StreamReader inputFile = File.OpenText(fileName);

                // Read words from file
                count = 0;

                while (!inputFile.EndOfStream && count < maxSize)
                {
                    // Read line
                    lineEntry = inputFile.ReadLine();

                    // Parse
                    if (double.TryParse(lineEntry, out parsedEntry))
                    {
                        numbers[count] = parsedEntry;
                    }
                    else
                    {
                        MessageBox.Show("Line entries in the wrong format have been replaced by zero.", "Invalid Line Entries", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Increment 
                    count++; // count = how many
                }

                // Keep track of how many are in the ListBox
                numListBox += count;

                // Close file
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, error reading file: " + ex.Message);
            }
        }
        private void DisplayDoubles(double[] numbers, int maxSize)
        {
            // Clear ListBox?
            if (clearCheckBox.Checked)
            {
                arrayListBox.Items.Clear();
            }

            for (int i = 0; i < maxSize; i++)
            {
                arrayListBox.Items.Add(numbers[i]);
            }
        }
        private int SearchNumberArray(double[] numbers, double searchDouble, int numListBox)
        {
            bool found = false;
            int index = 0, line = 0;

            // Loop through array
            while (!found && index < numListBox)
            {
                if (numbers[index] == searchDouble)
                {
                    found = true;
                    line = index + 1;
                }

                // Increment 
                index++;
            }

            // Return line number
            return line;
        }
    }
}
