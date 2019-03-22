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
    public partial class Add : Form
    {
        public static bool finished = false;
        public Add()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {
           addedTextBox.Text= "Your item was added!";
            finished = true;
            IsFinished();
        }

        public void IsFinished()
        {
            if (finished)
            {
                addButton.Enabled = true;
            }
        }
    }
}
