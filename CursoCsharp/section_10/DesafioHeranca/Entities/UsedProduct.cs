using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_10.DesafioHeranca.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string priceTag()
        {
            return Name + "(used) $" + Price + " (Manufacture Date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
