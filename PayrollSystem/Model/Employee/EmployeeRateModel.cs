using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    class EmployeeRateModel
    {
        static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_employee_rate Save(tbl_employee_rate data)
        {
            data.is_active = true;
            data.effective_date = DateTime.Now;
            db.tbl_employee_rate.Add(data);
            db.SaveChanges();
            return data;
        }

        public static bool Update(long empid, decimal rate)
        {
            tbl_employee_rate records = db.tbl_employee_rate.Where(s => s.emp_id == empid).FirstOrDefault();
            records.rate = rate;
            int res = db.SaveChanges();
            return res > 0 ? true : false;
        }

        public static List<tbl_employee_rate> Get(long empid = 0)
        {
            IQueryable<tbl_employee_rate> res = db.tbl_employee_rate;
            if (empid > 0)
                res = res.Where(s => s.emp_id == empid);
            return res.ToList();
        }
        
        public static tbl_employee_rate GetEmployeeRate(long empid)
        {
            tbl_employee_rate res = db.tbl_employee_rate.Where(s => s.emp_id == empid && s.is_active == true).FirstOrDefault();
            return res;
        }

        public static List<tbl_employee_rate> Get()
        {
            return db.tbl_employee_rate.ToList();
        }
    }
}
