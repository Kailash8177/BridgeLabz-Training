using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    public interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

}
