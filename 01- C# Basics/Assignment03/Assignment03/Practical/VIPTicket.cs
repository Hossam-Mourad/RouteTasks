using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Practical
{
    internal class VIPTicket : Ticket
    {
        public VIPTicket(string movieName, TicketType type, SeatLocation seat, double price, bool loungeAccess) : base(movieName, type, seat, price)
        {
            LoungeAccess = loungeAccess;
        }

        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;

        public override string ToString()
        {
            return $"{MovieName} | Price: {Price} EGP | After Tax: {Price * 1.14:F2} EGP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }

    }
}
