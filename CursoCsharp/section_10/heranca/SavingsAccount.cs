using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_10.heranca
{
    sealed internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // SOBREPOSICAO E METODO SELADO
        sealed public override void Withdraw(double amount)
        {
            // Um método com a keyword "sealed" não pode ser sobrescrito novamente por uma nova subclasse
            
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
