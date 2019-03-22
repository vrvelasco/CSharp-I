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

namespace Catalog
{
    public partial class Form1 : Form
    {
        // Declare array of products
        private const int ARRAY_SIZE = 10;
        private Product[] prodArray;
        private int numProds;


        public Form1()
        {
            InitializeComponent();
        }

        private int ReadFile(string fn, Product[] pa, int maxSize)
        {
            char[] delim = { ',' };
            int count = 0;
            StreamReader catalogFile;

            // Catch system file errors
            try
            {
                // Open file
                catalogFile = File.OpenText(fn);

                // Read file
                while (!catalogFile.EndOfStream && count < maxSize)
                {
                    string line = catalogFile.ReadLine();
                    string[] tokens = line.Split(delim);

                    // Create Product object
                    Product prod = new Product(tokens[0], tokens[1], double.Parse(tokens[2]));

                    pa[count] = prod; // Insert object into array

                    count++; // Increment
                }

                catalogFile.Close();

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEBUG: " + ex.Message);
                return -1; // Error

            }
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            // Get file path/name from user
            string fileName = fileNameTextBox.Text;

            if (fileName.Length > 0)
            {
                // Create array
                prodArray = new Product[ARRAY_SIZE];

                // Read file
                numProds = ReadFile(fileName, prodArray, ARRAY_SIZE);

                // Handle errors
                if (numProds > 0)
                    statusLabel.Text = numProds.ToString() + " products read.";
                else if (numProds == 0)
                    statusLabel.Text = fileName + " is empty.";
                else if (numProds == -1)
                    statusLabel.Text = "Error reading " + fileName;
            }
            else
            {
                statusLabel.Text = "Please enter file name.";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Validate search category
            string searchCat = searchTextBox.Text;

            if (searchCat.Length > 0)
            {
                // Search active array elements
                int foundCount = 0;
                double totalPrice = 0.0;

                for (int index = 0; index < numProds; index++)
                {
                    if (prodArray[index].Category.Equals(searchCat))
                    {
                        foundCount++;
                        totalPrice += prodArray[index].GetPrice();
                    }
                }

                // Validate search results
                if (foundCount > 0)
                {
                    double avgPrice = totalPrice / foundCount;
                    averageLabel.Text = avgPrice.ToString("c");
                    statusLabel.Text = foundCount.ToString() + " products were found.";
                }
                else
                {
                    averageLabel.Text = string.Empty;
                    statusLabel.Text = "No products found.";
                }
            }
            else
            {
                statusLabel.Text = "Please enter category.";
            }
        }
    }
}
