using CursoCsharp.section_14.DesafioInjecaoDependencia.Entities;
using CursoCsharp.section_14.DesafioInjecaoDependencia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_14.DesafioInjecaoDependencia
{
    internal class DesafioInjecaoDependenciaMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PayPalService());

            contractService.ProcessContract(contract, installments);

            Console.WriteLine("Installments: ");
            foreach(Installment i in contract.Installments)
            {
                Console.WriteLine(i);
            }
        }
    }
}
