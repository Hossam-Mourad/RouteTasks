using Advanced_C_2.Models;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Product Catalog
            List<Product> catalog = new()
            {
                new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };
            #endregion

            #region Task01

            //Console.WriteLine("---Electronics---");
            //List<Product> Electronics = Helper.Search.SearchProducts(catalog, product => (product.Category == "Electronics"));
            //foreach (var product in Electronics) product.printProduct();

            //Console.WriteLine();
            //Console.WriteLine("---Under 50---");
            //List<Product> Under50 = Helper.Search.SearchProducts(catalog, product => product.Price < 50);
            //foreach (var product in Under50) product.printProduct();

            //Console.WriteLine();
            //Console.WriteLine("---In_Stock---");
            //List<Product> In_Stock = Helper.Search.SearchProducts(catalog, product => product.Stock > 0);
            //foreach(var product in In_Stock) product.printProduct();

            //Console.WriteLine();
            //Console.WriteLine("---Clothing Under 100$---");
            //List<Product> ClothingUnder100 = Helper.Search.SearchProducts(catalog, product => (product.Category == "Clothing" && product.Price < 100));
            //foreach (Product product in ClothingUnder100) product.printProduct();

            #endregion

            #region Task02.1

            //Console.WriteLine("--Short Report--");
            //Product.PrintReport(catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}"));

            //Console.WriteLine();
            //Console.WriteLine("--Detailed Report--");
            //Product.PrintReport(catalog, product => Console.WriteLine($"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}"));

            //Console.WriteLine();

            #endregion

            #region Task02.2

            //Console.WriteLine("--- Summary List ---");
            //List<string> Summary = Product.TransformProducts(catalog, product => $"{product.Name} (${product.Price})");
            //foreach(string result in Summary) Console.WriteLine(result);

            //Console.WriteLine();
            //Console.WriteLine("--- Price Labels ---");
            //List<string> Labels = Product.TransformProducts(catalog, product => $"{product.Name}: {(product.Price > 100 ? "Expensive!" : "Affordable")}");
            //foreach (string result in Labels) Console.WriteLine(result);

            #endregion

            #region Task02.3
            
            //Console.WriteLine("--- Low-Stock Alert ---");
            //List<Product> Low_Stock = Product.FilterProducts(catalog, product => (product.Stock < 20));
            //foreach(Product product in Low_Stock)
            //{
            //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            //}

            #endregion
        }
    }
}
