namespace Chain___Gear.Admin
{
    partial class ManageEMP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2Female = new System.Windows.Forms.CheckBox();
            this.checkBox1Male = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nidTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.empIDTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpNamelabel1 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.checkBox2Female);
            this.panel1.Controls.Add(this.checkBox1Male);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnUploadPhoto);
            this.panel1.Controls.Add(this.pbxPhoto);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.salaryTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.reloadBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roleCB);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.nidTxt);
            this.panel1.Controls.Add(this.ageTxt);
            this.panel1.Controls.Add(this.empIDTxt);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmpNamelabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 277);
            this.panel2.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FullName,
            this.Age,
            this.NID_No,
            this.gender,
            this.SalaryRange,
            this.AdmitDate,
            this.Role,
            this.Photo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // NID_No
            // 
            this.NID_No.DataPropertyName = "NID_No";
            this.NID_No.HeaderText = "NID Number";
            this.NID_No.Name = "NID_No";
            this.NID_No.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // SalaryRange
            // 
            this.SalaryRange.DataPropertyName = "SalaryRange";
            this.SalaryRange.HeaderText = "Salary Range";
            this.SalaryRange.Name = "SalaryRange";
            this.SalaryRange.ReadOnly = true;
            // 
            // AdmitDate
            // 
            this.AdmitDate.DataPropertyName = "AdmitDate";
            this.AdmitDate.HeaderText = "Admin Date";
            this.AdmitDate.Name = "AdmitDate";
            this.AdmitDate.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "Photo";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Sex :";
            // 
            // checkBox2Female
            // 
            this.checkBox2Female.AutoSize = true;
            this.checkBox2Female.Location = new System.Drawing.Point(186, 189);
            this.checkBox2Female.Name = "checkBox2Female";
            this.checkBox2Female.Size = new System.Drawing.Size(60, 17);
            this.checkBox2Female.TabIndex = 48;
            this.checkBox2Female.Text = "Female";
            this.checkBox2Female.UseVisualStyleBackColor = true;
            // 
            // checkBox1Male
            // 
            this.checkBox1Male.AutoSize = true;
            this.checkBox1Male.Location = new System.Drawing.Point(131, 189);
            this.checkBox1Male.Name = "checkBox1Male";
            this.checkBox1Male.Size = new System.Drawing.Size(49, 17);
            this.checkBox1Male.TabIndex = 47;
            this.checkBox1Male.Text = "Male";
            this.checkBox1Male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "NID No :";
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Location = new System.Drawing.Point(1138, 140);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(70, 34);
            this.btnUploadPhoto.TabIndex = 45;
            this.btnUploadPhoto.Text = "Upload ";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(1113, 33);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(125, 101);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 44;
            this.pbxPhoto.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Admit Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Salary Range (TK) :";
            // 
            // salaryTxt
            // 
            this.salaryTxt.Location = new System.Drawing.Point(529, 33);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(247, 20);
            this.salaryTxt.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1003, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Search";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(1050, 190);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(247, 20);
            this.searchTxt.TabIndex = 38;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(793, 33);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(70, 34);
            this.reloadBtn.TabIndex = 37;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Role";
            // 
            // roleCB
            // 
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "manager",
            "employee",
            "engineer",
            "cleaner",
            "mechanic"});
            this.roleCB.Location = new System.Drawing.Point(529, 117);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(247, 21);
            this.roleCB.TabIndex = 35;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(869, 73);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(69, 61);
            this.deleteBtn.TabIndex = 34;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(793, 137);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(70, 34);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(793, 73);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(70, 61);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nidTxt
            // 
            this.nidTxt.Location = new System.Drawing.Point(131, 151);
            this.nidTxt.Name = "nidTxt";
            this.nidTxt.Size = new System.Drawing.Size(247, 20);
            this.nidTxt.TabIndex = 31;
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(131, 114);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(247, 20);
            this.ageTxt.TabIndex = 30;
            // 
            // empIDTxt
            // 
            this.empIDTxt.Location = new System.Drawing.Point(131, 74);
            this.empIDTxt.Name = "empIDTxt";
            this.empIDTxt.Size = new System.Drawing.Size(247, 20);
            this.empIDTxt.TabIndex = 29;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(131, 33);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(247, 20);
            this.NameTxt.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Employee ID :";
            // 
            // EmpNamelabel1
            // 
            this.EmpNamelabel1.AutoSize = true;
            this.EmpNamelabel1.Location = new System.Drawing.Point(62, 36);
            this.EmpNamelabel1.Name = "EmpNamelabel1";
            this.EmpNamelabel1.Size = new System.Drawing.Size(60, 13);
            this.EmpNamelabel1.TabIndex = 24;
            this.EmpNamelabel1.Text = "Full Name :";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(529, 154);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(247, 20);
            this.passwordTxt.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Password :";
            // 
            // ManageEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageEMP";
            this.Size = new System.Drawing.Size(1306, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox nidTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox empIDTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmpNamelabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2Female;
        private System.Windows.Forms.CheckBox checkBox1Male;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passwordTxt;
    }
}
