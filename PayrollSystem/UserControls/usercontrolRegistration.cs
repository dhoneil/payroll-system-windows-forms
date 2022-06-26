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
    public partial class usercontrolRegistration : UserControl
    {
        public usercontrolRegistration()
        {
            InitializeComponent();
        }

        private void usercontrolRegistration_Load(object sender, EventArgs e)
        {
            this.cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbjob.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcivilstatus.DropDownStyle = ComboBoxStyle.DropDownList;

            /*LOAD AND SET COMBO BOX ITEM NAME AND VALUE*/
            var companylist = CompanyModel.GetList();
            if (companylist.Any())
            {
                cmbcompany.DataSource = companylist;
                cmbcompany.ValueMember = "id";
                cmbcompany.DisplayMember = "name";
            }

            var departmentlist = DepartmentModel.GetList();
            if (departmentlist.Any())
            {
                cmbdepartment.DataSource = departmentlist;
                cmbdepartment.DisplayMember = "DepartmentName";
                cmbdepartment.ValueMember = "DepartmentID";
            }

            var joblist = JobModel.GetList();
            if (joblist.Any())
            {
                cmbjob.DataSource = joblist;
                cmbjob.DisplayMember = "JobName";
                cmbjob.ValueMember = "JobID";
            }

            if (GlobalVariable.SelectedEmployee == 0)
            {
                lbltitle.Text = "Register Employee";
                btnregisteremployee.Text = "Register Employee";
                cmbjob.SelectedValue = 0;
                cmbdepartment.SelectedValue = 0;
                cmbcompany.SelectedValue = 0;
            }
            else
            {
                lbltitle.Text = "Edit Employee";
                btnregisteremployee.Text = "Update Employee";

                tbl_employee emprecord = EmployeeModel.Get(GlobalVariable.SelectedEmployee);
                txtfirstname.Text = emprecord.firstname;
                txtmiddlename.Text = emprecord.middlename;
                txtlastname.Text = emprecord.lastname;
                txtemail.Text = emprecord.email;
                txtaddress.Text = emprecord.address;
                dtpbirthdate.Value = emprecord.birthdate.Value;
                cmbcivilstatus.Text = emprecord.civil_status;
                cmbcompany.Text = emprecord.gender;

                cmbcompany.SelectedValue = emprecord.company.HasValue ? emprecord.company : 0;
                //cmbdepartment.SelectedValue = emprecord.department.HasValue ? emprecord.department : 0;
                cmbjob.SelectedValue = emprecord.job_id.HasValue ? emprecord.job_id : 0;
                tbl_employee_rate emprate = EmployeeRateModel.GetEmployeeRate(emprecord.id);
                if (emprate != null)
                    txtrate.Text = emprate.rate.HasValue ? emprate.rate.Value.ToString("0.00") : string.Empty;

                tbl_employee_government govrecord = GovernmentModel.Get(emprecord.id);
                if (govrecord != null)
                {
                    ckbsss.Checked = govrecord.has_sss.Value;
                    ckbphilhealth.Checked = govrecord.has_philhealth.Value;
                    ckbpagibig.Checked = govrecord.has_pagibig.Value;

                    txtsss.Text = govrecord.has_sss.Value ? govrecord.sss_number : string.Empty;
                    txtphilhealth.Text = govrecord.has_philhealth.Value? govrecord.philhealth_number: string.Empty;
                    txtpagibig.Text = govrecord.has_pagibig.Value ? govrecord.pagibig_number : string.Empty;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregisteremployee_Click(object sender, EventArgs e)
        {
            /*PERSONAL INFO FIELDS*/
            string fname = txtfirstname.Text.Trim();
            string mname = txtmiddlename.Text.Trim();
            string lname = txtlastname.Text.Trim();
            string email = txtemail.Text.Trim();
            string address = txtaddress.Text.Trim();
            string birthdate = dtpbirthdate.Value.ToShortDateString();
            string civilstatus = cmbcivilstatus.Text;
            string gender = cmbcompany.Text;

            /*COMPANY INFO FIELDS*/
            long? company = (long?)cmbcompany.SelectedValue;
            long? department = (long?)cmbdepartment.SelectedValue;
            long? job = (long?)cmbjob.SelectedValue;
            long schedule = 2; //default sched ID in tbl_schedule as REGULAR SCHEDULE
            string rate = txtrate.Text.Trim();

            /*GOVERNMENT INFO FIELDS*/
            string sss = txtsss.Text.Trim();
            string philhealth = txtphilhealth.Text.Trim();
            string pagibig = txtpagibig.Text.Trim();

            bool flag = true; /*VARIABLE TO USED AS ERROR FETCHER*/

            /* VALIDATION OF FIELDS */
            if (String.IsNullOrEmpty(fname)) flag = false;
            if (String.IsNullOrEmpty(lname)) flag = false;
            //if (String.IsNullOrEmpty(email)) flag = false;
            if (String.IsNullOrEmpty(mname)) flag = false;
            //if (String.IsNullOrEmpty(address)) flag = false;
            if (String.IsNullOrEmpty(civilstatus)) flag = false;
            if (String.IsNullOrEmpty(gender)) flag = false;
            if (String.IsNullOrEmpty(rate)) flag = false;
            if (!company.HasValue) flag = false;
            if (!department.HasValue) flag = false;
            if (!job.HasValue) flag = false;
            if (ckbsss.Checked)
            {
                if (String.IsNullOrEmpty(sss)) flag = false;
            }
            if (ckbphilhealth.Checked)
            {
                if (String.IsNullOrEmpty(philhealth)) flag = false;
            }
            if (ckbpagibig.Checked)
            {
                if (String.IsNullOrEmpty(pagibig)) flag = false;
            }

            if (!flag)
            {
                MessageBox.Show("Please fill out all required fields.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (flag)
            {
                /*PROCESS GATHERED DATA FROM FIELDS*/
                EmployeeModel empmodel = new EmployeeModel();
                EmployeeAccountModel accountmodel = new EmployeeAccountModel();
                decimal emprate = 0m;
                try {
                    emprate = Convert.ToDecimal(rate);
                }
                catch
                {
                    MessageBox.Show("Please input numeric value on Rate field.");
                    txtrate.Focus();
                    txtrate.SelectAll();
                    flag = false;
                }

                if (flag)
                {
                    try
                    {
                        tbl_employee emprecord = new tbl_employee
                        {
                            firstname = fname,
                            middlename = mname,
                            lastname = lname,
                            email = email,
                            company = company.Value,
                            department = department.Value,
                            schedule = schedule,
                            job_id = job.Value,
                            address = address,
                            birthdate = Convert.ToDateTime(birthdate),
                            civil_status = civilstatus,
                            gender = gender
                        };

                        bool has_sss = ckbsss.Checked ? true : false;
                        bool has_philhealth = ckbphilhealth.Checked ? true : false;
                        bool has_pagibig = ckbpagibig.Checked ? true : false;

                        if (GlobalVariable.SelectedEmployee == 0)
                        {
                            emprecord = empmodel.Save(emprecord);

                            tbl_employee_rate raterecord = new tbl_employee_rate { emp_id = emprecord.id, rate = emprate };
                            tbl_employee_government govrecord = new tbl_employee_government
                            {
                                emp_id = emprecord.id,
                                has_sss = has_sss,
                                has_philhealth = has_philhealth,
                                has_pagibig = has_pagibig,
                                sss_number = txtsss.Text,
                                philhealth_number = txtphilhealth.Text,
                                pagibig_number = txtpagibig.Text
                            };
                            if (emprecord.id > 0)
                            {
                                raterecord = EmployeeRateModel.Save(raterecord);
                                govrecord = GovernmentModel.Save(govrecord);
                            }

                            if (emprecord.id > 0 && raterecord.id > 0 && govrecord.id > 0)
                            {
                                MessageBox.Show("Register complete!", "System Message");
                                Form frm = SettingWinForm.DynamicForm;
                                frm.Close();
                            }
                        }
                        else
                        {
                            emprecord.id = GlobalVariable.SelectedEmployee;
                            EmployeeModel.Update(emprecord);

                            tbl_employee_rate _ratedata = EmployeeRateModel.GetEmployeeRate(emprecord.id);
                            if (_ratedata != null)
                            {
                                EmployeeRateModel.Update(emprecord.id, emprate);
                            }
                            else
                            {
                                tbl_employee_rate raterecord = new tbl_employee_rate { emp_id = emprecord.id, rate = emprate };
                                EmployeeRateModel.Save(raterecord);
                            }

                            tbl_employee_government govrecord = new tbl_employee_government
                            {
                                emp_id = emprecord.id,
                                has_sss = has_sss,
                                has_philhealth = has_philhealth,
                                has_pagibig = has_pagibig,
                                sss_number = txtsss.Text,
                                philhealth_number = txtphilhealth.Text,
                                pagibig_number = txtpagibig.Text
                            };
                            tbl_employee_government _govdata = GovernmentModel.Get(emprecord.id);
                            if (_govdata != null)
                            {
                                GovernmentModel.Update(govrecord);
                            }
                            else
                            {
                                GovernmentModel.Save(govrecord);
                            }

                            if (flag)
                            {
                            
                                MessageBox.Show("Data Successfully Updated.", "System Message");
                                Form frm = SettingWinForm.DynamicForm;
                                frm.Close();
                            }
                        }
 
                        GlobalControls.SelectedDataGridView.DataSource = null;
                        GlobalControls.SelectedDataGridView.DataSource = EmployeeModel.GenerateEmployee();
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ckbsss_CheckedChanged_1(object sender, EventArgs e)
        {
            txtsss.Enabled = ckbsss.Checked;
        }

        private void ckbphilhealth_CheckedChanged(object sender, EventArgs e)
        {
            txtphilhealth.Enabled = ckbphilhealth.Checked;
        }

        private void ckbpagibig_CheckedChanged(object sender, EventArgs e)
        {
            txtpagibig.Enabled = ckbpagibig.Checked;
        }

        private void cmbcompany_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            long company = Convert.ToInt64(cmbcompany.SelectedValue);
            if (company > 0)
            {
                cmbdepartment.DataSource = null;
                cmbjob.DataSource = null;

                var departlist = DepartmentModel.GetList(0, company);
                cmbdepartment.DataSource = departlist;
                cmbdepartment.DisplayMember = "DepartmentName";
                cmbdepartment.ValueMember = "DepartmentID";
                cmbdepartment.SelectedValue = 0;
            }
        }

        private void cmbdepartment_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            long company = Convert.ToInt64(cmbcompany.SelectedValue);
            long department = Convert.ToInt64(cmbdepartment.SelectedValue);
            if (company > 0 && department > 0)
            {
                cmbjob.DataSource = null;
                var joblist = JobModel.Get(company, department);
                cmbjob.DataSource = joblist;
                cmbjob.ValueMember = "id";
                cmbjob.DisplayMember = "name";
                cmbjob.SelectedValue = 0;
            }
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbphilhealth_CheckedChanged_1(object sender, EventArgs e)
        {
            txtphilhealth.Enabled = ckbphilhealth.Checked;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpagibig.Enabled = ckbpagibig.Checked;
        }


    }
}
