using CursoCsharp.section_17.Predicate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_17.Predicate
{
    internal class PredicateMain
    {
        static void Main(string[] args)
        {
            List<ProductPredicate> list = new List<ProductPredicate>();
            list.Add(new ProductPredicate("Tv", 900.00));
            list.Add(new ProductPredicate("Mouse", 50.00));
            list.Add(new ProductPredicate("Tablet", 350.50));
            list.Add(new ProductPredicate("HD Case", 80.90));

            //list.RemoveAll((p) => p.Price >= 100);
            list.RemoveAll(ProductTest);

            foreach (ProductPredicate p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public static bool ProductTest(ProductPredicate p)
        {
            return p.Price >= 100;
        }
    }
}
