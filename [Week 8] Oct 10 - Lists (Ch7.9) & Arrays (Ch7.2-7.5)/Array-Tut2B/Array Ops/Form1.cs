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
        private void ReadWordFile(string fileName, out string[] words)
        {
            // Declare variables
            const int SIZE = 10;
            string[] temp = new string[SIZE];
            int count; // Actual number of words

            try
            {
                // Open file
                StreamReader wordFile = File.OpenText(fileName);

                // Read words from file
                count = 0;
                
                while (!wordFile.EndOfStream && count < SIZE)
                {
                    temp[count] = wordFile.ReadLine(); // count == index

                    // Increment 
                    count++; // count = how many
                }

                // Close file
                wordFile.Close();

                // Create new array of exact length
                words = new string[count];

                // Copy temp array to new array
                for (int index = 0; index < count; index++)
                {
                    words[index] = temp[index];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, error reading file: " + ex.Message);
                words = null;
            }
        }

        private int SearchWordArray(string[] wordArray, string searchTerm)
        {
            bool found = false;
            int index = 0, line = 0;

            // Loop through array
            while (!found && index < wordArray.Length)
            {
                if (wordArray[index] == searchTerm)
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
        private void searchWordButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            string fileName = "words.txt";
            string[] words; // Declare array
            string word;
            int foundAt;

            // Read words from file
            ReadWordFile(fileName, out words);

            // Read search term
            word = wordTextBox.Text;

            // Search for word
            foundAt = SearchWordArray(words, word);

            // Display search results
            if (foundAt == 0) // Not found
            {
                MessageBox.Show("Sorry, " + word + " was not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Was found
            {
                MessageBox.Show(word + " was found on line " + foundAt.ToString(), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            string fileName = "words.txt";
            string[] words;
            string word;

            // Read words from file
            ReadWordFile(fileName, out words);

            // Read search term
            word = wordTextBox.Text;

            // Search for word using LINQ extension method with lambda expression
            var foundWords = words.Where(w => w.Contains(word));

            // Display search results
            foreach (string f in foundWords)
            {
                MessageBox.Show(f + " was found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
