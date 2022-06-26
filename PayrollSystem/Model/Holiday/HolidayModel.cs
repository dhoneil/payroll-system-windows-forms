using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;

namespace PayrollSystem.Model
{
    public class HolidayModel
    {
        static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_holiday Save(tbl_holiday d)
        {
            d.is_active = true;
            db.tbl_holiday.Add(d);
            db.SaveChanges();
            return d;
        }

        public static List<tbl_holiday> Get(DateTime? datefrom = null, DateTime? dateto = null )
        {
            IQueryable<tbl_holiday> res = db.tbl_holiday;
            if (datefrom.HasValue && dateto.HasValue)
            {
                res = res.Where(s => s.date >= datefrom && s.date <= dateto);
            }
            return res.ToList();
        }

        public static tbl_holiday Get(DateTime date)
        {
            return db.tbl_holiday.Where(s => s.date.Value.Date == date.Date).SingleOrDefault();
        }

        public static bool IsDoubleHoliday(DateTime date)
        {
            List<tbl_holiday> res = db.tbl_holiday.Where(s => s.date.Value.Date == date.Date).ToList();

            return res.Count() == 2 ? true : false;
        }

        public static bool Inactive(long id)
        {
            tbl_holiday record = db.tbl_holiday.Single(s => s.id == id);
            record.is_active = false;

            int res = db.SaveChanges();
            return res > 0 ? true : false;
        }

        public static bool IsHoliday(DateTime data)
        {
            List<tbl_holiday> query = db.tbl_holiday.ToList();
            if (query.Any())
            {
                query = query.Where(s => s.date.Value.Date == data.Date).ToList();
                if (query.Any()) return true;
            }
            return false;
        }
    }
}
