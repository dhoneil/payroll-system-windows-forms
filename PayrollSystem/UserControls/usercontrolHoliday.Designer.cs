namespace PayrollSystem.UserControls
{
    partial class usercontrolHoliday
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
            this.dgvholiday = new System.Windows.Forms.DataGridView();
            this.txtholidayname = new MetroFramework.Controls.MetroTextBox();
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpholidaydate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbtype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvholiday)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Holiday";
            // 
            // dgvholiday
            // 
            this.dgvholiday.AllowUserToAddRows = false;
            this.dgvholiday.AllowUserToDeleteRows = false;
            this.dgvholiday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvholiday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvholiday.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvholiday.Location = new System.Drawing.Point(429, 89);
            this.dgvholiday.Name = "dgvholiday";
            this.dgvholiday.ReadOnly = true;
            this.dgvholiday.RowHeadersVisible = false;
            this.dgvholiday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvholiday.Size = new System.Drawing.Size(645, 510);
            this.dgvholiday.TabIndex = 20;
            // 
            // txtholidayname
            // 
            this.txtholidayname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtholidayname.Lines = new string[0];
            this.txtholidayname.Location = new System.Drawing.Point(161, 156);
            this.txtholidayname.MaxLength = 32767;
            this.txtholidayname.Name = "txtholidayname";
            this.txtholidayname.PasswordChar = '\0';
            this.txtholidayname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtholidayname.SelectedText = "";
            this.txtholidayname.Size = new System.Drawing.Size(243, 30);
            this.txtholidayname.TabIndex = 26;
            this.txtholidayname.UseSelectable = true;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnadd.Location = new System.Drawing.Point(25, 89);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(379, 34);
            this.btnadd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "+ Add New";
            this.btnadd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnadd.UseSelectable = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(78, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Name";
            // 
            // dtpholidaydate
            // 
            this.dtpholidaydate.Location = new System.Drawing.Point(161, 218);
            this.dtpholidaydate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpholidaydate.Name = "dtpholidaydate";
            this.dtpholidaydate.Size = new System.Drawing.Size(243, 29);
            this.dtpholidaydate.TabIndex = 30;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(87, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Date";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.ItemHeight = 23;
            this.cmbtype.Location = new System.Drawing.Point(161, 290);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(243, 29);
            this.cmbtype.TabIndex = 31;
            this.cmbtype.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(87, 290);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Type";
            // 
            // usercontrolHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.dtpholidaydate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtholidayname);
            this.Controls.Add(this.dgvholiday);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolHoliday";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvholiday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvholiday;
        private MetroFramework.Controls.MetroTextBox txtholidayname;
        private MetroFramework.Controls.MetroButton btnadd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpholidaydate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbtype;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
