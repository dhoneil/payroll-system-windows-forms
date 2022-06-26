using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class PayslipAdditionalsModel
    {
        public static tbl_payslip_additionals Save(tbl_payslip_additionals data)
        {
            using (var db = new dbPayrollEntities())
            {
                data.addedby = SessionModel.UserID;
                data.dateadded = DateTime.Now;
                db.tbl_payslip_additionals.Add(data);
                db.SaveChanges();

                return data;
            }
        }

        public static List<tbl_payslip_additionals> Get(long PayslipID)
        {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip_additionals.Where(s => s.payslip_id == PayslipID).ToList();
            }
        }
    }
}
