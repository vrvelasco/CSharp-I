using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*                                      Loop Review
    Create a program with the following features:
    1) A text box for user to enter a number, which must be an integer. Otherwise display an error message.
    2) The number must be between 100 and 599, otherwise display an error message.
    3) Display the range of the number as text in a label:
        a) 100 to 199: One Hundreds
        b) 200 to 299: Two Hundreds
        c) 300 to 399: Three Hundreds
        4) 400 to 499: Four Hundreds
        5) 500 to 599: Five Hundreds
    4) Create a While loop to display a list of numbers, from 100 up to but not including the user’s number, in a list box. 
    5) Create a For loop to display a list of numbers, from the user’s number up to and including 599, in another list box. (Or use the same list box in a separate button.)
    6) Create a Do While loop to display a list of numbers in a third list box box.  (Or use the same list box in a separate button.)
        a) Starting with half the user’s number (as low as 50, truncate if necessary)
        b) Up to and including twice the user’s number, but no more than 599
*/
namespace Loop_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NumberRange myNumberRange = new NumberRange();

        private void whileButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            int userNumber, count, sum = 0;

            // Get input and validate
            if (int.TryParse(userNumberTextBox.Text, out userNumber))
            {
                // Verify range
                if (userNumber >= 100 && userNumber <= 599)
                {
                    // Send to my Class
                    myNumberRange.setUserNumber(userNumber);
                    rangeTextBox.Text = myNumberRange.getRange();

                    // Initialize Loop counter
                    count = 100;

                    // Loop
                    while (count < userNumber)
                    {
                        // Calculate sum
                        sum += count;

                        // Display
                        whileListBox.Items.Add(count.ToString() + "\t" + sum.ToString());

                        // Increment Loop counter
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 100 - 599.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            int userNumber, count, sum = 0;

            // Get input and validate
            if (int.TryParse(userNumberTextBox.Text, out userNumber))
            {
                // Verify range
                if (userNumber >= 100 && userNumber <= 599)
                {           
                    // Send to my Class
                    myNumberRange.setUserNumber(userNumber);
                    rangeTextBox.Text = myNumberRange.getRange();

                    // Initialize, test and increment Loop counter
                    for (count = userNumber; count <= 599; count++)
                    {
                        // Calculate sum
                        sum += count;

                        // Display
                        forListBox.Items.Add(count.ToString() + "\t" + sum.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 100 - 599.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            int userNumber, userNumber2X, count, sum = 0;

            // Get input and validate
            if (int.TryParse(userNumberTextBox.Text, out userNumber))
            {
                // Verify range
                if (userNumber >= 100 && userNumber <= 599)
                {
                    // Send to my Class
                    myNumberRange.setUserNumber(userNumber);
                    rangeTextBox.Text = myNumberRange.getRange();
                    
                    // Initialize Loop counter
                    count = userNumber / 2;

                    // Double userNumber
                    userNumber2X = userNumber * 2;

                    // Check userNumber2X
                    if (userNumber2X > 599)
                    {
                        userNumber2X = 599;  // Maximum value
                    }

                    // Check count
                    if (count < 50)
                    {
                        count = 50; // Minimum value
                    }
                    else
                    {
                        // Loop
                        do
                        {
                            // Calculate sum
                            sum += count;

                            // Display
                            doWhileListBox.Items.Add(count.ToString() + "\t" + sum.ToString());

                            // Increment Loop counter
                            count++;

                        } while (count <= userNumber2X); // Test Loop counter
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 100 - 599.", "Invalid Integer Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes
            userNumberTextBox.Clear();
            rangeTextBox.Clear();

            // Clear ListBoxes
            whileListBox.Items.Clear();
            forListBox.Items.Clear();
            doWhileListBox.Items.Clear();

            // Return focaus to TextBox
            userNumberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }
    }
}

