using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Practical
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
    }

}
