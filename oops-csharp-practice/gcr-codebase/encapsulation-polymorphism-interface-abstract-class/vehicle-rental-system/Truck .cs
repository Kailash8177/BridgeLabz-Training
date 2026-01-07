using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    public class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Truck(string number, double rate, string policyNo)
            : base(number, "Truck", rate)
        {
            insurancePolicyNumber = policyNo;
        }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) + 1000; // heavy vehicle charge
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public string GetInsuranceDetails()
        {
            return $"Truck Insurance | Policy No: ****{insurancePolicyNumber[^3..]}";
        }
    }

}
