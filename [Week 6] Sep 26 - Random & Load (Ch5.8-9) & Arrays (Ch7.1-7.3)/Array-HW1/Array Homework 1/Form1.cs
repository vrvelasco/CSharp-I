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
    public partial class Form1 : Form
    {
        // Declare variables
        StreamReader inputFile;
        double line;
        double[] arrayNumbers; // Declare array reference   

        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            arrayNumbers = new double[5]; // Create array
            int count =0; // Declare and initialize

            // Open file
            inputFile = File.OpenText("Array.txt");

            // Loop while not at the end
            while (!inputFile.EndOfStream)
            {
                // Read one line from file
                line = double.Parse(inputFile.ReadLine());

                // Add to array
                arrayNumbers[count] = line;

                count++; // Increment
            }
            
            // Display
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayListBox.Items.Add(arrayNumbers[i]);
            }
            
            // Close the file
            inputFile.Close();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear form.
            arrayListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
