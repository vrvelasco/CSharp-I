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

namespace Class_HW
{
    public partial class Form1 : Form
    {
        // Declare and create list of Banks
        private List<Bank> bankList = new List<Bank>();

        // List of Customers
        private List<Customer> customerList = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void newBankButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (bankNameTextBox.Text.Length > 0 && locationTextBox.Text.Length > 0)
            {
                Bank bank = new Bank(bankNameTextBox.Text);
                bank.Location = locationTextBox.Text;

                bankList.Add(bank);

                // Clear
                bankNameTextBox.Clear();
                locationTextBox.Clear();
                bankNameTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter at least one character for each field.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Clear
                bankNameTextBox.Clear();
                locationTextBox.Clear();
                bankNameTextBox.Focus();
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            int account;

            if (int.TryParse(depositTextBox.Text, out account) && customerNameTextBox.Text.Length > 0)
            {
                Customer customer = new Customer(account, customerNameTextBox.Text);

                customerList.Add(customer);

                depositTextBox.Clear();
                customerNameTextBox.Clear();
                customerNameTextBox.Focus();            }
            else
            {
                MessageBox.Show("Please enter a valid account and name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                depositTextBox.Clear();
                customerNameTextBox.Clear();
                customerNameTextBox.Focus();
            }
        }

        private void customerBankButton_Click(object sender, EventArgs e)
        {
            int accountNo;
            if (int.TryParse(custAccountTextBox.Text, out accountNo) && locTextBox.Text.Length > 0)
            {
                foreach (Bank b in bankList)
                {
                    if (b.Location == locTextBox.Text)
                    {
                        b.AddCustomer(accountNo);
                    }
                    custAccountTextBox.Clear();
                    locTextBox.Clear();
                    custAccountTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please check entries and try again.");
                custAccountTextBox.Clear();
                locTextBox.Clear();
                custAccountTextBox.Focus();

            }
        }

        private void displayBankButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();

            displayListBox.Items.Add("Bank:");
            foreach (Bank bank in bankList)
            {
                displayListBox.Items.Add(bank.Name);
                displayListBox.Items.Add("\tLocation: " + bank.Location);

                foreach (int account in bank.Customers)
                {
                    displayListBox.Items.Add("\tAccount: " + account.ToString());
                }
            }
        }

        private void displayCustomerButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();

            displayListBox.Items.Add("Customer:");
            foreach (Customer customer in customerList)
            {
                displayListBox.Items.Add(customer.Name + "\t" + customer.Account);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter resultFile;

                resultFile = File.CreateText("Results.txt");

                foreach (Bank bank in bankList)
                {
                    resultFile.WriteLine(bank.Name + ":\t");

                    foreach (int account in bank.Customers)
                    {
                        resultFile.WriteLine("\tAccount: " + account.ToString());
                    }
                }

                resultFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
