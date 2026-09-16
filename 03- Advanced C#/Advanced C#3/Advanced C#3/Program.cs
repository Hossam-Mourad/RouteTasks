using System.Globalization;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_C_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01
            //// 1
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //// 2
            //Console.Write("Grades : ");
            //Helper.Printer.PrindList(grades);
            //Console.WriteLine($"Count = {grades.Count}");
            //Console.WriteLine($"First Grade = {grades[0]}, Last grade = {grades[^1]}");
            //// 3
            //grades.Sort();
            //Console.Write("Sorted List : "); 
            //Helper.Printer.PrindList(grades);
            //// 4
            //int FirstGradeAbove90 = grades.Find(x => x > 90);
            //Console.WriteLine($"First Grade Above 90 = {FirstGradeAbove90}");
            //// 5
            //List<int> FailingGrades = grades.FindAll(x => x < 75);
            //Console.Write("FailingGrades : ");
            //Helper.Printer.PrindList(FailingGrades);
            //// 6
            //grades.RemoveAll(x => x < 75);
            //// 7
            //bool have100 = grades.Contains(100);
            //Console.WriteLine($"Have 100 ? {( have100 ? "YES" : "NO")}");
            //// 8
            //List<String> ConvertedList = grades.ConvertAll(x => $"Grade: {x}");
            //Helper.Printer.PrindList(ConvertedList);
            #endregion

            #region EX02

            //// 1
            //SortedList<int, String> LeaderBoard = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            //// 2
            //Helper.Printer.PrindSortedList(LeaderBoard);
            //// 3
            //Console.WriteLine($"First Key : {LeaderBoard.Keys[0]}, First Value : {LeaderBoard.Values[0]}");
            //// 4
            //bool Score500 = LeaderBoard.Keys.Contains(500);
            //Console.WriteLine($"Score500 Exists? {(Score500 ? "YES" : "NO")}");
            //// 5
            //LeaderBoard.TryGetValue(999, out String Value);
            //Console.WriteLine(Value); // Print Empty because no value = 999
            //// 6
            //LeaderBoard.Remove(200);
            //Helper.Printer.PrindSortedList(LeaderBoard);
            #endregion

            #region EX03

            //// 1
            //Dictionary<String, String> PhoneBook = new()
            //{
            //    ["Hossam"] = "01142658612",
            //    ["Ali"] = "01125648323",
            //    ["Mohsen"] = "12354749",
            //    ["Krkr"] = "033548987"
            //};
            //// 2
            //// Add With index
            //PhoneBook["Medo"] = "1364892231";
            //// Update With index
            //PhoneBook["Hossam"] = "01065605214";

            //// 3
            //try
            //{
            //    PhoneBook.Add("Hossam", "01065605214");
            //} catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //// 4
            //bool done = PhoneBook.TryAdd("Hossam", "01065605214");
            //Console.WriteLine(done);

            //// 5
            //bool search = PhoneBook.ContainsKey("Mariam");
            //Console.WriteLine(search);

            //// 6
            //String SearchWithFallback = PhoneBook.GetValueOrDefault("Mariam", "Not Found");
            //Console.WriteLine(SearchWithFallback);

            //// 7
            //Console.Write("Keys : ");
            //foreach(var key in PhoneBook.Keys) Console.Write(key + " ");
            //Console.WriteLine();
            //Console.Write("Values : ");
            //foreach (var value in PhoneBook.Values) Console.Write(value + " ");
            #endregion

            #region EX04
            //// 1
            //HashSet<string> UniqueEmail = new(StringComparer.OrdinalIgnoreCase);
            //// 2
            //UniqueEmail.Add("ahmed@test.com");
            //UniqueEmail.Add("AHMED@test.com");
            //UniqueEmail.Add("sara@test.com");
            //UniqueEmail.Add("Sara@Test.Com");
            //// 3
            //Console.WriteLine(UniqueEmail.Count); // 2 because it case-insensitive so it ignore the diffrence between capital and small characters
            //// 4
            //HashSet<int> A = [1, 2, 3, 4, 5], B = [4, 5, 6, 7, 8];
            //// 5
            //HashSet<int> union = new(A), Intersect = new(A), Except = new(A);
            //union.UnionWith(B);
            //Intersect.IntersectWith(B);
            //Except.ExceptWith(B);

            //Console.Write("Union : ");
            //foreach(var item in union) Console.Write(item + " ");
            //Console.WriteLine();

            //Console.Write("Intersect : ");
            //foreach (var item in Intersect) Console.Write(item + " ");
            //Console.WriteLine();

            //Console.Write("Except : ");
            //foreach (var item in Except) Console.Write(item + " ");
            //Console.WriteLine();

            //// 6
            //bool isSub = new HashSet<int> { 1, 2 }.IsSubsetOf(A);
            //Console.WriteLine(isSub);
            #endregion

            #region EX05
            //Queue<String> Simulator = new();
            //Simulator.Enqueue("Report.pdf");
            //Simulator.Enqueue("Invoice.pdf"); 
            //Simulator.Enqueue("Letter.docx");
            //Simulator.Enqueue("Resume.pdf");
            //Simulator.Enqueue("Photo.jpg");
            //// 1
            //foreach(var item in Simulator) Console.WriteLine(item);
            //Console.WriteLine(Simulator.Count);

            //// 2
            //Console.WriteLine(Simulator.Peek());
            //// 3
            //while(Simulator.Count > 0)
            //{
            //    Console.WriteLine($"Printing: {Simulator.Dequeue()}");
            //}
            //// 4

            //Simulator.TryDequeue(out string result);
            //Console.WriteLine(result);
            //// Simulator is empty so TryDequeue handle the Error and return empty string 

            #endregion

            #region EX06

            // 1
            Stack<String> History = new();
            History.Push("google.com");
            History.Push("github.com");
            History.Push("stackoverflow.com");
            History.Push("youtube.com");
            History.Push("claude.ai");
            // 2
            Console.WriteLine(History.Peek());
            // 3
            Console.WriteLine(History.Pop());
            Console.WriteLine(History.Pop());
            Console.WriteLine(History.Pop());
            // 4
            Console.WriteLine(History.Peek());
            // 5
            while (History.Count > 0) History.Pop();
            History.TryPop(out string result);
            Console.WriteLine(result);
            // History is empty so TryPop handle the Error and return empty string
            #endregion
        }
    }
}
