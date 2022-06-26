namespace PayrollSystem.UserControls
{
    partial class usercontrolSchedule
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
            this.dgvschedule = new System.Windows.Forms.DataGridView();
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.txtschedname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtptimein = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtptimeout = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtptimegrace = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvschedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Schedule";
            // 
            // dgvschedule
            // 
            this.dgvschedule.AllowUserToAddRows = false;
            this.dgvschedule.AllowUserToDeleteRows = false;
            this.dgvschedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvschedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvschedule.Location = new System.Drawing.Point(429, 89);
            this.dgvschedule.Name = "dgvschedule";
            this.dgvschedule.ReadOnly = true;
            this.dgvschedule.RowHeadersVisible = false;
            this.dgvschedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvschedule.Size = new System.Drawing.Size(645, 510);
            this.dgvschedule.TabIndex = 20;
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
            // txtschedname
            // 
            this.txtschedname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtschedname.Lines = new string[0];
            this.txtschedname.Location = new System.Drawing.Point(161, 156);
            this.txtschedname.MaxLength = 32767;
            this.txtschedname.Name = "txtschedname";
            this.txtschedname.PasswordChar = '\0';
            this.txtschedname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtschedname.SelectedText = "";
            this.txtschedname.Size = new System.Drawing.Size(243, 30);
            this.txtschedname.TabIndex = 29;
            this.txtschedname.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Schedule Title";
            // 
            // dtptimein
            // 
            this.dtptimein.Location = new System.Drawing.Point(161, 218);
            this.dtptimein.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtptimein.Name = "dtptimein";
            this.dtptimein.Size = new System.Drawing.Size(243, 29);
            this.dtptimein.TabIndex = 31;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Time In";
            // 
            // dtptimeout
            // 
            this.dtptimeout.Location = new System.Drawing.Point(161, 278);
            this.dtptimeout.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtptimeout.Name = "dtptimeout";
            this.dtptimeout.Size = new System.Drawing.Size(243, 29);
            this.dtptimeout.TabIndex = 31;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 278);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Time Out";
            // 
            // dtptimegrace
            // 
            this.dtptimegrace.Location = new System.Drawing.Point(161, 339);
            this.dtptimegrace.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtptimegrace.Name = "dtptimegrace";
            this.dtptimegrace.Size = new System.Drawing.Size(243, 29);
            this.dtptimegrace.TabIndex = 31;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 339);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Grace Time";
            // 
            // usercontrolSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtptimegrace);
            this.Controls.Add(this.dtptimeout);
            this.Controls.Add(this.dtptimein);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtschedname);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvschedule);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolSchedule";
            this.Size = new System.Drawing.Size(1095, 621);
            this.Load += new System.EventHandler(this.usercontrolSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvschedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvschedule;
        private MetroFramework.Controls.MetroButton btnadd;
        private MetroFramework.Controls.MetroTextBox txtschedname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtptimein;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtptimeout;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtptimegrace;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
