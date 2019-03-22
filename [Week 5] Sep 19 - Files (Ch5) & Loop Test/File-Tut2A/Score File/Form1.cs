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

namespace Score_File
{
    public partial class Form1 : Form
    {
        // Declare variables
        int count, total, score;
        double average;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            
            StreamReader inputFile;

            try // Catch file system and parse errors.
            {
                inputFile = File.OpenText("Scores.txt");

                // Read all scores from file
                count = 0;
                total = 0;
                while (!inputFile.EndOfStream)
                {
                    // Read on line from file
                    score = int.Parse(inputFile.ReadLine());

                    count++; // Increment
                    total += score; // Running total
                }
                // Close the file
                inputFile.Close();

                // Calculate and display
                average = (double)total / count;
                countLabel.Text = count.ToString();
                totalLabel.Text = total.ToString();
                averageLabel.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void randomGradeButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int grade; // random number
            string letter; // letter grade

            // Create a Random object
            Random rand = new Random();
            
            // Get a random number from 1 to 5
            grade = rand.Next(5) + 1; // Add 1, because it's 0-4.

            // Convert to letter grade
            switch (grade)
            {
                case 1:
                    letter = "A";
                    break;
                case 2:
                    letter = "B";
                    break;
                case 3:
                    letter = "C";
                    break;
                case 4:
                    letter = "D";
                    break;
                case 5:
                    letter = "F";
                    break;
                default:
                    letter = "W";
                    break;
            }

            // Catch file system errors
            try
            {
                if (resultFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter resultFile = File.AppendText(resultFileDialog.FileName);
                    resultFile.WriteLine(letter);
                    resultFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error appending file: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int number;
            string saying;

            // Create Random object
            Random rand = new Random();
            number = rand.Next(3); // 0 thru 2

            // Convert
            switch (number)
            {
                case 0:
                    saying = "Congratulations, Graduate!";
                    break;
                case 1:
                    saying = "We'll see you again next semester!";
                    break;
                case 2:
                    saying = "Good luck job-hunting";
                    break;
                default:
                    saying = "Error: Random saying not selected";
                    break;
            }
            sayingLabel.Text = saying;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            try // Catch file system and parse errors.
            {
                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    // Read all scores from file
                    count = 0;
                    total = 0;
                    while (!inputFile.EndOfStream)
                    {
                        // Read on line from file
                        score = int.Parse(inputFile.ReadLine());

                        count++; // Increment
                        total += score; // Running total
                    }
                    // Close the file
                    inputFile.Close();

                    // Calculate and display
                    average = (double)total / count;
                    countLabel.Text = count.ToString();
                    totalLabel.Text = total.ToString();
                    averageLabel.Text = average.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Error selecting file name.");
                } // End OpenFileDialog
            } // End Try
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            // Catch file system exceptions
            try
            {
                StreamWriter resultFile;
                // Show Save File Dialog
                if (resultFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open File
                    resultFile = File.CreateText(resultFileDialog.FileName);
                    // Write results
                    resultFile.WriteLine(count.ToString());
                    resultFile.WriteLine(total.ToString());
                    resultFile.WriteLine(average.ToString("n1"));
                    // Close file
                    resultFile.Close();
                }
                else
                {
                    MessageBox.Show("Error selecting file name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing file: " + ex.Message);
            }
        }
    }
}
