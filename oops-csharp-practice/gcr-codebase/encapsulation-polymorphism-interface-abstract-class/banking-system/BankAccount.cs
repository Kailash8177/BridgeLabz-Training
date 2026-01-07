using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    public abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        protected double balance;

        protected BankAccount(string accNo, string name, double initialBalance)
        {
            accountNumber = accNo;
            holderName = name;
            balance = initialBalance;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public string HolderName
        {
            get { return holderName; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public abstract double CalculateInterest();
    }

}
