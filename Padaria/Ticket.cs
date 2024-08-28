using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class Ticket
    {
        public int Id { get; set; }
        public List<ProductTicket> ProductTickets { get; set; }
        public Client Client { get; set; }
        public PaymentType PaymentType { get; set; }

        public double TotalValue()
        {
            var amount = 0;
            foreach(var ticket in ProductTickets)
            {
                amount += ticket.Value;
            }

            return amount;
        }
        

    }
}
