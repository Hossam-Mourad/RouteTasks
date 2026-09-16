using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP.Practical
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        
        public Ticket this[int index]
        {
            get {
                if (index < 20) return tickets[index];
                else return null;
            }
            set { if(index < 20) tickets[index] = value; }
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


    }
}
