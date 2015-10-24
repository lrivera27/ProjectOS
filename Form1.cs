using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



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
            //Placeholder until database is implemented
            if(textBox1.Text == "user" && textBox2.Text == "123")
            {
                mainMenu ss = new mainMenu(); 
                this.Hide(); 
                ss.Show(); 

            } else
            {
                MessageBox.Show("Error: Invalid Username and/or Password");
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registrationForm ss = new registrationForm();
            this.Hide();
            ss.Show();
            
        }
    }
}
