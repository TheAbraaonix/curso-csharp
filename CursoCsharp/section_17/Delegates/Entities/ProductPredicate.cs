using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_17.Predicate.Entities
{
    internal class ProductPredicate
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductPredicate(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
