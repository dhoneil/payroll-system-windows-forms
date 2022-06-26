using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystem.Model.dbEntity;
using System.Security.Cryptography;
using System.Drawing;

namespace PayrollSystem.Model
{
    public class AccountModel
    {
        dbPayrollEntities db = new dbPayrollEntities();

        public static tbl_employee_account Save(tbl_employee_account a)
        {
            dbPayrollEntities db = new dbPayrollEntities();
            a.is_active = true;
            db.tbl_employee_account.Add(a);
            db.SaveChanges();
            return a;
        }

        public static List<view_user_account_list> GetList()
        {
            dbPayrollEntities db = new dbPayrollEntities ();
            return db.view_user_account_list.ToList();
        }

        public static List<view_employee_no_user_account> EmployeeNoAccountList()
        {
            dbPayrollEntities db = new dbPayrollEntities();
            return db.view_employee_no_user_account.ToList();
        }

        public static bool UsernameExist(string username)
        {
            dbPayrollEntities db = new dbPayrollEntities();
            List<tbl_employee_account> query = db.tbl_employee_account.Where(s => s.username.ToLower() == username.ToLower()).ToList();
            return (query.Count > 0 && query != null) ? true : false;
        }

        public long? LogIn(string username, string password)
        {
            long? id = null;
            string encryptedpassword = DataSecurity.EncryptText(username, password);
            if (db.tbl_employee_account.Any())
            {
                tbl_employee_account res = db.tbl_employee_account.Where(s => s.username.ToLower() == username.ToLower() && s.password == encryptedpassword).FirstOrDefault();
                id = res != null ? res.emp_id.Value : 0;
            }
            return id;
        }

        public tbl_employee_account LogInUser(string username, string password)
        {
            tbl_employee_account res = new tbl_employee_account();
            string encryptedpassword = DataSecurity.EncryptText(username, password);
            if (db.tbl_employee_account.Any())
            {
                 res = db.tbl_employee_account.Where(s => s.username.ToLower() == username.ToLower() && s.password == encryptedpassword).FirstOrDefault();
            }

            return res;
        }


        public static void logout()
        {
            SessionModel.ID = 0;

            var form = SettingWinForm.CurrentForm;
            usercontrolLogIn mainview = new usercontrolLogIn();
            mainview.Location = new Point(0, 5);

            form.Size = new Size(mainview.Width, mainview.Height);
            form.Controls.Clear();
            form.Controls.Add(mainview);
        }
    }
}
