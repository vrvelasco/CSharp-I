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

namespace Random_Array
{
    public partial class Form1 : Form
    {
        // Create array to hold numbers
        int arraySize = 0;
        int[] randomNumbers; // Declare array reference

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Call method for arraySize
            arraySize = UserRandomNumberArrayMethod(userArrayNumberTextBox.Text);
            
            // Check size
            if (arraySize == 0)
            {
                MessageBox.Show("Invalid entry. Please try again!", "Invalid Array Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                randomNumbers = new int[arraySize]; // Create array
                Random rand = new Random();

                // Loop to fill array
                for (int index = 0; index < randomNumbers.Length; index++)
                {
                    // Assign random numbers to array
                    randomNumbers[index] = rand.Next(10); // 0 through 9
                }

                // Display random numbers
                randomListBox.Items.Clear();
                for (int i = 0; i < arraySize; i++)
                {
                    randomListBox.Items.Add(randomNumbers[i]);
                }

                // Select first value
                randomListBox.SelectedIndex = 0;

                // Enable user-selected button
                userSelectedButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Open saveRandomFileDialog
            if (saveRandomFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Catch exceptions
                try
                {
                    // Open new file
                    StreamWriter numberFile = File.CreateText(saveRandomFileDialog.FileName);
                    // Write array to file
                    for (int i = 0; i < arraySize; i++)
                    {
                        numberFile.WriteLine(randomNumbers[i].ToString());
                    }
                    // Close file
                    numberFile.Close();
                    MessageBox.Show("The file was written.", "Task Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving array: " + ex.Message);
                }
            }
        }

        private int UserRandomNumberArrayMethod(string userInput) // Catchy method name
        {
            // Variable
            int arrayNumber;

            if (int.TryParse(userInput, out arrayNumber))
            {

                if (arrayNumber < 0)
                {
                    arrayNumber = 0;
                }
            }
            else
            {
                arrayNumber = 0;
            }

            return arrayNumber;
        }

        private void arrayMessageBoxButton_Click(object sender, EventArgs e)
        {
            DisplayArrayInMessageBox();
        }

        private void userSelectedButton_Click(object sender, EventArgs e)
        {
            // Send to method
           UserSelectedMethod();
        }

        // Method
        private void DisplayArrayInMessageBox()
        {
            // Display Array in MessageBox
            for (int i = 0; i < arraySize; i++)
            {
                MessageBox.Show("Value at index " + i + ": " + randomNumbers[i].ToString(),
                                "Index Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UserSelectedMethod()
        {
            // Variable
            int userSelectedIndex = randomListBox.SelectedIndex;
            string userSelected = "You selected index: ";
            string userValue = "\n\nThe value of the index is: ";

            MessageBox.Show(userSelected + userSelectedIndex + "." + userValue + randomListBox.SelectedItem.ToString() + ".",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
