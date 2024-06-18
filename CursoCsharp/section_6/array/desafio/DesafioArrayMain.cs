using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.array.desafio
{
    internal class DesafioArrayMain
    {
        static void Main(string[] args)
        {
            Person[] rooms = new Person[10];

            Console.WriteLine("Digite quantos quartos serão alugados:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome, e-mail e num. do quarto dos ocupantes:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ocupante: {i + 1}");
                string nome = Console.ReadLine();
                string email = Console.ReadLine();
                int quarto = int.Parse(Console.ReadLine());

                if (rooms[quarto] == null)
                {
                    rooms[quarto] = new Person { Name = nome, Email = email };
                }

            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }
        }
    }
}
