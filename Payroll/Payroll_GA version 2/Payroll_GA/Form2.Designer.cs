namespace Payroll_GA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_wage = new System.Windows.Forms.Label();
            this.txt_wage = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.rdo_tax1 = new System.Windows.Forms.RadioButton();
            this.rdo_tax2 = new System.Windows.Forms.RadioButton();
            this.rdo_tax3 = new System.Windows.Forms.RadioButton();
            this.grp_tax = new System.Windows.Forms.GroupBox();
            this.rdo_taxother = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_payroll = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_benefits = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.grp_tax.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_wage
            // 
            this.lbl_wage.AutoSize = true;
            this.lbl_wage.Location = new System.Drawing.Point(124, 163);
            this.lbl_wage.Name = "lbl_wage";
            this.lbl_wage.Size = new System.Drawing.Size(69, 13);
            this.lbl_wage.TabIndex = 0;
            this.lbl_wage.Text = "Hourly Wage";
            // 
            // txt_wage
            // 
            this.txt_wage.Location = new System.Drawing.Point(106, 179);
            this.txt_wage.Name = "txt_wage";
            this.txt_wage.Size = new System.Drawing.Size(100, 20);
            this.txt_wage.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.Location = new System.Drawing.Point(243, 163);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(82, 13);
            this.lbl_hours.TabIndex = 2;
            this.lbl_hours.Text = "Hours per week";
            // 
            // rdo_tax1
            // 
            this.rdo_tax1.AutoSize = true;
            this.rdo_tax1.Location = new System.Drawing.Point(6, 21);
            this.rdo_tax1.Name = "rdo_tax1";
            this.rdo_tax1.Size = new System.Drawing.Size(55, 17);
            this.rdo_tax1.TabIndex = 4;
            this.rdo_tax1.TabStop = true;
            this.rdo_tax1.Text = "1250L";
            this.rdo_tax1.UseVisualStyleBackColor = true;
            // 
            // rdo_tax2
            // 
            this.rdo_tax2.AutoSize = true;
            this.rdo_tax2.Location = new System.Drawing.Point(6, 44);
            this.rdo_tax2.Name = "rdo_tax2";
            this.rdo_tax2.Size = new System.Drawing.Size(47, 17);
            this.rdo_tax2.TabIndex = 5;
            this.rdo_tax2.TabStop = true;
            this.rdo_tax2.Text = "CBR";
            this.rdo_tax2.UseVisualStyleBackColor = true;
            // 
            // rdo_tax3
            // 
            this.rdo_tax3.AutoSize = true;
            this.rdo_tax3.Location = new System.Drawing.Point(6, 67);
            this.rdo_tax3.Name = "rdo_tax3";
            this.rdo_tax3.Size = new System.Drawing.Size(46, 17);
            this.rdo_tax3.TabIndex = 6;
            this.rdo_tax3.TabStop = true;
            this.rdo_tax3.Text = "CD0";
            this.rdo_tax3.UseVisualStyleBackColor = true;
            // 
            // grp_tax
            // 
            this.grp_tax.Controls.Add(this.textBox1);
            this.grp_tax.Controls.Add(this.rdo_taxother);
            this.grp_tax.Controls.Add(this.rdo_tax1);
            this.grp_tax.Controls.Add(this.rdo_tax3);
            this.grp_tax.Controls.Add(this.rdo_tax2);
            this.grp_tax.Location = new System.Drawing.Point(106, 223);
            this.grp_tax.Name = "grp_tax";
            this.grp_tax.Size = new System.Drawing.Size(229, 121);
            this.grp_tax.TabIndex = 7;
            this.grp_tax.TabStop = false;
            this.grp_tax.Text = "Tax Codes";
            // 
            // rdo_taxother
            // 
            this.rdo_taxother.AutoSize = true;
            this.rdo_taxother.Location = new System.Drawing.Point(6, 90);
            this.rdo_taxother.Name = "rdo_taxother";
            this.rdo_taxother.Size = new System.Drawing.Size(51, 17);
            this.rdo_taxother.TabIndex = 7;
            this.rdo_taxother.TabStop = true;
            this.rdo_taxother.Text = "Other";
            this.rdo_taxother.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btn_payroll
            // 
            this.btn_payroll.Location = new System.Drawing.Point(200, 0);
            this.btn_payroll.Name = "btn_payroll";
            this.btn_payroll.Size = new System.Drawing.Size(200, 81);
            this.btn_payroll.TabIndex = 8;
            this.btn_payroll.Text = "Your Payroll";
            this.btn_payroll.UseVisualStyleBackColor = true;
            this.btn_payroll.Click += new System.EventHandler(this.btn_payroll_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(600, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 81);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_benefits
            // 
            this.btn_benefits.Location = new System.Drawing.Point(400, 0);
            this.btn_benefits.Name = "btn_benefits";
            this.btn_benefits.Size = new System.Drawing.Size(200, 81);
            this.btn_benefits.TabIndex = 10;
            this.btn_benefits.Text = "Your Benefits";
            this.btn_benefits.UseVisualStyleBackColor = true;
            this.btn_benefits.Click += new System.EventHandler(this.btn_benefits_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(-1, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 81);
            this.btn_home.TabIndex = 11;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(106, 351);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 12;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_benefits);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_payroll);
            this.Controls.Add(this.grp_tax);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_hours);
            this.Controls.Add(this.txt_wage);
            this.Controls.Add(this.lbl_wage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grp_tax.ResumeLayout(false);
            this.grp_tax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_wage;
        private System.Windows.Forms.TextBox txt_wage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.RadioButton rdo_tax1;
        private System.Windows.Forms.RadioButton rdo_tax2;
        private System.Windows.Forms.RadioButton rdo_tax3;
        private System.Windows.Forms.GroupBox grp_tax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdo_taxother;
        private System.Windows.Forms.Button btn_payroll;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_benefits;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_calculate;
    }
}