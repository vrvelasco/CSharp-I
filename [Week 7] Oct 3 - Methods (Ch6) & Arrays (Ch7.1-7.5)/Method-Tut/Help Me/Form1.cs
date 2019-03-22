using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare a void method
        private void HelpMe()
        {
            MessageBox.Show("Hang On Sloopy!", "HelpMe Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpMeButton_Click(object sender, EventArgs e)
        {
            // Call the void method
            HelpMe();
        }

        // Declare a method with a parameter
        private void HelpMeWith(string request)
        {
            // Display help message
            MessageBox.Show("I can help you with " + request);
        }
        private void helpMeWithButton_Click(object sender, EventArgs e)
        {
            // Pass argument to method
            HelpMeWith(requestTextBox.Text);
        }

        // Declare a method with an output parameter
        private void GiveMeAnswer(string request, out string answer)
        {
            // Store help into output parameter
            answer = "I'll be there to help with " + request;
        }

        private void giveMeButton_Click(object sender, EventArgs e)
        {
            // Declare local variable
            string answer;

            // Call method
            GiveMeAnswer(requestTextBox.Text, out answer);

            // Display answer
            answerLabel.Text = answer;
        }

        // Declare a method with a return value
        private string ReturnMyAnswer(string request)
        {
            // Return answer to caller
            return "We're all in " + request + " together.";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // Call method to return answer
            answerLabel.Text = ReturnMyAnswer(requestTextBox.Text);
        }

        // Declare a method with a reference parameter
        private void SpellCheckDog(ref string word)
        {
            // Correct the spelling of "dog"
            if (word == "dag" || word == "deg")
            {
                word = "dog";
            }
        }

        private void spellButton_Click(object sender, EventArgs e)
        {
            // Input word
            string myWord = requestTextBox.Text;

            // Correct spelling
            SpellCheckDog(ref myWord);

            // Display corrected word
            answerLabel.Text = myWord;
        }
    }
}
