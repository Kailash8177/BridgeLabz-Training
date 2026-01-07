using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    public class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Bike(string number, double rate, string policyNo)
            : base(number, "Bike", rate)
        {
            insurancePolicyNumber = policyNo;
        }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) * 0.9; // 10% discount
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public string GetInsuranceDetails()
        {
            return $"Bike Insurance | Policy No: ****{insurancePolicyNumber[^3..]}";
        }
    }

}
