using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking.EFLayer.Models
{
    public class Employee
    {
        public string Employeeid { get; set; }
        public string EmployeeName { get; set; }
        public DateTime HireDate { get; set; }
        public string Dept { get; set; }
        public string Epassword { get; set; }
    }
}
