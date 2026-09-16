using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical
{
    internal class StandardTicket : Ticket
    {
        public StandardTicket(string movieName, TicketType type, SeatLocation seat, double price) : base(movieName, type, seat, price)
        {
            SeatNumber = seat.Number.ToString();
        }

        public string SeatNumber { get; set; }

        public override string ToString()
        {
            string BookedInfo = Booked ? "YES" : "NO";
            return base.ToString() + $" | {Seat.Row}-{Seat.Number} | Booked: {BookedInfo} | Final: {FinalPrice}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            string BookedInfo = Booked ? "YES" : "NO";
            Console.WriteLine($" | {Seat.Row}-{Seat.Number} | Booked: {BookedInfo} | Final: {FinalPrice}");
        }

        override public Ticket DeepCopy()
        {
            return new StandardTicket(MovieName, Type, Seat, Price);
        }

        public override double FinalPrice => PriceAfterTax;

    }
}
