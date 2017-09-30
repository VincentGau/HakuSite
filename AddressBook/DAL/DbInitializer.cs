using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.DAL
{
    public class DbInitializer
    {
        public static void Initialize(AddressBookContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{Name="Kohaku",EmployeeID="A001"},
            new Employee{Name="Chihiro",EmployeeID="A002"},
            new Employee{Name="Moe",EmployeeID="A003"}
            };
            foreach (Employee s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();
        }
    }
}
