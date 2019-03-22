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

namespace List_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare the list at the class level so it can be accessed by the other click event handlers.
        List<int> intList = new List<int>();
        List<int> searchLINQList = new List<int>();

        private void intButton_Click(object sender, EventArgs e)
        {
            // Variables
            int userInt; // User int

            // Verify that it is a valid integer.
            if (int.TryParse(intTextBox.Text, out userInt))
            {
                // Add it to a list of integers.
                intList.Add(userInt);
            }
            else
            {
                // Error message
                MessageBox.Show("Please enter a valid integer.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return focus
            intTextBox.Focus();
        }

        private void displayListButton_Click(object sender, EventArgs e)
        {

            // Clear ListBox
            intListBox.Items.Clear();

            // Display the integers in a ListBox.
            foreach (int num in intList)
            {
                intListBox.Items.Add(num);
            }

        }

        private void removeValueButton_Click(object sender, EventArgs e)
        {
            // Remove an integer by its value.
            int index;

            // Check for integer from the user
            if (int.TryParse(removeValueTextBox.Text, out index))
            {
                // Remove by value
                if (!intList.Remove(index))
                {
                    MessageBox.Show(index.ToString() + " was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Return focus
            removeValueTextBox.Focus();
        }

        private void positionButton_Click(object sender, EventArgs e)
        {
            // Insert an integer into a specified position in the list.
            int index, userInt;

            // Validate index
            if (int.TryParse(positionTextBox.Text, out index))
            {
                if (index >= 0 && index <= intList.Count)
                {
                    if (int.TryParse(intTextBox.Text, out userInt))
                    {
                        intList.Insert(index, userInt);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter index in range.\n\nNote: Zero is the first entry.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter integer index.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchInt;
            searchLabel.Text = "Result(s) found: ";

            if (int.TryParse(searchTextBox.Text, out searchInt))
            {

                // Search for an integer.
                for (int i = 0; i < intList.Count; i++)
                {
                    if (intList[i] == searchInt)
                    {
                        searchLabel.Text += "\n" + searchInt.ToString();
                    }
                }
            }
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            // Display
            sumLabel.Text = "Sum:\n" + intList.Sum();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            //  Read a user-selected text file of integers and add them to the list.
            StreamReader inputFile;

            try // Catch file system and parse errors.
            {
                int lineEntry, count;

                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    // Read all int from file
                    count = 0;

                    while (!inputFile.EndOfStream)
                    {
                        // Read on line from file
                        lineEntry = int.Parse(inputFile.ReadLine());

                        // Add to ListBox
                        intList.Add(lineEntry);

                        // Increment
                        count++;
                    }

                    // Close the file
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("Error selecting file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // End OpenFileDialog
            } // End Try
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error reading file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            int num;
            searchLabel.Text = "Result(s) found: ";

            // User input
            if (int.TryParse(searchTextBox.Text, out num))
            {
                // Perform a LINQ search
                var intVar = intList.Where(n => n.Equals(num));

                // Write results to searchLINQList
                foreach (int n in intVar)
                {
                    searchLINQList.Add(n);
                    searchLabel.Text += "\n" + n.ToString();
                }
            }

        }

        private void saveLINQResultsButton_Click(object sender, EventArgs e)
        {
            // Save the LINQ search results to a file.

            try // Catch file system exceptions
            {
                StreamWriter resultFile;

                // Show Save File Dialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open File
                    resultFile = File.CreateText(saveFileDialog.FileName);

                    // Display search results
                    foreach (int r in searchLINQList)
                    {
                        resultFile.WriteLine(r);
                    }

                    // Close file
                    resultFile.Close();
                }
                else
                {
                    MessageBox.Show("Error selecting file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            intTextBox.Clear();
            removeValueTextBox.Clear();
            searchTextBox.Clear();
            positionTextBox.Clear();
            intListBox.Items.Clear();
            intList.Clear();
            sumLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
