using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Part 1: Include the following features:
   1) Four text boxes to enter a, b, c, and x.
   2) Two labels to display x and y.
   3) Use the Parse method to convert the input values.
   4) Use exception handling in case of user input errors.
   5) Use the ToString method to convert the output value.
Part 2: Add two more buttons to increment and decrement x, and display the updated x and y.
   1) Use class-level field variables for values that need to be shared between click event handler methods.
   2) Add 1 to x or subtract 1 from x.
   3) Recalculate y.
   4) Redisplay x and y in the labels.
Part 3: Debug the program by using a breakpoint and displaying x in the code.
   1) Take a screenshot showing the program being debugged with the code stopped at a breakpoint, and the value of x displayed by the debugger.
   2) Submit the screenshot along with the zip file of the project.
 */

namespace Processing_Homework
{
    public partial class Form1 : Form
    {
        // Declare variable
        const int X_DELTA = 1;
        int varA, varB, varC, varX, resultX, resultY, newX;

            public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                // Get input
                varA = int.Parse(varATextBox.Text);
                varB = int.Parse(varBTextBox.Text);
                varC = int.Parse(varCTextBox.Text);
                varX = int.Parse(varXTextBox.Text);

                // Math
                resultX = varX;
                resultY = (varA * (varX * varX)) + (varB * varX) + varC;

                // Output (y = ax² + bx + c)
                equationLabel.Text = "y = (" + varA.ToString() +")("+ varX.ToString() + "²) + (" + varB.ToString() +")("+ varX.ToString() + ") + " + varC.ToString();
                xResultLabel.Text = "x = " + resultX.ToString();
                yResultLabel.Text = "y = " + resultY.ToString();
                // Setup newX
                newX = varX;
            }
            catch (Exception ex) // Error message
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear form
            varATextBox.Clear();
            varBTextBox.Clear();
            varCTextBox.Clear();
            varXTextBox.Clear();
            equationLabel.Text = "y = ax² + bx + c";
            xResultLabel.Text = "x =";
            yResultLabel.Text = "y =";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        private void incXButton_Click(object sender, EventArgs e)
        {
            // Increment
            newX += X_DELTA;
            // Calculate
            RecalculateMethod();
        }

        private void decXButton_Click(object sender, EventArgs e)
        {
            // Decrement
            newX -= X_DELTA;
            // Calculate
            RecalculateMethod();
        }

        public void RecalculateMethod() // Method to do the calculation after variable change
        {
            // Math
            resultX = newX;
            resultY = (varA * (newX * newX)) + (varB * newX) + varC;

            // Output (y = ax² + bx + c)
            equationLabel.Text = "y = (" + varA.ToString() + ")(" + newX.ToString() + "²) + (" + varB.ToString() + ")(" + newX.ToString() + ") + " + varC.ToString();
            xResultLabel.Text = "x = " + resultX.ToString();
            yResultLabel.Text = "y = " + resultY.ToString();
        }
    }
}
