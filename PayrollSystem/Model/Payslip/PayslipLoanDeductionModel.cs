using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class PayslipLoanDeductionModel
    {
        public static tbl_payslip_loan_deduction Save(tbl_payslip_loan_deduction data)
        {
            using (var db = new dbPayrollEntities())
            {
                db.tbl_payslip_loan_deduction.Add(data);
                return data;
            }
        }

        public static List<tbl_payslip_loan_deduction> Get(long PayslipID)
        {
            using (var db = new dbPayrollEntities())
            {
                return db.tbl_payslip_loan_deduction.Where(s => s.payslip_id == PayslipID).ToList();
            }
        }
    }
}
