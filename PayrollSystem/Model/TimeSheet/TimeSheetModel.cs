using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;
using System.Data;
using System.Windows.Forms;

namespace PayrollSystem.Model
{
    public class TimeSheetModel
    {
        public static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_employee_timesheet Save(tbl_employee_timesheet data)
        {
            data.preparedby = SessionModel.UserID;
            data.prepared_date = DateTime.Now;
            data.approvedby = SessionModel.UserID;
            data.approved_date = DateTime.Now;
            data.status = "APPROVED";
            db.tbl_employee_timesheet.Add(data);
            db.SaveChanges();
            return data;
        }

        public static bool Update(tbl_employee_timesheet data)
        {
            int id = 0;
            tbl_employee_timesheet record = db.tbl_employee_timesheet.Where(s => s.emp_id.Value == data.emp_id.Value).SingleOrDefault();
            if (record != null)
            {
                if (data.emp_id.HasValue) record.emp_id = data.emp_id;
                if (data.date_from.HasValue) record.date_from = data.date_from;
                if (data.date_to.HasValue) record.date_to = data.date_to;
                if (data.working_days.HasValue) record.working_days = data.working_days;
                if (data.holidays.HasValue) record.holidays = data.holidays;
                if (data.days_absent.HasValue) record.days_absent = data.days_absent;
                if (data.duty_hours.HasValue) record.duty_hours = data.duty_hours;
                if (data.lates.HasValue) record.lates = data.lates;
                if (data.undertime.HasValue) record.undertime = data.undertime;
                if (data.overtime.HasValue) record.overtime = data.overtime;
                if (data.preparedby.HasValue) record.preparedby = data.preparedby;
                if (data.prepared_date.HasValue) record.prepared_date = data.prepared_date;
                if (data.approved_date.HasValue) record.approved_date = data.approved_date;
                if (data.approvedby.HasValue) record.approvedby = data.approvedby;
                if (data.cancelled_date.HasValue) record.cancelled_date = data.cancelled_date;
                if (data.cancelledby.HasValue) record.cancelledby = data.cancelledby;
                if (!String.IsNullOrEmpty(data.status)) record.status = data.status;
                id = db.SaveChanges();
            }
            return id > 0 ? true : false;
        }

        public static bool ApproveTimeSheet(tbl_employee_timesheet data)
        {
            bool flag = false;
            tbl_employee_timesheet record = db.tbl_employee_timesheet.Where(s => s.emp_id.Value == data.emp_id && s.date_from == data.date_from && s.date_to == data.date_to).SingleOrDefault();
            if (record != null)
            {
                flag = CancelTimeSheet(record.emp_id.Value, record.date_from.Value, record.date_to.Value);
            }
            tbl_employee_timesheet res = Save(data);
            flag = res.id > 0 ? true : false;

            return flag;
        }

        public static bool CancelTimeSheet(long empid, DateTime datefrom, DateTime dateto)
        {
            bool flag = false;
            List<tbl_employee_timesheet> record = db.tbl_employee_timesheet.Where(s => s.emp_id.Value == empid && s.date_from == datefrom.Date && s.date_to == dateto && s.status == "APPROVED").ToList();
            foreach (var i in record)
            {
                i.status = "CANCELLED";
                i.cancelledby = SessionModel.UserID;
                i.cancelled_date = DateTime.Now;
                int res = db.SaveChanges();
                flag = res > 0 ? true : false;
            }
            return flag;
        }

        public static List<tbl_employee_timesheet> Get(DateTime datefrom, DateTime dateto)
        {
            IQueryable<tbl_employee_timesheet> res = db.tbl_employee_timesheet.Where(s => s.date_from.Value >= datefrom && s.date_to.Value <= dateto && s.status=="APPROVED");
            return res.ToList();
        }

        public static tbl_employee_timesheet Get(long id)
        {
            return db.tbl_employee_timesheet.Where(s => s.id == id).SingleOrDefault();
        }

        public static List<view_employee_timesheet_list> TimeSheetList(string datefrom = "", string dateto = "")
        {
            IQueryable<view_employee_timesheet_list> res = db.view_employee_timesheet_list;
            if (res.Any())
            {
                if (!String.IsNullOrEmpty(datefrom) && !String.IsNullOrEmpty(dateto)) res = res.Where(s => s.date_from.Value >= Convert.ToDateTime(datefrom) && s.date_to.Value <= Convert.ToDateTime(dateto));
            }
            return res.ToList();
        }

        public static List<tbl_employee_timesheet> GetEmployeeTimeSheetList(long empid, DateTime datefrom, DateTime dateto)
        {
            IQueryable<tbl_employee_timesheet> res = db.tbl_employee_timesheet.Where(s=> s.date_from >= datefrom && s.date_to <= dateto && s.status == "APPROVED");
            if (empid > 0)
                res = res.Where(s => s.emp_id == empid);
            return res.ToList();
        }

        public static tbl_employee_timesheet GetEmployeeTimeSheet(long empid, DateTime datefrom, DateTime dateto)
        {
            tbl_employee_timesheet res = db.tbl_employee_timesheet.Where(s => s.emp_id.Value == empid && (s.date_from >= datefrom && s.date_to <= dateto) && s.status == "APPROVED").SingleOrDefault();
            return res;
        }

        public static DataTable GenerateTimeSheet(long company, long department, DateTime date_from, DateTime date_to)
        {
            DataTable dtDataSource = new DataTable();
            DataColumn dc = new DataColumn("Can Approve?", typeof(bool));
            dtDataSource.Columns.Add(dc);
            dtDataSource.Columns.Add("ID");
            dtDataSource.Columns.Add("Name");
            dtDataSource.Columns.Add("Date Range");
            dtDataSource.Columns.Add("Working Days");
            dtDataSource.Columns.Add("Holidays");
            dtDataSource.Columns.Add("Days Absent");
            dtDataSource.Columns.Add("Duty Hours");
            dtDataSource.Columns.Add("Lates(min)");
            dtDataSource.Columns.Add("Undertime(min)");
            dtDataSource.Columns.Add("Overtime(hr)");

            var employeelist = EmployeeModel.GetAllEmployee();

            if (employeelist.Any())
            {
                employeelist = employeelist.Where(s => s.is_active.Value == true).ToList();
                if (company > 0) employeelist = employeelist.Where(s => s.CompanyId.ZeroNull() == company).ToList();
                if (department > 0) employeelist = employeelist.Where(s => s.DeptId.ZeroNull() == department).ToList();
                foreach (var emp in employeelist)
                {
                    var timesheet = TimeSheetModel.GetEmployeeTimeSheetList(emp.id, date_from, date_to);
                    if (timesheet.Any())
                    {
                        foreach (var ts in timesheet)
                        {
                            DataRow row = dtDataSource.NewRow();
                            row[0] = false;
                            row["ID"] = emp.id;
                            row["Name"] = emp.EmployeeName;
                            row["Date Range"] = date_from.ToShortDateString() + " - " + date_to.ToShortDateString();
                            row["Working Days"] = ts.working_days;
                            row["Holidays"] = ts.holidays;
                            row["Days Absent"] = ts.days_absent;
                            row["Duty Hours"] = ts.duty_hours.Value.ToString("0.00");
                            row["Lates(min)"] = ts.lates.Value.ToString("0");
                            row["Undertime(min)"] = ts.undertime.Value.ToString("0");
                            row["Overtime(hr)"] = ts.overtime.Value.ToString("0.00");

                            dtDataSource.Rows.Add(row);
                        }
                    }
                    else
                    {
                        double workingdays = 0, holidays = 0, total_duty_hours = 0, total_lates = 0, total_undertime = 0, total_overtime = 0, days_absent = 0;

                        int totaldays = (int)(date_to - date_from).TotalDays;
                        for (int x = 0; x < totaldays + 1; x++)
                        {
                            DateTime _date = date_from.AddDays(x);
                            bool isholiday = HolidayModel.IsHoliday(_date);
                            bool isRD = _date.DayOfWeek.ToString().ToUpper() == "SUNDAY" ? true : false;
                            var dtrrecord = DTRModel.GetEntry(emp.id, _date);
                            if (dtrrecord != null)
                            {
                                workingdays++;
                                if (isholiday && isRD)
                                {
                                    holidays++;
                                    workingdays--;
                                }
                                else if (isholiday && isRD == false)
                                {
                                    workingdays--;
                                    holidays++;
                                }
                                else if (isRD && isholiday == false)
                                {
                                    workingdays--;
                                }

                                TimeSpan firstHalf = new TimeSpan(12, 0, 0);
                                TimeSpan secondHalf = new TimeSpan(13, 0, 0);

                                /// FOR SKILL TEST :  IF EMPLOYEE IS HALF DAY
                                if ((dtrrecord.check_in.Value.TimeOfDay >= firstHalf && dtrrecord.check_in.Value.TimeOfDay <= secondHalf) || (dtrrecord.check_out.Value.TimeOfDay >= firstHalf || dtrrecord.check_out.Value.TimeOfDay <= secondHalf))
                                {
                                    days_absent += 0.5;
                                }

                                total_duty_hours += Convert.ToDouble(dtrrecord.total_duty_hours.Value);
                                total_lates += Convert.ToDouble(dtrrecord.lates.Value);
                                total_overtime += Convert.ToDouble(dtrrecord.total_overtime.Value);
                                total_undertime += Convert.ToDouble(dtrrecord.undertime.Value);
                                if ((dtrrecord.isRD.Value && dtrrecord.isHoliday.Value) || (dtrrecord.isHoliday.Value && dtrrecord.isRD.Value == false))
                                {
                                    workingdays++;
                                }
                                else if (dtrrecord.isRD.Value && dtrrecord.isHoliday.Value == false) { workingdays++; }
                            }
                            else {
                                if (isRD == false && isholiday == false) days_absent++;
                            }
                        }

                        DataRow row = dtDataSource.NewRow();
                        row[0] = true;
                        row["ID"] = emp.id;
                        row["Name"] = emp.EmployeeName;
                        row["Date Range"] = date_from.ToShortDateString() + " - " + date_to.ToShortDateString();
                        row["Working Days"] = workingdays;
                        row["Holidays"] = holidays;
                        row["Days Absent"] = days_absent;
                        row["Duty Hours"] = total_duty_hours.ToString("0.00");
                        row["Lates(min)"] = total_lates.ToString("0.00");
                        row["Undertime(min)"] = total_undertime.ToString("0");
                        row["Overtime(hr)"] = total_overtime.ToString("0");

                        dtDataSource.Rows.Add(row);
                    }
                }
            }

            return dtDataSource;
        }
    }
}
