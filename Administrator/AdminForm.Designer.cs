namespace Administrator
{
    partial class AdminForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Cars = new System.Windows.Forms.TabPage();
            this.imageBtn = new System.Windows.Forms.Button();
            this.deleteCarBtn = new System.Windows.Forms.Button();
            this.viewCarBtn = new System.Windows.Forms.Button();
            this.updateCarBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.engineTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.manufacturerTxt = new System.Windows.Forms.TextBox();
            this.caridTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Employees = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.useridTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cars
            // 
            this.Cars.Controls.Add(this.imageBtn);
            this.Cars.Controls.Add(this.deleteCarBtn);
            this.Cars.Controls.Add(this.viewCarBtn);
            this.Cars.Controls.Add(this.updateCarBtn);
            this.Cars.Controls.Add(this.addCarBtn);
            this.Cars.Controls.Add(this.pictureBox1);
            this.Cars.Controls.Add(this.dataGridView2);
            this.Cars.Controls.Add(this.comboBox2);
            this.Cars.Controls.Add(this.engineTxt);
            this.Cars.Controls.Add(this.locationTxt);
            this.Cars.Controls.Add(this.modelTxt);
            this.Cars.Controls.Add(this.manufacturerTxt);
            this.Cars.Controls.Add(this.caridTxt);
            this.Cars.Controls.Add(this.dateTimePicker1);
            this.Cars.Controls.Add(this.label13);
            this.Cars.Controls.Add(this.label12);
            this.Cars.Controls.Add(this.label11);
            this.Cars.Controls.Add(this.label9);
            this.Cars.Controls.Add(this.label8);
            this.Cars.Controls.Add(this.label7);
            this.Cars.Controls.Add(this.label6);
            this.Cars.Location = new System.Drawing.Point(4, 25);
            this.Cars.Name = "Cars";
            this.Cars.Padding = new System.Windows.Forms.Padding(3);
            this.Cars.Size = new System.Drawing.Size(827, 371);
            this.Cars.TabIndex = 1;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = true;
            // 
            // imageBtn
            // 
            this.imageBtn.Location = new System.Drawing.Point(588, 85);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(75, 23);
            this.imageBtn.TabIndex = 23;
            this.imageBtn.Text = "View Car";
            this.imageBtn.UseVisualStyleBackColor = true;
            this.imageBtn.Click += new System.EventHandler(this.imageBtn_Click);
            // 
            // deleteCarBtn
            // 
            this.deleteCarBtn.Location = new System.Drawing.Point(346, 301);
            this.deleteCarBtn.Name = "deleteCarBtn";
            this.deleteCarBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCarBtn.TabIndex = 22;
            this.deleteCarBtn.Text = "Delete";
            this.deleteCarBtn.UseVisualStyleBackColor = true;
            this.deleteCarBtn.Click += new System.EventHandler(this.deleteCarBtn_Click);
            // 
            // viewCarBtn
            // 
            this.viewCarBtn.Location = new System.Drawing.Point(232, 302);
            this.viewCarBtn.Name = "viewCarBtn";
            this.viewCarBtn.Size = new System.Drawing.Size(75, 23);
            this.viewCarBtn.TabIndex = 21;
            this.viewCarBtn.Text = "View";
            this.viewCarBtn.UseVisualStyleBackColor = true;
            this.viewCarBtn.Click += new System.EventHandler(this.viewCarBtn_Click);
            // 
            // updateCarBtn
            // 
            this.updateCarBtn.Location = new System.Drawing.Point(130, 302);
            this.updateCarBtn.Name = "updateCarBtn";
            this.updateCarBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCarBtn.TabIndex = 20;
            this.updateCarBtn.Text = "Update";
            this.updateCarBtn.UseVisualStyleBackColor = true;
            this.updateCarBtn.Click += new System.EventHandler(this.updateCarBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(29, 303);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 19;
            this.addCarBtn.Text = "Add";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(551, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column10,
            this.Column11,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13});
            this.dataGridView2.Location = new System.Drawing.Point(18, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(527, 170);
            this.dataGridView2.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Gasoline",
            "Diesel",
            "Electric",
            "GPL"});
            this.comboBox2.Location = new System.Drawing.Point(203, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // engineTxt
            // 
            this.engineTxt.Location = new System.Drawing.Point(97, 82);
            this.engineTxt.Name = "engineTxt";
            this.engineTxt.Size = new System.Drawing.Size(100, 20);
            this.engineTxt.TabIndex = 13;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(324, 34);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(100, 20);
            this.locationTxt.TabIndex = 11;
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(218, 34);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(100, 20);
            this.modelTxt.TabIndex = 10;
            // 
            // manufacturerTxt
            // 
            this.manufacturerTxt.Location = new System.Drawing.Point(112, 34);
            this.manufacturerTxt.Name = "manufacturerTxt";
            this.manufacturerTxt.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTxt.TabIndex = 9;
            // 
            // caridTxt
            // 
            this.caridTxt.Location = new System.Drawing.Point(6, 34);
            this.caridTxt.Name = "caridTxt";
            this.caridTxt.Size = new System.Drawing.Size(100, 20);
            this.caridTxt.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(243, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Fuel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Engine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Build Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Car ID";
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.deleteBtn);
            this.Employees.Controls.Add(this.viewBtn);
            this.Employees.Controls.Add(this.updateBtn);
            this.Employees.Controls.Add(this.addBtn);
            this.Employees.Controls.Add(this.dataGridView1);
            this.Employees.Controls.Add(this.fullnameTxt);
            this.Employees.Controls.Add(this.useridTxt);
            this.Employees.Controls.Add(this.passwordTxt);
            this.Employees.Controls.Add(this.usernameTxt);
            this.Employees.Controls.Add(this.comboBox1);
            this.Employees.Controls.Add(this.label5);
            this.Employees.Controls.Add(this.label4);
            this.Employees.Controls.Add(this.label3);
            this.Employees.Controls.Add(this.label2);
            this.Employees.Controls.Add(this.label1);
            this.Employees.Location = new System.Drawing.Point(4, 25);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(827, 371);
            this.Employees.TabIndex = 0;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(109, 342);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(15, 342);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 13;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(109, 301);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 301);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(277, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 321);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "password";
            this.Column1.HeaderText = "Password";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "iduser";
            this.Column2.HeaderText = "UserID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fullname";
            this.Column3.HeaderText = "Full Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "type";
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Location = new System.Drawing.Point(136, 156);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(100, 20);
            this.fullnameTxt.TabIndex = 9;
            // 
            // useridTxt
            // 
            this.useridTxt.Location = new System.Drawing.Point(15, 156);
            this.useridTxt.Name = "useridTxt";
            this.useridTxt.Size = new System.Drawing.Size(100, 20);
            this.useridTxt.TabIndex = 8;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(136, 60);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 6;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(15, 60);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Employee",
            "Customer"});
            this.comboBox1.Location = new System.Drawing.Point(30, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Tab
            // 
            this.Tab.AccessibleName = "";
            this.Tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tab.Controls.Add(this.Employees);
            this.Tab.Controls.Add(this.Cars);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(835, 400);
            this.Tab.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idcar";
            this.Column5.HeaderText = "Car ID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "engine";
            this.Column10.HeaderText = "Engine";
            this.Column10.Name = "Column10";
            this.Column10.Width = 45;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "fuel";
            this.Column11.HeaderText = "Fuel";
            this.Column11.Name = "Column11";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "manufacturer";
            this.Column6.HeaderText = "Manufacturer";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "model";
            this.Column7.HeaderText = "Model";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "location";
            this.Column8.HeaderText = "Location";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "year";
            this.Column9.HeaderText = "BuildDate";
            this.Column9.Name = "Column9";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "photo";
            this.Column13.HeaderText = "image";
            this.Column13.Name = "Column13";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 474);
            this.Controls.Add(this.Tab);
            this.Name = "AdminForm";
            this.Text = "LuxuryRenting";
            this.Cars.ResumeLayout(false);
            this.Cars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage Cars;
        private System.Windows.Forms.Button imageBtn;
        private System.Windows.Forms.Button deleteCarBtn;
        private System.Windows.Forms.Button viewCarBtn;
        private System.Windows.Forms.Button updateCarBtn;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox engineTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.TextBox manufacturerTxt;
        private System.Windows.Forms.TextBox caridTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.TextBox useridTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}

