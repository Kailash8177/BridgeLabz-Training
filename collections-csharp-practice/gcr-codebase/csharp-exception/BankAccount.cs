using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    internal class BankAccount
    {
        private double balance = 5000;

        public void Withdraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Invalid amount!");

            if (amount > balance)
                throw new InsufficientFundsException("Insufficient balance!");

            balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: " + balance);
        }
    }

    internal class BankTransactionDemo
    {
        public static void Main()
        {
            BankAccount account = new BankAccount();

            try
            {
                account.Withdraw(6000);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
