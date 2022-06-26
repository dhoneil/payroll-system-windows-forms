using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;
using System.Data;

namespace PayrollSystem.Model
{
    public class GovernmentModel
    {
        public string governmentname { get; set; }
        public decimal amount { get; set; }
        static dbPayrollEntities db;

        public static tbl_employee_government Save(tbl_employee_government data)
        {
            db = new dbPayrollEntities();
            db.tbl_employee_government.Add(data);
            db.SaveChanges();
            return data;
        }

        public static bool Update(tbl_employee_government data)
        {
            db = new dbPayrollEntities();
            tbl_employee_government record = db.tbl_employee_government.Where(s => s.emp_id == data.emp_id).SingleOrDefault();
            int res = 0;
            if (record != null)
            {
                record.has_sss = data.has_sss;
                record.has_philhealth = data.has_philhealth;
                record.has_pagibig = data.has_pagibig;
                record.sss_number = data.sss_number;
                record.philhealth_number = data.philhealth_number;
                record.pagibig_number = data.pagibig_number;
                res = db.SaveChanges();
            }
            return res > 0 ? true : false;
        }

        public static tbl_employee_government Get(long empid)
        {
            db = new dbPayrollEntities();
            tbl_employee_government res = db.tbl_employee_government.Where(s => s.emp_id == empid).FirstOrDefault();
            return res;
        }

        public static DataTable GenerateEmployeeGovernment(long company=0, long department =0, long empid = 0)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("SSS");
            dt.Columns.Add("Philhealth");
            dt.Columns.Add("PAG-IBIG");

            var sss_contribution = SSSModel.Get();
            var employeelist = EmployeeModel.GetList(company, department, empid);
            if (employeelist.Any())
            {
                foreach (var emp in employeelist)
                {
                    string sss = string.Empty;
                    string philhealth = string.Empty;
                    string pagibig = string.Empty;
                    decimal? _sss = null;
                    decimal? _philhealth = null;
                    decimal? _pagibig = null;
                    var empgovernment = GovernmentModel.Get(emp.id);
                    var emprate = EmployeeRateModel.GetEmployeeRate(emp.id);
                    if (emprate != null)
                    {
                        if (empgovernment != null)
                        {
                            if (empgovernment.has_sss.Value)
                            {
                                if (emprate.rate >= 15750)
                                    _sss = (decimal)581.30;
                                else
                                    _sss = sss_contribution.Where(s => s.start_range >= emprate.rate && emprate.rate <= s.end_range).Select(s => s.total_contribution_ee).FirstOrDefault();
                            }
                            //sss_ee = _sss_ee.HasValue ? _sss_ee.Value.ToString("0.00") : "No SSS Deduction";
                            if (empgovernment.has_philhealth.Value)
                            {
                                if (emprate.rate.Value <= 10000) _philhealth = (decimal)137.50;
                                else if (emprate.rate.Value >= 40000) _philhealth = (decimal)550;
                                else _philhealth = emprate.rate * (decimal)2.75;
                            }
                            if (empgovernment.has_pagibig.Value) _pagibig = 100;
                        }
                    }

                    sss = _sss.HasValue ? _sss.Value.ToString("0,0.00") : "No Deduction";
                    philhealth = _philhealth.HasValue ? _philhealth.Value.ToString("0,0.00") : "No Deduction";
                    pagibig = _pagibig.HasValue ? _pagibig.Value.ToString("0,0.00") : "No Deduction";

                    DataRow row = dt.NewRow();
                    row["ID"] = emp.id;
                    row["Name"] = emp.EmployeeName;
                    row["SSS"] = sss;
                    row["Philhealth"] = philhealth;
                    row["PAG-IBIG"] = pagibig;

                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
    }
}
