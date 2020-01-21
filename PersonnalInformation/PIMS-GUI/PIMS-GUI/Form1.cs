using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS_GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        LoginGUI login = new LoginGUI("admin", "1234");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = txt_username.Text;
            string pass = txt_password.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("Login Succesful!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }
    }
}
