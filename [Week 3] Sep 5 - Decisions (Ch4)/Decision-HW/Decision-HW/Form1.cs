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
    Decision Homework

    Create a program to enter data for a college application, and display the entered and selected
    information.

    Part 1: Highest Grade Completed

    1. Use a TextBox to enter the highest grade completed, 1 through 12.
    2. Use an if-else statement with TryParse to validate the user entered a valid integer.
    Otherwise display an error message.
    3. Use a nested if-else statement to verify the grade is between 1 and 12 (inclusive).
    Otherwise display an error message.
    4. Display the grade as a word (such as “first” or “1st”) only if it is valid and within range.

    Part 2: Degree Program

    1. Use a GroupBox and RadioButtons to select a degree program (such as Programming,
    Database, or Web Development).
    2. Display the selected degree program.

    Part 3: Financial Aid

    1. Use a GroupBox and CheckBoxes to select financial aid sources (such as Grants, Loans, or
       Work-Study).
    2. Display all the selected financial aid sources.

    Part 4: Reason for Attending College

    1. Use a ListBox to select one of the following reasons for attending college:
        a. I want to start a high-paying career.
        b. I want to contribute to society.
        c. I want to be the best I can be.
        d. I’m tired of living at home.
        e. I want to party all the time.
    2. Display the selected reason.
*/
namespace Decisions_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decideButton_Click(object sender, EventArgs e)
        {   // *******************************
            // Part 1: Highest Grade Completed
            // *******************************

            // Declare variables
            int highestGrade;
            string levelInWords = "", degreeProgram = "", financialAid = "", reasons = "[No Reason Selected]";
            string intro = "\nThe highest grade you completed was: ", programIntro = "\n\nYou will complete a: ", aidIntro = "\n\nYou are receiving Financial Aid from:", reasonsIntro = "\n\nYour reason for attending college: ";
            bool gettingAid = false;

            // Get and check input
            if (int.TryParse(highestGradeTextBox.Text, out highestGrade))
            {
                // Within range?
                if (highestGrade >= 1 && highestGrade <= 12)
                {
                    // 1-3 abbreviation
                    switch (highestGrade)
                    {
                        case 1:
                            levelInWords = "1st";
                            break;
                        case 2:
                            levelInWords = "2nd";
                            break;
                        case 3:
                            levelInWords = "3rd";
                            break;
                    }
                    // 4-12 shortcut
                    if (highestGrade > 3)
                    {
                        levelInWords = highestGrade.ToString() + "th";
                    }
                    outputLabel.Text = levelInWords;

                    // **********************
                    // Part 2: Degree Program
                    // **********************

                    // Check Degree Program
                    if (programmingRadioButton.Checked)
                    {
                        degreeProgram = "Programming Degree";
                    }
                    else if (databaseRadioButton.Checked)
                    {
                        degreeProgram = "Database Degree";
                    }
                    else
                    {
                        degreeProgram = "Web Development";
                    }

                    // *********************
                    // Part 3: Financial Aid
                    // *********************

                    // Check Financial Aid options
                    if (grantsCheckBox.Checked)
                    {
                        financialAid += " Grants";
                        gettingAid = true;
                    }
                    if (loansCheckBox.Checked)
                    {
                        if (gettingAid)
                        {
                            financialAid += " and";
                        }
                        financialAid += " Loans";
                        gettingAid = true;
                    }
                    if (workStudyCheckBox.Checked)
                    {
                        if (gettingAid)
                        {
                            financialAid += " and";
                        }
                        financialAid += " Work-Study";
                        gettingAid = true;
                    }
                    if (!gettingAid)
                    {
                        financialAid += " None";
                    }
                    // ************************************
                    // Part 4: Reason for Attending College
                    // ************************************

                    // Input reason from ListBox
                    if (reasonsListBox.SelectedIndex != -1)
                    {
                        // Get the selected item
                        reasons = reasonsListBox.SelectedItem.ToString();
                    }
                    else
                    {
                        // Display decision philosophy error message.
                        MessageBox.Show("Please select a reaseon.", "Reason Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    // And finally, Output
                    outputLabel.Text = intro + levelInWords.ToUpper() + programIntro + degreeProgram.ToUpper() + aidIntro + financialAid.ToUpper() + reasonsIntro + reasons.ToUpper();
                }
                else
                {
                    // Not within range error message
                    MessageBox.Show("Please enter a number between 1 and 12.", "Grade Not In Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Not a valid integer error message
                MessageBox.Show("Please enter a valid grade level between 1 and 12.", "Invalid Grade Level", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear form
            highestGradeTextBox.Clear();
            programmingRadioButton.Checked = true;
            grantsCheckBox.Checked = false;
            loansCheckBox.Checked = false;
            workStudyCheckBox.Checked = false;
            reasonsListBox.SelectedIndex = -1;
            outputLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }
    }
}
