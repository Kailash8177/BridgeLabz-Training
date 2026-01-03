using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class BankUtility
    {
        public static void Main()
        {
            BankAccount acc = new BankAccount(1001, "Rahul", 5000);
            acc.Display();
            acc.Deposit(2000);
            Console.WriteLine("Balance: " + acc.GetBalance());
        }
    }

    public class BankAccount
    {
        public int AccountNumber;        // public
        protected string AccountHolder;  // protected
        private double Balance;          // private

        public BankAccount(int accNo, string holder, double balance)
        {
            AccountNumber = accNo;
            AccountHolder = holder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void Display()
        {
            Console.WriteLine($"Account: {AccountNumber}, Holder: {AccountHolder}");
        }
    }
}
