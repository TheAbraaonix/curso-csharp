using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_11.DesafioExceptions.Exceptions;

namespace CursoCsharp.section_11.DesafioExceptions.Entities
{
    internal class AccountDesafioExceptions
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public AccountDesafioExceptions() { }

        public AccountDesafioExceptions(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new WithdrawException("Not enough balance");
            }

            if(amount > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds withdraw limit");
            }
            
            Balance -= amount;
        }
    }
}
