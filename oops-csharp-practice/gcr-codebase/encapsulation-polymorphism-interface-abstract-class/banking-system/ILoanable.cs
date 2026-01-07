using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    public interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

}
