using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.Model
{
    public class AccountType
    {
        dbPayrollEntities db = new dbPayrollEntities();

        public tbl_account_type Add(tbl_account_type type)
        {
            tbl_account_type res = db.tbl_account_type.Add(type);
            return res;
        }

        public List<tbl_account_type> Get(tbl_account_type type)
        {
            List<tbl_account_type> query = null;
            query = db.tbl_account_type.ToList();
            //if (query != null) {
            //    if (type.id > 0) query = query.Where(s => s.id == type.id).ToList();
            //}
            return query;
        }
    }
}
