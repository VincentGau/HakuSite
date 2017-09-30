using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string OrgID { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Office { get; set; }
    }
}
