using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Entity;

namespace PayrollSystem.Model
{
    public class PayslipModel
    {
        static dbPayrollEntities db;

        public static DataGridView dgvpayslip { get; set; }

        public static tbl_payslip Save(tbl_payslip data)
        {
            using (dbPayrollEntities db = new dbPayrollEntities())
            {
                data.preparedby = SessionModel.UserID;
                data.dateprepared = DateTime.Now;
                data.status = "FOR APPROVAL";
                data.remarks = "COMPUTED";
                db.tbl_payslip.Add(data);
                db.SaveChanges();
                return data;
            }
            
        }

        public static bool Approve(long timesheetid)
        {
            using (var db = new dbPayrollEntities())
            {
                bool flag = false;
                tbl_payslip record = db.tbl_payslip.Where(s => s.timesheet_id == timesheetid).FirstOrDefault();
                if (record != null)
                {
                    record.status = "APPROVED";
                    record.approvedby = SessionModel.UserID;
                    record.dateapproved = DateTime.Now;
                    flag = db.SaveChanges() > 0;
                }

                return flag;
            }
        }

        public static tbl_payslip Get(long timesheetid) {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip.Where(s => s.timesheet_id == timesheetid).SingleOrDefault();
            }
        }

        public static tbl_payslip GetEmployeePayslip(long empid, DateTime datefrom, DateTime dateto)
        {
            db = new dbPayrollEntities();
            return db.tbl_payslip.Where(s => s.emp_id == empid && DbFunctions.TruncateTime(s.datefrom).Value == datefrom.Date && DbFunctions.TruncateTime(s.dateto).Value == dateto.Date).FirstOrDefault();
        }

        public static void GeneratePayslip(long company, long department, DateTime datefrom, DateTime dateto, Button btncomputepayslip, Button btnapprovepayslip)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("EMP ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Name");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Additionals");
            dt.Columns.Add("Less");
            dt.Columns.Add("Gross Pay");
            dt.Columns.Add("Deductions");
            dt.Columns.Add("Net Pay");
            dt.Columns.Add("Status");
            dt.Columns.Add("Remarks");
            
            bool hastimesheet = false;
            bool haspayslip = false;
            bool enableComputePayslip = false;
            bool enableApprovePayslip = false;
            var employeelist = EmployeeModel.GetList(company, department).OrderBy(s => s.lastname);
            if (employeelist.Any())
            {
                foreach (var emp in employeelist)
                {
                    DataRow row = dt.NewRow();
                    tbl_employee_timesheet emptimesheet = TimeSheetModel.GetEmployeeTimeSheet(emp.id, datefrom, dateto);

                    row["EMP ID"] = emp.id;
                    if (emptimesheet == null)
                    {
                        row["ID"] = 0;
                        row["Date"] = datefrom.ToShortDateString() + " - " + dateto.ToShortDateString();
                        row["Name"] = emp.EmployeeName;
                        row["Rate"] = "-";
                        row["Additionals"] = "-";
                        row["Less"] = "-";
                        row["Gross Pay"] = "-";
                        row["Deductions"] = "-";
                        row["Net Pay"] = "-";
                        row["Status"] = "-";
                        row["Remarks"] = "NO APPROVED TIMESHEET";
                        
                    }
                    else
                    {
                        row["ID"] = emptimesheet.id;
                        row["Date"] = datefrom.ToShortDateString() + " - " + dateto.ToShortDateString();
                        row["Name"] = emp.EmployeeName;

                        string strrate = "-";
                        string stradditionals = "-";
                        string strless = "-";
                        string strgrosspay = "-";
                        string strdeductions = "-";
                        string strnetpay = "-";
                        string strstatus = "-";
                        string remarks = "COMPUTE PAYSLIP";
                        var employeepayslip = PayslipModel.GetEmployeePayslip(emp.id, datefrom, dateto);

                        // Enable btncomputepayslip if found atleast 1 timesheet with no payslip record
                        if (enableComputePayslip == false && employeepayslip == null)
                        {
                            enableComputePayslip = true;
                        }

                        if (employeepayslip != null)
                        {
                            // Enable btnapprovepayslip if found atleast 1 payslip with the status of FOR APPROVAL
                            // And only those have ADMIN accounts can approve the payslip
                            if (enableApprovePayslip == false && employeepayslip.status == "FOR APPROVAL" && SessionModel.UserType.ToUpper() == "ADMIN")
                            {
                                enableApprovePayslip = true;
                            }

                            remarks = "HAS PAYSLIP";

                            decimal rate = employeepayslip.semi_monthly_rate.Value;
                            decimal deductionadjustment = 0m;
                            decimal additionaladjustment = 0m;
                            decimal totalless = 0m;
                            decimal totaladditional = 0m;
                            decimal governmentdeduction = 0m;
                            decimal loandeduction = 0m;
                            decimal grosspay = 0m;
                            decimal netpay = 0m;

                            var payslipadjustments = PayslipAdjustmentModel.GetList(employeepayslip.id);
                            var payslipgovernmentdeductions = PayslipGovernmentDeductionModel.GetList(employeepayslip.id);
                            var payslipadditional = PayslipAdditionalsModel.Get(employeepayslip.id);
                            var payslipless = PayslipLessModel.Get(employeepayslip.id);
                            var paysliploan = PayslipLoanDeductionModel.Get(employeepayslip.id);

                            if (payslipadjustments.Any())
                            {
                                foreach (var i in payslipadjustments)
                                {
                                    if (i.type.ToUpper() == "ADDITIONAL") additionaladjustment += i.amount.Value;
                                    else if (i.type.ToUpper() == "LESS" || i.type.ToUpper() == "CHARGE") deductionadjustment += i.amount.Value;
                                }
                            }

                            if (payslipadditional.Any())
                            {
                                foreach (var data in payslipadditional)
                                {
                                    totaladditional += data.amount.Value;
                                }
                            }

                            if (payslipless.Any())
                            {
                                foreach (var data in payslipless)
                                {
                                    totalless += data.amount.Value;
                                }
                            }

                            if (payslipgovernmentdeductions.Any())
                            {
                                foreach (var i in payslipgovernmentdeductions)
                                {
                                    governmentdeduction += i.amount.Value;
                                }
                            }

                            if (paysliploan.Any()) {
                                foreach (var data in paysliploan)
                                {
                                    loandeduction += data.amount.Value;
                                }
                            }

                            decimal totaldeduction = governmentdeduction + loandeduction + deductionadjustment;
                            grosspay = ((rate + totaladditional + additionaladjustment) - totalless);
                            netpay = grosspay - totaldeduction;

                            strrate = employeepayslip.semi_monthly_rate.Value.TruncateDecimal();
                            stradditionals = additionaladjustment.TruncateDecimal();
                            strless = totalless.TruncateDecimal();
                            strgrosspay = grosspay.TruncateDecimal();
                            strdeductions = totaldeduction.TruncateDecimal();
                            strnetpay = netpay.TruncateDecimal();
                            strstatus = employeepayslip.status;
                        }
                        row["Rate"] = strrate;
                        row["Additionals"] = stradditionals;
                        row["Less"] = strless;
                        row["Gross Pay"] = strgrosspay;
                        row["Deductions"] = strdeductions;
                        row["Net Pay"] = strnetpay;
                        row["Status"] = strstatus;
                        row["Remarks"] = remarks;
                    }
                    dt.Rows.Add(row);
                }
            }

            if (hastimesheet) btncomputepayslip.Enabled = true;
            else btncomputepayslip.Enabled = false;

            if (enableComputePayslip) btncomputepayslip.Enabled = true;
            else btncomputepayslip.Enabled = false;

            if (enableApprovePayslip) btnapprovepayslip.Enabled = true;
            else btnapprovepayslip.Enabled = false;

            dgvpayslip.DataSource = null;
            dgvpayslip.DataSource = dt;
            dgvpayslip.RowPrePaint += dgvpayslip_RowPrePaint;
        }

        static void dgvpayslip_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvpayslip.Rows[e.RowIndex].Cells["Remarks"].Value.ToString().ToUpper().Trim() == "NO APPROVED TIMESHEET")
            {
                dgvpayslip.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Maroon;
                dgvpayslip.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else if (dgvpayslip.Rows[e.RowIndex].Cells["Remarks"].Value.ToString().ToUpper().Trim() == "COMPUTE PAYSLIP")
            {
                dgvpayslip.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                dgvpayslip.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        public static void ComputePayslip(long timesheetid)
        {
            using (dbPayrollEntities db = new dbPayrollEntities())
            {
                tbl_employee_timesheet timesheet = db.tbl_employee_timesheet.Where(s => s.id == timesheetid).SingleOrDefault();
                if (timesheet != null)
                {
                    long EMPID = timesheet.emp_id.Value;
                    tbl_employee_rate rate = db.tbl_employee_rate.Where(s => s.emp_id == EMPID && s.is_active == true).SingleOrDefault(); 

                    decimal monthly_rate = rate != null ? rate.rate.Value : 0m;
                    decimal semi_monthly_rate = monthly_rate / 2;

                    tbl_payslip tblpayslip = new tbl_payslip
                    {
                        emp_id = EMPID,
                        timesheet_id = timesheetid,
                        monthly_rate = monthly_rate,
                        semi_monthly_rate = semi_monthly_rate,
                        datefrom = timesheet.date_from.Value.Date,
                        dateto = timesheet.date_to.Value.Date
                    };

                   tbl_payslip paysliprecord = PayslipModel.Save(tblpayslip);
                   long PAYSLIPID = paysliprecord.id;
                   if (PAYSLIPID > 0)
                   {
                       //USE TO STORE ALL COMPUTATION FROM ADDITIONALS and LESS
                       List<tbl_payslip_detail> listtblpayslipdetail = new List<tbl_payslip_detail>();

                       decimal absences = 0m, undertime = 0m, lates = 0m;
                       decimal absencesamount = 0m, undertimeamount = 0m, latesamount = 0m;
                       decimal overtime = 0m, holiday = 0m;

                       tbl_employee_government government = db.tbl_employee_government.Where(s => s.emp_id == EMPID && (s.has_sss.Value || s.has_pagibig.Value || s.has_philhealth.Value)).SingleOrDefault();
                       List<tbl_loan> loanrecord = db.tbl_loan.Where(s => s.emp_id == EMPID && (timesheet.date_from >= s.effective_date && s.effective_date <= timesheet.date_to)).ToList();
                       var emprate = EmployeeRateModel.GetEmployeeRate(EMPID);


                       decimal EMP_RATE = emprate.rate.Value; //Monthly Rate
                       //GET RATE PER DAY
                       decimal daily_rate = (EMP_RATE * 12) / 313;  ///// 313 = Total Working Days per Year, 12 = Number of Months per Year

                       //GET RATE PER HOUR
                       decimal hourly_rate = daily_rate / 8; /// 8 = Total working hours per Day
                       
                       //GET RATE PER MINUTE                                    
                       decimal minute_rate = (daily_rate / 8) / 60;

                       // COMPUTE ADDITIONALS : OVERTIME and HOLIDAY
                       decimal TotalAdditionalAmount = 0m;
                       tbl_payslip_additionals addtionalsTable = new tbl_payslip_additionals();
                       for (DateTime _date = timesheet.date_from.Value; _date <= timesheet.date_to.Value; _date = _date.AddDays(1))
                       {
                           tbl_dtr dtrrecord = DTRModel.GetEntry(EMPID, _date);
                           if (dtrrecord != null)
                           {
                               decimal AdditionalAmount = 0m;

                               decimal workinghours = dtrrecord.total_duty_hours.Value;

                               decimal TotalOverTimeHours = dtrrecord.total_overtime.Value;


                               //Check if there is OVERTIME
                               //By Identifying if Total Overtime is Greater or Equal to 1hr
                               bool hasOverTime = TotalOverTimeHours >= 1 ? true : false;

                               //Check first if the day is Holiday
                               if (dtrrecord.isHoliday.Value)
                               {
                                   // SET DEFAULT working hours on Holidays is 8hrs.
                                   workinghours = 8;

                                   decimal holiday_percentage = 0m;

                                   //Check if the day is having a Double Holiday
                                   if (HolidayModel.IsDoubleHoliday(_date) == true)
                                   {
                                       //Working on Double Holiday
                                       //Formula : (Hourly rate × 300% × working_hours)
                                       holiday += hourly_rate * 3.00m * workinghours;
                                       holiday_percentage = 3.00m;

                                       addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 3.00m * workinghours), name = "DOUBLE HOLIDAY", dateadded = DateTime.Now };
                                       PayslipAdditionalsModel.Save(addtionalsTable);

                                       if (hasOverTime == true)
                                       {
                                           decimal OverTimeRate = 0m;
                                           if (dtrrecord.isRD.Value == true)
                                           {
                                               //Working on Double Holiday and at the same time Rest Day with Over Time
                                               //Formula : OT Rate = (Hourly rate X 507%)
                                               OverTimeRate = hourly_rate * 5.07m;

                                               overtime = OverTimeRate * TotalOverTimeHours;
                                               addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (OverTimeRate * TotalOverTimeHours), name = "OT RD DOUBLE HOLIDAY", dateadded = DateTime.Now };
                                               PayslipAdditionalsModel.Save(addtionalsTable);
                                           }
                                           else
                                           {
                                               //Working On Double Holiday
                                               //Formula : OT Rate = (hourly rate X 390%)
                                               OverTimeRate = hourly_rate * 3.90m;

                                               overtime = OverTimeRate * TotalOverTimeHours;
                                               addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (OverTimeRate * TotalOverTimeHours), name = "OT DOUBLE HOLIDAY", dateadded = DateTime.Now };
                                               PayslipAdditionalsModel.Save(addtionalsTable);
                                           }
                                       }

                                       AdditionalAmount = (holiday + overtime);
                                   }
                                   else
                                   {
                                       //Get the Detail of the day's Holiday
                                       tbl_holiday holidayrecord = HolidayModel.Get(_date);

                                       //Identify the type of the Holiday. Whether if it is SPECIAL OR REGULAR
                                       if (holidayrecord.type.ToUpper() == "SPECIAL")
                                       {
                                           if (dtrrecord.isRD.Value == false)
                                           {
                                               //Working on SPECIAL HOLIDAY
                                               //Formula : (Hourly rate × 130% × 8 hours)
                                               holiday += hourly_rate * 1.30m * workinghours;
                                               holiday_percentage = 1.30m;
                                               addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.30m * workinghours), name = "SPECIAL HOLIDAY", dateadded = DateTime.Now };
                                               PayslipAdditionalsModel.Save(addtionalsTable);
                                           }
                                           else if (dtrrecord.isRD.Value == true)
                                           {
                                               //Working on SPECIAL HOLIDAY at the same time Rest Day 
                                               //Formula : (Hourly rate × 150% × 8 hours)
                                               holiday += hourly_rate * 1.50m * workinghours;
                                               holiday_percentage = 1.50m;
                                               addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.50m * workinghours), name = "RD SPECIAL HOLIDAY", dateadded = DateTime.Now };
                                               PayslipAdditionalsModel.Save(addtionalsTable);
                                           }

                                           if (hasOverTime == true)
                                           {
                                               decimal OverTimeRate = 0m;
                                               if (dtrrecord.isRD.Value == true)
                                               {
                                                   //Working on SPECIAL HOLIDAY at the same time Rest Day with OVERTIME
                                                   //FORMULA : OT Rate = (Hourly rate X 195%)
                                                   OverTimeRate = hourly_rate * 1.95m;

                                                   overtime = OverTimeRate * TotalOverTimeHours;

                                                   addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.95m), name = "OT RD SPECIAL HOLIDAY", dateadded = DateTime.Now };
                                                   PayslipAdditionalsModel.Save(addtionalsTable);
                                               }
                                               else
                                               {
                                                   //Working on SPECIAL HOLIDAY with OVERTIME
                                                   //Formula : OT RATE = (Hourly rate X 169%)
                                                   OverTimeRate = hourly_rate * 1.69m;

                                                   overtime = OverTimeRate * TotalOverTimeHours;

                                                   addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.69m), name = "OT SPECIAL HOLIDAY", dateadded = DateTime.Now };
                                                   PayslipAdditionalsModel.Save(addtionalsTable);
                                               }
                                           }
                                       }
                                       else if (holidayrecord.type.ToUpper() == "REGULAR")
                                       {
                                           if (dtrrecord.isRD.Value == false) // Working on REGULAR HOLIDAY
                                           {
                                               //Formula : (Hourly rate × 200% × 8 hours)
                                               holiday = hourly_rate * 2.00m * workinghours;
                                               holiday_percentage = 2.00m;

                                               addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 2.00m * workinghours), name = "REGULAR HOLIDAY", dateadded = DateTime.Now };
                                               PayslipAdditionalsModel.Save(addtionalsTable);
                                           }
                                           else if (dtrrecord.isRD.Value == true) //Working on REGULAR HOLIDAY at the same time Rest Day
                                           {
                                               //Formula : (Hourly rate × 260% × 8 hours)
                                               holiday = hourly_rate * 2.60m * workinghours;
                                               holiday_percentage = 2.60m;

                                               addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 2.60m * workinghours), name = "RD REGULAR HOLIDAY", dateadded = DateTime.Now };
                                               PayslipAdditionalsModel.Save(addtionalsTable);
                                           }

                                           if (hasOverTime == true)
                                           {
                                               decimal OverTimeRate = 0m;
                                               if (dtrrecord.isRD.Value == true)
                                               {
                                                   //Working on REGULAR HOLIDAY at the same time Rest Day with OVERTIME
                                                   //Formula : OT Rate = (Hourly rate X 338%)
                                                   OverTimeRate = hourly_rate * 3.38m;

                                                   overtime = OverTimeRate * TotalOverTimeHours;

                                                   addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 3.38m), name = "OT RD REGULAR HOLIDAY", dateadded = DateTime.Now };
                                                   PayslipAdditionalsModel.Save(addtionalsTable);
                                               }
                                               else
                                               {
                                                   //Working on REGULAR HOLIDAY with OVERTIME
                                                   //Formula : OT Rate = (hourly rate X 260%)
                                                   OverTimeRate = hourly_rate * 2.60m;

                                                   overtime = OverTimeRate * TotalOverTimeHours;

                                                   addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 2.60m), name = "OT REGULAR HOLIDAY", dateadded = DateTime.Now };
                                                   PayslipAdditionalsModel.Save(addtionalsTable);
                                               }
                                           }
                                       }
                                   }
                                   AdditionalAmount = holiday + overtime;

                               }
                               else
                               {
                                   if (hasOverTime == true)
                                   {
                                       decimal OverTimeRate = 0m;
                                       if (dtrrecord.isRD.Value == true)
                                       {
                                           //Working on Rest Day with Overtime
                                           //Formula : OT Rate = (hourly rate X 169%)
                                           OverTimeRate = hourly_rate * 1.69m;

                                           overtime = overtime * TotalOverTimeHours;

                                           addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.69m), name = "OT RD", dateadded = DateTime.Now };
                                           PayslipAdditionalsModel.Save(addtionalsTable);

                                       }
                                       else
                                       {
                                           //Working on Ordinary Day with Overtime
                                           //Formula = OT Rate = (hourly rate * 169%)
                                           OverTimeRate = hourly_rate * 1.25m;

                                           overtime = OverTimeRate * TotalOverTimeHours;

                                           addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.25m), name = "OT", dateadded = DateTime.Now };
                                           PayslipAdditionalsModel.Save(addtionalsTable);
                                       }
                                   }

                                   decimal RegularPay = 0m;
                                   if (dtrrecord.isRD.Value == true)
                                   {
                                       //Working on Rest Day 
                                       //Formula : RD Pay = (Hourly rate × 130% × 8 hours)
                                       RegularPay = hourly_rate * 1.30m * 8;

                                       addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * 1.30m * 8), name = "RD", dateadded = DateTime.Now };
                                       PayslipAdditionalsModel.Save(addtionalsTable);
                                   }
                                   else
                                   {
                                       //Working on Ordinary Day
                                       //RegularPay = hourly_rate * (dtrrecord.total_duty_hours.Value > 8 ? 8 : dtrrecord.total_duty_hours.Value);

                                       //addtionalsTable = new tbl_payslip_additionals { payslip_id = PAYSLIPID, amount = (hourly_rate * dtrrecord.total_duty_hours.Value), name = "OT RD", dateadded = DateTime.Now };
                                       //PayslipAdditionalsModel.Save(addtionalsTable);

                                   }

                                   AdditionalAmount = RegularPay + overtime;
                               }

                               TotalAdditionalAmount += AdditionalAmount;

                           }
                       }


                       List<tbl_payslip_less> listLess = new List<tbl_payslip_less>();

                       absences = timesheet.days_absent.Value;
                       undertime = timesheet.undertime.Value;
                       lates = timesheet.lates.Value;

                       //COMPUTE LESS : Less are LATES, UNDERTIME and ABSENCES
                       absencesamount = absences * daily_rate;
                       undertimeamount = undertime * minute_rate;
                       latesamount = lates * minute_rate;

                       listLess.Add(new tbl_payslip_less { payslip_id = PAYSLIPID, name = "ABSENCES", amount = absencesamount, minutes = 0, days = absences });
                       listLess.Add(new tbl_payslip_less { payslip_id = PAYSLIPID, name = "UNDERTIME", amount = undertimeamount, minutes = undertime, days = 0 });
                       listLess.Add(new tbl_payslip_less { payslip_id = PAYSLIPID, name = "LATES", amount = latesamount, minutes = lates, days = 0 });

                       //SAVE LESS
                       foreach (tbl_payslip_less dataLess in listLess)
                       {
                           PayslipLessModel.Save(dataLess);
                       }

                       //GOVERNMENT DEDUCTION
                       decimal sss = 0m, pagibig = 0m, philhealth = 0m;
                       List<GovernmentModel> listGovernmentDeduction = new List<GovernmentModel>();
                       if (government != null)
                       {
                           if (government.has_pagibig.Value)
                           {
                               pagibig = 100;
                           }
                           if (government.has_sss.Value)
                           {
                               var sssmodel = SSSModel.Get();
                               if (emprate.rate >= 15750)
                               {
                                   sss = (decimal)581.30;
                               }
                               else
                               {
                                   sss = sssmodel.Where(s => s.start_range >= emprate.rate && emprate.rate <= s.end_range).Select(s => s.total_contribution_ee).FirstOrDefault().Value;
                               }
                           }
                           if (government.has_philhealth.Value)
                           {
                               if (emprate.rate.Value <= 10000)
                               {
                                   philhealth = (decimal)137.50;
                               }
                               else if (emprate.rate.Value >= 40000)
                               {
                                   philhealth = (decimal)550;
                               }
                               else
                               {
                                   philhealth = emprate.rate.Value * (decimal)2.75;
                               }
                           }
                       }

                       //SAVE GOVERNMENT DEDUCTION
                       listGovernmentDeduction.Add(new GovernmentModel { governmentname = "PAGIBIG", amount = pagibig });
                       listGovernmentDeduction.Add(new GovernmentModel { governmentname = "SSS", amount = sss });
                       listGovernmentDeduction.Add(new GovernmentModel { governmentname = "PhilHealth", amount = philhealth });
                       foreach (GovernmentModel gov in listGovernmentDeduction)
                       {
                           tbl_payslip_government_dedution payslipgovdeduction = new tbl_payslip_government_dedution
                           {
                               payslip_id = PAYSLIPID,
                               government = gov.governmentname,
                               amount = gov.amount
                           };
                           PayslipGovernmentDeductionModel.Save(payslipgovdeduction);
                       }

                       //SAVE LOAN DEDUCTION
                       if (loanrecord.Any())
                       {
                           foreach (var e in loanrecord)
                           {
                               tbl_payslip_loan_deduction paysliploan = new tbl_payslip_loan_deduction
                               {
                                   payslip_id = PAYSLIPID,
                                   amount = e.amount
                               };

                               paysliploan = PayslipLoanDeductionModel.Save(paysliploan);
                           }
                       }
                   }
                }
            }
        }

        //public static decimal ComputeLates()
        //{ 
        
        //}

        //public static decimal ComputeAbsent()
        //{ 
        
        //}
    }
}
