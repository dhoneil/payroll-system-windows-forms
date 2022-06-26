using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using System.Data;

namespace PayrollSystem.Model
{
    public class EmployeeModel
    {
        static dbPayrollEntities db;

        public static List<View_Employee> GetAllEmployee()
        {
            db = new dbPayrollEntities();
            IQueryable<View_Employee> emp = db.View_Employee.OrderBy(s => s.lastname);
            return emp.ToList();
        }

        public static tbl_employee Get(long id)
        {
            db = new dbPayrollEntities();
            tbl_employee record = db.tbl_employee.Where(s => s.id == id).SingleOrDefault();
            return record;
        }

        public static View_Employee GetEmployeeById(long id)
        {
            db = new dbPayrollEntities();
            View_Employee query = db.View_Employee.Where(s => s.id == id).SingleOrDefault();
            return query;
        }

        public static List<view_employee_list_v2> getList()
        {
            db = new dbPayrollEntities();
            IQueryable<view_employee_list_v2> query = db.view_employee_list_v2;
            return query.ToList();
        }

        public static List<View_Employee> GetList(long company = 0, long department = 0, long empid = 0)
        {
            db = new dbPayrollEntities();
            IQueryable<View_Employee> res = db.View_Employee;
            if (company > 0) res = res.Where(s => s.company == company);
            if (department > 0) res = res.Where(s => s.department == department);
            if (empid > 0) res = res.Where(s => s.id == empid);
            return res.OrderBy(s => s.lastname).ToList();
        }

        public static List<View_Employee> GetEmployee()
        {
            db = new dbPayrollEntities();
            var res = db.View_Employee.OrderBy(s => s.lastname);
            return res.ToList();
        }

        public static List<view_employee_list_v2> SearchEmployee(string input)
        {
            db = new dbPayrollEntities();
            IQueryable<view_employee_list_v2> searchemp = db.view_employee_list_v2.Where(s => s.EmployeeName.Contains(input));
            //searchemp = searchemp.Where(s=>s.is_active.Value==true);

            return searchemp.ToList();
        }
        public tbl_employee Save(tbl_employee e)
        {
            db = new dbPayrollEntities();
            e.is_active = true;
            e.status = "Active";
            db.tbl_employee.Add(e);
            db.SaveChanges();
            return e;
        }
        public static bool Update(tbl_employee e)
        {
            db = new dbPayrollEntities();
            tbl_employee record = db.tbl_employee.Single(s => s.id == e.id);
            if (!String.IsNullOrEmpty(e.firstname)) record.firstname = e.firstname;
            if (!String.IsNullOrEmpty(e.middlename)) record.middlename = e.middlename;
            if (!String.IsNullOrEmpty(e.lastname)) record.lastname = e.lastname;
            if (!String.IsNullOrEmpty(e.email)) record.email = e.email;
            if (e.is_active.HasValue) record.is_active = e.is_active;
            if (e.company.HasValue) record.company = e.company;
            if (e.department.HasValue) record.department = e.department;
            if (e.job_id.HasValue) record.job_id = e.job_id;
            if (!String.IsNullOrEmpty(e.address)) record.address = e.address;
            if (e.birthdate.HasValue) record.birthdate = e.birthdate;
            if (!String.IsNullOrEmpty(e.civil_status)) record.civil_status = e.civil_status;
            if (!String.IsNullOrEmpty(e.gender)) record.gender = e.gender;
            if (!String.IsNullOrEmpty(e.usertype)) record.usertype = e.usertype;
            if (!String.IsNullOrEmpty(e.status)) record.status = e.status;
            db.SaveChanges();
            long res = record.id;

            return res > 0 ? true : false;
        }

        public List<tbl_employee> Get(tbl_employee e = null)
        {
            db = new dbPayrollEntities();
            List<tbl_employee> result = db.tbl_employee.ToList();
            if (e.id > 0) result = result.Where(s=> s.id == e.id).ToList();
            if (e.is_active.HasValue) result = result.Where(s => s.is_active == e.is_active.Value).ToList();

            return result;
        }

        public static DataTable GenerateEmployee(string search = "")
        {
            db = new dbPayrollEntities();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Company");
            dt.Columns.Add("Department");
            dt.Columns.Add("Job");
            dt.Columns.Add("Active?");
            List<View_Employee> record = EmployeeModel.GetList();
            if (!String.IsNullOrEmpty(search))
            {
                string[] arrsearch = search.Trim().Split(' ');
                foreach (string i in arrsearch)
                {
                    record = record.Where(s => s.firstname.ToLower().Contains(i.ToLower()) || s.lastname.ToLower().Contains(i.ToLower())).ToList();
                }
            }
            record = record.OrderBy(s => s.lastname).ToList();
            if (record.Any())
            {
                foreach (var i in record)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = i.id;
                    row["Name"] = i.EmployeeName;
                    row["Company"] = i.Company_Name;
                    row["Department"] = i.Department_Name;
                    row["Job"] = i.JobName;
                    string status = string.Empty;
                    if (i.is_active.HasValue)
                        status = i.is_active.Value ? "Yes" : "No";
                    row["Active?"] = status;

                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
    }
}
