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

namespace Card_Search
{
    public partial class Form1 : Form
    {
        const int ACE = 1;
        const int KING = 13;
        const int SIZE = 5;
        int[] handArray;
        int[] foundArray;
        int foundCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            handArray = new int[SIZE]; // Creates array
            handListBox.Items.Clear();

            // Generate 5 random cards from 1 to 13
            Random rand = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                handArray[i] = rand.Next(KING) + ACE;
                handListBox.Items.Add(handArray[i].ToString());
            }

        }

        // Method to search hand
        private int SearchHand(int card, // Card to search for
                               int[] hand, // Array of cards to search in
                               int[] found) //Array of cards found
        {
            // Loop through each card in hand
            int count = 0;

            for (int i = 0; i < hand.Length; i++)
            {
                // Does this card match the search card
                if (hand[i] == card)
                {
                    // Assign found card to next element in found array
                    found[count] = hand[i];
                    count++;
                }
            }

            return count;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            foundArray = new int[SIZE]; // Create array
            foundListBox.Items.Clear();

            // Input and validate card
            int card = 0;
            if (int.TryParse(searchTextBox.Text, out card))
            {
                if (card >= ACE && card <= KING)
                {
                    // Call method to perform search
                    foundCount = SearchHand(card, handArray, foundArray);

                    // Display found cards
                    if (foundCount > 0)
                    {
                        for (int i = 0; i < foundCount; i++)
                        {
                            foundListBox.Items.Add(foundArray[i]);
                        }
                    }
                    else
                    {
                        foundListBox.Items.Add("None");
                    }
                }
                else
                {
                    MessageBox.Show("Search card should be 1 to 13.", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Search card must be whole number.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveArray(string fileName, int[] cards, int count)
        {
            try
            {
                StreamWriter cardFile = File.CreateText(fileName);

                for (int i = 0; i < count; i++)
                {
                    cardFile.WriteLine(cards[i].ToString());
                }

                cardFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (foundCount > 0)
            {
                if (SaveArray("found.txt", foundArray, foundCount))
                {
                    MessageBox.Show("Found cards saved.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error saving found cards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No found cards to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
