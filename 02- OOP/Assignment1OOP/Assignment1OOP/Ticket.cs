using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOP
{
    public class Ticket
    {
        public String movieName;
        public TicketType Type;
        public Seat seat;
        private double price;

        public Ticket(String _moviename, TicketType _type, Seat _seat, double _price)
        {
            movieName = _moviename;
            Type = _type;
            seat = _seat;
            price = _price;
        }
        Ticket(String _moviename) : this(_moviename, TicketType.Standard, new Seat() { row = 'A', Number = 1 }, 50)
        { }

        public double CalcTotal(double taxPrecent)
        {
            return price + (price * taxPrecent / 100.0);
        }

        public void ApplyDiscount(double discountAmount)
        {
            if(discountAmount > 0 && discountAmount <= price)
            {
                price -= discountAmount;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Movie: {movieName}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Seat: {seat.row}{seat.Number}");
            Console.WriteLine($"Price: {price}");
        }

    }
}
