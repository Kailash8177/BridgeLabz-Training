using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    public class CurrentAccount : BankAccount, ILoanable
    {
        private const double interestRate = 0.02;

        public CurrentAccount(string accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return balance * interestRate;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount; // overdraft allowed
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Current Account Loan Requested: ₹{amount}");
        }

        public double CalculateLoanEligibility()
        {
            return balance * 10;
        }
    }

}
