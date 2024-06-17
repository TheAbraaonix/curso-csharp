using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_4
{
    internal class MainEstatica
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            
            Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2"));
        }
    }
}
