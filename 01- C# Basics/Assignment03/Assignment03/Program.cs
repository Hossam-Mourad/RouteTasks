using AssignmentOOP03.Practical;

namespace AssignmentOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Theoretical Questions

            #region Question 01
            //Q1 : Identify the type of relationship in each scenario below (Inheritance, Association, Aggregation, Composition, or Dependency):
            // a) a) A University has Departments. If the university is closed, the departments no longer exist.
            // Composition

            // b) A Driver uses a Car. The driver does not own the car.
            // Association

            // c) A Dog is an Animal.
            // Inheritance

            // d) A Team has Players. If the team is deleted, the players still exist.
            // Aggregation

            // e) A method receives a Logger as a parameter and calls it inside the method only.
            // Dependency

            #endregion


            #region Question 02

            // a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
            // yes, but instance no

            // b) What is the difference between protected internal and private protected?
            // private protected -> Accessible in the containing class OR derived classes in the same assembly only
            // protected internal -> Accessible anywhere in the same assembly (like internal) OR in derived classes in other assemblies (like protected)

            // c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            // the class cannot be inherited, the method cannot be overridden

            // d) Can you create an object from a sealed class using new? Why or why not?
            // yes, sealed classes cannot be inherited but can be instantiated
            #endregion

            #endregion

            #region Practical Questions

            Cinema cinema = new Cinema();
            Console.WriteLine("========== Cinema Opened ==========");
            cinema.OpenCinema();
            SeatLocation seat1 = new SeatLocation { Number = 5 };
            SeatLocation seat2 = new SeatLocation { Number = 15 };
            SeatLocation seat3 = new SeatLocation { Number = 20 };

            StandardTicket standard = new StandardTicket("Inception", TicketType.Standard, seat1, 100.0);
            VIPTicket vip = new VIPTicket("The Matrix", TicketType.VIP, seat2, 200.0, true);
            IMAXTicket imax = new IMAXTicket("Interstellar", TicketType.IMAX, seat3, 150.0, true);

            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);


            Console.WriteLine("========== All Tickets ==========");
           
            for(int i = 0; i < 3; i++)
            {
                Console.Write($"Ticket #{i + 1} ");
                Console.WriteLine(cinema[i]);
            }

            cinema.CloseCinema();
            Console.WriteLine("========== Cinema Closed ==========");


            #endregion
        }
    }
}
