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

namespace File_Homework_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        double expenses, total, entry;
        StreamWriter saveFile, saveFile1;
        StreamReader inputFile;
        string listBoxEntry;
        int count;

        private void addButton_Click(object sender, EventArgs e)
        {
            // Valid decimal number?
            if (double.TryParse(expenseTextBox.Text, out expenses))
            {
                // Non-negative?
                if (expenses > 0)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Open File
                        saveFile = File.AppendText(saveFileDialog.FileName);

                        // Write expense
                        saveFile.WriteLine(expenses.ToString());

                        // Close file
                        saveFile.Close();

                        // Return focus to expensesTextBox
                        expenseTextBox.Focus();
                    }
                }
                else
                {
                    // Error
                    MessageBox.Show("Please enter a number greater than zero.", "Positive Number Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Error
                MessageBox.Show("Please enter a valid decimal number.", "Invalid Decimal Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear form
            expenseTextBox.Clear();
            expensesListBox.Items.Clear();
            totalLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expenseTextBox.Focus();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try // Catch file system and parse errors.
            {
                // Show Save File Dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    // Read all expenses from file
                    count = 0;
                    total = 0;

                    // Clear expensesListBox
                    expensesListBox.Items.Clear();

                    while (!inputFile.EndOfStream)
                    {
                        // Enable "Save" Button
                        saveButton.Enabled = true;

                        // Read one line from file
                        entry = double.Parse(inputFile.ReadLine());

                        // Add to expensesListBox
                        expensesListBox.Items.Add(entry.ToString());

                        count++; // Increment
                        total += entry; // Running total
                    }
                    // Close the file
                    inputFile.Close();

                    // Calculate and display
                    totalLabel.Text = "The total for the expenses: " + total.ToString("c");
                }
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Catch file system exceptions
            try
            {
                // Show Save File Dialog
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Open File
                    saveFile1 = File.AppendText(saveFileDialog1.FileName);

                    // Intro
                    saveFile1.WriteLine("Expenses (in USD)");
                    saveFile1.WriteLine("***********************************");
                    
                    // Loop
                    for (int i = 1; i <= expensesListBox.Items.Count; i++)
                    {
                        // Get entry
                        listBoxEntry = expensesListBox.Items[i - 1].ToString();
                        // Write results
                        saveFile1.WriteLine(listBoxEntry);
                    }

                    // Output total
                    saveFile1.WriteLine("===================================");
                    saveFile1.WriteLine("The total expenses are : " + total.ToString("c"));
                    saveFile1.WriteLine("===================================");


                    // Close file
                    saveFile1.Close();
                }
                else
                {
                    MessageBox.Show("Please select a file name.", "Error selecting file name.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error writing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
