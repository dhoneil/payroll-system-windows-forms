namespace PayrollSystem.UserControls
{
    partial class usercontrolCompanyDepartmentJob
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
            this.dgvcompany = new System.Windows.Forms.DataGridView();
            this.dgvdepartment = new System.Windows.Forms.DataGridView();
            this.dgvjob = new System.Windows.Forms.DataGridView();
            this.txtsearchcompany = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtsearchdepartment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtsearchjob = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnaddnewcompany = new MetroFramework.Controls.MetroButton();
            this.btnaddnewdepartment = new MetroFramework.Controls.MetroButton();
            this.btnaddnewjob = new MetroFramework.Controls.MetroButton();
            this.contextMenuStripcompany = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDepartment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripJob = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjob)).BeginInit();
            this.contextMenuStripcompany.SuspendLayout();
            this.contextMenuStripDepartment.SuspendLayout();
            this.contextMenuStripJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcompany
            // 
            this.dgvcompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompany.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvcompany.Location = new System.Drawing.Point(30, 128);
            this.dgvcompany.Name = "dgvcompany";
            this.dgvcompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcompany.Size = new System.Drawing.Size(306, 422);
            this.dgvcompany.TabIndex = 0;
            this.dgvcompany.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcompany_CellMouseUp);
            // 
            // dgvdepartment
            // 
            this.dgvdepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepartment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdepartment.Location = new System.Drawing.Point(388, 128);
            this.dgvdepartment.Name = "dgvdepartment";
            this.dgvdepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdepartment.Size = new System.Drawing.Size(306, 422);
            this.dgvdepartment.TabIndex = 0;
            this.dgvdepartment.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdepartment_CellMouseUp);
            // 
            // dgvjob
            // 
            this.dgvjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjob.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvjob.Location = new System.Drawing.Point(744, 128);
            this.dgvjob.Name = "dgvjob";
            this.dgvjob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvjob.Size = new System.Drawing.Size(302, 422);
            this.dgvjob.TabIndex = 0;
            this.dgvjob.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvjob_CellMouseUp);
            // 
            // txtsearchcompany
            // 
            this.txtsearchcompany.Lines = new string[0];
            this.txtsearchcompany.Location = new System.Drawing.Point(30, 92);
            this.txtsearchcompany.MaxLength = 32767;
            this.txtsearchcompany.Name = "txtsearchcompany";
            this.txtsearchcompany.PasswordChar = '\0';
            this.txtsearchcompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearchcompany.SelectedText = "";
            this.txtsearchcompany.Size = new System.Drawing.Size(183, 23);
            this.txtsearchcompany.TabIndex = 18;
            this.txtsearchcompany.UseSelectable = true;
            this.txtsearchcompany.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearchcompany_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Company";
            // 
            // txtsearchdepartment
            // 
            this.txtsearchdepartment.Lines = new string[0];
            this.txtsearchdepartment.Location = new System.Drawing.Point(388, 91);
            this.txtsearchdepartment.MaxLength = 32767;
            this.txtsearchdepartment.Name = "txtsearchdepartment";
            this.txtsearchdepartment.PasswordChar = '\0';
            this.txtsearchdepartment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearchdepartment.SelectedText = "";
            this.txtsearchdepartment.Size = new System.Drawing.Size(183, 23);
            this.txtsearchdepartment.TabIndex = 18;
            this.txtsearchdepartment.UseSelectable = true;
            this.txtsearchdepartment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearchdepartment_KeyUp);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(388, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Department";
            // 
            // txtsearchjob
            // 
            this.txtsearchjob.Lines = new string[0];
            this.txtsearchjob.Location = new System.Drawing.Point(744, 92);
            this.txtsearchjob.MaxLength = 32767;
            this.txtsearchjob.Name = "txtsearchjob";
            this.txtsearchjob.PasswordChar = '\0';
            this.txtsearchjob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearchjob.SelectedText = "";
            this.txtsearchjob.Size = new System.Drawing.Size(179, 23);
            this.txtsearchjob.TabIndex = 18;
            this.txtsearchjob.UseSelectable = true;
            this.txtsearchjob.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearchjob_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(744, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Job";
            // 
            // btnaddnewcompany
            // 
            this.btnaddnewcompany.AutoSize = true;
            this.btnaddnewcompany.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddnewcompany.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnaddnewcompany.Location = new System.Drawing.Point(219, 92);
            this.btnaddnewcompany.Name = "btnaddnewcompany";
            this.btnaddnewcompany.Size = new System.Drawing.Size(117, 23);
            this.btnaddnewcompany.Style = MetroFramework.MetroColorStyle.Green;
            this.btnaddnewcompany.TabIndex = 19;
            this.btnaddnewcompany.Text = "+ Add New";
            this.btnaddnewcompany.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnaddnewcompany.UseSelectable = true;
            this.btnaddnewcompany.Click += new System.EventHandler(this.btnaddnewcompany_Click);
            // 
            // btnaddnewdepartment
            // 
            this.btnaddnewdepartment.AutoSize = true;
            this.btnaddnewdepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddnewdepartment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnaddnewdepartment.Location = new System.Drawing.Point(577, 91);
            this.btnaddnewdepartment.Name = "btnaddnewdepartment";
            this.btnaddnewdepartment.Size = new System.Drawing.Size(117, 23);
            this.btnaddnewdepartment.Style = MetroFramework.MetroColorStyle.Green;
            this.btnaddnewdepartment.TabIndex = 19;
            this.btnaddnewdepartment.Text = "+ Add New";
            this.btnaddnewdepartment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnaddnewdepartment.UseSelectable = true;
            this.btnaddnewdepartment.Click += new System.EventHandler(this.btnaddnewdepartment_Click);
            // 
            // btnaddnewjob
            // 
            this.btnaddnewjob.AutoSize = true;
            this.btnaddnewjob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddnewjob.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnaddnewjob.Location = new System.Drawing.Point(929, 92);
            this.btnaddnewjob.Name = "btnaddnewjob";
            this.btnaddnewjob.Size = new System.Drawing.Size(117, 23);
            this.btnaddnewjob.Style = MetroFramework.MetroColorStyle.Green;
            this.btnaddnewjob.TabIndex = 19;
            this.btnaddnewjob.Text = "+ Add New";
            this.btnaddnewjob.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnaddnewjob.UseSelectable = true;
            this.btnaddnewjob.Click += new System.EventHandler(this.btnaddnewjob_Click);
            // 
            // contextMenuStripcompany
            // 
            this.contextMenuStripcompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripcompany.Name = "contextMenuStripcompany";
            this.contextMenuStripcompany.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStripcompany.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripcompany_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // contextMenuStripDepartment
            // 
            this.contextMenuStripDepartment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.contextMenuStripDepartment.Name = "contextMenuStripDepartment";
            this.contextMenuStripDepartment.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // contextMenuStripJob
            // 
            this.contextMenuStripJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem2});
            this.contextMenuStripJob.Name = "contextMenuStripJob";
            this.contextMenuStripJob.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // usercontrolCompanyDepartmentJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtsearchjob);
            this.Controls.Add(this.txtsearchdepartment);
            this.Controls.Add(this.btnaddnewjob);
            this.Controls.Add(this.btnaddnewdepartment);
            this.Controls.Add(this.btnaddnewcompany);
            this.Controls.Add(this.txtsearchcompany);
            this.Controls.Add(this.dgvjob);
            this.Controls.Add(this.dgvdepartment);
            this.Controls.Add(this.dgvcompany);
            this.Name = "usercontrolCompanyDepartmentJob";
            this.Size = new System.Drawing.Size(1130, 632);
            this.Load += new System.EventHandler(this.usercontrolCompanyDepartmentJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjob)).EndInit();
            this.contextMenuStripcompany.ResumeLayout(false);
            this.contextMenuStripDepartment.ResumeLayout(false);
            this.contextMenuStripJob.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtsearchcompany;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtsearchdepartment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtsearchjob;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnaddnewcompany;
        public System.Windows.Forms.DataGridView dgvcompany;
        private MetroFramework.Controls.MetroButton btnaddnewdepartment;
        private MetroFramework.Controls.MetroButton btnaddnewjob;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripcompany;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDepartment;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        public System.Windows.Forms.DataGridView dgvdepartment;
        public System.Windows.Forms.DataGridView dgvjob;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripJob;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;


    }
}
