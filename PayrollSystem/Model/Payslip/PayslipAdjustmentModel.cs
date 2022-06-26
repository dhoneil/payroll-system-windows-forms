using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    public class PayslipAdjustmentModel
    {
        static dbPayrollEntities db;

        public static tbl_payslip_adjustment Save(tbl_payslip_adjustment data)
        {
            db = new dbPayrollEntities();
            data.status = "APPROVED";
            db.tbl_payslip_adjustment.Add(data);
            db.SaveChanges();
            return data;
        }

        public static tbl_payslip_adjustment Update(tbl_payslip_adjustment data)
        {
            db = new dbPayrollEntities();
            tbl_payslip_adjustment record = db.tbl_payslip_adjustment.Where(s => s.id == data.id).Single();
            if (data.amount.HasValue) record.amount = data.amount;
            if (!String.IsNullOrEmpty(data.adjustment)) record.adjustment = data.adjustment;
            db.SaveChanges();
            return record;
        }

        public static bool Void(long id)
        {
            db = new dbPayrollEntities();
            tbl_payslip_adjustment record = db.tbl_payslip_adjustment.Where(s => s.id == id).Single();
            record.status = "VOID";
            int res = db.SaveChanges();
            return res > 0 ? true : false;
        }

        public static List<tbl_payslip_adjustment> GetList(long payslipid, string status = "APPROVED")
        {
            db = new dbPayrollEntities();
            List<tbl_payslip_adjustment> result = db.tbl_payslip_adjustment.Where(s => s.payslip_id == payslipid && s.status == "APPROVED").ToList();
            return result;
        }

        public static tbl_payslip_adjustment Get(long id)
        {
            db = new dbPayrollEntities();
            return db.tbl_payslip_adjustment.Where(s => s.id == id).SingleOrDefault();
        }

    }
}
