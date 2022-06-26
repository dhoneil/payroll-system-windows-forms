using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class PayslipOvertimeModel
    {
        public static tbl_payslip_overtime Save(tbl_payslip_overtime data)
        {
            using (var db = new dbPayrollEntities())
            {
                db.tbl_payslip_overtime.Add(data);
                db.SaveChanges();
                return data;
            }
        }

        public static List<tbl_payslip_overtime> Get(long payslip_id)
        {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip_overtime.Where(s => s.payslip_id == payslip_id).ToList();
            }
        }
    }
}
