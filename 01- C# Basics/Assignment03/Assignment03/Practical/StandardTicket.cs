using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Practical
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
            return $"{MovieName} | Price: {Price} EGP | After Tax: {Price * 1.14:F2} EGP | Seat: {SeatNumber}";
        }

    }
}
