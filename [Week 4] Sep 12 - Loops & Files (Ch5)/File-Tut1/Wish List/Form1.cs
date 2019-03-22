using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // StreamReader and StreamWriter

namespace Wish_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            // Catch file system errors
            try
            {
                // Declare StreamWriter variable to hold reference to object
                StreamWriter outputFile;

                // Create file and get reference to object
                outputFile = File.CreateText("WishList.txt");

                // Write wish to file
                outputFile.WriteLine(wishTextBox.Text);

                // Close file
                outputFile.Close();

                // Let the user know
                MessageBox.Show("The wish was written.");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error writing file: " + ex.Message);
            }
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            // Catch file system errors
            try
            {
                // Declare StreamWriter variable to hold reference to object
                StreamWriter outputFile;

                // Create file and get reference to object
                outputFile = File.AppendText("WishList.txt");

                // Write wish to file
                outputFile.WriteLine(wishTextBox.Text);

                // Close file
                outputFile.Close();

                // Let the user know
                MessageBox.Show("The wish was written.");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error writing file: " + ex.Message);
            }

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // Catch file system error
            try
            {
                // Declare variable to hold one wish
                string wish;

                // Declare StreamReader to hold reference
                StreamReader inputFile;

                // Open file
                inputFile = File.OpenText("WishList.txt");

                // Read all wishes from file
                while (!inputFile.EndOfStream)
                {
                    // Read one wish
                    wish = inputFile.ReadLine();

                    // Add wish to ListBox
                    wishListBox.Items.Add(wish);
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show("Error reading file: " + ex.Message);
                          }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text and list boxes.
            wishTextBox.Clear();
            wishListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
