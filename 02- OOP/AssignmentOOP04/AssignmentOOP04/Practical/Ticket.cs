using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Practical
{
    internal class Ticket
    {
        private static int ticketCounter = 0;
        private string movieName;
        private double priceAfterTax;
        private double price;
        public Ticket()
        {
            ticketCounter++;
            TicketId = ticketCounter;
        }
        public Ticket(string movieName, double price) 
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Price = price;
        }
        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public int TicketId { get; }
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value)) movieName = value;
            }
        }
        public TicketType Type { get; set; }

        public SeatLocation Seat { get; set; }

        public double Price {
            get
            {
                return price;
            }
            set{
                if(value > 0) price = value;
            }
        }
        public double PriceAfterTax
        {
            get
            {
                return Price + (Price * 0.14);
            }
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return $"| {MovieName} | {Type} | Seat: {Seat.Row} - {Seat.Number} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP";
        }

        public virtual void PrintTicket()
        {
            Console.Write($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP");
        }

        public void SetPrice(decimal _price)
        {
            if(_price >= 0) Price = (double)_price;
        }
        public void SetPrice(decimal _price, decimal multiplier)
        {
            if (_price >= 0) Price = (double)_price * (double)multiplier;
        }

    }
}
