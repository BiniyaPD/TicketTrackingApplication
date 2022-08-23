//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TicketTracking.EFLayer.Contracts;
//using TicketTracking.EFLayer.Models;

//namespace TicketTracking.EFLayer.Implementation
//{
//    public class TicketEFImpl : ITicketRepository
//    {
//        private readonly db_ticketContext context = null;


//        public TicketEFImpl(db_ticketContext context)
//        {
//            this.context = context;
//        }

//        public bool CloseTicket(CommonLayer.Models.Ticket ticket)
//        {
//            bool isClosed = false;
//            try
//            {
//                var ticketToClose = this.context.Tickets.FirstOrDefault(x => x.TicketId == ticket.TicketId);
//               if(ticketToClose==null)
//                {
//                    Console.WriteLine("Ticket Not Found");
//                }
//                ticketToClose.ResolvedBy = ticket.ResolvedBy;
//                ticketToClose.Resolution = ticket.Resolution;
//                ticketToClose.TicketStatus = "Closed";
//                this.context.SaveChanges();
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            return isClosed;
//        }

//        public int LogTicket(TicketTracking.CommonLayer.Models.Ticket ticket)
//        {
//            Ticket ticketDb = null;
//            try
//            {
//                ticketDb = new Models.Ticket()
//                {
//                    LoggedBy = ticket.LoggedBy,
//                    RaisedDate = ticket.RaisedDate,
//                    Severity = ticket.Severity,
//                    Tdescription = ticket.Tdescription,
//                    ResolvedBy = ticket.ResolvedBy,
//                    Resolution = ticket.Resolution,
//                    ResolvedDate = ticket.ResolvedDate,
//                    TicketStatus = ticket.TicketStatus
//                };
//                this.context.Tickets.Add(ticketDb);
//                this.context.SaveChanges();
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            return ticketDb.TicketId;
//        }
//    }
//}
