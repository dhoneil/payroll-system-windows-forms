namespace PayrollSystem.UserControls
{
    partial class usercontrolGovernment
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvemployeegovernment = new System.Windows.Forms.DataGridView();
            this.btnsssguideline = new MetroFramework.Controls.MetroButton();
            this.btnphilhealthguideline = new MetroFramework.Controls.MetroButton();
            this.btnpagibigguideline = new MetroFramework.Controls.MetroButton();
            this.cmbcompany = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbdepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbemployee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnfilter = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployeegovernment)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Government Deduction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "CONTRIBUTION GUIDELINES";
            // 
            // dgvemployeegovernment
            // 
            this.dgvemployeegovernment.AllowUserToAddRows = false;
            this.dgvemployeegovernment.AllowUserToDeleteRows = false;
            this.dgvemployeegovernment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvemployeegovernment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployeegovernment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvemployeegovernment.Location = new System.Drawing.Point(429, 89);
            this.dgvemployeegovernment.Name = "dgvemployeegovernment";
            this.dgvemployeegovernment.ReadOnly = true;
            this.dgvemployeegovernment.RowHeadersVisible = false;
            this.dgvemployeegovernment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvemployeegovernment.Size = new System.Drawing.Size(645, 510);
            this.dgvemployeegovernment.TabIndex = 23;
            // 
            // btnsssguideline
            // 
            this.btnsssguideline.AutoSize = true;
            this.btnsssguideline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsssguideline.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnsssguideline.Location = new System.Drawing.Point(20, 128);
            this.btnsssguideline.Name = "btnsssguideline";
            this.btnsssguideline.Size = new System.Drawing.Size(121, 34);
            this.btnsssguideline.Style = MetroFramework.MetroColorStyle.Green;
            this.btnsssguideline.TabIndex = 28;
            this.btnsssguideline.Text = "○ SSS";
            this.btnsssguideline.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnsssguideline.UseSelectable = true;
            this.btnsssguideline.Click += new System.EventHandler(this.btnsssguideline_Click);
            // 
            // btnphilhealthguideline
            // 
            this.btnphilhealthguideline.AutoSize = true;
            this.btnphilhealthguideline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnphilhealthguideline.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnphilhealthguideline.Location = new System.Drawing.Point(162, 128);
            this.btnphilhealthguideline.Name = "btnphilhealthguideline";
            this.btnphilhealthguideline.Size = new System.Drawing.Size(108, 34);
            this.btnphilhealthguideline.Style = MetroFramework.MetroColorStyle.Green;
            this.btnphilhealthguideline.TabIndex = 28;
            this.btnphilhealthguideline.Text = "○ PHILHEALTH";
            this.btnphilhealthguideline.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnphilhealthguideline.UseSelectable = true;
            this.btnphilhealthguideline.Click += new System.EventHandler(this.btnphilhealthguideline_Click);
            // 
            // btnpagibigguideline
            // 
            this.btnpagibigguideline.AutoSize = true;
            this.btnpagibigguideline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnpagibigguideline.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnpagibigguideline.Location = new System.Drawing.Point(297, 128);
            this.btnpagibigguideline.Name = "btnpagibigguideline";
            this.btnpagibigguideline.Size = new System.Drawing.Size(113, 34);
            this.btnpagibigguideline.Style = MetroFramework.MetroColorStyle.Green;
            this.btnpagibigguideline.TabIndex = 28;
            this.btnpagibigguideline.Text = "○ PAG-IBIG";
            this.btnpagibigguideline.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnpagibigguideline.UseSelectable = true;
            this.btnpagibigguideline.Click += new System.EventHandler(this.btnpagibigguideline_Click);
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.ItemHeight = 23;
            this.cmbcompany.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbcompany.Location = new System.Drawing.Point(161, 218);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(243, 29);
            this.cmbcompany.TabIndex = 24;
            this.cmbcompany.UseSelectable = true;
            this.cmbcompany.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(61, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Company";
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.ItemHeight = 23;
            this.cmbdepartment.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbdepartment.Location = new System.Drawing.Point(162, 287);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(243, 29);
            this.cmbdepartment.TabIndex = 24;
            this.cmbdepartment.UseSelectable = true;
            this.cmbdepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbdepartment_SelectionChangeCommitted);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 287);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Department";
            // 
            // cmbemployee
            // 
            this.cmbemployee.FormattingEnabled = true;
            this.cmbemployee.ItemHeight = 23;
            this.cmbemployee.Location = new System.Drawing.Point(162, 356);
            this.cmbemployee.Name = "cmbemployee";
            this.cmbemployee.Size = new System.Drawing.Size(243, 29);
            this.cmbemployee.TabIndex = 24;
            this.cmbemployee.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 356);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Employee";
            // 
            // btnfilter
            // 
            this.btnfilter.AutoSize = true;
            this.btnfilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfilter.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnfilter.Location = new System.Drawing.Point(24, 565);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(380, 34);
            this.btnfilter.Style = MetroFramework.MetroColorStyle.Green;
            this.btnfilter.TabIndex = 28;
            this.btnfilter.Text = "Filter";
            this.btnfilter.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnfilter.UseSelectable = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // usercontrolGovernment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.btnpagibigguideline);
            this.Controls.Add(this.btnphilhealthguideline);
            this.Controls.Add(this.btnsssguideline);
            this.Controls.Add(this.dgvemployeegovernment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbemployee);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolGovernment";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolGovernment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployeegovernment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvemployeegovernment;
        private MetroFramework.Controls.MetroButton btnsssguideline;
        private MetroFramework.Controls.MetroButton btnphilhealthguideline;
        private MetroFramework.Controls.MetroButton btnpagibigguideline;
        private MetroFramework.Controls.MetroComboBox cmbcompany;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbdepartment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbemployee;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnfilter;
    }
}
