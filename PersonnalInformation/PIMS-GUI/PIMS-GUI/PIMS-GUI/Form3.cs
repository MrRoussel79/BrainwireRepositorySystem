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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging off PIMS....");
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
            this.databaseTableAdapter.Fill(this.databaseDataSet.database); // TODO: This line of code loads data into the 'databaseDataSet.database' table. 

        }
    }
}
