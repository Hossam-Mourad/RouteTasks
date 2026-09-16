using AssignmentOOP04.Practical;

namespace AssignmentOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Theoretical

            #region Question01
            // Q1 : What is the difference between static binding and dynamic binding? When does each one happen?

            // Static binding happens at compile time based on the reference type, while dynamic binding happens at runtime based on the object type.

            #endregion

            #region Question02
            // Q2 :  What is the difference between method overloading and method overriding?

            // overloading happen in the same class without inheritance and it is when we type the same method name with change in parameters(number, type, order).
            // overriding happen when a child class inherit a method from parent and rewrite it with the same signature and return type, but with different behavior.
            #endregion

            #region Question03

            // Q3 : What keywords are used for Method Overriding? What does each one mean ?

            // virtual , used in parent class to make the method overrideable.
            // override, used in child class to override the method of parent.

            #endregion

            #endregion

            #region Practical

            Cinema cinema = new Cinema();
            Console.WriteLine("========== Cinema Opened ==========");
            cinema.OpenCinema();
            Console.WriteLine();
            Console.WriteLine("========== SetPrice Test ==========");

            SeatLocation seat1 = new SeatLocation { Row = 'A', Number = 5 };
            SeatLocation seat2 = new SeatLocation { Row = 'B', Number = 15 };
            SeatLocation seat3 = new SeatLocation { Row = 'C', Number = 20 };

            Ticket standard = new StandardTicket("Inception", TicketType.Standard, seat1, 100.0);
            Ticket vip = new VIPTicket("The Matrix", TicketType.VIP, seat2, 200.0, true);
            Ticket imax = new IMAXTicket("Interstellar", TicketType.IMAX, seat3, 150.0, true);


            Console.Write("Setting price directly: ");
            vip.SetPrice(150m);
            Console.WriteLine(vip.Price);
            Console.Write("Setting price with multiplier: 100 x 1.5 = ");
            vip.SetPrice(100m, 1.5m);
            Console.WriteLine(vip.Price);

            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);
            Console.WriteLine();
            Console.WriteLine("========== All Tickets ==========");
            cinema.PrintAllTickets();
            Console.WriteLine();

            Console.WriteLine("========== Process Single Ticket ==========");
            
            Cinema.ProcessTicket(standard);
            Console.WriteLine();

            cinema.CloseCinema();
            #endregion

        }
    }
}
