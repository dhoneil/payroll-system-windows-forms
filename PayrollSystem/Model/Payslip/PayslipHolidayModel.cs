using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class PayslipHolidayModel
    {
        public static tbl_payslip_holiday Save(tbl_payslip_holiday data)
        {
            using(var db = new dbPayrollEntities())
            {
                db.tbl_payslip_holiday.Add(data);
                db.SaveChanges();
                return data;
            }
        }

        public static List<tbl_payslip_holiday> Get(long payslip_id)
        {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip_holiday.Where(s => s.payslip_id == payslip_id).ToList();
            }
        }
    }
}
