using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    public class EmployeeAccountModel
    {
        dbPayrollEntities db = new dbPayrollEntities();
        public tbl_employee_account Save(tbl_employee_account accountdata)
        {
            db.tbl_employee_account.Add(accountdata);
            db.SaveChanges();
            return accountdata;
        }

        public bool UsernameExist(string username)
        {
            List<tbl_employee_account> query = db.tbl_employee_account.Where(s => s.username.ToLower() == username).ToList();
            return (query.Count > 0 && query != null) ? true : false;
        }
    }
}
