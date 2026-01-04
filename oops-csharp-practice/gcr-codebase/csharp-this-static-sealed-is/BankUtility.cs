using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class BankUtility
    {
        public static void Main()
        {
            object acc = new BankAccount("Amit", 101);

            // is operator check
            if (acc is BankAccount)
            {
                ((BankAccount)acc).Display();
            }

            BankAccount.GetTotalAccounts();
        }
    }
    public class BankAccount
    {
        // static variable (shared across all accounts)
        public static string BankName = "State Bank";
        private static int totalAccounts = 0;

        // readonly variable (cannot be changed after assignment)
        public readonly int AccountNumber;

        public string AccountHolderName;

        // Constructor using 'this'
        public BankAccount(string accountHolderName, int accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            totalAccounts++;
        }

        // static method
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts: " + totalAccounts);
        }

        public void Display()
        {
            Console.WriteLine($"{BankName} | {AccountHolderName} | {AccountNumber}");
        }
    }

}
