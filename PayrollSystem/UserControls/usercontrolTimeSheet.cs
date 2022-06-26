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
    public partial class usercontrolTimeSheet : UserControl
    {
        public usercontrolTimeSheet()
        {
            InitializeComponent();
        }

        private void usercontrolTimeSheet_Load(object sender, EventArgs e)
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

        private void cmbcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
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
            GlobalVariable.SelectedCompany = company;
            GlobalVariable.SelectedDepartment = department;

            GenerateTimeSheet(company, department, date_from, date_to);
        }

        public void GenerateTimeSheet(long company, long department, DateTime date_from, DateTime date_to)
        {
            dgvtimesheet.DataSource = null;
            dgvtimesheet.DataSource = TimeSheetModel.GenerateTimeSheet(company, department, date_from, date_to);
            if (dgvtimesheet.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvtimesheet.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                    if ((bool)cell.Value == false)
                    {
                        row.Cells[0].Value = false;
                        row.Cells[0] = new DataGridViewTextBoxCell();
                    }
                }
            }
        }

        private void cmbcompany_SelectedValueChanged(object sender, EventArgs e)
        {

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

        private void dgvtimesheet_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvtimesheet.Rows[e.RowIndex].Selected = true;
                    this.dgvtimesheet.CurrentCell = this.dgvtimesheet.Rows[e.RowIndex].Cells[1];
                    this.contextmenustriptimesheet.Show(this.dgvtimesheet, e.Location);
                    contextmenustriptimesheet.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void viewDTRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int year = Convert.ToInt32(cmbyear.Text);
            int month = (int)cmbmonth.SelectedValue;
            int day = Convert.ToInt32(cmbday.Text);

            DateTime payroll_date = new DateTime(year, month, day);
            DateTime date_to = payroll_date.AddDays(-5);
            int year_now = date_to.Day == 5 && date_to.Month == 1 ? date_to.Year - 1 : date_to.Year;
            DateTime date_from = date_to.Day == 5 ? new DateTime(year_now, date_to.AddMonths(-1).Month, 21) : new DateTime(year_now, date_to.Month, 6);

            long empID = Convert.ToInt64(dgvtimesheet.CurrentRow.Cells["ID"].Value);
            GlobalVariable.SelectedEmployee = empID;

            Form frm = new Form();
            usercontrolDTR uc = new usercontrolDTR();
            uc.Location = new Point(0, 0);
            frm.ClientSize = new Size(uc.Width, uc.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Controls.Add(uc);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormClosing += frm_FormClosing;
            SettingWinForm.ParentForm = frm;
            frm.ShowDialog();
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
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
            GenerateTimeSheet(company, department, date_from, date_to);
        }

        private void btnapprovetimesheet_Click(object sender, EventArgs e)
        {
            bool flag = true;
            bool noselection = false;
            List<tbl_employee_timesheet> timesheetdata = new List<tbl_employee_timesheet>();
            foreach (DataGridViewRow row in dgvtimesheet.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell != null)
                {
                    if ((bool)cell.Value == false) noselection = true;
                    else
                    {
                        noselection = false;
                        long empid = Convert.ToInt64(row.Cells["ID"].Value);
                        string[] date = row.Cells["Date Range"].Value.ToString().Trim().Split('-');
                        DateTime date_from = Convert.ToDateTime(date[0].Trim());
                        DateTime date_to = Convert.ToDateTime(date[1].Trim());
                        if (DTRModel.HasDTR(empid, date_from, date_to) == false) flag = false;
                        else
                        {
                            decimal workingdays = Convert.ToDecimal(row.Cells["Working Days"].Value);
                            decimal holidays = Convert.ToDecimal(row.Cells["Holidays"].Value);
                            decimal daysabsent = Convert.ToDecimal(row.Cells["Days Absent"].Value);
                            decimal dutyhours = Convert.ToDecimal(row.Cells["Duty Hours"].Value);
                            decimal lates = Convert.ToDecimal(row.Cells["Lates(min)"].Value);
                            decimal undertime = Convert.ToDecimal(row.Cells["Undertime(min)"].Value);
                            decimal overtime = Convert.ToDecimal(row.Cells["Overtime(hr)"].Value);

                            tbl_employee_timesheet data = new tbl_employee_timesheet
                            {
                                emp_id = empid,
                                date_from = date_from,
                                date_to = date_to,
                                working_days = workingdays,
                                holidays = holidays,
                                days_absent = daysabsent,
                                duty_hours = dutyhours,
                                lates = lates,
                                undertime = undertime,
                                overtime = overtime
                            };

                            timesheetdata.Add(data);
                        }
                    }
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Some selected Time Sheet don't have DTR. Please review the Time Sheet before approve.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (noselection)
            {
                MessageBox.Show("Please select atleast one Time Sheet to approve.", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult diagResult = MessageBox.Show("Are you sure to Approve selected Employee Time Sheet?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diagResult == DialogResult.Yes)
                {
                    foreach (tbl_employee_timesheet data in timesheetdata)
                    {
                        try
                        {
                            if (TimeSheetModel.ApproveTimeSheet(data) == false) flag = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    if (flag)
                    {
                        MessageBox.Show("Selected Time Sheet Successfully Approved.");
                        dgvtimesheet.DataSource = null;
                        GenerateTimeSheet(GlobalVariable.SelectedCompany, GlobalVariable.SelectedDepartment, GlobalVariable.SelectedDateFrom, GlobalVariable.SelectedDateTo);
                    }

                    //foreach (DataGridViewRow row in dgvtimesheet.Rows)
                    //{
                    //    DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

                    //    if (cell != null)
                    //    {
                    //        if ((bool)cell.Value == true)
                    //        {
                    //            string[] date = row.Cells["Date Range"].Value.ToString().Trim().Split('-');
                    //            DateTime date_from = Convert.ToDateTime(date[0].Trim());
                    //            DateTime date_to = Convert.ToDateTime(date[1].Trim());
                    //            long empid = Convert.ToInt64(row.Cells["ID"].Value);
                    //            decimal workingdays = Convert.ToDecimal(row.Cells["Working Days"].Value);
                    //            decimal holidays = Convert.ToDecimal(row.Cells["Holidays"].Value);
                    //            decimal daysabsent = Convert.ToDecimal(row.Cells["Days Absent"].Value);
                    //            decimal dutyhours = Convert.ToDecimal(row.Cells["Duty Hours"].Value);
                    //            decimal lates = Convert.ToDecimal(row.Cells["Lates(min)"].Value);
                    //            decimal undertime = Convert.ToDecimal(row.Cells["Undertime(min)"].Value);
                    //            decimal overtime = Convert.ToDecimal(row.Cells["Overtime(hr)"].Value);

                    //            if (flag)
                    //            {
                    //                try
                    //                {
                    //                    tbl_employee_timesheet data = new tbl_employee_timesheet
                    //                    {
                    //                        emp_id = empid,
                    //                        date_from = date_from,
                    //                        date_to = date_to,
                    //                        working_days = workingdays,
                    //                        holidays = holidays,
                    //                        days_absent = daysabsent,
                    //                        duty_hours = dutyhours,
                    //                        lates = lates,
                    //                        undertime = undertime,
                    //                        overtime = overtime
                    //                    };

                    //                    if (TimeSheetModel.ApproveTimeSheet(data))
                    //                    {
                    //                        MessageBox.Show("Selected Time Sheet Successfully Approved.");
                    //                        dgvtimesheet.DataSource = null;
                    //                        GenerateTimeSheet(GlobalVariable.SelectedCompany, GlobalVariable.SelectedDepartment, GlobalVariable.SelectedDateFrom, GlobalVariable.SelectedDateTo);
                    //                    }
                    //                }
                    //                catch (Exception ex) { MessageBox.Show(ex.Message); }
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
        }

        private void contextmenustriptimesheet_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
