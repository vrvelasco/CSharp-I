using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_HW
{
    public partial class ListForm : Form
    {
        List<string> shoppingList = new List<string>();

        public static string userString = "";

        public ListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addItemTextBox.Text.Length > 0)
            {
                shoppingList.Add(addItemTextBox.Text);
                Add myAdd = new Add();
                myAdd.ShowDialog();
                addItemTextBox.Clear();
                addItemTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter at least one character.");
            }
        }

        private void List_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About myAbout = new About();
            myAbout.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadList()
        {
            int result = FileInput.ReadFile(shoppingList);
            MessageBox.Show(FileInput.ReadFileMessage(result));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int result = FileOutput.SaveFile(shoppingList);
            MessageBox.Show(FileOutput.SaveFileMessage(result));
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            foreach (string item in shoppingList)
            {
                displayListBox.Items.Add(item);
            }
        }
    }
}
