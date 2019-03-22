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

namespace Final_RevHW
{
    public partial class Form1 : Form
    {
        private const int ARRAY_SIZE = 10;
        private const int MAKE = 0;
        private const int MODEL = 1;
        private const int PRICE = 2;
        private int arrayCount = 0;
        private double average = 0;
        private double sum = 0;
        private string result = "";

        // Array and List
        private Car[] carArray;
        private List<Car> carList;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            carArray = new Car[ARRAY_SIZE];

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                arrayCount = ReadFile(openFileDialog.FileName, carArray, ARRAY_SIZE);
                sum = 0;
                average = 0;
            }
            else
            {
                MessageBox.Show("Please select a valid file to begin.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadComplete();
            averageLabel.Text = DisplayInfo();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (arrayCount != 0)
            {
                // Check user selection
                if (makeRadioButton.Checked)
                {
                    if (searchTextBox.Text.Length > 0)
                    {
                        string search = searchTextBox.Text.ToUpper();
                        bool found = false;
                        result = "";

                        displayListBox.Items.Clear();

                        for (int i = 0; i < arrayCount; i++)
                        {
                            if (carArray[i].Make.ToString().ToUpper() == search)
                            {
                                displayListBox.Items.Add("Make: " + carArray[i].Make + "\tModel: " + carArray[i].Model);
                                 result += carArray[i].Make.ToString() + "\n";
                                found = true;
                            }
                        }

                        /* if (!found)
                         {
                             MessageBox.Show(search + " was not found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {
                             MessageBox.Show(search + " was found!", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }*/
                    }
                }


                if (modelRadioButton.Checked)
                {
                    if (searchTextBox.Text.Length > 0)
                    {
                        string search = searchTextBox.Text.ToUpper();
                        bool found = false;

                        displayListBox.Items.Clear();

                        for (int i = 0; i < arrayCount; i++)
                        {
                            if (carArray[i].Model.ToString().ToUpper() == (search))
                            {
                                displayListBox.Items.Add("Make: " + carArray[i].Make + "\tModel: " + carArray[i].Model);
                                found = true;
                            }
                        }

                        /*  if (!found)
                          {
                              MessageBox.Show(search + " was not found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                          else
                          {
                              MessageBox.Show(search + " was found!", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }*/
                    }
                    else
                    {
                        MessageBox.Show("Please enter vehicle's model to look for.", "Model Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please enter vehicle's make to look for.", "Make Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            double userPrice;

            if (arrayCount < ARRAY_SIZE)
            {
                if (makeTextBox.Text.Length > 0 && modelTextBox.Text.Length > 0 && priceTextBox.Text.Length > 0)
                {
                    if (double.TryParse(priceTextBox.Text, out userPrice))
                    {
                        // Create Car object
                        Car car = new Car(makeTextBox.Text, modelTextBox.Text, userPrice);
                        carArray[arrayCount] = car; // Insert object into array
                        arrayCount++;
                        averageLabel.Text = DisplayInfo();
                    }
                    else
                    {
                        MessageBox.Show("The price entered is invalid. Please try again.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("All fields must contain at least one character.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Ten vehicles is the maximum.", "Maximum Vehicles Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void arrayListButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void searchLINQButton_Click(object sender, EventArgs e)
        {
            LINQSearch();
        }

        /*
         *  METHODS
         */
        public void LoadComplete()
        {
            // Hide intro stuff
            titleGroupBox.Visible = false;
            introGroupBox.Visible = false;

            // Enable Options
            bonusGroupBox.Enabled = true;
            searchGroupBox.Enabled = true;
            vehicleGroupBox.Enabled = true;
        }

        public string DisplayInfo()
        {
            // Clear
            sum = 0;
            average = 0;

            // Clear ListBox
            displayListBox.Items.Clear();

            // Update form
            vehicleCountLabel.Text = "Vehicle(s): " + arrayCount.ToString() + " / 10";

            // Formatting
            displayListBox.Items.Add("MAKE:\t\tMODEL:\t\tPRICE:");
            displayListBox.Items.Add("============================================");

            if (arrayCount != 0) // Not empty
            {
                for (int i = 0; i < arrayCount; i++) // Loop through array
                {
                    displayListBox.Items.Add(carArray[i].Make + "\t\t" + carArray[i].Model + "\t\t" + carArray[i].GetPrice().ToString("c"));
                    sum += carArray[i].GetPrice();
                }

                average = sum / arrayCount;

                return "[ Avg: " + average.ToString("c") + " ]";
            }
            else
                return "[ Average: $0.00 ]";
        }

        private int ReadFile(string fileName, Car[] carArray, int arraySize)
        {
            char[] delim = { ',' };
            int count = 0;
            StreamReader vehicleFile;

            // Catch system file errors
            try
            {
                // Open file
                vehicleFile = File.OpenText(fileName);

                // Read file
                while (!vehicleFile.EndOfStream && count < arraySize)
                {
                    string line = vehicleFile.ReadLine();
                    string[] tokens = line.Split(delim);

                    // Create Car object
                    Car car = new Car(tokens[MAKE], tokens[MODEL], double.Parse(tokens[PRICE]));

                    carArray[count] = car; // Insert object into array

                    count++; // Increment
                }

                vehicleFile.Close();

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEBUG: " + ex.Message);
                return -1; // Error

            }
        }

        public void LINQSearch()
        {
            // Array to List
            carList = new List<Car>();

            // Add array objects to list
            for (int i = 0; i < arrayCount; i++)
            {
                carList.Add(carArray[i]);
            }

            // LINQ search
            if (searchLINQTextBox.Text.Length > 0)
            {
                string searchLINQ = searchLINQTextBox.Text.ToUpper();
                bool found = false;

                var foundMake = carList.Where(car => car.Make.ToUpper().Contains(searchLINQ));

                displayListBox.Items.Clear();

                foreach (Car make in foundMake)
                {
                    if (make.Make.ToUpper().Contains(searchLINQ))
                    {
                        displayListBox.Items.Add("Make: " + make.Make + "\tModel: " + make.Model);
                    }
                }

                /*  if (!found)
                  {
                      MessageBox.Show(searchLINQ + " was not found.", "LINQ Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  else
                  {
                      MessageBox.Show(searchLINQ + " was found!", "LINQ Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }*/
            }
            else
            {
                MessageBox.Show("Please enter vehicle's make to look for.", "Make Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           // if (saveFileDialog.ShowDialog() == DialogResult.OK)
           // {
                StreamWriter saveFile;

                saveFile = File.CreateText("Result.txt");
                saveFile.WriteLine("Result: " + result);
                saveFile.Close();
          //  }
        }
    }
}