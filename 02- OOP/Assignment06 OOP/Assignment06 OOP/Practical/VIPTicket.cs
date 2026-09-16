using Assignment06_OOP.Practical.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical
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
            
            string loungeInfo = LoungeAccess ? "YES" : "NO";
            string BookedInfo = Booked ? "YES" : "NO";
            return base.ToString() + $" | Lounge: {loungeInfo} | ServiceFee: {ServiceFee} EGP | Booked: {BookedInfo} | Final: {FinalPrice}";
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            string loungeInfo = LoungeAccess ? "YES" : "NO";
            string BookedInfo = Booked ? "YES" : "NO";
            Console.WriteLine($" | Lounge: {loungeInfo} | ServiceFee: {ServiceFee} EGP | Booked: {BookedInfo} | Final: {FinalPrice}");
        }

        public override Ticket DeepCopy()
        {
            return new VIPTicket(MovieName, Type, Seat, Price, LoungeAccess);
        }

        override public double FinalPrice => PriceAfterTax + (double)ServiceFee;
    }
}
