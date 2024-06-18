using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.arrayList.desafio
{
    internal class DesafioArrayListMain
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("How many employees will be registred?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the ID, name and salary of the employee:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee {i + 1}");
                int id;
                
                while (true)
                {
                    id = int.Parse(Console.ReadLine());
                    if (employees.Find(x => x.Id == id) != null)
                    {
                        Console.WriteLine("Id already exists! Please enter a different ID:");
                    }
                    else
                    {
                        break;
                    }
                }
                
                string name = Console.ReadLine();
                double salary = int.Parse(Console.ReadLine());

                Employee e = new Employee(id, name, salary);
                employees.Add(e);
            }

            Console.WriteLine("Enter the employee ID that will have the salary increase:");
            int searchId = int.Parse(Console.ReadLine());

            if(employees.Find(x => x.Id == searchId) == null)
            {
                Console.WriteLine("This id does not exists!");
                Console.WriteLine("");
                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary}");
                }
            } else
            {
                Employee foundEmployee = employees.Find(x => x.Id == searchId);

                Console.WriteLine("Enter the percentage:");
                double percentage = int.Parse(Console.ReadLine());

                foundEmployee.IncreaseSalary(percentage);

                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary}");
                }
            }
        }
    }
}
