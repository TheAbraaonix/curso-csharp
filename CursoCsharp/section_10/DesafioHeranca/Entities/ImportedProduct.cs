using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_10.DesafioHeranca.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) 
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag() + " (CustomsFee: $" + CustomsFee + ")";
        }

        public double TotalPrice()
        {
            Price += Price + CustomsFee;
            return Price;
        }
    }
}
