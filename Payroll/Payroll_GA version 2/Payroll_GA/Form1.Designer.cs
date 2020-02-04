namespace Payroll_GA
{
    partial class Form1
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.chk_terms = new System.Windows.Forms.CheckBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(238, 125);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(266, 20);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(237, 169);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(266, 20);
            this.txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(333, 262);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chk_terms
            // 
            this.chk_terms.AutoSize = true;
            this.chk_terms.Location = new System.Drawing.Point(286, 221);
            this.chk_terms.Name = "chk_terms";
            this.chk_terms.Size = new System.Drawing.Size(71, 17);
            this.chk_terms.TabIndex = 3;
            this.chk_terms.Text = "I agree to";
            this.chk_terms.UseVisualStyleBackColor = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(173, 127);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(175, 172);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(350, 222);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms and Conditions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 445);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.chk_terms);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chk_terms;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

