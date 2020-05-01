namespace PIMS_GUI
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsrName = new System.Windows.Forms.Label();
            this.lblPasswrd = new System.Windows.Forms.Label();
            this.txt_usernameCreate = new System.Windows.Forms.RichTextBox();
            this.txtPassCreate = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal Information Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login Creation";
            // 
            // lblUsrName
            // 
            this.lblUsrName.AutoSize = true;
            this.lblUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrName.Location = new System.Drawing.Point(69, 89);
            this.lblUsrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(108, 24);
            this.lblUsrName.TabIndex = 3;
            this.lblUsrName.Text = "Username -";
            // 
            // lblPasswrd
            // 
            this.lblPasswrd.AutoSize = true;
            this.lblPasswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswrd.Location = new System.Drawing.Point(71, 126);
            this.lblPasswrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswrd.Name = "lblPasswrd";
            this.lblPasswrd.Size = new System.Drawing.Size(103, 24);
            this.lblPasswrd.TabIndex = 4;
            this.lblPasswrd.Text = "Password -";
            // 
            // txt_usernameCreate
            // 
            this.txt_usernameCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernameCreate.Location = new System.Drawing.Point(200, 90);
            this.txt_usernameCreate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usernameCreate.Name = "txt_usernameCreate";
            this.txt_usernameCreate.Size = new System.Drawing.Size(190, 24);
            this.txt_usernameCreate.TabIndex = 5;
            this.txt_usernameCreate.Text = "";
            // 
            // txtPassCreate
            // 
            this.txtPassCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCreate.Location = new System.Drawing.Point(200, 126);
            this.txtPassCreate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassCreate.Name = "txtPassCreate";
            this.txtPassCreate.Size = new System.Drawing.Size(190, 24);
            this.txtPassCreate.TabIndex = 6;
            this.txtPassCreate.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreate.Location = new System.Drawing.Point(200, 167);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 33);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu.Location = new System.Drawing.Point(308, 167);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(88, 33);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Close";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(571, 248);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPassCreate);
            this.Controls.Add(this.txt_usernameCreate);
            this.Controls.Add(this.lblPasswrd);
            this.Controls.Add(this.lblUsrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.Label lblPasswrd;
        private System.Windows.Forms.RichTextBox txt_usernameCreate;
        private System.Windows.Forms.RichTextBox txtPassCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnMenu;
    }
}