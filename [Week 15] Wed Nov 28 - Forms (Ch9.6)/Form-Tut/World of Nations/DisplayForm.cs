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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        // Method to display world info
        public void DisplayWorld()
        {
            // Declare list of strings
            List<string> worldInfo;

            // Get list of nation paragraphs from world object
            worldInfo = World.theWorld.GetInfo();

            // Display paragraphs in ListBox
            foreach (string natInfo in worldInfo)
            {
                nationsListBox.Items.Add(natInfo);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            // Display world information
            DisplayWorld();
        }
    }
}
