using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Food_Delivery_System
{
    public class Utility
    {
        public
    static void Main()
        {
            List<FoodItem> order = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

            foreach (FoodItem item in order)
            {
                item.GetItemDetails();
                double total = item.CalculateTotalPrice();
                Console.WriteLine($"Total Price: ₹{total}");

                if (item is IDiscountable discountable)
                {
                    Console.WriteLine(discountable.GetDiscountDetails());
                    Console.WriteLine($"Discount Amount: ₹{discountable.ApplyDiscount()}");
                }

                Console.WriteLine("----------------------------------");
            }
        }
    }
}
