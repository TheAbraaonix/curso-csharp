using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_7
{
    internal class TopicosEspeciais
    {
        static void Main(string[] args)
        {
            // PALAVRA VAR:
            var x = 10;
            var y = 20.0;
            var z = "string";

            Console.WriteLine(x + " " + y + " " + z);

            // SWITCH CASE:
            int numberDay = int.Parse(Console.ReadLine());
            string day;

            switch (numberDay)
            {
                case 1:
                    day = "sunday";
                    break;
                case 2:
                    day = "monday";
                    break;
                case 3:
                    day = "tuesday";
                    break;
                default:
                    day = "wrong";
                    break;
            }

            Console.WriteLine($"Day: {day}");

            // CONDICIONAL TERNARIA
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            // FUNCOES PARA STRING
            string original = "     ASDS fafafas FASFA facFA fasFQWF       ";

            Console.WriteLine(original.ToLower());
            Console.WriteLine(original.ToUpper());
            Console.WriteLine(original.Trim());
            Console.WriteLine(original.IndexOf("fac"));
            Console.WriteLine(original.LastIndexOf("q"));
            Console.WriteLine(original.Substring(10));
            Console.WriteLine(original.Substring(10, 5));
            Console.WriteLine(original.Replace("A", "X"));
            Console.WriteLine(original.Replace("fa", "xyz"));

            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine(b1);

            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine(b2);

            // DATA E HORA
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2024, 06, 19);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2024, 06, 19, 20, 45, 03);
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2024, 06, 19, 20, 45, 03, 500);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d7);

            // OPERACOES COM HORA
            DateTime d8 = DateTime.Now;
            Console.WriteLine(d8);
            Console.WriteLine(d8.AddHours(2));
            Console.WriteLine(d8.AddMinutes(10));

            DateTime d9 = DateTime.Parse("2024-06-19");
            DateTime d10 = DateTime.Parse("2003-02-13");
            TimeSpan diff = d9.Subtract(d10);
            Console.WriteLine(diff);

            // DATETIMEKIND 
            DateTime d12 = new DateTime(2001, 8, 15, 13, 45, 58, DateTimeKind.Local);
            DateTime d13 = new DateTime(2001, 8, 15, 13, 45, 58, DateTimeKind.Local);
            DateTime d14 = new DateTime(2001, 8, 15, 13, 45, 58);

            Console.WriteLine(d12);
            Console.WriteLine(d13);
            Console.WriteLine(d14);

            Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to utc: " + d1.ToUniversalTime());
        }
    }
}
