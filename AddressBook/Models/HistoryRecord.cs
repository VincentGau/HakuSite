using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public enum ModifyType
    {
        Initial, Newcommer, Dimission, Transfer
    }

    public class HistoryRecord
    {
        public string ID { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string OrgID { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Office { get; set; }

        public DateTime ModifyDate { get; set; }
        public ModifyType ModifyType { get; set; }

        public string Remarks { get; set; }
    }
}
