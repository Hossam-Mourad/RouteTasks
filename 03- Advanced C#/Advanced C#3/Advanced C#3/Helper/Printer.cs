using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_3.Helper
{
    class Printer
    {
        public static void PrindList<T>(List<T> items)
        {
            Console.Write("[");
            foreach(T item in items) Console.Write(item + ",");
            Console.WriteLine("]");
        }

        public static void PrindSortedList<T, K>(SortedList<K, T> items)
        {
            Console.WriteLine("{");
            foreach (var (x, y) in items) Console.WriteLine("[" + y + " " + x + "] ,");
            Console.WriteLine("}");
        }

    }
}
