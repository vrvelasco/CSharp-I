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
    public partial class About : Form
    {
        public static bool finished = false;
        public static string className;
        public About()
        {
            InitializeComponent();
            IsFinished("CIS 252");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
           aboutLabel.Text="Created for " + className;
            finished = true;
            IsFinished("CIS 252");
        }

        public void IsFinished(string name)
        {
            className = name;

            if (finished)
            {
                closeButton.Enabled = true;
            }
        }
    }
}
