using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class PayslipLessModel
    {
        public static tbl_payslip_less Save(tbl_payslip_less data)
        {
            using (var db = new dbPayrollEntities())
            {
                db.tbl_payslip_less.Add(data);
                db.SaveChanges();
                return data;
            }
        }

        public static List<tbl_payslip_less> Get(long PayslipID)
        {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip_less.Where(s => s.payslip_id == PayslipID).ToList();
            }
        }
    }
}
