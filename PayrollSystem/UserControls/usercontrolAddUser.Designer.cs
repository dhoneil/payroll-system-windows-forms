namespace PayrollSystem.UserControls
{
    partial class usercontrolAddUser
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvuserlist = new System.Windows.Forms.DataGridView();
            this.cmbemployee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbusertype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnadduser = new MetroFramework.Controls.MetroButton();
            this.cmbquestion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtanswer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtconfirmanswer = new MetroFramework.Controls.MetroTextBox();
            this.CMS_resetPassword = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtconfirmpassword = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserlist)).BeginInit();
            this.CMS_resetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Manage User";
            // 
            // dgvuserlist
            // 
            this.dgvuserlist.AllowUserToAddRows = false;
            this.dgvuserlist.AllowUserToDeleteRows = false;
            this.dgvuserlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvuserlist.Location = new System.Drawing.Point(429, 89);
            this.dgvuserlist.Name = "dgvuserlist";
            this.dgvuserlist.ReadOnly = true;
            this.dgvuserlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvuserlist.Size = new System.Drawing.Size(645, 510);
            this.dgvuserlist.TabIndex = 14;
            this.dgvuserlist.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvuserlist_CellMouseUp);
            // 
            // cmbemployee
            // 
            this.cmbemployee.FormattingEnabled = true;
            this.cmbemployee.ItemHeight = 23;
            this.cmbemployee.Location = new System.Drawing.Point(161, 148);
            this.cmbemployee.Name = "cmbemployee";
            this.cmbemployee.Size = new System.Drawing.Size(243, 29);
            this.cmbemployee.TabIndex = 0;
            this.cmbemployee.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 148);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Employee Name";
            // 
            // cmbusertype
            // 
            this.cmbusertype.FormattingEnabled = true;
            this.cmbusertype.ItemHeight = 23;
            this.cmbusertype.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbusertype.Location = new System.Drawing.Point(161, 210);
            this.cmbusertype.Name = "cmbusertype";
            this.cmbusertype.Size = new System.Drawing.Size(243, 29);
            this.cmbusertype.TabIndex = 1;
            this.cmbusertype.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(66, 210);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "User Type";
            // 
            // txtusername
            // 
            this.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(161, 277);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(243, 30);
            this.txtusername.TabIndex = 2;
            this.txtusername.UseSelectable = true;
            // 
            // txtpassword
            // 
            this.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(161, 342);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(243, 30);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(57, 277);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "User Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(69, 342);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Password";
            // 
            // btnadduser
            // 
            this.btnadduser.AutoSize = true;
            this.btnadduser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadduser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnadduser.Location = new System.Drawing.Point(25, 89);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(379, 34);
            this.btnadduser.Style = MetroFramework.MetroColorStyle.Green;
            this.btnadduser.TabIndex = 27;
            this.btnadduser.Text = "+ Add New";
            this.btnadduser.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnadduser.UseSelectable = true;
            this.btnadduser.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbquestion
            // 
            this.cmbquestion.FormattingEnabled = true;
            this.cmbquestion.ItemHeight = 23;
            this.cmbquestion.Items.AddRange(new object[] {
            "What was your childhood nickname?",
            "What is the name of your favorite childhood friend?",
            "In what city or town did your mother and father meet?",
            "What is the middle name of your oldest child?",
            "What is your favorite team?",
            "What is your favorite movie?",
            "What was your favorite sport in high school?",
            "What was your favorite food as a child?",
            "What is the first name of the boy or girl that you first kissed?",
            "What was the make and model of your first car?"});
            this.cmbquestion.Location = new System.Drawing.Point(695, 425);
            this.cmbquestion.Name = "cmbquestion";
            this.cmbquestion.Size = new System.Drawing.Size(379, 29);
            this.cmbquestion.TabIndex = 24;
            this.cmbquestion.UseSelectable = true;
            this.cmbquestion.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(964, 403);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Security Question";
            this.metroLabel5.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(974, 477);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Security Answer";
            this.metroLabel6.Visible = false;
            // 
            // txtanswer
            // 
            this.txtanswer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtanswer.Lines = new string[0];
            this.txtanswer.Location = new System.Drawing.Point(695, 499);
            this.txtanswer.MaxLength = 32767;
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.PasswordChar = '●';
            this.txtanswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtanswer.SelectedText = "";
            this.txtanswer.Size = new System.Drawing.Size(379, 30);
            this.txtanswer.TabIndex = 26;
            this.txtanswer.UseSelectable = true;
            this.txtanswer.UseSystemPasswordChar = true;
            this.txtanswer.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(922, 542);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(152, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Confirm Security Answer";
            this.metroLabel7.Visible = false;
            // 
            // txtconfirmanswer
            // 
            this.txtconfirmanswer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtconfirmanswer.Lines = new string[0];
            this.txtconfirmanswer.Location = new System.Drawing.Point(695, 564);
            this.txtconfirmanswer.MaxLength = 32767;
            this.txtconfirmanswer.Name = "txtconfirmanswer";
            this.txtconfirmanswer.PasswordChar = '●';
            this.txtconfirmanswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconfirmanswer.SelectedText = "";
            this.txtconfirmanswer.Size = new System.Drawing.Size(379, 30);
            this.txtconfirmanswer.TabIndex = 26;
            this.txtconfirmanswer.UseSelectable = true;
            this.txtconfirmanswer.UseSystemPasswordChar = true;
            this.txtconfirmanswer.Visible = false;
            // 
            // CMS_resetPassword
            // 
            this.CMS_resetPassword.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPasswordToolStripMenuItem});
            this.CMS_resetPassword.Name = "CMS_resetPassword";
            this.CMS_resetPassword.Size = new System.Drawing.Size(156, 26);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(17, 403);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(115, 19);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "Confirm Password";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtconfirmpassword.Lines = new string[0];
            this.txtconfirmpassword.Location = new System.Drawing.Point(161, 403);
            this.txtconfirmpassword.MaxLength = 32767;
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '●';
            this.txtconfirmpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconfirmpassword.SelectedText = "";
            this.txtconfirmpassword.Size = new System.Drawing.Size(243, 30);
            this.txtconfirmpassword.TabIndex = 4;
            this.txtconfirmpassword.UseSelectable = true;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // usercontrolAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.txtconfirmanswer);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbquestion);
            this.Controls.Add(this.cmbusertype);
            this.Controls.Add(this.cmbemployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvuserlist);
            this.Name = "usercontrolAddUser";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserlist)).EndInit();
            this.CMS_resetPassword.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvuserlist;
        private MetroFramework.Controls.MetroComboBox cmbemployee;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbusertype;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnadduser;
        private MetroFramework.Controls.MetroComboBox cmbquestion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtanswer;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtconfirmanswer;
        private System.Windows.Forms.ContextMenuStrip CMS_resetPassword;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtconfirmpassword;
    }
}
