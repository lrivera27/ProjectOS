using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
=======

>>>>>>> 045bbfb593ef64f1d2164bbb8f709c9adcd44e1b
namespace Squashids
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            this.Text = "Registration Page";
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            loginForm ss = new loginForm();
            this.Close();
            ss.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Program.user.firstName = firstNameBox.Text;
            //Program.user.lastName = lastNameBox.Text;
            //Program.user.username = usernameBox.Text;
            //Program.user.password = passwordBox.Text;
            
>>>>>>> 045bbfb593ef64f1d2164bbb8f709c9adcd44e1b

        }
    }
}
