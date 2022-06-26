namespace PayrollSystem.UserControls
{
    partial class usercontrolDepartment
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
            this.txtdepartmentname = new MetroFramework.Controls.MetroTextBox();
            this.btnaddcompany = new MetroFramework.Controls.MetroButton();
            this.cmbcompany = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnupdatedepartment = new MetroFramework.Controls.MetroButton();
            this.txthiddenDepartmentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Department";
            // 
            // txtdepartmentname
            // 
            this.txtdepartmentname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtdepartmentname.Lines = new string[0];
            this.txtdepartmentname.Location = new System.Drawing.Point(162, 157);
            this.txtdepartmentname.MaxLength = 32767;
            this.txtdepartmentname.Name = "txtdepartmentname";
            this.txtdepartmentname.PasswordChar = '\0';
            this.txtdepartmentname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdepartmentname.SelectedText = "";
            this.txtdepartmentname.Size = new System.Drawing.Size(342, 30);
            this.txtdepartmentname.TabIndex = 22;
            this.txtdepartmentname.UseSelectable = true;
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
            this.btnaddcompany.TabIndex = 23;
            this.btnaddcompany.Text = "+ Save";
            this.btnaddcompany.UseSelectable = true;
            this.btnaddcompany.Click += new System.EventHandler(this.btnaddcompany_Click_1);
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.ItemHeight = 23;
            this.cmbcompany.Location = new System.Drawing.Point(162, 102);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(342, 29);
            this.cmbcompany.TabIndex = 24;
            this.cmbcompany.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Company";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 148);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 25;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Department";
            // 
            // btnupdatedepartment
            // 
            this.btnupdatedepartment.AutoSize = true;
            this.btnupdatedepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdatedepartment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnupdatedepartment.Highlight = true;
            this.btnupdatedepartment.Location = new System.Drawing.Point(302, 221);
            this.btnupdatedepartment.Name = "btnupdatedepartment";
            this.btnupdatedepartment.Size = new System.Drawing.Size(202, 23);
            this.btnupdatedepartment.Style = MetroFramework.MetroColorStyle.Green;
            this.btnupdatedepartment.TabIndex = 23;
            this.btnupdatedepartment.Text = "○ Update";
            this.btnupdatedepartment.UseSelectable = true;
            this.btnupdatedepartment.Click += new System.EventHandler(this.btnupdatedepartment_Click);
            // 
            // txthiddenDepartmentID
            // 
            this.txthiddenDepartmentID.Location = new System.Drawing.Point(162, 62);
            this.txthiddenDepartmentID.Name = "txthiddenDepartmentID";
            this.txthiddenDepartmentID.Size = new System.Drawing.Size(100, 20);
            this.txthiddenDepartmentID.TabIndex = 26;
            this.txthiddenDepartmentID.Visible = false;
            // 
            // usercontrolDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txthiddenDepartmentID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.btnupdatedepartment);
            this.Controls.Add(this.btnaddcompany);
            this.Controls.Add(this.txtdepartmentname);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolDepartment";
            this.Size = new System.Drawing.Size(528, 309);
            this.Load += new System.EventHandler(this.usercontrolDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroButton btnupdatedepartment;
        public MetroFramework.Controls.MetroButton btnaddcompany;
        public System.Windows.Forms.TextBox txthiddenDepartmentID;
        public MetroFramework.Controls.MetroTextBox txtdepartmentname;
        public MetroFramework.Controls.MetroComboBox cmbcompany;
    }
}
