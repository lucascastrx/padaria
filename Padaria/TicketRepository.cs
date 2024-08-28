using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class TicketRepository : IRepository<int, Ticket>
    {
        private List<Ticket> tickets = [];
        private static int TICKET_ID;
        public Ticket Create(Ticket Data)
        {
            Data.Id = TICKET_ID++;
            Data.ClientPoints();
            tickets.Add(Data);
            return Data;

        }

        public void Delete(int Id)
        {
            var ticket = tickets.Find(o => o.Id == Id);
            if (ticket == null)
                throw new Exception("Ticket not found.");
            tickets.Remove(ticket);
        }

        public Ticket Read(int Id)
        {
            var ticket = tickets.Find(o => o.Id == Id);
            if (ticket == null)
                throw new Exception("Ticket not found.");
            return ticket;
        }

        public Ticket Update(int Id, Ticket data)
        {
            var ticket = tickets.Find(o => o.Id == Id);
            if (ticket == null)
                throw new Exception("Ticket not found.");
            ticket.Client = data.Client;
            //ticket.PaymentType = data.PaymentType;
            return ticket;

        }
    }
}
