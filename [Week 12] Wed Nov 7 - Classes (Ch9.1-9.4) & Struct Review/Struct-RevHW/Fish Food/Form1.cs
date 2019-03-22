using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_Food
{
    public partial class Form1 : Form
    {
        struct Fish // Declare fish structure
        {
            public string name;
            public string habitat;
            public string food;
            public double size;
        }

        //Declare and create list of fish
        List<Fish> fishList = new List<Fish>();

        public Form1()
        {
            InitializeComponent();
        }

        // Enter Fish Button Handler
        private void enterFishButton_Click(object sender, EventArgs e)
        {
            double size;

            // Validate fish, habitat, and food
            if (fishTextBox.Text.Length > 0 && habitatTextBox.Text.Length > 0 && foodTextBox.Text.Length > 0 && sizeTextBox.Text.Length > 0)
            {
                if (double.TryParse(sizeTextBox.Text, out size))
                {
                    if (size >= 1.0 && size <= 10.0)
                    {
                        // Create struct to hold data
                        Fish fish = new Fish();
                        fish.name = fishTextBox.Text.ToUpper();
                        fish.habitat = habitatTextBox.Text.ToUpper();
                        fish.food = foodTextBox.Text.ToUpper();
                        fish.size = size;

                        // Add struct to List
                        fishList.Add(fish);

                        // Display the fish on the form
                        fishListBox.Items.Add(fish.name + "\t\t" + fish.habitat + "\t\t" + fish.food + "\t\t" + fish.size);
                    }
                    else
                    {
                        MessageBox.Show("The size is not a valid entry.\nSize has to be between 1.0 - 10.0 .", "Invalid Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sizeTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The size is not a valid entry.\nSize has to be between 1.0 - 10.0 .", "Invalid Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sizeTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter fish, habitat, size, and food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fishTextBox.Focus();
            }

            Clear();
        }

        // Search Fish Button Handler
        private void searchFishButton_Click(object sender, EventArgs e)
        {
            // Validate search-fish
            if (searchFishTextBox.Text.Length > 0)
            {
                string searchFish = searchFishTextBox.Text;

                // Search for fish in list
                bool found = false;

                foreach (Fish fish in fishList)
                {
                    if (fish.name.Contains(searchFish.ToUpper()))
                    {
                        // Display data for found fish
                        searchListBox.Items.Add(fish.name + " lives in a " + fish.habitat + " and eats " + fish.food + ". It weighs " + fish.size + ".");
                        found = true;
                    }
                }

                if (!found)
                {
                    searchListBox.Items.Add(searchFish + " not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter fish to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                searchFishTextBox.Focus();
            }
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            if (fishList.Count == 0)
            {
                MessageBox.Show("Please enter a fish before getting the average.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fishTextBox.Focus();
            }
            else
            {
                int count = 0;
                double total = 0, average = 0;

                foreach (Fish fish in fishList)
                {
                    total += fish.size;
                    count++;
                }
                average = total / count;

                // Display
                averageSizeLabel.Text="The average size is: " + average.ToString("n2");
            }
        }

        public void Clear()
        {
            fishTextBox.Text = "";
            habitatTextBox.Text = "";
            foodTextBox.Text = "";
            sizeTextBox.Text = "";
            fishTextBox.Focus();
        }
    }
}
