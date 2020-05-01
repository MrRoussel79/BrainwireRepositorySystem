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
        const string PASSWORD = "1234";
        const string ADMIN_USERNAME = "ADMIN";
        const string USERNAME = "USER";
        /// <summary>
        /// ///////////////////////////////////////////////////////////      TXT FILE WITH ADMIN USER AND PASSWORD LINE BY LINE   ////////////////
        /// </summary>
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = txt_username.Text;
            string pass = txt_password.Text;
            //check if eligible to be logged in 
            if (user == ADMIN_USERNAME && pass == PASSWORD)
            {
                MessageBox.Show("Login Succesful!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            if (user == USERNAME && pass == PASSWORD)
            {
                MessageBox.Show("Login Succesful! Please accept T&Cs");
                Form5 form5 = new Form5();
                form5.Show();
              
                
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}

