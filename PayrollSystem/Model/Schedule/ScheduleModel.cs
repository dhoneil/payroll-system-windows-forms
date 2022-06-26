using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;

namespace PayrollSystem.Model
{
    public class ScheduleModel
    {
        static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_schedule Save(tbl_schedule d)
        {
            db.tbl_schedule.Add(d);
            db.SaveChanges();
            return d;
        }

        public static List<tbl_schedule> Get()
        {
            return db.tbl_schedule.ToList();
        }

        public static tbl_schedule GetById(long id)
        {
            return db.tbl_schedule.Where(s => s.id == id).SingleOrDefault();
        }
    }
}
