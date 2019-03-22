using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void part1Button_Click(object sender, EventArgs e)
        {
            Part1Method();
        }

        private void part2Button_Click(object sender, EventArgs e)
        {
            // Variable
            string part2String;

            // Get string from TextBox
            part2String = part2TextBox.Text;

            // TextBox empty?
            if (part2String == string.Empty)
            {
                part2Label.Text = "Incorrect entry. Please try again!";
            }
            else
            {
                // Send to Method
                Part2Method(part2String);
            }
        }

        private void part3Button_Click(object sender, EventArgs e)
        {
            // Local variale
            string p3Ans;

            // Send to method and get p3Ans
            Part3Method(out p3Ans);

            // Display p3Ans
            part3Label.Text = "You entered: " + p3Ans;
        }

        private void part4Button_Click(object sender, EventArgs e)
        {
            // Variable
            bool part4CE;

            part4CE = Part4Method(part4TextBox.Text);

            if (part4CE==false)
            {
                MessageBox.Show("Sorry, try again!", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You guessed the secret word!", "Correct!");
            }
        }

        private void part5Button_Click(object sender, EventArgs e)
        {
            // Input word
            string part5Word = part5TextBox.Text;

            // Check for censored words
            Part5Method(ref part5Word);

            // Display
            part5Label.Text = "You entered: " + part5Word;
        }

        /*
         * START OF METHODS
         */

        private void Part1Method()
        {
            // Void Method with No Parameters
            MessageBox.Show("Void Method with No Parameters", "Part 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Part2Method(string word)
        {
            part2Label.Text = "You entered: " + word;
        }

        private void Part3Method(out string output3)
        {
            // Variable
            string input3 = part3TextBox.Text;
            
            // TextBox empty?
            if (input3 == string.Empty)
            {
                output3 = "** NOTHING **";
            }
            else
            {
                // Set output3
                output3 = input3;
            }
        }

        private bool Part4Method(string input4)
        {
            // Variables
            bool p4Secret;
            const string SECRET_WORD = "BOOLEAN";

            // Compare words
            input4 = input4.ToUpper(); // ToUpper so they are both uppercase

            if (input4 == SECRET_WORD)
            {
                p4Secret = true;
            }
            else
            {
                p4Secret = false;
            }
            
            return p4Secret;
        }
        private void Part5Method(ref string input5)
        {
            // ToLower to make them the same so we can compare
            input5 = input5.ToLower();

            // Check word
            if (input5 == "darn" || input5 == "shoot" || input5 == "stink")
            {
                input5 = "[BLEEP]";
            }
        }
    }
}
