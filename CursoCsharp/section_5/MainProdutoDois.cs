using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_4;

namespace CursoCsharp.section_5
{
    internal class MainProdutoDois
    {
        static void Main(string[] args)
        {
            ProdutoDois p = new ProdutoDois("TV", 500.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
