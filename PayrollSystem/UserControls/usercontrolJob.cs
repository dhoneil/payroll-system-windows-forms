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
    public partial class usercontrolJob : UserControl
    {
        public usercontrolJob()
        {
            InitializeComponent();
        }

        private void usercontrolJob_Load(object sender, EventArgs e)
        {
            List<view_job_list> joblist = JobModel.GetList();
            if (joblist.Any())
            {
                //dgvdepartmentlist.DataSource = joblist;
            }

            List<tbl_company> companylist = CompanyModel.GetList();
            if (companylist.Any())
            {
                cmbcompany.DataSource = companylist;
                cmbcompany.DisplayMember = "name";
                cmbcompany.ValueMember = "id";
            }

            List<view_department_list> departmentlist = DepartmentModel.GetList();
            if(departmentlist.Any())
            {
                cmbdepartment.DataSource = departmentlist;
                cmbdepartment.DisplayMember = "DepartmentName";
                cmbdepartment.ValueMember = "DepartmentID";
            }
        }

        private void btnaddcompany_Click_1(object sender, EventArgs e)
        {
            string jobname = txtjobname.Text.Trim();
            bool flag = true;
            if (String.IsNullOrEmpty(jobname)) flag = false;
            if (flag)
            {
                try
                {
                    long company = (long)cmbcompany.SelectedValue;
                    long department = (long)cmbdepartment.SelectedValue;
                    tbl_jobs data = new tbl_jobs { company = company, department = department, name = jobname };
                    data = JobModel.Save(data);
                    if (data.id > 0)
                    {
                        //dgvdepartmentlist.DataSource = JobModel.GetList();
                        MessageBox.Show("Job successfully saved.");
                        txtjobname.Text = string.Empty;
                    }
                    SettingWinForm.CurrentForm.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("All fields are required.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string jobname = txtjobname.Text.Trim();
            string id = txthiddenJobID.Text;
            bool flag = true;
            if (String.IsNullOrEmpty(jobname)) flag = false;
            if (flag)
            {
                try
                {
                    long company = (long)cmbcompany.SelectedValue;
                    long department = (long)cmbdepartment.SelectedValue;

                    tbl_jobs src = new tbl_jobs();
                    src.id = Convert.ToInt64(id);
                    src.company = company;
                    src.department = department;
                    src.name = jobname;
                    var data = JobModel.Update(src);
                    if (data.id > 0)
                    {
                        MessageBox.Show("Job successfully Updated.");

                        cmbcompany.SelectedValue = 0;
                        cmbdepartment.SelectedValue = 0;
                        txtjobname.Text = string.Empty;
                        txthiddenJobID.Text = string.Empty;
                    }
                    SettingWinForm.CurrentForm.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("All fields are required.");
            }
        }
    }
}
