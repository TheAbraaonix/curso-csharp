using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_10.DesafioMetodosAbstratos.Entities;

namespace CursoCsharp.section_10.DesafioMetodosAbstratos
{
    internal class DesafioMetodosAbstratosMain
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");

                Console.Write("Individual or Company (i/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberEmployees));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAX PAYERS:");

            double total = 0;
            foreach(Person person in list)
            {
                Console.WriteLine($"{person.Name}: $ {person.Tax().ToString("F2")}");
                total += person.Tax();
            }
        }
    }
}
