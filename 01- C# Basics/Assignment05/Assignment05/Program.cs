namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01

            //Console.WriteLine("Enter a day number (1-7): ");
            //Enum.TryParse( Console.ReadLine(), out DayOfWeek Today);
            //Console.WriteLine($"Day: {Today}");

            //switch (Today) {
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("It's the Weekend");
            //        break;
            //    default:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //}

            #endregion


            #region Question02

            //Console.Write("Enter array size: ");
            //int.TryParse(Console.ReadLine(), out int Size);
            //int []arr = new int[Size];
            //int max = -1000000000, min = 1000000000, sum = 0;
            //double Average = 0; 
            //for(int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Enter element [{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    if (arr[i] > max) max = arr[i];
            //    if(arr[i] < min) min = arr[i];
            //    Average += arr[i];
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine($"Average = {Average / Size}");
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}");
            //Console.Write("Reverse = ");
            //for(int i = Size - 1; i >= 0; i--) {
            //    Console.Write(arr[i]);
            //    if(i > 0) Console.Write(", ");
            //}

            #endregion


            #region Question03 Student Grades Matrix

            //int[,] grades = new int[3, 4];
            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Enter grade of Subject {j + 1} of Student {i + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());   
            //    }
            //}

            //double TotalAverage = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    double Average = 0;
            //    for (int j = 0; j < 4; j++)
            //    {
            //        TotalAverage += grades[i, j];
            //        Average += grades[i, j];
            //    }
            //    Console.WriteLine($"Average of {i + 1} Student = {Average / 4.0}");
            //}
            //Console.WriteLine($"Total Average = {TotalAverage / 3.0}");



            #endregion

            #region Question04 Basic Calculator Functions

            //Console.Write("Enter First Number : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Choose the Operation (+ , - , * , /): ");
            //char op = char.Parse(Console.ReadLine());

            //Console.Write("Result = ");
            //if(op == '+') Console.WriteLine(Add(num1, num2));
            //else if (op == '-') Console.WriteLine(Subtract(num1, num2));
            //else if (op == '*') Console.WriteLine(Multiply(num1, num2));
            //else Console.WriteLine(Divide(num1, num2));

            #endregion

            #region Question05

            //double testRadius = 1.5;
            //CalculateCircle(testRadius, out double Area, out double circum);
            //Console.WriteLine($"Area = {Area} \ncircum = {circum}");

            #endregion
        }

        #region Basic Calculator Functions
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            if(y == 0)
            {
                Console.WriteLine("Can't Divide By Zero, Please Try Again...");
                return 0;
            }
            return x / y;
        }

        #endregion

        #region CircleCalculatorFunction
        
        static void CalculateCircle(double radius, out double Area, out double circumference) {
            Area = radius * radius * 3.14;
            circumference = 2 * 3.14 * radius;
        }

        #endregion

    }

    #region DayOfWeekEnum

    //enum DayOfWeek
    //{
    //    Saturday = 1, 
    //    Sunday, 
    //    Monday,
    //    Tuesday, 
    //    Wednesday, 
    //    Thursday, 
    //    Friday
    //}

    #endregion
}
