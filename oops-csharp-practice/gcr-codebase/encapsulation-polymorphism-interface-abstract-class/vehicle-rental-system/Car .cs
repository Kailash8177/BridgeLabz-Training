using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    public class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(string number, double rate, string policyNo)
            : base(number, "Car", rate)
        {
            insurancePolicyNumber = policyNo;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500; // flat insurance
        }

        public string GetInsuranceDetails()
        {
            return $"Car Insurance | Policy No: ****{insurancePolicyNumber[^3..]}";
        }
    }

}
