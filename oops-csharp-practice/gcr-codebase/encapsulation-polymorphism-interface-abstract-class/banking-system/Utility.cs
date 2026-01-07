using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    public class Utility
    {
        public static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("SA101", "Amit", 50000),
            new CurrentAccount("CA202", "Ravi", 100000)
        };

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine($"Account Holder: {account.HolderName}");
                Console.WriteLine($"Balance: ₹{account.Balance}");
                Console.WriteLine($"Interest Earned: ₹{account.CalculateInterest()}");

                if (account is ILoanable loanable)
                {
                    Console.WriteLine($"Loan Eligibility: ₹{loanable.CalculateLoanEligibility()}");
                }

                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
