using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HakuSite.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }

        [Display(Name ="部门")]
        public string org { get; set; }


    }

    public class HakuDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } 
    }


}