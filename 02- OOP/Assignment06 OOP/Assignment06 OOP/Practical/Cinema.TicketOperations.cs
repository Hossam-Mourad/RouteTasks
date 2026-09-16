using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical
{
    public partial class Cinema
    {
        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    tickets[i].PrintTicket();
                }
            }
        }

        public static void ProcessTicket(Ticket ticket)
        {
            ticket.PrintTicket();
        }

        public bool BookTicket(int id)
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null && ticket.TicketId == id && !ticket.Booked)
                {
                    ticket.Book();
                    return true;
                }
            }
            return false;
        }

        public bool CancelBooking(int id)
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null && ticket.TicketId == id && ticket.Booked)
                {
                    ticket.Cancel();
                    return true;
                }
            }
            return false;
        }
    }
}
