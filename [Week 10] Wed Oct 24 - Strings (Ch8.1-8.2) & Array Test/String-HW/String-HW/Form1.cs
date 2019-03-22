using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validateNameButton_Click(object sender, EventArgs e)
        {
            string title = "", firstName = "", lastName = "", suffix = "", tempName = "";
            const char SPACE = ' ';
            char[] userName;
            int newName = 0, spaceCount = 0;

                        if (fullNameTextBox.Text != "")
            {
                // Validate that the string is a full name
                if (fullNameTextBox.Text.Contains(SPACE)) // Make sure it contains at least a first and last name (seperated by a space)
                {
                    // Get userName entry
                    userName = fullNameTextBox.Text.ToUpper().ToCharArray();

                    // Loop through array
                    for (int i = 0; i < userName.Length; i++)
                    {
                        tempName += userName[i]; // Start building the name

                        switch (newName) // Do we need to switch to new name part?
                        {
                            case 0:
                                if (tempName == "MR. " || tempName == "MS. " || tempName == "DR. ") // Does it match the titles that we are looking for?
                                {
                                    title = tempName + "[ VALID ]"; // Title matches above. Display BONUS.
                                }
                                else
                                {
                                    title = tempName; // No Mr., Ms., or Dr., but it might still be a valid so we will display it.
                                }
                                break;

                            case 1:
                                firstName = tempName;
                                break;

                            case 2:
                                lastName = tempName;
                                break;

                            case 3:
                                if (tempName == "II" || tempName == "III" || tempName == "JR.") // Does it match II, III, Jr.?
                                {
                                    suffix = tempName + " [ VALID ]"; // Suffix matches above. Display BONUS.
                                }
                                else
                                {
                                    suffix = tempName;
                                }
                                break;

                            default:
                                // Does nothing.
                                break;
                        }

                        if (userName[i] == SPACE)
                        {
                            newName++;
                            spaceCount++;
                            tempName = "";
                        }
                    }

                    // Correction (if any)
                    if (spaceCount == 2 && firstName == " ") // First and Last Name with 2 spaces
                    {
                        firstName = title;
                        title = "";
                    }
                    
                    else if (spaceCount == 1) // First and Last Name only
                    {
                        lastName = firstName;
                        firstName = title;
                        title = "";
                    }
                    else if (spaceCount == 2) // No Title
                    {
                        suffix = lastName;
                        lastName = firstName;
                        firstName = title;
                        title = "";
                    }

                    // Display name parts
                    MessageBox.Show("Title: " + title + "\n\nFirst Name: " + firstName + "\n\nLast Name: " + lastName + "\n\nSuffix: " + suffix, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // The user did not include a space to seperate first and last name.
                    MessageBox.Show("You need to enter at least your first and last name.\n\nPlease check the name field and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // *** BONUS: Validate an optional title and/or suffix
            }
            else
            {
                MessageBox.Show("The name field cannot be blank.", "Text Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validateCardButton_Click(object sender, EventArgs e)
        {
            // Variables 
            string cardNumber = "", expMonth = "", expYear = "", cvvCode = "", valid = "";
            char[] cardArray;
            double doubleCard;
            int intMonth = 0, intYear = 0;

            // Valid input?
            if (double.TryParse(cardTextBox.Text, out doubleCard))
            {
                // Get userCard entry
                string userCard = cardTextBox.Text;

                // Validate that the string contains 23 digits
                if (userCard.Length == 23)
                {
                    // Add chars to cardArray
                    cardArray = userCard.ToCharArray();

                    // Get chars for Card Number
                    for (int i = 0; i < 16; i++)
                    {
                        cardNumber += cardArray[i];
                    }

                    // Get chars for EXP Month
                    for (int i = 16; i < 18; i++)
                    {
                        expMonth += cardArray[i];
                    }

                    intMonth = int.Parse(expMonth);

                    // Get chars for EXP Year
                    for (int i = 18; i < 20; i++)
                    {
                        expYear += cardArray[i];
                    }

                    intYear = int.Parse(expYear);

                    // Get chars for CVV
                    for (int i = 20; i < 23; i++)
                    {
                        cvvCode += cardArray[i];
                    }

                    // Format Card Number into 4 groups of 4 (16 total)
                    cardNumber = cardNumber.Insert(4, "-"); // First group
                    cardNumber = cardNumber.Insert(9, "-"); // Second group
                    cardNumber = cardNumber.Insert(14, "-"); // Third and Forth groups

                    // *** BONUS: Verify the expiration is a valid month/year between 1980 and 2050.
                    if (intMonth >= 1 && intMonth <= 12)
                    {
                        valid = " - [Bonus: VALID]"; // Set to valid and then check year

                        // Year within range?
                        if (cardArray[18] == '6' || cardArray[18] == '7')
                        {
                            valid = " - [Bonus: INVALID]";
                        }

                        // Year 2050?
                        if (cardArray[18] == '5' && cardArray[19] != '0')
                        {
                            valid = " - [Bonus: INVALID]";
                        }
                    }
                    else
                    {
                        valid = " - [Bonus: INVALID]";
                    }

                    // Display
                    MessageBox.Show("Card Number: " + cardNumber + "\n\nExpiration Date: " + expMonth + "/" + expYear + valid + "\n\nCVV Code: " + cvvCode, "Card Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please enter the following:\n- Card Number\n- Expiration Date\n- and CVV Code (Security code on the back)\n\n* No formatting is required. *", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Only numbers are accepted in this field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string userString, darn = "DARN", shoot = "SHOOT", stink = "STINK";

            if (userStringTextBox.Text != "")
            {
                userString = userStringTextBox.Text.ToUpper();

                // Search and display result
                if (userString.Contains(darn))
                {
                    int index = userString.IndexOf(darn);

                    // Display
                    MessageBox.Show("\"" + darn + "\" was found at position: " + (index + 1).ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("\"" + darn + "\" was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // *************************************************************************************************************

                // Search and display result
                if (userString.Contains(shoot))
                {
                    int index = userString.IndexOf(shoot);

                    // Display
                    MessageBox.Show("\"" + shoot + "\" was found at position: " + (index + 1).ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("\"" + shoot + "\" was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // *************************************************************************************************************

                // Search and display result
                if (userString.Contains(stink))
                {
                    int index = userString.IndexOf(stink);

                    // Display
                    MessageBox.Show("\"" + stink + "\" was found at position: " + (index + 1).ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("\"" + stink + "\" was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Error
                MessageBox.Show("Please enter a sentence before clicking the \"Search\" button.", "Sentence Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string userString, bleep = "[ BLEEP ]", darn = "darn", shoot = "shoot", stink = "stink";

            if (userStringTextBox.Text != "")
            {
                userString = userStringTextBox.Text.ToLower();

                // Find search term (DARN)
                int index = userString.IndexOf(darn);

                if (index != -1) // found
                {
                    // Remove search term and insert replacement
                    userString = userString.Remove(index, darn.Length);
                    userString = userString.Insert(index, bleep);
                    userStringTextBox.Text = userString;
                }

                // *************************************************************************************************************

                // Find search term (SHOOT)
                int index2 = userString.IndexOf(shoot);

                if (index2 != -1) // found
                {
                    // Remove search term and insert replacement
                    userString = userString.Remove(index2, shoot.Length);
                    userString = userString.Insert(index2, bleep);
                    userStringTextBox.Text = userString;
                }

                // *************************************************************************************************************

                // Find search term (STINK)
                int index3 = userString.IndexOf(stink);

                if (index3 != -1) // found
                {
                    // Remove search term and insert replacement
                    userString = userString.Remove(index3, stink.Length);
                    userString = userString.Insert(index3, bleep);
                    userStringTextBox.Text = userString;
                }

                // Inform user that processing is complete
                MessageBox.Show("If any of these words appear in your sentence:\n- Darn\n- Shoot\n- Stink\n\n Then they have been replaced with: " + bleep, "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Error
                MessageBox.Show("Please enter a sentence before clicking the \"Replace\" button.", "Sentence Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
