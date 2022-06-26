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
    public partial class usercontrolDepartment : UserControl
    {
        public usercontrolDepartment()
        {
            InitializeComponent();
        }

        private void usercontrolDepartment_Load(object sender, EventArgs e)
        {
            cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;

            List<tbl_company> res = CompanyModel.GetList();
            cmbcompany.DataSource = res;
            cmbcompany.DisplayMember = "name";
            cmbcompany.ValueMember = "id";
            cmbcompany.SelectedValue = GlobalVariable.SelectedCompany;

            //dgvdepartmentlist.DataSource = DepartmentModel.GetList();





        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnaddcompany_Click_1(object sender, EventArgs e)
        {
            string departmentname = txtdepartmentname.Text.Trim();
            long companyid = (long)cmbcompany.SelectedValue;
            bool flag = true;
            if (String.IsNullOrEmpty(departmentname)) flag = false;
            if (companyid == 0) flag = false;
            if (flag)
            {
                try
                {
                    tbl_department data = new tbl_department { company = companyid, name = departmentname };
                    tbl_department res = DepartmentModel.Save(data);
                    if (res.id > 0)
                    {
                        //dgvdepartmentlist.DataSource = DepartmentModel.GetList();
                        MessageBox.Show("Department successfully added");
                        txtdepartmentname.Text = string.Empty;
                    }
                    SettingWinForm.CurrentForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void btnupdatedepartment_Click(object sender, EventArgs e)
        {
            string id = txthiddenDepartmentID.Text;
            string departmentname = txtdepartmentname.Text.Trim();
            long companyid = (long)cmbcompany.SelectedValue;
            bool flag = true;
            if (String.IsNullOrEmpty(departmentname)) flag = false;
            if (companyid == 0) flag = false;
            if (flag)
            {
                try
                {
                    tbl_department data = new tbl_department();
                    data.id = Convert.ToInt64(id);
                    data.name = departmentname;
                    data.company = companyid;
                    var src = DepartmentModel.Update(data);
                    long idd = src.id;
                    if (idd>0)
                    {
                        MessageBox.Show("Department Successfully Updated");
                        txthiddenDepartmentID.Text = string.Empty;
                        txtdepartmentname.Text = string.Empty;
                    }
                    SettingWinForm.CurrentForm.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
