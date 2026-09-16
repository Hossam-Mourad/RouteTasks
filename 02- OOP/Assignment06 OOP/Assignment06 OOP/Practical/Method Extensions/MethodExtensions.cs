using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_OOP.Practical.Method_Extensions
{
    public static class MethodExtensions
    {
        public static string GenerateReceipt(this Ticket t)
        {
            string bookinfo = t.Booked ? "Booked" : "Not Booked";
            return $"Movie : {t.MovieName}\nType : {t.GetType().Name}\nFinal : {t.PriceAfterTax}\nStatus : {bookinfo}";
        }

        public static double TotalRevenue(this Ticket[] tickets)
        {
            double tot = 0;
            foreach (Ticket x in tickets)
            {
                if (x.Booked)
                {
                    tot += x.FinalPrice;
                }
            }
            return tot;
        }

    }
}
