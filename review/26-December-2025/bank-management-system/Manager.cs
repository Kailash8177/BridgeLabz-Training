using System;
using System.Collections.Generic;
using System.Text;

namespace bank_management_system
{
    internal class Manager
    {
        public IBankAccount OpenAccount()
        {
            Console.WriteLine("Enter the AccNumber of the user");
            string accNo = Console.ReadLine();

            Console.WriteLine("Enter the initial balance");
            double bal = double.Parse(Console.ReadLine());

            Console.WriteLine("Account is SuccesFully Opend");
            return new SavingAccount(accNo, bal);
        }

        public void ShowTheDetails(Bank bank,IBankAccount account)
        {
            Console.WriteLine("Bank name :" + Bank.BankName);
            Console.WriteLine("Bank branch name: "+ Bank.BranchName);
            Console.WriteLine("Bank IFSC: "+ Bank.IFSC);
            Console.WriteLine("Account number: " + account.GetAccountNumber());
            Console.WriteLine("Account balance: "+ account.GetBalance());
        }
    }
}
