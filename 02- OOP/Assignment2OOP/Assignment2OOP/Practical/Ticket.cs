using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP.Practical
{
    internal class Ticket
    {
        private static int ticketCounter = 0;
        private string movieName;

        public Ticket() {
            ticketCounter++;
        }
        public Ticket(int ticketId, string movieName, TicketType type, SeatLocation seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public int TicketId { get; set; }
        public string MovieName { 
            get { return movieName; }
            set { 
                if(string.IsNullOrEmpty(movieName)) movieName = value; 
            }
        }
        public TicketType Type { get; set; }

        public SeatLocation Seat { get; set; }

        public double Price { get; set; }
        public double PriceAfterTax { 
            get { 
                return Price + (Price * 0.14);
            }
            set;
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return $"| {MovieName} | {Type} | Seat: {Seat.row} - {Seat.Number} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP";
        }


    }
}
