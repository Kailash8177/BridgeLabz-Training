using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{
    class Bank
    {
        public string BankName;

        public Bank(string name)
        {
            BankName = name;
        }

        public void OpenAccount(Customer customer)
        {
            Console.WriteLine($"{customer.Name} opened account in {BankName}");
        }
    }

    // ---------------- Customer ----------------
    class Customer
    {
        public string Name;
        public double Balance;
        public Bank Bank; // Association

        public Customer(string name, double balance, Bank bank)
        {
            Name = name;
            Balance = balance;
            Bank = bank;
        }

        public void ViewBalance()
        {
            Console.WriteLine($"{Name}'s balance: {Balance}");
        }
    }

    // ---------------- Utility ----------------
    class BankUtility
    {
        public static void Main()
        {
            Bank bank = new Bank("SBI");
            Customer c1 = new Customer("Amit", 5000, bank);

            bank.OpenAccount(c1);
            c1.ViewBalance();
        }
    }
}
