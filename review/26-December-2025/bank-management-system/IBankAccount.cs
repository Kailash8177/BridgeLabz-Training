using System;
using System.Collections.Generic;
using System.Text;

namespace bank_management_system
{
    internal interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double GetBalance();

        string GetAccountNumber();
    }
}
