//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayrollSystem.Model.dbEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_dtr
    {
        public long id { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string year { get; set; }
        public Nullable<System.DateTime> check_in { get; set; }
        public Nullable<System.DateTime> check_out { get; set; }
        public Nullable<decimal> total_duty_hours { get; set; }
        public Nullable<decimal> lates { get; set; }
        public Nullable<decimal> undertime { get; set; }
        public Nullable<decimal> total_overtime { get; set; }
        public Nullable<System.DateTime> ot_start { get; set; }
        public Nullable<System.DateTime> ot_end { get; set; }
        public string ot_status { get; set; }
        public Nullable<decimal> holiday_work_hours { get; set; }
        public string holiday_work_status { get; set; }
        public string status { get; set; }
        public Nullable<bool> isHoliday { get; set; }
        public Nullable<bool> isRD { get; set; }
    }
}