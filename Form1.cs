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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "user" && textBox2.Text == "123")
            {
                mainMenu ss = new mainMenu();
                this.Hide();
                ss.Show(); //Shows new form
            }
        }
    }
}
