using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e) // Button Click Handler
        {
            MessageBox.Show("Hello World!", "Message"); // Display message
        }

        private void morningButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Good Morning!";
        }

        private void afternoonButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Good Afternoon!";

        }

        private void illinoisPictureBox_Click(object sender, EventArgs e)
        {
            flagNameLabel.Text = "Illinois";
        }

        private void missouriPictureBox_Click(object sender, EventArgs e)
        {
            flagNameLabel.Text = "Missouri";
        }

        private void showIllinoisButton_Click(object sender, EventArgs e)
        {
            illinoisPictureBox.Visible = true;
            missouriPictureBox.Visible = false;
        }
        /* Click event handler for the showMissouriButton
         * This method makes Missouri visible and hides Illinois. 
         */

            // Missouri Button handler
        private void showMissouriButton_Click(object sender, EventArgs e)
        {
            illinoisPictureBox.Visible = false; // Hide Illinois
            missouriPictureBox.Visible = true; //  Show Missouri
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes form
        }
    }
}
