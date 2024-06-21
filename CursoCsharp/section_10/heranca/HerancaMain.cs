using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_10.heranca
{
    internal class HerancaMain
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);

            // DOWNCASTING
            BusinessAccount acc3 = (BusinessAccount)acc2;
            acc3.Loan(100);

            // SOBREPOSICAO
            Account acc4 = new BusinessAccount(1001, "Alex", 500, 200);
            Account acc5 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc4.Withdraw(10);
            acc5.Withdraw(10);

            Console.WriteLine(acc4.Balance);
            Console.WriteLine(acc5.Balance);

            // CLASSE ABSTRATA
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500, 400));

            double sum = 0;

            foreach(Account account in accounts)
            {
                sum += account.Balance;
            }

            Console.WriteLine(sum);

            foreach(Account account in accounts)
            {
                account.Withdraw(10);
            }

            foreach(Account account in accounts)
            {
                Console.WriteLine($"Updated: {account.Number}, Balance: {account.Balance}");
            }
        }
    }
}
