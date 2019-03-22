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

namespace Array_Test_Minerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Class level variables
        const int SIZE = 10;
        string[] minerals = new string[SIZE];
        int count = 0;

        private void readFileButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox 
            mineralsListBox.Items.Clear();

            try
            {
                // Show Open File Dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // File Read?
                    if (ReadMinerals(openFileDialog.FileName))
                    {
                        // Display integers in the first ListBox
                        for (int i = 0; i < count; i++)
                        {
                            mineralsListBox.Items.Add(minerals[i]);
                        }
                    }
                    else
                    {
                        // Error
                        MessageBox.Show("Error reading file to array", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Error
                    MessageBox.Show("File not selected. Please try again!", "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchMineralsButton_Click(object sender, EventArgs e)
        {
            // Get user input
            string searchMineral = searchTextBox.Text.ToLower();

            // Send to method
            if (SearchMinerals(searchMineral.ToLower()) == searchMineral.ToLower())
            {

                // Display
                MessageBox.Show(searchMineral + " was found.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Display
                MessageBox.Show("The mineral you searched for was not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Methods ***

        private bool ReadMinerals(string fileName)
        {
            bool fileRead = false;

            // Read the file of minerals to the array
            StreamReader inputFile;
            string lineEntry;

            if (count != 0)
            {
                count = 0; // Reset count in case a new file was selected.
            }
            try
            {
                inputFile = File.OpenText(fileName);

                while (!inputFile.EndOfStream && count != SIZE)
                {
                    // Read one line from file
                    lineEntry = inputFile.ReadLine();
                    minerals[count] = lineEntry.ToLower();

                    count++; // Increment
                }

                // Close the file
                inputFile.Close();

                fileRead = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in reading file: " + ex.Message);
                fileRead = false;
            }

            return fileRead;
        }

        private string SearchMinerals(string searchMineral)
        {
            bool found = false;
            int index = 0;

            while (!found && index < count)
            {
                if (minerals[index] == searchMineral)
                {
                    found = true;
                }

                // Increment 
                index++;
            }

            if (found)
            {
                // All good.
            }
            else
            {
                //Error
                searchMineral = "";
            }

            // Return line number
            return searchMineral;
        }
    }
}
