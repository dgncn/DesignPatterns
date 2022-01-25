using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLockExample
{
    public class Ticket
    {
        public Ticket()
        {
            TicketNumber = Guid.NewGuid();
            TicketCreatedDate = DateTime.Now;
        }
        public Guid TicketNumber { get; set; }
        public int TicketOrderNumber { get; set; }
        public DateTime TicketCreatedDate { get; set; }
        public bool IsUsed { get; set; } = false;
    }
}
