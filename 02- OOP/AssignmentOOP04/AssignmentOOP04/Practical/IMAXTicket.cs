using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Practical
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3d { get; set; }
        public IMAXTicket(string movieName, TicketType type, SeatLocation seat, double price, bool is3d) : base(movieName, type, seat, price)
        {
            Is3d = is3d;
            if (Is3d)
            {
                Price += 30;
            }
        }


        public override string ToString()
        {
            return $"{MovieName} | Price: {Price} EGP | After Tax: {Price * 1.14:F2} EGP | IMAX 3D: {(Is3d ? "Yes" : "No")}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            string imaxInfo = Is3d ? "YES" : "NO";
            Console.WriteLine($" | IMAX 3D: {imaxInfo}");
        }

    }
}
