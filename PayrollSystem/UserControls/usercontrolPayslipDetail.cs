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
using System.IO;
using System.Reflection;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolPayslipDetail : UserControl
    {
        public usercontrolPayslipDetail()
        {
            InitializeComponent();
        }

        long PAYSLIPID = 0;
        tbl_payslip PAYSLIP_RECORD = new tbl_payslip();
        View_Employee EMPLOYEE_RECORD = new View_Employee();
        tbl_employee_timesheet TIMESHEET_RECORD = new tbl_employee_timesheet();
        private void usercontrolPayslipDetail_Load(object sender, EventArgs e)
        {
            long EMPLOYEEID = GlobalVariable.SelectedEmployee;
            DateTime DATEFROM = GlobalVariable.SelectedDateFrom;
            DateTime DATETO = GlobalVariable.SelectedDateTo;
            EMPLOYEE_RECORD = EmployeeModel.GetEmployeeById(EMPLOYEEID);
            TIMESHEET_RECORD = TimeSheetModel.Get(GlobalVariable.TimeSheetID);
            var employeepayslip = PayslipModel.Get(GlobalVariable.TimeSheetID);

            // SET VALUE TO GLOBAL VARIABLE TO STORE CURRENT PAYSLIP
            PAYSLIP_RECORD = employeepayslip;

            if (employeepayslip != null)
            {
                PAYSLIPID = employeepayslip.id;

                //Payslip with FOR APPROVAL status can be modify
                if (employeepayslip.status == "FOR APPROVAL")
                {
                    txtadditionalname.Enabled = true;
                    txtadditionalamount.Enabled = true;
                    btnaddadditional.Enabled = true;

                    txtdeductioname.Enabled = true;
                    txtdeductionamount.Enabled = true;
                    btnadddeduction.Enabled = true;
                }

                //Only those approved payslip can be print
                if (employeepayslip.status == "APPROVED")
                {
                    btnprintpayslip.Enabled = true;
                }

                //RATE
                lblsummaryrateamount.Text = employeepayslip.semi_monthly_rate.Value.TruncateDecimal();

                //ADJUSTMENTS - Additionals / Less
                var adjustment = PayslipAdjustmentModel.GetList(employeepayslip.id);
                SetAdjustments(adjustment);

                //ADDITIONALS - OVERTIME AND HOLIDAY
                var additionals = PayslipAdditionalsModel.Get(employeepayslip.id);
                SetAdditionals(additionals);

                //LESS - ABSENCES AND LATES AND UNDERTIME
                var less = PayslipLessModel.Get(employeepayslip.id);
                SetLess(less);

                //DEDUCTIONS - GOVERNMENT AND LOANS
                var government = PayslipGovernmentDeductionModel.Get(employeepayslip.id);
                SetGovernment(government);
                var loans = PayslipLoanDeductionModel.Get(employeepayslip.id);
                SetLoans(loans);

                ComputDeductions();
                ComputeGrossPay();
                ComputeNetPay();
            }

            lblemployeename.Text = EMPLOYEE_RECORD.lastname.ToUpper() + ", " + EMPLOYEE_RECORD.firstname.ToUpper();
        }

        public void SetAdditionals(List<tbl_payslip_additionals> record)
        {
            DataTable ds = new DataTable();
            ds.Columns.Add("Name");
            ds.Columns.Add("Amount");

            decimal total = 0m;
            if (record.Any())
            {
                foreach (var data in record)
                {
                    DataRow row = ds.NewRow();
                    row["Name"] = data.name;
                    row["Amount"] = data.amount.Value.TruncateDecimal();
                    
                    ds.Rows.Add(row);

                    total += data.amount.Value;
                }
            }

            if (dgvadditionaladjustments.Rows.Count > 0) {
                foreach (DataGridViewRow row in dgvadditionaladjustments.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Amount"].Value);
                }
            }

            lblsummaryadditionalsamount.Text = total.TruncateDecimal();

            dgvadditionals.DataSource = ds;

        }

        public void SetLess(List<tbl_payslip_less> record)
        {
            if (record.Any())
            {
                decimal total = 0m;
                foreach (var data in record)
                {
                    switch (data.name)
                    {
                        case "ABSENCES":
                            lblabsencesamount.Text = data.amount.Value.TruncateDecimal();
                            break;
                        case "UNDERTIME":
                            lblundertimeamount.Text = data.amount.Value.TruncateDecimal();
                            break;
                        case "LATES":
                            lbllatesamount.Text = data.amount.Value.TruncateDecimal();
                            break;
                    }
                    total += data.amount.Value;
                }
                lblsummarylessamount.Text = total.TruncateDecimal();
            }
        }

        public void SetGovernment(List<tbl_payslip_government_dedution> record)
        {
            if (record.Any())
            {
                foreach (var data in record)
                {
                    switch (data.government.ToUpper())
                    {
                        case "PAGIBIG":
                            lblpagibigamount.Text = data.amount.Value.TruncateDecimal();
                            break;
                        case "SSS":
                            lblsssamount.Text = data.amount.Value.TruncateDecimal();
                            break;
                        case "PHILHEALTH":
                            lblphilhealthamount.Text = data.amount.Value.TruncateDecimal();
                            break;
                    }
                }
            }
        }

        public void SetLoans(List<tbl_payslip_loan_deduction> record)
        {
            if (record.Any())
            {
                decimal total = 0m;
                foreach (var data in record)
                {
                    total += data.amount.Value;
                }
                lblloanamount.Text = total.TruncateDecimal();
            }
        }

        public void SetAdjustments(List<tbl_payslip_adjustment> record)
        {
            if (record.Any())
            {
                DataTable dsAdditional = new DataTable();
                dsAdditional.Columns.Add("Name");
                dsAdditional.Columns.Add("Amount");

                DataTable dsLess = new DataTable();
                dsLess.Columns.Add("Name");
                dsLess.Columns.Add("Amount");

                foreach (var data in record)
                {
                    if (data.type.ToUpper() == "ADDITIONAL")
                    {
                        DataRow row = dsAdditional.NewRow();
                        row["Name"] = data.adjustment;
                        row["Amount"] = data.amount.Value.TruncateDecimal();
                        dsAdditional.Rows.Add(row);
                    }
                    else if (data.type.ToUpper() == "LESS")
                    {
                        DataRow row = dsLess.NewRow();
                        row["Name"] = data.adjustment;
                        row["Amount"] = data.amount.Value.TruncateDecimal();
                        dsLess.Rows.Add(row);
                    }
                }

                dgvadditionaladjustments.DataSource = dsAdditional;
                dgvdeductionadjustments.DataSource = dsLess;
            }
        }

        public void ComputDeductions()
        {
            decimal pagibig = Convert.ToDecimal(lblpagibigamount.Text);
            decimal philhealth = Convert.ToDecimal(lblphilhealthamount.Text);
            decimal sss = Convert.ToDecimal(lblsssamount.Text);
            decimal loan = Convert.ToDecimal(lblloanamount.Text);
            decimal deductionadjustment = 0m;

            if (dgvdeductionadjustments.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdeductionadjustments.Rows)
                {
                    deductionadjustment += Convert.ToDecimal(row.Cells["Amount"].Value);
                }
            }

            lblsummarydeductionsamount.Text = (pagibig + philhealth + sss + loan + deductionadjustment).TruncateDecimal();
        }

        public void ComputeGrossPay()
        {
            decimal rate = Convert.ToDecimal(lblsummaryrateamount.Text);
            decimal additionals = Convert.ToDecimal(lblsummaryadditionalsamount.Text);
            decimal less = Convert.ToDecimal(lblsummarylessamount.Text);

            lblsummarygrossamount.Text = ((rate + additionals) - less).TruncateDecimal();
        }

        public void ComputeNetPay()
        {
            decimal gross = Convert.ToDecimal(lblsummarygrossamount.Text);
            decimal deduction = Convert.ToDecimal(lblsummarydeductionsamount.Text);

            lblsummarynetpayamount.Text = (gross - deduction).TruncateDecimal();
        }

        private void btnadddduction_Click(object sender, EventArgs e)
        {
            string txtname = txtdeductioname.Text.Trim();
            string txtamount = txtdeductionamount.Text.Trim();

            if (!String.IsNullOrEmpty(txtname) && !String.IsNullOrEmpty(txtamount))
            {
                bool flag = true;
                decimal amount = 0m;
                try
                {
                    amount = Convert.ToDecimal(txtamount);
                }
                catch
                {
                    MessageBox.Show("Please input numeric value on Amount field.");
                    flag = false;
                }
                if (flag)
                {
                    var data = PayslipAdjustmentModel.Save(new tbl_payslip_adjustment { adjustment = txtname, amount = amount, payslip_id = PAYSLIPID, type = "LESS" });
                    if (data.id > 0)
                    {
                        decimal additional = Convert.ToDecimal(lblsummarydeductionsamount.Text);
                        lblsummarydeductionsamount.Text = (additional + amount).TruncateDecimal();
                        ComputeGrossPay();
                        ComputeNetPay();

                        //Update LESS DataGridView
                        dgvdeductionadjustments.Rows.Add(txtname, amount.TruncateDecimal());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input values on both fields");
            }
        }

        private void btnaddadditional_Click(object sender, EventArgs e)
        {
            string txtname = txtadditionalname.Text;
            string txtamount = txtadditionalamount.Text;

            if (!String.IsNullOrEmpty(txtname) && !String.IsNullOrEmpty(txtamount))
            {
                bool flag = true;
                decimal amount = 0m;
                try
                {
                    amount = Convert.ToDecimal(txtamount);
                }
                catch
                {
                    MessageBox.Show("Please input numeric value on Amount field.");
                    flag = false;
                }
                if (flag)
                {
                    var data = PayslipAdjustmentModel.Save(new tbl_payslip_adjustment { adjustment = txtname, amount = amount, payslip_id = PAYSLIPID, type = "ADDITIONAL" });
                    if (data.id > 0)
                    {
                        decimal additional = Convert.ToDecimal(lblsummaryadditionalsamount.Text);
                        lblsummaryadditionalsamount.Text = (additional + amount).TruncateDecimal();
                        ComputeGrossPay();
                        ComputeNetPay();
                        if (dgvadditionaladjustments.Rows.Count > 0)
                        {
                            dgvadditionaladjustments.Rows.Add(txtname, amount.TruncateDecimal());
                        }
                        else
                        {
                            DataTable ds = new DataTable();
                            ds.Columns.Add("Name");
                            ds.Columns.Add("Amount");

                            DataRow row = ds.NewRow();
                            row["Name"] = txtname;
                            row["Amount"] = amount.TruncateDecimal();
                            ds.Rows.Add(row);

                            dgvadditionaladjustments.DataSource = ds;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input values on both fields");
            }
        }

        WebBrowser myWebBrowser = new WebBrowser();
        private void btnprintpayslip_Click(object sender, EventArgs e)
        {

            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;

            //TEMPLATE path : PayrollSystem\PayrollSystem\bin\Debug\Content\printContent.html
            string templatePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content\printContent.html");
            string content = System.IO.File.ReadAllText(templatePath);
            //EMPLOYEE INFO
            content = content.Replace("{{COMPANY_NAME}}", EMPLOYEE_RECORD.Company_Name);
            content = content.Replace("{{WORING_DATES}}", (TIMESHEET_RECORD.date_from.Value.ToShortDateString() + " - " + TIMESHEET_RECORD.date_to.Value.ToShortDateString()));
            content = content.Replace("{{EMPLOYEE_DESIGNATION}}", EMPLOYEE_RECORD.JobName);
            content = content.Replace("{{EMPLOYEE_NAME}}", EMPLOYEE_RECORD.lastname.ToUpper() + ", " + EMPLOYEE_RECORD.firstname.ToUpper());
            content = content.Replace("{{PAYSLIP_ID}}", PAYSLIP_RECORD.id.ToString());
            content = content.Replace("{{EMPLOYEE_DEPARTMENT}}", EMPLOYEE_RECORD.Department_Name);

            //DISPLAY ADDITIONALS
            string otherAdditionals = string.Empty;
            if (dgvadditionals.Rows.Count > 0) {
                foreach (DataGridViewRow row in dgvadditionals.Rows)
                {
                    otherAdditionals += @"<tr><td style='font-size:12px;'>" + row.Cells["Name"].Value + "</td><td style='text-align: right; font-size:12px;'>" + row.Cells["Amount"].Value + "</td></tr>";
                }
            }
            if (dgvadditionaladjustments.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvadditionaladjustments.Rows)
                {
                    otherAdditionals += @"<tr><td style='font-size:12px;'>" + row.Cells["Name"].Value + "</td><td style='text-align: right; font-size:12px;'>" + row.Cells["Amount"].Value + "</td></tr>";
                }
            }
            otherAdditionals += "<tr><td style='font-size:12px;'><strong>TOTAL ADDITIONALS</strong></td><td style='text-align: right; font-size:12px;'><strong>" + lblsummaryadditionalsamount.Text + "</strong></td></tr>";
            content = content.Replace("{{TBODY_ADDITIONALS}}", 
                String.Format(@"<tr>
                                    <td style='font-size:12px;'>SEMI MONTHLY</td>
                                    <td style='text-align: right; font-size:12px;'>{0}</td>
                                </tr> {1}", PAYSLIP_RECORD.semi_monthly_rate.Value.TruncateDecimal(), otherAdditionals));

            //DISPLAY LESS
            string Less = string.Empty;
            Less += "<tr><td style='font-size:12px;'>ABSENCES</td><td style='text-align: right; font-size:12px;'>" + lblabsencesamount.Text + "</td></tr>";
            Less += "<tr><td style='font-size:12px;'>LATES</td><td style='text-align: right; font-size:12px;'>" + lbllatesamount.Text + "</td></tr>";
            Less += "<tr><td style='font-size:12px;'>UNDERTIME</td><td style='text-align: right; font-size:12px;'>" + lblundertimeamount.Text + "</td></tr>";
            Less += "<tr><td style='font-size:12px;'><strong>TOTAL LESS</strong></td><td style='text-align: right; font-size:12px;'> <strong>" + lblsummarylessamount.Text + "</strong></td></tr>";
            content = content.Replace("{{TBODY_LESS}}", Less);

            //DISPLAY ADJUSTMENTS
            string Adjustments = string.Empty;
            Adjustments += "<tr><td style='font-size:12px;'>PAG IBIG</td><td style='text-align: right; font-size:12px;'>" + lblpagibigamount.Text + "</td></tr>";
            Adjustments += "<tr><td style='font-size:12px;'>PHILHEALTH</td><td style='text-align: right; font-size:12px;'>" + lblphilhealthamount.Text + "</td></tr>";
            Adjustments += "<tr><td style='font-size:12px;'>SSS</td><td style='text-align: right; font-size:12px;'>" + lblsssamount.Text + "</td></tr>";
            Adjustments += "<tr><td style='font-size:12px;'>Loan</td><td style='text-align: right; font-size:12px;'>" + lblloanamount.Text + "</td></tr>";

            if (dgvdeductionadjustments.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdeductionadjustments.Rows)
                {
                    Adjustments += "<tr><td style='font-size:12px;'>" + row.Cells["Name"].Value + "</td><td style='text-align: right; font-size:12px;'>" + row.Cells["Amount"].Value + "</td></tr>";
                }
            }
            content = content.Replace("{{TBODY_DEDUCTION}}", Adjustments);

            //DISPLAY TOTAL GROSS
            content = content.Replace("{{TOTAL_GROSS}}", lblsummarygrossamount.Text);

            //DISPLAY TOTOAL DEDUCTION
            content = content.Replace("{{TOTAL_DEDUCTION}}", lblsummarydeductionsamount.Text);

            //DISPLAY NET AMOUNT
            content = content.Replace("{{NET_AMOUNT}}", lblsummarynetpayamount.Text);
            content = content.Replace("{{NET_AMOUNT_IN_WORDS}}", Convert.ToDecimal(lblsummarynetpayamount.Text).CurrencyInWords());

            myWebBrowser.DocumentText = content;

        }

        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.Print();
        }

    }
}
