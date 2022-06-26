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
    public partial class usercontrolPayroll : UserControl
    {
        public usercontrolPayroll()
        {
            InitializeComponent();
        }

        private void usercontrolPayroll_Load(object sender, EventArgs e)
        {
            cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbmonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbyear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbday.DropDownStyle = ComboBoxStyle.DropDownList;

            var companylist = CompanyModel.GetList();
            if (companylist.Any())
            {
                cmbcompany.DataSource = companylist;
                cmbcompany.ValueMember = "id";
                cmbcompany.DisplayMember = "name";
                cmbcompany.SelectedValue = 0;
            }

            List<int> year = new List<int>();
            for (int x = 2018; x < DateTime.Now.Year + 3; x++)
            {
                year.Add(x);
            }
            cmbyear.DataSource = year;
            cmbyear.Text = DateTime.Now.Year.ToString();

            Dictionary<int, string> month = new Dictionary<int, string>();
            month.Add(1, "January");
            month.Add(2, "February");
            month.Add(3, "March");
            month.Add(4, "April");
            month.Add(5, "May");
            month.Add(6, "June");
            month.Add(7, "July");
            month.Add(8, "August");
            month.Add(9, "September");
            month.Add(10, "October");
            month.Add(11, "November");
            month.Add(12, "December");
            cmbmonth.DataSource = month.ToList();
            cmbmonth.ValueMember = "Key";
            cmbmonth.DisplayMember = "Value";
            cmbmonth.SelectedValue = DateTime.Now.Month;

            List<int> days = new List<int> { 10, 25 };
            cmbday.DataSource = days;
        }

        private void cmbcompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbdepartment.DataSource = null;

            var departmentlist = DepartmentModel.GetList(0, (long)cmbcompany.SelectedValue);
            cmbdepartment.SelectedValue = 0;
            if (departmentlist.Any())
            {
                cmbdepartment.DataSource = departmentlist;
                cmbdepartment.ValueMember = "DepartmentID";
                cmbdepartment.DisplayMember = "DepartmentName";
            }
            else
            {
                //cmbdepartment.Text = "No Department" ;
            }
        }

        private void btnviewpayslip_Click(object sender, EventArgs e)
        {
            long company = 0;
            long department = 0;
            if (cmbdepartment.SelectedValue != null) department = (long)cmbdepartment.SelectedValue;
            if (cmbcompany.SelectedValue != null) company = (long)cmbcompany.SelectedValue;
            int year = Convert.ToInt32(cmbyear.Text);
            int month = (int)cmbmonth.SelectedValue;
            int day = Convert.ToInt32(cmbday.Text);

            DateTime payroll_date = new DateTime(year, month, day);
            DateTime date_to = payroll_date.AddDays(-5);
            int year_now = date_to.Day == 5 && date_to.Month == 1 ? date_to.Year - 1 : date_to.Year;
            DateTime date_from = date_to.Day == 5 ? new DateTime(year_now, date_to.AddMonths(-1).Month, 21) : new DateTime(year_now, date_to.Month, 6);

            GlobalVariable.SelectedDateFrom = date_from;
            GlobalVariable.SelectedDateTo = date_to;
            PayslipModel.dgvpayslip = dgvpayslip;
            PayslipModel.GeneratePayslip(company, department, date_from, date_to, btncomputepayslip, btnapprovepayslip);

        }

        private void dgvpayslip_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dgvpayslip.Rows[e.RowIndex].Selected = true;
                if (e.Button == MouseButtons.Right && 
                    (this.dgvpayslip.Rows[e.RowIndex].Cells["Status"].Value.ToString().ToUpper() == "FOR APPROVAL" ||
                    (this.dgvpayslip.Rows[e.RowIndex].Cells["Status"].Value.ToString().ToUpper() == "APPROVED")))
                {
                    //this.dgvpayslip.CurrentCell = this.dgvpayslip.Rows[e.RowIndex].Cells[1];
                    this.contextmenustrippayroll.Show(this.dgvpayslip, e.Location);
                    contextmenustrippayroll.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void viewDTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariable.TimeSheetID = Convert.ToInt64(dgvpayslip.CurrentRow.Cells["ID"].Value);
                GlobalVariable.SelectedEmployee = Convert.ToInt64(dgvpayslip.CurrentRow.Cells["EMP ID"].Value);
                usercontrolPayslipDetail uc = new usercontrolPayslipDetail ();
                ShowPayslipDetail(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowPayslipDetail(UserControl uc)
        {
            Form frm = new Form();
            uc.Location = new Point(0, 0);
            frm.Controls.Add(uc);
            frm.ClientSize = new Size(uc.Width, uc.Height);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            SettingWinForm.DynamicForm = frm;
            GlobalControls.SelectedDataGridView = this.dgvpayslip;
            frm.ShowDialog();
        }

        private void btncomputepayslip_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvpayslip.Rows)
            {
                string remarks = row.Cells["Remarks"].Value.ToString();
                if (remarks.ToUpper() == "COMPUTE PAYSLIP")
                {
                    long id = Convert.ToInt64(row.Cells["ID"].Value);
                    PayslipModel.ComputePayslip(id);
                }

                btnviewpayslip.PerformClick();
            }

        }

        private void btnapprovepayslip_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvpayslip.Rows)
            {
                string status = row.Cells["Status"].Value.ToString();
                if (status.ToUpper() == "FOR APPROVAL")
                {
                    try
                    {
                        long id = Convert.ToInt64(row.Cells["ID"].Value);
                        tbl_payslip data = PayslipModel.Get(id);
                        if (PayslipModel.Approve(data.id))
                        {
                            MessageBox.Show("Payslip(s) Successfully Approved.");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Approve Payslip(s)");
                        }
                    }
                    catch {
                        MessageBox.Show("Failed to Approve Payslip(s). Internal Error Occured");
                    }
                }

                btnviewpayslip.PerformClick();
            }
        }
    }
}
