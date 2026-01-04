using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Superclass ----------------
    class BankAccount
    {
        public int AccountNumber;
        public double Balance;
    }

    // ---------------- Savings Account ----------------
    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }

    // ---------------- Checking Account ----------------
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;

        public void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }

    // ---------------- Fixed Deposit Account ----------------
    class FixedDepositAccount : BankAccount
    {
        public int LockInPeriod;

        public void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }
    }

    // ---------------- Utility Class ----------------
    class BankUtility
    {
        public static void Main()
        {
            BankAccount acc1 = new SavingsAccount();
            BankAccount acc2 = new CheckingAccount();
            BankAccount acc3 = new FixedDepositAccount();

            ((SavingsAccount)acc1).DisplayAccountType();
            ((CheckingAccount)acc2).DisplayAccountType();
            ((FixedDepositAccount)acc3).DisplayAccountType();
        }
    }
}
