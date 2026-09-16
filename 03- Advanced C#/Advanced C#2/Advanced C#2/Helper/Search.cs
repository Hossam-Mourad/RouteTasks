using Advanced_C_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_2.Helper
{
    class Search
    {

        public static List<Models.Product> SearchProducts(List<Models.Product> products, Predicate<Models.Product> predicate)
        {
            List<Models.Product> result = new List<Models.Product>();

            foreach (var product in products)
            {
                if (predicate(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }

    }
}