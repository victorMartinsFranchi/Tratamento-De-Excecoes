using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoDeExcecoes.Entities.Exceptions;

namespace TratamentoDeExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Depoist(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= WithdrawLimit & Balance >= amount)
                Balance -= amount;
            else if (amount > WithdrawLimit)
                throw new DomainException("Amount exceeds withdraw limit");
            else
                throw new DomainException("Not enough balance");
        }
    }
}
