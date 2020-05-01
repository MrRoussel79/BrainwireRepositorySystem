namespace PIMS_GUI
{
    partial class Form5
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lstBoxTAC = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.Location = new System.Drawing.Point(7, 683);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(260, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "I have read and accept the Terms and Conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lstBoxTAC
            // 
            this.lstBoxTAC.FormattingEnabled = true;
            this.lstBoxTAC.Location = new System.Drawing.Point(7, 3);
            this.lstBoxTAC.Name = "lstBoxTAC";
            this.lstBoxTAC.Size = new System.Drawing.Size(999, 667);
            this.lstBoxTAC.TabIndex = 11;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkGray;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(411, 675);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(88, 33);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.DarkGray;
            this.btnDecline.Location = new System.Drawing.Point(503, 675);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(88, 33);
            this.btnDecline.TabIndex = 13;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1010, 713);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lstBoxTAC);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstBoxTAC;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
    }
}