using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketLockExample
{
    public class Program
    {

        private static object _lockObject = new object();
        static async Task Main(string[] args)
        {
            Conference conference = new Conference("C# Deep Dive To Locking Mechanism");
            Task[] workers = new Task[100];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = Task.Run(() => BuyTicket(conference, workers[i]));
                Console.WriteLine($"task.Id: {workers[i].Id} | task.Status: {workers[i].Status}");
            }

            await Task.WhenAll(workers);

        }

        public static void BuyTicket(Conference conference, Task task)
        {
            Ticket ticket = null;
            #region with proper / lock
            lock (_lockObject)
            {
                ticket = conference.Tickets.OrderBy(x => x.TicketOrderNumber).Where(x => !x.IsUsed).FirstOrDefault();
                if (ticket != null)
                {
                    ticket.IsUsed = true;
                    Console.WriteLine($"ticket used a thread. task.Id:{task?.Id} | ticket.TicketOrderNumber: {ticket.TicketOrderNumber}");
                }
            }
            #endregion
            #region with wrong usage
            //ticket = conference.Tickets.OrderBy(x => x.TicketOrderNumber).Where(x => !x.IsUsed).FirstOrDefault();
            //if (ticket != null)
            //{
            //    ticket.IsUsed = true;
            //    Console.WriteLine($"ticket used a thread. task.Id:{task?.Id} | ticket.TicketOrderNumber: {ticket.TicketOrderNumber}");
            //}
            #endregion
        }
    }
}
