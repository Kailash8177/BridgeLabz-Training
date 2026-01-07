using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    public class SavingsAccount : BankAccount, ILoanable
    {
        private const double interestRate = 0.04;

        public SavingsAccount(string accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return balance * interestRate;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Savings Account Loan Requested: ₹{amount}");
        }

        public double CalculateLoanEligibility()
        {
            return balance * 5;
        }
    }

}
