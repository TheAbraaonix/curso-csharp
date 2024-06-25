using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.desafio_section_9.Entities;

namespace CursoCsharp.section_15.EqualsAndHashCode
{
    internal class EqualsAndHashCodeMain
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "maria", Email = "maria@outlook.com" };
            Client b = new Client { Name = "alex", Email = "alex@outlook.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
