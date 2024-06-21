using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_10.DesafioMetodosAbstratos.Entities
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Person() { }

        protected Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
