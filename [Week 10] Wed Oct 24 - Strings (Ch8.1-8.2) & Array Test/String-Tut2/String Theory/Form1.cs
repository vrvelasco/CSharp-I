using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Theory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateEmail(string email)
        {
            const char AT_SIGN = '@';
            const char DOT = '.';

            // Check at signs and dots
            int index = 0;
            int atSignCount = 0;
            int atSignIndex = -1;
            int lastDotIndex = -1;

            foreach (char ch in email)
            {
                // Check each character
                if (ch == AT_SIGN)
                {
                    atSignCount++;
                    atSignIndex = index;
                }
                else if (ch == DOT)
                {
                    lastDotIndex = index;
                }
                else if (char.IsLetterOrDigit(ch))
                {
                    // OK, continue
                }
                else
                {
                    return false;
                }

                index++;
            } // End foreach

            // Validate at sign and last dot
            if (atSignCount == 1 && atSignIndex != -1 && lastDotIndex > atSignIndex + 1)
            {
                // OK, continue
            }
            else
            {
                return false;
            }

            // Validate dot and top-level domain
            if (email.EndsWith(".com") || email.EndsWith(".org") || email.EndsWith(".net") || email.EndsWith(".edu"))
            {
                // OK, continue
            }
            else
            {
                return false;
            }

            // Everything is OK
            return true;
        }
        private void validateEmailButton_Click(object sender, EventArgs e)
        {
            if (ValidateEmail(inputTextBox.Text))
            {
                validEmailLabel.Text = "Valid Email";
            }
            else
            {
                validEmailLabel.Text = "Invalid Email";
            }
        }

        // Validate 10-digit phone number
        private bool ValidatePhone(string phone)
        {
            // Declare variable
            int numDigits = 0;

            // Check for 10 digits
            foreach (char c in phone)
            {
                if (char.IsDigit(c))
                {
                    numDigits++;
                }
            }

            // Return True or False
            return numDigits == 10;
        }

        // Extract 10 digits from phone number
        private char[] ExtractDigits(string phone)
        {
            char[] digits = new char[10];

            // Extract 10 digits
            int index = 0;

            foreach (char c in phone)
            {
                if (char.IsDigit(c) && index < 10)
                {
                    digits[index] = c;
                    index++;
                }
            }

            // Return array of digits
            return digits;
        }

        // Format 10-digit phone number with dashes
        private string FormatPhone(string digits)
        {
            const string DASH = "-";
            string formatted = "";
            int index = 0;

            // For each digit in the string of digits
            foreach (char c in digits)
            {
                // Insert dashes after area code and prefix 123-456-7890
                if (index == 3 || index == 7)
                {
                    formatted = formatted.Insert(index, DASH);
                    index++;
                }

                // Convert digit to string and insert it
                formatted = formatted.Insert(index, c.ToString());
                index++;
            }

            return formatted;
        }

        // Format 10 digit phone number with dashes: 123-456-7890
        // Calls: ValidatePhone, ExtractDigits, FormatPhone
        private void formatPhoneButton_Click(object sender, EventArgs e)
        {
            string inputPhone;
            char[] phoneDigitsArray = new char[10];
            string phoneDigitsString;
            string formattedPhone;

            inputPhone = inputTextBox.Text;

            if (ValidatePhone(inputPhone))
            {
                phoneDigitsArray = ExtractDigits(inputPhone);      // char[]
                phoneDigitsString = new string(phoneDigitsArray); // string
                formattedPhone = FormatPhone(phoneDigitsString);
                formattedPhoneLabel.Text = formattedPhone;
            }
            else
            {
                formattedPhoneLabel.Text = "Invalid phone";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get text to search in 
            string text = inputTextBox.Text.ToLower();

            // Get search term
            string searchTerm = searchTextBox.Text.ToLower();

            // Search and display result
            if (text.Contains(searchTerm))
            {
                int index = text.IndexOf(searchTerm);

                // Display
                MessageBox.Show(searchTerm + " was found at position " + (index + 1).ToString() + " in " + text);

                // Change search term to green to show found
                searchTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show(searchTerm + " was not found in " + text);

                // Change search term to red to show not found
                searchTextBox.BackColor = Color.Pink;
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            // Get text, search term and replacement
            string text = inputTextBox.Text;
            string searchTerm = searchTextBox.Text;
            string replacement = replaceTextBox.Text;

            // Find search term
            int index = text.IndexOf(searchTerm);

            if (index != -1) // found
            {
                // Remove search term and insert replacement
                text = text.Remove(index, searchTerm.Length);
                text = text.Insert(index, replacement);
                inputTextBox.Text = text;

                // Change color to green to show found
                inputTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                // Change search term to red to show not found
                searchTextBox.BackColor = Color.Pink;
            }
        }

    }
}
