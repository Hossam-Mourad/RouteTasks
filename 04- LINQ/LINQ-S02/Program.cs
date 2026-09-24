using LINQ.Models;
using System.Linq;
using static LINQ.DataSources.Source;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01

            //var query = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02

            //var query = ProductList.Skip(5).Take(5);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q03

            // var query = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Q04

            //var query = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            #endregion

            #region Q05

            //int[] ids = { 3, 9, 13, 18 };
            //var query = ids.Contains(9);

            #endregion

            #region Q06

            //var query = ProductList.GroupBy(p => p.Category);

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Key} {item.Count()}");
            //}

            #endregion


            #region Q07

            //var query = ProductList.GroupBy(p => p.Category, p => p.ProductName);

            #endregion

            #region Q08

            //var query = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);

            #endregion

            #region Q09

            //var query = from c in CustomerList
            //            group c by c.Country
            //            into groups
            //            select new
            //            {

            //                country = groups.Key,
            //                count = groups.Count(),
            //                TotalOrderValue = groups.Sum(c => c.Orders.Sum(o => o.Total))
            //            };

            #endregion

            #region Q10

            //var query = ProductList.Sum(p => p.UnitsInStock);

            #endregion

            #region Q11

            //var MOST_EXPENSIVE = ProductList.Max(p => p.UnitPrice);
            //var CHEAPEST = ProductList.Min(p => p.UnitPrice);

            #endregion

            #region Q12

            //var query = ProductList.Select(p => p.Category).Distinct();

            #endregion

            #region Q13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var query = setA.Except(setB);

            #endregion

            #region Q14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var query = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region Q15

            //var query = ProductList.ToDictionary(p => p.ProductID);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(query[18]);

            #endregion

            #region Q16

            //var query = ProductList.First(p => p.UnitPrice > 50);

            #endregion

            #region Q17

            //var query = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            #endregion

            #region Q18

            //var query = Enumerable.Range(0, 100).Where(n => n % 7 == 0);

            #endregion

            #region Q19

            //var query = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

            #endregion

            #region Q20

            //var query = ProductList.Select(p => p.ProductName).Take(3).Zip(CustomerList.Select(c => c.CompanyName).Take(3));

            #endregion

            #region Q21

            var query = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            #endregion
        }
    }
}
