using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }

        public void printProduct() // added method to format the output
        {
            Console.WriteLine($"{Name} - ${Price} (Stock: {Stock})");
        }

        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }

        public static List<string> TransformProducts(List<Product> products, Func<Product, String> Transform)
        {
            List<string> result = new();
            foreach(Product product in products)
            {
                result.Add(Transform(product));
            }
            return result;
        }

        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> filter)
        {
            List<Product> result = new();
            foreach(Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}
