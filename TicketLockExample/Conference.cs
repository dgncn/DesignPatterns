using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLockExample
{
    public class Conference
    {
        public List<Ticket> Tickets { get; set; }
        public string Title { get; set; }

        public Conference(string title)
        {
            Title = title;
            Tickets = GetRandomTickets();
        }

        private List<Ticket> GetRandomTickets()
        {
            var list = new List<Ticket>();
            for (int i = 0; i < 40; i++)
            {
                Ticket ticket = new Ticket()
                {
                    TicketOrderNumber = i + 1,
                };
                list.Add(ticket);
            }
            return list;
        }
    }
}
