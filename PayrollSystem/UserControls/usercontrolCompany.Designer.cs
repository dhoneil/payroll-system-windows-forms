namespace PayrollSystem.UserControls
{
    partial class usercontrolCompany
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtcompanyname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txthiddencompanyID = new System.Windows.Forms.TextBox();
            this.btnupdatecompany = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Company";
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
            this.btnaddcompany.TabIndex = 20;
            this.btnaddcompany.Text = "+ Save";
            this.btnaddcompany.UseSelectable = true;
            this.btnaddcompany.Click += new System.EventHandler(this.btnaddcompany_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 168);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtaddress.Lines = new string[0];
            this.txtaddress.Location = new System.Drawing.Point(162, 157);
            this.txtaddress.MaxLength = 32767;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(342, 30);
            this.txtaddress.TabIndex = 21;
            this.txtaddress.UseSelectable = true;
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtcompanyname.Lines = new string[0];
            this.txtcompanyname.Location = new System.Drawing.Point(162, 102);
            this.txtcompanyname.MaxLength = 32767;
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.PasswordChar = '\0';
            this.txtcompanyname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcompanyname.SelectedText = "";
            this.txtcompanyname.Size = new System.Drawing.Size(342, 30);
            this.txtcompanyname.TabIndex = 21;
            this.txtcompanyname.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Name";
            // 
            // txthiddencompanyID
            // 
            this.txthiddencompanyID.Location = new System.Drawing.Point(162, 64);
            this.txthiddencompanyID.Name = "txthiddencompanyID";
            this.txthiddencompanyID.Size = new System.Drawing.Size(100, 20);
            this.txthiddencompanyID.TabIndex = 23;
            this.txthiddencompanyID.Visible = false;
            // 
            // btnupdatecompany
            // 
            this.btnupdatecompany.AutoSize = true;
            this.btnupdatecompany.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdatecompany.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnupdatecompany.Highlight = true;
            this.btnupdatecompany.Location = new System.Drawing.Point(302, 221);
            this.btnupdatecompany.Name = "btnupdatecompany";
            this.btnupdatecompany.Size = new System.Drawing.Size(202, 23);
            this.btnupdatecompany.Style = MetroFramework.MetroColorStyle.Green;
            this.btnupdatecompany.TabIndex = 20;
            this.btnupdatecompany.Text = "○ Update";
            this.btnupdatecompany.UseSelectable = true;
            this.btnupdatecompany.Click += new System.EventHandler(this.btnupdatecompany_Click_1);
            // 
            // usercontrolCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txthiddencompanyID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.btnupdatecompany);
            this.Controls.Add(this.btnaddcompany);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolCompany";
            this.Size = new System.Drawing.Size(528, 309);
            this.Load += new System.EventHandler(this.usercontrolCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.TextBox txthiddencompanyID;
        public MetroFramework.Controls.MetroButton btnupdatecompany;
        public MetroFramework.Controls.MetroButton btnaddcompany;
        public MetroFramework.Controls.MetroTextBox txtaddress;
        public MetroFramework.Controls.MetroTextBox txtcompanyname;
    }
}
