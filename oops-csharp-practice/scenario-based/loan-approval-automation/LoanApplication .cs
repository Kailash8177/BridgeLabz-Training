using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace loan_approval_automation
{
    abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected double loanAmount;
        protected int termMonths;
        protected double annualInterestRate;

        private bool isApproved; // INTERNAL CONTROL

        protected LoanApplication(Applicant applicant,
                                  double loanAmount,
                                  int termMonths,
                                  double annualInterestRate)
        {
            this.applicant = applicant;
            this.loanAmount = loanAmount;
            this.termMonths = termMonths;
            this.annualInterestRate = annualInterestRate;
        }

        protected bool BasicEligibilityCheck()
        {
            return applicant.CreditScore >= 650 &&
                   applicant.Income >= loanAmount / 10;
        }

        protected void SetApprovalStatus(bool status)
        {
            isApproved = status;
        }

        public bool IsApproved => isApproved;

        protected double MonthlyInterestRate =>
            (annualInterestRate / 12) / 100;

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }


}
