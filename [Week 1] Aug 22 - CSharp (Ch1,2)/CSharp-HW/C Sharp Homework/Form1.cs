using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageBoxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a MessageBox!", "MessageBox Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            languageLabel.Text = "Hello!"; // Displays English greeting.
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            languageLabel.Text = "¡Hola!"; // Displays Spanish greeting.
        }

        private void redCrossPictureBox_Click(object sender, EventArgs e)
        {
            jobLabel.Text = "The American Red Cross"; // Display name.
        }

        private void commerceBankPictureBox_Click(object sender, EventArgs e)
        {
            jobLabel.Text = "Commerce Bank";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            /* 
             * This 
             * is
             * a
             * block
             * comment
             */
            this.Close(); // Closes program (This is a line comment)
        }

        private void showARCButton_Click(object sender, EventArgs e)
        {
            redCrossPictureBox.Visible = true;
            commerceBankPictureBox.Visible = false;
        }

        private void showCBIButton_Click(object sender, EventArgs e)
        {
            redCrossPictureBox.Visible = false;
            commerceBankPictureBox.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            languageLabel.Text = string.Empty;
            jobLabel.Text = string.Empty;
            redCrossPictureBox.Visible = true;
            commerceBankPictureBox.Visible = true;
        }
    }
}
