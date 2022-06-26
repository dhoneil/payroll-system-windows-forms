using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Model
{
    public class SessionModel
    {
        public static long ID { get; set; }
        public static long UserID { get; set; }
        public static string UserType { get; set; }
        public static string userFirstname { get; set; }
        public static string userLastname { get; set; }
        public static string userCompany { get; set; }
        public static string userDepartment { get; set; }
    }
}
