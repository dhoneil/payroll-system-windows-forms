using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class PayslipDetailModel
    {
        public static tbl_payslip_detail Save(tbl_payslip_detail data)
        {
            using (var db = new dbPayrollEntities())
            {
                db.tbl_payslip_detail.Add(data);
                db.SaveChanges();
                return data;
            }
        }

        public static List<tbl_payslip_detail> Get(long payslip_id)
        {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip_detail.Where(s => s.payslip_id == payslip_id).ToList();
            }
        }
    }
}
