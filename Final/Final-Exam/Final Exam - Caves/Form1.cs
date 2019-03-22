using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam___Caves
{
    public partial class Form1 : Form
    {
        private const int ARRAY_SIZE = 10;
        private Cave[] caveArray;
        private List<Cave> caveList;
        private int arrayCount;

        public Form1()
        {
            InitializeComponent();
        }

        public int ReadFile(int maxSize)
        {
            // Create array
            caveArray = new Cave[ARRAY_SIZE];

            char[] delim = { ',' };
            int count = 0;
            StreamReader caveFile;

            // Catch system file errors
            try
            {
                // Open file
                caveFile = File.OpenText("Caves.csv");

                // Read file
                while (!caveFile.EndOfStream && count < maxSize)
                {
                    string line = caveFile.ReadLine();
                    string[] tokens = line.Split(delim);

                    // Create Cave object
                    Cave cave = new Cave(tokens[0], tokens[1], double.Parse(tokens[2]));

                    caveArray[count] = cave; // Insert object into array

                    count++; // Increment
                }

                caveFile.Close();

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1; // Error
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox
            displayListBox.Items.Clear();

            // Read file
            arrayCount = ReadFile(ARRAY_SIZE);

            // Display ListBox entries
            DisplayFileInfo();

            // Display average
            averageLabel.Text = "Average Length: " + AverageLength().ToString() + "ft";

            // Enable search
            searchGroupBox.Enabled = true;
            searchLINQGroupBox.Enabled = true;
        }

        public double AverageLength()
        {
            double sum = 0;

            for (int i = 0; i < arrayCount; i++)
            {
                sum += caveArray[i].GetLength();
            }

            return sum / arrayCount;
        }

        public void DisplayFileInfo()
        {
            displayListBox.Items.Add("Cave Name:\t\tLocation:\t\tLength:");

            for (int i = 0; i < arrayCount; i++)
            {
                displayListBox.Items.Add(caveArray[i].Name + "\t\t" + caveArray[i].Location + "\t\t" + caveArray[i].GetLength());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Validate search category
            string search = searchTextBox.Text.ToUpper();

            if (search.Length > 0)
            {
                displayListBox.Items.Clear();

                for (int i = 0; i < arrayCount; i++)
                {
                    if (caveArray[i].Name.ToUpper().Contains(search))
                    {
                        displayListBox.Items.Add("Cave Name: " + caveArray[i].Name + "\t\tLocation: " + caveArray[i].Location + "\t\tLength: " + caveArray[i].GetLength());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            LINQSearch();
        }

        public void LINQSearch()
        {
            caveList = new List<Cave>();

            // Add array objects to list
            for (int i = 0; i < arrayCount; i++)
            {
                caveList.Add(caveArray[i]);
            }

            // LINQ search
            if (searchLINQTextBox.Text.Length > 0)
            {
                string searchLINQ = searchLINQTextBox.Text.ToUpper();

                var foundCave = caveList.Where(cave => cave.Name.ToUpper().Contains(searchLINQ));

                displayListBox.Items.Clear();

                foreach (Cave cave in foundCave)
                {
                    if (cave.Name.ToUpper().Contains(searchLINQ))
                    {
                        displayListBox.Items.Add("Cave Name: " + cave.Name + "\t\tLocation: " + cave.Location + "\t\tLength: " + cave.GetLength());
                    }
                }
            }
            else
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             MessageBox.Show("Thanks for another great semester!", "Thanks!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
