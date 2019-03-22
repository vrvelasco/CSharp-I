using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            int age, count;

            // Get input and validate
            if (int.TryParse(ageTextBox.Text, out age))
            {
                // Verify range
                if (age >= 18 && age <= 99)
                {
                    // Age range
                    if (age >= 18 && age<= 29)
                    {
                        ageRangeLabel.Text = "= Young Adult";
                    }
                    else if (age >= 30 && age <= 59)
                    {
                        ageRangeLabel.Text = "= Middle Age";
                    }
                    else if (age >= 60 && age <= 99)
                    {
                        ageRangeLabel.Text = "= Older Adult";
                    }
                        // Initialize Loop counter
                        count = 18;

                    // Loop
                    while (count <= age)
                    {
                        // Display
                        whileListBox.Items.Add(count.ToString());

                        // Increment Loop counter
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 18 - 99.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            int age, count;

            // Get input and validate
            if (int.TryParse(ageTextBox.Text, out age))
            {
                // Verify range
                if (age >= 18 && age <= 99)
                {
                    // Age range
                    if (age >= 18 && age <= 29)
                    {
                        ageRangeLabel.Text = "= Young Adult";
                    }
                    else if (age >= 30 && age <= 59)
                    {
                        ageRangeLabel.Text = "= Middle Age";
                    }
                    else if (age >= 60 && age <= 99)
                    {
                        ageRangeLabel.Text = "= Older Adult";
                    }
                    
                    // Initialize, test and increment Loop counter
                    for (count = age; count <= 99; count++)
                    {
                        // Display
                        forListBox.Items.Add(count.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 18 - 99.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear form
            ageTextBox.Clear();
            ageRangeLabel.Text = string.Empty;
            whileListBox.Items.Clear();
            forListBox.Items.Clear();
            // Return focus
            ageTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }
    }
}
