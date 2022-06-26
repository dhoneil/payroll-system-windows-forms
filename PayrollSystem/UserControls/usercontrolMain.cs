using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolMain : UserControl
    {
        public usercontrolMain()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolEmployeeList uc = new usercontrolEmployeeList();
            panelmaincontainer.Controls.Add(uc);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolAttendance uc = new usercontrolAttendance();
            panelmaincontainer.Controls.Add(uc);
        }

        private void employeeLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolCompany uc = new usercontrolCompany();
            panelmaincontainer.Controls.Add(uc);
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolDepartment uc = new usercontrolDepartment();
            panelmaincontainer.Controls.Add(uc);
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolJob uc = new usercontrolJob();
            panelmaincontainer.Controls.Add(uc);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolAddUser uc = new usercontrolAddUser();
            panelmaincontainer.Controls.Add(uc);
        }

        private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolTimeSheet uc = new usercontrolTimeSheet();
            panelmaincontainer.Controls.Add(uc);
        }

        private void holidayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelmaincontainer.Controls.Clear();
            usercontrolHoliday uc = new usercontrolHoliday();
            panelmaincontainer.Controls.Add(uc);
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            usercontrolSchedule uc = new usercontrolSchedule();
            if (panelmaincontainer.Controls.Contains(uc)) { }
            else
            {
                panelmaincontainer.Controls.Clear();
                panelmaincontainer.Controls.Add(uc);
            }
        }

        private void governmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            usercontrolGovernment uc = new usercontrolGovernment();
            if (panelmaincontainer.Controls.Contains(uc)) { }
            else
            {
                panelmaincontainer.Controls.Clear();
                panelmaincontainer.Controls.Add(uc);
            }
        }

        private void seedFundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            usercontrolSeedFund uc = new usercontrolSeedFund();
            if (panelmaincontainer.Controls.Contains(uc)) { }
            else
            {
                panelmaincontainer.Controls.Clear();
                panelmaincontainer.Controls.Add(uc);
            }
        }

        private void monthlyPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            usercontrolPayroll uc = new usercontrolPayroll();
            if (panelmaincontainer.Controls.Contains(uc)) { }
            else
            {
                panelmaincontainer.Controls.Clear();
                panelmaincontainer.Controls.Add(uc);
            }
        }

        private void companyDepartmentJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariable.UnSetValue();
            panelmaincontainer.Controls.Clear();
            usercontrolCompanyDepartmentJob uc = new usercontrolCompanyDepartmentJob();
            panelmaincontainer.Controls.Add(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usercontrolMain_Load(object sender, EventArgs e)
        {
            lblfullname.Text = SessionModel.userFirstname.ToUpper()+" "+SessionModel.userLastname.ToUpper();
            lblcompdept.Text = SessionModel.userCompany.ToUpper()+"-"+SessionModel.userDepartment.ToUpper();


            if (SessionModel.UserType != "Admin" && SessionModel.UserType != "Super Admin" || String.IsNullOrEmpty(SessionModel.UserType))
            {
                usersToolStripMenuItem.Visible = false;
            }
            else
            {
                usersToolStripMenuItem.Visible = true;
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountModel.logout();
        }

    }
}
