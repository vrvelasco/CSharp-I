using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_of_Nations
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // Create the Enter form
            EnterForm enterForm = new World_of_Nations.EnterForm();

            // Show Enter form as modal dialog
            // It must return before program can continue
            enterForm.ShowDialog();  // Modal
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Create the Display form
            DisplayForm displayForm = new DisplayForm();

            // Show Display form as modeless dialog
            // It will remain open while program continues
            displayForm.Show(); // Modeless
        }
    }
}
