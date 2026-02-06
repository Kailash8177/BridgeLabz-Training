using System;
using System.Collections.Generic;
using System.Text;

namespace bank_management_system
{
    internal abstract class BankAccount : IBankAccount
    {
        private string accountNumber;
        public double balance;

        public BankAccount(string account, double bal)
        {
            this.accountNumber = account;
            this.balance = bal;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public virtual void Deposit(Double amount)
        {
            if (amount<0)
            {
                Console.WriteLine("Enter the valid Amount");
                return;
            }
            balance += amount;
            Console.WriteLine("Deposite SuccesFully");
        }

        public virtual void Withdraw(Double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Enter the valid Amount");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Ammount is insufficient");
                return;
            }
            balance -= amount;
            Console.WriteLine("withdraw");

        }
        public virtual double GetBalance() { return balance; }
    }
}
