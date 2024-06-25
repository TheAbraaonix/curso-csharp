using CursoCsharp.section_17.Predicate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_17.Func
{
    internal class FuncMain
    {
        static void Main(string[] args)
        {
            List<ProductPredicate> list = new List<ProductPredicate>();
            list.Add(new ProductPredicate("Tv", 900.00));
            list.Add(new ProductPredicate("Mouse", 50.00));
            list.Add(new ProductPredicate("Tablet", 350.50));
            list.Add(new ProductPredicate("HD Case", 80.90));

            //List<String> result = list.Select((p) => p.Name.ToUpper()).ToList();
            List<String> result = list.Select(NameUpper).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s.ToString());
            }
        }

        static string NameUpper(ProductPredicate p)
        {
            return p.Name.ToUpper();
        }
    }
}
