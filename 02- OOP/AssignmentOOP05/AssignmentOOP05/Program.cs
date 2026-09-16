using AssignmentOOP05.Practical;
using AssignmentOOP05.Practical.Contracts;

namespace AssignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region therotical

            #region Question01
            // Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.

            // An interface defines a contract that a class must follow.
            // we can't inherits from multi classes but we can implement multi interfaces.
            // Enable polymorphism without inheritance
            // Remove tight coupling between classes
            // Enable multiple inheritance(behavior)
            #endregion

            #region Question02

            // a) the two methods do the same thing
            // b) Explicit implementation for every Method
            // c) No you have to call it by refrence of the interface itself
            //Translator translator = new Translator();
            //IEnglishSpeaker SE = translator;
            //SE.Great();
            //IArabicSpeaker SA = translator;
            //SA.Great();

            #endregion

            #region Question03

            // shallow copy copies the object but copies references for reference-type fields.
            // A deep copy copies the object and all nested objects, creating fully independent duplicates.
            // we use shallow when no nested reference state
            // we use deep copy when modifications should not affect original
            // the risk is any change in the copy will change the original 

            #endregion

            #region Question04

            /*

            // Look at the following code and determine the output. Explain why.
            // Dev - Testing
            // QA - Testing
            // cause of shallow copy so refrence type fields change in both objects like Dept, but string is immutable so it like value type and change only in e2 not in e1
             */

            #endregion

            #endregion


            #region practical

            Cinema cinema = new Cinema("Hossam's");
            Console.WriteLine("=== Cinema Opened ===");
            cinema.OpenCinema();

            SeatLocation seat1 = new SeatLocation { Row = 'A', Number = 5 };
            SeatLocation seat2 = new SeatLocation { Row = 'B', Number = 15 };
            SeatLocation seat3 = new SeatLocation { Row = 'C', Number = 20 };

            Ticket standard = new StandardTicket("Inception", TicketType.Standard, seat1, 100.0);
            Ticket vip = new VIPTicket("Avengers", TicketType.VIP, seat2, 200.0, true);
            Ticket imax = new IMAXTicket("Dune", TicketType.IMAX, seat3, 150.0, true);

            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            
            Console.WriteLine("=== Booking ===");
            Console.WriteLine();
            if (cinema.BookTicket(standard.TicketId)) Console.WriteLine($"Ticket #{standard.TicketId} is Booked");
            else Console.WriteLine("Failed To Book");

            if (cinema.BookTicket(vip.TicketId)) Console.WriteLine($"Ticket #{vip.TicketId} is Booked");
            else Console.WriteLine("Failed To Book");

            if (cinema.BookTicket(imax.TicketId)) Console.WriteLine($"Ticket #{imax.TicketId} is Booked");
            else Console.WriteLine("Failed To Book");
            Console.WriteLine();
            Console.WriteLine("--- All Tickets ---");
            cinema.PrintAllTickets();

            Console.WriteLine();
            Console.WriteLine("--- Clone Test ---");

            Ticket Clone = vip.DeepCopy();
            Clone.MovieName = "Interstellar";

            Console.Write("Original: ");
            vip.PrintTicket();
            Console.Write("Clone: ");
            Clone.PrintTicket();
            Console.WriteLine();
            Console.WriteLine("--- After Cancellation ---");
            cinema.CancelBooking(standard.TicketId);
            standard.PrintTicket();
            Console.WriteLine();
            Console.WriteLine("--- BookingHelper.PrintAll ---");
            Iprintable[] printableTickets = new Iprintable[] { standard, vip, imax };
            BookingHelper.PrintALL(printableTickets);
            Console.WriteLine();
            cinema.CloseCinema();
            Console.WriteLine("==== Cinema Closed ====");


            #endregion
        }
    }
}
