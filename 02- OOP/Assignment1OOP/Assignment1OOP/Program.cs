namespace Assignment1OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Movie Name: ");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            TicketType type = (TicketType)Enum.Parse(typeof(TicketType), Console.ReadLine());
            Console.WriteLine("Enter Seat Row (A, B, C...): ");
            Seat seat = new Seat();
            seat.row = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seat Number: ");
            seat.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());
            Ticket ticket = new Ticket(movieName, type, seat, price);
            Console.WriteLine("===== Ticket Info =====");
            ticket.PrintTicket();
            Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14.0)}");
            Console.WriteLine("===== After Discount =====");
            Console.WriteLine($"Discount Before :{discount}");
            Console.WriteLine($"Discount After :{0.00}");
            ticket.ApplyDiscount(discount); 
            ticket.PrintTicket();
            Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14.0)}");
        }

    }
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }
}
