using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HakuSite.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string org { get; set; }


    }

    public class HakuDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } 
    }


}