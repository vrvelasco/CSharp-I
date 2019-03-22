using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decideButton_Click(object sender, EventArgs e)
        {
            // Declare constants
            const int MAX_CHILDREN = 2;

            // Declare variables
            int children;
            string childrenMessage = "You will have ";
            string socialClassMessage = "You will be ";
            string possessionsMessage = "You will own ";
            bool ownPossessions = false;
            string decisionMessage = String.Empty;

            // Input and validate number of children.
            if (int.TryParse(childrenTextBox.Text, out children))
            {
                // Check range of children
                if (children >= 0 && children <= MAX_CHILDREN)
                {
                    // Create children message
                    switch (children)
                    {
                        case 0:
                            childrenMessage += "no children";
                            break;
                        case 1:
                            childrenMessage += "one child";
                            break;
                        case 2:
                            childrenMessage += "two children";
                            break;
                        default:
                            // Example of switch default
                            break;
                    }
                }
                else
                {
                    // Display children range error.
                    MessageBox.Show("Please enter 0, 1, or 2 children.");
                }
            }
            else
            {
                // Display invalid children error message
                MessageBox.Show("Please enter number of children.");
            }

            // Input social class from radio buttons
            if (richRadioButton.Checked)
            {
                socialClassMessage += "rich";
            }
            else if (middleClassRadioButton.Checked)
            {
                socialClassMessage += "middle class";
            }
            else if (poorRadioButton.Checked)
            {
                socialClassMessage += "poor";
            }
            else
            {
                // Trailing else
            }
            // Input possessions from CheckBoxes
            if (houseCheckBox.Checked)
            {
                possessionsMessage += "a house";
                ownPossessions = true;
            }
            if (carCheckBox.Checked)
            {
                if (ownPossessions)
                {
                    possessionsMessage += " and ";
                }
                possessionsMessage += "a car";
                ownPossessions = true;
            }
            if (iPhoneCheckBox.Checked)
            {
                // Check for previous possessions
                if (ownPossessions)
                {
                    possessionsMessage += " and ";
                }
                possessionsMessage += "an iPhone";
                ownPossessions = true;
            }
            if (!ownPossessions)
            {
                possessionsMessage += "nothing";
            }

            // Input decision philosophy from ListBox
            if (decisionListBox.SelectedIndex != -1)
            {
                // Get the selected item
                decisionMessage = decisionListBox.SelectedItem.ToString();
            }
            else
            {
                // Display decision philosophy error message.
                MessageBox.Show("Please select how to decide.");
            }

            // Display life situation
            situationLabel.Text = childrenMessage + ", " + socialClassMessage + ", " + possessionsMessage + ", and " + decisionMessage + ".";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the children TextBox
            childrenTextBox.Clear();

            // Set first RadioButton to clear the others.
            richRadioButton.Checked = true;

            // Clear output message label
            situationLabel.Text = string.Empty;

            // Clear CheckBox 
            houseCheckBox.Checked = false;
            carCheckBox.Checked = false;
            iPhoneCheckBox.Checked = false;

            //Select first item in ListBox
            decisionListBox.SelectedIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize ListBox selection
            decisionListBox.SelectedIndex = 0;
        }
    }
}
