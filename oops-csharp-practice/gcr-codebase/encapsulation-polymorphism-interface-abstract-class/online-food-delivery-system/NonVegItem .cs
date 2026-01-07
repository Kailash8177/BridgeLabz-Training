using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Food_Delivery_System
{
    public class NonVegItem : FoodItem, IDiscountable
    {
        private const double ExtraCharge = 50;   // non-veg handling charge
        private const double DiscountRate = 0.05; // 5%

        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + ExtraCharge;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * DiscountRate;
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Item Discount: 5%";
        }
    }

}
