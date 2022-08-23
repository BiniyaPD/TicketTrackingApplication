using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicketTracking.EFLayer.Contracts
{
    public interface ITicketRepository
    {
        int LogTicket(TicketTracking.CommonLayer.Models.Ticket ticket);
        bool CloseTicket(TicketTracking.CommonLayer.Models.Ticket ticket);

    }
}
