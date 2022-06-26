using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;

namespace PayrollSystem.Model
{
    public class PayslipGovernmentDeductionModel
    {
        static dbPayrollEntities db;

        public static tbl_payslip_government_dedution Save(tbl_payslip_government_dedution data)
        {
            db = new dbPayrollEntities();
            db.tbl_payslip_government_dedution.Add(data);
            db.SaveChanges();
            return data;
        }

        public static tbl_payslip_government_dedution Update(tbl_payslip_government_dedution data)
        { 
            db= new dbPayrollEntities ();
            tbl_payslip_government_dedution record = db.tbl_payslip_government_dedution.Where(s => s.id == data.id).Single();
            if (data.amount.HasValue) record.amount = data.amount;
            db.SaveChanges();
            return record;
        }

        public static List<tbl_payslip_government_dedution> GetList(long payslipID)
        {
            db = new dbPayrollEntities();
            return db.tbl_payslip_government_dedution.Where(s => s.payslip_id == payslipID).ToList();
        }

        public static List<tbl_payslip_government_dedution> Get(long PayslipID)
        {
            db = new dbPayrollEntities();
            return db.tbl_payslip_government_dedution.Where(s => s.payslip_id == PayslipID).ToList();
        }
    }
}
