using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_List
{
    public partial class Form1 : Form
    {
        // Create Bug List
        List<string> bugList = new List<string>() { "ant", "bee" };
        public Form1()
        {
            InitializeComponent();
        }

        // Add a bug to the list
        private void addButton_Click(object sender, EventArgs e)
        {
            bugList.Add(addTextBox.Text);

            // DEMO PRE-INITIALIZE
            List<string> workingBugs = new List<string>() { "ant", "bee" };
            string[] bugArray = new string[] { "ant", "bee" };
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();

            foreach (string bug in bugList)
            {
                displayListBox.Items.Add(bug);
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            int bugCount = bugList.Count;
            MessageBox.Show("There are " + bugCount.ToString() + " bugs.", "Item In List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = bugList.IndexOf(searchTextBox.Text);

            if (index != -1) // If Found
            {
                MessageBox.Show(bugList[index] + " was found at index " + index.ToString());
            }
            else // Not Found
            {
                MessageBox.Show(searchTextBox.Text + " was not found");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index;

            // Check for integer from the user
            if (int.TryParse(removeTextBox.Text, out index))
            {
                // Remove by index
                if (index < bugList.Count)
                {
                    bugList.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Please enter index in range.", "Not In Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Remove by value
                if (!bugList.Remove(removeTextBox.Text))
                {
                    MessageBox.Show(removeTextBox.Text + " was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            // Declare variable
            string bug; // bug to search for

            // Input bug
            bug = searchTextBox.Text;

            // Search for bug using LINQ extension method with lambda expression
            var foundBugs = bugList.Where(b => b.Equals(bug));

            // Display search results
            foreach (string fb in foundBugs)
            {
                MessageBox.Show(fb + " was found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            int index;

            // Validate index
            if(int.TryParse(removeTextBox.Text, out index))
            {
               if (index >= 0 && index <= bugList.Count)
                {
                    bugList.Insert(index, addTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Please enter index in range.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter integer index.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
