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
    
    public partial class tbl_holiday
    {
        public long id { get; set; }
        public string holiday_name { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string type { get; set; }
        public Nullable<bool> is_active { get; set; }
    }
}
