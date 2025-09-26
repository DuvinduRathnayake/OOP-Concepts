using BankDemo;
using System;

namespace BankDemo
{
    class Program
    {
        static void Main(String[] args)
        {
            var account = new BankAccount("AC123", 100);
            Console.WriteLine($"Account balance is:{account.Balance}");

            account.Deposit(50);
            Console.WriteLine($"After Deposit:{account.Balance}");

            account.Withdraw(30);
            Console.WriteLine($"After withdraw:{account.Balance}");

            try
            {
                account.Withdraw(200); // should fail
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}