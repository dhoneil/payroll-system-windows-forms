using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;

namespace PayrollSystem.Model
{
    class SSSModel
    {
        static dbPayrollEntities db = new dbPayrollEntities();

        public static List<tbl_sss_contribution> Get()
        {
            return db.tbl_sss_contribution.ToList();
        }
    }
}
