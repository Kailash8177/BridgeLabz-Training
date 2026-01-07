using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Food_Delivery_System
{
    public class VegItem : FoodItem, IDiscountable
    {
        private const double DiscountRate = 0.10; // 10%

        public VegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * DiscountRate;
        }

        public string GetDiscountDetails()
        {
            return "Veg Item Discount: 10%";
        }
    }

}
