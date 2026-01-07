using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce_platform
{
    public class Groceries : Product
    {
        public override double CalculateDiscount()
        {
            return GetPrice() * 0.05; // 5% discount
        }
    }

}
