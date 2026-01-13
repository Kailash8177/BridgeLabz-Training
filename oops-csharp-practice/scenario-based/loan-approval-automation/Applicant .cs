using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace loan_approval_automation
{
    internal class Applicant
    {
        private string name;
        private int creditScore;
        private double income;

        public Applicant(string name, int creditScore, double income)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
        }

        public string Name => name;

        // 🔑 Accessible inside LoanApplication & child classes
        protected internal int CreditScore => creditScore;
        protected internal double Income => income;
    }

}
