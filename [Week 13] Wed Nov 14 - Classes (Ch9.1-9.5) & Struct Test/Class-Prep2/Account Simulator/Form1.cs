using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        // BankAccount field with a $1000 starting balance
        private BankAccount account = new BankAccount(1000);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the starting balance.
            balanceLabel.Text = account.Balance.ToString("c");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount; // To hold the amount of the deposit

            // Convert the amount to a decimal.
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                // Deposit the amount into the account.
                account.Deposit(amount);

                // Display the new balance.
                balanceLabel.Text = account.Balance.ToString("c");

                // Clear the text box.
                depositTextBox.Clear();
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount; // To hold the amount of the withdrawal

            // Convert the amount to a decimal.
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                // Withdraw the amount from the account.
                account.Withdraw(amount);

                // Display the new balance.
                balanceLabel.Text = account.Balance.ToString("c");

                // Clear the text box.
                withdrawTextBox.Clear();
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}