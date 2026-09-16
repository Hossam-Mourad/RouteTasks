using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Practical
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
            string imaxInfo = Is3d ? "YES" : "NO";
            string BookedInfo = Booked ? "YES" : "NO";
            return base.ToString() + $" | IMAX 3D: {imaxInfo} | Booked: {BookedInfo}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            string imaxInfo = Is3d ? "YES" : "NO";
            string BookedInfo = Booked ? "YES" : "NO";
            Console.WriteLine($" | IMAX 3D: {imaxInfo} | Booked: {BookedInfo}" );
        }

        public override Ticket DeepCopy()
        {
            return new IMAXTicket(MovieName, Type, Seat, Price, Is3d);
        }
    }
}
