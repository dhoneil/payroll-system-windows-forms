namespace PayrollSystem.UserControls
{
    partial class usercontrolEditEmployee
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
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.cmbcompany = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbcivilstatus = new System.Windows.Forms.ComboBox();
            this.cmbdepartment = new System.Windows.Forms.ComboBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtemployeeID = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.cmbusertype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbisactive = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmbjob = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(143, 411);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(328, 96);
            this.txtaddress.TabIndex = 7;
            this.txtaddress.Text = "";
            // 
            // dtpbirthdate
            // 
            this.dtpbirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbirthdate.Location = new System.Drawing.Point(143, 513);
            this.dtpbirthdate.Name = "dtpbirthdate";
            this.dtpbirthdate.Size = new System.Drawing.Size(328, 30);
            this.dtpbirthdate.TabIndex = 8;
            // 
            // cmbcompany
            // 
            this.cmbcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.Location = new System.Drawing.Point(143, 291);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(328, 33);
            this.cmbcompany.TabIndex = 5;
            this.cmbcompany.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(143, 590);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(328, 33);
            this.cmbgender.TabIndex = 11;
            // 
            // cmbcivilstatus
            // 
            this.cmbcivilstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcivilstatus.FormattingEnabled = true;
            this.cmbcivilstatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Separated",
            "Divorced/Annuled",
            "Widowed"});
            this.cmbcivilstatus.Location = new System.Drawing.Point(143, 550);
            this.cmbcivilstatus.Name = "cmbcivilstatus";
            this.cmbcivilstatus.Size = new System.Drawing.Size(328, 33);
            this.cmbcivilstatus.TabIndex = 9;
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.Location = new System.Drawing.Point(143, 331);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(328, 33);
            this.cmbdepartment.TabIndex = 6;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(143, 217);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(328, 30);
            this.txtlastname.TabIndex = 3;
            // 
            // txtemployeeID
            // 
            this.txtemployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeID.Location = new System.Drawing.Point(143, 64);
            this.txtemployeeID.Name = "txtemployeeID";
            this.txtemployeeID.Size = new System.Drawing.Size(328, 30);
            this.txtemployeeID.TabIndex = 25;
            this.txtemployeeID.Visible = false;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(143, 143);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(328, 30);
            this.txtfirstname.TabIndex = 1;
            // 
            // cmbusertype
            // 
            this.cmbusertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbusertype.FormattingEnabled = true;
            this.cmbusertype.Items.AddRange(new object[] {
            "",
            "User",
            "Admin"});
            this.cmbusertype.Location = new System.Drawing.Point(143, 101);
            this.cmbusertype.Name = "cmbusertype";
            this.cmbusertype.Size = new System.Drawing.Size(328, 33);
            this.cmbusertype.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Civil Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birth Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "User Type";
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(50, 684);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(421, 29);
            this.btnEditEmployee.TabIndex = 7;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(27, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "employee id (hidden)";
            this.label14.Visible = false;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddlename.Location = new System.Drawing.Point(143, 180);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(328, 30);
            this.txtmiddlename.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 46);
            this.label10.TabIndex = 33;
            this.label10.Text = "Edit Employee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Status";
            // 
            // cmbisactive
            // 
            this.cmbisactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbisactive.FormattingEnabled = true;
            this.cmbisactive.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbisactive.Location = new System.Drawing.Point(143, 630);
            this.cmbisactive.Name = "cmbisactive";
            this.cmbisactive.Size = new System.Drawing.Size(328, 33);
            this.cmbisactive.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(143, 254);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(328, 30);
            this.txtemail.TabIndex = 4;
            // 
            // cmbjob
            // 
            this.cmbjob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjob.FormattingEnabled = true;
            this.cmbjob.Location = new System.Drawing.Point(143, 371);
            this.cmbjob.Name = "cmbjob";
            this.cmbjob.Size = new System.Drawing.Size(328, 33);
            this.cmbjob.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Job";
            // 
            // usercontrolEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbjob);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.dtpbirthdate);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.cmbisactive);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.cmbcivilstatus);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtemployeeID);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbusertype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditEmployee);
            this.Name = "usercontrolEditEmployee";
            this.Size = new System.Drawing.Size(552, 749);
            this.Load += new System.EventHandler(this.usercontrolEditEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtemployeeID;
        public System.Windows.Forms.RichTextBox txtaddress;
        public System.Windows.Forms.DateTimePicker dtpbirthdate;
        public System.Windows.Forms.ComboBox cmbcompany;
        public System.Windows.Forms.ComboBox cmbgender;
        public System.Windows.Forms.ComboBox cmbcivilstatus;
        public System.Windows.Forms.ComboBox cmbdepartment;
        public System.Windows.Forms.TextBox txtlastname;
        public System.Windows.Forms.TextBox txtfirstname;
        public System.Windows.Forms.ComboBox cmbusertype;
        public System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmbisactive;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cmbjob;
        private System.Windows.Forms.Label label15;
    }
}
