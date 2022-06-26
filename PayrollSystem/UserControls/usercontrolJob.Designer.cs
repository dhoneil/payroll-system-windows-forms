namespace PayrollSystem.UserControls
{
    partial class usercontrolJob
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnaddcompany = new MetroFramework.Controls.MetroButton();
            this.txtjobname = new MetroFramework.Controls.MetroTextBox();
            this.cmbdepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnupdate = new MetroFramework.Controls.MetroButton();
            this.txthiddenJobID = new System.Windows.Forms.TextBox();
            this.cmbcompany = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Job";
            // 
            // btnaddcompany
            // 
            this.btnaddcompany.AutoSize = true;
            this.btnaddcompany.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddcompany.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnaddcompany.Highlight = true;
            this.btnaddcompany.Location = new System.Drawing.Point(302, 221);
            this.btnaddcompany.Name = "btnaddcompany";
            this.btnaddcompany.Size = new System.Drawing.Size(202, 23);
            this.btnaddcompany.Style = MetroFramework.MetroColorStyle.Green;
            this.btnaddcompany.TabIndex = 24;
            this.btnaddcompany.Text = "+ Save";
            this.btnaddcompany.UseSelectable = true;
            this.btnaddcompany.Click += new System.EventHandler(this.btnaddcompany_Click_1);
            // 
            // txtjobname
            // 
            this.txtjobname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtjobname.Lines = new string[0];
            this.txtjobname.Location = new System.Drawing.Point(162, 173);
            this.txtjobname.MaxLength = 32767;
            this.txtjobname.Name = "txtjobname";
            this.txtjobname.PasswordChar = '\0';
            this.txtjobname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtjobname.SelectedText = "";
            this.txtjobname.Size = new System.Drawing.Size(342, 30);
            this.txtjobname.TabIndex = 25;
            this.txtjobname.UseSelectable = true;
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.ItemHeight = 23;
            this.cmbdepartment.Location = new System.Drawing.Point(162, 127);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(342, 29);
            this.cmbdepartment.TabIndex = 26;
            this.cmbdepartment.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(61, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Company";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Department";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(97, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Job";
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnupdate.Highlight = true;
            this.btnupdate.Location = new System.Drawing.Point(302, 221);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(202, 23);
            this.btnupdate.Style = MetroFramework.MetroColorStyle.Green;
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "○ Update";
            this.btnupdate.UseSelectable = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txthiddenJobID
            // 
            this.txthiddenJobID.Location = new System.Drawing.Point(162, 39);
            this.txthiddenJobID.Name = "txthiddenJobID";
            this.txthiddenJobID.Size = new System.Drawing.Size(100, 20);
            this.txthiddenJobID.TabIndex = 29;
            this.txthiddenJobID.Visible = false;
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.ItemHeight = 23;
            this.cmbcompany.Location = new System.Drawing.Point(162, 74);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(342, 29);
            this.cmbcompany.TabIndex = 26;
            this.cmbcompany.UseSelectable = true;
            // 
            // usercontrolJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txthiddenJobID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.txtjobname);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddcompany);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolJob";
            this.Size = new System.Drawing.Size(528, 309);
            this.Load += new System.EventHandler(this.usercontrolJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txtjobname;
        public MetroFramework.Controls.MetroComboBox cmbdepartment;
        public MetroFramework.Controls.MetroComboBox cmbdepartmentcmbcompany;
        public MetroFramework.Controls.MetroButton btnupdate;
        public MetroFramework.Controls.MetroButton btnaddcompany;
        public System.Windows.Forms.TextBox txthiddenJobID;
        public MetroFramework.Controls.MetroComboBox cmbcompany;
    }
}
