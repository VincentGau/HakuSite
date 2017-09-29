using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AddressBook.Models;

namespace AddressBook.DAL
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TmpEmployee> TmpEmployees { get; set; }
        public DbSet<Org> Orgs { get; set; }
        public DbSet<HistoryRecord> HistoryRecords { get; set; }
    }
}
