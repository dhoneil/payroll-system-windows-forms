using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;
using System.Data;

namespace PayrollSystem.Model
{
    public class SeedFundDeduction
    {
        static dbPayrollEntities db = new dbPayrollEntities();
        public static tbl_loan Save(tbl_loan data)
        {
            data.preparedby = SessionModel.UserID;
            data.dateprepared = DateTime.Now;
            data.status = "FOR RELEASE";
            db.tbl_loan.Add(data);
            db.SaveChanges();
            return data;
        }

        public static List<tbl_loan>Get(long id = 0)
        {
            IQueryable<tbl_loan> query = db.tbl_loan;
            if (id > 0) query = query.Where(s => s.id == id);
            return query.ToList();
        }

        public static List<view_employee_loan> GetList()
        {
            List<view_employee_loan> res = db.view_employee_loan.ToList();
            return res;
        }

        public static bool Release(long id)
        {
            tbl_loan record = db.tbl_loan.Single(s => s.id == id);
            int res = 0;
            if (record != null)
            {
                record.releasedby = SessionModel.UserID;
                record.datereleased = DateTime.Now;
                record.status = "RELEASED";
                res = db.SaveChanges();
            }

            return res > 0 ? true : false;
        }

        public static bool Void(long id)
        {
            tbl_loan record = db.tbl_loan.Single(s => s.id == id);
            int res = 0;
            if (record != null)
            {
                record.voidby = SessionModel.UserID;
                record.datevoid = DateTime.Now;
                record.status = "VOID";
                res = db.SaveChanges();
            }

            return res > 0 ? true : false;
        }

        public static DataTable GenerateEmployeeLoan()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Employee");
            dt.Columns.Add("Company");
            dt.Columns.Add("Department");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Status");
            dt.Columns.Add("Remarks");

            var employeeloan = SeedFundDeduction.GetList();
            if (employeeloan.Any())
            {
                foreach (var i in employeeloan)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = i.id;
                    row["Employee"] = i.EmployeeName;
                    row["Company"] = i.Company;
                    row["Department"] = i.Department;
                    row["Amount"] = i.amount.HasValue ? i.amount.Value.ToString("0,0.00") : "";
                    string remarks = String.Format("Prepared By: {0} \n Released By : {1} \n Void By: {2}",i.PreparedByName, i.ReleasedByName, i.VoidByName);
                    string status = i.status;
                    //if (i.preparedby.HasValue) remarks += String.Format("Prepared By: {0}", i.PreparedByName);
                    //if (i.releasedby.HasValue) remarks += String.Format("\n Released By: {0}", i.ReleasedByName);
                    //if (i.voidby.HasValue) remarks += String.Format("\n Void By: {0}", i.VoidByName);

                    row["Status"] = status.ToUpper();
                    row["Remarks"] = remarks;

                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
    }
}
