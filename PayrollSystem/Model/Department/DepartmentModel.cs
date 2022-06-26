using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    public class DepartmentModel
    {
        public static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_department Save(tbl_department d)
        {
            d.is_active = true;
            db.tbl_department.Add(d);
            db.SaveChanges();
            return d;
        }

        public static List<view_department_list> GetList(long id = 0, long company = 0)
        {
            IQueryable<view_department_list> query = db.view_department_list;
            if (id > 0) query = query.Where(s => s.DepartmentID == id);
            if (company > 0) query = query.Where(s => s.CompanyID == company);
            return query.ToList();
        }
        public static List<tbl_department> GetListv2()
        {
            return db.tbl_department.Where(s => s.is_active.Value == true).ToList();
        }

        public static List<view_department_list> Search(string searchkey)
        {
            IQueryable<view_department_list> src = db.view_department_list.Where(s => s.DepartmentName.Contains(searchkey) || s.CompanyName.Contains(searchkey));
            return src.ToList();
        }

        public static tbl_department Update(tbl_department data)
        {
            tbl_department src = db.tbl_department.Single(s => s.id == data.id);
            src.name = data.name;
            src.company = data.company;
            db.SaveChanges();
            return data;
        }
    }
}
