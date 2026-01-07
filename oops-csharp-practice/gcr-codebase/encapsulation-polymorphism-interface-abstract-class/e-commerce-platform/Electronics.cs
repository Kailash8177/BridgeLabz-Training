using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce_platform
{
    public class Electronics : Product, ITaxable
    {
        public override double CalculateDiscount()
        {
            return GetPrice() * 0.10; // 10% discount
        }

        public double CalculateTax()
        {
            return GetPrice() * 0.18; // 18% GST
        }

        public string GetTaxDetails()
        {
            return "Electronics Tax: 18% GST";
        }
    }

}
