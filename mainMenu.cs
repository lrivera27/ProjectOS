using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squashids
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void hidsBtn_Click(object sender, EventArgs e)
        {
            hidsPanel.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            loginForm ss = new loginForm();
            this.Close();
            ss.Show();
        }


    }
}
