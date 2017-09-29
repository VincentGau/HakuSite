using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HakuSite.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "座机")]
        public string Phone { get; set; }

        [Display(Name = "手机")]
        public string Mobile { get; set; }

        [Display(Name = "部门")]
        public string Org { get; set; }

        [Display(Name = "办公室")]
        public string Office { get; set; }

        [Display(Name = "标识码")]
        public string EncryptID { get; set; }
    }

    public class TmpEmployee
    {
        public int ID { get; set; }

        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "座机")]
        public string Phone { get; set; }

        [Display(Name = "手机")]
        public string Mobile { get; set; }

        [Display(Name = "部门")]
        public string Org { get; set; }

        [Display(Name = "办公室")]
        public string Office { get; set; }

        [Display(Name = "标识码")]
        public string EncryptID { get; set; }
    }

    public class Org
    {
        public int ID { get; set; }

        public string OrgID { get; set; }

        public string OrgName { get; set; }

        public int NumOfPeople { get; set; }

    }

    public class HistoryRecord
    {
        public int ID { get; set; }

        public string EncryptID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Org { get; set; }

        public string Office { get; set; }

        public string ModifyType { get; set; }
        //ModifyType: Initaial New Leave Modify

        public DateTime ModifyDate { get; set; }


    }

    public class HakuDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Org> Orgs { get; set; }
        public DbSet<HistoryRecord> HistoryRecords { get; set; }
        public DbSet<TmpEmployee> TmpEmployees { get; set; }


    }


}