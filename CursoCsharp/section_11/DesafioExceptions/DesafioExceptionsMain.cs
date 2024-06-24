using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_11.DesafioExceptions.Entities;
using CursoCsharp.section_11.DesafioExceptions.Exceptions;

namespace CursoCsharp.section_11.DesafioExceptions
{
    internal class DesafioExceptionsMain
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                Console.Write("Account number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                AccountDesafioExceptions account = new AccountDesafioExceptions(accountNumber, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine());

                account.Withdraw(withdrawAmount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2"));
            }
            catch (WithdrawException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
