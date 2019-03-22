using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonus_Average
{
    public partial class Form1 : Form
    {
        // Declare class-level constant field
        const double BONUS_POINT = 1.0;

        // Declare class-level field variables
        double testAverage, bonusPoints, bonusAverage;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare local constants
            const int NUM_SCORES = 3;

            // Declare local variables
            double test1, test2, test3;

            // Handle exceptions
            try
            {
                // Input test scores
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Calculate average
                testAverage = (test1 + test2 + test3) / NUM_SCORES;

                // Display average
                testAverageLabel.Text = testAverage.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            testAverageLabel.Text = "";
            bonusPointsLabel.Text = "";
            bonusAverageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subtractBonusPointButton_Click(object sender, EventArgs e)
        {
            // Decrease Bonus Points
            bonusPoints -= BONUS_POINT;

            // Calculate Bonus Average
            bonusAverage = testAverage + bonusPoints;

            // Display bonus points and bonus average
            bonusPointsLabel.Text = bonusPoints.ToString("n0");
            bonusAverageLabel.Text = bonusAverage.ToString("n1");
        }

        private void addBonusPointButton_Click(object sender, EventArgs e)
        {
            // Increase Bonus Points
            bonusPoints += BONUS_POINT;

            // Calculate Bonus Average
            bonusAverage = testAverage + bonusPoints;

            // Display bonus points and bonus average
            bonusPointsLabel.Text = bonusPoints.ToString("n0");
            bonusAverageLabel.Text = bonusAverage.ToString("n1");
        }
    }
}
