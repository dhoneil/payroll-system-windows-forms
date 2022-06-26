using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;

namespace PayrollSystem.Model
{
    public class CompanyModel
    {
        public static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_company Save(tbl_company c)
        {
            c.is_active = true;
            db.tbl_company.Add(c);
            db.SaveChanges();
            return c;
        }

        public static List<tbl_company> GetList()
        {
            return db.tbl_company.Where(s => s.is_active.Value == true).ToList();
        }

        public static List<tbl_company> Search(string searchkey)
        {
            IQueryable<tbl_company> src = db.tbl_company.Where(s => s.name.Contains(searchkey) || s.address.Contains(searchkey));
            return src.ToList();
        }

        public static tbl_company Update(tbl_company data)
        {
            tbl_company src = db.tbl_company.Single(s => s.id == data.id);
            src.name = data.name;
            src.address = data.address;
            db.SaveChanges();
            return data;
        }
    }
}
