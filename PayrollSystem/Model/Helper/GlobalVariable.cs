using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Model
{
    public class GlobalVariable
    {
        public static long SelectedEmployee { get; set; }
        public static DateTime SelectedDateFrom { get; set; }
        public static DateTime SelectedDateTo { get; set; }
        public static DateTime SelectedDate { get; set; }
        public static long SelectedCompany { get; set; }
        public static long SelectedDepartment { get; set; }
        public static long PayslipID { get; set; }
        public static long TimeSheetID { get; set; }

        public static void UnSetValue()
        {
            SelectedEmployee = 0;
            SelectedCompany = 0;
            SelectedDepartment = 0;
        }
    }
}
