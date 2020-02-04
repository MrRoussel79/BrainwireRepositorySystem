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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_payroll_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3() ;
            form3.Show();
            this.Hide();
        }

        private void btn_benefits_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
        }

        public void menubarHome()
        {

        }
    }

    //1250 = 0%
    //CBR = 20%
    //CD0 = 40%

    /*Nat Ins
     * 118-166 weekly 0%
     * 166.01-962 weekly 12%
     * 962+weekly (remainind) 2%*/

    
}
