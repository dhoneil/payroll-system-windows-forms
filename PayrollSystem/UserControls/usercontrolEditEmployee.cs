using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.UserControls;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolEditEmployee : UserControl
    {
        public usercontrolEditEmployee()
        {
            InitializeComponent();
        }

        private void usercontrolEditEmployee_Load(object sender, EventArgs e)
        {
            /*LOAD AND SET USER TYPE COMBO BOX ITEM NAME AND VALUE*/
            //AccountType accounttypemodel = new AccountType();
            //cmbusertype.DataSource = accounttypemodel.Get(null);
            //cmbusertype.DisplayMember = "type";
            //cmbusertype.ValueMember = "id";
            this.cmbusertype.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbcivilstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbgender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbisactive.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbjob.DropDownStyle = ComboBoxStyle.DropDownList;

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

            long EMPID = GlobalVariable.SelectedEmployee;

            var empmodel = EmployeeModel.GetEmployeeById(EMPID);

            string usertype = !String.IsNullOrEmpty(empmodel.usertype) ? empmodel.usertype : "";
            string firstname = !String.IsNullOrEmpty(empmodel.firstname) ? empmodel.firstname : "";
            string lastname = !String.IsNullOrEmpty(empmodel.lastname) ? empmodel.lastname : "";
            string email = !String.IsNullOrEmpty(empmodel.email) ? empmodel.email : "";
            string middlename = !String.IsNullOrEmpty(empmodel.firstname) ? empmodel.middlename : "";

            long CompanyId = empmodel.CompanyId.HasValue ? empmodel.CompanyId.Value : 0;
            string CompanyName = empmodel.Company_Name;
            long DepartmentId = empmodel.department.HasValue ? empmodel.department.Value : 0;
            string DepartmentName = empmodel.Department_Name;

            string civilstatus = empmodel.civil_status;
            string gender = empmodel.gender;
            string address = empmodel.address;
            string userstatus = empmodel.Employee_Status;

            DateTime? birthdate = empmodel.birthdate.Value;

            dtpbirthdate.Value = birthdate.Value;
            txtemployeeID.Text = EMPID.ToString();
            cmbusertype.Text = usertype;
            txtfirstname.Text = firstname;
            txtmiddlename.Text = middlename;
            txtlastname.Text = lastname;
            txtemail.Text = email;
            cmbcompany.SelectedValue = CompanyId;
            cmbdepartment.SelectedValue = DepartmentId;
            txtaddress.Text = address;
            cmbcivilstatus.Text = civilstatus;
            cmbgender.Text = gender;
            cmbisactive.SelectedValue = empmodel.is_active;
            cmbisactive.Text = userstatus;

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_employee data = new tbl_employee();

                data.id = Convert.ToInt64(txtemployeeID.Text);
                data.firstname = txtfirstname.Text;
                data.middlename = txtmiddlename.Text;
                data.lastname = txtlastname.Text;
                data.email = txtemail.Text;

                var isactive = data.is_active = cmbisactive.Text.ToUpper() == "ACTIVE" ? true : false;
                data.status = isactive == true ? "ACTIVE" : "INACTIVE";

                data.company = Convert.ToInt64(cmbcompany.SelectedValue);
                data.department = Convert.ToInt64(cmbdepartment.SelectedValue);
                data.job_id = Convert.ToInt64(cmbjob.SelectedValue);
                data.address = txtaddress.Text;
                data.birthdate = dtpbirthdate.Value;
                data.civil_status = cmbcivilstatus.Text;
                data.gender = cmbgender.Text;
                data.usertype = cmbusertype.Text;

                bool result = EmployeeModel.Update(data);
                if (result)
                {
                    MessageBox.Show("Successfully Updated.");
                    SettingWinForm.DynamicForm.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cmbcompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
