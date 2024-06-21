using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_10.DesafioMetodosAbstratos.Entities
{
    internal class Individual : Person
    {
        public double HealthExpeditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpeditures) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            double taxToPay = 0;

            if (AnualIncome < 20000)
            {
                taxToPay = AnualIncome * 0.15;
            }
            else
            {
                taxToPay = AnualIncome * 0.25;
            }

            if (HealthExpeditures > 0)
            {
                return (taxToPay) - (HealthExpeditures - 0.5);
            }
            else
            {
                return taxToPay;
            }
        }
    }
}
