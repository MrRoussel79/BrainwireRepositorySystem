namespace PIMS_GUI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.usertypelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new PIMS_GUI.DatabaseDataSet();
            this.databaseTableAdapter = new PIMS_GUI.DatabaseDataSetTableAdapters.databaseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogoff);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(4, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogoff.Location = new System.Drawing.Point(938, 5);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(88, 33);
            this.btnLogoff.TabIndex = 9;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 30);
            this.listBox1.TabIndex = 0;
            // 
            // usertypelbl
            // 
            this.usertypelbl.AutoSize = true;
            this.usertypelbl.Location = new System.Drawing.Point(12, 9);
            this.usertypelbl.Name = "usertypelbl";
            this.usertypelbl.Size = new System.Drawing.Size(188, 13);
            this.usertypelbl.TabIndex = 10;
            this.usertypelbl.Text = "You are logged in as an Administrator !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personal Information Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brainvire Ltd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Version 2.11";
            // 
            // adminView
            // 
            this.adminView.AutoGenerateColumns = false;
            this.adminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.houseNoDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countyDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.adminView.DataSource = this.databaseBindingSource;
            this.adminView.Location = new System.Drawing.Point(5, 163);
            this.adminView.Name = "adminView";
            this.adminView.Size = new System.Drawing.Size(1042, 394);
            this.adminView.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            // 
            // houseNoDataGridViewTextBoxColumn
            // 
            this.houseNoDataGridViewTextBoxColumn.DataPropertyName = "House No";
            this.houseNoDataGridViewTextBoxColumn.HeaderText = "House No";
            this.houseNoDataGridViewTextBoxColumn.Name = "houseNoDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countyDataGridViewTextBoxColumn
            // 
            this.countyDataGridViewTextBoxColumn.DataPropertyName = "county";
            this.countyDataGridViewTextBoxColumn.HeaderText = "county";
            this.countyDataGridViewTextBoxColumn.Name = "countyDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataMember = "database";
            this.databaseBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseTableAdapter
            // 
            this.databaseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1052, 560);
            this.ControlBox = false;
            this.Controls.Add(this.usertypelbl);
            this.Controls.Add(this.adminView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "PIMS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.DataGridView adminView;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private DatabaseDataSetTableAdapters.databaseTableAdapter databaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label usertypelbl;
        private System.Windows.Forms.Button button1;
    }
}