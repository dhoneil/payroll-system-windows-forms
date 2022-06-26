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
    public partial class usercontrolGovernment : UserControl
    {
        public usercontrolGovernment()
        {
            InitializeComponent();
        }

        private void usercontrolGovernment_Load(object sender, EventArgs e)
        {
            cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbemployee.DropDownStyle = ComboBoxStyle.DropDownList;

            var companylist = CompanyModel.GetList();
            if (companylist.Any())
            {
                cmbcompany.DataSource = companylist;
                cmbcompany.ValueMember = "id";
                cmbcompany.DisplayMember = "name";
                cmbcompany.SelectedValue = 0;
            }
        }

        private void cmbcompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long company = Convert.ToInt64(cmbcompany.SelectedValue);
            if (company > 0)
            {
                var departmentlist = DepartmentModel.GetList(0, company);
                if (departmentlist.Any())
                {
                    cmbdepartment.DataSource = departmentlist;
                    cmbdepartment.ValueMember = "DepartmentID";
                    cmbdepartment.DisplayMember = "DepartmentName";
                    cmbdepartment.SelectedValue = 0;

                    cmbemployee.DataSource = null;
                }
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            long company = Convert.ToInt64(cmbcompany.SelectedValue);
            long department = Convert.ToInt64(cmbdepartment.SelectedValue);
            long employee  = Convert.ToInt64(cmbemployee.SelectedValue);
            if ( company > 0)
            {
                dgvemployeegovernment.DataSource = null;
                dgvemployeegovernment.DataSource = GovernmentModel.GenerateEmployeeGovernment(company, department, employee);
            }
            else
            {
                MessageBox.Show("Please select Company.");
            }
        }

        private void btnsssguideline_Click(object sender, EventArgs e)
        {
            usercontrolGovernmentGuidelines uc = new usercontrolGovernmentGuidelines();
            uc.lblgovernmentname.Text = "SSS Contribution Table 2019";
            DataTable dt = new DataTable();
            dt.Columns.Add("Range of Compensation");
            dt.Columns.Add("EE");
            var sss_contribution = SSSModel.Get();
            if (sss_contribution.Any())
            {
                foreach (var i in sss_contribution)
                {
                    DataRow row = dt.NewRow();
                    row[0] = i.start_range.Value.ToString("0,0.00") + " - " + i.end_range.Value.ToString("0,0.00");
                    row[1] = i.total_contribution_ee.Value.ToString("0,0.00");
                    dt.Rows.Add(row);
                }
            }
            uc.dgvgovernment.DataSource = null;
            uc.dgvgovernment.DataSource = dt;

            ShowGovernmentGuidelines(uc);
        }

        private void btnphilhealthguideline_Click(object sender, EventArgs e)
        {
            usercontrolGovernmentGuidelines uc = new usercontrolGovernmentGuidelines();
            uc.lblgovernmentname.Text = "Philhealth Contribution Table 2019";
            DataTable dt = new DataTable();
            dt.Columns.Add("Monthly Basic Salary x 2.75%");
            dt.Columns.Add("Monthly Premium");
            dt.Columns.Add("Personal Share");
            dt.Columns.Add("Employer Share");
            dt.Rows.Add("P10,000 and below", "P275.00", "P137.50", "P137.50");
            dt.Rows.Add("P10,000.01 to P39,999.99", "P275.02 to P1,099.99", "P137.51 to P549.99", "P137.51 to P549.99");
            dt.Rows.Add("P40,000.01 and above", "P1,100", "P550", "P550");

            uc.dgvgovernment.DataSource = null;
            uc.dgvgovernment.DataSource = dt;

            ShowGovernmentGuidelines(uc);
        }

        private void btnpagibigguideline_Click(object sender, EventArgs e)
        {
            usercontrolGovernmentGuidelines uc = new usercontrolGovernmentGuidelines();
            uc.lblgovernmentname.Text = "PAG-IBIG Contribution Table 2019";
            DataTable dt = new DataTable();
            dt.Columns.Add("Monthly Compensation");
            dt.Columns.Add("Employee Share");
            dt.Columns.Add("Employer Share");
            dt.Rows.Add("P1,500 and below", "1%", "2%");
            dt.Rows.Add("Over P1,500", "2%", "2%");
            uc.dgvgovernment.DataSource = null;
            uc.dgvgovernment.DataSource = dt;

            ShowGovernmentGuidelines(uc);
        }

        public void ShowGovernmentGuidelines(UserControl uc)
        {
            Form frm = new Form();
            uc.Location = new Point(0, 0);
            frm.ClientSize = new Size(uc.Width, uc.Height);
            frm.Controls.Add(uc);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void cmbdepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long company = Convert.ToInt64(cmbcompany.SelectedValue); 
            long department = Convert.ToInt64(cmbdepartment.SelectedValue); 
            if (company > 0 && department > 0) 
            { var employeelist = EmployeeModel.GetList(company, department); cmbemployee.DataSource = employeelist; cmbemployee.DisplayMember = "EmployeeName"; cmbemployee.ValueMember = "id"; cmbemployee.SelectedValue = 0; }
        }
    }
}
