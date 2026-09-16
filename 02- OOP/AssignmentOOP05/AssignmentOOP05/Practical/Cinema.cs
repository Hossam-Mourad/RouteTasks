using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AssignmentOOP05.Practical;

namespace AssignmentOOP05.Practical   
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();

        public string? CinemaName { get; set; }
        public Cinema(string name)
        {
            CinemaName = name;
        }
        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < 20) return tickets[index];
                else return null;
            }
            set { if (index >= 0 && index < 20) tickets[index] = value; }
        }

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

        public void OpenCinema()
        {
            projector.Start();
        }
        public void CloseCinema()
        {
            projector.Stop();
        }

        public string GetMovie(string name)
        {
            for(int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null && tickets[i].MovieName == name)
                {
                    return tickets[i].MovieName;
                }
            }
            return null;
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
