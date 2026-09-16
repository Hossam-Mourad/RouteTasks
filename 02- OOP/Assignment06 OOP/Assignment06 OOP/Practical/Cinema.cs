using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical   
{
    public partial class Cinema
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


    }
}
