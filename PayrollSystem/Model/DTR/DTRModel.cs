using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data;

namespace PayrollSystem
{
    public class DTRModel
    {
        static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_dtr Save(tbl_dtr data)
        {
            data.status = "APPROVED";
            db.tbl_dtr.Add(data);
            db.SaveChanges();
            return data;
        }

        public static tbl_dtr GetEntry(long empID, DateTime date)
        {
            return db.tbl_dtr.Where(s => s.emp_id == empID && DbFunctions.TruncateTime(s.date).Value == DbFunctions.TruncateTime(date)).SingleOrDefault();
        }

        public static List<tbl_dtr> Get()
        {
            return db.tbl_dtr.ToList();
        }

        public static IQueryable<tbl_dtr> GetEmployeeDTR(long empID, DateTime date)
        {
            IQueryable<tbl_dtr> result = db.tbl_dtr;
            if (result.Any())
            {
                result = result.Where(s => s.emp_id == empID && DbFunctions.TruncateTime(s.date).Value == date.Date);
            }
            return result;
        }

        public static bool HasDTR(long empid, DateTime datefrom, DateTime dateto)
        {
            bool flag = false;
            List<tbl_dtr> query = db.tbl_dtr.Where(s => s.emp_id == empid && (datefrom.Date >= DbFunctions.TruncateTime(s.date).Value && DbFunctions.TruncateTime(s.date.Value).Value <= dateto.Date)).ToList();
            if (query.Any()) flag = true;
            return flag;
        }

        public static bool UpdateEntry(tbl_dtr data)
        {
            tbl_dtr query = db.tbl_dtr.Single(s => s.emp_id == data.emp_id && DbFunctions.TruncateTime(s.date).Value == DbFunctions.TruncateTime(data.date).Value);
            if (data.check_in.HasValue) query.check_in = data.check_in.Value;
            if (data.check_out.HasValue) query.check_out = data.check_out.Value;
            if (!String.IsNullOrEmpty(data.year)) query.year = data.year;
            if (data.total_duty_hours.HasValue) query.total_duty_hours = data.total_duty_hours.Value;
            if (data.lates.HasValue) query.lates = data.lates.Value;
            if (data.undertime.HasValue) query.undertime = data.undertime.Value;
            if (data.total_overtime.HasValue) query.total_overtime = data.total_overtime.Value;
            if (data.holiday_work_hours.HasValue) query.holiday_work_hours = data.holiday_work_hours.Value;
            if (!String.IsNullOrEmpty(data.status)) query.status = data.status;
            if (data.isRD.HasValue) query.isRD = data.isRD;
            if (data.isHoliday.HasValue) query.isHoliday = data.isHoliday;
            int res = db.SaveChanges();

            return res > 0 ? true : false;
        }

        public static DataTable GenerateDTR(DateTime datestart, DateTime dateend, long empid)
        {
            DataTable dtsource = new DataTable();
            dtsource.Columns.Add("Date");
            dtsource.Columns.Add("Day");
            dtsource.Columns.Add("Remarks");
            dtsource.Columns.Add("In");
            dtsource.Columns.Add("Out");
            dtsource.Columns.Add("Total(hr)");
            dtsource.Columns.Add("Lates(min)");
            dtsource.Columns.Add("Undertime(min)");
            dtsource.Columns.Add("Overtime(hr)");
            dtsource.Columns.Add("Holiday(hr)");

            int totaldays = (int)(dateend - datestart).TotalDays;
            for (int i = 0; i < totaldays + 1; i++)
            {
                DateTime addedDate = datestart.AddDays(i);
                string date = addedDate.ToShortDateString();
                string day = addedDate.ToString("ddd").ToUpper();

                var dtr_result = DTRModel.GetEmployeeDTR(empid, addedDate);
                string timein = string.Empty;
                string timeout = string.Empty;
                decimal dutyhours = 0, lates = 0, undertime = 0, overtime = 0, holiday = 0;
                string remarks = string.Empty;
                string undertime_status = string.Empty, overtime_status = string.Empty, holiday_status = string.Empty;
                bool isholiday = HolidayModel.IsHoliday(addedDate);

                DataRow row = dtsource.NewRow();
                remarks = day == "SUN" ? "RD" : isholiday ? "HLD" : string.Empty;
                if (dtr_result.ToList().Any())
                {
                    tbl_dtr dtrrecord = DTRModel.GetEntry(empid, addedDate);
                    remarks = dtrrecord.check_in.HasValue && dtrrecord.check_out.HasValue ? (remarks != string.Empty ? (remarks + "/") : "") + "P" : "A";
                    row["Date"] = dtrrecord.date.Value.ToShortDateString();
                    row["Day"] = dtrrecord.date.Value.ToString("ddd").ToUpper();
                    row["Remarks"] = remarks;
                    row["In"] = dtrrecord.check_in.HasValue ? dtrrecord.check_in.Value.ToString("HH:mm") : " - ";
                    row["Out"] = dtrrecord.check_out.HasValue ? dtrrecord.check_out.Value.ToString("HH:mm") : " - ";
                    row["Total(hr)"] = dtrrecord.total_duty_hours.HasValue ? (dtrrecord.total_duty_hours.Value).ToString("0.00") : "0";
                    row["Lates(min)"] = dtrrecord.lates.HasValue ? (dtrrecord.lates.Value).ToString("0.00") : "0";
                    row["Undertime(min)"] = dtrrecord.undertime.HasValue ? dtrrecord.undertime.Value.ToString("0") : "0";
                    row["Overtime(hr)"] = dtrrecord.total_overtime.HasValue ? (dtrrecord.total_overtime.Value).ToString("0.00") : "0";
                    row["Holiday(hr)"] = dtrrecord.holiday_work_hours.HasValue ? (dtrrecord.holiday_work_hours.Value).ToString("0.00") : "0";
                }
                else
                {
                    row["Date"] = date;
                    row["Day"] = day;
                    row["Remarks"] = remarks != string.Empty ? remarks : "A";
                    row["In"] = timein;
                    row["Out"] = timeout;
                    row["Total(hr)"] = dutyhours;
                    row["Lates(min)"] = lates;
                    row["Undertime(min)"] = undertime;
                    row["Overtime(hr)"] = overtime;
                    row["Holiday(hr)"] = holiday;
                }
                dtsource.Rows.Add(row);
            }

            return dtsource;
        }
    }
}
