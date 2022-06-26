using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class employee_accountModel
    {
        static dbPayrollEntities db = new dbPayrollEntities();
        public static tbl_employee_account Save(tbl_employee_account empacc)
        {
            db.tbl_employee_account.Add(empacc);
            return empacc;
        }
    }
}
