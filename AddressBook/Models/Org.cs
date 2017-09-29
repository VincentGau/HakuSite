using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Org
    {
        public string OrgID { get; set; }
        public string OrgName { get; set; }
        public string ParentID { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Org> Orgs { get; set; }
    }
}
