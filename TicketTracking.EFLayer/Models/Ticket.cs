using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking.EFLayer.Models
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public string LoggedBy { get; set; }
        public DateTime RaisedDate { get; set; }
        public string Severity { get; set; }
        public string Ticketdescription { get; set; }
        public string ResolvedBy { get; set; }
        public string Resolution { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string TicketStatus { get; set; }

        public Employee LoggedByEmployee { get; set; }
        public Employee ResolvedByEmployee { get; set; }
    }
}
