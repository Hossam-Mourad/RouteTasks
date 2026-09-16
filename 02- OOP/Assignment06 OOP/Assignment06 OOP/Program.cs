using Assignment06_OOP.Practical;
using Assignment06_OOP.Practical.Contracts;
using Assignment06_OOP.Practical.Method_Extensions;

namespace Assignment06_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region theoretical

            #region Question 01
            //  abstraction the process of exposing only what the user needs and hiding how it is implemented.
            // encapsulation is preventing access to the internal details of an object and access its data only through a public methods.
            // real example is keyboard, you just push the keys and it type the letters this is abstraction, but the internal details is protected and you can't access it this is encapsulation.

            #endregion

            #region Question 02

            //Q2 : What is the difference between an abstract class and an interface? Give at least four differences. When would you choose one over the other?

            // Abstract class:
            // can have both abstract and non-abstract members.
            // can have constructors.
            // can have fields and properties.
            // can be inherited by only one class.
            // Interface:
            // can only have abstract members.
            // cannot have constructors.
            // cannot have fields and properties.
            // can be implemented by multiple classes.
            // we choose an abstract class when we want to provide a common base class for related classes and we choose an interface when we want to define a contract that multiple classes have to implement.

            #endregion

            #region Question 03

            // a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            // No, because Appliance is an abstract class.

            // b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?

            // PowerConsumption() is abstract so it must be implemented by any class inherits from Appliance, Status() is virtual so it can be overridden by any class inherits from Appliance, Label() is concrete so it cannot be overridden and it has a complete implementation.

            // c) If you call Status() on a Toaster object, what will it return? Why?
            // it will return "Standby" Because the Toaster class does not override the Status() method.
            #endregion

            #region Question 04

            // a) What is a partial class? Why would a developer split Calculator into two files?

            // A partial class is a class that can be split into multiple files. A developer would split Calculator into two files to organize the code better and to make it easier to maintain.

            // b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?

            // A partial method is a method that can be declared in one part of a partial class and implemented in another part. If the OnCalculated() implementation in Calculator.Logging.cs is deleted, the code will still compile because partial methods are optional and they do not have to be implemented.

            // c) What is an extension method? What are the three rules for writing one?

            // An extension method lets you add new methods to an existing type without modifying its source code, without inheritance, and without recompiling.

            // static class
            // static method
            // the first parameter must have the 'this'

            // d) What will the following code print?

            // Log: result = 20
            // $20.00

            #endregion

            #endregion


            #region practical

            Cinema cinema = new Cinema("Hossam's");
            Console.WriteLine("=== Cinema Opened ===");
            cinema.OpenCinema();

            // Ticket t = new Ticket();

            SeatLocation seat1 = new SeatLocation { Row = 'A', Number = 5 };
            SeatLocation seat2 = new SeatLocation { Row = 'B', Number = 15 };
            SeatLocation seat3 = new SeatLocation { Row = 'C', Number = 20 };

            Ticket standard = new StandardTicket("Inception", TicketType.Standard, seat1, 80.0);
            Ticket vip = new VIPTicket("Avengers", TicketType.VIP, seat2, 200.0, true);
            Ticket imax = new IMAXTicket("Dune", TicketType.IMAX, seat3, 130.0, true);

            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            cinema.BookTicket(standard.TicketId);
            cinema.BookTicket(vip.TicketId);
            cinema.BookTicket(imax.TicketId);

            Console.WriteLine();
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");
            cinema.PrintAllTickets();


            Console.WriteLine();
            Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");
            Console.WriteLine($"StandardTicket => Final Price: {standard.FinalPrice}");
            Console.WriteLine($"VIPTicket => Final Price: {vip.FinalPrice}");
            Console.WriteLine($"IMAXTicket => Final Price: {imax.FinalPrice}");


            Console.WriteLine();
            Console.WriteLine("--- Extension Method: Receipt ---");
            Console.WriteLine("========== RECEIPT ==========");
            Console.WriteLine(vip.GenerateReceipt());
            Console.WriteLine("=============================");

            Console.WriteLine();
            Console.WriteLine("--- Extension Method: Total Revenue ---");

            Ticket[] tickets = { standard, vip , imax };

            Console.WriteLine($"Total Revenue: {tickets.TotalRevenue()}\n");

            cinema.CloseCinema();
            Console.WriteLine("=== Cinema Closed ===");
            

            #endregion
        }
    }
}
