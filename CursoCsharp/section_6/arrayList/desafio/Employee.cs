using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.arrayList.desafio
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * percentage) / 100;
        }
    }
}
