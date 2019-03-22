using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void whileButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;     // Loop counter
            int number;   // Ending number
            int sum = 0; // Sum of numbers

            // Input and validate number
            if (int.TryParse(numberTextBox.Text, out number))
            {
                // Verify positive (Nested if)
                if (number > 0)
                {
                    // Initialize loop counter
                    count = 1;

                    // Test Loop counter
                    while (count <= number)
                    {
                        // Calculate sum
                        sum += count;

                        // Display
                        sumListBox.Items.Add(count.ToString() + "\t" + sum.ToString());

                        // Increment Loop counter
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a positive number.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void forButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;     // Loop counter
            int number;   // Ending number
            int sum = 0; // Sum of numbers

            // Input and validate number
            if (int.TryParse(numberTextBox.Text, out number))
            {
                // Verify positive (Nested if)
                if (number > 0)
                {
                    // Initialize, test, and increment Loop counter
                    for (count = 1; count <= number; count++)
                    {
                        // Calculate sum
                        sum += count;

                        // Display
                        sumListBox.Items.Add(count.ToString() + "\t" + sum.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a positive number.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void doWhileButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int count;     // Loop counter
            int number;   // Ending number
            int sum = 0; // Sum of numbers

            // Input and validate number
            if (int.TryParse(numberTextBox.Text, out number))
            {
                // Verify positive (Nested if)
                if (number > 0)
                {
                    // Initialize Loop counter
                    count = 1;

                    do
                    {
                        // Calculate sum
                        sum += count;

                        // Display
                        sumListBox.Items.Add(count.ToString() + "\t" + sum.ToString());

                        // Increment Loop counter
                        count++;

                    } while (count <= number); // Test Loop counter
                }
                else
                {
                    MessageBox.Show("Please enter a positive number.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text box and list box.
            numberTextBox.Clear();
            sumListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

    }
}
