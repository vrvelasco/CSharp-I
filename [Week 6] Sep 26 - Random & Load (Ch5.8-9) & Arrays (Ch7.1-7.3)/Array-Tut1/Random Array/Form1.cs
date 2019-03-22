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
        const int SIZE = 5;
        int[] randomNumbers; // Declare array reference

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            randomNumbers = new int[SIZE]; // Create array
            Random rand = new Random();

            // Loop to fill array
            for (int index = 0; index < randomNumbers.Length; index++)
            {
                // Assign random numbers to array
                randomNumbers[index] = rand.Next(10); // 0 through 9
            }

            // Display random numbers
            randomListBox.Items.Clear();
            for (int i = 0; i < SIZE; i++)
            {
                randomListBox.Items.Add(randomNumbers[i]);
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
                    for (int i = 0; i < SIZE; i++)
                    {
                        numberFile.WriteLine(randomNumbers[i].ToString());
                    }
                    // Close file
                    numberFile.Close();
                    MessageBox.Show("The file was written.","Task Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving array: " + ex.Message);
                }
            }
        }
    }
}
