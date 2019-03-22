using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_of_Nations
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Local data
            string name;
            string cont;
            int pop;

            // Validate population
            if (int.TryParse(populationTextBox.Text, out pop) && pop >= 1)
            {
                // Input strings
                name = nameTextBox.Text;
                cont = continentTextBox.Text;

                // Create and populate nation object
                Nation nat = new Nation(name, cont, pop);

                // Add nation to static World object
                World.theWorld.AddNation(nat);

                // Close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter population.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close the form without doing anything
            this.Close();
        }
    }
}
