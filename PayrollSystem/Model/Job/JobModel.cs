using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    public class JobModel
    {
        public static dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_jobs Save(tbl_jobs j)
        {
            j.is_active = true;
            db.tbl_jobs.Add(j);
            db.SaveChanges();
            return j;
        }

        public static List<view_job_list> GetList()
        {
            return db.view_job_list.ToList();
        }

        public static List<tbl_jobs> Get(long company, long department)
        {
            return db.tbl_jobs.Where(s => s.company == company && s.department == department).ToList();
        }

        public static List<view_job_list> Search(string searchkey)
        {
            IQueryable<view_job_list> src = db.view_job_list.Where(s => s.CompanyName.Contains(searchkey) || s.DepartmentName.Contains(searchkey) || s.JobName.Contains(searchkey));
            return src.ToList();
        }
        public static tbl_jobs GetbyID(long id)
        {
            tbl_jobs src = db.tbl_jobs.Single(s => s.id == id);
            return src;
        }
        public static tbl_jobs Update(tbl_jobs data)
        {
            tbl_jobs src = db.tbl_jobs.Single(s => s.id == data.id);
            src.company = data.company;
            src.department = data.department;
            src.name = data.name;
            db.SaveChanges();
            return data;
        }
    }
}
