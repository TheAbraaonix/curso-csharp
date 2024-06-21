using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_10.DesafioHeranca.Entities;

namespace CursoCsharp.section_10.DesafioHeranca
{
    internal class DesafioHerancaMain
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Product {i + 1} data:");

                Console.Write("Commom, used or imported (c/u/i)?: ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    ImportedProduct ip = new ImportedProduct(name, price, customsFee);
                    list.Add(ip);
                }

                if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    UsedProduct up = new UsedProduct(name, price, manufactureDate);
                    list.Add(up);
                }

                if (type == 'c')
                {
                    Product p = new Product(name, price);
                    list.Add(p);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}
