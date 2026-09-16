using Assignment06_OOP.Practical.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical
{
    public abstract class Ticket : Iprintable, IClonable
    {
        private static int ticketCounter = 0;
        private string? movieName;
        private double price;
        public bool Booked { get; private set; }
        public Ticket()
        {
            ticketCounter++;
            TicketId = ticketCounter;
            Booked = false;
        }
        internal Ticket(string movieName, double price) 
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Price = price;
            Booked = false;
        }
        internal Ticket(string movieName, TicketType type, SeatLocation seat, double price)
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
        internal TicketType Type { get; set; }

        internal SeatLocation Seat { get; set; }

        internal double Price {
            get
            {
                return price;
            }
            set{
                if(value > 0) price = value;
            }
        }
        internal double PriceAfterTax
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

        public bool Book()
        {
            if (!Booked)
            {
                Booked = true;
                return true;
            }
            return false;
        }

        public bool Cancel()
        {
            if (Booked)
            {
                Booked = false;
                return true;
            }
            return false;
        }

        public abstract Ticket DeepCopy();

        public abstract double FinalPrice { get; }

    }
}
