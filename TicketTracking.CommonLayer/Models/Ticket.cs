using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking.CommonLayer.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string LoggedBy { get; set; }
        public DateTime? RaisedDate { get; set; }
        public string Severity { get; set; }
        public string Tdescription { get; set; }
        public string ResolvedBy { get; set; }
        public string Resolution { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string TicketStatus { get; set; }

        public virtual Employee LoggedByNavigation { get; set; }
        public virtual Employee ResolvedByNavigation { get; set; }
    }
}
