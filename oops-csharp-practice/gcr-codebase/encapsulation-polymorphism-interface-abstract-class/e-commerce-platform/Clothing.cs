using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce_platform
{
    public class Clothing : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return GetPrice() * 0.20; // 20% discount
        }

        public double CalculateTax()
        {
            return GetPrice() * 0.12; // 12% GST
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax: 12% GST";
        }
    }

}
