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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging off PIMS....");
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usertypelbl.Text = ("You are logged in as an Administrator !");
          
            this.databaseTableAdapter.Fill(this.databaseDataSet.database);  // TODO: This line of code loads data into the 'databaseDataSet.database' table.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
