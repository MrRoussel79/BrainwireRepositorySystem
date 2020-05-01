using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS_GUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

            lstBoxTAC.Items.AddRange(File.ReadAllLines("D:\\PIMS-GUI\\PolicyDocument.txt"));


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }
    }
}
