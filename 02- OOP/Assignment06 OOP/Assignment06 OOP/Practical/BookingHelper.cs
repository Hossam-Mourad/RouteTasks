using Assignment06_OOP.Practical.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical
{
    internal static class BookingHelper
    {
        private static int bookCounter = 1;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5)
            {
                totalPrice -= (totalPrice * 0.1);
            }
            return totalPrice;
        }

        public static string GenerateBookingReference()
        {
            return $"BK-{bookCounter++}";
        }

        public static void PrintALL(Iprintable[] to_print)
        {
            foreach (var item in to_print)
            {
                item.PrintTicket();
            }
        }
    }

}
