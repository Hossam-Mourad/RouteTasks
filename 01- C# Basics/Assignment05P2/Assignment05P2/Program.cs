namespace Assignment05P2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] grades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter score for Student {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--- Report ---");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student {i + 1}: {grades[i]} -> Grade: {GetGrade(grades[i])}");
            }
            GetMinMax(grades, out int min, out int max);
            Console.WriteLine($"Average: {GetAverage(grades)}");
            Console.WriteLine($"Lowest Score: {min}");
            Console.WriteLine($"Highest Score: {max}");

        }

        static Grade GetGrade(int grad)
        {
            if (grad >= 90) return Grade.A;
            else if (grad >= 80) return Grade.B;
            else if (grad >= 70) return Grade.C;
            else if (grad >= 60) return Grade.D;
            else return Grade.F;
        }

        static double GetAverage(int[] arr)
        {
            double Average = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                Average += arr[i];
            }
            return Average / arr.Length;
        }

        static void GetMinMax(int[] arr, out int Min, out int Max)
        {
            Min = 1000000000; Max = -1000000000;
            foreach (int grade in arr)
            {
                if (grade > Max) Max = grade;
                if (grade < Min) Min = grade;
            }
        }
    }
    enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }
}
