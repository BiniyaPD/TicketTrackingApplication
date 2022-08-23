using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketTracking.WebApp.Models
{
    public class LogTicket
    {
        [Display(Name = "Select the Date")]
        [Required(ErrorMessage = "Date cannot be blank")]
        public DateTime RaisedDate { get; set; }
        [Display(Name = "Select the Severity")]
        [Required(ErrorMessage = "Severity cannot be blank")]
        public string Severity { get; set; }
        [Display(Name = "Enter your Ticket Description")]
        [Required(ErrorMessage = "Ticket Description cannot be blank")]
        public string Ticketdescription { get; set; }
        [Display(Name = "Choose the Resolver")]
        public string ResolvedBy { get; set; }
        [Display(Name = "Enter the Resolution")]
        public string Resolution { get; set; }
        [Display(Name = "Choose the Resolved Date")]
        public DateTime ResolvedDate { get; set; }
        [Display(Name = "Choose the TicketStatus")]
        public string TicketStatus { get; set; }

        //public virtual Employee LoggedByNavigation { get; set; }
        //public virtual Employee ResolvedByNavigation { get; set; }
    }
}
