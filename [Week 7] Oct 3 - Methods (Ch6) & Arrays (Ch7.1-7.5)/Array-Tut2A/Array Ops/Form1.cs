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

namespace Array_Ops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Read array from file
        private int ReadNumberFile(string fileName, double[] numbers, int maxSize)
        {
            // Declare variables
            int count;

            try
            {
                // Open file
                StreamReader numberFile = File.OpenText(fileName);

                // Read numbers from file
                count = 0;

                while (!numberFile.EndOfStream && count < maxSize)
                {
                    // Here count is the index
                    numbers[count] = double.Parse(numberFile.ReadLine());
                    count++; // Now it is the count
                }

                // Close file
                numberFile.Close();

                // Return
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, error reading file: " + ex.Message);
                return 0;
            }

        }

        private void DisplayNumbers(double[] numbers)
        {
            foreach (double number in numbers)
            {
                numbersListBox.Items.Add(number);
            }
        }

        private void ShrinkArray(ref double[] original, int count)
        {
            // Create new array of size needed
            double[] resized = new double[count];

            // Copy elements of original array
            for (int index = 0; index < count; index++)
            {
                resized[index] = original[index];
                            }

            // Assign new array to original reference
            original = resized;
        }

        private void processNumbersButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            string fileName = "numbers.txt";
            const int SIZE = 10;
            double[] numbers = new double[SIZE];
            int count;

            // Read numbers from file
            count = ReadNumberFile(fileName, numbers, SIZE);

            // Shrink array to needed size
            ShrinkArray(ref numbers, count);

            // Display numbers in ListBox
            DisplayNumbers(numbers);
        }

        private void searchWordButton_Click(object sender, EventArgs e)
        {

        }
    }
}
