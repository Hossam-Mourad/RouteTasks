using System.Text;

namespace AssignmentS04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question01


            //var stopWatch1 = System.Diagnostics.Stopwatch.StartNew();
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //stopWatch1.Stop();

            //// (a) Explain why this code is inefficient. Reference what happens in memory.
            //// because string is immutible so every change will create a new object
            //// in the memory
            //// (b) Rewrite this code using StringBuilder to be more efficient.

            //StringBuilder productList2 = new StringBuilder();
            //var stopWatch2 = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList2.Append("PROD-");
            //    productList2.Append(i);
            //    productList2.Append(",");
            //}
            //string result = productList2.ToString();
            //stopWatch2.Stop();

            //Console.WriteLine(stopWatch1.ElapsedMilliseconds);
            //Console.WriteLine(stopWatch2.ElapsedMilliseconds);


            #endregion

            #region Question02

            //Console.Write("Please Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Enter the number of today(1 - 7 where 1 = sunday, 2 = monday....etc): ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Do u have a Student ID ?");
            //string ans = Console.ReadLine();
            //bool ID = false;
            //if (ans.ToLower() == "yes") ID = true;
            //double price = 0.0;
            //StringBuilder Breakdown = new StringBuilder();

            //if(age < 5)
            //{
            //    price = 0;
            //    Breakdown.Append("Free Because Age < 5");
            //} else if(age >= 5 && age <= 12)
            //{
            //    price = 30;
            //    Breakdown.Append("30 LE Because Age (5 - 12)");
            //} else if(age >= 13 && age <= 59)
            //{
            //    price = 50;
            //    Breakdown.Append("50 LE Because Age (13 - 59)");
            //} else
            //{
            //    price = 25;
            //    Breakdown.Append("25 LE Because Age 60+");
            //}

            //if(day == 6 || day == 7)
            //{
            //    price += 10;
            //    Breakdown.Append("\n+10 LE Cause of Weekend");
            //}

            //if (ID)
            //{
            //    price -= ((20f / 100f) * price);
            //    Breakdown.Append("\n20% Discount Cause of Student ID");
            //}

            //Console.WriteLine($"Total is: {price} LE");
            //Console.WriteLine(Breakdown);

            #endregion

            #region Question03

            //string fileExtension = ".pdf", fileType;
            //switch (fileExtension)
            //{
            //    case ".pdf": 
            //        fileType = "PDF Document";
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            //Console.WriteLine(fileType);


            //string fileExtension = ".pdf";
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};
            //Console.WriteLine(fileType);

            #endregion

            #region Question04

            //int temperature = 15;
            //string weatherAdvice;

            //weatherAdvice = (temperature < 0 ? "Freezing! Stay indoors." : (temperature < 15 ? "Cold.Wear a jacket." : (temperature < 25 ? "Pleasant weather." : (temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure."))));

            //Console.WriteLine(weatherAdvice);

            // Is the ternary version more readable? When would you choose one over the other?
            // NO, when the number of choices is small and the logic is simple.

            #endregion

            #region Question05

            //int attempt = 0;
            //string password;
            //bool valid = false;
            //do
            //{
            //    attempt++;
            //    Console.WriteLine("Enter a New Password");
            //    password = Console.ReadLine();
            //    if(password.Length < 8)
            //    {
            //        Console.WriteLine("(Password Must be 8 characters or more)");
            //        continue;
            //    }
            //    bool upper = false, digit = false, space = false;
            //    foreach(char c in password)
            //    {
            //        if (c >= 'A' && c <= 'Z') upper = true;
            //        if(c >= '0' && c <= '9') digit = true;
            //        if(c == ' ') space = true;
            //    }
            //    if (!upper)
            //    {
            //        Console.WriteLine("(Password should have at least one uppercase letter)");
            //        continue;
            //    }
            //    if (!digit)
            //    {
            //        Console.WriteLine("(Password should have at least one digit)");
            //        continue;
            //    }
            //    if (space)
            //    {
            //        Console.WriteLine("(No Spaces Allowed)");
            //        continue;
            //    }
            //    valid = true;
            //    Console.WriteLine("(Password accepted!)");
            //    break;
            //} while(attempt < 5);
            //if(!valid) Console.WriteLine("(Account locked)");
            #endregion

            #region Question06

            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            //// a
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if(scores[i] < 50)
            //    {
            //        Console.WriteLine(scores[i]);
            //    }
            //}

            //// b
            //foreach (int x in scores)
            //{
            //    if(x > 90)
            //    {
            //        Console.WriteLine(x);
            //        break;
            //    }
            //}

            //// c

            //double classAverage = 0, cnt = 0.0;
            //int pointer = 0;
            //while (pointer < scores.Length) {
            //    if (scores[pointer] >= 40){
            //        classAverage += scores[pointer];
            //        cnt++;
            //    }
            //    pointer++;
            //}
            //classAverage /= cnt;
            //Console.WriteLine(classAverage);

            //// d

            //int cntA = 0, cntB = 0, cntC = 0, cntD = 0, cntF = 0;
            //foreach (int x in scores)
            //{
            //    if (x >= 90) cntA++;
            //    else if (x >= 80) cntB++;
            //    else if (x >= 70) cntC++;
            //    else if (x >= 60) cntD++;
            //    else cntF++;
            //}
            //Console.WriteLine($"{cntA} {cntB} {cntC} {cntD} {cntF}");

            #endregion

        }
    }
}
