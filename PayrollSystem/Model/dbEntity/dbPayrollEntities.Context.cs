﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbPayrollEntities : DbContext
    {
        public dbPayrollEntities()
            : base("name=dbPayrollEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_account_type> tbl_account_type { get; set; }
        public virtual DbSet<tbl_attendance> tbl_attendance { get; set; }
        public virtual DbSet<tbl_company> tbl_company { get; set; }
        public virtual DbSet<tbl_department> tbl_department { get; set; }
        public virtual DbSet<tbl_dtr> tbl_dtr { get; set; }
        public virtual DbSet<tbl_employee> tbl_employee { get; set; }
        public virtual DbSet<tbl_employee_government> tbl_employee_government { get; set; }
        public virtual DbSet<tbl_employee_rate> tbl_employee_rate { get; set; }
        public virtual DbSet<tbl_employee_timesheet> tbl_employee_timesheet { get; set; }
        public virtual DbSet<tbl_holiday> tbl_holiday { get; set; }
        public virtual DbSet<tbl_jobs> tbl_jobs { get; set; }
        public virtual DbSet<tbl_loan> tbl_loan { get; set; }
        public virtual DbSet<tbl_schedule> tbl_schedule { get; set; }
        public virtual DbSet<tbl_sss_contribution> tbl_sss_contribution { get; set; }
        public virtual DbSet<view_department_list> view_department_list { get; set; }
        public virtual DbSet<View_Employee> View_Employee { get; set; }
        public virtual DbSet<view_employee_list> view_employee_list { get; set; }
        public virtual DbSet<view_employee_list_v2> view_employee_list_v2 { get; set; }
        public virtual DbSet<view_employee_loan> view_employee_loan { get; set; }
        public virtual DbSet<view_employee_no_user_account> view_employee_no_user_account { get; set; }
        public virtual DbSet<view_employee_timesheet_list> view_employee_timesheet_list { get; set; }
        public virtual DbSet<view_job_list> view_job_list { get; set; }
        public virtual DbSet<view_user_account_list> view_user_account_list { get; set; }
        public virtual DbSet<tbl_payslip_adjustment> tbl_payslip_adjustment { get; set; }
        public virtual DbSet<tbl_payslip_government_dedution> tbl_payslip_government_dedution { get; set; }
        public virtual DbSet<tbl_payslip_additionals> tbl_payslip_additionals { get; set; }
        public virtual DbSet<tbl_payslip_deductions> tbl_payslip_deductions { get; set; }
        public virtual DbSet<tbl_payslip_loan_deduction> tbl_payslip_loan_deduction { get; set; }
        public virtual DbSet<tbl_payslip_less> tbl_payslip_less { get; set; }
        public virtual DbSet<tbl_payslip_overtime> tbl_payslip_overtime { get; set; }
        public virtual DbSet<tbl_payslip_holiday> tbl_payslip_holiday { get; set; }
        public virtual DbSet<tbl_payslip_detail> tbl_payslip_detail { get; set; }
        public virtual DbSet<tbl_employee_account> tbl_employee_account { get; set; }
        public virtual DbSet<tbl_payslip> tbl_payslip { get; set; }
    }
}