namespace PayrollSystem.UserControls
{
    partial class usercontrolMain
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
            this.menustripmainview = new System.Windows.Forms.MenuStrip();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDepartmentJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seedFundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.governmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyPayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payslipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelmaincontainer = new System.Windows.Forms.Panel();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblcompdept = new System.Windows.Forms.Label();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripmainview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustripmainview
            // 
            this.menustripmainview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.deductionToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menustripmainview.Location = new System.Drawing.Point(0, 0);
            this.menustripmainview.Name = "menustripmainview";
            this.menustripmainview.Size = new System.Drawing.Size(1632, 24);
            this.menustripmainview.TabIndex = 0;
            this.menustripmainview.Text = "menuStrip1";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Visible = false;
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.companyDepartmentJobToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.jobToolStripMenuItem,
            this.holidayToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // companyDepartmentJobToolStripMenuItem
            // 
            this.companyDepartmentJobToolStripMenuItem.Name = "companyDepartmentJobToolStripMenuItem";
            this.companyDepartmentJobToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.companyDepartmentJobToolStripMenuItem.Text = "Company - Department - Job";
            this.companyDepartmentJobToolStripMenuItem.Click += new System.EventHandler(this.companyDepartmentJobToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.ShowShortcutKeys = false;
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Visible = false;
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.departmentsToolStripMenuItem.Text = "Department";
            this.departmentsToolStripMenuItem.Visible = false;
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.jobToolStripMenuItem.Text = "Job";
            this.jobToolStripMenuItem.Visible = false;
            this.jobToolStripMenuItem.Click += new System.EventHandler(this.jobToolStripMenuItem_Click);
            // 
            // holidayToolStripMenuItem
            // 
            this.holidayToolStripMenuItem.Name = "holidayToolStripMenuItem";
            this.holidayToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.holidayToolStripMenuItem.Text = "Holiday";
            this.holidayToolStripMenuItem.Click += new System.EventHandler(this.holidayToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Visible = false;
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // deductionToolStripMenuItem
            // 
            this.deductionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seedFundToolStripMenuItem,
            this.governmentToolStripMenuItem});
            this.deductionToolStripMenuItem.Name = "deductionToolStripMenuItem";
            this.deductionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.deductionToolStripMenuItem.Text = "Deduction";
            // 
            // seedFundToolStripMenuItem
            // 
            this.seedFundToolStripMenuItem.Name = "seedFundToolStripMenuItem";
            this.seedFundToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.seedFundToolStripMenuItem.Text = "Seed Fund";
            this.seedFundToolStripMenuItem.Click += new System.EventHandler(this.seedFundToolStripMenuItem_Click);
            // 
            // governmentToolStripMenuItem
            // 
            this.governmentToolStripMenuItem.Name = "governmentToolStripMenuItem";
            this.governmentToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.governmentToolStripMenuItem.Text = "Government";
            this.governmentToolStripMenuItem.Click += new System.EventHandler(this.governmentToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeSheetToolStripMenuItem,
            this.monthlyPayrollToolStripMenuItem,
            this.payslipToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.payrollToolStripMenuItem.Text = "HRIS";
            // 
            // timeSheetToolStripMenuItem
            // 
            this.timeSheetToolStripMenuItem.Name = "timeSheetToolStripMenuItem";
            this.timeSheetToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.timeSheetToolStripMenuItem.Text = "Time Sheet";
            this.timeSheetToolStripMenuItem.Click += new System.EventHandler(this.timeSheetToolStripMenuItem_Click);
            // 
            // monthlyPayrollToolStripMenuItem
            // 
            this.monthlyPayrollToolStripMenuItem.Name = "monthlyPayrollToolStripMenuItem";
            this.monthlyPayrollToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.monthlyPayrollToolStripMenuItem.Text = "Payroll";
            this.monthlyPayrollToolStripMenuItem.Click += new System.EventHandler(this.monthlyPayrollToolStripMenuItem_Click);
            // 
            // payslipToolStripMenuItem
            // 
            this.payslipToolStripMenuItem.Name = "payslipToolStripMenuItem";
            this.payslipToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.payslipToolStripMenuItem.Text = "Payslip";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.lOGOUTToolStripMenuItem.Text = "Account Settings";
            // 
            // panelmaincontainer
            // 
            this.panelmaincontainer.Location = new System.Drawing.Point(3, 27);
            this.panelmaincontainer.Name = "panelmaincontainer";
            this.panelmaincontainer.Size = new System.Drawing.Size(1064, 596);
            this.panelmaincontainer.TabIndex = 1;
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblfullname.Location = new System.Drawing.Point(1348, 32);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(120, 37);
            this.lblfullname.TabIndex = 2;
            this.lblfullname.Text = "fullname";
            this.lblfullname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcompdept
            // 
            this.lblcompdept.AutoSize = true;
            this.lblcompdept.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblcompdept.Location = new System.Drawing.Point(1381, 70);
            this.lblcompdept.Name = "lblcompdept";
            this.lblcompdept.Size = new System.Drawing.Size(80, 20);
            this.lblcompdept.TabIndex = 2;
            this.lblcompdept.Text = "compDept";
            this.lblcompdept.Click += new System.EventHandler(this.label1_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // usercontrolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblcompdept);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.panelmaincontainer);
            this.Controls.Add(this.menustripmainview);
            this.Name = "usercontrolMain";
            this.Size = new System.Drawing.Size(1632, 788);
            this.Load += new System.EventHandler(this.usercontrolMain_Load);
            this.menustripmainview.ResumeLayout(false);
            this.menustripmainview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustripmainview;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyPayrollToolStripMenuItem;
        private System.Windows.Forms.Panel panelmaincontainer;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seedFundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem governmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payslipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyDepartmentJobToolStripMenuItem;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblcompdept;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;


    }
}
