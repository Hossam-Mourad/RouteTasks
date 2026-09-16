using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            ////  What will this print and explain what happens?
            //    double d = 9.99;
            //    int x = (int)d;
            //    Console.WriteLine(x);
            //// it will print 9 because i cast from double to int and the int can't
            //// store fraction part so it ignores it
            #endregion

            #region Question02
            //// This code doesn’t compile. Fix it with the smallest change? 
            //int n = 5;
            //double d2 = n / 2f;
            //Console.WriteLine(d2);
            // put f after 2 to tell the compiler it's float not integer
            #endregion

            #region Question03
            // You read a number from user input .. Write the correct line to   
            // get age as int.
            // int age = Convert.ToInt32(Console.ReadLine());
            // int age = int.Parse(Console.ReadLine());
            // Console.WriteLine(age);
            #endregion

            #region Question04

            //// What happens here and why?   
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            //// throw exception because "12a" is not an integer
            #endregion

            #region Question05
            // Complete the code from the previous question so it prints 
            // Invalid if conversion into int fails, otherwise prints the number
            //string s = "12a";
            //if(int.TryParse(s, out int x))
            //{
            //    Console.WriteLine(x);
            //} else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region Question06
            //// What will this print and explain why ? 
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            //// 11 because we cast the object to integer so a = 10 then
            //// we add 1 in the print statement
            #endregion

            #region Question07
            // What will this print and explain why and if there is a   
            // problem handle it ?
            //object o = 10;
            //// long x = (long) o;
            //long x = (long)(int)o;
            //Console.WriteLine(x);
            // it throws an exception because we 10 is int and when we unbox it 
            // we must unbox to the same type 
            #endregion

            #region Question08
            // Fix this to avoid exceptions and print -1 if conversion isn’t       
            // possible ?
            //object o = 10;
            //if(int.TryParse(o?.ToString(), out int x))
            //{
            //    Console.WriteLine(x);
            //} else
            //{
            //    Console.WriteLine(-1);
            //}
            #endregion

            #region Question09
            //// What will this print and explain why ? 
            //string? name = null;
            //Console.WriteLine(name?.Length);
            //// print nothing because we use Null Probagation operator so no exception

            #endregion

            #region Qusetion10
            //// What will this print and explain the process? 
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);
            //// it will print 0 
            //// we use Null propagation operator so if the name2 value is null 
            //// it will return default value of string (null) then we use '??'
            //// (Fallback) that change the default value from null to 0
            #endregion

            #region Question11
            //// What’s wrong with this “safe” code and how can we solve it ? 
            //string? s = "asd";
            //// int x = int.Parse(s ?? "0");
            //// wrong when the string s can't be parsed to int like "abc" 
            //// to handle it we use tryparse
            //if (int.TryParse(s ?? "0", out int x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("can't be converted to int");
            //}

            #endregion

            #region Question12
            ////What happens here and if there is a problem, handle it  
            //string? s = null;
            //// Console.WriteLine(s!.Length);
            //Console.WriteLine(s?.Length);
            //// throw null exception
            #endregion

            #region Question13
            // What will this print? 
            //string? s = null; 
            //int x = Convert.ToInt32(s); 
            //Console.WriteLine(x); 
            // 0 because convert return default value if null 
            #endregion

            #region Question14
            //  Compare results and explain each result : 
            //string? s = null; 

            // A 
            // int a = int.Parse(s); 

            // B 
            //int b = Convert.ToInt32(s); 
            //Console.WriteLine(b); 
            // a will throw exception of null
            // b will print 0 because Convert return default value if the s is null
            #endregion

            #region Question15
            //// Complete the line to print "Guest" when user is null,   
            //// otherwise print the user name in uppercase:
            //string? user = "null";
            //Console.WriteLine(user?.ToUpper()?? "Guest");
            #endregion

        }
    }
}
