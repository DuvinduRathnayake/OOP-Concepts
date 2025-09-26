using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class BankAccount
    {
        private decimal _balance;
        private readonly string _accountNumber;

        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new ArgumentException("Account number cannot be empty");
            }

            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be empty");
            }

            _accountNumber = accountNumber;
            _balance = initialBalance;
        }

        public decimal Balance => _balance; // readonly property

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit must be a postive");
            }

            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount should be positive");
            }

            if (amount > _balance)
            {
                throw new ArgumentException("Insufficient funds");
            }
            _balance -= amount;
        }
    }
}
