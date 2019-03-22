using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trip_Planner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void planTripButton_Click(object sender, EventArgs e)
        {
            // Declare data for date
            string outputDate;

            // Declare variables for fuel
            double mpg;        // Miles per Gallon
            double miles;     // Miles to travel
            double price;    // Price per Gallon
            double gallons; // Total Fuel required
            double cost;   // Total Cost

            // Concatenate date data
            outputDate = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;

            // Input MPG, miles and price
            mpg = double.Parse(milesPerGallonTextBox.Text);
            miles = double.Parse(milesToTravelTextBox.Text);
            price = double.Parse(pricePerGallonTextBox.Text);

            // Calculate total fuel and cost
            gallons = miles / mpg;
            cost = gallons * price;

            // Display date
            dateOutputLabel.Text = outputDate;

            // Display gallons and cost
            totalFuelLabel.Text = gallons.ToString("n1");
            totalCostLabel.Text = cost.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear date text boxes
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // Clear fuel text boxes
            milesPerGallonTextBox.Text = "";
            milesToTravelTextBox.Text = "";
            pricePerGallonTextBox.Text = "";

            // Clear date label
            dateOutputLabel.Text = "";

            // Clear fuels labels
            totalFuelLabel.Text = "";
            totalCostLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes form.
        }
    }
}
