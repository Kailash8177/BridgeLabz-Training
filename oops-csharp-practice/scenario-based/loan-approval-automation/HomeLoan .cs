using System;
using System.Collections.Generic;
using System.Text;

namespace loan_approval_automation
{
    internal class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant,
                        double loanAmount,
                        int termMonths)
            : base(applicant, loanAmount, termMonths, 8.5)
        {
        }

        public override bool ApproveLoan()
        {
            bool eligible = BasicEligibilityCheck() &&
                            applicant.CreditScore >= 700;

            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI()
        {
            double r = MonthlyInterestRate;
            double n = termMonths;

            return (loanAmount * r * Math.Pow(1 + r, n)) /
                   (Math.Pow(1 + r, n) - 1);
        }
    }


}
