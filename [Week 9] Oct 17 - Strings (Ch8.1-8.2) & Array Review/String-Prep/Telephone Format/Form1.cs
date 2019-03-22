﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidNumber mehtod accepts a string and 
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // Length of a valid string
            bool valid = true; // Flag to indicate validity

            // Check the string's length.
            if (str.Length == VALID_LENGTH)
            {
                // Check each character in str.
                foreach (char ch in str)
                {
                    // If this character is not a digit, the 
                    // string is not valid.
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                                    }
            }
            else
            {
                // Incorrect lenght.
                valid = false;
                            }

            // Return the status.
            return valid;
        }

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        private void TelephoneFormat (ref string str)
        {
            // First, insert the left paren at positiion 0.
            str = str.Insert(0, "(");

            // Next, insert the right paren at position 4.
            str = str.Insert(4, ")");

            // Next, insert the hypen at position 8.
            str = str.Insert(8, "-");
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input.
            string input = numberTextBox.Text.Trim();

            // If the input is a valid number, format it
            // and display it.
            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid input.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}