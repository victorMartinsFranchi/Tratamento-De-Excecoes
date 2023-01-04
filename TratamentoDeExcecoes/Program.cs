using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoDeExcecoes.Entities;
using TratamentoDeExcecoes.Entities.Exceptions;

namespace TratamentoDeExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("WithdrawLimit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account x = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine();

                Console.Write("Enter the ammount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                x.Withdraw(withdrawAmount);
                Console.WriteLine("New Balance: " + x.Balance.ToString("F2"));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
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
