using System;
using System.Collections.Generic;
using System.Text;

namespace loan_approval_automation
{
    internal class Utility
    {
        public static void Main()
        {
            Applicant applicant = new Applicant(
                "Rahul Sharma", 720, 60000);

            LoanApplication loan =
                new HomeLoan(applicant, 2000000, 240);

            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved");
                Console.WriteLine($" Monthly EMI: {Math.Round(loan.CalculateEMI())}");
            }
            else
            {
                Console.WriteLine(" Loan Rejected");
            }
        }
    }
}
