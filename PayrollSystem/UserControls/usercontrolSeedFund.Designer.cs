namespace PayrollSystem.UserControls
{
    partial class usercontrolSeedFund
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
            this.dgvloan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.contextmenustripoptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.cmbcompany = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbdepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbemployee = new MetroFramework.Controls.MetroComboBox();
            this.Employee = new MetroFramework.Controls.MetroLabel();
            this.txtamount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpdeductiondate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloan)).BeginInit();
            this.contextmenustripoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvloan
            // 
            this.dgvloan.AllowUserToAddRows = false;
            this.dgvloan.AllowUserToDeleteRows = false;
            this.dgvloan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvloan.Location = new System.Drawing.Point(429, 89);
            this.dgvloan.MultiSelect = false;
            this.dgvloan.Name = "dgvloan";
            this.dgvloan.ReadOnly = true;
            this.dgvloan.RowHeadersVisible = false;
            this.dgvloan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloan.Size = new System.Drawing.Size(645, 510);
            this.dgvloan.TabIndex = 24;
            this.dgvloan.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvloan_CellMouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Seed Fund";
            // 
            // contextmenustripoptions
            // 
            this.contextmenustripoptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.releaseToolStripMenuItem,
            this.voidToolStripMenuItem});
            this.contextmenustripoptions.Name = "contextmenustripoptions";
            this.contextmenustripoptions.Size = new System.Drawing.Size(114, 48);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.releaseToolStripMenuItem.Text = "Release";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // voidToolStripMenuItem
            // 
            this.voidToolStripMenuItem.Name = "voidToolStripMenuItem";
            this.voidToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.voidToolStripMenuItem.Text = "Void";
            this.voidToolStripMenuItem.Click += new System.EventHandler(this.voidToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdd.Location = new System.Drawing.Point(24, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(379, 34);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "+ Add New";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.ItemHeight = 23;
            this.cmbcompany.Location = new System.Drawing.Point(161, 156);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(243, 29);
            this.cmbcompany.TabIndex = 24;
            this.cmbcompany.UseSelectable = true;
            this.cmbcompany.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Company";
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.ItemHeight = 23;
            this.cmbdepartment.Location = new System.Drawing.Point(161, 220);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(243, 29);
            this.cmbdepartment.TabIndex = 24;
            this.cmbdepartment.UseSelectable = true;
            this.cmbdepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbdepartment_SelectionChangeCommitted);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Department";
            // 
            // cmbemployee
            // 
            this.cmbemployee.FormattingEnabled = true;
            this.cmbemployee.ItemHeight = 23;
            this.cmbemployee.Location = new System.Drawing.Point(160, 283);
            this.cmbemployee.Name = "cmbemployee";
            this.cmbemployee.Size = new System.Drawing.Size(243, 29);
            this.cmbemployee.TabIndex = 24;
            this.cmbemployee.UseSelectable = true;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(61, 283);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(67, 19);
            this.Employee.TabIndex = 33;
            this.Employee.Text = "Employee";
            // 
            // txtamount
            // 
            this.txtamount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtamount.Lines = new string[0];
            this.txtamount.Location = new System.Drawing.Point(161, 346);
            this.txtamount.MaxLength = 32767;
            this.txtamount.Name = "txtamount";
            this.txtamount.PasswordChar = '\0';
            this.txtamount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtamount.SelectedText = "";
            this.txtamount.Size = new System.Drawing.Size(243, 30);
            this.txtamount.TabIndex = 26;
            this.txtamount.UseSelectable = true;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(72, 346);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Amount";
            // 
            // dtpdeductiondate
            // 
            this.dtpdeductiondate.Location = new System.Drawing.Point(160, 408);
            this.dtpdeductiondate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpdeductiondate.Name = "dtpdeductiondate";
            this.dtpdeductiondate.Size = new System.Drawing.Size(242, 29);
            this.dtpdeductiondate.TabIndex = 34;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 408);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Deduction Date";
            // 
            // usercontrolSeedFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpdeductiondate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbemployee);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvloan);
            this.Name = "usercontrolSeedFund";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolSeedFund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloan)).EndInit();
            this.contextmenustripoptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvloan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextmenustripoptions;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voidToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox cmbcompany;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbdepartment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbemployee;
        private MetroFramework.Controls.MetroLabel Employee;
        private MetroFramework.Controls.MetroTextBox txtamount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtpdeductiondate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
