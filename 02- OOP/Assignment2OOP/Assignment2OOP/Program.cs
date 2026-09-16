using Assignment2OOP.Practical;

namespace Assignment2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region therotical questions

            #region Question 1

            /* 
             * a.
             * Owner, Balance are public.
             * no validation before subtract the amount from the balance.
             * 
             * b.
             * to fix it we make the balance and owner private. and add if condition before 
             * subtract from the balance.
             * 
             * c.
             * no validation, no rules. Data becomes invalid and bugs are impossible to trace.
             */

            #endregion

            #region Question 2

            // a.  It looks like a field from outside, but behaves like methods inside.


            #endregion

            #region Question 3

            /*
             public class StudentRegister
                {
                    private string[] names = new string[5];
                    public string this[int index]
                    {
                        get { return names[index]; }
                        set { names[index] = value; }
                    }
                }
             */

            //a) What is `this[int index]` called? Explain its purpose.
            // its a special proberity. it give us the ability to access the object by indecies like arrays and other 
            // b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
            // outOfBound exception, we can add a validation in the get
            // Can a class have more than one indexer? If yes, give an example of when that would be useful.
            // yes, it's usefull when we have thing that i can access it by more than one type
            // like books , we can search about book by name or numbers , or position
            #endregion

            #region Question 4

            /*
             public class Order
            {
                public static int TotalOrders = 0;
                public string Item;
 
                public Order(string item)
                {
                    Item = item;
                    TotalOrders++;
                }
            }
             */
            // a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
            // static means tha the field belong to the class and i can access it without creating an object.
            // but I can't access the item without creating an object because it's not static.
            // b) Can a static method inside `Order` access the `Item` field directly? Why or why not?
            // No, beacause the Item belong to the object so if i call the method what is the object that i will access its item ?

            #endregion

            #endregion


            #region Practical Questions


            Cinema cinema = new Cinema();


            Console.WriteLine("========== Ticket Booking ==========");
            for (int i = 1; i <= 3; i++)
            {
                Ticket ticket = new Ticket();
                Console.WriteLine($"Enter Data for Ticket {i}:");
                Console.Write("Movie Name: ");
                ticket.MovieName = Console.ReadLine();
                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                ticket.Type = (TicketType)int.Parse(Console.ReadLine());
                Console.Write("Seat Row(A-Z): ");
                SeatLocation seat;
                seat.row = char.Parse(Console.ReadLine());
                Console.Write("Seat Number: ");
                seat.Number = int.Parse(Console.ReadLine());
                ticket.Seat = seat;
                Console.Write("Price: ");
                ticket.Price = double.Parse(Console.ReadLine());
                cinema.AddTicket(ticket);
                Console.WriteLine();
            }
            Console.WriteLine("========== All Tickets ==========");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ticket #{i + 1} {cinema[i]}");
            }


            Console.WriteLine("========== Search by Movie ==========");

            Console.Write("Enter movie name to search: ");
            bool found = false;
            string searchMovie = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (cinema[i] != null && cinema[i].MovieName == searchMovie)
                {
                    Console.WriteLine($"Found: Ticket #{i + 1} {cinema[i]}");
                    found = true;
                    break;
                }
            }
            if (!found) Console.WriteLine("Not found");

            Console.WriteLine("========== Total Sold ==========");
            Console.WriteLine(Ticket.GetTotalTicketsSold());

            Console.WriteLine("========== Refrences Generate ==========");
            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());

            Console.WriteLine("========== Group Price ==========");
            Console.WriteLine(BookingHelper.CalcGroupDiscount(5, 80));

            #endregion


        }
        #region proberityExample
        //public int MyProperty 
        //{
        //    get
        //    {
        //        // calculate
        //        return 0;
        //    }
        //}
        #endregion
    }
}
