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

namespace Array_RevHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Class level variables
        string fileName = "", saveFileName = "";
        int[] numbers = new int[50];
        string[] words = new string[50];
        int count = 0;

        private void openButton_Click(object sender, EventArgs e)
        {
            ResetForm();

            // Call OpenFileDialog
            OpenFileDialog();

            // Read file to array
            if (fileName != "")
            {
                ReadFileToArray();

                if (count != 0) // If count is still zero, then something happen with the file (Might be in the wrong format)
                {
                    ConverArrayToWords();

                    SaveFileDialog();

                    if (saveFileName != "")
                    {
                        WriteArrayToFile();
                    }
                }
            }

            if (savePictureBox.Image == correctPictureBox.Image)
            {
                // Confirm to user
                MessageBox.Show("Processing completed successfully. Your file is located at:\n\n " + saveFileName, "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /***********
         * METHODS *
         ***********/

        private void OpenFileDialog()
        {
            // Catch file system error
            try
            {
                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;

                    openPictureBox.Image = correctPictureBox.Image;
                }
                else
                {
                    MessageBox.Show("File not selected. Please try again!", "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                    openPictureBox.Image = wrongPictureBox.Image;
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show("Error reading file: " + ex.Message);
                ResetForm();
                openPictureBox.Image = wrongPictureBox.Image;
            }
        }

        private void ReadFileToArray()
        {
            // Read file to array
            StreamReader inputFile;
            int lineEntry;

            try
            {
                inputFile = File.OpenText(fileName);

                while (!inputFile.EndOfStream)
                {
                    // Read one line from file
                    lineEntry = int.Parse(inputFile.ReadLine());
                    numbers[count] = lineEntry;

                    count++; // Increment
                }

                readPictureBox.Image = correctPictureBox.Image;

                // Close the file
                inputFile.Close();

                // Display integers in the first ListBox
                for (int i = 0; i < count; i++)
                {
                    integerArrayListBox.Items.Add(numbers[i]);
                }

                displayPictureBox.Image = correctPictureBox.Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in reading file: " + ex.Message);
                openPictureBox.Image = wrongPictureBox.Image;
            }
        }

        private void ConverArrayToWords()
        {
            // Variables
            int intFromArray;

            // Loop through integer array
            for (int i = 0; i < count; i++)
            {
                intFromArray = numbers[i];

                switch (intFromArray)
                {
                    // For values 1-5, store the word in second array
                    case 1:
                        words[i] = "One";
                        wordsArrayListBox.Items.Add(words[i]);
                        break;
                    case 2:
                        words[i] = "Two";
                        wordsArrayListBox.Items.Add(words[i]);
                        break;
                    case 3:
                        words[i] = "Three";
                        wordsArrayListBox.Items.Add(words[i]);
                        break;
                    case 4:
                        words[i] = "Four";
                        wordsArrayListBox.Items.Add(words[i]);
                        break;
                    case 5:
                        words[i] = "Five";
                        wordsArrayListBox.Items.Add(words[i]);
                        break;
                    default:
                        // If lower than 1 == "lower"
                        if (intFromArray < 1)
                        {
                            words[i] = "Lower than 1";
                            wordsArrayListBox.Items.Add(words[i]);
                        }
                        // if higher than 5 == "higher"
                        if (intFromArray > 5)
                        {
                            words[i] = "Higher than 5";
                            wordsArrayListBox.Items.Add("Higher than 5");
                        }
                        break;
                }

                loopPictureBox.Image = correctPictureBox.Image;
                convertPictureBox.Image = correctPictureBox.Image;
            }
        }

        private void SaveFileDialog()
        {
            // Catch file system error
            try
            {
                // Show the OpenFileDialog
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileName = saveFileDialog1.FileName;

                    savePictureBox.Image = correctPictureBox.Image;
                }
                else
                {
                    MessageBox.Show("File not selected. Please try again!", "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    savePictureBox.Image = wrongPictureBox.Image;
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show("Error reading file: " + ex.Message);
                savePictureBox.Image = wrongPictureBox.Image;
            }
        }

        private void WriteArrayToFile()
        {
            StreamWriter outputFile;

            try
            {
                // Open File
                outputFile = File.CreateText(saveFileName);

                // Write array to file
                for (int i = 0; i < count; i++)
                {
                    // Write results
                    outputFile.WriteLine(words[i]);
                }

                // Close file
                outputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing file: " + ex.Message);
                savePictureBox.Image = wrongPictureBox.Image;
            }
        }

        private void ResetForm()
        {
            // Reset Lights
            openPictureBox.Image = defaultPictureBox.Image;
            readPictureBox.Image = defaultPictureBox.Image;
            displayPictureBox.Image = defaultPictureBox.Image;
            loopPictureBox.Image = defaultPictureBox.Image;
            convertPictureBox.Image = defaultPictureBox.Image;
            savePictureBox.Image = defaultPictureBox.Image;

            // Reset Variables
            fileName = "";
            count = 0;

            // Reset ListBox
            integerArrayListBox.Items.Clear();
            wordsArrayListBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
