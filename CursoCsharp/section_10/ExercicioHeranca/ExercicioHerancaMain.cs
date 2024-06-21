using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_10.ExercicioHeranca.Entities;

namespace CursoCsharp.section_10.ExercicioHeranca
{
    internal class ExercicioHerancaMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter employee #{i + 1} data:");
                
                Console.Write("Outsourced (y/n)?: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if(ch == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("");

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee e in list)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2"));
            }
        }
    }
}
