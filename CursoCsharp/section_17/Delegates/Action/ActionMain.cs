using CursoCsharp.section_17.Predicate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_17.Action
{
    internal class ActionMain
    {
        static void Main(string[] args)
        {
            List<ProductPredicate> list = new List<ProductPredicate>();
            list.Add(new ProductPredicate("Tv", 900.00));
            list.Add(new ProductPredicate("Mouse", 50.00));
            list.Add(new ProductPredicate("Tablet", 350.50));
            list.Add(new ProductPredicate("HD Case", 80.90));

            //list.ForEach((p) => p.Price += p.Price * 0.1);
            list.ForEach(UpdatePrice);

            foreach (ProductPredicate productPredicate in list)
            {
                Console.WriteLine(productPredicate.ToString());
            }
        }

        static void UpdatePrice(ProductPredicate p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
