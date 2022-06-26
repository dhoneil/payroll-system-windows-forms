namespace PayrollSystem.UserControls
{
    partial class usercontrolPayroll
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
            this.dgvpayslip = new System.Windows.Forms.DataGridView();
            this.contextmenustrippayroll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncomputepayslip = new MetroFramework.Controls.MetroButton();
            this.btnviewpayslip = new MetroFramework.Controls.MetroButton();
            this.cmbcompany = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbdepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbday = new MetroFramework.Controls.MetroComboBox();
            this.cmbmonth = new MetroFramework.Controls.MetroComboBox();
            this.cmbyear = new MetroFramework.Controls.MetroComboBox();
            this.btnapprovepayslip = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayslip)).BeginInit();
            this.contextmenustrippayroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Payroll";
            // 
            // dgvpayslip
            // 
            this.dgvpayslip.AllowUserToAddRows = false;
            this.dgvpayslip.AllowUserToDeleteRows = false;
            this.dgvpayslip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayslip.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvpayslip.Location = new System.Drawing.Point(429, 161);
            this.dgvpayslip.MultiSelect = false;
            this.dgvpayslip.Name = "dgvpayslip";
            this.dgvpayslip.RowHeadersVisible = false;
            this.dgvpayslip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpayslip.Size = new System.Drawing.Size(645, 438);
            this.dgvpayslip.TabIndex = 31;
            this.dgvpayslip.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpayslip_CellMouseUp);
            // 
            // contextmenustrippayroll
            // 
            this.contextmenustrippayroll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDTRToolStripMenuItem});
            this.contextmenustrippayroll.Name = "contextmenustriptimesheet";
            this.contextmenustrippayroll.Size = new System.Drawing.Size(173, 26);
            // 
            // viewDTRToolStripMenuItem
            // 
            this.viewDTRToolStripMenuItem.Name = "viewDTRToolStripMenuItem";
            this.viewDTRToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewDTRToolStripMenuItem.Text = "View Payslip Detail";
            this.viewDTRToolStripMenuItem.Click += new System.EventHandler(this.viewDTRToolStripMenuItem_Click);
            // 
            // btncomputepayslip
            // 
            this.btncomputepayslip.AutoSize = true;
            this.btncomputepayslip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncomputepayslip.Enabled = false;
            this.btncomputepayslip.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btncomputepayslip.Location = new System.Drawing.Point(429, 94);
            this.btncomputepayslip.Name = "btncomputepayslip";
            this.btncomputepayslip.Size = new System.Drawing.Size(200, 34);
            this.btncomputepayslip.Style = MetroFramework.MetroColorStyle.Green;
            this.btncomputepayslip.TabIndex = 33;
            this.btncomputepayslip.Text = "Compute Payslip";
            this.btncomputepayslip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btncomputepayslip.UseSelectable = true;
            this.btncomputepayslip.Click += new System.EventHandler(this.btncomputepayslip_Click);
            // 
            // btnviewpayslip
            // 
            this.btnviewpayslip.AutoSize = true;
            this.btnviewpayslip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnviewpayslip.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnviewpayslip.Location = new System.Drawing.Point(24, 398);
            this.btnviewpayslip.Name = "btnviewpayslip";
            this.btnviewpayslip.Size = new System.Drawing.Size(379, 34);
            this.btnviewpayslip.Style = MetroFramework.MetroColorStyle.Green;
            this.btnviewpayslip.TabIndex = 33;
            this.btnviewpayslip.Text = "View Payslip";
            this.btnviewpayslip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnviewpayslip.UseSelectable = true;
            this.btnviewpayslip.Click += new System.EventHandler(this.btnviewpayslip_Click);
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.ItemHeight = 23;
            this.cmbcompany.Location = new System.Drawing.Point(160, 99);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(243, 29);
            this.cmbcompany.TabIndex = 34;
            this.cmbcompany.UseSelectable = true;
            this.cmbcompany.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Company";
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.ItemHeight = 23;
            this.cmbdepartment.Location = new System.Drawing.Point(160, 161);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(243, 29);
            this.cmbdepartment.TabIndex = 34;
            this.cmbdepartment.UseSelectable = true;
            this.cmbdepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Department";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(97, 341);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Day";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(81, 291);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Month";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(94, 240);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Year";
            // 
            // cmbday
            // 
            this.cmbday.FormattingEnabled = true;
            this.cmbday.ItemHeight = 23;
            this.cmbday.Location = new System.Drawing.Point(160, 341);
            this.cmbday.Name = "cmbday";
            this.cmbday.Size = new System.Drawing.Size(243, 29);
            this.cmbday.TabIndex = 36;
            this.cmbday.UseSelectable = true;
            // 
            // cmbmonth
            // 
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.ItemHeight = 23;
            this.cmbmonth.Location = new System.Drawing.Point(160, 291);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(243, 29);
            this.cmbmonth.TabIndex = 37;
            this.cmbmonth.UseSelectable = true;
            // 
            // cmbyear
            // 
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.ItemHeight = 23;
            this.cmbyear.Location = new System.Drawing.Point(160, 240);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(243, 29);
            this.cmbyear.TabIndex = 38;
            this.cmbyear.UseSelectable = true;
            // 
            // btnapprovepayslip
            // 
            this.btnapprovepayslip.AutoSize = true;
            this.btnapprovepayslip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnapprovepayslip.Enabled = false;
            this.btnapprovepayslip.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnapprovepayslip.Location = new System.Drawing.Point(874, 99);
            this.btnapprovepayslip.Name = "btnapprovepayslip";
            this.btnapprovepayslip.Size = new System.Drawing.Size(200, 34);
            this.btnapprovepayslip.Style = MetroFramework.MetroColorStyle.Green;
            this.btnapprovepayslip.TabIndex = 42;
            this.btnapprovepayslip.Text = "Approve Payslip";
            this.btnapprovepayslip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnapprovepayslip.UseSelectable = true;
            this.btnapprovepayslip.Click += new System.EventHandler(this.btnapprovepayslip_Click);
            // 
            // usercontrolPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnapprovepayslip);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbday);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.cmbyear);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.btnviewpayslip);
            this.Controls.Add(this.btncomputepayslip);
            this.Controls.Add(this.dgvpayslip);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolPayroll";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayslip)).EndInit();
            this.contextmenustrippayroll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvpayslip;
        private System.Windows.Forms.ContextMenuStrip contextmenustrippayroll;
        private System.Windows.Forms.ToolStripMenuItem viewDTRToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btncomputepayslip;
        private MetroFramework.Controls.MetroButton btnviewpayslip;
        private MetroFramework.Controls.MetroComboBox cmbcompany;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbdepartment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbday;
        private MetroFramework.Controls.MetroComboBox cmbmonth;
        private MetroFramework.Controls.MetroComboBox cmbyear;
        private MetroFramework.Controls.MetroButton btnapprovepayslip;
    }
}
