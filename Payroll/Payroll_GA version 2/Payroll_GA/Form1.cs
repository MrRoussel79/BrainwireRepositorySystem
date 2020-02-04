using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_GA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin"&&txt_password.Text == "admin")
            {
                
                    if (chk_terms.Checked)
                    {
                        Form2 MainPage = new Form2();
                        MainPage.Show();
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: You have not agreed to Terms and Conditions");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Incorrect username or password");
                }
            
           
        }
    }
}
