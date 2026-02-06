using System;
using System.Collections.Generic;
using System.Text;

namespace bank_management_system
{
    internal class SavingAccount: BankAccount
    {
        public SavingAccount(string account,double balance):base(account,balance) { }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("Successfully withdraw saving account");
            base.Withdraw(amount);
        }
    }
}
