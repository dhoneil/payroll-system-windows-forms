namespace PayrollSystem.UserControls
{
    partial class usercontrolTimeSheet
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
            this.dgvtimesheet = new System.Windows.Forms.DataGridView();
            this.contextmenustriptimesheet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.cmbcompany = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbdepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbmonth = new MetroFramework.Controls.MetroComboBox();
            this.cmbyear = new MetroFramework.Controls.MetroComboBox();
            this.cmbday = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnapprovetimesheet = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimesheet)).BeginInit();
            this.contextmenustriptimesheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time Sheet";
            // 
            // dgvtimesheet
            // 
            this.dgvtimesheet.AllowUserToAddRows = false;
            this.dgvtimesheet.AllowUserToDeleteRows = false;
            this.dgvtimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimesheet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvtimesheet.Location = new System.Drawing.Point(429, 89);
            this.dgvtimesheet.Name = "dgvtimesheet";
            this.dgvtimesheet.RowHeadersVisible = false;
            this.dgvtimesheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtimesheet.Size = new System.Drawing.Size(645, 510);
            this.dgvtimesheet.TabIndex = 19;
            this.dgvtimesheet.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtimesheet_CellMouseUp);
            // 
            // contextmenustriptimesheet
            // 
            this.contextmenustriptimesheet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDTRToolStripMenuItem});
            this.contextmenustriptimesheet.Name = "contextmenustriptimesheet";
            this.contextmenustriptimesheet.Size = new System.Drawing.Size(124, 26);
            this.contextmenustriptimesheet.Opening += new System.ComponentModel.CancelEventHandler(this.contextmenustriptimesheet_Opening);
            // 
            // viewDTRToolStripMenuItem
            // 
            this.viewDTRToolStripMenuItem.Name = "viewDTRToolStripMenuItem";
            this.viewDTRToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewDTRToolStripMenuItem.Text = "View DTR";
            this.viewDTRToolStripMenuItem.Click += new System.EventHandler(this.viewDTRToolStripMenuItem_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGenerate.Location = new System.Drawing.Point(25, 89);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(379, 34);
            this.btnGenerate.Style = MetroFramework.MetroColorStyle.Green;
            this.btnGenerate.TabIndex = 28;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.ItemHeight = 23;
            this.cmbcompany.Location = new System.Drawing.Point(161, 156);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(243, 29);
            this.cmbcompany.TabIndex = 29;
            this.cmbcompany.UseSelectable = true;
            this.cmbcompany.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            this.cmbcompany.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            this.cmbcompany.SelectedValueChanged += new System.EventHandler(this.cmbcompany_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Company";
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.ItemHeight = 23;
            this.cmbdepartment.Location = new System.Drawing.Point(161, 234);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(243, 29);
            this.cmbdepartment.TabIndex = 29;
            this.cmbdepartment.UseSelectable = true;
            this.cmbdepartment.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            this.cmbdepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            this.cmbdepartment.SelectedValueChanged += new System.EventHandler(this.cmbcompany_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 234);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Department";
            // 
            // cmbmonth
            // 
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.ItemHeight = 23;
            this.cmbmonth.Location = new System.Drawing.Point(161, 308);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(243, 29);
            this.cmbmonth.TabIndex = 29;
            this.cmbmonth.UseSelectable = true;
            this.cmbmonth.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            this.cmbmonth.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            this.cmbmonth.SelectedValueChanged += new System.EventHandler(this.cmbcompany_SelectedValueChanged);
            // 
            // cmbyear
            // 
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.ItemHeight = 23;
            this.cmbyear.Location = new System.Drawing.Point(161, 359);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(243, 29);
            this.cmbyear.TabIndex = 29;
            this.cmbyear.UseSelectable = true;
            this.cmbyear.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            this.cmbyear.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            this.cmbyear.SelectedValueChanged += new System.EventHandler(this.cmbcompany_SelectedValueChanged);
            // 
            // cmbday
            // 
            this.cmbday.FormattingEnabled = true;
            this.cmbday.ItemHeight = 23;
            this.cmbday.Location = new System.Drawing.Point(161, 409);
            this.cmbday.Name = "cmbday";
            this.cmbday.Size = new System.Drawing.Size(243, 29);
            this.cmbday.TabIndex = 29;
            this.cmbday.UseSelectable = true;
            this.cmbday.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            this.cmbday.SelectionChangeCommitted += new System.EventHandler(this.cmbcompany_SelectionChangeCommitted);
            this.cmbday.SelectedValueChanged += new System.EventHandler(this.cmbcompany_SelectedValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(97, 315);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Year";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(84, 366);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Month";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(100, 416);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Day";
            // 
            // btnapprovetimesheet
            // 
            this.btnapprovetimesheet.AutoSize = true;
            this.btnapprovetimesheet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnapprovetimesheet.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnapprovetimesheet.Location = new System.Drawing.Point(25, 565);
            this.btnapprovetimesheet.Name = "btnapprovetimesheet";
            this.btnapprovetimesheet.Size = new System.Drawing.Size(379, 34);
            this.btnapprovetimesheet.Style = MetroFramework.MetroColorStyle.Green;
            this.btnapprovetimesheet.TabIndex = 28;
            this.btnapprovetimesheet.Text = "Approve Time Sheet";
            this.btnapprovetimesheet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnapprovetimesheet.UseSelectable = true;
            this.btnapprovetimesheet.Click += new System.EventHandler(this.btnapprovetimesheet_Click);
            // 
            // usercontrolTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbday);
            this.Controls.Add(this.cmbyear);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.cmbcompany);
            this.Controls.Add(this.btnapprovetimesheet);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgvtimesheet);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolTimeSheet";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolTimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimesheet)).EndInit();
            this.contextmenustriptimesheet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextmenustriptimesheet;
        private System.Windows.Forms.ToolStripMenuItem viewDTRToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvtimesheet;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroComboBox cmbcompany;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbdepartment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbmonth;
        private MetroFramework.Controls.MetroComboBox cmbyear;
        private MetroFramework.Controls.MetroComboBox cmbday;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnapprovetimesheet;
    }
}
