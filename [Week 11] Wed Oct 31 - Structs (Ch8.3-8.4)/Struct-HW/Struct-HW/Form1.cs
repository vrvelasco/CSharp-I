using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Struct_HW
{
    struct Account
    {
        public string name;   // Customer's name
        public double[] balance; // Array of balance
    }

    struct Results
    {
        public string name;
        public double average;
    }

    enum Customer { Customer0, Customer1, Customer2 }  // *** BONUS ***

    public partial class Form1 : Form
    {
        // Declare List of Accounts as a field at Class level
        private List<Account> accountList;
        private List<Results> resultList;

        // Declare variables at class level
        const int NAME_INDEX = 0;
        const int NUM_ACCOUNTS = 3;
        bool searchClicked = false;

        // string calcName;
        // double calcAverage;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ReadCSVFile(string fileName)
        {
            // Declare file and string variables
            StreamReader csvFile;
            string csvLine;
            char[] delim = { ',' };
            string[] tokens;

            // Catch file system errors
            try
            {
                // Open CSV file
                csvFile = File.OpenText(fileName);

                // Create Account List
                accountList = new List<Account>();

                // Read to end of file
                while (!csvFile.EndOfStream)
                {
                    // Read one line
                    csvLine = csvFile.ReadLine();

                    // Split line into tokens
                    tokens = csvLine.Split(delim);

                    // Create an Account and populate from CSV
                    Account account = new Account();
                    account.name = tokens[NAME_INDEX];
                    account.balance = new double[NUM_ACCOUNTS];

                    for (int a = 0; a < NUM_ACCOUNTS; a++)
                    {
                        account.balance[a] = double.Parse(tokens[1 + a]);
                    }

                    // Add Account to List
                    accountList.Add(account);
                }

                // Close CSV file
                csvFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CalculateAverages(List<Account> accountList, string fileName)
        {
             resultList = new List<Results>();
            Results result = new Results();
            

            // Calculate average balance for all customers
            foreach (Account account in accountList)
            {
                // Calculate average balance for one customer
                double total = 0;

                for (Customer c = Customer.Customer0; c <= Customer.Customer2; c++)
                {
                    total += account.balance[(int)c];
                }

                result.name = account.name;

                double average = total / NUM_ACCOUNTS;

                result.average = average;

                resultList.Add(result);

                if (searchClicked)
                {
                    // Add entry to ListBox
                    accountsListBox.Items.Add("Customer: \tAverage (in Dollars) :");
                    accountsListBox.Items.Add(account.name + "\t\t" + average.ToString("n2"));
                }

                searchClicked = false;

            }
        }

        private void SaveAverages(List<Results> resultList)
        {
            StreamWriter saveFile;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Show dialog and select save file name
            {
                saveFile = File.CreateText(saveFileDialog.FileName);
                //  resultList = new List<Results>();

                foreach (Results result in resultList)
                {
                    saveFile.WriteLine(result.name + "," + result.average);
                }

                saveFile.Close();
            }
            else // File not selected
            {
                MessageBox.Show("Please select a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ***************************************************************************************************

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Show dialog and file is selected
            {
                if (ReadCSVFile(openFileDialog.FileName)) // Successful?
                {
                    MessageBox.Show("File read and processed successfully!", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please select a file in the correct format.", "File With Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // File not selected
            {
                MessageBox.Show("Please select a file.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveAverages(resultList);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                if (saveButton.Enabled)
                {
                    // Declare variables
                    string searchName;

                    // Read search term from TextBox
                    searchName = searchTextBox.Text;

                    // Search for cusotmer in struct in list
                    // using LINQ extension method with lambda expression
                    var foundAccounts = accountList.Where(ddaStruct => ddaStruct.name.ToUpper().Contains(searchName.ToUpper()));

                    // Copy structs from var to List
                    List<Account> foundDDAList = new List<Account>();

                    foreach (Account foundDDAStruct in foundAccounts)
                    {
                        foundDDAList.Add(foundDDAStruct);
                    }

                    // Calculate average and display results
                    accountsListBox.Items.Add("============= Search Results =============");
                    searchClicked = true;
                    CalculateAverages(foundDDAList, "");
                }
                else
                {
                    MessageBox.Show("Please open a file first.", "File Not Opened", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Search Term Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}